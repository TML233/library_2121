
namespace library_2121 {
	partial class TodayStats {
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
			this.data = new System.Windows.Forms.DataGridView();
			this.lblTitle = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// data
			// 
			this.data.AllowUserToAddRows = false;
			this.data.AllowUserToDeleteRows = false;
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(12, 119);
			this.data.Name = "data";
			this.data.ReadOnly = true;
			this.data.RowHeadersWidth = 72;
			this.data.RowTemplate.Height = 33;
			this.data.Size = new System.Drawing.Size(1162, 485);
			this.data.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblTitle.Location = new System.Drawing.Point(485, 14);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(186, 42);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "今日牛逼";
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Location = new System.Drawing.Point(26, 81);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(52, 21);
			this.labelTotal.TabIndex = 2;
			this.labelTotal.Text = "今日";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(688, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 55);
			this.button1.TabIndex = 3;
			this.button1.Text = "退出";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TodayStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1186, 616);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.data);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TodayStats";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TodayStats";
			this.Load += new System.EventHandler(this.TodayStats_Load);
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Button button1;
	}
}