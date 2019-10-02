using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmManagement : Form
	{
		public frmManagement()
		{
			InitializeComponent();
			LoadTable();
			LoadCategory();
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAdmin admin = new frmAdmin();
			admin.Insert += admin_Insert;
			admin.Delete += admin_Delete;
			admin.UpdateDrink += admin_UpdateDrink;
			this.Hide();
			admin.ShowDialog();
			this.Show();
		}

		private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmInFo info = new frmInFo();
			this.Hide();
			info.ShowDialog();
			this.Show();
		}

		public void LoadTable()
		{
			flpTableList.Controls.Clear();	
			TableDAO tbdao = new TableDAO();
			List<Table> tablelist = tbdao.LoadTable();

			foreach(Table item in tablelist)
			{
				Button btn = new Button();
				btn.Width = 115;
				btn.Height = 115;
				btn.Click += btn_Click;
				btn.Tag = item;

				btn.Text = item.Name + "\r\n\r\n" + item.Status;

				if (item.Status.Equals("Trống"))
				{
					btn.BackColor = Color.LightSkyBlue;
				}

				else
				{
					btn.BackColor = Color.LightPink;
				}
				flpTableList.Controls.Add(btn);
			}
		}
		private void ShowBill(int id) // id cua ban
		{
			lsvDetailBill.Items.Clear();
			CultureInfo culture = new CultureInfo("vi-VN");			
			// lay ra danh sach hoa don
			List<Detail_Bill> detail = Detail_BillDAO.GetDetail_Bills(id);

			float totalPrices = 0;
			foreach (Detail_Bill item in detail)
			{
				ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
				lsvItem.SubItems.Add(item.Count.ToString());
				lsvItem.SubItems.Add(item.Prices.ToString());
				lsvItem.SubItems.Add(item.TotalPrices.ToString());
				totalPrices += item.Prices;
				lsvDetailBill.Items.Add(lsvItem);				
			}
			
			txtTotalPrices.Text = totalPrices.ToString("c", culture);
			
		}

		private void btn_Click(object sender, EventArgs e)
		{
			int TableId = ((sender as Button).Tag as Table).ID;
			lsvDetailBill.Tag = (sender as Button).Tag; 
			ShowBill(TableId);
		}

		// lay ra duoc nhom nuoc 
		public void LoadCategory()
		{
			List<Category> categories = CategoryDAO.GetCategory();
			cbChooseType.DataSource = categories;
			cbChooseType.DisplayMember = "Name";
		}

		public void LoadCategoryByid(int id)
		{
			List<Drink> drinks = DrinkDAO.GetDrinksByCategory(id);
			cbDrink.DataSource = drinks;
			cbDrink.DisplayMember = "Name";
		}

		// lay ra nuoc theo tung nhom
		private void LoadDrink(int id)
		{
			List<Drink> drinks = DrinkDAO.GetDrinksByCategory(id);
			cbDrink.DataSource = drinks;
			cbDrink.DisplayMember = "Name";
		}


		private void cbChooseType_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;

			if (cb.SelectedItem == null)
				return;

			Category selected = cb.SelectedItem as Category;
			int id = selected.ID;
			LoadDrink(id);
		}

		private void btnAddDrink_Click(object sender, EventArgs e)
		{
			Table table = lsvDetailBill.Tag as Table;
			int idBill = BillDAO.GetBillByTable(table.ID);
			int idDrink = (cbDrink.SelectedItem as Drink).ID;
			int count = (int)nmCount.Value;
			if(idBill == -1)
			{
				BillDAO.InsertBill(table.ID);
				BillInfoDAO.InsertBillInFo(BillDAO.GetMaxBill(), idDrink, count);
			}

			else
			{
				BillInfoDAO.InsertBillInFo(idBill, idDrink, count);
			}

			ShowBill(table.ID);

			LoadTable();
		}

		private void btnPay_Click(object sender, EventArgs e)
		{
			Table table = lsvDetailBill.Tag as Table;

			int idBill = BillDAO.GetBillByTable(table.ID);

			if (idBill != -1)
			{
				if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				{
					BillDAO.CheckOut(idBill);					
					ShowBill(table.ID);					
					LoadTable();
				}
			}
		}

		void admin_UpdateDrink(object sender, EventArgs e)
		{
			LoadCategoryByid((cbChooseType.SelectedItem as Category).ID);
			if (lsvDetailBill.Tag != null)
				ShowBill((lsvDetailBill.Tag as Table).ID);
		}

		void admin_Delete(object sender, EventArgs e)
		{
			LoadCategoryByid((cbChooseType.SelectedItem as Category).ID);
			if (lsvDetailBill.Tag != null)
				ShowBill((lsvDetailBill.Tag as Table).ID);
			LoadTable();
		}

		void admin_Insert(object sender, EventArgs e)
		{
			LoadCategoryByid((cbChooseType.SelectedItem as Category).ID);
			if (lsvDetailBill.Tag != null)
				ShowBill((lsvDetailBill.Tag as Table).ID);
		}
		
	}
}

