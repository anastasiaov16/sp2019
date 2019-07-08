namespace FSSS
{
    partial class MainPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewProfileBtn = new System.Windows.Forms.Button();
            this.AddFileBtn = new System.Windows.Forms.Button();
            this.SendFileBtn = new System.Windows.Forms.Button();
            this.DeleteFileBtn = new System.Windows.Forms.Button();
            this.EditFileBtn = new System.Windows.Forms.Button();
            this.UpdateTableBtn = new System.Windows.Forms.Button();
            this.FindFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FindBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewProfileBtn
            // 
            this.ViewProfileBtn.Location = new System.Drawing.Point(393, 62);
            this.ViewProfileBtn.Name = "ViewProfileBtn";
            this.ViewProfileBtn.Size = new System.Drawing.Size(89, 28);
            this.ViewProfileBtn.TabIndex = 1;
            this.ViewProfileBtn.Text = "View profile";
            this.ViewProfileBtn.UseVisualStyleBackColor = true;
            this.ViewProfileBtn.Click += new System.EventHandler(this.ViewProfileBtn_Click);
            // 
            // AddFileBtn
            // 
            this.AddFileBtn.Location = new System.Drawing.Point(393, 112);
            this.AddFileBtn.Name = "AddFileBtn";
            this.AddFileBtn.Size = new System.Drawing.Size(86, 28);
            this.AddFileBtn.TabIndex = 3;
            this.AddFileBtn.Text = "Add file";
            this.AddFileBtn.UseVisualStyleBackColor = true;
            this.AddFileBtn.Click += new System.EventHandler(this.AddFileBtn_Click);
            // 
            // SendFileBtn
            // 
            this.SendFileBtn.Location = new System.Drawing.Point(393, 269);
            this.SendFileBtn.Name = "SendFileBtn";
            this.SendFileBtn.Size = new System.Drawing.Size(86, 28);
            this.SendFileBtn.TabIndex = 5;
            this.SendFileBtn.Text = "Send file";
            this.SendFileBtn.UseVisualStyleBackColor = true;
            this.SendFileBtn.Click += new System.EventHandler(this.SendFileBtn_Click);
            // 
            // DeleteFileBtn
            // 
            this.DeleteFileBtn.Location = new System.Drawing.Point(393, 216);
            this.DeleteFileBtn.Name = "DeleteFileBtn";
            this.DeleteFileBtn.Size = new System.Drawing.Size(86, 28);
            this.DeleteFileBtn.TabIndex = 7;
            this.DeleteFileBtn.Text = "Delete file";
            this.DeleteFileBtn.UseVisualStyleBackColor = true;
            this.DeleteFileBtn.Click += new System.EventHandler(this.DeleteFileBtn_Click);
            // 
            // EditFileBtn
            // 
            this.EditFileBtn.Location = new System.Drawing.Point(393, 165);
            this.EditFileBtn.Name = "EditFileBtn";
            this.EditFileBtn.Size = new System.Drawing.Size(86, 28);
            this.EditFileBtn.TabIndex = 9;
            this.EditFileBtn.Text = "Edite file";
            this.EditFileBtn.UseVisualStyleBackColor = true;
            this.EditFileBtn.Click += new System.EventHandler(this.EditFileBtn_Click);
            // 
            // UpdateTableBtn
            // 
            this.UpdateTableBtn.Location = new System.Drawing.Point(393, 318);
            this.UpdateTableBtn.Name = "UpdateTableBtn";
            this.UpdateTableBtn.Size = new System.Drawing.Size(86, 28);
            this.UpdateTableBtn.TabIndex = 11;
            this.UpdateTableBtn.Text = "Update table";
            this.UpdateTableBtn.UseVisualStyleBackColor = true;
            this.UpdateTableBtn.Click += new System.EventHandler(this.UpdateTableBtn_Click);
            // 
            // FindFileBtn
            // 
            this.FindFileBtn.Location = new System.Drawing.Point(277, 406);
            this.FindFileBtn.Name = "FindFileBtn";
            this.FindFileBtn.Size = new System.Drawing.Size(75, 28);
            this.FindFileBtn.TabIndex = 12;
            this.FindFileBtn.Text = "Find";
            this.FindFileBtn.UseVisualStyleBackColor = true;
            this.FindFileBtn.Click += new System.EventHandler(this.FindFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Find file";
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(72, 411);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(176, 20);
            this.FindBox.TabIndex = 14;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 449);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindFileBtn);
            this.Controls.Add(this.UpdateTableBtn);
            this.Controls.Add(this.EditFileBtn);
            this.Controls.Add(this.DeleteFileBtn);
            this.Controls.Add(this.SendFileBtn);
            this.Controls.Add(this.AddFileBtn);
            this.Controls.Add(this.ViewProfileBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewProfileBtn;
        private System.Windows.Forms.Button AddFileBtn;
        private System.Windows.Forms.Button SendFileBtn;
        private System.Windows.Forms.Button DeleteFileBtn;
        private System.Windows.Forms.Button EditFileBtn;
        private System.Windows.Forms.Button UpdateTableBtn;
        private System.Windows.Forms.Button FindFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindBox;
    }
}