namespace SchoolUI.UserControls
{
	partial class UCLesson
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvLesson = new System.Windows.Forms.DataGridView();
			this.btnDeleteAll = new MyCustomButton.MyCustomButton();
			this.gboxSearch = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnSearch = new MyCustomButton.MyCustomButton();
			this.gboxAddEdit = new System.Windows.Forms.GroupBox();
			this.cboxGrade = new System.Windows.Forms.ComboBox();
			this.cboxTeachers = new System.Windows.Forms.ComboBox();
			this.lblTeacherName = new System.Windows.Forms.Label();
			this.numNumberOfUnits = new System.Windows.Forms.NumericUpDown();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblGrade = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new MyCustomButton.MyCustomButton();
			this.btnEdit = new MyCustomButton.MyCustomButton();
			this.lblNumberOfUnits = new System.Windows.Forms.Label();
			this.btnDelete = new MyCustomButton.MyCustomButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
			this.gboxSearch.SuspendLayout();
			this.gboxAddEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNumberOfUnits)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLesson
			// 
			this.dgvLesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLesson.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLesson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLesson.Location = new System.Drawing.Point(17, 29);
			this.dgvLesson.MultiSelect = false;
			this.dgvLesson.Name = "dgvLesson";
			this.dgvLesson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvLesson.RowHeadersVisible = false;
			this.dgvLesson.RowHeadersWidth = 51;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dgvLesson.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvLesson.RowTemplate.Height = 29;
			this.dgvLesson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvLesson.Size = new System.Drawing.Size(756, 760);
			this.dgvLesson.TabIndex = 1;
			this.dgvLesson.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.LessonDGV_CellEnter);
			this.dgvLesson.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.LessonDGV_UserDeletedRow);
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.AutoSize = true;
			this.btnDeleteAll.BackColor = System.Drawing.Color.White;
			this.btnDeleteAll.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Delete;
			this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteAll.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAll.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDeleteAll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDeleteAll.IconSize = 30;
			this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteAll.Location = new System.Drawing.Point(789, 746);
			this.btnDeleteAll.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteAll.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteAll.Size = new System.Drawing.Size(351, 43);
			this.btnDeleteAll.TabIndex = 15;
			this.btnDeleteAll.Text = "حذف همه";
			this.btnDeleteAll.UseVisualStyleBackColor = false;
			this.btnDeleteAll.Click += new System.EventHandler(this.DeleteAllButton_Click);
			// 
			// gboxSearch
			// 
			this.gboxSearch.Controls.Add(this.txtSearch);
			this.gboxSearch.Controls.Add(this.lblSearch);
			this.gboxSearch.Controls.Add(this.btnSearch);
			this.gboxSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxSearch.Location = new System.Drawing.Point(779, 13);
			this.gboxSearch.Name = "gboxSearch";
			this.gboxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxSearch.Size = new System.Drawing.Size(370, 192);
			this.gboxSearch.TabIndex = 40;
			this.gboxSearch.TabStop = false;
			this.gboxSearch.Text = "جستجو ";
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.White;
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtSearch.Location = new System.Drawing.Point(10, 67);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(351, 37);
			this.txtSearch.TabIndex = 35;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.BackColor = System.Drawing.Color.White;
			this.lblSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSearch.Location = new System.Drawing.Point(267, 37);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(90, 29);
			this.lblSearch.TabIndex = 33;
			this.lblSearch.Text = "متن جستجو";
			this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSearch
			// 
			this.btnSearch.AutoSize = true;
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnSearch.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btnSearch.IconColor = System.Drawing.Color.White;
			this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnSearch.IconSize = 30;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(10, 130);
			this.btnSearch.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnSearch.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSearch.Size = new System.Drawing.Size(351, 43);
			this.btnSearch.TabIndex = 38;
			this.btnSearch.Text = "جستجو";
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// gboxAddEdit
			// 
			this.gboxAddEdit.Controls.Add(this.cboxGrade);
			this.gboxAddEdit.Controls.Add(this.cboxTeachers);
			this.gboxAddEdit.Controls.Add(this.lblTeacherName);
			this.gboxAddEdit.Controls.Add(this.numNumberOfUnits);
			this.gboxAddEdit.Controls.Add(this.txtName);
			this.gboxAddEdit.Controls.Add(this.lblGrade);
			this.gboxAddEdit.Controls.Add(this.label1);
			this.gboxAddEdit.Controls.Add(this.btnAdd);
			this.gboxAddEdit.Controls.Add(this.btnEdit);
			this.gboxAddEdit.Controls.Add(this.lblNumberOfUnits);
			this.gboxAddEdit.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxAddEdit.Location = new System.Drawing.Point(779, 234);
			this.gboxAddEdit.Name = "gboxAddEdit";
			this.gboxAddEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxAddEdit.Size = new System.Drawing.Size(370, 379);
			this.gboxAddEdit.TabIndex = 41;
			this.gboxAddEdit.TabStop = false;
			this.gboxAddEdit.Text = "انتخاب | افزودن | ویرایش ";
			// 
			// cboxGrade
			// 
			this.cboxGrade.BackColor = System.Drawing.Color.White;
			this.cboxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxGrade.FormattingEnabled = true;
			this.cboxGrade.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
			this.cboxGrade.Location = new System.Drawing.Point(10, 65);
			this.cboxGrade.Name = "cboxGrade";
			this.cboxGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxGrade.Size = new System.Drawing.Size(351, 37);
			this.cboxGrade.TabIndex = 54;
			// 
			// cboxTeachers
			// 
			this.cboxTeachers.BackColor = System.Drawing.Color.White;
			this.cboxTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxTeachers.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxTeachers.FormattingEnabled = true;
			this.cboxTeachers.Location = new System.Drawing.Point(10, 246);
			this.cboxTeachers.Name = "cboxTeachers";
			this.cboxTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxTeachers.Size = new System.Drawing.Size(209, 37);
			this.cboxTeachers.TabIndex = 52;
			// 
			// lblTeacherName
			// 
			this.lblTeacherName.AutoSize = true;
			this.lblTeacherName.BackColor = System.Drawing.Color.White;
			this.lblTeacherName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTeacherName.Location = new System.Drawing.Point(155, 216);
			this.lblTeacherName.Name = "lblTeacherName";
			this.lblTeacherName.Size = new System.Drawing.Size(59, 29);
			this.lblTeacherName.TabIndex = 53;
			this.lblTeacherName.Text = "نام دبیر";
			// 
			// numNumberOfUnits
			// 
			this.numNumberOfUnits.BackColor = System.Drawing.Color.White;
			this.numNumberOfUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numNumberOfUnits.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numNumberOfUnits.Location = new System.Drawing.Point(236, 246);
			this.numNumberOfUnits.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.numNumberOfUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numNumberOfUnits.Name = "numNumberOfUnits";
			this.numNumberOfUnits.Size = new System.Drawing.Size(125, 37);
			this.numNumberOfUnits.TabIndex = 39;
			this.numNumberOfUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numNumberOfUnits.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numNumberOfUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.White;
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtName.Location = new System.Drawing.Point(10, 141);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(351, 37);
			this.txtName.TabIndex = 35;
			// 
			// lblGrade
			// 
			this.lblGrade.BackColor = System.Drawing.Color.White;
			this.lblGrade.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblGrade.Location = new System.Drawing.Point(267, 35);
			this.lblGrade.Name = "lblGrade";
			this.lblGrade.Size = new System.Drawing.Size(94, 27);
			this.lblGrade.TabIndex = 33;
			this.lblGrade.Text = "رشته";
			this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(329, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 29);
			this.label1.TabIndex = 33;
			this.label1.Text = "نام";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAdd
			// 
			this.btnAdd.AutoSize = true;
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAdd.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.White;
			this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAdd.IconSize = 30;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(203, 320);
			this.btnAdd.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAdd.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnAdd.Size = new System.Drawing.Size(158, 43);
			this.btnAdd.TabIndex = 38;
			this.btnAdd.Text = "افزودن";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.AutoSize = true;
			this.btnEdit.BackColor = System.Drawing.Color.White;
			this.btnEdit.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Edit;
			this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
			this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEdit.IconSize = 30;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(10, 320);
			this.btnEdit.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnEdit.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnEdit.Size = new System.Drawing.Size(158, 43);
			this.btnEdit.TabIndex = 37;
			this.btnEdit.Text = "ویرایش";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// lblNumberOfUnits
			// 
			this.lblNumberOfUnits.AutoSize = true;
			this.lblNumberOfUnits.BackColor = System.Drawing.Color.White;
			this.lblNumberOfUnits.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNumberOfUnits.Location = new System.Drawing.Point(276, 216);
			this.lblNumberOfUnits.Name = "lblNumberOfUnits";
			this.lblNumberOfUnits.Size = new System.Drawing.Size(78, 29);
			this.lblNumberOfUnits.TabIndex = 34;
			this.lblNumberOfUnits.Text = "تعداد واحد";
			this.lblNumberOfUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = true;
			this.btnDelete.BackColor = System.Drawing.Color.White;
			this.btnDelete.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Delete;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDelete.IconSize = 30;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(789, 697);
			this.btnDelete.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDelete.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDelete.Size = new System.Drawing.Size(351, 43);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "حذف";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UCLesson
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gboxSearch);
			this.Controls.Add(this.gboxAddEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.dgvLesson);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "UCLesson";
			this.Size = new System.Drawing.Size(1157, 807);
			this.Load += new System.EventHandler(this.UCLesson_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
			this.gboxSearch.ResumeLayout(false);
			this.gboxSearch.PerformLayout();
			this.gboxAddEdit.ResumeLayout(false);
			this.gboxAddEdit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNumberOfUnits)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvLesson;
		private MyCustomButton.MyCustomButton btnDeleteAll;
		private GroupBox gboxSearch;
		private TextBox txtSearch;
		private Label lblSearch;
		private MyCustomButton.MyCustomButton btnSearch;
		private GroupBox gboxAddEdit;
		private TextBox txtName;
		private Label label1;
		private MyCustomButton.MyCustomButton btnAdd;
		private MyCustomButton.MyCustomButton btnEdit;
		private Label lblNumberOfUnits;
		private MyCustomButton.MyCustomButton btnDelete;
		private NumericUpDown numNumberOfUnits;
		private ComboBox cboxTeachers;
		private Label lblTeacherName;
		private Label lblGrade;
		private ComboBox cboxGrade;
	}
}
