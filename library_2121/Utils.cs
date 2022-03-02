using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace library_2121 {
	public class Utils {
		public static string ConnectionString => ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

		public static (SqlConnection,SqlCommand) Prepare(string sql,params object[] args) {
			var conn = new SqlConnection(ConnectionString);
			var cmd = new SqlCommand(sql, conn);
			for (int i = 0; i < args.Length; i += 1) {
				cmd.Parameters.AddWithValue("@" + i, args[i]);
			}
			return (conn, cmd);
		}
		public static int ExecuteUpdate(string sql,params object[] args) {
			var pair = Prepare(sql, args);
			var conn = pair.Item1;
			var cmd = pair.Item2;

			try {
				conn.Open();
				int affected=cmd.ExecuteNonQuery();
				return affected;
			} finally {
				conn.Close();
			}
		}

		public static object ExecuteScalar(string sql, params object[] args) {
			var pair = Prepare(sql, args);
			var conn = pair.Item1;
			var cmd = pair.Item2;

			try {
				conn.Open();
				return cmd.ExecuteScalar();
			} finally {
				conn.Close();
			}
		}

		public static IEnumerable<SqlDataReader> ExecuteReader(string sql, params object[] args) {
			var pair = Prepare(sql, args);
			var conn = pair.Item1;
			var cmd = pair.Item2;

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

		public static DataTable ExecuteQuery(string sql, params object[] args) {
			var pair = Prepare(sql, args);
			var conn = pair.Item1;
			var cmd = pair.Item2;

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