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
	public partial class BorrowQuery : Form {
		public bool borrow = false;
		string orderby = "";
		string limit = "";
		public BorrowQuery(bool borrow) {
			this.borrow = borrow;
			orderby = borrow ? "借书日期" : "还书日期";
			limit = borrow ? "还书时间 IS NULL" : "还书时间 IS NOT NULL";
			InitializeComponent();
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			string sql = "SELECT * FROM borrow ORDER BY {1} DESC";
			string param = textBox.Text;
			string date = inputDate.Text;
			if (!radioDate.Checked && string.IsNullOrWhiteSpace(textBox.Text)) {
				sql = "SELECT * FROM borrow WHERE {0} ORDER BY {1} DESC";
			} else if (radioId.Checked) {
				sql = "SELECT * FROM borrow WHERE {0} AND 图书编号=@Param ORDER BY {1} DESC";
			} else if (radioCard.Checked) {
				sql = "SELECT * FROM borrow WHERE {0} AND 借书证号=@Param ORDER BY {1} DESC";
			} else if (radioBookName.Checked) {
				sql = "SELECT * FROM borrow WHERE {0} AND 书名 LIKE @Param ORDER BY {1} DESC";
				param = string.Format("%{0}%", textBox.Text);
			} else if (radioCardName.Checked) {
				sql = "SELECT * FROM borrow WHERE {0} AND 姓名=@Param ORDER BY {1} DESC";
			} else if (radioDate.Checked) {
				if (borrow) {
					sql = "SELECT * FROM borrow WHERE {0} AND 借书日期=@Param ORDER BY {1} DESC";
				} else {
					sql = "SELECT * FROM borrow WHERE {0} AND 还书日期=@Param ORDER BY {1} DESC";
				}
			}

			string finalSql = string.Format(sql, limit, orderby);
			var set=Utils.ExecuteQuery(finalSql, "book", ("@Param", !radioDate.Checked?param:date));
			dataBook.DataSource = set.Tables["book"].DefaultView;
		}

		private void btnQuit_Click(object sender, EventArgs e) {
			Close();
		}

		void SetInputBox(bool date) {
			textBox.Visible = !date;
			inputDate.Visible = date;
		}
		
		private void radioId_CheckedChanged(object sender, EventArgs e) {
			SetInputBox(false);
		}

		private void radioCard_CheckedChanged(object sender, EventArgs e) {
			SetInputBox(false);
		}

		private void radioBookName_CheckedChanged(object sender, EventArgs e) {
			SetInputBox(false);
		}

		private void radioCardName_CheckedChanged(object sender, EventArgs e) {
			SetInputBox(false);
		}

		private void radioDate_CheckedChanged(object sender, EventArgs e) {
			SetInputBox(true);
		}

		private void BorrowQuery_Load(object sender, EventArgs e) {
			lblTitle.Text = borrow ? "借书查询" : "还书查询";
		}
	}
}
