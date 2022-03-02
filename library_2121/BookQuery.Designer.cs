
namespace library_2121 {
	partial class BookQuery {
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
			this.inputCategory = new System.Windows.Forms.TextBox();
			this.btnQuery = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.dataBook = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.inputAuthor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.inputName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.inputPublisher = new System.Windows.Forms.TextBox();
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
			this.lblTitle.Size = new System.Drawing.Size(270, 42);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "书籍组合查询";
			// 
			// inputCategory
			// 
			this.inputCategory.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inputCategory.Location = new System.Drawing.Point(91, 88);
			this.inputCategory.Margin = new System.Windows.Forms.Padding(4);
			this.inputCategory.Name = "inputCategory";
			this.inputCategory.Size = new System.Drawing.Size(136, 36);
			this.inputCategory.TabIndex = 3;
			// 
			// btnQuery
			// 
			this.btnQuery.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQuery.Location = new System.Drawing.Point(25, 132);
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
			this.btnQuit.Location = new System.Drawing.Point(144, 132);
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
			this.dataBook.Location = new System.Drawing.Point(25, 179);
			this.dataBook.Margin = new System.Windows.Forms.Padding(4);
			this.dataBook.Name = "dataBook";
			this.dataBook.RowHeadersWidth = 51;
			this.dataBook.RowTemplate.Height = 27;
			this.dataBook.Size = new System.Drawing.Size(1404, 784);
			this.dataBook.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 10.8F);
			this.label1.Location = new System.Drawing.Point(20, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "分类";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 10.8F);
			this.label2.Location = new System.Drawing.Point(234, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 26);
			this.label2.TabIndex = 12;
			this.label2.Text = "作者";
			// 
			// inputAuthor
			// 
			this.inputAuthor.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inputAuthor.Location = new System.Drawing.Point(305, 88);
			this.inputAuthor.Margin = new System.Windows.Forms.Padding(4);
			this.inputAuthor.Name = "inputAuthor";
			this.inputAuthor.Size = new System.Drawing.Size(136, 36);
			this.inputAuthor.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 10.8F);
			this.label3.Location = new System.Drawing.Point(448, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 26);
			this.label3.TabIndex = 14;
			this.label3.Text = "书名";
			// 
			// inputName
			// 
			this.inputName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inputName.Location = new System.Drawing.Point(519, 88);
			this.inputName.Margin = new System.Windows.Forms.Padding(4);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(251, 36);
			this.inputName.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 10.8F);
			this.label4.Location = new System.Drawing.Point(777, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 26);
			this.label4.TabIndex = 16;
			this.label4.Text = "出版社";
			// 
			// inputPublisher
			// 
			this.inputPublisher.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inputPublisher.Location = new System.Drawing.Point(874, 88);
			this.inputPublisher.Margin = new System.Windows.Forms.Padding(4);
			this.inputPublisher.Name = "inputPublisher";
			this.inputPublisher.Size = new System.Drawing.Size(221, 36);
			this.inputPublisher.TabIndex = 15;
			// 
			// BookQuery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1445, 987);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.inputPublisher);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.inputName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inputAuthor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataBook);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnQuery);
			this.Controls.Add(this.inputCategory);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BookQuery";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book";
			this.Load += new System.EventHandler(this.BookQuery_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox inputCategory;
		private System.Windows.Forms.Button btnQuery;
		private System.Windows.Forms.Button btnQuit;
		public System.Windows.Forms.DataGridView dataBook;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox inputAuthor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox inputPublisher;
	}
}