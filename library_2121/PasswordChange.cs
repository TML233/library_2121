using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace library_2121 {
	public partial class PasswordChange : Form {
		public PasswordChange() {
			InitializeComponent();
		}
		private void Register_Load(object sender, EventArgs e) {
			
		}

		private void btnNext_Click(object sender, EventArgs e) {
			string user = inputUser.Text.Trim();
			if (user.Length < 4) {
				MessageBox.Show("用户名至少 4 位！");
				return;
			}

			{
				SqlConnection conn = new SqlConnection(Utils.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM open1 WHERE 用户名=@User", conn);
				cmd.Parameters.AddWithValue("@User", user);
				var reader = cmd.ExecuteReader();
				bool has = false;
				if (reader.Read()) {
					has = true;
				}
				conn.Close();
				if (!has) {
					MessageBox.Show("用户名错误！");
					return;
				}
			}

			string oldPass = inputOld.Text;
			{
				SqlConnection conn = new SqlConnection(Utils.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM open1 WHERE 用户名=@User AND 口令=@Old", conn);
				cmd.Parameters.AddWithValue("@User", user);
				cmd.Parameters.AddWithValue("@Old", oldPass);
				var reader = cmd.ExecuteReader();
				bool has = false;
				if (reader.Read()) {
					has = true;
				}
				conn.Close();
				if (!has) {
					MessageBox.Show("旧密码错误！");
					return;
				}
			}

			string password = inputPassword.Text;
			if (password.Length < 6) {
				MessageBox.Show("新密码至少 6 位！");
				return;
			}
			if (!Regex.IsMatch(password, @"[a-zA-Z]+")) {
				MessageBox.Show("新密码需要包含英文字母！");
				return;
			}

			if (inputPassword2.Text != password) {
				MessageBox.Show("确认密码不匹配！");
				return;
			}

			int affected = Utils.ExecuteUpdate(
				"UPDATE open1 set 口令=@Password WHERE 用户名=@User",
				("@User", user), ("@Password", password)
			);
			if (affected > 0) {
				MessageBox.Show("修改成功！");
				Close();
			} else {
				MessageBox.Show("修改失败！");
			}
		}
	}
}
