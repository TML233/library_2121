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
	public partial class UserInfo : Form {
		public enum Mode {
			UserRegister,
			AdminAdd,
			AdminEdit
		}
		Mode mode;
		UserManager user;
		public UserInfo(Mode mode = Mode.UserRegister) {
			InitializeComponent();
			this.mode = mode;
		}

		Random random = new Random();
		void GenerateCode() {
			lblCode.Text = random.Next(1000, 10000).ToString();
		}

		private void Register_Load(object sender, EventArgs e) {
			GenerateCode();
			switch (mode) {
				case Mode.UserRegister:
					lblTitle.Text = "注册用户";
					break;
				case Mode.AdminAdd:
					lblTitle.Text = "添加用户";
					break;
				case Mode.AdminEdit:
					lblTitle.Text = "修改用户";
					break;
			}
			if (mode != Mode.UserRegister) {
				linkGenerateCode.Enabled = false;
				inputCode.ReadOnly = true;
				lblCode.Text = "无需";
				user = (UserManager)Owner;
			}
			if (mode == Mode.AdminEdit) {
				inputUser.ReadOnly = true;
				inputUser.Text = user.dataUser.CurrentRow.Cells["用户名"].Value.ToString();
				inputName.Text = user.dataUser.CurrentRow.Cells["姓名"].Value.ToString();
				inputPassword.Text = user.dataUser.CurrentRow.Cells["口令"].Value.ToString();
				inputPassword2.Text = user.dataUser.CurrentRow.Cells["口令"].Value.ToString();
				inputIden.Text = user.dataUser.CurrentRow.Cells["身份证号"].Value.ToString();
				inputEmail.Text = user.dataUser.CurrentRow.Cells["邮箱"].Value.ToString();
				inputPhone.Text = user.dataUser.CurrentRow.Cells["手机号码"].Value.ToString();
			}
		}

		private void linkGenerateCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			GenerateCode();
		}

		private void btnNext_Click(object sender, EventArgs e) {
			string user = inputUser.Text.Trim();
			if (user.Length < 4) {
				MessageBox.Show("用户名至少 4 位！");
				return;
			}

			if (mode != Mode.AdminEdit) {
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
				if (has) {
					MessageBox.Show("用户名重复！");
					return;
				}
			}

			string password = inputPassword.Text;
			if (password.Length < 6) {
				MessageBox.Show("密码至少 6 位！");
				return;
			}
			if (!Regex.IsMatch(password, @"[a-zA-Z]+")) {
				MessageBox.Show("密码需要包含英文字母！");
				return;
			}

			if (inputPassword2.Text != password) {
				MessageBox.Show("确认密码不匹配！");
				return;
			}

			string name = inputName.Text.Trim();
			if (name.Length == 0) {
				MessageBox.Show("姓名不能为空！");
				return;
			}
			string iden = inputIden.Text.Trim();
			if (iden.Length == 0) {
				MessageBox.Show("身份证号不能为空！");
				return;
			}
			if (!Regex.IsMatch(iden, @"(^\d{15}$)|(^\d{17}(x|X|\d)$)")) {
				MessageBox.Show("身份证号格式不正确！");
				return;
			}

			string email = inputEmail.Text.Trim();
			if (email.Length == 0) {
				MessageBox.Show("邮箱不能为空！");
				return;
			}
			if (!Regex.IsMatch(email, @"^[0-9A-Za-z_-]+@[0-9A-Za-z_-]+(\.[0-9A-Za-z_-]+)+$")) {
				MessageBox.Show("邮箱格式不正确！");
				return;
			}
			string phone = inputPhone.Text.Trim();
			if (phone.Length != 11) {
				MessageBox.Show("手机号必须为 11 位！");
				return;
			}

			if (mode == Mode.UserRegister) {
				string code = inputCode.Text.Trim();
				if (code.Length == 0) {
					MessageBox.Show("验证码不能为空！");
					return;
				}
				if (code != lblCode.Text) {
					MessageBox.Show("验证码错误！");
					return;
				}
			}

			if (mode != Mode.AdminEdit) {
				int affected = Utils.ExecuteUpdate(
					"INSERT INTO open1(用户名,口令,级别,姓名,身份证号,邮箱,手机号码,创建时间) VALUES(@User,@Password,@Type,@Name,@Iden,@Email,@Phone,@Time)",
					("@User", user), ("@Password", password), ("@Type", "a"),
					("@Name", name), ("@Iden", iden), ("@Email", email),
					("@Phone", phone), ("@Time", DateTimeOffset.Now.ToString())
				);
				if (affected > 0) {
					MessageBox.Show("注册成功！");
					Close();
				} else {
					MessageBox.Show("注册失败！");
				}
			} else {
				int affected = Utils.ExecuteUpdate(
					"UPDATE open1 set 口令=@Password, 级别=@Type, 姓名=@Name, 身份证号=@Iden, 邮箱=@Email, 手机号码=@Phone WHERE 用户名=@User",
					("@User", user), ("@Password", password), ("@Type", "a"),
					("@Name", name), ("@Iden", iden), ("@Email", email),
					("@Phone", phone)
				);
				if (affected > 0) {
					MessageBox.Show("修改成功！");
					Close();
				} else {
					MessageBox.Show("修改失败！");
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
