
namespace library_2121
{
	partial class Login
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.inputUser = new System.Windows.Forms.TextBox();
			this.inputPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.radioUser = new System.Windows.Forms.RadioButton();
			this.radioAdmin = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.inputCode = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblCode = new System.Windows.Forms.Label();
			this.linkGenerateCode = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(73, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "图书馆管理信息系统\r\n登录";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(59, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "用户名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(59, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "密码";
			// 
			// inputUser
			// 
			this.inputUser.Location = new System.Drawing.Point(173, 137);
			this.inputUser.Name = "inputUser";
			this.inputUser.Size = new System.Drawing.Size(187, 25);
			this.inputUser.TabIndex = 3;
			// 
			// inputPassword
			// 
			this.inputPassword.Location = new System.Drawing.Point(173, 177);
			this.inputPassword.Name = "inputPassword";
			this.inputPassword.PasswordChar = '*';
			this.inputPassword.Size = new System.Drawing.Size(187, 25);
			this.inputPassword.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(59, 222);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "账户类型";
			// 
			// radioUser
			// 
			this.radioUser.AutoSize = true;
			this.radioUser.Checked = true;
			this.radioUser.Location = new System.Drawing.Point(173, 222);
			this.radioUser.Name = "radioUser";
			this.radioUser.Size = new System.Drawing.Size(88, 19);
			this.radioUser.TabIndex = 6;
			this.radioUser.TabStop = true;
			this.radioUser.Text = "普通用户";
			this.radioUser.UseVisualStyleBackColor = true;
			// 
			// radioAdmin
			// 
			this.radioAdmin.AutoSize = true;
			this.radioAdmin.Location = new System.Drawing.Point(267, 222);
			this.radioAdmin.Name = "radioAdmin";
			this.radioAdmin.Size = new System.Drawing.Size(73, 19);
			this.radioAdmin.TabIndex = 7;
			this.radioAdmin.Text = "管理员";
			this.radioAdmin.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(59, 261);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "验证码";
			// 
			// inputCode
			// 
			this.inputCode.Location = new System.Drawing.Point(173, 262);
			this.inputCode.MaxLength = 4;
			this.inputCode.Name = "inputCode";
			this.inputCode.Size = new System.Drawing.Size(88, 25);
			this.inputCode.TabIndex = 9;
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnNext.Location = new System.Drawing.Point(35, 344);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(89, 44);
			this.btnNext.TabIndex = 10;
			this.btnNext.Text = "确定";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnCancel.Location = new System.Drawing.Point(130, 344);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 44);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnRegister.Location = new System.Drawing.Point(225, 344);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(89, 44);
			this.btnRegister.TabIndex = 12;
			this.btnRegister.Text = "注册";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnClose.Location = new System.Drawing.Point(320, 344);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(89, 44);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblCode
			// 
			this.lblCode.BackColor = System.Drawing.Color.Black;
			this.lblCode.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblCode.ForeColor = System.Drawing.Color.White;
			this.lblCode.Location = new System.Drawing.Point(267, 253);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(102, 39);
			this.lblCode.TabIndex = 14;
			this.lblCode.Text = "1234";
			this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkGenerateCode
			// 
			this.linkGenerateCode.AutoSize = true;
			this.linkGenerateCode.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.linkGenerateCode.Location = new System.Drawing.Point(267, 292);
			this.linkGenerateCode.Name = "linkGenerateCode";
			this.linkGenerateCode.Size = new System.Drawing.Size(104, 19);
			this.linkGenerateCode.TabIndex = 15;
			this.linkGenerateCode.TabStop = true;
			this.linkGenerateCode.Text = "刷新验证码";
			this.linkGenerateCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGenerateCode_LinkClicked);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 416);
			this.Controls.Add(this.linkGenerateCode);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.inputCode);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.radioAdmin);
			this.Controls.Add(this.radioUser);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.inputPassword);
			this.Controls.Add(this.inputUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox inputUser;
		private System.Windows.Forms.TextBox inputPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioUser;
		private System.Windows.Forms.RadioButton radioAdmin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox inputCode;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.LinkLabel linkGenerateCode;
	}
}