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
	public partial class BookManager : Form {
		public BookManager() {
			InitializeComponent();
		}

		private void Book_Load(object sender, EventArgs e) {
			RefreshData();
		}

		void RefreshData() {
			Entities db = new Entities();
			dataBook.DataSource = (from o in db.book
								   orderby o.rkrq descending
								   select o).ToList();
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			Entities db = new Entities();
			object dt;
			string param = textBox.Text;
			if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "全部") {
				dt = (from o in db.book
					 orderby o.rkrq descending
					 select o).ToList();
			} else if (radioId.Checked) {
				dt= (from o in db.book
					where o.tsbh==param
					orderby o.rkrq descending
					select o).ToList();
			} else if (radioType.Checked) {
				dt = (from o in db.book
					 where o.fenlei == param
					 orderby o.rkrq descending
					 select o).ToList();
			} else if (radioName.Checked) {
				dt = (from o in db.book
					 where o.shuming.Contains(param)
					 orderby o.rkrq descending
					 select o).ToList();
			} else if (radioAuthor.Checked) {
				dt = (from o in db.book
					 where o.zuozhe == param
					 orderby o.rkrq descending
					 select o).ToList();
			} else if (radioPublisher.Checked) {
				dt = (from o in db.book
					 where o.chubanhse == param
					 orderby o.rkrq descending
					 select o).ToList();
			} else {
				dt = (from o in db.book
					 orderby o.rkrq descending
					 select o).ToList();
			}

			dataBook.DataSource = dt;
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
				string intId = Convert.ToString(dgvr.Cells["tsbh"].Value);
				Entities db = new Entities();
				book book = (from o in db.book
							 where o.tsbh == intId
							 select o).FirstOrDefault();
				if (book == null) {
					MessageBox.Show("删除失败！", "软件提示");
					return;
				}

				db.book.Remove(book);
				db.SaveChanges();
				dataBook.Rows.Remove(dgvr);
				MessageBox.Show("删除成功！", "软件提示");
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
