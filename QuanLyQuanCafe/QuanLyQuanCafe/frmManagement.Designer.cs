namespace QuanLyQuanCafe
{
	partial class frmManagement
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
			this.flpTableList = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnAddDrink = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.nmCount = new System.Windows.Forms.NumericUpDown();
			this.cbDrink = new System.Windows.Forms.ComboBox();
			this.cbChooseType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtTotalPrices = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnPay = new System.Windows.Forms.Button();
			this.lsvDetailBill = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblTable = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
			this.panel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpTableList
			// 
			this.flpTableList.AutoScroll = true;
			this.flpTableList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flpTableList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.flpTableList.Location = new System.Drawing.Point(12, 35);
			this.flpTableList.Name = "flpTableList";
			this.flpTableList.Size = new System.Drawing.Size(392, 436);
			this.flpTableList.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(415, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(469, 436);
			this.panel1.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnAddDrink);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.nmCount);
			this.panel3.Controls.Add(this.cbDrink);
			this.panel3.Controls.Add(this.cbChooseType);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(461, 62);
			this.panel3.TabIndex = 1;
			// 
			// btnAddDrink
			// 
			this.btnAddDrink.Location = new System.Drawing.Point(385, 11);
			this.btnAddDrink.Name = "btnAddDrink";
			this.btnAddDrink.Size = new System.Drawing.Size(68, 42);
			this.btnAddDrink.TabIndex = 6;
			this.btnAddDrink.Text = "Thêm Món";
			this.btnAddDrink.UseVisualStyleBackColor = true;
			this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(309, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Số Lượng:";
			// 
			// nmCount
			// 
			this.nmCount.Location = new System.Drawing.Point(312, 33);
			this.nmCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmCount.Name = "nmCount";
			this.nmCount.Size = new System.Drawing.Size(47, 20);
			this.nmCount.TabIndex = 4;
			this.nmCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cbDrink
			// 
			this.cbDrink.FormattingEnabled = true;
			this.cbDrink.Location = new System.Drawing.Point(153, 32);
			this.cbDrink.Name = "cbDrink";
			this.cbDrink.Size = new System.Drawing.Size(138, 21);
			this.cbDrink.TabIndex = 3;
			// 
			// cbChooseType
			// 
			this.cbChooseType.FormattingEnabled = true;
			this.cbChooseType.Location = new System.Drawing.Point(6, 32);
			this.cbChooseType.Name = "cbChooseType";
			this.cbChooseType.Size = new System.Drawing.Size(138, 21);
			this.cbChooseType.TabIndex = 2;
			this.cbChooseType.SelectedIndexChanged += new System.EventHandler(this.cbChooseType_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(150, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Chọn Nước";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn Loại:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.txtTotalPrices);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.btnPay);
			this.panel2.Controls.Add(this.lsvDetailBill);
			this.panel2.Controls.Add(this.lblTable);
			this.panel2.Location = new System.Drawing.Point(3, 71);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(461, 365);
			this.panel2.TabIndex = 0;
			// 
			// txtTotalPrices
			// 
			this.txtTotalPrices.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTotalPrices.ForeColor = System.Drawing.Color.Black;
			this.txtTotalPrices.Location = new System.Drawing.Point(73, 325);
			this.txtTotalPrices.Name = "txtTotalPrices";
			this.txtTotalPrices.ReadOnly = true;
			this.txtTotalPrices.Size = new System.Drawing.Size(110, 22);
			this.txtTotalPrices.TabIndex = 5;
			this.txtTotalPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 330);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Tổng Tiền:";
			// 
			// btnPay
			// 
			this.btnPay.Location = new System.Drawing.Point(200, 325);
			this.btnPay.Name = "btnPay";
			this.btnPay.Size = new System.Drawing.Size(79, 22);
			this.btnPay.TabIndex = 2;
			this.btnPay.Text = "Thanh Toán";
			this.btnPay.UseVisualStyleBackColor = true;
			this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
			// 
			// lsvDetailBill
			// 
			this.lsvDetailBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lsvDetailBill.GridLines = true;
			this.lsvDetailBill.Location = new System.Drawing.Point(8, 56);
			this.lsvDetailBill.Name = "lsvDetailBill";
			this.lsvDetailBill.Size = new System.Drawing.Size(445, 250);
			this.lsvDetailBill.TabIndex = 1;
			this.lsvDetailBill.UseCompatibleStateImageBehavior = false;
			this.lsvDetailBill.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên Nước";
			this.columnHeader1.Width = 139;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số Lượng";
			this.columnHeader2.Width = 65;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Giá";
			this.columnHeader3.Width = 114;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tổng giá";
			this.columnHeader4.Width = 122;
			// 
			// lblTable
			// 
			this.lblTable.AutoSize = true;
			this.lblTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTable.Location = new System.Drawing.Point(196, 18);
			this.lblTable.Name = "lblTable";
			this.lblTable.Size = new System.Drawing.Size(112, 19);
			this.lblTable.TabIndex = 0;
			this.lblTable.Text = "Hoá Đơn Bàn";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(890, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thôngTinToolStripMenuItem
			// 
			this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
			this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
			this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.thôngTinToolStripMenuItem.Text = "Tài Khoản";
			// 
			// thôngTinToolStripMenuItem1
			// 
			this.thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
			this.thôngTinToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.thôngTinToolStripMenuItem1.Text = "Thông Tin";
			this.thôngTinToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinToolStripMenuItem1_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// frmManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(890, 474);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flpTableList);
			this.Controls.Add(this.menuStrip1);
			this.Name = "frmManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần Mềm Quản Lý Quán Cafe";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flpTableList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblTable;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnAddDrink;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nmCount;
		private System.Windows.Forms.ComboBox cbDrink;
		private System.Windows.Forms.ComboBox cbChooseType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotalPrices;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPay;
		private System.Windows.Forms.ListView lsvDetailBill;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}