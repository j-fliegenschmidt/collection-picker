namespace com.romiox.CollectionPicker
{
    partial class CollectionPickDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scRoot = new System.Windows.Forms.SplitContainer();
            this.cpPicker = new com.romiox.CollectionPicker.CollectionPicker();
            this.scBottom = new System.Windows.Forms.SplitContainer();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scRoot)).BeginInit();
            this.scRoot.Panel1.SuspendLayout();
            this.scRoot.Panel2.SuspendLayout();
            this.scRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBottom)).BeginInit();
            this.scBottom.Panel2.SuspendLayout();
            this.scBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // scRoot
            // 
            this.scRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scRoot.IsSplitterFixed = true;
            this.scRoot.Location = new System.Drawing.Point(0, 0);
            this.scRoot.Name = "scRoot";
            this.scRoot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRoot.Panel1
            // 
            this.scRoot.Panel1.Controls.Add(this.cpPicker);
            // 
            // scRoot.Panel2
            // 
            this.scRoot.Panel2.Controls.Add(this.scBottom);
            this.scRoot.Size = new System.Drawing.Size(351, 258);
            this.scRoot.SplitterDistance = 225;
            this.scRoot.TabIndex = 1;
            // 
            // cpPicker
            // 
            this.cpPicker.Collection = null;
            this.cpPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpPicker.Location = new System.Drawing.Point(0, 0);
            this.cpPicker.Name = "cpPicker";
            this.cpPicker.OmitNull = false;
            this.cpPicker.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cpPicker.Size = new System.Drawing.Size(351, 225);
            this.cpPicker.TabIndex = 0;
            // 
            // scBottom
            // 
            this.scBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scBottom.IsSplitterFixed = true;
            this.scBottom.Location = new System.Drawing.Point(0, 0);
            this.scBottom.Name = "scBottom";
            // 
            // scBottom.Panel2
            // 
            this.scBottom.Panel2.Controls.Add(this.btCancel);
            this.scBottom.Panel2.Controls.Add(this.btOk);
            this.scBottom.Size = new System.Drawing.Size(351, 29);
            this.scBottom.SplitterDistance = 183;
            this.scBottom.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(84, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // CollectionPickDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 258);
            this.Controls.Add(this.scRoot);
            this.Name = "CollectionPickDialog";
            this.Text = "CollectionPickDialog";
            this.scRoot.Panel1.ResumeLayout(false);
            this.scRoot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRoot)).EndInit();
            this.scRoot.ResumeLayout(false);
            this.scBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBottom)).EndInit();
            this.scBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CollectionPicker cpPicker;
        private System.Windows.Forms.SplitContainer scRoot;
        private System.Windows.Forms.SplitContainer scBottom;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}