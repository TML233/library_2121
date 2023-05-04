
namespace library_2121
{
	partial class UserMenu
	{
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.预约ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.今日进书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.今日过期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.借书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.还书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.书籍组合查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1100, 37);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 管理ToolStripMenuItem
			// 
			this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预约ToolStripMenuItem,
            this.今日进书ToolStripMenuItem,
            this.今日过期ToolStripMenuItem,
            this.借书查询ToolStripMenuItem,
            this.还书查询ToolStripMenuItem,
            this.书籍组合查询ToolStripMenuItem,
            this.退出ToolStripMenuItem});
			this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
			this.管理ToolStripMenuItem.Size = new System.Drawing.Size(72, 33);
			this.管理ToolStripMenuItem.Text = "管理";
			// 
			// 预约ToolStripMenuItem
			// 
			this.预约ToolStripMenuItem.Name = "预约ToolStripMenuItem";
			this.预约ToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
			this.预约ToolStripMenuItem.Text = "预约";
			// 
			// 今日进书ToolStripMenuItem
			// 
			this.今日进书ToolStripMenuItem.Name = "今日进书ToolStripMenuItem";
			this.今日进书ToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
			this.今日进书ToolStripMenuItem.Text = "今日进书";
			// 
			// 今日过期ToolStripMenuItem
			// 
			this.今日过期ToolStripMenuItem.Name = "今日过期ToolStripMenuItem";
			this.今日过期ToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
			this.今日过期ToolStripMenuItem.Text = "今日过期";
			// 
			// 借书查询ToolStripMenuItem
			// 
			this.借书查询ToolStripMenuItem.Name = "借书查询ToolStripMenuItem";
			this.借书查询ToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
			this.借书查询ToolStripMenuItem.Text = "借书查询";
			// 
			// 还书查询ToolStripMenuItem
			// 
			this.还书查询ToolStripMenuItem.Name = "还书查询ToolStripMenuItem";
			this.还书查询ToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
			this.还书查询ToolStripMenuItem.Text = "还书查询";
			// 
			// 书籍组合查询ToolStripMenuItem
			// 
			this.书籍组合查询ToolStripMenuItem.Name = "书籍组合查询ToolStripMenuItem";
			this.书籍组合查询ToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
			this.书籍组合查询ToolStripMenuItem.Text = "书籍组合查询";
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
			this.退出ToolStripMenuItem.Text = "退出";
			// 
			// UserMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 630);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UserMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User";
			this.Load += new System.EventHandler(this.User_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 预约ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 今日进书ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 今日过期ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 借书查询ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 还书查询ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 书籍组合查询ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
	}
}