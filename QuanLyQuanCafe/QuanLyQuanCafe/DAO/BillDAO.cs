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
	public class BillDAO
	{
		public static int GetBillByTable(int id) // id cua ban
		{
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("SELECT * FROM HoaDon WHERE idBan = " + id + " AND TrangThai = 0");
			if(data.Rows.Count > 0)
			{
				Bill bill = new Bill(data.Rows[0]);
				return bill.Id;
			}
			return -1;
		}

		public static void InsertBill(int id)
		{
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("EXEC USP_InsertBill @idBan", new object[] { id });
		}

		public static int GetMaxBill()
		{
			clsData dt = new clsData();
			return (int)dt.ExecuteScalar("SELECT MAX(id) FROM HoaDon");
		}

		public static void CheckOut(int id)
		{
			string query = "UPDATE HoaDon SET TrangThai = 1, NgayRa = GETDATE() WHERE id = " + id;
			clsData dt = new clsData();
			dt.ExecuteNonQuery(query);
		}
	}
}
