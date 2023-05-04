using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using library_2121.Data;

namespace library_2121 {
	public partial class UserManager : Form {
		public UserManager() {
			InitializeComponent();
		}

		private void Book_Load(object sender, EventArgs e) {
			RefreshData();
		}

		void RefreshData() {
			Entities db = new Entities();
			dataUser.DataSource = (from o in db.open1
								   where o.jibie=="a"
								   orderby o.cjsj descending
								   select new { o.user_name, o.name, o.card, o.email, o.phone, o.cjsj }).ToList();
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			string param = textBox.Text;
			Entities db = new Entities();
			if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "全部")
			{
				dataUser.DataSource = (from o in db.open1
									   where o.jibie == "a"
									   orderby o.cjsj descending
									   select new { o.user_name, o.name, o.card, o.email, o.phone, o.cjsj }).ToList();
			}
			else
			{
				dataUser.DataSource = (from o in db.open1
									   where o.jibie == "a"
									   where o.user_name == param
									   orderby o.cjsj descending
									   select new { o.user_name, o.name, o.card, o.email, o.phone, o.cjsj }).ToList();
			}
		}

		private void btnQuit_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			if (dataUser.RowCount == 0) {
				return;
			}
			if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
				DataGridViewRow dgvr = dataUser.CurrentRow;
				string id = Convert.ToString(dgvr.Cells["user_name"].Value);

				Entities db = new Entities();
				var user = (from o in db.open1 where o.user_name==id select o).FirstOrDefault();
				if (user == null) {
					MessageBox.Show("删除失败！", "软件提示");
				}
				db.open1.Remove(user);

				try {
					db.SaveChanges();
					MessageBox.Show("删除成功！", "软件提示");
				} catch {
					MessageBox.Show("删除失败！", "软件提示");
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			Form form = new UserInfo(UserInfo.Mode.AdminAdd);
			form.Owner = this;
			form.ShowDialog();
			RefreshData();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			Form form = new UserInfo(UserInfo.Mode.AdminEdit);
			form.Owner = this;
			form.ShowDialog();
			RefreshData();
		}
	}
}
