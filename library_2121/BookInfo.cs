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
				inputId.Text = book.dataBook.CurrentRow.Cells["图书编号"].Value.ToString();
				inputCategory.Text = book.dataBook.CurrentRow.Cells["分类"].Value.ToString();
				inputName.Text = book.dataBook.CurrentRow.Cells["书名"].Value.ToString();
				inputAuthor.Text = book.dataBook.CurrentRow.Cells["作者"].Value.ToString();
				inputPublisher.Text = book.dataBook.CurrentRow.Cells["出版社"].Value.ToString();
				datePublish.Text = book.dataBook.CurrentRow.Cells["出版日期"].Value.ToString();
				inputPrice.Text = book.dataBook.CurrentRow.Cells["定价"].Value.ToString();
				dateEnter.Text = book.dataBook.CurrentRow.Cells["入库日期"].Value.ToString();
				inputStatus.Text = book.dataBook.CurrentRow.Cells["状态"].Value.ToString();
				comboPosition.Text = book.dataBook.CurrentRow.Cells["所放位置"].Value.ToString();
				inputComment.Text = book.dataBook.CurrentRow.Cells["备注"].Value.ToString();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnNext_Click(object sender, EventArgs e) {
			if (editMode) {
				int edited = Utils.ExecuteUpdate("update book set 分类='" + inputCategory.Text + "',书名='" + inputName.Text + "',作者='" + inputAuthor.Text + "',出版社='" + inputPublisher.Text + "',出版日期='" + datePublish.Value.Date + "',定价=" + inputPrice.Text + ",入库日期='" + dateEnter.Text + "',状态='" + inputStatus.Text + "',所放位置='" + comboPosition.Text + "',备注='" + inputComment.Text + "'  where 图书编号='" + inputId.Text + "'");
				if (edited > 0) {
					MessageBox.Show("修改成功！");
				} else {
					MessageBox.Show("修改失败！");
				}
			} else {
				int edited=Utils.ExecuteUpdate("insert into book(图书编号,分类,书名,作者,出版社,出版日期,定价,入库日期,状态,所放位置,备注)  Values('" + inputId.Text + "','" + inputCategory.Text + "','" + inputName.Text + "','" + inputAuthor.Text + "','" + inputPublisher.Text + "','" + datePublish.Value.Date + "'," + inputPrice.Text + ",'" + dateEnter.Text + "','" + inputStatus.Text + "','" + comboPosition.Text + "','" + inputComment.Text + "')");
				if (edited > 0) {
					MessageBox.Show("添加成功！");
				} else {
					MessageBox.Show("添加失败！");
				}
			}
			Close();
		}
	}
}
