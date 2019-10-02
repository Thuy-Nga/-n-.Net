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
	public class BillInfoDAO
	{
		public static List<BillInfo> GetListBillInfoByBill(int id) // id cua hoa don
		{
			List<BillInfo> listBill = new List<BillInfo>();
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("SELECT * FROM ChiTietHD WHERE idHD = " + id );
			foreach(DataRow item in data.Rows)
			{
				BillInfo binfo = new BillInfo(item);
				listBill.Add(binfo);
			}

			return listBill;			
		}

		public static void InsertBillInFo(int idBill, int idDrink, int count )
		{
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("USP_InsertBillInFo @idHD , @idNuoc , @SL", new object[] { idBill, idDrink, count });
		}

		internal static void DeleteBillInfoByDrinkID(int idDrink)
		{
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("DELETE ChiTietHD WHERE idNuoc = " + idDrink);
		}
	}
}
