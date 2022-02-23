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
	public partial class TotalBooks : Form {
		public TotalBooks() {
			InitializeComponent();
		}

		private void TotalBooks_Load(object sender, EventArgs e) {
			var data = Utils.ExecuteQuery("SELECT COUNT(图书编号) AS count, SUM(定价) AS price from book", "total");
			string count = data.Tables["total"].Rows[0].ItemArray[0].ToString();
			string price = data.Tables["total"].Rows[0].ItemArray[1].ToString();
			label1.Text = string.Format("图书馆藏书总数为 {0} 本\n图书馆藏书总价为 {1} 元", count, price);
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
