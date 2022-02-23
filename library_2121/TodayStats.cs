using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_2121 {
	public partial class TodayStats : Form {
		public TodayStats(Mode mode) {
			this.mode = mode;
			InitializeComponent();
		}

		public enum Mode {
			Enter,
			Return,
			Borrow,
			Expired
		}
		Mode mode;

		private void TodayStats_Load(object sender, EventArgs e) {
			string sql=null;
			string title = null;
			switch (mode) {
				case Mode.Enter:
					title = "进书";
					sql = "SELECT * FROM book WHERE DATEDIFF(DAY,入库日期,SYSDATETIME())=0 ORDER BY 入库日期 DESC";
					break;
				case Mode.Return:
					title = "还书";
					sql = "SELECT * FROM borrow WHERE DATEDIFF(DAY,还书时间,SYSDATETIME())=0 ORDER BY 还书时间 DESC";
					break;
				case Mode.Borrow:
					title = "借书";
					sql = "SELECT * FROM borrow WHERE DATEDIFF(DAY,借书日期,SYSDATETIME())=0 ORDER BY 借书日期 DESC";
					break;
				case Mode.Expired:
					title = "过期";
					sql = "SELECT * FROM borrow WHERE 还书时间 IS NULL AND DATEDIFF(DAY,还书日期,SYSDATETIME())>0 ORDER BY 还书日期 DESC";
					break;
			}
			lblTitle.Text = string.Format("今日{0}", title);

			var set = Utils.ExecuteQuery(sql, "today");
			data.DataSource = set.Tables["today"].DefaultView;

			labelTotal.Text = string.Format("今日{0}共 {1} 本", title, set.Tables["today"].DefaultView.Count);
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
