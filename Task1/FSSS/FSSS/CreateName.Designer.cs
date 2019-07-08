namespace FSSS
{
    partial class CreateName
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldNameBox = new System.Windows.Forms.TextBox();
            this.NewNameBox = new System.Windows.Forms.TextBox();
            this._ChangeNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter old Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter new Name";
            // 
            // OldNameBox
            // 
            this.OldNameBox.Location = new System.Drawing.Point(113, 29);
            this.OldNameBox.Name = "OldNameBox";
            this.OldNameBox.Size = new System.Drawing.Size(153, 20);
            this.OldNameBox.TabIndex = 2;
            // 
            // NewNameBox
            // 
            this.NewNameBox.Location = new System.Drawing.Point(113, 84);
            this.NewNameBox.Name = "NewNameBox";
            this.NewNameBox.Size = new System.Drawing.Size(153, 20);
            this.NewNameBox.TabIndex = 3;
            // 
            // _ChangeNameBtn
            // 
            this._ChangeNameBtn.Location = new System.Drawing.Point(104, 141);
            this._ChangeNameBtn.Name = "_ChangeNameBtn";
            this._ChangeNameBtn.Size = new System.Drawing.Size(75, 23);
            this._ChangeNameBtn.TabIndex = 4;
            this._ChangeNameBtn.Text = "Change";
            this._ChangeNameBtn.UseVisualStyleBackColor = true;
            this._ChangeNameBtn.Click += new System.EventHandler(this.ChangeNameBtn_Click);
            // 
            // CreateName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 182);
            this.Controls.Add(this._ChangeNameBtn);
            this.Controls.Add(this.NewNameBox);
            this.Controls.Add(this.OldNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateName";
            this.Text = "CreateName";
            this.Load += new System.EventHandler(this.CreateName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OldNameBox;
        private System.Windows.Forms.TextBox NewNameBox;
        private System.Windows.Forms.Button _ChangeNameBtn;
    }
}