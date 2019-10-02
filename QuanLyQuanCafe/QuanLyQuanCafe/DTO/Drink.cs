using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Drink
	{
		private int iD;
		private string name;
		private int iDCategory;
		private float prices;

		public Drink(int iD, string name, int iDCategory, float prices)
		{
			this.iD = iD;
			this.name = name;
			this.iDCategory = iDCategory;
			this.prices = prices;
		}

		public Drink(DataRow row)
		{
			this.iD = (int)row["id"];
			this.name = row["Ten"].ToString();
			this.iDCategory = (int)row["idLoai"];
			this.prices = (float)Convert.ToDouble(row["Gia"]);
		}

		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int IDCategory
		{
			get { return iDCategory; }
			set { iDCategory = value; }
		}
		public float Prices
		{
			get { return prices; }
			set { prices = value; }			
		}
	}
}
