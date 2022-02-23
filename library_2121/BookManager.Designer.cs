
namespace library_2121 {
	partial class BookManager {
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
			this.radioPublisher = new System.Windows.Forms.RadioButton();
			this.radioAuthor = new System.Windows.Forms.RadioButton();
			this.radioName = new System.Windows.Forms.RadioButton();
			this.radioType = new System.Windows.Forms.RadioButton();
			this.radioId = new System.Windows.Forms.RadioButton();
			this.textBox = new System.Windows.Forms.TextBox();
			this.btnQuery = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.dataBook = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("宋体", 18F);
			this.lblTitle.Location = new System.Drawing.Point(263, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(253, 30);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "书籍基本信息管理";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioPublisher);
			this.groupBox1.Controls.Add(this.radioAuthor);
			this.groupBox1.Controls.Add(this.radioName);
			this.groupBox1.Controls.Add(this.radioType);
			this.groupBox1.Controls.Add(this.radioId);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(12, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(443, 61);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "查询类别";
			// 
			// radioPublisher
			// 
			this.radioPublisher.AutoSize = true;
			this.radioPublisher.Location = new System.Drawing.Point(340, 27);
			this.radioPublisher.Name = "radioPublisher";
			this.radioPublisher.Size = new System.Drawing.Size(87, 23);
			this.radioPublisher.TabIndex = 4;
			this.radioPublisher.TabStop = true;
			this.radioPublisher.Text = "出版社";
			this.radioPublisher.UseVisualStyleBackColor = true;
			// 
			// radioAuthor
			// 
			this.radioAuthor.AutoSize = true;
			this.radioAuthor.Location = new System.Drawing.Point(266, 27);
			this.radioAuthor.Name = "radioAuthor";
			this.radioAuthor.Size = new System.Drawing.Size(68, 23);
			this.radioAuthor.TabIndex = 3;
			this.radioAuthor.TabStop = true;
			this.radioAuthor.Text = "作者";
			this.radioAuthor.UseVisualStyleBackColor = true;
			// 
			// radioName
			// 
			this.radioName.AutoSize = true;
			this.radioName.Location = new System.Drawing.Point(192, 27);
			this.radioName.Name = "radioName";
			this.radioName.Size = new System.Drawing.Size(68, 23);
			this.radioName.TabIndex = 2;
			this.radioName.TabStop = true;
			this.radioName.Text = "书名";
			this.radioName.UseVisualStyleBackColor = true;
			// 
			// radioType
			// 
			this.radioType.AutoSize = true;
			this.radioType.Location = new System.Drawing.Point(118, 27);
			this.radioType.Name = "radioType";
			this.radioType.Size = new System.Drawing.Size(68, 23);
			this.radioType.TabIndex = 1;
			this.radioType.TabStop = true;
			this.radioType.Text = "分类";
			this.radioType.UseVisualStyleBackColor = true;
			// 
			// radioId
			// 
			this.radioId.AutoSize = true;
			this.radioId.Location = new System.Drawing.Point(6, 27);
			this.radioId.Name = "radioId";
			this.radioId.Size = new System.Drawing.Size(106, 23);
			this.radioId.TabIndex = 0;
			this.radioId.TabStop = true;
			this.radioId.Text = "图书编号";
			this.radioId.UseVisualStyleBackColor = true;
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox.Location = new System.Drawing.Point(461, 63);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(100, 28);
			this.textBox.TabIndex = 3;
			this.textBox.Text = "全部";
			// 
			// btnQuery
			// 
			this.btnQuery.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQuery.Location = new System.Drawing.Point(568, 63);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new System.Drawing.Size(81, 28);
			this.btnQuery.TabIndex = 4;
			this.btnQuery.Text = "查询";
			this.btnQuery.UseVisualStyleBackColor = true;
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnRemove.Location = new System.Drawing.Point(12, 108);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(81, 28);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "删除";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnAdd.Location = new System.Drawing.Point(99, 108);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(81, 28);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "增加";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnEdit.Location = new System.Drawing.Point(186, 108);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(81, 28);
			this.btnEdit.TabIndex = 7;
			this.btnEdit.Text = "修改";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQuit.Location = new System.Drawing.Point(273, 108);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(81, 28);
			this.btnQuit.TabIndex = 8;
			this.btnQuit.Text = "退出";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// dataBook
			// 
			this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataBook.Location = new System.Drawing.Point(18, 143);
			this.dataBook.Name = "dataBook";
			this.dataBook.RowHeadersWidth = 51;
			this.dataBook.RowTemplate.Height = 27;
			this.dataBook.Size = new System.Drawing.Size(1021, 560);
			this.dataBook.TabIndex = 9;
			// 
			// Book
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1051, 715);
			this.Controls.Add(this.dataBook);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnQuery);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Book";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book";
			this.Load += new System.EventHandler(this.Book_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioPublisher;
		private System.Windows.Forms.RadioButton radioAuthor;
		private System.Windows.Forms.RadioButton radioName;
		private System.Windows.Forms.RadioButton radioType;
		private System.Windows.Forms.RadioButton radioId;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button btnQuery;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnQuit;
		public System.Windows.Forms.DataGridView dataBook;
	}
}