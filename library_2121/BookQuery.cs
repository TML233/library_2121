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
	public partial class BookQuery : Form {
		public BookQuery() {
			InitializeComponent();
		}

		private void btnQuery_Click(object sender, EventArgs e) {
			Entities db = new Entities();

			var query = db.book.AsQueryable();
			
			string category = inputCategory.Text.Trim();
			string name = inputName.Text.Trim();
			string author = inputAuthor.Text.Trim();
			string publisher = inputPublisher.Text.Trim();

			if (!string.IsNullOrEmpty(category)) {
				query = query.Where(o => o.fenlei.Contains(category));
			}
			if (!string.IsNullOrEmpty(name)) {
				query = query.Where(o => o.shuming.Contains(name));
			}
			if (!string.IsNullOrEmpty(author)) {
				query = query.Where(o => o.zuozhe.Contains(author));
			}
			if (!string.IsNullOrEmpty(publisher)) {
				query = query.Where(o => o.chubanhse.Contains(publisher));
			}
			query = query.OrderByDescending(o => o.rkrq);
			
			
			dataBook.DataSource = query.Select(o => new { o.tsbh, o.fenlei, o.shuming, o.zuozhe, o.chubanhse, o.chubanriqi, o.dingjia, o.rkrq, o.zt, o.sfwz, o.beizhu }).ToList();
		}

		private void btnQuit_Click(object sender, EventArgs e) {
			Close();
		}

		private void BookQuery_Load(object sender, EventArgs e) {
			Entities db = new Entities();
			dataBook.DataSource = (from o in db.book orderby o.rkrq select new { o.tsbh, o.fenlei, o.shuming, o.zuozhe, o.chubanhse, o.chubanriqi, o.dingjia, o.rkrq, o.zt, o.sfwz, o.beizhu }).ToList(); 
		}
	}
}
