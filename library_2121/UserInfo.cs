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
using library_2121.Data;

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
				string uname= user.dataUser.CurrentRow.Cells["user_name"].Value.ToString();
				inputUser.Text = uname;
				inputName.Text = user.dataUser.CurrentRow.Cells["name"].Value.ToString();
				Entities db = new Entities();
				string password = (from o in db.open1 where o.user_name == uname select o.password).FirstOrDefault();
				inputPassword.Text = password;
				inputPassword2.Text = password;
				inputIden.Text = user.dataUser.CurrentRow.Cells["card"].Value.ToString();
				inputEmail.Text = user.dataUser.CurrentRow.Cells["email"].Value.ToString();
				inputPhone.Text = user.dataUser.CurrentRow.Cells["phone"].Value.ToString();
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

			Entities db = new Entities();
			if (mode != Mode.AdminEdit) {
				var uu = (from o in db.open1 where o.user_name == user select o).FirstOrDefault();
				if (uu != null) {
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
				var uu = new open1 {
					user_name = user,
					password = password,
					jibie = "a",
					name = name,
					card = iden,
					email = email,
					phone = phone,
					cjsj = DateTime.Now
				};
				db.open1.Add(uu);
				try {
					db.SaveChanges();
					MessageBox.Show("注册成功！");
				} catch {
					MessageBox.Show("注册失败！");
				}
			} else {
				var uu = (from o in db.open1 where o.user_name == user select o).FirstOrDefault();
				if (uu == null) {
					MessageBox.Show("修改失败！");
					return;
				} else {
					uu.password = password;
					uu.name = name;
					uu.jibie = iden;
					uu.email = email;
					uu.phone = phone;
					try {
						db.SaveChanges();
						MessageBox.Show("修改成功！");
					} catch {
						MessageBox.Show("修改失败！");
					}
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
