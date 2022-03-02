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
	public partial class ReaderInfo : Form {
		bool editMode;
		ReaderManager reader = null;
		public ReaderInfo(bool edit) {
			InitializeComponent();
			editMode = edit;
		}

		private void BookInfo_Load(object sender, EventArgs e) {
			lblTitle.Text = editMode ? "读者修改" : "读者添加";
			reader = (ReaderManager)Owner;
			if (editMode) {
				inputId.ReadOnly = true;
				inputId.Text = reader.dataReader.CurrentRow.Cells["借书证号"].Value.ToString();
				inputName.Text = reader.dataReader.CurrentRow.Cells["姓名"].Value.ToString();
				cbGender.Text = reader.dataReader.CurrentRow.Cells["性别"].Value.ToString();
				inputDepartment.Text = reader.dataReader.CurrentRow.Cells["单位"].Value.ToString();
				cbLevel.Text = reader.dataReader.CurrentRow.Cells["级别"].Value.ToString();
				inputBorrowed.Text = reader.dataReader.CurrentRow.Cells["已借书数"].Value.ToString();
				dateRegister.Text = reader.dataReader.CurrentRow.Cells["登记日期"].Value.ToString();
				inputPhone.Text = reader.dataReader.CurrentRow.Cells["电话号码"].Value.ToString();
				inputEmail.Text = reader.dataReader.CurrentRow.Cells["电子邮件地址"].Value.ToString();
				cbLost.Text = reader.dataReader.CurrentRow.Cells["挂失"].Value.ToString();
				cbFine.Text = reader.dataReader.CurrentRow.Cells["过期罚款"].Value.ToString();
				cbBookNum.Text = reader.dataReader.CurrentRow.Cells["借书总数"].Value.ToString();
				cbDays.Text = reader.dataReader.CurrentRow.Cells["借书天数"].Value.ToString();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnNext_Click(object sender, EventArgs e) {
			if (editMode) {
				int edited = Utils.ExecuteUpdate(
					"update reader set [姓名]=@0,[性别]=@1,[单位]=@2,[级别]=@3,[已借书数]=@4,[登记日期]=@5,[电话号码]=@6,[电子邮件地址]=@7,[挂失]=@8,[过期罚款]=@9,[借书总数]=@10,[借书天数]=@11 where [借书证号]=@12",
					inputName.Text, cbGender.Text, inputDepartment.Text, cbLevel.Text, inputBorrowed.Text, dateRegister.Value.ToString("yyyy-MM-dd"), inputPhone.Text, inputEmail.Text, cbLost.Text, cbFine.Text, cbBookNum.Text, cbDays.Text, inputId.Text
				);
				if (edited > 0) {
					MessageBox.Show("修改成功！");
				} else {
					MessageBox.Show("修改失败！");
				}
			} else {
				int edited = Utils.ExecuteUpdate(
					"insert into reader([借书证号],[姓名],[性别],[单位],[级别],[已借书数],[登记日期],[电话号码],[电子邮件地址],[挂失],[过期罚款],[借书总数],[借书天数]) Values(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)",
					inputId.Text, inputName.Text, cbGender.Text, inputDepartment.Text, cbLevel.Text, inputBorrowed.Text, dateRegister.Value.ToString("yyyy-MM-dd"), inputPhone.Text, inputEmail.Text, cbLost.Text, cbFine.Text, cbBookNum.Text, cbDays.Text
				);
				if (edited > 0) {
					MessageBox.Show("添加成功！");
				} else {
					MessageBox.Show("添加失败！");
				}
			}
			string sql = "SELECT * FROM reader ORDER BY 登记日期 DESC";
			var set = Utils.ExecuteQuery(sql, "reader");
			reader.dataReader.DataSource = set.Tables["reader"].DefaultView;
			Close();
		}
	}
}
