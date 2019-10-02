using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class BillInfo
	{
		private int id;
		private int idHD;
		private int idNuoc;
		private int sl;

		public BillInfo(int id, int idHD, int idNuoc, int sl)
		{
			this.id = id;
			this.idHD = idHD;
			this.idNuoc = idNuoc;
			this.sl = sl;
		}

		public BillInfo(DataRow dt)
		{
			this.id = (int)dt["id"];
			this.idHD = (int)dt["idHD"];
			this.idNuoc = (int)dt["idNuoc"];
			this.sl = (int)dt["SoLuong"];
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public int IdHD
		{
			get { return idHD; }
			set { idHD = value; }
		}
		public int IdNuoc
		{
			get { return idNuoc; }
			set { idNuoc = value; }
		}
		public int SL
		{
			get { return sl; }
			set { sl = value; }
		}
	}
}
