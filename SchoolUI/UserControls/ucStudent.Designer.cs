namespace SchoolUI.UserControls
{
	partial class UCStudent
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cboxClassName = new System.Windows.Forms.ComboBox();
			this.lblClassName = new System.Windows.Forms.Label();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.cboxGradeName = new System.Windows.Forms.ComboBox();
			this.lblGradeName = new System.Windows.Forms.Label();
			this.btnDeleteAll = new MyCustomButton.MyCustomButton();
			this.gboxDisplay = new System.Windows.Forms.GroupBox();
			this.gboxAddEdit = new System.Windows.Forms.GroupBox();
			this.pboxPicture = new System.Windows.Forms.PictureBox();
			this.btnDeletePic = new MyCustomButton.MyCustomButton();
			this.txtFathername = new System.Windows.Forms.TextBox();
			this.lblFathername = new System.Windows.Forms.Label();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.txtNationalCode = new System.Windows.Forms.TextBox();
			this.lblFirstname = new System.Windows.Forms.Label();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.btnAddPic = new MyCustomButton.MyCustomButton();
			this.btnAdd = new MyCustomButton.MyCustomButton();
			this.lblNationalCode = new System.Windows.Forms.Label();
			this.btnEdit = new MyCustomButton.MyCustomButton();
			this.lblLastname = new System.Windows.Forms.Label();
			this.btnDelete = new MyCustomButton.MyCustomButton();
			this.gboxSearch = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnSeach = new MyCustomButton.MyCustomButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.gboxDisplay.SuspendLayout();
			this.gboxAddEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).BeginInit();
			this.gboxSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// cboxClassName
			// 
			this.cboxClassName.BackColor = System.Drawing.Color.White;
			this.cboxClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxClassName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxClassName.FormattingEnabled = true;
			this.cboxClassName.Location = new System.Drawing.Point(10, 149);
			this.cboxClassName.Name = "cboxClassName";
			this.cboxClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxClassName.Size = new System.Drawing.Size(351, 37);
			this.cboxClassName.TabIndex = 2;
			// 
			// lblClassName
			// 
			this.lblClassName.AutoSize = true;
			this.lblClassName.BackColor = System.Drawing.Color.White;
			this.lblClassName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblClassName.Location = new System.Drawing.Point(315, 119);
			this.lblClassName.Name = "lblClassName";
			this.lblClassName.Size = new System.Drawing.Size(48, 29);
			this.lblClassName.TabIndex = 16;
			this.lblClassName.Text = "کلاس";
			// 
			// dgvStudents
			// 
			this.dgvStudents.AllowUserToAddRows = false;
			this.dgvStudents.AllowUserToDeleteRows = false;
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(17, 115);
			this.dgvStudents.MultiSelect = false;
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvStudents.RowHeadersVisible = false;
			this.dgvStudents.RowHeadersWidth = 51;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStudents.RowTemplate.Height = 29;
			this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStudents.Size = new System.Drawing.Size(756, 674);
			this.dgvStudents.TabIndex = 5;
			this.dgvStudents.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDGV_CellEnter);
			this.dgvStudents.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.StudentsDGV_UserDeletedRow);
			// 
			// cboxGradeName
			// 
			this.cboxGradeName.BackColor = System.Drawing.Color.White;
			this.cboxGradeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxGradeName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxGradeName.FormattingEnabled = true;
			this.cboxGradeName.Location = new System.Drawing.Point(10, 66);
			this.cboxGradeName.Name = "cboxGradeName";
			this.cboxGradeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxGradeName.Size = new System.Drawing.Size(351, 37);
			this.cboxGradeName.TabIndex = 0;
			// 
			// lblGradeName
			// 
			this.lblGradeName.AutoSize = true;
			this.lblGradeName.BackColor = System.Drawing.Color.White;
			this.lblGradeName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblGradeName.Location = new System.Drawing.Point(328, 36);
			this.lblGradeName.Name = "lblGradeName";
			this.lblGradeName.Size = new System.Drawing.Size(34, 29);
			this.lblGradeName.TabIndex = 16;
			this.lblGradeName.Text = "پایه";
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
			this.btnDeleteAll.Location = new System.Drawing.Point(17, 67);
			this.btnDeleteAll.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteAll.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteAll.Size = new System.Drawing.Size(225, 43);
			this.btnDeleteAll.TabIndex = 4;
			this.btnDeleteAll.Text = "حذف همه";
			this.btnDeleteAll.UseVisualStyleBackColor = false;
			this.btnDeleteAll.Click += new System.EventHandler(this.DeleteAllButton_Click);
			// 
			// gboxDisplay
			// 
			this.gboxDisplay.Controls.Add(this.cboxGradeName);
			this.gboxDisplay.Controls.Add(this.lblClassName);
			this.gboxDisplay.Controls.Add(this.lblGradeName);
			this.gboxDisplay.Controls.Add(this.cboxClassName);
			this.gboxDisplay.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxDisplay.Location = new System.Drawing.Point(779, 5);
			this.gboxDisplay.Name = "gboxDisplay";
			this.gboxDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxDisplay.Size = new System.Drawing.Size(370, 203);
			this.gboxDisplay.TabIndex = 0;
			this.gboxDisplay.TabStop = false;
			this.gboxDisplay.Text = "نمایش دانش‌آموزان ";
			// 
			// gboxAddEdit
			// 
			this.gboxAddEdit.Controls.Add(this.pboxPicture);
			this.gboxAddEdit.Controls.Add(this.btnDeletePic);
			this.gboxAddEdit.Controls.Add(this.txtFathername);
			this.gboxAddEdit.Controls.Add(this.lblFathername);
			this.gboxAddEdit.Controls.Add(this.txtFirstname);
			this.gboxAddEdit.Controls.Add(this.txtNationalCode);
			this.gboxAddEdit.Controls.Add(this.lblFirstname);
			this.gboxAddEdit.Controls.Add(this.txtLastname);
			this.gboxAddEdit.Controls.Add(this.btnAddPic);
			this.gboxAddEdit.Controls.Add(this.btnAdd);
			this.gboxAddEdit.Controls.Add(this.lblNationalCode);
			this.gboxAddEdit.Controls.Add(this.btnEdit);
			this.gboxAddEdit.Controls.Add(this.lblLastname);
			this.gboxAddEdit.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxAddEdit.Location = new System.Drawing.Point(779, 214);
			this.gboxAddEdit.Name = "gboxAddEdit";
			this.gboxAddEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxAddEdit.Size = new System.Drawing.Size(370, 451);
			this.gboxAddEdit.TabIndex = 1;
			this.gboxAddEdit.TabStop = false;
			this.gboxAddEdit.Text = "افزودن | ویرایش ";
			// 
			// pboxPicture
			// 
			this.pboxPicture.ErrorImage = null;
			this.pboxPicture.Image = global::SchoolUI.Resources.StudentDefaultPicture;
			this.pboxPicture.InitialImage = null;
			this.pboxPicture.Location = new System.Drawing.Point(279, 38);
			this.pboxPicture.Name = "pboxPicture";
			this.pboxPicture.Size = new System.Drawing.Size(82, 82);
			this.pboxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxPicture.TabIndex = 35;
			this.pboxPicture.TabStop = false;
			// 
			// btnDeletePic
			// 
			this.btnDeletePic.AutoSize = true;
			this.btnDeletePic.BackColor = System.Drawing.Color.White;
			this.btnDeletePic.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Delete;
			this.btnDeletePic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeletePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeletePic.Font = new System.Drawing.Font("P - IRAN Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDeletePic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeletePic.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDeletePic.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeletePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDeletePic.IconSize = 20;
			this.btnDeletePic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeletePic.Location = new System.Drawing.Point(134, 81);
			this.btnDeletePic.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeletePic.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeletePic.Name = "btnDeletePic";
			this.btnDeletePic.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeletePic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeletePic.Size = new System.Drawing.Size(137, 41);
			this.btnDeletePic.TabIndex = 1;
			this.btnDeletePic.Text = "حذف تصویر";
			this.btnDeletePic.UseVisualStyleBackColor = false;
			this.btnDeletePic.Click += new System.EventHandler(this.DeletePicButton_Click);
			// 
			// txtFathername
			// 
			this.txtFathername.BackColor = System.Drawing.Color.White;
			this.txtFathername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFathername.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFathername.Location = new System.Drawing.Point(190, 322);
			this.txtFathername.Name = "txtFathername";
			this.txtFathername.Size = new System.Drawing.Size(170, 37);
			this.txtFathername.TabIndex = 4;
			// 
			// lblFathername
			// 
			this.lblFathername.AutoSize = true;
			this.lblFathername.BackColor = System.Drawing.Color.White;
			this.lblFathername.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFathername.Location = new System.Drawing.Point(302, 290);
			this.lblFathername.Name = "lblFathername";
			this.lblFathername.Size = new System.Drawing.Size(55, 29);
			this.lblFathername.TabIndex = 33;
			this.lblFathername.Text = "نام پدر";
			this.lblFathername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFirstname
			// 
			this.txtFirstname.BackColor = System.Drawing.Color.White;
			this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFirstname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFirstname.Location = new System.Drawing.Point(10, 155);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(351, 37);
			this.txtFirstname.TabIndex = 2;
			// 
			// txtNationalCode
			// 
			this.txtNationalCode.BackColor = System.Drawing.Color.White;
			this.txtNationalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNationalCode.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtNationalCode.Location = new System.Drawing.Point(10, 322);
			this.txtNationalCode.Name = "txtNationalCode";
			this.txtNationalCode.Size = new System.Drawing.Size(170, 37);
			this.txtNationalCode.TabIndex = 5;
			// 
			// lblFirstname
			// 
			this.lblFirstname.AutoSize = true;
			this.lblFirstname.BackColor = System.Drawing.Color.White;
			this.lblFirstname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFirstname.Location = new System.Drawing.Point(328, 123);
			this.lblFirstname.Name = "lblFirstname";
			this.lblFirstname.Size = new System.Drawing.Size(31, 29);
			this.lblFirstname.TabIndex = 33;
			this.lblFirstname.Text = "نام";
			this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLastname
			// 
			this.txtLastname.BackColor = System.Drawing.Color.White;
			this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLastname.Location = new System.Drawing.Point(10, 238);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(350, 37);
			this.txtLastname.TabIndex = 3;
			// 
			// btnAddPic
			// 
			this.btnAddPic.AutoSize = true;
			this.btnAddPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAddPic.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnAddPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPic.Font = new System.Drawing.Font("P - IRAN Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAddPic.ForeColor = System.Drawing.Color.White;
			this.btnAddPic.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddPic.IconColor = System.Drawing.Color.White;
			this.btnAddPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAddPic.IconSize = 20;
			this.btnAddPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddPic.Location = new System.Drawing.Point(134, 38);
			this.btnAddPic.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAddPic.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnAddPic.Name = "btnAddPic";
			this.btnAddPic.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnAddPic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnAddPic.Size = new System.Drawing.Size(137, 41);
			this.btnAddPic.TabIndex = 0;
			this.btnAddPic.Text = "افزودن تصویر";
			this.btnAddPic.UseVisualStyleBackColor = false;
			this.btnAddPic.Click += new System.EventHandler(this.AddPicButton_Click);
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
			this.btnAdd.Location = new System.Drawing.Point(191, 393);
			this.btnAdd.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnAdd.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnAdd.Size = new System.Drawing.Size(170, 43);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "افزودن";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// lblNationalCode
			// 
			this.lblNationalCode.AutoSize = true;
			this.lblNationalCode.BackColor = System.Drawing.Color.White;
			this.lblNationalCode.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNationalCode.Location = new System.Drawing.Point(119, 290);
			this.lblNationalCode.Name = "lblNationalCode";
			this.lblNationalCode.Size = new System.Drawing.Size(58, 29);
			this.lblNationalCode.TabIndex = 34;
			this.lblNationalCode.Text = "کد ملی";
			this.lblNationalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.btnEdit.Location = new System.Drawing.Point(10, 393);
			this.btnEdit.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnEdit.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnEdit.Size = new System.Drawing.Size(170, 43);
			this.btnEdit.TabIndex = 7;
			this.btnEdit.Text = "ویرایش";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// lblLastname
			// 
			this.lblLastname.AutoSize = true;
			this.lblLastname.BackColor = System.Drawing.Color.White;
			this.lblLastname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblLastname.Location = new System.Drawing.Point(262, 206);
			this.lblLastname.Name = "lblLastname";
			this.lblLastname.Size = new System.Drawing.Size(93, 29);
			this.lblLastname.TabIndex = 34;
			this.lblLastname.Text = "نام خانوادگی";
			this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.btnDelete.Location = new System.Drawing.Point(17, 18);
			this.btnDelete.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDelete.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDelete.Size = new System.Drawing.Size(225, 43);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "حذف";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// gboxSearch
			// 
			this.gboxSearch.Controls.Add(this.txtSearch);
			this.gboxSearch.Controls.Add(this.lblSearch);
			this.gboxSearch.Controls.Add(this.btnSeach);
			this.gboxSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxSearch.Location = new System.Drawing.Point(248, 5);
			this.gboxSearch.Name = "gboxSearch";
			this.gboxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxSearch.Size = new System.Drawing.Size(525, 105);
			this.gboxSearch.TabIndex = 2;
			this.gboxSearch.TabStop = false;
			this.gboxSearch.Text = "جستجو ";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.BackColor = System.Drawing.Color.White;
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtSearch.Location = new System.Drawing.Point(165, 59);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(351, 37);
			this.txtSearch.TabIndex = 0;
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.BackColor = System.Drawing.Color.White;
			this.lblSearch.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSearch.Location = new System.Drawing.Point(425, 29);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(90, 29);
			this.lblSearch.TabIndex = 33;
			this.lblSearch.Text = "متن جستجو";
			this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSeach
			// 
			this.btnSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSeach.AutoSize = true;
			this.btnSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnSeach.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnSeach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeach.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnSeach.ForeColor = System.Drawing.Color.White;
			this.btnSeach.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btnSeach.IconColor = System.Drawing.Color.White;
			this.btnSeach.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSeach.IconSize = 30;
			this.btnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSeach.Location = new System.Drawing.Point(6, 57);
			this.btnSeach.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnSeach.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnSeach.Name = "btnSeach";
			this.btnSeach.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnSeach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSeach.Size = new System.Drawing.Size(153, 43);
			this.btnSeach.TabIndex = 1;
			this.btnSeach.Text = "جستجو";
			this.btnSeach.UseVisualStyleBackColor = false;
			// 
			// UCStudent
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gboxSearch);
			this.Controls.Add(this.gboxAddEdit);
			this.Controls.Add(this.gboxDisplay);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.dgvStudents);
			this.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "UCStudent";
			this.Size = new System.Drawing.Size(1157, 807);
			this.Load += new System.EventHandler(this.UCStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.gboxDisplay.ResumeLayout(false);
			this.gboxDisplay.PerformLayout();
			this.gboxAddEdit.ResumeLayout(false);
			this.gboxAddEdit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).EndInit();
			this.gboxSearch.ResumeLayout(false);
			this.gboxSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ComboBox cboxClassName;
		private Label lblClassName;
		private DataGridView dgvStudents;
		private ComboBox cboxGradeName;
		private Label lblGradeName;
		private MyCustomButton.MyCustomButton btnDeleteAll;
		private GroupBox gboxDisplay;
		private GroupBox gboxAddEdit;
		private TextBox txtFirstname;
		private Label lblFirstname;
		private TextBox txtLastname;
		private MyCustomButton.MyCustomButton btnAdd;
		private MyCustomButton.MyCustomButton btnEdit;
		private Label lblLastname;
		private MyCustomButton.MyCustomButton btnDelete;
		private TextBox txtFathername;
		private Label lblFathername;
		private TextBox txtNationalCode;
		private Label lblNationalCode;
		private MyCustomButton.MyCustomButton btnDeletePic;
		private MyCustomButton.MyCustomButton btnAddPic;
		private GroupBox gboxSearch;
		private TextBox txtSearch;
		private Label lblSearch;
		private MyCustomButton.MyCustomButton btnSeach;
		private PictureBox pboxPicture;
	}
}
