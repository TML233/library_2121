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

			Entities db = new Entities();
			var uu = (from o in db.open1
					  where o.user_name == user
					  select o).FirstOrDefault();
			if (uu == null) {
				MessageBox.Show("用户名错误！");
				return;
			}
			if (uu.jibie != "b") {
				MessageBox.Show("只能修改管理员！");
				return;
			}

			string oldPass = inputOld.Text;
			{
				if (uu.password != oldPass) {
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

			uu.password = password;
			try {
				db.SaveChanges();
				MessageBox.Show("修改成功！");
			} catch {
				MessageBox.Show("修改失败！");
			}
		}
	}
}
