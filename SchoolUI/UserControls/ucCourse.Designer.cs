namespace SchoolUI.UserControls
{
	partial class UCCourse
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvCourses = new System.Windows.Forms.DataGridView();
			this.btnDeleteAll = new MyCustomButton.MyCustomButton();
			this.btnChangeCurrentCourse = new MyCustomButton.MyCustomButton();
			this.gboxSearch = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnSearch = new MyCustomButton.MyCustomButton();
			this.gboxAddEdit = new System.Windows.Forms.GroupBox();
			this.cboxYear = new System.Windows.Forms.ComboBox();
			this.cboxMonth = new System.Windows.Forms.ComboBox();
			this.lblMonth = new System.Windows.Forms.Label();
			this.btnAdd = new MyCustomButton.MyCustomButton();
			this.btnEdit = new MyCustomButton.MyCustomButton();
			this.lblYear = new System.Windows.Forms.Label();
			this.btnDelete = new MyCustomButton.MyCustomButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
			this.gboxSearch.SuspendLayout();
			this.gboxAddEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCourses
			// 
			this.dgvCourses.AllowUserToAddRows = false;
			this.dgvCourses.AllowUserToDeleteRows = false;
			this.dgvCourses.AllowUserToResizeRows = false;
			this.dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
			this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCourses.Location = new System.Drawing.Point(17, 29);
			this.dgvCourses.MultiSelect = false;
			this.dgvCourses.Name = "dgvCourses";
			this.dgvCourses.ReadOnly = true;
			this.dgvCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvCourses.RowHeadersVisible = false;
			this.dgvCourses.RowHeadersWidth = 51;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dgvCourses.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCourses.RowTemplate.Height = 29;
			this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCourses.Size = new System.Drawing.Size(756, 760);
			this.dgvCourses.TabIndex = 0;
			this.dgvCourses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCourse_CellEnter);
			this.dgvCourses.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DGVCourse_UsedDeletedRow);
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnDeleteAll.Location = new System.Drawing.Point(788, 686);
			this.btnDeleteAll.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteAll.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteAll.Size = new System.Drawing.Size(351, 43);
			this.btnDeleteAll.TabIndex = 9;
			this.btnDeleteAll.Text = "حذف همه";
			this.btnDeleteAll.UseVisualStyleBackColor = false;
			this.btnDeleteAll.Click += new System.EventHandler(this.DeleteAllButton_Click);
			// 
			// btnChangeCurrentCourse
			// 
			this.btnChangeCurrentCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnChangeCurrentCourse.AutoSize = true;
			this.btnChangeCurrentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnChangeCurrentCourse.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnChangeCurrentCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnChangeCurrentCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeCurrentCourse.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnChangeCurrentCourse.ForeColor = System.Drawing.Color.White;
			this.btnChangeCurrentCourse.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
			this.btnChangeCurrentCourse.IconColor = System.Drawing.Color.White;
			this.btnChangeCurrentCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnChangeCurrentCourse.IconSize = 30;
			this.btnChangeCurrentCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChangeCurrentCourse.Location = new System.Drawing.Point(789, 746);
			this.btnChangeCurrentCourse.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnChangeCurrentCourse.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnChangeCurrentCourse.Name = "btnChangeCurrentCourse";
			this.btnChangeCurrentCourse.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnChangeCurrentCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnChangeCurrentCourse.Size = new System.Drawing.Size(351, 43);
			this.btnChangeCurrentCourse.TabIndex = 9;
			this.btnChangeCurrentCourse.Text = "تغییر به دوره انتخاب شده";
			this.btnChangeCurrentCourse.UseVisualStyleBackColor = false;
			this.btnChangeCurrentCourse.Click += new System.EventHandler(this.ChangeCourseButton_Click);
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
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.BackColor = System.Drawing.Color.White;
			this.lblSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSearch.Location = new System.Drawing.Point(270, 37);
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
			this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
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
			this.gboxAddEdit.Controls.Add(this.cboxYear);
			this.gboxAddEdit.Controls.Add(this.cboxMonth);
			this.gboxAddEdit.Controls.Add(this.lblMonth);
			this.gboxAddEdit.Controls.Add(this.btnAdd);
			this.gboxAddEdit.Controls.Add(this.btnEdit);
			this.gboxAddEdit.Controls.Add(this.lblYear);
			this.gboxAddEdit.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxAddEdit.Location = new System.Drawing.Point(779, 234);
			this.gboxAddEdit.Name = "gboxAddEdit";
			this.gboxAddEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxAddEdit.Size = new System.Drawing.Size(370, 304);
			this.gboxAddEdit.TabIndex = 41;
			this.gboxAddEdit.TabStop = false;
			this.gboxAddEdit.Text = "افزودن | ویرایش ";
			// 
			// cboxYear
			// 
			this.cboxYear.BackColor = System.Drawing.Color.White;
			this.cboxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxYear.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxYear.FormattingEnabled = true;
			this.cboxYear.Location = new System.Drawing.Point(10, 172);
			this.cboxYear.Name = "cboxYear";
			this.cboxYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxYear.Size = new System.Drawing.Size(351, 37);
			this.cboxYear.TabIndex = 39;
			// 
			// cboxMonth
			// 
			this.cboxMonth.BackColor = System.Drawing.Color.White;
			this.cboxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMonth.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxMonth.FormattingEnabled = true;
			this.cboxMonth.Items.AddRange(new object[] {
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
			this.cboxMonth.Location = new System.Drawing.Point(10, 67);
			this.cboxMonth.Name = "cboxMonth";
			this.cboxMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxMonth.Size = new System.Drawing.Size(351, 37);
			this.cboxMonth.TabIndex = 39;
			// 
			// lblMonth
			// 
			this.lblMonth.AutoSize = true;
			this.lblMonth.BackColor = System.Drawing.Color.White;
			this.lblMonth.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMonth.Location = new System.Drawing.Point(329, 35);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(31, 29);
			this.lblMonth.TabIndex = 33;
			this.lblMonth.Text = "ماه";
			this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.btnAdd.Location = new System.Drawing.Point(203, 246);
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
			this.btnEdit.Location = new System.Drawing.Point(10, 246);
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
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.BackColor = System.Drawing.Color.White;
			this.lblYear.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblYear.Location = new System.Drawing.Point(266, 140);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(94, 29);
			this.lblYear.TabIndex = 34;
			this.lblYear.Text = "سال تحصیلی";
			this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnDelete.Location = new System.Drawing.Point(788, 637);
			this.btnDelete.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDelete.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDelete.Size = new System.Drawing.Size(351, 43);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "حذف";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UCCourse
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gboxSearch);
			this.Controls.Add(this.gboxAddEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.btnChangeCurrentCourse);
			this.Controls.Add(this.dgvCourses);
			this.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.MinimumSize = new System.Drawing.Size(1157, 807);
			this.Name = "UCCourse";
			this.Size = new System.Drawing.Size(1157, 807);
			this.Tag = "";
			this.Load += new System.EventHandler(this.UCCourse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
			this.gboxSearch.ResumeLayout(false);
			this.gboxSearch.PerformLayout();
			this.gboxAddEdit.ResumeLayout(false);
			this.gboxAddEdit.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dgvCourses;
		private MyCustomButton.MyCustomButton btnDeleteAll;
		private MyCustomButton.MyCustomButton btnChangeCurrentCourse;
		private GroupBox gboxSearch;
		private TextBox txtSearch;
		private Label lblSearch;
		private MyCustomButton.MyCustomButton btnSearch;
		private GroupBox gboxAddEdit;
		private Label lblMonth;
		private MyCustomButton.MyCustomButton btnAdd;
		private MyCustomButton.MyCustomButton btnEdit;
		private Label lblYear;
		private MyCustomButton.MyCustomButton btnDelete;
		private ComboBox cboxMonth;
		private ComboBox cboxYear;
	}
}
