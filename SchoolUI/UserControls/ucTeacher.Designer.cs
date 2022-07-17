namespace SchoolUI.UserControls
{
	partial class UCTeacher
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.lblFirstname = new System.Windows.Forms.Label();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.btnEdit = new MyCustomButton.MyCustomButton();
			this.lblLastname = new System.Windows.Forms.Label();
			this.btnAdd = new MyCustomButton.MyCustomButton();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.gboxAddEdit = new System.Windows.Forms.GroupBox();
			this.gboxSearch = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnSearch = new MyCustomButton.MyCustomButton();
			this.btnDelete = new MyCustomButton.MyCustomButton();
			this.btnDeleteAll = new MyCustomButton.MyCustomButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.gboxAddEdit.SuspendLayout();
			this.gboxSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTeachers.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(17, 29);
			this.dgvTeachers.MultiSelect = false;
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvTeachers.RowHeadersVisible = false;
			this.dgvTeachers.RowHeadersWidth = 51;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dgvTeachers.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTeachers.RowTemplate.Height = 29;
			this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvTeachers.Size = new System.Drawing.Size(756, 760);
			this.dgvTeachers.TabIndex = 4;
			this.dgvTeachers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTeachers_CellEnter);
			this.dgvTeachers.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DGVTeachers_UserDeletedRow);
			// 
			// lblFirstname
			// 
			this.lblFirstname.AutoSize = true;
			this.lblFirstname.BackColor = System.Drawing.Color.White;
			this.lblFirstname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFirstname.Location = new System.Drawing.Point(329, 37);
			this.lblFirstname.Name = "lblFirstname";
			this.lblFirstname.Size = new System.Drawing.Size(31, 29);
			this.lblFirstname.TabIndex = 33;
			this.lblFirstname.Text = "نام";
			this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFirstname
			// 
			this.txtFirstname.BackColor = System.Drawing.Color.White;
			this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFirstname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFirstname.Location = new System.Drawing.Point(10, 67);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(351, 37);
			this.txtFirstname.TabIndex = 3;
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
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "ویرایش";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// lblLastname
			// 
			this.lblLastname.AutoSize = true;
			this.lblLastname.BackColor = System.Drawing.Color.White;
			this.lblLastname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblLastname.Location = new System.Drawing.Point(263, 142);
			this.lblLastname.Name = "lblLastname";
			this.lblLastname.Size = new System.Drawing.Size(93, 29);
			this.lblLastname.TabIndex = 34;
			this.lblLastname.Text = "نام خانوادگی";
			this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "افزودن";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// txtLastname
			// 
			this.txtLastname.BackColor = System.Drawing.Color.White;
			this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastname.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLastname.Location = new System.Drawing.Point(10, 172);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(351, 37);
			this.txtLastname.TabIndex = 0;
			// 
			// gboxAddEdit
			// 
			this.gboxAddEdit.Controls.Add(this.txtFirstname);
			this.gboxAddEdit.Controls.Add(this.lblFirstname);
			this.gboxAddEdit.Controls.Add(this.txtLastname);
			this.gboxAddEdit.Controls.Add(this.btnAdd);
			this.gboxAddEdit.Controls.Add(this.btnEdit);
			this.gboxAddEdit.Controls.Add(this.lblLastname);
			this.gboxAddEdit.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxAddEdit.Location = new System.Drawing.Point(779, 234);
			this.gboxAddEdit.Name = "gboxAddEdit";
			this.gboxAddEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxAddEdit.Size = new System.Drawing.Size(370, 304);
			this.gboxAddEdit.TabIndex = 0;
			this.gboxAddEdit.TabStop = false;
			this.gboxAddEdit.Text = "افزودن | ویرایش ";
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
			this.gboxSearch.TabIndex = 3;
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
			this.txtSearch.TabIndex = 0;
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
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "جستجو";
			this.btnSearch.UseVisualStyleBackColor = false;
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
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "حذف";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
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
			this.btnDeleteAll.TabIndex = 2;
			this.btnDeleteAll.Text = "حذف همه";
			this.btnDeleteAll.UseVisualStyleBackColor = false;
			this.btnDeleteAll.Click += new System.EventHandler(this.DeleteAllButton_Click);
			// 
			// UCTeacher
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.gboxSearch);
			this.Controls.Add(this.gboxAddEdit);
			this.Controls.Add(this.dgvTeachers);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "UCTeacher";
			this.Size = new System.Drawing.Size(1157, 807);
			this.Load += new System.EventHandler(this.UCTeacher_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.gboxAddEdit.ResumeLayout(false);
			this.gboxAddEdit.PerformLayout();
			this.gboxSearch.ResumeLayout(false);
			this.gboxSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dgvTeachers;
		private Label lblFirstname;
		private TextBox txtFirstname;
		private MyCustomButton.MyCustomButton btnEdit;
		private Label lblLastname;
		private MyCustomButton.MyCustomButton btnAdd;
		private TextBox txtLastname;
		private GroupBox gboxAddEdit;
		private GroupBox gboxSearch;
		private TextBox txtSearch;
		private Label lblSearch;
		private MyCustomButton.MyCustomButton btnSearch;
		private MyCustomButton.MyCustomButton btnDelete;
		private MyCustomButton.MyCustomButton btnDeleteAll;
	}
}
