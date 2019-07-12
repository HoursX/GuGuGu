namespace GuGuGu
{
    partial class CustomerMaintain
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
            this.CustomerMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnDelCustomer = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnUpdCustomer = new System.Windows.Forms.Button();
            this.BtnQueCustomer = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbTip = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbCustomerID = new System.Windows.Forms.TextBox();
            this.TbCustomerCre = new System.Windows.Forms.TextBox();
            this.TbCustomerNote = new System.Windows.Forms.TextBox();
            this.TbCustomerTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCustomerAddr = new System.Windows.Forms.TextBox();
            this.LbNote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerMain
            // 
            this.CustomerMain.BackgroundColor = System.Drawing.Color.White;
            this.CustomerMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerMain.Location = new System.Drawing.Point(9, 9);
            this.CustomerMain.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerMain.Name = "CustomerMain";
            this.CustomerMain.RowTemplate.Height = 27;
            this.CustomerMain.Size = new System.Drawing.Size(749, 544);
            this.CustomerMain.TabIndex = 0;
            this.CustomerMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerMain_CellClick);
            this.CustomerMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerMain_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CustomerMain);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 564);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.BtnOk);
            this.panel2.Location = new System.Drawing.Point(763, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 544);
            this.panel2.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(287, 499);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(87, 23);
            this.BtnExit.TabIndex = 32;
            this.BtnExit.Text = "退出操作模式";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddCustomer);
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.BtnDelCustomer);
            this.groupBox1.Controls.Add(this.BtnExcel);
            this.groupBox1.Controls.Add(this.BtnUpdCustomer);
            this.groupBox1.Controls.Add(this.BtnQueCustomer);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 102);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作模式";
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(12, 20);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.BtnAddCustomer.TabIndex = 0;
            this.BtnAddCustomer.Text = "新增客户";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(113, 73);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 11;
            this.BtnRefresh.Text = "更新列表";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnDelCustomer
            // 
            this.BtnDelCustomer.Location = new System.Drawing.Point(113, 20);
            this.BtnDelCustomer.Name = "BtnDelCustomer";
            this.BtnDelCustomer.Size = new System.Drawing.Size(75, 23);
            this.BtnDelCustomer.TabIndex = 1;
            this.BtnDelCustomer.Text = "删除客户";
            this.BtnDelCustomer.UseVisualStyleBackColor = true;
            this.BtnDelCustomer.Click += new System.EventHandler(this.BtnDelCustomer_Click);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(12, 73);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(75, 23);
            this.BtnExcel.TabIndex = 10;
            this.BtnExcel.Text = "表格导出";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnUpdCustomer
            // 
            this.BtnUpdCustomer.Location = new System.Drawing.Point(210, 20);
            this.BtnUpdCustomer.Name = "BtnUpdCustomer";
            this.BtnUpdCustomer.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdCustomer.TabIndex = 2;
            this.BtnUpdCustomer.Text = "信息更新";
            this.BtnUpdCustomer.UseVisualStyleBackColor = true;
            this.BtnUpdCustomer.Click += new System.EventHandler(this.BtnUpdCustomer_Click);
            // 
            // BtnQueCustomer
            // 
            this.BtnQueCustomer.Location = new System.Drawing.Point(311, 20);
            this.BtnQueCustomer.Name = "BtnQueCustomer";
            this.BtnQueCustomer.Size = new System.Drawing.Size(75, 23);
            this.BtnQueCustomer.TabIndex = 3;
            this.BtnQueCustomer.Text = "查询客户";
            this.BtnQueCustomer.UseVisualStyleBackColor = true;
            this.BtnQueCustomer.Click += new System.EventHandler(this.BtnQueCustomer_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(46, 501);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(79, 21);
            this.BtnOk.TabIndex = 17;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbTip);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TbCustomerID);
            this.groupBox2.Controls.Add(this.TbCustomerCre);
            this.groupBox2.Controls.Add(this.TbCustomerNote);
            this.groupBox2.Controls.Add(this.TbCustomerTel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TbCustomerAddr);
            this.groupBox2.Controls.Add(this.LbNote);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TbCustomerName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(11, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 376);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前客户信息";
            // 
            // LbTip
            // 
            this.LbTip.AutoSize = true;
            this.LbTip.Location = new System.Drawing.Point(274, 26);
            this.LbTip.Name = "LbTip";
            this.LbTip.Size = new System.Drawing.Size(89, 12);
            this.LbTip.TabIndex = 46;
            this.LbTip.Text = "请选择操作模式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "客户积分：";
            // 
            // TbCustomerID
            // 
            this.TbCustomerID.Location = new System.Drawing.Point(90, 23);
            this.TbCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.TbCustomerID.Name = "TbCustomerID";
            this.TbCustomerID.Size = new System.Drawing.Size(179, 21);
            this.TbCustomerID.TabIndex = 35;
            // 
            // TbCustomerCre
            // 
            this.TbCustomerCre.Location = new System.Drawing.Point(90, 190);
            this.TbCustomerCre.Name = "TbCustomerCre";
            this.TbCustomerCre.Size = new System.Drawing.Size(179, 21);
            this.TbCustomerCre.TabIndex = 44;
            // 
            // TbCustomerNote
            // 
            this.TbCustomerNote.Location = new System.Drawing.Point(90, 230);
            this.TbCustomerNote.Multiline = true;
            this.TbCustomerNote.Name = "TbCustomerNote";
            this.TbCustomerNote.Size = new System.Drawing.Size(290, 124);
            this.TbCustomerNote.TabIndex = 43;
            // 
            // TbCustomerTel
            // 
            this.TbCustomerTel.Location = new System.Drawing.Point(90, 150);
            this.TbCustomerTel.Name = "TbCustomerTel";
            this.TbCustomerTel.Size = new System.Drawing.Size(179, 21);
            this.TbCustomerTel.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "客户编号：";
            // 
            // TbCustomerAddr
            // 
            this.TbCustomerAddr.Location = new System.Drawing.Point(90, 109);
            this.TbCustomerAddr.Name = "TbCustomerAddr";
            this.TbCustomerAddr.Size = new System.Drawing.Size(179, 21);
            this.TbCustomerAddr.TabIndex = 41;
            // 
            // LbNote
            // 
            this.LbNote.AutoSize = true;
            this.LbNote.Location = new System.Drawing.Point(43, 233);
            this.LbNote.Name = "LbNote";
            this.LbNote.Size = new System.Drawing.Size(41, 12);
            this.LbNote.TabIndex = 40;
            this.LbNote.Text = "备注：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "客户姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "客户电话：";
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Location = new System.Drawing.Point(90, 66);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.Size = new System.Drawing.Size(179, 21);
            this.TbCustomerName.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "客户地址：";
            // 
            // CustomerMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 588);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1239, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1239, 627);
            this.Name = "CustomerMaintain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuGuGu超市收银系统 - 客户信息维护";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customermaintain_FormClosed);
            this.Load += new System.EventHandler(this.Customermaintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnDelCustomer;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Button BtnUpdCustomer;
        private System.Windows.Forms.Button BtnQueCustomer;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbCustomerID;
        private System.Windows.Forms.TextBox TbCustomerCre;
        private System.Windows.Forms.TextBox TbCustomerNote;
        private System.Windows.Forms.TextBox TbCustomerTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCustomerAddr;
        private System.Windows.Forms.Label LbNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label label3;
    }
}