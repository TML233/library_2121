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

namespace library_2121 {
	public partial class UserManager : Form {
		public UserManager() {
			InitializeComponent();
		}

		private void Book_Load(object sender, EventArgs e) {
			RefreshData();
		}

		void RefreshData() {
			string sql = "SELECT * FROM open1 ORDER BY 创建时间 DESC";
			dataUser.DataSource = Utils.ExecuteQuery(sql).DefaultView;
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			string sql = "SELECT * FROM open1 ORDER BY 创建时间 DESC";
			string param = textBox.Text;
			if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "全部")
			{
				sql = "SELECT * FROM open1 ORDER BY 创建时间 DESC";
			}
			else
			{
				sql = "SELECT * FROM open1 WHERE 用户名={0} ORDER BY 创建时间 DESC";
			}
			
			dataUser.DataSource = Utils.ExecuteQuery(sql, param).DefaultView;
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
				string intId = Convert.ToString(dgvr.Cells["用户名"].Value);
				if (Utils.ExecuteUpdate("Delete From open1 Where 用户名 = @0", intId) >0) {
					dataUser.Rows.Remove(dgvr);
					MessageBox.Show("删除成功！", "软件提示");
				} else {
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
