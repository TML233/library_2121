
namespace library_2121
{
	partial class PasswordChange {
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
			this.label2 = new System.Windows.Forms.Label();
			this.inputUser = new System.Windows.Forms.TextBox();
			this.inputPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.inputPassword2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.inputOld = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("宋体", 18F);
			this.lblTitle.Location = new System.Drawing.Point(204, 29);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(186, 42);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "修改密码";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(80, 116);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "用户名";
			// 
			// inputUser
			// 
			this.inputUser.Location = new System.Drawing.Point(210, 109);
			this.inputUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.inputUser.Name = "inputUser";
			this.inputUser.Size = new System.Drawing.Size(256, 31);
			this.inputUser.TabIndex = 4;
			// 
			// inputPassword
			// 
			this.inputPassword.Location = new System.Drawing.Point(210, 258);
			this.inputPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.inputPassword.Name = "inputPassword";
			this.inputPassword.PasswordChar = '*';
			this.inputPassword.Size = new System.Drawing.Size(256, 31);
			this.inputPassword.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(80, 265);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 28);
			this.label3.TabIndex = 5;
			this.label3.Text = "新密码";
			// 
			// inputPassword2
			// 
			this.inputPassword2.Location = new System.Drawing.Point(210, 301);
			this.inputPassword2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.inputPassword2.Name = "inputPassword2";
			this.inputPassword2.PasswordChar = '*';
			this.inputPassword2.Size = new System.Drawing.Size(256, 31);
			this.inputPassword2.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(80, 308);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 28);
			this.label4.TabIndex = 7;
			this.label4.Text = "确认密码";
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnCancel.Location = new System.Drawing.Point(285, 375);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(122, 62);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnNext.Location = new System.Drawing.Point(155, 375);
			this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(122, 62);
			this.btnNext.TabIndex = 21;
			this.btnNext.Text = "确定";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// inputOld
			// 
			this.inputOld.Location = new System.Drawing.Point(210, 184);
			this.inputOld.Margin = new System.Windows.Forms.Padding(4);
			this.inputOld.Name = "inputOld";
			this.inputOld.PasswordChar = '*';
			this.inputOld.Size = new System.Drawing.Size(256, 31);
			this.inputOld.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(80, 191);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 28);
			this.label1.TabIndex = 23;
			this.label1.Text = "旧密码";
			// 
			// PasswordChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 469);
			this.Controls.Add(this.inputOld);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.inputPassword2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.inputPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.inputUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PasswordChange";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.Load += new System.EventHandler(this.Register_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox inputUser;
		private System.Windows.Forms.TextBox inputPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox inputPassword2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TextBox inputOld;
		private System.Windows.Forms.Label label1;
	}
}