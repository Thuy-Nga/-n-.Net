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
	public class DrinkDAO
	{
		public static List<Drink> GetDrinksByCategory(int id)
		{
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("SELECT * FROM Nuoc WHERE idLoai = "+ id);
			List<Drink> drinks = new List<Drink>();

			foreach (DataRow item in data.Rows)
			{
				Drink drink = new Drink(item);
				drinks.Add(drink);
			}

			return drinks;
		} 

		public static List<Drink> GetDrinks()
		{
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("select * from Nuoc");
			List<Drink> drinks = new List<Drink>();

			foreach (DataRow item in data.Rows)
			{
				Drink drink = new Drink(item);
				drinks.Add(drink);
			}

			return drinks;
		}

		public static bool InsertDrink(string name, int idType, float price)
		{
			clsData dt = new clsData();
			string query = string.Format("INSERT Nuoc (Ten, idLoai, Gia) VALUES  ( N'{0}', {1}, {2})", name,idType, price);
			int result = dt.ExecuteNonQuery(query);

			return result > 0;
		}

		public static bool UpdateDrink(int id, string name, int idType, float price)
		{
			clsData dt = new clsData();
			string query = string.Format("UPDATE Nuoc SET Ten = N'{0}', idLoai = {1}, Gia = {2} WHERE id = {3} ", name, idType, price,id);
			int result = dt.ExecuteNonQuery(query);

			return result > 0;
		}

		public static bool DeleteDrinks(int idDrink)
		{
			BillInfoDAO.DeleteBillInfoByDrinkID(idDrink);
			clsData dt = new clsData();
			string query = string.Format("Delete Nuoc where id = {0}", idDrink);
			int result = dt.ExecuteNonQuery(query);

			return result > 0;
		}

		public static List<Drink> SearchDrinkByName(string name)
		{
			clsData dt = new clsData();
			List<Drink> list = new List<Drink>();

			string query = string.Format("SELECT * FROM Nuoc WHERE Ten LIKE N'%{0}%'", name);

			DataTable data = dt.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				Drink drink = new Drink(item);
				list.Add(drink);
			}

			return list;
		}
	}
}
