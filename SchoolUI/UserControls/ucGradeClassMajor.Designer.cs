namespace SchoolUI.UserControls
{
	partial class UCGradeClassMajor
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnDeleteGrade = new MyCustomButton.MyCustomButton();
			this.btnEditGrade = new MyCustomButton.MyCustomButton();
			this.btnAddGrade = new MyCustomButton.MyCustomButton();
			this.lblGradeName = new System.Windows.Forms.Label();
			this.txtGradeName = new System.Windows.Forms.TextBox();
			this.lboxGrade = new System.Windows.Forms.ListBox();
			this.btnDeleteAllGrades = new MyCustomButton.MyCustomButton();
			this.gboxGrade = new System.Windows.Forms.GroupBox();
			this.gboxClass = new System.Windows.Forms.GroupBox();
			this.txtClassName = new System.Windows.Forms.TextBox();
			this.lboxClass = new System.Windows.Forms.ListBox();
			this.lblClassName = new System.Windows.Forms.Label();
			this.btnAddClass = new MyCustomButton.MyCustomButton();
			this.btnEditClass = new MyCustomButton.MyCustomButton();
			this.btnDeleteClass = new MyCustomButton.MyCustomButton();
			this.btnDeleteAllClasses = new MyCustomButton.MyCustomButton();
			this.gboxGrade.SuspendLayout();
			this.gboxClass.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDeleteGrade
			// 
			this.btnDeleteGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteGrade.AutoSize = true;
			this.btnDeleteGrade.BackColor = System.Drawing.Color.White;
			this.btnDeleteGrade.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Delete;
			this.btnDeleteGrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDeleteGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteGrade.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDeleteGrade.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteGrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDeleteGrade.IconSize = 25;
			this.btnDeleteGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteGrade.Location = new System.Drawing.Point(386, 723);
			this.btnDeleteGrade.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteGrade.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteGrade.Name = "btnDeleteGrade";
			this.btnDeleteGrade.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteGrade.Size = new System.Drawing.Size(170, 43);
			this.btnDeleteGrade.TabIndex = 4;
			this.btnDeleteGrade.Text = "حذف";
			this.btnDeleteGrade.UseVisualStyleBackColor = false;
			this.btnDeleteGrade.Click += new System.EventHandler(this.DeleteGradeButton_Click);
			// 
			// btnEditGrade
			// 
			this.btnEditGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnEditGrade.AutoSize = true;
			this.btnEditGrade.BackColor = System.Drawing.Color.White;
			this.btnEditGrade.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Edit;
			this.btnEditGrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEditGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditGrade.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
			this.btnEditGrade.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditGrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEditGrade.IconSize = 25;
			this.btnEditGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditGrade.Location = new System.Drawing.Point(386, 122);
			this.btnEditGrade.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnEditGrade.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditGrade.Name = "btnEditGrade";
			this.btnEditGrade.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnEditGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnEditGrade.Size = new System.Drawing.Size(170, 43);
			this.btnEditGrade.TabIndex = 2;
			this.btnEditGrade.Text = "ویرایش";
			this.btnEditGrade.UseVisualStyleBackColor = false;
			this.btnEditGrade.Click += new System.EventHandler(this.EditGradeButton_Click);
			// 
			// btnAddGrade
			// 
			this.btnAddGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAddGrade.AutoSize = true;
			this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAddGrade.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnAddGrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAddGrade.ForeColor = System.Drawing.Color.White;
			this.btnAddGrade.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddGrade.IconColor = System.Drawing.Color.White;
			this.btnAddGrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAddGrade.IconSize = 25;
			this.btnAddGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddGrade.Location = new System.Drawing.Point(205, 122);
			this.btnAddGrade.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAddGrade.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnAddGrade.Name = "btnAddGrade";
			this.btnAddGrade.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnAddGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnAddGrade.Size = new System.Drawing.Size(170, 43);
			this.btnAddGrade.TabIndex = 1;
			this.btnAddGrade.Text = "افزودن";
			this.btnAddGrade.UseVisualStyleBackColor = false;
			this.btnAddGrade.Click += new System.EventHandler(this.AddGradeButton_Click);
			// 
			// lblGradeName
			// 
			this.lblGradeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblGradeName.AutoSize = true;
			this.lblGradeName.BackColor = System.Drawing.Color.White;
			this.lblGradeName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblGradeName.Location = new System.Drawing.Point(499, 36);
			this.lblGradeName.Name = "lblGradeName";
			this.lblGradeName.Size = new System.Drawing.Size(57, 29);
			this.lblGradeName.TabIndex = 31;
			this.lblGradeName.Text = "نام پایه";
			// 
			// txtGradeName
			// 
			this.txtGradeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGradeName.BackColor = System.Drawing.Color.White;
			this.txtGradeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGradeName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtGradeName.Location = new System.Drawing.Point(10, 68);
			this.txtGradeName.Name = "txtGradeName";
			this.txtGradeName.Size = new System.Drawing.Size(546, 37);
			this.txtGradeName.TabIndex = 0;
			// 
			// lboxGrade
			// 
			this.lboxGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lboxGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lboxGrade.FormattingEnabled = true;
			this.lboxGrade.ItemHeight = 29;
			this.lboxGrade.Location = new System.Drawing.Point(10, 177);
			this.lboxGrade.Name = "lboxGrade";
			this.lboxGrade.Size = new System.Drawing.Size(546, 526);
			this.lboxGrade.TabIndex = 3;
			// 
			// btnDeleteAllGrades
			// 
			this.btnDeleteAllGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteAllGrades.AutoSize = true;
			this.btnDeleteAllGrades.BackColor = System.Drawing.Color.White;
			this.btnDeleteAllGrades.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Delete;
			this.btnDeleteAllGrades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteAllGrades.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDeleteAllGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllGrades.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDeleteAllGrades.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllGrades.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDeleteAllGrades.IconSize = 25;
			this.btnDeleteAllGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteAllGrades.Location = new System.Drawing.Point(205, 723);
			this.btnDeleteAllGrades.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteAllGrades.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllGrades.Name = "btnDeleteAllGrades";
			this.btnDeleteAllGrades.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteAllGrades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteAllGrades.Size = new System.Drawing.Size(170, 43);
			this.btnDeleteAllGrades.TabIndex = 5;
			this.btnDeleteAllGrades.Text = "حذف همه";
			this.btnDeleteAllGrades.UseVisualStyleBackColor = false;
			this.btnDeleteAllGrades.Click += new System.EventHandler(this.DeleteAllGradesButton_Click);
			// 
			// gboxGrade
			// 
			this.gboxGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gboxGrade.Controls.Add(this.txtGradeName);
			this.gboxGrade.Controls.Add(this.lboxGrade);
			this.gboxGrade.Controls.Add(this.lblGradeName);
			this.gboxGrade.Controls.Add(this.btnAddGrade);
			this.gboxGrade.Controls.Add(this.btnEditGrade);
			this.gboxGrade.Controls.Add(this.btnDeleteGrade);
			this.gboxGrade.Controls.Add(this.btnDeleteAllGrades);
			this.gboxGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxGrade.Location = new System.Drawing.Point(583, 12);
			this.gboxGrade.Name = "gboxGrade";
			this.gboxGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxGrade.Size = new System.Drawing.Size(565, 779);
			this.gboxGrade.TabIndex = 0;
			this.gboxGrade.TabStop = false;
			this.gboxGrade.Text = "پایه ";
			// 
			// gboxClass
			// 
			this.gboxClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.gboxClass.Controls.Add(this.txtClassName);
			this.gboxClass.Controls.Add(this.lboxClass);
			this.gboxClass.Controls.Add(this.lblClassName);
			this.gboxClass.Controls.Add(this.btnAddClass);
			this.gboxClass.Controls.Add(this.btnEditClass);
			this.gboxClass.Controls.Add(this.btnDeleteClass);
			this.gboxClass.Controls.Add(this.btnDeleteAllClasses);
			this.gboxClass.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxClass.Location = new System.Drawing.Point(12, 12);
			this.gboxClass.Name = "gboxClass";
			this.gboxClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxClass.Size = new System.Drawing.Size(565, 779);
			this.gboxClass.TabIndex = 2;
			this.gboxClass.TabStop = false;
			this.gboxClass.Text = "کلاس ";
			// 
			// txtClassName
			// 
			this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtClassName.BackColor = System.Drawing.Color.White;
			this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClassName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtClassName.Location = new System.Drawing.Point(10, 68);
			this.txtClassName.Name = "txtClassName";
			this.txtClassName.Size = new System.Drawing.Size(546, 37);
			this.txtClassName.TabIndex = 0;
			// 
			// lboxClass
			// 
			this.lboxClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lboxClass.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lboxClass.FormattingEnabled = true;
			this.lboxClass.ItemHeight = 29;
			this.lboxClass.Location = new System.Drawing.Point(10, 177);
			this.lboxClass.Name = "lboxClass";
			this.lboxClass.Size = new System.Drawing.Size(546, 526);
			this.lboxClass.TabIndex = 3;
			this.lboxClass.SelectedValueChanged += new System.EventHandler(this.ClassListBox_SelectedValueChanged);
			// 
			// lblClassName
			// 
			this.lblClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblClassName.AutoSize = true;
			this.lblClassName.BackColor = System.Drawing.Color.White;
			this.lblClassName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblClassName.Location = new System.Drawing.Point(485, 36);
			this.lblClassName.Name = "lblClassName";
			this.lblClassName.Size = new System.Drawing.Size(71, 29);
			this.lblClassName.TabIndex = 31;
			this.lblClassName.Text = "نام کلاس";
			// 
			// btnAddClass
			// 
			this.btnAddClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAddClass.AutoSize = true;
			this.btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAddClass.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnAddClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddClass.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAddClass.ForeColor = System.Drawing.Color.White;
			this.btnAddClass.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddClass.IconColor = System.Drawing.Color.White;
			this.btnAddClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAddClass.IconSize = 25;
			this.btnAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddClass.Location = new System.Drawing.Point(205, 122);
			this.btnAddClass.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAddClass.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnAddClass.Name = "btnAddClass";
			this.btnAddClass.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnAddClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnAddClass.Size = new System.Drawing.Size(170, 43);
			this.btnAddClass.TabIndex = 1;
			this.btnAddClass.Text = "افزودن";
			this.btnAddClass.UseVisualStyleBackColor = false;
			this.btnAddClass.Click += new System.EventHandler(this.AddClassButton_Click);
			// 
			// btnEditClass
			// 
			this.btnEditClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnEditClass.AutoSize = true;
			this.btnEditClass.BackColor = System.Drawing.Color.White;
			this.btnEditClass.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Edit;
			this.btnEditClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditClass.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEditClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditClass.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
			this.btnEditClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEditClass.IconSize = 25;
			this.btnEditClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditClass.Location = new System.Drawing.Point(386, 122);
			this.btnEditClass.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnEditClass.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEditClass.Name = "btnEditClass";
			this.btnEditClass.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnEditClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnEditClass.Size = new System.Drawing.Size(170, 43);
			this.btnEditClass.TabIndex = 2;
			this.btnEditClass.Text = "ویرایش";
			this.btnEditClass.UseVisualStyleBackColor = false;
			this.btnEditClass.Click += new System.EventHandler(this.EditClassButton_Click);
			// 
			// btnDeleteClass
			// 
			this.btnDeleteClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteClass.AutoSize = true;
			this.btnDeleteClass.BackColor = System.Drawing.Color.White;
			this.btnDeleteClass.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Delete;
			this.btnDeleteClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteClass.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDeleteClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteClass.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDeleteClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDeleteClass.IconSize = 25;
			this.btnDeleteClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteClass.Location = new System.Drawing.Point(386, 723);
			this.btnDeleteClass.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteClass.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteClass.Name = "btnDeleteClass";
			this.btnDeleteClass.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteClass.Size = new System.Drawing.Size(170, 43);
			this.btnDeleteClass.TabIndex = 4;
			this.btnDeleteClass.Text = "حذف";
			this.btnDeleteClass.UseVisualStyleBackColor = false;
			this.btnDeleteClass.Click += new System.EventHandler(this.DeleteClassButton_Click);
			// 
			// btnDeleteAllClasses
			// 
			this.btnDeleteAllClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteAllClasses.AutoSize = true;
			this.btnDeleteAllClasses.BackColor = System.Drawing.Color.White;
			this.btnDeleteAllClasses.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Delete;
			this.btnDeleteAllClasses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteAllClasses.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDeleteAllClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllClasses.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDeleteAllClasses.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDeleteAllClasses.IconSize = 25;
			this.btnDeleteAllClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteAllClasses.Location = new System.Drawing.Point(205, 723);
			this.btnDeleteAllClasses.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteAllClasses.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAllClasses.Name = "btnDeleteAllClasses";
			this.btnDeleteAllClasses.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteAllClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteAllClasses.Size = new System.Drawing.Size(170, 43);
			this.btnDeleteAllClasses.TabIndex = 5;
			this.btnDeleteAllClasses.Text = "حذف همه";
			this.btnDeleteAllClasses.UseVisualStyleBackColor = false;
			this.btnDeleteAllClasses.Click += new System.EventHandler(this.DeleteAllClassesButton_Click);
			// 
			// UCGradeClassMajor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gboxClass);
			this.Controls.Add(this.gboxGrade);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "UCGradeClassMajor";
			this.Size = new System.Drawing.Size(1157, 807);
			this.Load += new System.EventHandler(this.UCGradeMajorClass_Load);
			this.gboxGrade.ResumeLayout(false);
			this.gboxGrade.PerformLayout();
			this.gboxClass.ResumeLayout(false);
			this.gboxClass.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MyCustomButton.MyCustomButton btnDeleteGrade;
		private MyCustomButton.MyCustomButton btnEditGrade;
		private MyCustomButton.MyCustomButton btnAddGrade;
		private Label lblGradeName;
		private TextBox txtGradeName;
		private ListBox lboxGrade;
		private MyCustomButton.MyCustomButton btnDeleteAllGrades;
		private GroupBox gboxGrade;
		private GroupBox gboxClass;
		private TextBox txtClassName;
		private ListBox lboxClass;
		private Label lblClassName;
		private MyCustomButton.MyCustomButton btnAddClass;
		private MyCustomButton.MyCustomButton btnEditClass;
		private MyCustomButton.MyCustomButton btnDeleteClass;
		private MyCustomButton.MyCustomButton btnDeleteAllClasses;
	}
}
