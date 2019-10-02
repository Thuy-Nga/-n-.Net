using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Detail_Bill
	{
		private string name;
		private int count;
		private float prices;
		private float totalPrices;

		public Detail_Bill(string name, int count, float prices, float totalPrices)
		{
			this.name = name;
			this.count = count;
			this.prices = prices;
			this.totalPrices = totalPrices;
		}

		public Detail_Bill(DataRow row)
		{
			this.name = row["Ten"].ToString();
			this.count = (int)row["SoLuong"];
			this.prices = (float)Convert.ToDouble(row["Gia"].ToString());
			this.TotalPrices = (float)Convert.ToDouble(row["TongTien"].ToString());
		}
		public string Name { get => name; set => name = value; }
		public int Count { get => count; set => count = value; }
		public float Prices { get => prices; set => prices = value; }
		public float TotalPrices { get => totalPrices; set => totalPrices = value; }
	}
}
