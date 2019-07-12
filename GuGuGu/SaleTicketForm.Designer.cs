namespace GuGuGu
{
    partial class SaleTicketForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.GBDetails = new System.Windows.Forms.GroupBox();
            this.LbTip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbCusID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TbOrdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVOrderDetails = new System.Windows.Forms.DataGridView();
            this.DGVOrder = new System.Windows.Forms.DataGridView();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.GBDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.GBDetails);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.DGVOrderDetails);
            this.MainPanel.Controls.Add(this.DGVOrder);
            this.MainPanel.Location = new System.Drawing.Point(13, 13);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1198, 563);
            this.MainPanel.TabIndex = 0;
            // 
            // GBDetails
            // 
            this.GBDetails.Controls.Add(this.LbTip);
            this.GBDetails.Location = new System.Drawing.Point(843, 4);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.Size = new System.Drawing.Size(350, 55);
            this.GBDetails.TabIndex = 3;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "详细信息";
            // 
            // LbTip
            // 
            this.LbTip.AutoSize = true;
            this.LbTip.Location = new System.Drawing.Point(16, 24);
            this.LbTip.Name = "LbTip";
            this.LbTip.Size = new System.Drawing.Size(77, 12);
            this.LbTip.TabIndex = 0;
            this.LbTip.Text = "当前订单号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExcel);
            this.groupBox1.Controls.Add(this.TbCusID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TimePickerEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TimePickerStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbOrdID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入信息以查询记录";
            // 
            // TbCusID
            // 
            this.TbCusID.Location = new System.Drawing.Point(618, 21);
            this.TbCusID.Name = "TbCusID";
            this.TbCusID.Size = new System.Drawing.Size(123, 21);
            this.TbCusID.TabIndex = 7;
            this.TbCusID.TextChanged += new System.EventHandler(this.TbCusID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "客户ID：";
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.Location = new System.Drawing.Point(441, 21);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.Size = new System.Drawing.Size(123, 21);
            this.TimePickerEnd.TabIndex = 5;
            this.TimePickerEnd.ValueChanged += new System.EventHandler(this.TimePickerEnd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "结束时间：";
            // 
            // TimePickerStart
            // 
            this.TimePickerStart.Location = new System.Drawing.Point(241, 21);
            this.TimePickerStart.Name = "TimePickerStart";
            this.TimePickerStart.Size = new System.Drawing.Size(123, 21);
            this.TimePickerStart.TabIndex = 3;
            this.TimePickerStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.TimePickerStart.ValueChanged += new System.EventHandler(this.TimePickerStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始时间：";
            // 
            // TbOrdID
            // 
            this.TbOrdID.Location = new System.Drawing.Point(46, 21);
            this.TbOrdID.Name = "TbOrdID";
            this.TbOrdID.Size = new System.Drawing.Size(123, 21);
            this.TbOrdID.TabIndex = 1;
            this.TbOrdID.TextChanged += new System.EventHandler(this.TbOrdID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单号：";
            // 
            // DGVOrderDetails
            // 
            this.DGVOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.DGVOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrderDetails.Location = new System.Drawing.Point(723, 65);
            this.DGVOrderDetails.Name = "DGVOrderDetails";
            this.DGVOrderDetails.RowTemplate.Height = 23;
            this.DGVOrderDetails.Size = new System.Drawing.Size(470, 493);
            this.DGVOrderDetails.TabIndex = 1;
            // 
            // DGVOrder
            // 
            this.DGVOrder.BackgroundColor = System.Drawing.Color.White;
            this.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrder.Location = new System.Drawing.Point(3, 65);
            this.DGVOrder.Name = "DGVOrder";
            this.DGVOrder.RowTemplate.Height = 23;
            this.DGVOrder.Size = new System.Drawing.Size(713, 493);
            this.DGVOrder.TabIndex = 0;
            this.DGVOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrder_CellClick);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(751, 19);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(75, 23);
            this.BtnExcel.TabIndex = 8;
            this.BtnExcel.Text = "Excel导出";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // SaleTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 588);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1239, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1239, 627);
            this.Name = "SaleTicketForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuGuGu超市收银系统 - 销售单查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaleTicketForm_FormClosed);
            this.Load += new System.EventHandler(this.SaleTicketForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.GBDetails.ResumeLayout(false);
            this.GBDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView DGVOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVOrderDetails;
        private System.Windows.Forms.TextBox TbCusID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimePickerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbOrdID;
        private System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.Label LbTip;
        private System.Windows.Forms.Button BtnExcel;
    }
}