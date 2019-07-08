namespace FSSS
{
    partial class EditFile
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
            this._EditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OldTitleBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewTitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _EditBtn
            // 
            this._EditBtn.Location = new System.Drawing.Point(73, 157);
            this._EditBtn.Name = "_EditBtn";
            this._EditBtn.Size = new System.Drawing.Size(75, 23);
            this._EditBtn.TabIndex = 6;
            this._EditBtn.Text = "Edit";
            this._EditBtn.UseVisualStyleBackColor = true;
            this._EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Old title";
            // 
            // OldTitleBox
            // 
            this.OldTitleBox.Location = new System.Drawing.Point(81, 42);
            this.OldTitleBox.Name = "OldTitleBox";
            this.OldTitleBox.Size = new System.Drawing.Size(127, 20);
            this.OldTitleBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewTitleBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OldTitleBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._EditBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit title, please";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NewTitleBox
            // 
            this.NewTitleBox.Location = new System.Drawing.Point(81, 98);
            this.NewTitleBox.Name = "NewTitleBox";
            this.NewTitleBox.Size = new System.Drawing.Size(127, 20);
            this.NewTitleBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "New title";
            // 
            // EditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 237);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditFile";
            this.Text = "EditFile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _EditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldTitleBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NewTitleBox;
        private System.Windows.Forms.Label label2;
    }
}