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
	public partial class BookManager : Form {
		public BookManager() {
			InitializeComponent();
		}

		private void Book_Load(object sender, EventArgs e) {
			RefreshData();
		}

		void RefreshData() {
			string sql = "SELECT * FROM book ORDER BY 入库日期 DESC";
			dataBook.DataSource = Utils.ExecuteQuery(sql).DefaultView;
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			string sql = "SELECT * FROM book ORDER BY 入库日期 DESC";
			string param = textBox.Text;
			if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "全部") {
				sql = "SELECT * FROM book ORDER BY 入库日期 DESC";
			} else if (radioId.Checked) {
				sql = "SELECT * FROM book WHERE 图书编号=@0 ORDER BY 入库日期 DESC";
			} else if (radioType.Checked) {
				sql = "SELECT * FROM book WHERE 分类=@0 ORDER BY 入库日期 DESC";
			} else if (radioName.Checked) {
				sql = "SELECT * FROM book WHERE 书名 LIKE @0 ORDER BY 入库日期 DESC";
				param = string.Format("%{0}%", textBox.Text);
			} else if (radioAuthor.Checked) {
				sql = "SELECT * FROM book WHERE 作者=@0 ORDER BY 入库日期 DESC";
			} else if (radioPublisher.Checked) {
				sql = "SELECT * FROM book WHERE 出版社=@0 ORDER BY 入库日期 DESC";
			}

			dataBook.DataSource = Utils.ExecuteQuery(sql, param).DefaultView;
		}

		private void btnQuit_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			if (dataBook.RowCount == 0) {
				return;
			}
			if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
				DataGridViewRow dgvr = dataBook.CurrentRow;
				string intId = Convert.ToString(dgvr.Cells["图书编号"].Value);
				if (Utils.ExecuteUpdate("Delete From book Where 图书编号 = @0", intId) > 0) {
					dataBook.Rows.Remove(dgvr);
					MessageBox.Show("删除成功！", "软件提示");
				} else {
					MessageBox.Show("删除失败！", "软件提示");
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			Form bookInfo = new BookInfo(false);
			bookInfo.Owner = this;
			bookInfo.ShowDialog();
			RefreshData();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			Form bookInfo = new BookInfo(true);
			bookInfo.Owner = this;
			bookInfo.ShowDialog();
			RefreshData();
		}
	}
}
