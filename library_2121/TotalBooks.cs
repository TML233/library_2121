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
	public partial class TotalBooks : Form {
		public TotalBooks() {
			InitializeComponent();
		}

		private void TotalBooks_Load(object sender, EventArgs e) {
			Entities db = new Entities();
			var data = (from o in db.book
						group o by 1 into grp
						select new {
							count = grp.Count(),
							price = grp.Sum(o => o.dingjia)
						}
						).First();
			int count = data.count;
			double price = data.price;
			label1.Text = string.Format("图书馆藏书总数为 {0} 本\n图书馆藏书总价为 {1} 元", count, price);
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
