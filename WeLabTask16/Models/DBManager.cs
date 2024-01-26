using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WeLabTask16.Models
{
	public class DBManager
	{
		string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WeStudentTask;Data Source=DESKTOP-4S96KP6\\SQLEXPRESS";
		public int IUD(string query)
		{
			SqlConnection con = new SqlConnection(constr);
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			int r = cmd.ExecuteNonQuery();
			con.Close();
			return r;
		}
		public SqlDataReader fetch(string query)
		{
			SqlConnection con = new SqlConnection(constr);
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataReader sdr = cmd.ExecuteReader();
			
			return sdr;
		}
	}
}