//-----------------------------------------------------------------------
// <copyright file="CollectionPickDialog.cs">
//     Copyright (c) Janis Fliegenschmidt
// </copyright>
//-----------------------------------------------------------------------

namespace com.romiox.CollectionPicker
{
    using System;
    using System.Collections;
    using System.Windows.Forms;

    /// <summary>
    /// Dialog that lets a user pick an item from a collection.
    /// </summary>
    public partial class CollectionPickDialog : Form
    {
        private Boolean okRequiresSelection = true;

        public CollectionPickDialog(ICollection collection = null)
        {
            this.InitializeComponent();
            this.cpPicker.SelectedItemChanged += (sender, args) =>
                {
                    if (this.okRequiresSelection && this.cpPicker.IsItemSelected)
                    {
                        this.btOk.Enabled = true;
                    }
                    else
                    {
                        this.btOk.Enabled = false;
                    }
                };

            this.cpPicker.Collection = collection;
            this.cpPicker.Refresh();
        }

        public Object SelectedItem
        {
            get
            {
                return this.cpPicker.SelectedItem;
            }
        }

        public ICollection Collection
        {
            get
            {
                return this.cpPicker.Collection;
            }

            set
            {
                this.cpPicker.Collection = value;
                this.cpPicker.Refresh();
            }
        }

        public Boolean OkRequiresSelection
        {
            get
            {
                return this.okRequiresSelection;
            }

            set
            {
                this.btOk.Enabled = (this.okRequiresSelection = value) ? this.cpPicker.IsItemSelected : true;
            }
        }

        public static Object PromptSelection(ICollection collection, Boolean okRequiresSelection = true)
        {
            Object result = null;
            using (CollectionPickDialog cpd = new CollectionPickDialog(collection))
            {
                cpd.OkRequiresSelection = okRequiresSelection;
                DialogResult dr = cpd.ShowDialog();

                result = dr == DialogResult.OK ? cpd.SelectedItem : null;
            }

            return result;
        }
    }
}
