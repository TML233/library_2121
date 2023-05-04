
namespace library_2121 {
	partial class AppointmentPage {
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
			this.label1 = new System.Windows.Forms.Label();
			this.data = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.inputCard = new System.Windows.Forms.TextBox();
			this.inputBook = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioBook = new System.Windows.Forms.RadioButton();
			this.radioReader = new System.Windows.Forms.RadioButton();
			this.inputQuery = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(524, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "预约管理";
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(11, 191);
			this.data.Margin = new System.Windows.Forms.Padding(4);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 72;
			this.data.RowTemplate.Height = 33;
			this.data.Size = new System.Drawing.Size(1179, 464);
			this.data.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(13, 75);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "借书证号";
			// 
			// inputCard
			// 
			this.inputCard.Location = new System.Drawing.Point(134, 74);
			this.inputCard.Margin = new System.Windows.Forms.Padding(4);
			this.inputCard.Name = "inputCard";
			this.inputCard.Size = new System.Drawing.Size(213, 31);
			this.inputCard.TabIndex = 3;
			// 
			// inputBook
			// 
			this.inputBook.Location = new System.Drawing.Point(478, 74);
			this.inputBook.Margin = new System.Windows.Forms.Padding(4);
			this.inputBook.Name = "inputBook";
			this.inputBook.Size = new System.Drawing.Size(240, 31);
			this.inputBook.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(358, 75);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "图书编号";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(764, 68);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(117, 42);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "预约";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(889, 68);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 42);
			this.button1.TabIndex = 7;
			this.button1.Text = "退出";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioReader);
			this.groupBox1.Controls.Add(this.radioBook);
			this.groupBox1.Location = new System.Drawing.Point(18, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 72);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "查询类别";
			// 
			// radioBook
			// 
			this.radioBook.AutoSize = true;
			this.radioBook.Location = new System.Drawing.Point(26, 31);
			this.radioBook.Name = "radioBook";
			this.radioBook.Size = new System.Drawing.Size(119, 25);
			this.radioBook.TabIndex = 0;
			this.radioBook.TabStop = true;
			this.radioBook.Text = "图书编号";
			this.radioBook.UseVisualStyleBackColor = true;
			// 
			// radioReader
			// 
			this.radioReader.AutoSize = true;
			this.radioReader.Location = new System.Drawing.Point(228, 31);
			this.radioReader.Name = "radioReader";
			this.radioReader.Size = new System.Drawing.Size(119, 25);
			this.radioReader.TabIndex = 1;
			this.radioReader.TabStop = true;
			this.radioReader.Text = "借书证号";
			this.radioReader.UseVisualStyleBackColor = true;
			// 
			// inputQuery
			// 
			this.inputQuery.Location = new System.Drawing.Point(409, 137);
			this.inputQuery.Margin = new System.Windows.Forms.Padding(4);
			this.inputQuery.Name = "inputQuery";
			this.inputQuery.Size = new System.Drawing.Size(240, 31);
			this.inputQuery.TabIndex = 9;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(657, 134);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(117, 42);
			this.button2.TabIndex = 10;
			this.button2.Text = "查询";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// AppointmentPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1203, 665);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.inputQuery);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.inputBook);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.inputCard);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.data);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AppointmentPage";
			this.Text = "BorrowPage";
			this.Load += new System.EventHandler(this.BorrowPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox inputCard;
		private System.Windows.Forms.TextBox inputBook;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioReader;
		private System.Windows.Forms.RadioButton radioBook;
		private System.Windows.Forms.TextBox inputQuery;
		private System.Windows.Forms.Button button2;
	}
}