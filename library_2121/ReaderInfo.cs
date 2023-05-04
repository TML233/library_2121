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
				inputId.Text = reader.dataReader.CurrentRow.Cells["jszh"].Value.ToString();
				inputName.Text = reader.dataReader.CurrentRow.Cells["name"].Value.ToString();
				cbGender.Text = reader.dataReader.CurrentRow.Cells["sex"].Value.ToString();
				inputDepartment.Text = reader.dataReader.CurrentRow.Cells["danwei"].Value.ToString();
				cbLevel.Text = reader.dataReader.CurrentRow.Cells["jibie"].Value.ToString();
				inputBorrowed.Text = reader.dataReader.CurrentRow.Cells["yjss"].Value.ToString();
				dateRegister.Text = reader.dataReader.CurrentRow.Cells["djrq"].Value.ToString();
				inputPhone.Text = reader.dataReader.CurrentRow.Cells["phone"].Value.ToString();
				inputEmail.Text = reader.dataReader.CurrentRow.Cells["email"].Value.ToString();
				cbLost.Text = reader.dataReader.CurrentRow.Cells["guashi"].Value.ToString();
				cbFine.Text = reader.dataReader.CurrentRow.Cells["gqfk"].Value.ToString();
				cbBookNum.Text = reader.dataReader.CurrentRow.Cells["jieshuzongshu"].Value.ToString();
				cbDays.Text = reader.dataReader.CurrentRow.Cells["jsts"].Value.ToString();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnNext_Click(object sender, EventArgs e) {
			Entities db = new Entities();
			if (editMode) {
				var reader = (from o in db.reader
							  where o.jszh == inputId.Text
							  select o).FirstOrDefault();
				reader.name = inputName.Text;
				reader.sex = cbGender.Text;
				reader.danwei = inputDepartment.Text;
				reader.jibie = cbLevel.Text;
				reader.yjss = int.Parse(inputBorrowed.Text);
				reader.djrq = dateRegister.Value.Date;
				reader.phone = inputPhone.Text;
				reader.email= inputEmail.Text;
				reader.guashi = cbLost.Text;
				reader.gqfk = int.Parse(cbFine.Text);
				reader.jieshuzongshu = int.Parse(cbBookNum.Text);
				reader.jsts=int.Parse(cbDays.Text);
				try {
					db.SaveChanges();
					MessageBox.Show("修改成功！");
				} catch {
					MessageBox.Show("修改失败！");
				}
			} else {
				var reader = new reader {
					jszh = inputId.Text,
					name = inputName.Text,
					sex = cbGender.Text,
					danwei = inputDepartment.Text,
					jibie = cbLevel.Text,
					yjss = int.Parse(inputBorrowed.Text),
					djrq = dateRegister.Value.Date,
					phone = inputPhone.Text,
					email = inputEmail.Text,
					guashi = cbLost.Text,
					gqfk = int.Parse(cbFine.Text),
					jieshuzongshu = int.Parse(cbBookNum.Text),
					jsts = int.Parse(cbDays.Text)
				};
				db.reader.Add(reader);
				try {
					db.SaveChanges();
					MessageBox.Show("添加成功！");
				} catch {
					MessageBox.Show("添加失败！");
				}
			}
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
