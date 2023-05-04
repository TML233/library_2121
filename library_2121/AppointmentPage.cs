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
	public partial class AppointmentPage : Form {
		public AppointmentPage() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}

		void RefreshDataCard(string card) {
			Entities db = new Entities();
			data.DataSource = (from o in db.yuyue where o.jszh == card select o).ToList();
		}
		void RefreshDataBook(string book) {
			Entities db = new Entities();
			data.DataSource = (from o in db.yuyue where o.tsbh == book select o).ToList();
		}
		void RefreshData() {
			if (radioBook.Checked) {
				RefreshDataBook(inputQuery.Text);
			}else if (radioReader.Checked) {
				RefreshDataCard(inputQuery.Text);
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e) {
			Entities db = new Entities();
			var reader = (from o in db.reader where o.jszh == inputCard.Text select o).FirstOrDefault();
			if (reader == null) {
				MessageBox.Show("没有此借书证号！", "错误");
				return;
			}
			if (reader.guashi == "挂失") {
				MessageBox.Show("该卡已被挂失！", "错误");
				return;
			}
			var book =(from o in db.book where o.tsbh==inputBook.Text select o).FirstOrDefault();
			if (book == null) {
				MessageBox.Show("没有此图书编号！", "错误");
				return;
			}
			if (book.zt == "借") {
				MessageBox.Show("该图书已借出！", "错误");
				return;
			}

			int yuyueCount=(from o in db.yuyue where o.tsbh==book.tsbh select o).Count();

			if (yuyueCount > 0) {
				MessageBox.Show("该图书已被预约！", "错误");
				return;
			}
			var yuyue = new yuyue {
				jszh = reader.jszh,
				name = reader.name,
				tsbh = book.tsbh,
				shuming = book.shuming,
				yuyueriqi = DateTime.Today,
				yxsx = DateTime.Today.AddDays(3)
			};
			db.yuyue.Add(yuyue);
			try {
				db.SaveChanges();
				MessageBox.Show("预约成功！");
				RefreshDataCard(reader.jszh);
			} catch {
				MessageBox.Show("预约失败！", "错误");
			}
		}

		private void BorrowPage_Load(object sender, EventArgs e) {
			Entities db = new Entities();
			var today = DateTime.Today;
			db.yuyue.RemoveRange(from o in db.yuyue where o.yxsx < today select o);
			db.SaveChanges();
		}
	}
}
