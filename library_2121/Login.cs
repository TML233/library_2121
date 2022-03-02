using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace library_2121
{
	public partial class Login : Form
	{
		public Login() {
			InitializeComponent();
		}

		void InitInputs() {
			ClearInputs();
			GenerateCode();
			inputUser.Focus();
		}
		void ClearInputs() {
			inputUser.Clear();
			inputPassword.Clear();
			inputCode.Clear();
		}

		Random random = new Random();
		void GenerateCode() {
			lblCode.Text = random.Next(1000, 10000).ToString();
		}

		private void Login_Load(object sender, EventArgs e) {
			InitInputs();
		}

		private void btnNext_Click(object sender, EventArgs e) {
			string user = inputUser.Text.Trim();
			if (user.Length == 0) {
				MessageBox.Show("用户名不能为空！");
				return;
			}
			string password = inputPassword.Text;
			if (password.Length == 0) {
				MessageBox.Show("密码不能为空！");
				return;
			}
			string code = inputCode.Text.Trim();
			if (code.Length == 0) {
				MessageBox.Show("验证码不能为空！");
				return;
			}
			if (code != lblCode.Text) {
				MessageBox.Show("验证码错误！");
				return;
			}

			int result = 0;
			foreach (var reader in Utils.ExecuteReader("SELECT * FROM open1 WHERE 用户名=@0 AND 口令=@1", user, password)) {
				if (radioUser.Checked && reader["级别"].ToString().Trim() == "a") {
					result = 1;
					break;
				}
				if (radioAdmin.Checked && reader["级别"].ToString().Trim() == "b") {
					result = 2;
					break;
				}
			}

			if (result == 0) {
				if (MessageBox.Show("用户名或密码错误！是否重新输入？", "登陆失败", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					InitInputs();
				} else {
					GenerateCode();
				}
			} else if (result == 1) {
				InitInputs();
				var main = new UserMenu();
				main.ShowDialog();
			} else if (result == 2) {
				InitInputs();
				var main = new AdminMenu();
				main.ShowDialog();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			ClearInputs();
		}

		private void btnClose_Click(object sender, EventArgs e) {
			Close();
		}

		private void lblCode_Click(object sender, EventArgs e) {
			GenerateCode();
		}

		private void linkGenerateCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			GenerateCode();
		}

		private void btnRegister_Click(object sender, EventArgs e) {
			new UserInfo().ShowDialog();
		}
	}
}