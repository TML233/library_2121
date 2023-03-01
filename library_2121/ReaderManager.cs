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
	public partial class ReaderManager : Form {
		public ReaderManager() {
			InitializeComponent();
		}

		private void Book_Load(object sender, EventArgs e) {
			RefreshData();
		}
		void RefreshData()
		{
			Entities db = new Entities();
			dataReader.DataSource = (from o in db.reader
									 orderby o.djrq descending
									 select o).ToList();
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			Entities db = new Entities();
			string param = textBox.Text;
			if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "全部") {
				dataReader.DataSource = (from o in db.reader
										 orderby o.djrq descending
										 select o).ToList();
			}else if (radioId.Checked) {
				dataReader.DataSource = (from o in db.reader
										 where o.jszh==param
										 orderby o.djrq descending
										 select o).ToList();
			} else if (radioName.Checked) {
				dataReader.DataSource = (from o in db.reader
										 where o.name.Contains(param)
										 orderby o.djrq descending
										 select o).ToList();
			} else {
				dataReader.DataSource = (from o in db.reader
										 orderby o.djrq descending
										 select o).ToList();
			}
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
				string intId = Convert.ToString(dgvr.Cells["jszh"].Value);
				Entities db = new Entities();
				reader reader = (from o in db.reader
								 where o.jszh == intId
								 select o).FirstOrDefault();
				if (reader == null) {
					MessageBox.Show("删除失败！", "软件提示");
					return;
				}
				db.reader.Remove(reader);
				db.SaveChanges();
				dataReader.Rows.Remove(dgvr);
				MessageBox.Show("删除成功！", "软件提示");
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
