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
	public partial class BorrowPage : Form {
		public BorrowPage() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}

		void RefreshData(string card) {
			var set = Utils.ExecuteQuery("SELECT * FROM borrow WHERE 借书证号=@Card AND 还书时间 IS NULL", "data", ("@Card", card));
			data.DataSource = set.Tables["data"].DefaultView;
		}
		private void inputCard_TextChanged(object sender, EventArgs e) {
			RefreshData(inputCard.Text);
		}

		private void btnSubmit_Click(object sender, EventArgs e) {
			var conn = Utils.GetConnection();
			try {
				conn.Open();
				{
					var cmd = new SqlCommand("SELECT COUNT(借书证号) FROM reader WHERE 借书证号=@Card", conn);
					cmd.Parameters.AddWithValue("@Card", inputCard.Text);
					bool result = (int)cmd.ExecuteScalar() != 0;
					if (!result) {
						MessageBox.Show("没有此借书证号！", "错误");
						return;
					}
				}
				{
					var cmd = new SqlCommand("SELECT 状态 FROM book WHERE 图书编号=@Book", conn);
					cmd.Parameters.AddWithValue("@Book", inputBook.Text);
					var result = cmd.ExecuteScalar() as string;
					if (result==null) {
						MessageBox.Show("没有此图书编号！", "错误");
						return;
					}
					if (result != "否") {
						MessageBox.Show("该图书已借出！", "错误");
						return;
					}
				}
				int aff1=Utils.ExecuteUpdate("UPDATE book SET 状态='借' WHERE 图书编号=@Book", ("@Book", inputBook.Text));

			} finally {
				conn?.Close();
			}
			RefreshData(inputCard.Text);
		}
	}
}
