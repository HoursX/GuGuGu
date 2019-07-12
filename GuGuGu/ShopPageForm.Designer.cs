namespace GuGuGu
{
    partial class ShopPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopPageForm));
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BtnPay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LbSum = new System.Windows.Forms.Label();
            this.LbTip = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbProID = new System.Windows.Forms.TextBox();
            this.TbProName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDiscount = new System.Windows.Forms.TextBox();
            this.TbQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.DGVProView = new System.Windows.Forms.DataGridView();
            this.ViewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPanel.Controls.Add(this.panel1);
            this.ViewPanel.Location = new System.Drawing.Point(12, 13);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1198, 563);
            this.ViewPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Controls.Add(this.DGVProView);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 554);
            this.panel1.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.BtnPay);
            this.MenuPanel.Controls.Add(this.label5);
            this.MenuPanel.Controls.Add(this.LbSum);
            this.MenuPanel.Controls.Add(this.LbTip);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Controls.Add(this.DGVStock);
            this.MenuPanel.Location = new System.Drawing.Point(595, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(590, 547);
            this.MenuPanel.TabIndex = 1;
            // 
            // BtnPay
            // 
            this.BtnPay.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPay.Location = new System.Drawing.Point(352, 495);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(88, 41);
            this.BtnPay.TabIndex = 5;
            this.BtnPay.Text = "结算";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(284, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "元";
            // 
            // LbSum
            // 
            this.LbSum.AutoSize = true;
            this.LbSum.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbSum.ForeColor = System.Drawing.Color.Red;
            this.LbSum.Location = new System.Drawing.Point(196, 504);
            this.LbSum.Name = "LbSum";
            this.LbSum.Size = new System.Drawing.Size(54, 21);
            this.LbSum.TabIndex = 3;
            this.LbSum.Text = "0.00";
            // 
            // LbTip
            // 
            this.LbTip.AutoSize = true;
            this.LbTip.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbTip.Location = new System.Drawing.Point(111, 504);
            this.LbTip.Name = "LbTip";
            this.LbTip.Size = new System.Drawing.Size(94, 21);
            this.LbTip.TabIndex = 2;
            this.LbTip.Text = "总金额：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnDel);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 465);
            this.panel2.TabIndex = 1;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(130, 380);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 11;
            this.BtnDel.Text = "移除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(23, 380);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "加入";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TbUnitPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TbProID);
            this.groupBox2.Controls.Add(this.TbProName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TbDiscount);
            this.groupBox2.Controls.Add(this.TbQuantity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 242);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前选择商品信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "单价：";
            // 
            // TbUnitPrice
            // 
            this.TbUnitPrice.Location = new System.Drawing.Point(55, 104);
            this.TbUnitPrice.Name = "TbUnitPrice";
            this.TbUnitPrice.Size = new System.Drawing.Size(142, 21);
            this.TbUnitPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "商品号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名：";
            // 
            // TbProID
            // 
            this.TbProID.Location = new System.Drawing.Point(55, 32);
            this.TbProID.Name = "TbProID";
            this.TbProID.Size = new System.Drawing.Size(142, 21);
            this.TbProID.TabIndex = 7;
            // 
            // TbProName
            // 
            this.TbProName.Location = new System.Drawing.Point(55, 69);
            this.TbProName.Name = "TbProName";
            this.TbProName.Size = new System.Drawing.Size(142, 21);
            this.TbProName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数量：";
            // 
            // TbDiscount
            // 
            this.TbDiscount.Location = new System.Drawing.Point(55, 186);
            this.TbDiscount.Name = "TbDiscount";
            this.TbDiscount.Size = new System.Drawing.Size(142, 21);
            this.TbDiscount.TabIndex = 5;
            // 
            // TbQuantity
            // 
            this.TbQuantity.Location = new System.Drawing.Point(55, 143);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(142, 21);
            this.TbQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "折扣：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbSearch);
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索";
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(10, 20);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(184, 21);
            this.TbSearch.TabIndex = 0;
            this.TbSearch.Text = "请输入商品名或商品号进行搜索";
            this.TbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            this.TbSearch.Leave += new System.EventHandler(this.TbSearch_Leave);
            this.TbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbSearch_MouseDown);
            // 
            // DGVStock
            // 
            this.DGVStock.BackgroundColor = System.Drawing.Color.White;
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Location = new System.Drawing.Point(244, 3);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.RowTemplate.Height = 23;
            this.DGVStock.Size = new System.Drawing.Size(341, 466);
            this.DGVStock.TabIndex = 0;
            this.DGVStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellClick);
            this.DGVStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellDoubleClick);
            this.DGVStock.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGVStock_RowsRemoved);
            // 
            // DGVProView
            // 
            this.DGVProView.BackgroundColor = System.Drawing.Color.White;
            this.DGVProView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProView.Location = new System.Drawing.Point(4, 4);
            this.DGVProView.Name = "DGVProView";
            this.DGVProView.RowTemplate.Height = 23;
            this.DGVProView.Size = new System.Drawing.Size(585, 547);
            this.DGVProView.TabIndex = 0;
            this.DGVProView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProView_CellClick);
            this.DGVProView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVProView_CellMouseDoubleClick);
            // 
            // ShopPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 589);
            this.Controls.Add(this.ViewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1239, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1239, 627);
            this.Name = "ShopPageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuGuGu超市收银系统 - 收银页";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopPageForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopPageForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopPageForm_Load);
            this.ViewPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.DataGridView DGVProView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.TextBox TbProID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbProName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbTip;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbUnitPrice;
        private System.Windows.Forms.Button BtnDel;
    }
}