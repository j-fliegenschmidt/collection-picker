namespace com.romiox.CollectionPickerDemo
{
    partial class CollectionPickerDemoForm
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
            this.collectionPicker = new com.romiox.CollectionPicker.CollectionPicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // collectionPicker
            // 
            this.collectionPicker.Collection = null;
            this.collectionPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.collectionPicker.Location = new System.Drawing.Point(0, 0);
            this.collectionPicker.Name = "collectionPicker";
            this.collectionPicker.OmitNull = false;
            this.collectionPicker.Size = new System.Drawing.Size(285, 184);
            this.collectionPicker.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Launch Dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btLaunchDialog_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Simple";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btSimpleSample_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Inheritance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btInheritanceSample_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Dictionaries";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btDictSample_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(146, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Launch Dialog Static";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btLaunchDialogStatic_Click);
            // 
            // CollectionPickerDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 250);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.collectionPicker);
            this.Name = "CollectionPickerDemoForm";
            this.Text = "Collection Picker Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private com.romiox.CollectionPicker.CollectionPicker collectionPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

