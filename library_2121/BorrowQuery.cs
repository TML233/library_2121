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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace library_2121 {
	public partial class BorrowQuery : Form {
		public bool borrow = false;
		public BorrowQuery(bool borrow) {
			this.borrow = borrow;
			InitializeComponent();
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			string param = textBox.Text;
			var date = inputDate.Value.Date;
			object table = null;
			int count = 0;
			Entities db = new Entities();
			if (!radioDate.Checked) {
				if (string.IsNullOrWhiteSpace(textBox.Text)) {
					var l = (from o in db.borrow
							 where borrow ? o.hssj == null : o.hssj != null
							 orderby borrow ? o.jsrq : o.hsrq descending
							 select new { o.ID,o.tsbh,o.shuming,o.jszh,o.name,o.jsrq,o.hsrq,o.zt,o.fkje,o.hssj}).ToList();
					count = l.Count;
					table = l;
				} else if (radioId.Checked) {
					var l = (from o in db.borrow
							 where borrow ? o.hssj == null : o.hssj != null
							 where o.tsbh == param
							 orderby borrow ? o.jsrq : o.hsrq descending
							 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
					count = l.Count;
					table = l;
				} else if (radioCard.Checked) {
					var l = (from o in db.borrow
							 where borrow ? o.hssj == null : o.hssj != null
							 where o.jszh == param
							 orderby borrow ? o.jsrq : o.hsrq descending
							 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
					count = l.Count;
					table = l;
				} else if (radioBookName.Checked) {
					var l = (from o in db.borrow
							 where borrow ? o.hssj == null : o.hssj != null
							 where o.shuming.Contains(param)
							 orderby borrow ? o.jsrq : o.hsrq descending
							 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
					count = l.Count;
					table = l;
				} else if (radioCardName.Checked) {
					var l = (from o in db.borrow
							 where borrow ? o.hssj == null : o.hssj != null
							 where o.name == param
							 orderby borrow ? o.jsrq : o.hsrq descending
							 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
					count = l.Count;
					table = l;
				}
			} else {
				if (borrow) {
					var l = (from o in db.borrow
							 where borrow ? o.hssj == null : o.hssj != null
							 where o.hssj == date
							 orderby borrow ? o.jsrq : o.hsrq descending
							 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
					count = l.Count;
					table = l;
				} else {
					var l = (from o in db.borrow
							 where borrow ? o.hssj == null : o.hssj != null
							 where o.hssj == date
							 orderby borrow ? o.jsrq : o.hsrq descending
							 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
					count = l.Count;
					table = l;
				}
			}

			dataBook.DataSource = table;
			lblCount.Text = $"共 {count} 个结果。";
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

			Entities db = new Entities();
			var l = (from o in db.borrow
					 where borrow ? o.hssj == null : o.hssj != null
					 orderby borrow ? o.jsrq : o.hsrq descending
					 select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
			var count = l.Count;
			var table = l;
			dataBook.DataSource = table;
			lblCount.Text = $"共 {count} 个结果。";
		}
	}
}
