using library_2121.Data;
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
	public partial class BookInfo : Form {
		bool editMode;
		BookManager book = null;
		public BookInfo(bool edit) {
			InitializeComponent();
			editMode = edit;
		}

		private void BookInfo_Load(object sender, EventArgs e) {
			lblTitle.Text = editMode ? "书籍修改" : "书籍添加";
			book = (BookManager)Owner;
			if (editMode) {
				inputId.ReadOnly = true;
				inputId.Text = book.dataBook.CurrentRow.Cells["tsbh"].Value.ToString();
				inputCategory.Text = book.dataBook.CurrentRow.Cells["fenlei"].Value.ToString();
				inputName.Text = book.dataBook.CurrentRow.Cells["shuming"].Value.ToString();
				inputAuthor.Text = book.dataBook.CurrentRow.Cells["zuozhe"].Value.ToString();
				inputPublisher.Text = book.dataBook.CurrentRow.Cells["chubanhse"].Value.ToString();
				datePublish.Text = book.dataBook.CurrentRow.Cells["chubanriqi"].Value.ToString();
				inputPrice.Text = book.dataBook.CurrentRow.Cells["dingjia"].Value.ToString();
				dateEnter.Text = book.dataBook.CurrentRow.Cells["rkrq"].Value.ToString();
				inputStatus.Text = book.dataBook.CurrentRow.Cells["zt"].Value.ToString();
				comboPosition.Text = book.dataBook.CurrentRow.Cells["sfwz"].Value.ToString();
				inputComment.Text = book.dataBook.CurrentRow.Cells["beizhu"].Value.ToString();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnNext_Click(object sender, EventArgs e) {
			Entities db = new Entities();
			if (editMode) {
				var book = (from o in db.book
							where o.tsbh == inputId.Text
							select o).FirstOrDefault();
				if (book == null) {
					MessageBox.Show("修改失败！");
				} else {
					book.fenlei = inputCategory.Text;
					book.shuming = inputName.Text;
					book.zuozhe = inputAuthor.Text;
					book.chubanhse = inputPublisher.Text;
					book.chubanriqi = datePublish.Value.Date;
					book.dingjia = double.Parse(inputPrice.Text);
					book.zt = inputStatus.Text;
					book.sfwz = comboPosition.Text;
					book.beizhu = inputComment.Text;
				}
				db.SaveChanges();
				MessageBox.Show("修改成功！");
			} else {
				var book = new book {
					tsbh = inputId.Text,
					fenlei = inputCategory.Text,
					shuming = inputName.Text,
					zuozhe = inputAuthor.Text,
					chubanhse = inputPublisher.Text,
					chubanriqi = datePublish.Value.Date,
					dingjia = double.Parse(inputPrice.Text),
					zt = inputStatus.Text,
					sfwz = comboPosition.Text,
					beizhu = inputComment.Text
				};
				db.book.Add(book);
				try {
					db.SaveChanges();
					MessageBox.Show("添加成功！");
				} catch {
					MessageBox.Show("添加失败！");
				}
			}
			Close();
		}
	}
}
