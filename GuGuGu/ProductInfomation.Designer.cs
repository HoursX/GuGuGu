namespace GuGuGu
{
    partial class ProductInfomation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.GbSelect = new System.Windows.Forms.GroupBox();
            this.RbNO = new System.Windows.Forms.RadioButton();
            this.RbOK = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TbValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbTip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbProductID = new System.Windows.Forms.TextBox();
            this.TbUnitPrice = new System.Windows.Forms.TextBox();
            this.TbProductName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCategoryName = new System.Windows.Forms.ComboBox();
            this.CbxCompanyName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbSelect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DGVProduct);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 571);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(752, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 563);
            this.panel2.TabIndex = 28;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(291, 463);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 30;
            this.BtnExit.Text = "退出操作";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.GbSelect);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TbValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LbTip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TbProductID);
            this.groupBox2.Controls.Add(this.TbUnitPrice);
            this.groupBox2.Controls.Add(this.TbProductName);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CbxCategoryName);
            this.groupBox2.Controls.Add(this.CbxCompanyName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 304);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前商品信息";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(264, 265);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 33;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // GbSelect
            // 
            this.GbSelect.Controls.Add(this.RbNO);
            this.GbSelect.Controls.Add(this.RbOK);
            this.GbSelect.Location = new System.Drawing.Point(86, 255);
            this.GbSelect.Name = "GbSelect";
            this.GbSelect.Size = new System.Drawing.Size(158, 36);
            this.GbSelect.TabIndex = 32;
            this.GbSelect.TabStop = false;
            // 
            // RbNO
            // 
            this.RbNO.AutoSize = true;
            this.RbNO.Location = new System.Drawing.Point(107, 15);
            this.RbNO.Name = "RbNO";
            this.RbNO.Size = new System.Drawing.Size(35, 16);
            this.RbNO.TabIndex = 1;
            this.RbNO.TabStop = true;
            this.RbNO.Text = "否";
            this.RbNO.UseVisualStyleBackColor = true;
            // 
            // RbOK
            // 
            this.RbOK.AutoSize = true;
            this.RbOK.Location = new System.Drawing.Point(12, 15);
            this.RbOK.Name = "RbOK";
            this.RbOK.Size = new System.Drawing.Size(35, 16);
            this.RbOK.TabIndex = 0;
            this.RbOK.TabStop = true;
            this.RbOK.Text = "是";
            this.RbOK.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "折扣：";
            // 
            // TbValue
            // 
            this.TbValue.Location = new System.Drawing.Point(87, 228);
            this.TbValue.Name = "TbValue";
            this.TbValue.Size = new System.Drawing.Size(157, 21);
            this.TbValue.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "阈值：";
            // 
            // LbTip
            // 
            this.LbTip.AutoSize = true;
            this.LbTip.Location = new System.Drawing.Point(262, 27);
            this.LbTip.Name = "LbTip";
            this.LbTip.Size = new System.Drawing.Size(89, 12);
            this.LbTip.TabIndex = 28;
            this.LbTip.Text = "请选择操作模式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "商品号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "商品名：";
            // 
            // TbProductID
            // 
            this.TbProductID.Enabled = false;
            this.TbProductID.Location = new System.Drawing.Point(88, 23);
            this.TbProductID.Name = "TbProductID";
            this.TbProductID.Size = new System.Drawing.Size(156, 21);
            this.TbProductID.TabIndex = 21;
            // 
            // TbUnitPrice
            // 
            this.TbUnitPrice.Location = new System.Drawing.Point(88, 189);
            this.TbUnitPrice.Name = "TbUnitPrice";
            this.TbUnitPrice.Size = new System.Drawing.Size(156, 21);
            this.TbUnitPrice.TabIndex = 23;
            // 
            // TbProductName
            // 
            this.TbProductName.Location = new System.Drawing.Point(88, 64);
            this.TbProductName.Name = "TbProductName";
            this.TbProductName.Size = new System.Drawing.Size(156, 21);
            this.TbProductName.TabIndex = 27;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(38, 192);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(41, 12);
            this.lblUnitPrice.TabIndex = 22;
            this.lblUnitPrice.Text = "单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "供应商：";
            // 
            // CbxCategoryName
            // 
            this.CbxCategoryName.FormattingEnabled = true;
            this.CbxCategoryName.Location = new System.Drawing.Point(88, 149);
            this.CbxCategoryName.Name = "CbxCategoryName";
            this.CbxCategoryName.Size = new System.Drawing.Size(156, 20);
            this.CbxCategoryName.TabIndex = 15;
            // 
            // CbxCompanyName
            // 
            this.CbxCompanyName.FormattingEnabled = true;
            this.CbxCompanyName.Location = new System.Drawing.Point(88, 105);
            this.CbxCompanyName.Name = "CbxCompanyName";
            this.CbxCompanyName.Size = new System.Drawing.Size(156, 20);
            this.CbxCompanyName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "类别名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAlter);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 115);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作模式";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "增加商品";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(113, 20);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 24;
            this.btnAlter.Text = "修改商品";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.BtnAlter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(211, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "查询商品";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "删除商品";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(16, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "刷新列表";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(55, 463);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // DGVProduct
            // 
            this.DGVProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Location = new System.Drawing.Point(3, 3);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.RowTemplate.Height = 23;
            this.DGVProduct.Size = new System.Drawing.Size(743, 563);
            this.DGVProduct.TabIndex = 19;
            this.DGVProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProduct_CellClick);
            this.DGVProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProduct_CellDoubleClick);
            // 
            // ProductInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 588);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductInfomation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuGuGu超市收银系统 - 商品信息维护";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductInfomation_FormClosed);
            this.Load += new System.EventHandler(this.ProductInfomation_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbSelect.ResumeLayout(false);
            this.GbSelect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox CbxCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVProduct;
        private System.Windows.Forms.TextBox TbProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.TextBox TbUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox TbProductName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbTip;
        private System.Windows.Forms.GroupBox GbSelect;
        private System.Windows.Forms.RadioButton RbNO;
        private System.Windows.Forms.RadioButton RbOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClear;
    }
}