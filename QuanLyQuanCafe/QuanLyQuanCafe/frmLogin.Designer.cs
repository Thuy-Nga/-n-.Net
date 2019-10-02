namespace QuanLyQuanCafe
{
	partial class frmLogin
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUeserName = new System.Windows.Forms.TextBox();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlbackground = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblMini = new System.Windows.Forms.Label();
			this.lblClose = new System.Windows.Forms.Label();
			this.pnlBottom.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlbackground.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(171, 126);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(108, 32);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(27, 126);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(108, 32);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Đăng Nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtPass.ForeColor = System.Drawing.SystemColors.GrayText;
			this.txtPass.Location = new System.Drawing.Point(27, 80);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(256, 30);
			this.txtPass.TabIndex = 3;
			this.txtPass.Text = "Mật khẩu";
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
			// 
			// txtUeserName
			// 
			this.txtUeserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtUeserName.ForeColor = System.Drawing.SystemColors.GrayText;
			this.txtUeserName.Location = new System.Drawing.Point(27, 32);
			this.txtUeserName.Name = "txtUeserName";
			this.txtUeserName.Size = new System.Drawing.Size(256, 30);
			this.txtUeserName.TabIndex = 2;
			this.txtUeserName.Text = "Tên đăng nhập";
			this.txtUeserName.Enter += new System.EventHandler(this.txtUeserName_Enter);
			this.txtUeserName.Leave += new System.EventHandler(this.txtUeserName_Leave);
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.background_login;
			this.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlBottom.Controls.Add(this.panel1);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 77);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(331, 233);
			this.pnlBottom.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.txtUeserName);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.txtPass);
			this.panel1.Location = new System.Drawing.Point(12, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(307, 182);
			this.panel1.TabIndex = 6;
			// 
			// pnlbackground
			// 
			this.pnlbackground.BackColor = System.Drawing.Color.Peru;
			this.pnlbackground.Controls.Add(this.label1);
			this.pnlbackground.Controls.Add(this.lblMini);
			this.pnlbackground.Controls.Add(this.lblClose);
			this.pnlbackground.Controls.Add(this.pnlBottom);
			this.pnlbackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlbackground.Location = new System.Drawing.Point(0, 0);
			this.pnlbackground.Name = "pnlbackground";
			this.pnlbackground.Size = new System.Drawing.Size(331, 310);
			this.pnlbackground.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(97, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 31);
			this.label1.TabIndex = 9;
			this.label1.Text = "Đăng nhập";
			// 
			// lblMini
			// 
			this.lblMini.AutoSize = true;
			this.lblMini.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblMini.Location = new System.Drawing.Point(292, 3);
			this.lblMini.Name = "lblMini";
			this.lblMini.Size = new System.Drawing.Size(17, 17);
			this.lblMini.TabIndex = 8;
			this.lblMini.Text = "_";
			this.lblMini.Click += new System.EventHandler(this.lblMini_Click);
			// 
			// lblClose
			// 
			this.lblClose.AutoSize = true;
			this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblClose.Location = new System.Drawing.Point(309, 3);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(18, 17);
			this.lblClose.TabIndex = 7;
			this.lblClose.Text = "X";
			this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(331, 310);
			this.Controls.Add(this.pnlbackground);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.pnlBottom.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlbackground.ResumeLayout(false);
			this.pnlbackground.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUeserName;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlbackground;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMini;
		private System.Windows.Forms.Label lblClose;
	}
}

