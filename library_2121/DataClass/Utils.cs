using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Windows.Forms;

namespace library_2121 {
	public class Utils {
		public static string ConnectionString => ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

		public static SqlConnection GetConnection() {
			return new SqlConnection(ConnectionString);
		}

		public static int ExecuteUpdate(string sql,params (string name,object value)[] parameters) {
			SqlConnection conn = GetConnection();
			SqlCommand cmd = new SqlCommand(sql, conn);
			foreach(var v in parameters) {
				cmd.Parameters.AddWithValue(v.name, v.value);
			}

			try {
				conn.Open();
				int affected=cmd.ExecuteNonQuery();
				return affected;
			} catch (Exception e) {
				MessageBox.Show(e.ToString());
				return -1;
			} finally {
				conn.Close();
			}
		}
		public static DataSet ExecuteQuery(string sql,string table, params (string name, object value)[] parameters) {
			SqlConnection conn = GetConnection();

			try {
				SqlCommand cmd = new SqlCommand(sql, conn);
				foreach (var v in parameters) {
					cmd.Parameters.AddWithValue(v.name, v.value);
				}

				DataSet ds = new DataSet();
				SqlDataAdapter adp = new SqlDataAdapter(cmd);

				adp.Fill(ds, table);
				return ds;
			} finally {
				conn.Close();
			}
		}
	}
}