//-----------------------------------------------------------------------
// <copyright file="CollectionPicker.cs">
//     Copyright (c) Janis Fliegenschmidt
// </copyright>
//-----------------------------------------------------------------------

namespace com.romiox.CollectionPicker
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Delegate that can be injected into the CollectionPicker and will be called
    /// instead of ToString().
    /// </summary>
    /// <param name="obj">The object to be described.</param>
    /// <returns>A string describing the object.</returns>
    public delegate String TypeDescriptionDelegate(Object obj);

    /// <summary>
    /// UserControl to let a user pick from a collection.
    /// </summary>
    public partial class CollectionPicker : UserControl
    {
        private static Dictionary<Type, TypeDescriptionDelegate> globalDescriptors;
        private Dictionary<Type, TypeDescriptionDelegate> localDescriptors;
        private ICollection collection;

        /// <summary>
        /// Fires when the selected item changes.
        /// </summary>
        public event EventHandler SelectedItemChanged;

        /// <summary>
        /// Initializes a new instance of theC CollectionPicker class.
        /// </summary>
        public CollectionPicker()
        {
            this.InitializeComponent();

            this.OmitNull = true;
            this.lbDictPicker.SelectedIndexChanged += (s, e) => this.OnSelectedIndexChanged(this, e);
        }

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        public ICollection Collection
        {
            get
            {
                return this.collection;
            }

            set
            {
                this.collection = value;
            }
        }

        /// <summary>
        /// Gets the currently selected item.
        /// </summary>
        public Object SelectedItem
        {
            get
            {
                int index = this.lbDictPicker.SelectedIndex;
                if (index < 0 || index > this.collection.Count - 1)
                {
                    return null;
                }
                else
                {
                    IEnumerator enumerator = this.collection.GetEnumerator();
                    enumerator.Reset();

                    for (int i = 0; i <= index; i++)
                    {
                        enumerator.MoveNext();
                    }

                    return enumerator.Current;
                }
            }
        }

        /// <summary>
        /// Registers a new type descriptor.
        /// </summary>
        /// <param name="type">The type the delegate describes.</param>
        /// <param name="descriptor">The TypeDescriptionDelegate.</param>
        /// <param name="global">Whether to register it globally or for this instance only.</param>
        public void AddDescriptor(Type type, TypeDescriptionDelegate descriptor, Boolean global = false)
        {
            if (descriptor != null)
            {
                (global ? this.GlobalDescriptors : this.LocalDescriptors).Add(type, descriptor);
            }
            else
            {
                this.RemoveTypeDescriptor(type, global);
            }
        }

        /// <summary>
        /// Removes the descriptor for a given type.
        /// </summary>
        /// <param name="type">The type the discriptor is asociated with.</param>
        /// <param name="global">Whether to remove the descriptor from the global or instance list.</param>
        public void RemoveTypeDescriptor(Type type, Boolean global = false)
        {
            (global ? this.GlobalDescriptors : this.LocalDescriptors).Remove(type);
        }

        /// <summary>
        /// Determines whether null values will presented for selection. Initial value: true.
        /// </summary>
        public Boolean OmitNull { get; set; }

        /// <summary>
        /// Gets whether an item was selected. If null is an allowed value, this can be used to check
        /// whether it was a legitimate choice or the absence of a choice.
        /// </summary>
        public Boolean IsItemSelected
        {
            get
            {
                return (this.lbDictPicker.SelectedIndex >= 0 && this.lbDictPicker.SelectedIndex < this.collection.Count);
            }
        }

        private Dictionary<Type, TypeDescriptionDelegate> LocalDescriptors
        {
            get
            {
                if (this.localDescriptors == null)
                {
                    this.localDescriptors = new Dictionary<Type, TypeDescriptionDelegate>();
                }

                return this.localDescriptors;
            }
        }

        private Dictionary<Type, TypeDescriptionDelegate> GlobalDescriptors
        {
            get
            {
                if (globalDescriptors == null)
                {
                    globalDescriptors = new Dictionary<Type, TypeDescriptionDelegate>();
                }

                return globalDescriptors;
            }
        }

        private void OnSelectedIndexChanged(Object sender, EventArgs args)
        {
            if (this.SelectedItemChanged != null)
            {
                this.SelectedItemChanged(sender, args);
            }
        }

        /// <summary>
        /// Forces the control to invalidate its client area and data and immediately redraw itself
        /// and any child controls, taking changes to the displayed collection into account.
        /// </summary>
        new public void Refresh()
        {
            if (this.collection == null)
            {
                base.Refresh();
                return;
            }

            List<String> items = new List<String>();

            foreach (Object elem in this.collection)
            {
                if (elem == null)
                {
                    if (!this.OmitNull)
                    {
                        items.Add("<Null>");
                    }

                    continue;
                }

                List<Type> validTypes = new List<Type>();

                for (int i = 0; i < 2; i++)
                {
                    Dictionary<Type, TypeDescriptionDelegate> descriptors =
                        i == 0 ? this.LocalDescriptors : this.GlobalDescriptors;

                    foreach (Type t in descriptors.Keys)
                    {
                        if (t.IsAssignableFrom(elem.GetType()))
                        {
                            validTypes.Add(t);
                        }
                    }

                    if (validTypes.Count <= 0)
                    {
                        if (i == 0)
                        {
                            continue;
                        }
                        else
                        {
                            items.Add(elem.ToString());
                        }
                    }
                    else
                    {
                        for (int j = 0; j < validTypes.Count; j++)
                        {
                            for (int k = 0; k < validTypes.Count; k++)
                            {
                                if (!(k == j) && validTypes[j].IsAssignableFrom(validTypes[k]))
                                {
                                    validTypes.RemoveAt(j);
                                    j = 0;
                                    break;
                                }
                            }
                        }

                        items.Add(descriptors[validTypes[0]](elem));
                        break;
                    }
                }
            }

            this.lbDictPicker.Items.Clear();
            this.lbDictPicker.Items.AddRange(items.ToArray());

            base.Refresh();
        }
    }
}
