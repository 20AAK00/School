using SchoolUI.UserControls.Reusables;

namespace SchoolUI.Forms
{
	partial class FormMessage
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
			this.lblMessage = new System.Windows.Forms.Label();
			this.ucTitleBar = new SchoolUI.UserControls.Reusables.UCTitleBar();
			this.btnOK = new MyCustomButton.MyCustomButton();
			this.btnCancel = new MyCustomButton.MyCustomButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMessage.Location = new System.Drawing.Point(12, 57);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMessage.Size = new System.Drawing.Size(479, 95);
			this.lblMessage.TabIndex = 4;
			this.lblMessage.Text = "label1";
			// 
			// ucTitleBar
			// 
			this.ucTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.ucTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.ucTitleBar.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ucTitleBar.Location = new System.Drawing.Point(3, 0);
			this.ucTitleBar.Name = "ucTitleBar";
			this.ucTitleBar.Size = new System.Drawing.Size(502, 40);
			this.ucTitleBar.TabIndex = 2;
			// 
			// btnOK
			// 
			this.btnOK.AutoSize = true;
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnOK.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
			this.btnOK.IconColor = System.Drawing.Color.White;
			this.btnOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnOK.IconSize = 30;
			this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOK.Location = new System.Drawing.Point(12, 155);
			this.btnOK.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnOK.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnOK.Name = "btnOK";
			this.btnOK.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnOK.Size = new System.Drawing.Size(132, 43);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "تأیید";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.BackColor = System.Drawing.Color.White;
			this.btnCancel.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Edit;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
			this.btnCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancel.IconSize = 30;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(150, 155);
			this.btnCancel.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnCancel.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCancel.Size = new System.Drawing.Size(132, 43);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "لغو";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(3, 207);
			this.panel3.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panel1.Location = new System.Drawing.Point(505, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(3, 210);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panel2.Location = new System.Drawing.Point(0, 207);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(505, 3);
			this.panel2.TabIndex = 2;
			// 
			// FormMessage
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(508, 210);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.ucTitleBar);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMessage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Message";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label lblMessage;
		private UCTitleBar ucTitleBar;
		private MyCustomButton.MyCustomButton btnOK;
		private MyCustomButton.MyCustomButton btnCancel;
		private Panel panel3;
		private Panel panel1;
		private Panel panel2;
	}
}