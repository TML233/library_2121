
namespace library_2121 {
	partial class BorrowPage {
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
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(286, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "借书管理";
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(7, 70);
			this.data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 72;
			this.data.RowTemplate.Height = 33;
			this.data.Size = new System.Drawing.Size(643, 265);
			this.data.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(7, 43);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "借书证号";
			// 
			// inputCard
			// 
			this.inputCard.Location = new System.Drawing.Point(73, 42);
			this.inputCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inputCard.Name = "inputCard";
			this.inputCard.Size = new System.Drawing.Size(118, 21);
			this.inputCard.TabIndex = 3;
			this.inputCard.TextChanged += new System.EventHandler(this.inputCard_TextChanged);
			// 
			// inputBook
			// 
			this.inputBook.Location = new System.Drawing.Point(261, 42);
			this.inputBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inputBook.Name = "inputBook";
			this.inputBook.Size = new System.Drawing.Size(133, 21);
			this.inputBook.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(195, 43);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "图书编号";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(417, 39);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(64, 24);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "提交";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(485, 39);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 24);
			this.button1.TabIndex = 7;
			this.button1.Text = "退出";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BorrowPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 342);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.inputBook);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.inputCard);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.data);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "BorrowPage";
			this.Text = "BorrowPage";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
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
	}
}