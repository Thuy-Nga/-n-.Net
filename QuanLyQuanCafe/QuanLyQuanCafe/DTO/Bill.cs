using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Bill
	{
		private int id;
		private DateTime? checkIn;
		private DateTime? checkOut;
		private int status;

		public Bill(int Id, DateTime? CheckIn, DateTime? CheckOut, int Status)
		{
			this.id = Id;
			this.checkIn = CheckIn;
			this.checkOut = CheckOut;
			this.status = Status;
		}

		public Bill(DataRow row)
		{
			this.id = (int)row["id"];
			this.checkIn = (DateTime)row["NgayVao"];
			var CheckOutTemp = row["NgayRa"];
			if(CheckOutTemp.ToString() != "")
				this.checkOut = (DateTime)row["NgayRa"];
			this.status = Convert.ToInt32(row["TrangThai"]);
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public DateTime? CheckIn
		{
			get { return checkIn; }
			set { checkIn = value; }
		}

		public DateTime? CheckOut
		{
			get { return checkOut; }
			set { checkOut = value; }
		}

		public int Status
		{
			get { return status; }
			set { status = value; }
		}
	}
}
