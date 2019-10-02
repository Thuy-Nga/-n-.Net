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
	public class TableDAO
	{
		public List<Table> LoadTable()
		{
			List<Table> tablelist = new List<Table>();

			clsData dt = new clsData();
			DataTable dtable = dt.ExecuteQuery("SELECT * FROM Ban");
			foreach(DataRow item in dtable.Rows)
			{
				Table tb = new Table(item);
				tablelist.Add(tb);
			}

			return tablelist;
		}
	}
}
