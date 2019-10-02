using QuanLyQuanCafe.Data;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class CategoryDAO
	{
		public static List<Category> GetCategory()
		{

			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("SELECT * FROM Loai"); 
			List<Category> categories = new List<Category>();

			foreach(DataRow item in data.Rows)
			{
				Category category = new Category(item);
				categories.Add(category);
			}

			return categories;
		}

		public static Category GetCategoryByID(int id)
		{
			clsData dt = new clsData();
			Category category = null;

			string query = "select * from Loai where id = " + id;

			DataTable data = dt.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				category = new Category(item);
				return category;
			}

			return category;
		}
	}
}
