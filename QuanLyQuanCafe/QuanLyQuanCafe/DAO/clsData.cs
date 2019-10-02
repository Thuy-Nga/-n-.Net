using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Data
{
	
	public class clsData
	{
		private string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quan_Ly_Quan_Cafe;Integrated Security=True";

		public DataTable ExecuteQuery(string query, object[] parameter = null)
		{
			DataTable dt = new DataTable();

			using(SqlConnection con = new SqlConnection(conStr))
			{
				con.Open();

				SqlCommand cmn = new SqlCommand(query,con);

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							cmn.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}

				SqlDataAdapter adapter = new SqlDataAdapter(cmn);
				adapter.Fill(dt);
				con.Close();

			}
			return dt;
		}

		public int ExecuteNonQuery(string query, object[] parameter = null)
		{
			int data = 0;

			using (SqlConnection connection = new SqlConnection(conStr))
			{
				connection.Open();

				SqlCommand command = new SqlCommand(query, connection);

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}

				data = command.ExecuteNonQuery();

				connection.Close();
			}

			return data;
		}

		public object ExecuteScalar(string query, object[] parameter = null)
		{
			object data = 0;

			using (SqlConnection connection = new SqlConnection(conStr))
			{
				connection.Open();

				SqlCommand command = new SqlCommand(query, connection);

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}

				data = command.ExecuteScalar();

				connection.Close();
			}

			return data;
		}
	}

}
