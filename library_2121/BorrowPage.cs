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
			data.DataSource = Utils.ExecuteQuery("SELECT * FROM borrow WHERE 借书证号=@0 AND 还书时间 IS NULL", "data", card).DefaultView;
		}
		private void inputCard_TextChanged(object sender, EventArgs e) {
			RefreshData(inputCard.Text);
		}

		private void btnSubmit_Click(object sender, EventArgs e) {
			var conn = Utils.GetConnection();
			try {
				conn.Open();
				{
					var sc = Utils.ExecuteScalar("SELECT COUNT(借书证号) FROM reader WHERE 借书证号=@0", inputCard.Text);
					if ((int)sc == 0) {
						MessageBox.Show("没有此借书证号！", "错误");
						return;
					}
				}
				{
					var sc = Utils.ExecuteScalar("SELECT 挂失 FROM reader WHERE 借书证号=@0", inputCard.Text);
					if ((sc as string) == "挂失") {
						MessageBox.Show("该卡已被挂失！", "错误");
						return;
					}
				}
				{
					var sc = Utils.ExecuteScalar("SELECT 状态 FROM book WHERE 图书编号=@0", inputBook.Text) as string;
					if (sc == null) {
						MessageBox.Show("没有此图书编号！", "错误");
						return;
					}
					if (sc == "借") {
						MessageBox.Show("该图书已借出！", "错误");
						return;
					}
				}
				{
				}
				{
					var sc = Utils.ExecuteScalar("SELECT COUNT(*) FROM yuyue book WHERE 图书编号=@0 AND 有效期限>@1 AND 借书证号=@2", inputBook.Text, DateTime.Today, inputCard.Text);
					if ((int)sc > 0) {
						try {
							var sqlR0 = Utils.ExecuteUpdate("UPDATE book SET 状态='借' WHERE 图书编号=@0", inputBook.Text) > 0;

							var type = Utils.ExecuteScalar("SELECT 级别 FROM reader WHERE 借书证号=@0", inputCard.Text).ToString();
							var borrowTime = DateTime.Today;
							var returnTime = borrowTime.AddDays(type == "B" ? 180 : 90);
							var sqlR1 = Utils.ExecuteUpdate(
								String.Format(
									"INSERT INTO borrow(图书编号,书名,借书证号,姓名,借书日期,状态,罚款金额,还书日期) SELECT 图书编号,书名,借书证号,姓名,'{0}','否',0 FROM book,reader,'{1}' WHERE book.图书编号=@0 AND reader.借书证号=@1",
									borrowTime, returnTime
								),
								inputBook.Text, inputCard.Text
							) > 0;

							Utils.ExecuteUpdate("DELETE FROM yuyue where 图书编号=@0 AND 有效期限>@1 AND 借书证号=@2", inputBook.Text, DateTime.Today, inputCard.Text);

							var sqlR2 = Utils.ExecuteUpdate("UPDATE reader set 已借书数=已借书数+1 WHERE 借书证号=@0", inputCard.Text) > 0;

							if (!sqlR0 || !sqlR1 || !sqlR2) {
								throw new Exception();
							}

							MessageBox.Show("借书成功！");
						} catch {
							MessageBox.Show("借书失败！");
						}
					}
				}

			} finally {
				conn?.Close();
			}
			RefreshData(inputCard.Text);
		}

		private void BorrowPage_Load(object sender, EventArgs e) {
			var conn = Utils.GetConnection();
			conn.Open();
			
		}
	}
}
