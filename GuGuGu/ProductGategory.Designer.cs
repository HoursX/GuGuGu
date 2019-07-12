namespace GuGuGu
{
    partial class ProductGategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGategory));
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddCategories = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnDelCategories = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnUpdCategories = new System.Windows.Forms.Button();
            this.BtnQueCategories = new System.Windows.Forms.Button();
            this.DGVCategories = new System.Windows.Forms.DataGridView();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbTip = new System.Windows.Forms.Label();
            this.LbDe = new System.Windows.Forms.Label();
            this.TbDe = new System.Windows.Forms.TextBox();
            this.LbID = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.LbName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.ViewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPanel.Controls.Add(this.panel1);
            this.ViewPanel.Location = new System.Drawing.Point(13, 13);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1198, 563);
            this.ViewPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Controls.Add(this.DGVCategories);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 554);
            this.panel1.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.groupBox2);
            this.MenuPanel.Controls.Add(this.BtnExit);
            this.MenuPanel.Controls.Add(this.BtnOk);
            this.MenuPanel.Controls.Add(this.groupBox1);
            this.MenuPanel.Location = new System.Drawing.Point(775, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(410, 547);
            this.MenuPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddCategories);
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.BtnDelCategories);
            this.groupBox1.Controls.Add(this.BtnExcel);
            this.groupBox1.Controls.Add(this.BtnUpdCategories);
            this.groupBox1.Controls.Add(this.BtnQueCategories);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 102);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作模式";
            // 
            // BtnAddCategories
            // 
            this.BtnAddCategories.Location = new System.Drawing.Point(12, 20);
            this.BtnAddCategories.Name = "BtnAddCategories";
            this.BtnAddCategories.Size = new System.Drawing.Size(75, 23);
            this.BtnAddCategories.TabIndex = 0;
            this.BtnAddCategories.Text = "添加类别";
            this.BtnAddCategories.UseVisualStyleBackColor = true;
            this.BtnAddCategories.Click += new System.EventHandler(this.BtnAddCategories_Click);
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
            // BtnDelCategories
            // 
            this.BtnDelCategories.Location = new System.Drawing.Point(113, 20);
            this.BtnDelCategories.Name = "BtnDelCategories";
            this.BtnDelCategories.Size = new System.Drawing.Size(75, 23);
            this.BtnDelCategories.TabIndex = 1;
            this.BtnDelCategories.Text = "删除类别";
            this.BtnDelCategories.UseVisualStyleBackColor = true;
            this.BtnDelCategories.Click += new System.EventHandler(this.BtnDelCategories_Click);
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
            // BtnUpdCategories
            // 
            this.BtnUpdCategories.Location = new System.Drawing.Point(210, 20);
            this.BtnUpdCategories.Name = "BtnUpdCategories";
            this.BtnUpdCategories.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdCategories.TabIndex = 2;
            this.BtnUpdCategories.Text = "更新类别";
            this.BtnUpdCategories.UseVisualStyleBackColor = true;
            this.BtnUpdCategories.Click += new System.EventHandler(this.BtnUpdCategories_Click);
            // 
            // BtnQueCategories
            // 
            this.BtnQueCategories.Location = new System.Drawing.Point(311, 20);
            this.BtnQueCategories.Name = "BtnQueCategories";
            this.BtnQueCategories.Size = new System.Drawing.Size(75, 23);
            this.BtnQueCategories.TabIndex = 3;
            this.BtnQueCategories.Text = "查询类别";
            this.BtnQueCategories.UseVisualStyleBackColor = true;
            this.BtnQueCategories.Click += new System.EventHandler(this.BtnQueCategories_Click);
            // 
            // DGVCategories
            // 
            this.DGVCategories.BackgroundColor = System.Drawing.Color.White;
            this.DGVCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategories.Location = new System.Drawing.Point(4, 4);
            this.DGVCategories.Name = "DGVCategories";
            this.DGVCategories.RowTemplate.Height = 23;
            this.DGVCategories.Size = new System.Drawing.Size(765, 547);
            this.DGVCategories.TabIndex = 0;
            this.DGVCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategories_CellClick);
            this.DGVCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategories_CellDoubleClick);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(56, 500);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 13;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(275, 500);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(87, 23);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "退出操作模式";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbTip);
            this.groupBox2.Controls.Add(this.LbDe);
            this.groupBox2.Controls.Add(this.TbDe);
            this.groupBox2.Controls.Add(this.LbID);
            this.groupBox2.Controls.Add(this.TbID);
            this.groupBox2.Controls.Add(this.LbName);
            this.groupBox2.Controls.Add(this.TbName);
            this.groupBox2.Location = new System.Drawing.Point(4, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 382);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前类别信息";
            // 
            // LbTip
            // 
            this.LbTip.AutoSize = true;
            this.LbTip.Location = new System.Drawing.Point(269, 25);
            this.LbTip.Name = "LbTip";
            this.LbTip.Size = new System.Drawing.Size(89, 12);
            this.LbTip.TabIndex = 21;
            this.LbTip.Text = "请选择操作模式";
            // 
            // LbDe
            // 
            this.LbDe.AutoSize = true;
            this.LbDe.Location = new System.Drawing.Point(11, 100);
            this.LbDe.Name = "LbDe";
            this.LbDe.Size = new System.Drawing.Size(65, 12);
            this.LbDe.TabIndex = 20;
            this.LbDe.Text = "类别描述：";
            // 
            // TbDe
            // 
            this.TbDe.Location = new System.Drawing.Point(76, 97);
            this.TbDe.Multiline = true;
            this.TbDe.Name = "TbDe";
            this.TbDe.Size = new System.Drawing.Size(314, 263);
            this.TbDe.TabIndex = 19;
            // 
            // LbID
            // 
            this.LbID.AutoSize = true;
            this.LbID.Location = new System.Drawing.Point(23, 64);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(53, 12);
            this.LbID.TabIndex = 18;
            this.LbID.Text = "类别号：";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(76, 61);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(177, 21);
            this.TbID.TabIndex = 17;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(23, 25);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(53, 12);
            this.LbName.TabIndex = 16;
            this.LbName.Text = "类别名：";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(76, 22);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(177, 21);
            this.TbName.TabIndex = 15;
            // 
            // ProductGategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 588);
            this.Controls.Add(this.ViewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1239, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1239, 627);
            this.Name = "ProductGategory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuGuGu超市收银系统 - 商品类别维护";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductGategory_FormClosed);
            this.Load += new System.EventHandler(this.ProductGategory_Load);
            this.ViewPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVCategories;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button BtnAddCategories;
        private System.Windows.Forms.Button BtnQueCategories;
        private System.Windows.Forms.Button BtnUpdCategories;
        private System.Windows.Forms.Button BtnDelCategories;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbTip;
        private System.Windows.Forms.Label LbDe;
        private System.Windows.Forms.TextBox TbDe;
        private System.Windows.Forms.Label LbID;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnOk;
    }
}