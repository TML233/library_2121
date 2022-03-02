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
	public partial class ReaderManager : Form {
		public ReaderManager() {
			InitializeComponent();
		}

		private void Book_Load(object sender, EventArgs e) {
			RefreshData();
		}
		void RefreshData()
		{
			string sql = "SELECT * FROM reader ORDER BY 登记日期 DESC";
			dataReader.DataSource = Utils.ExecuteQuery(sql).DefaultView;
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			string sql = "SELECT * FROM reader ORDER BY 登记日期 DESC";
			string param = textBox.Text;
			if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "全部") {
				sql = "SELECT * FROM reader ORDER BY 登记日期 DESC";
			}else if (radioId.Checked) {
				sql = "SELECT * FROM reader WHERE 借书证号=@0 ORDER BY 登记日期 DESC";
			}else if (radioName.Checked) {
				sql = "SELECT * FROM reader WHERE 姓名 LIKE @0 ORDER BY 登记日期 DESC";
				param = string.Format("%{0}%", textBox.Text);
			}
			
			dataReader.DataSource = Utils.ExecuteQuery(sql, param).DefaultView;
		}

		private void btnQuit_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			if (dataReader.RowCount == 0) {
				return;
			}
			if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
				DataGridViewRow dgvr = dataReader.CurrentRow;
				string intId = Convert.ToString(dgvr.Cells["借书证号"].Value);
				if (Utils.ExecuteUpdate("Delete From reader Where 借书证号 = @0", intId) > 0) {
					dataReader.Rows.Remove(dgvr);
					MessageBox.Show("删除成功！", "软件提示");
				} else {
					MessageBox.Show("删除失败！", "软件提示");
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			Form form = new ReaderInfo(false);
			form.Owner = this;
			form.ShowDialog();
			RefreshData();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			Form form = new ReaderInfo(true);
			form.Owner = this;
			form.ShowDialog();
			RefreshData();
		}
	}
}
