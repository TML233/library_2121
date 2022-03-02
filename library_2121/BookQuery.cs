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
	public partial class BookQuery : Form {
		public BookQuery() {
			InitializeComponent();
		}

		StringBuilder sb = new StringBuilder();
		private void btnQuery_Click(object sender, EventArgs e) {
			sb.Clear();
			sb.Append("SELECT * FROM book");
			bool whereAdded = false;
			
			string category = inputCategory.Text.Trim();
			string name = inputName.Text.Trim();
			string author = inputAuthor.Text.Trim();
			string publisher = inputPublisher.Text.Trim();

			if (!string.IsNullOrEmpty(category)) {
				sb.Append(!whereAdded ? " WHERE " : " AND ");
				whereAdded = true;
				sb.Append(string.Format("分类 LIKE '%{0}%'", category));
			}
			if (!string.IsNullOrEmpty(name)) {
				sb.Append(!whereAdded ? " WHERE " : " AND ");
				whereAdded = true;
				sb.Append(string.Format("书名 LIKE '%{0}%'", name));
			}
			if (!string.IsNullOrEmpty(author)) {
				sb.Append(!whereAdded ? " WHERE " : " AND ");
				whereAdded = true;
				sb.Append(string.Format("作者 LIKE '%{0}%'", author));
			}
			if (!string.IsNullOrEmpty(publisher)) {
				sb.Append(!whereAdded ? " WHERE " : " AND ");
				whereAdded = true;
				sb.Append(string.Format("出版社 LIKE '%{0}%'", publisher));
			}
			sb.Append(" ORDER BY 入库日期 DESC");

			
			
			dataBook.DataSource = Utils.ExecuteQuery(sb.ToString()).DefaultView;
		}

		private void btnQuit_Click(object sender, EventArgs e) {
			Close();
		}

		private void BookQuery_Load(object sender, EventArgs e) {
			dataBook.DataSource = Utils.ExecuteQuery("SELECT * FROM book ORDER BY 入库日期 DESC").DefaultView;
		}
	}
}
