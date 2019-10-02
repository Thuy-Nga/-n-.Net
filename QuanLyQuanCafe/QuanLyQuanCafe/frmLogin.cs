using QuanLyQuanCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("Bạn có muốn thoát ?","Thông Báo Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.Yes)
			{
				e.Cancel = true;
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUeserName.Text;
			string pass = txtPass.Text;
			if(Login(username,pass))
			{
				frmManagement fm = new frmManagement();
				this.Hide();
				fm.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Bạn đã sai tên đăng nhập hoặc mật khẩu", "Thông Báo");
			}
		}

		bool Login(string username,string pass)
		{
			string query = "USP_Login @userName , @pass";
			clsData data = new clsData();
			DataTable kt = data.ExecuteQuery(query, new object[] { username , pass });
			return kt.Rows.Count > 0;
		}

		#region Event
		private void txtUeserName_Enter(object sender, EventArgs e)
		{
			if(txtUeserName.Text == "Tên đăng nhập")
			{
				txtUeserName.Text = "";
				txtUeserName.ForeColor = Color.Black;
			}
		}

		private void txtUeserName_Leave(object sender, EventArgs e)
		{
			if (txtUeserName.Text == "")
			{
				txtUeserName.Text = "Tên đăng nhập";
				txtUeserName.ForeColor = Color.Gray;
			}
		}

		private void txtPass_Enter(object sender, EventArgs e)
		{
			if (txtPass.Text == "Mật khẩu")
			{
				txtPass.Text = "";
				txtPass.ForeColor = Color.Black;
				txtPass.UseSystemPasswordChar = true;
			}
		}

		private void txtPass_Leave(object sender, EventArgs e)
		{
			if (txtPass.Text == "")
			{
				txtPass.Text = "Mật khẩu";
				txtPass.ForeColor = Color.Gray;
				txtPass.UseSystemPasswordChar = false;
			}
		}

		private void lblClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lblMini_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}



		#endregion
	}
}
