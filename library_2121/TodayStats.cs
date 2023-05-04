using library_2121.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
			string title = null;
			Entities db = new Entities();
			DateTime now = DateTime.Now;
			object table = null;
			int count = 0;
			switch (mode) {
				case Mode.Enter: {
						title = "进书";
						var l = (from o in db.book where DbFunctions.DiffDays(o.rkrq, now) == 0 orderby o.rkrq descending select new { o.tsbh,o.fenlei,o.shuming,o.zuozhe,o.chubanhse,o.chubanriqi,o.dingjia,o.rkrq,o.zt,o.sfwz,o.beizhu}).ToList();
						count = l.Count;
						table = l;
					}
					break;
				case Mode.Return: {
						title = "还书";
						var l = (from o in db.borrow where DbFunctions.DiffDays(o.hssj, now) == 0 orderby o.hssj descending select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
						count = l.Count;
						table = l;
					}
					break;
				case Mode.Borrow: {
						title = "借书";
						var l = (from o in db.borrow where DbFunctions.DiffDays(o.jsrq, now) == 0 orderby o.jsrq descending select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
						count = l.Count;
						table = l;
					}
					break;
				case Mode.Expired: {
						title = "过期";
						var l = (from o in db.borrow where o.hssj == null where DbFunctions.DiffDays(o.hsrq, now) > 0 where o.zt=="否" orderby o.hsrq descending select new { o.ID, o.tsbh, o.shuming, o.jszh, o.name, o.jsrq, o.hsrq, o.zt, o.fkje, o.hssj }).ToList();
						count = l.Count;
						table = l;
					}
					break;
			}
			lblTitle.Text = string.Format("今日{0}", title);

			data.DataSource = table;

			labelTotal.Text = string.Format("今日{0}共 {1} 本", title, count);
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
