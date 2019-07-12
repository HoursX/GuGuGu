namespace GuGuGu
{
    partial class UserFrom
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
            this.BtnChangePassWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxNewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnChangePassWord
            // 
            this.BtnChangePassWord.Location = new System.Drawing.Point(158, 247);
            this.BtnChangePassWord.Name = "BtnChangePassWord";
            this.BtnChangePassWord.Size = new System.Drawing.Size(75, 23);
            this.BtnChangePassWord.TabIndex = 0;
            this.BtnChangePassWord.Text = "修改密码";
            this.BtnChangePassWord.UseVisualStyleBackColor = true;
            this.BtnChangePassWord.Click += new System.EventHandler(this.BtnChangePassWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前用户ID：";
            // 
            // TbxEmployeeID
            // 
            this.TbxEmployeeID.Location = new System.Drawing.Point(158, 98);
            this.TbxEmployeeID.Name = "TbxEmployeeID";
            this.TbxEmployeeID.Size = new System.Drawing.Size(100, 21);
            this.TbxEmployeeID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // TbxPassWord
            // 
            this.TbxPassWord.Location = new System.Drawing.Point(158, 148);
            this.TbxPassWord.Name = "TbxPassWord";
            this.TbxPassWord.PasswordChar = '*';
            this.TbxPassWord.Size = new System.Drawing.Size(100, 21);
            this.TbxPassWord.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认新密码：";
            // 
            // TbxNewPassword
            // 
            this.TbxNewPassword.Location = new System.Drawing.Point(157, 190);
            this.TbxNewPassword.Name = "TbxNewPassword";
            this.TbxNewPassword.PasswordChar = '*';
            this.TbxNewPassword.Size = new System.Drawing.Size(100, 21);
            this.TbxNewPassword.TabIndex = 6;
            // 
            // UserFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 387);
            this.Controls.Add(this.TbxNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnChangePassWord);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserFrom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserFrom_FormClosed);
            this.Load += new System.EventHandler(this.UserFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChangePassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxNewPassword;
    }
}