using SchoolUI.UserControls.Reusables;

namespace SchoolUI.Forms
{
	partial class FormReport
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
			this.lblGrade = new System.Windows.Forms.Label();
			this.ucTitleBar = new SchoolUI.UserControls.Reusables.UCTitleBar();
			this.cboxGrade = new System.Windows.Forms.ComboBox();
			this.cboxClass = new System.Windows.Forms.ComboBox();
			this.lblClass = new System.Windows.Forms.Label();
			this.btnPrint = new MyCustomButton.MyCustomButton();
			this.btnCancel = new MyCustomButton.MyCustomButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lblGrade
			// 
			this.lblGrade.AutoSize = true;
			this.lblGrade.BackColor = System.Drawing.Color.White;
			this.lblGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblGrade.Location = new System.Drawing.Point(329, 54);
			this.lblGrade.Name = "lblGrade";
			this.lblGrade.Size = new System.Drawing.Size(34, 29);
			this.lblGrade.TabIndex = 28;
			this.lblGrade.Text = "پایه";
			// 
			// ucTitleBar
			// 
			this.ucTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.ucTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.ucTitleBar.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ucTitleBar.Location = new System.Drawing.Point(0, 0);
			this.ucTitleBar.Name = "ucTitleBar";
			this.ucTitleBar.Size = new System.Drawing.Size(378, 40);
			this.ucTitleBar.TabIndex = 34;
			// 
			// cboxGrade
			// 
			this.cboxGrade.BackColor = System.Drawing.Color.White;
			this.cboxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxGrade.FormattingEnabled = true;
			this.cboxGrade.Location = new System.Drawing.Point(12, 86);
			this.cboxGrade.Name = "cboxGrade";
			this.cboxGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxGrade.Size = new System.Drawing.Size(351, 37);
			this.cboxGrade.TabIndex = 40;
			// 
			// cboxClass
			// 
			this.cboxClass.BackColor = System.Drawing.Color.White;
			this.cboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxClass.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxClass.FormattingEnabled = true;
			this.cboxClass.Location = new System.Drawing.Point(12, 161);
			this.cboxClass.Name = "cboxClass";
			this.cboxClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxClass.Size = new System.Drawing.Size(351, 37);
			this.cboxClass.TabIndex = 42;
			// 
			// lblClass
			// 
			this.lblClass.AutoSize = true;
			this.lblClass.BackColor = System.Drawing.Color.White;
			this.lblClass.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblClass.Location = new System.Drawing.Point(315, 129);
			this.lblClass.Name = "lblClass";
			this.lblClass.Size = new System.Drawing.Size(48, 29);
			this.lblClass.TabIndex = 41;
			this.lblClass.Text = "کلاس";
			// 
			// btnPrint
			// 
			this.btnPrint.AutoSize = true;
			this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnPrint.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnPrint.ForeColor = System.Drawing.Color.White;
			this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
			this.btnPrint.IconColor = System.Drawing.Color.White;
			this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPrint.IconSize = 30;
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrint.Location = new System.Drawing.Point(12, 221);
			this.btnPrint.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnPrint.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnPrint.Size = new System.Drawing.Size(158, 43);
			this.btnPrint.TabIndex = 44;
			this.btnPrint.Text = "چاپ";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.PrintButton_Click);
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
			this.btnCancel.Location = new System.Drawing.Point(205, 221);
			this.btnCancel.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnCancel.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCancel.Size = new System.Drawing.Size(158, 43);
			this.btnCancel.TabIndex = 43;
			this.btnCancel.Text = "لغو";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panel3.Location = new System.Drawing.Point(0, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(3, 233);
			this.panel3.TabIndex = 47;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panel2.Location = new System.Drawing.Point(0, 273);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(375, 3);
			this.panel2.TabIndex = 46;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panel1.Location = new System.Drawing.Point(375, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(3, 236);
			this.panel1.TabIndex = 45;
			// 
			// FormReport
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(378, 276);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.cboxClass);
			this.Controls.Add(this.lblClass);
			this.Controls.Add(this.cboxGrade);
			this.Controls.Add(this.ucTitleBar);
			this.Controls.Add(this.lblGrade);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddEditStudent";
			this.Load += new System.EventHandler(this.FormReport_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblGrade;
		private UCTitleBar ucTitleBar;
		private ComboBox cboxGrade;
		private ComboBox cboxClass;
		private Label lblClass;
		private MyCustomButton.MyCustomButton btnPrint;
		private MyCustomButton.MyCustomButton btnCancel;
		private Panel panel3;
		private Panel panel2;
		private Panel panel1;
	}
}