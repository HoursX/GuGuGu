namespace GuGuGu
{
    partial class StockForm
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
            this.DGVInventory = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReFresh = new System.Windows.Forms.Button();
            this.Btnlead = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.DGVDataStock = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventory)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGVInventory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DGVDataStock);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 571);
            this.panel1.TabIndex = 0;
            // 
            // DGVInventory
            // 
            this.DGVInventory.BackgroundColor = System.Drawing.Color.White;
            this.DGVInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInventory.Location = new System.Drawing.Point(574, 8);
            this.DGVInventory.Name = "DGVInventory";
            this.DGVInventory.RowTemplate.Height = 23;
            this.DGVInventory.Size = new System.Drawing.Size(620, 554);
            this.DGVInventory.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(315, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 554);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReFresh);
            this.groupBox1.Controls.Add(this.Btnlead);
            this.groupBox1.Controls.Add(this.btnFinish);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作模式";
            // 
            // BtnReFresh
            // 
            this.BtnReFresh.Location = new System.Drawing.Point(15, 103);
            this.BtnReFresh.Name = "BtnReFresh";
            this.BtnReFresh.Size = new System.Drawing.Size(75, 23);
            this.BtnReFresh.TabIndex = 5;
            this.BtnReFresh.Text = "库存刷新";
            this.BtnReFresh.UseVisualStyleBackColor = true;
            this.BtnReFresh.Click += new System.EventHandler(this.BtnReFresh_Click);
            // 
            // Btnlead
            // 
            this.Btnlead.Location = new System.Drawing.Point(15, 42);
            this.Btnlead.Name = "Btnlead";
            this.Btnlead.Size = new System.Drawing.Size(75, 23);
            this.Btnlead.TabIndex = 3;
            this.Btnlead.Text = "导入进货表";
            this.Btnlead.UseVisualStyleBackColor = true;
            this.Btnlead.Click += new System.EventHandler(this.Btnlead_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(127, 42);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "数据写入";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // DGVDataStock
            // 
            this.DGVDataStock.BackgroundColor = System.Drawing.Color.White;
            this.DGVDataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDataStock.Location = new System.Drawing.Point(7, 8);
            this.DGVDataStock.Name = "DGVDataStock";
            this.DGVDataStock.RowTemplate.Height = 23;
            this.DGVDataStock.Size = new System.Drawing.Size(302, 554);
            this.DGVDataStock.TabIndex = 1;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 588);
            this.Controls.Add(this.panel1);
            this.Name = "StockForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuGuGu超市收银系统 - 商品进货";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stock_FormClosed);
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVDataStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button Btnlead;
        private System.Windows.Forms.DataGridView DGVInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReFresh;
    }
}