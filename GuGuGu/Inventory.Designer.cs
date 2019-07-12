namespace GuGuGu
{
    partial class Inventory
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbTip = new System.Windows.Forms.Label();
            this.TbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbThrValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbSupID = new System.Windows.Forms.TextBox();
            this.TbProName = new System.Windows.Forms.TextBox();
            this.TbProID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAlert = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnQue = new System.Windows.Forms.Button();
            this.DGVInventory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DGVInventory);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 563);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Controls.Add(this.BtnOK);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(749, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 551);
            this.panel2.TabIndex = 6;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(264, 467);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(95, 23);
            this.BtnExit.TabIndex = 23;
            this.BtnExit.Text = "退出操作模式";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(82, 467);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 22;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbTip);
            this.groupBox2.Controls.Add(this.TbQuantity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TbThrValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TbSupID);
            this.groupBox2.Controls.Add(this.TbProName);
            this.groupBox2.Controls.Add(this.TbProID);
            this.groupBox2.Location = new System.Drawing.Point(10, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 298);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前商品信息";
            // 
            // LbTip
            // 
            this.LbTip.AutoSize = true;
            this.LbTip.Location = new System.Drawing.Point(287, 41);
            this.LbTip.Name = "LbTip";
            this.LbTip.Size = new System.Drawing.Size(89, 12);
            this.LbTip.TabIndex = 33;
            this.LbTip.Text = "请选择操作模式";
            // 
            // TbQuantity
            // 
            this.TbQuantity.Location = new System.Drawing.Point(109, 186);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(172, 21);
            this.TbQuantity.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "剩余库存：";
            // 
            // TbThrValue
            // 
            this.TbThrValue.Location = new System.Drawing.Point(109, 239);
            this.TbThrValue.Name = "TbThrValue";
            this.TbThrValue.Size = new System.Drawing.Size(172, 21);
            this.TbThrValue.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "阈值设定：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "供应商编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "商品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "商品编号：";
            // 
            // TbSupID
            // 
            this.TbSupID.Location = new System.Drawing.Point(109, 135);
            this.TbSupID.Name = "TbSupID";
            this.TbSupID.Size = new System.Drawing.Size(172, 21);
            this.TbSupID.TabIndex = 25;
            // 
            // TbProName
            // 
            this.TbProName.Location = new System.Drawing.Point(109, 86);
            this.TbProName.Name = "TbProName";
            this.TbProName.Size = new System.Drawing.Size(172, 21);
            this.TbProName.TabIndex = 24;
            // 
            // TbProID
            // 
            this.TbProID.Location = new System.Drawing.Point(109, 38);
            this.TbProID.Name = "TbProID";
            this.TbProID.Size = new System.Drawing.Size(172, 21);
            this.TbProID.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAlert);
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnExcel);
            this.groupBox1.Controls.Add(this.BtnQue);
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 117);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作模式";
            // 
            // BtnAlert
            // 
            this.BtnAlert.Location = new System.Drawing.Point(12, 75);
            this.BtnAlert.Name = "BtnAlert";
            this.BtnAlert.Size = new System.Drawing.Size(69, 23);
            this.BtnAlert.TabIndex = 20;
            this.BtnAlert.Text = "告急商品";
            this.BtnAlert.UseVisualStyleBackColor = true;
            this.BtnAlert.Click += new System.EventHandler(this.BtnAlert_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(323, 27);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 11;
            this.BtnRefresh.Text = "更新列表";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(217, 27);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "设置阈值";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(110, 27);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(75, 23);
            this.BtnExcel.TabIndex = 11;
            this.BtnExcel.Text = "表格导出";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnQue
            // 
            this.BtnQue.Location = new System.Drawing.Point(12, 27);
            this.BtnQue.Name = "BtnQue";
            this.BtnQue.Size = new System.Drawing.Size(69, 23);
            this.BtnQue.TabIndex = 9;
            this.BtnQue.Text = "查询库存";
            this.BtnQue.UseVisualStyleBackColor = true;
            this.BtnQue.Click += new System.EventHandler(this.BtnQue_Click);
            // 
            // DGVInventory
            // 
            this.DGVInventory.BackgroundColor = System.Drawing.Color.White;
            this.DGVInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInventory.Location = new System.Drawing.Point(6, 5);
            this.DGVInventory.Name = "DGVInventory";
            this.DGVInventory.RowTemplate.Height = 23;
            this.DGVInventory.Size = new System.Drawing.Size(737, 551);
            this.DGVInventory.TabIndex = 5;
            this.DGVInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInventory_CellClick);
            this.DGVInventory.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVInventory_CellPainting);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 589);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1239, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1239, 627);
            this.Name = "Inventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuGuGu超市收银系统 - 库存查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventory_FormClosed);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnQue;
        private System.Windows.Forms.DataGridView DGVInventory;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbThrValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbSupID;
        private System.Windows.Forms.TextBox TbProName;
        private System.Windows.Forms.TextBox TbProID;
        private System.Windows.Forms.Button BtnAlert;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LbTip;
        private System.Windows.Forms.Button BtnExit;
    }
}