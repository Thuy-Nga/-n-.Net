using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
	public partial class frmAdmin : Form
	{
		BindingSource listDrinks = new BindingSource();
		public frmAdmin()
		{
			InitializeComponent();
			//LoadListAccount();
			LoadListDrinks();
			dtgvDrinks.DataSource = listDrinks;
			AddDrinkBinding();
			LoadCategoryIntoCombobox(cboType);
		}

		/*public void LoadListAccount()
		{
			string query = "EXEC dbo.USP_GetAccountByUserName @userName";
			clsData data = new clsData();
			dtgvAccount.DataSource = data.ExecuteQuery(query, new object[] { "Nguyễn Thị Thuý Nga" });
		}*/

		public void LoadListDrinks()
		{
			listDrinks.DataSource = DrinkDAO.GetDrinks();
		}

		public void AddDrinkBinding()
		{
			txtName.DataBindings.Add(new Binding("Text", dtgvDrinks.DataSource, "Name"));
			txtID.DataBindings.Add(new Binding("Text", dtgvDrinks.DataSource, "ID"));
			txtPrices.DataBindings.Add(new Binding("Text", dtgvDrinks.DataSource, "Prices"));
		}


		public void LoadCategoryIntoCombobox(ComboBox cbo)
		{
			cboType.DataSource = CategoryDAO.GetCategory();
			cboType.DisplayMember = "Name";
		}
		private void btnAddDrink_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			int idCategory = (cboType.SelectedItem as Category).ID;
			float prices = float.Parse(txtPrices.Text.ToString());
			if(DrinkDAO.InsertDrink(name, idCategory, prices))
			{
				LoadListDrinks();
				MessageBox.Show("Thêm món thành công.");
				if (insert != null)
					insert(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Thêm món thất bại.");
			}

		}
		private void btnViewDrink_Click(object sender, EventArgs e)
		{
			LoadListDrinks();
		}

		private void txtID_TextChanged_1(object sender, EventArgs e)
		{
			if (dtgvDrinks.SelectedCells.Count > 0)
			{
				int id = (int)dtgvDrinks.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;

				Category category = CategoryDAO.GetCategoryByID(id);

				cboType.SelectedItem = category;

				int index = -1;
				int i = 0;
				foreach (Category item in cboType.Items)
				{
					if (item.ID == category.ID)
					{
						index = i;
						break;
					}
					i++;
				}

				cboType.SelectedIndex = index;
			}
		}

		private void btnEditDrink_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			int idCategory = (cboType.SelectedItem as Category).ID;
			float prices = float.Parse(txtPrices.Text.ToString());
			int id = Convert.ToInt32(txtID.Text);
			if (DrinkDAO.UpdateDrink(id, name, idCategory, prices))
			{
				LoadListDrinks();
				MessageBox.Show("Sửa món thành công.");
				if (updatedrink != null)
					updatedrink(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Sửa món thất bại.");
			}
		}

		private void btnDeleteDrink_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtID.Text);
			if (DrinkDAO.DeleteDrinks(id))
			{
				LoadListDrinks();
				MessageBox.Show("Xóa món thành công.");
				if (delete != null)
					delete(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Xóa món thất bại.");
			}
		}

		List<Drink> SearchFoodByName(string name)
		{
			List<Drink> listFood = DrinkDAO.SearchDrinkByName(name);

			return listFood;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			// lỗi phần xem
			dtgvDrinks.DataSource = SearchFoodByName(txtSearch.Text);
			
		}

		private event EventHandler insert;
		public event EventHandler Insert
		{
			add { insert += value; }
			remove { insert -= value; }
		}

		private event EventHandler delete;
		public event EventHandler Delete
		{
			add { delete += value; }
			remove { delete -= value; }
		}

		private event EventHandler updatedrink;
		public event EventHandler UpdateDrink
		{
			add { updatedrink += value; }
			remove { updatedrink -= value; }
		}
	}
}
