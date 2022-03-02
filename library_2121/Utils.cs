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

		public static SqlConnection GetConnection() => new SqlConnection(ConnectionString);

		public static int ExecuteUpdate(string sql,params object[] parameters) {
			SqlConnection conn = GetConnection();
			SqlCommand cmd = new SqlCommand(sql, conn);
			for (int i = 0; i < parameters.Length; i += 1) {
				cmd.Parameters.AddWithValue("@" + i, parameters[i]);
			}

			try {
				conn.Open();
				int affected=cmd.ExecuteNonQuery();
				return affected;
			} finally {
				conn.Close();
			}
		}

		public static object ExecuteScalar(string sql, params object[] parameters) {
			SqlConnection conn = GetConnection();
			SqlCommand cmd = new SqlCommand(sql, conn);
			for (int i = 0; i < parameters.Length; i += 1) {
				cmd.Parameters.AddWithValue("@" + i, parameters[i]);
			}

			try {
				conn.Open();
				return cmd.ExecuteScalar();
			} finally {
				conn.Close();
			}
		}

		public static IEnumerable<SqlDataReader> ExecuteReader(string sql, params object[] parameters) {
			SqlConnection conn = GetConnection();
			SqlCommand cmd = new SqlCommand(sql, conn);
			for (int i = 0; i < parameters.Length; i += 1) {
				cmd.Parameters.AddWithValue("@" + i, parameters[i]);
			}

			SqlDataReader reader = null;
			try {
				conn.Open();
				reader = cmd.ExecuteReader();
				while (reader.Read()) {
					yield return reader;
				}
			} finally {
				reader?.Close();
				conn.Close();
			}
		}

		public static DataTable ExecuteQuery(string sql, params object[] parameters) {
			SqlConnection conn = GetConnection();
			SqlCommand cmd = new SqlCommand(sql, conn);
			for (int i = 0; i < parameters.Length; i += 1) {
				cmd.Parameters.AddWithValue("@" + i, parameters[i]);
			}

			try {
				DataTable dt = new DataTable();
				SqlDataAdapter adp = new SqlDataAdapter(cmd);
				adp.Fill(dt);
				return dt;
			} finally {
				conn.Close();
			}
		}
	}
}