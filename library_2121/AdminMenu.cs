using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_2121
{
	public partial class AdminMenu : Form
	{
		public AdminMenu() {
			InitializeComponent();
		}

		private void 书籍基本信息管理ToolStripMenuItem_Click(object sender, EventArgs e) {
			new BookManager().ShowDialog();
		}

        private void 读者基本信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new ReaderManager().ShowDialog();
        }

		private void 用户基本信息管理ToolStripMenuItem_Click(object sender, EventArgs e) {
			new UserManager().ShowDialog();
		}

		private void 今日进书ToolStripMenuItem_Click(object sender, EventArgs e) {
			new TodayStats(TodayStats.Mode.Enter).ShowDialog();
		}

		private void 今日还书ToolStripMenuItem_Click(object sender, EventArgs e) {
			new TodayStats(TodayStats.Mode.Return).ShowDialog();
		}

		private void 今日借书ToolStripMenuItem_Click(object sender, EventArgs e) {
			new TodayStats(TodayStats.Mode.Borrow).ShowDialog();
		}

		private void 今日过期ToolStripMenuItem_Click(object sender, EventArgs e) {
			new TodayStats(TodayStats.Mode.Expired).ShowDialog();
		}

		private void 藏书总价及藏书总数ToolStripMenuItem_Click(object sender, EventArgs e) {
			new TotalBooks().ShowDialog();
		}

		private void 组合查询ToolStripMenuItem_Click(object sender, EventArgs e) {
			new BookQuery().ShowDialog();
		}

		private void 借书查询ToolStripMenuItem_Click(object sender, EventArgs e) {
			new BorrowQuery(true).ShowDialog();
		}

		private void 还书查询ToolStripMenuItem_Click(object sender, EventArgs e) {
			new BorrowQuery(false).ShowDialog();
		}

		private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e) {
			new PasswordChange().ShowDialog();
		}

		private void 借书ToolStripMenuItem_Click(object sender, EventArgs e) {
			new BorrowPage().ShowDialog();
		}

		private void 续签ToolStripMenuItem_Click(object sender, EventArgs e) {
			new ContinueBorrowPage().ShowDialog();
		}

		private void 预约ToolStripMenuItem_Click(object sender, EventArgs e) {
			new AppointmentPage().ShowDialog();
		}
	}
}
