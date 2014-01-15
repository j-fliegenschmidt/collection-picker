//-----------------------------------------------------------------------
// <copyright file="CollectionPickerDemoForm.cs">
//     Copyright (c) Janis Fliegenschmidt
// </copyright>
//-----------------------------------------------------------------------

namespace com.romiox.CollectionPickerDemo
{
    using com.romiox.CollectionPicker;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    public partial class CollectionPickerDemoForm : Form
    {
        public CollectionPickerDemoForm()
        {
            this.InitializeComponent();
        }

        private void btLaunchDialog_Click(object sender, EventArgs e)
        {
            new CollectionPickDialog(new Dictionary<int, String>() { { 1, "a" }, { 2, "b" } }).ShowDialog();
        }

        private void btLaunchDialogStatic_Click(object sender, EventArgs e)
        {
            Object selected = CollectionPickDialog.PromptSelection(new Dictionary<int, String>() { { 1, "a" }, { 2, "b" } });
        }

        private void btSimpleSample_Click(object sender, EventArgs e)
        {
            this.collectionPicker.AddDescriptor(typeof(StringBuilder), (o) => { return "fromDelegate: " + o.ToString(); });
            this.collectionPicker.Collection = new List<Object>() { "ha", "ll", "o", new StringBuilder("hello"), null };
            this.collectionPicker.Refresh();
        }

        private void btDictSample_Click(object sender, EventArgs e)
        {
            this.collectionPicker.AddDescriptor(typeof(KeyValuePair<int, String>), (o) => { return "fromDelegate:" + o.ToString(); });
            this.collectionPicker.Collection = new Dictionary<int, String>() { { 1, "a" }, { 2, "b" } };
            this.collectionPicker.Refresh();
        }

        private void btInheritanceSample_Click(object sender, EventArgs e)
        {
            this.collectionPicker.AddDescriptor(typeof(A), (o) => { return "from Delegate 1: " + ((A)o).ToString().Remove(0, 57); });
            this.collectionPicker.AddDescriptor(typeof(C), (o) => { return "from Delegate 2: " + ((B)o).ToString().Remove(0, 57); });
            this.collectionPicker.Collection = new List<Object>() { new A(), new B(), new C() };
            this.collectionPicker.Refresh();
        }

        private class A
        {
        }

        private class B : A
        {
        }

        private class C : B
        {
        }
    }
}
