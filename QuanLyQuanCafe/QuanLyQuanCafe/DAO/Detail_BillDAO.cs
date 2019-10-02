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
	public class Detail_BillDAO
	{
		public static List<Detail_Bill> GetDetail_Bills(int id) 
		{
			List<Detail_Bill> listBill = new List<Detail_Bill>();
			clsData dt = new clsData();
			DataTable data = dt.ExecuteQuery("SELECT D.Ten, B.SoLuong, D.Gia, B.SoLuong*D.Gia AS TongTien FROM HoaDon A, ChiTietHD B, Nuoc D WHERE TrangThai=0 AND B.idHD = A.id AND D.id = B.idNuoc AND A.idBan = "+id);
			foreach (DataRow item in data.Rows)
			{
				Detail_Bill billfo = new Detail_Bill(item);
				listBill.Add(billfo);
			}

			return listBill;

		}
	}
}
