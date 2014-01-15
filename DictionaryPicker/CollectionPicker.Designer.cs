//-----------------------------------------------------------------------
// <copyright file="CollectionPicker.Designer.cs">
//     Copyright (c) Janis Fliegenschmidt
// </copyright>
//-----------------------------------------------------------------------

namespace com.romiox.CollectionPicker
{
    public partial class CollectionPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDictPicker = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDictPicker
            // 
            this.lbDictPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDictPicker.FormattingEnabled = true;
            this.lbDictPicker.IntegralHeight = false;
            this.lbDictPicker.Location = new System.Drawing.Point(0, 0);
            this.lbDictPicker.Name = "lbDictPicker";
            this.lbDictPicker.Size = new System.Drawing.Size(349, 153);
            this.lbDictPicker.TabIndex = 0;
            // 
            // CollectionPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDictPicker);
            this.Name = "CollectionPicker";
            this.Size = new System.Drawing.Size(349, 153);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDictPicker;
    }
}
