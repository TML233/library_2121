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
	public partial class ContinueBorrowPage : Form {
		public ContinueBorrowPage() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}

		void RefreshData(string bookId) {
			Entities db = new Entities();
			data.DataSource = (from o in db.borrow where o.tsbh == bookId where o.zt == "否" where o.fkje == 0 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
		}

		private void btnSubmit_Click(object sender, EventArgs e) {
			if(data.SelectedCells.Count <= 0) {
				MessageBox.Show("请先选择条目。");
				return;
			}
			var bId = (int)((data.SelectedCells[0].OwningRow.DataBoundItem as dynamic).ID);
			Entities db = new Entities();
			var borrow = (from o in db.borrow where o.ID == bId select o).FirstOrDefault();
			if (borrow == null) {
				MessageBox.Show("没有此条目！");
				return;
			}
			var reader = (from o in db.reader where o.jszh == borrow.jszh select o).FirstOrDefault();
			if (reader == null) {
				MessageBox.Show("没有此借书证！");
				return;
			}
			int addDays = reader.jibie == "A" ? 90 : 180;
			borrow.jsrq = DateTime.Now;
			borrow.hsrq = borrow.jsrq.AddDays(addDays);
			try {
				db.SaveChanges();
				MessageBox.Show("续借成功！");
				RefreshData(inputBook.Text);
			} catch {
				MessageBox.Show("续借失败！");
			}
		}

		private void BorrowPage_Load(object sender, EventArgs e) {
			//var conn = Utils.GetConnection();
			//conn.Open();
			
		}

		private void button2_Click(object sender, EventArgs e) {
			RefreshData(inputBook.Text);
		}
	}
}
