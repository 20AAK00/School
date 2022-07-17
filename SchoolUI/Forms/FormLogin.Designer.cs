using SchoolUI.UserControls.Reusables;

namespace SchoolUI.Forms
{
	partial class FormLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.pboxBackground = new System.Windows.Forms.PictureBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.pboxKey = new System.Windows.Forms.PictureBox();
			this.ucTitleBar = new SchoolUI.UserControls.Reusables.UCTitleBar();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.btnLogin = new MyCustomButton.MyCustomButton();
			((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxKey)).BeginInit();
			this.SuspendLayout();
			// 
			// pboxBackground
			// 
			this.pboxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground.Image")));
			this.pboxBackground.InitialImage = null;
			this.pboxBackground.Location = new System.Drawing.Point(0, 48);
			this.pboxBackground.Name = "pboxBackground";
			this.pboxBackground.Size = new System.Drawing.Size(1200, 720);
			this.pboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxBackground.TabIndex = 0;
			this.pboxBackground.TabStop = false;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.lblUsername.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblUsername.Location = new System.Drawing.Point(856, 370);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(75, 29);
			this.lblUsername.TabIndex = 1;
			this.lblUsername.Text = "نام کاربری";
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.Color.White;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtUsername.Location = new System.Drawing.Point(575, 402);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(355, 34);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.White;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPassword.Location = new System.Drawing.Point(575, 488);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(355, 34);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.lblPassword.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPassword.Location = new System.Drawing.Point(859, 456);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(72, 29);
			this.lblPassword.TabIndex = 4;
			this.lblPassword.Text = "کلمه عبور";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.lblLogin.Font = new System.Drawing.Font("P - IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.lblLogin.Location = new System.Drawing.Point(675, 331);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(155, 44);
			this.lblLogin.TabIndex = 1;
			this.lblLogin.Text = "ورود به سیستم";
			// 
			// pboxKey
			// 
			this.pboxKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.pboxKey.Image = ((System.Drawing.Image)(resources.GetObject("pboxKey.Image")));
			this.pboxKey.Location = new System.Drawing.Point(719, 266);
			this.pboxKey.Name = "pboxKey";
			this.pboxKey.Size = new System.Drawing.Size(67, 62);
			this.pboxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxKey.TabIndex = 6;
			this.pboxKey.TabStop = false;
			// 
			// ucTitleBar
			// 
			this.ucTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.ucTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.ucTitleBar.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ucTitleBar.Location = new System.Drawing.Point(0, 0);
			this.ucTitleBar.Name = "ucTitleBar";
			this.ucTitleBar.Size = new System.Drawing.Size(1200, 40);
			this.ucTitleBar.TabIndex = 4;
			// 
			// lblCopyright
			// 
			this.lblCopyright.BackColor = System.Drawing.Color.White;
			this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblCopyright.Font = new System.Drawing.Font("P - IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCopyright.Location = new System.Drawing.Point(0, 741);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCopyright.Size = new System.Drawing.Size(1200, 27);
			this.lblCopyright.TabIndex = 8;
			this.lblCopyright.Text = "متن کپی‌رایت";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLogin
			// 
			this.btnLogin.AutoSize = true;
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnLogin.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
			this.btnLogin.IconColor = System.Drawing.Color.White;
			this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnLogin.IconSize = 30;
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogin.Location = new System.Drawing.Point(683, 555);
			this.btnLogin.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnLogin.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnLogin.Size = new System.Drawing.Size(138, 43);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "ورود";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.LoginButtom_Click);
			// 
			// FormLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1200, 768);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lblCopyright);
			this.Controls.Add(this.ucTitleBar);
			this.Controls.Add(this.pboxKey);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.pboxBackground);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxKey)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pboxBackground;
		private Label lblUsername;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Label lblPassword;
		private Label lblLogin;
		private PictureBox pboxKey;
		private UCTitleBar ucTitleBar;
		private Label lblCopyright;
		private MyCustomButton.MyCustomButton btnLogin;
	}
}