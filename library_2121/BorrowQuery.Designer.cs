
namespace library_2121 {
	partial class BorrowQuery {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblTitle = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioDate = new System.Windows.Forms.RadioButton();
			this.radioCardName = new System.Windows.Forms.RadioButton();
			this.radioBookName = new System.Windows.Forms.RadioButton();
			this.radioCard = new System.Windows.Forms.RadioButton();
			this.radioId = new System.Windows.Forms.RadioButton();
			this.textBox = new System.Windows.Forms.TextBox();
			this.btnQuery = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.dataBook = new System.Windows.Forms.DataGridView();
			this.inputDate = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("宋体", 18F);
			this.lblTitle.Location = new System.Drawing.Point(362, 13);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(186, 42);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "借还查询";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioDate);
			this.groupBox1.Controls.Add(this.radioCardName);
			this.groupBox1.Controls.Add(this.radioBookName);
			this.groupBox1.Controls.Add(this.radioCard);
			this.groupBox1.Controls.Add(this.radioId);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(16, 57);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(631, 85);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "查询类别";
			// 
			// radioDate
			// 
			this.radioDate.AutoSize = true;
			this.radioDate.Location = new System.Drawing.Point(515, 38);
			this.radioDate.Margin = new System.Windows.Forms.Padding(4);
			this.radioDate.Name = "radioDate";
			this.radioDate.Size = new System.Drawing.Size(89, 30);
			this.radioDate.TabIndex = 4;
			this.radioDate.TabStop = true;
			this.radioDate.Text = "日期";
			this.radioDate.UseVisualStyleBackColor = true;
			this.radioDate.CheckedChanged += new System.EventHandler(this.radioDate_CheckedChanged);
			// 
			// radioCardName
			// 
			this.radioCardName.AutoSize = true;
			this.radioCardName.Location = new System.Drawing.Point(413, 38);
			this.radioCardName.Margin = new System.Windows.Forms.Padding(4);
			this.radioCardName.Name = "radioCardName";
			this.radioCardName.Size = new System.Drawing.Size(89, 30);
			this.radioCardName.TabIndex = 3;
			this.radioCardName.TabStop = true;
			this.radioCardName.Text = "姓名";
			this.radioCardName.UseVisualStyleBackColor = true;
			this.radioCardName.CheckedChanged += new System.EventHandler(this.radioCardName_CheckedChanged);
			// 
			// radioBookName
			// 
			this.radioBookName.AutoSize = true;
			this.radioBookName.Location = new System.Drawing.Point(311, 38);
			this.radioBookName.Margin = new System.Windows.Forms.Padding(4);
			this.radioBookName.Name = "radioBookName";
			this.radioBookName.Size = new System.Drawing.Size(89, 30);
			this.radioBookName.TabIndex = 2;
			this.radioBookName.TabStop = true;
			this.radioBookName.Text = "书名";
			this.radioBookName.UseVisualStyleBackColor = true;
			this.radioBookName.CheckedChanged += new System.EventHandler(this.radioBookName_CheckedChanged);
			// 
			// radioCard
			// 
			this.radioCard.AutoSize = true;
			this.radioCard.Location = new System.Drawing.Point(162, 38);
			this.radioCard.Margin = new System.Windows.Forms.Padding(4);
			this.radioCard.Name = "radioCard";
			this.radioCard.Size = new System.Drawing.Size(141, 30);
			this.radioCard.TabIndex = 1;
			this.radioCard.TabStop = true;
			this.radioCard.Text = "借书证号";
			this.radioCard.UseVisualStyleBackColor = true;
			this.radioCard.CheckedChanged += new System.EventHandler(this.radioCard_CheckedChanged);
			// 
			// radioId
			// 
			this.radioId.AutoSize = true;
			this.radioId.Location = new System.Drawing.Point(8, 38);
			this.radioId.Margin = new System.Windows.Forms.Padding(4);
			this.radioId.Name = "radioId";
			this.radioId.Size = new System.Drawing.Size(141, 30);
			this.radioId.TabIndex = 0;
			this.radioId.TabStop = true;
			this.radioId.Text = "图书编号";
			this.radioId.UseVisualStyleBackColor = true;
			this.radioId.CheckedChanged += new System.EventHandler(this.radioId_CheckedChanged);
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox.Location = new System.Drawing.Point(655, 90);
			this.textBox.Margin = new System.Windows.Forms.Padding(4);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(255, 36);
			this.textBox.TabIndex = 3;
			// 
			// btnQuery
			// 
			this.btnQuery.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQuery.Location = new System.Drawing.Point(25, 150);
			this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new System.Drawing.Size(111, 39);
			this.btnQuery.TabIndex = 4;
			this.btnQuery.Text = "查询";
			this.btnQuery.UseVisualStyleBackColor = true;
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQuit.Location = new System.Drawing.Point(144, 150);
			this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(111, 39);
			this.btnQuit.TabIndex = 8;
			this.btnQuit.Text = "退出";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// dataBook
			// 
			this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataBook.Location = new System.Drawing.Point(25, 200);
			this.dataBook.Margin = new System.Windows.Forms.Padding(4);
			this.dataBook.Name = "dataBook";
			this.dataBook.RowHeadersWidth = 51;
			this.dataBook.RowTemplate.Height = 27;
			this.dataBook.Size = new System.Drawing.Size(1404, 784);
			this.dataBook.TabIndex = 9;
			// 
			// inputDate
			// 
			this.inputDate.CustomFormat = "yyyy/MM/dd";
			this.inputDate.Font = new System.Drawing.Font("宋体", 10.8F);
			this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.inputDate.Location = new System.Drawing.Point(654, 90);
			this.inputDate.Name = "inputDate";
			this.inputDate.Size = new System.Drawing.Size(256, 36);
			this.inputDate.TabIndex = 10;
			this.inputDate.Value = new System.DateTime(2021, 9, 5, 0, 0, 0, 0);
			// 
			// BorrowQuery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1445, 1001);
			this.Controls.Add(this.inputDate);
			this.Controls.Add(this.dataBook);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnQuery);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BorrowQuery";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book";
			this.Load += new System.EventHandler(this.BorrowQuery_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioDate;
		private System.Windows.Forms.RadioButton radioCardName;
		private System.Windows.Forms.RadioButton radioBookName;
		private System.Windows.Forms.RadioButton radioCard;
		private System.Windows.Forms.RadioButton radioId;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button btnQuery;
		private System.Windows.Forms.Button btnQuit;
		public System.Windows.Forms.DataGridView dataBook;
		private System.Windows.Forms.DateTimePicker inputDate;
	}
}