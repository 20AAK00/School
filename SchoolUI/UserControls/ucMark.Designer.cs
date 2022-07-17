namespace SchoolUI.UserControls
{
	partial class UCMark
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
			this.dgvMarks = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblGradeName = new System.Windows.Forms.Label();
			this.cboxGradeName = new System.Windows.Forms.ComboBox();
			this.cboxClassName = new System.Windows.Forms.ComboBox();
			this.lblClassName = new System.Windows.Forms.Label();
			this.lblLessonName = new System.Windows.Forms.Label();
			this.cboxLessonName = new System.Windows.Forms.ComboBox();
			this.btnDeleteAll = new MyCustomButton.MyCustomButton();
			this.btnApply = new MyCustomButton.MyCustomButton();
			this.btnRepeatForAll = new MyCustomButton.MyCustomButton();
			this.gboxDisplay = new System.Windows.Forms.GroupBox();
			this.gboxRepeatedMark = new System.Windows.Forms.GroupBox();
			this.numRepeatMark = new System.Windows.Forms.NumericUpDown();
			this.lblRepeatedMark = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
			this.gboxDisplay.SuspendLayout();
			this.gboxRepeatedMark.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numRepeatMark)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMarks
			// 
			this.dgvMarks.AllowUserToAddRows = false;
			this.dgvMarks.AllowUserToDeleteRows = false;
			this.dgvMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvMarks.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Firstname,
            this.Lastname,
            this.Mark,
            this.Status});
			this.dgvMarks.Location = new System.Drawing.Point(17, 29);
			this.dgvMarks.MultiSelect = false;
			this.dgvMarks.Name = "dgvMarks";
			this.dgvMarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvMarks.RowHeadersVisible = false;
			this.dgvMarks.RowHeadersWidth = 51;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dgvMarks.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvMarks.RowTemplate.Height = 29;
			this.dgvMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvMarks.Size = new System.Drawing.Size(756, 760);
			this.dgvMarks.TabIndex = 2;
			this.dgvMarks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMarks_CellEndEdit);
			// 
			// ID
			// 
			this.ID.HeaderText = "کد دانش‌آموز";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Firstname
			// 
			this.Firstname.HeaderText = "نام";
			this.Firstname.MinimumWidth = 6;
			this.Firstname.Name = "Firstname";
			this.Firstname.ReadOnly = true;
			// 
			// Lastname
			// 
			this.Lastname.HeaderText = "نام خانوادگی";
			this.Lastname.MinimumWidth = 6;
			this.Lastname.Name = "Lastname";
			this.Lastname.ReadOnly = true;
			// 
			// Mark
			// 
			this.Mark.HeaderText = "نمره";
			this.Mark.MinimumWidth = 6;
			this.Mark.Name = "Mark";
			// 
			// Status
			// 
			this.Status.HeaderText = "وضعیت";
			this.Status.MinimumWidth = 6;
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// lblGradeName
			// 
			this.lblGradeName.AutoSize = true;
			this.lblGradeName.BackColor = System.Drawing.Color.White;
			this.lblGradeName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblGradeName.Location = new System.Drawing.Point(327, 43);
			this.lblGradeName.Name = "lblGradeName";
			this.lblGradeName.Size = new System.Drawing.Size(34, 29);
			this.lblGradeName.TabIndex = 51;
			this.lblGradeName.Text = "پایه";
			// 
			// cboxGradeName
			// 
			this.cboxGradeName.BackColor = System.Drawing.Color.White;
			this.cboxGradeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxGradeName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxGradeName.FormattingEnabled = true;
			this.cboxGradeName.Location = new System.Drawing.Point(10, 72);
			this.cboxGradeName.Name = "cboxGradeName";
			this.cboxGradeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxGradeName.Size = new System.Drawing.Size(351, 37);
			this.cboxGradeName.TabIndex = 0;
			// 
			// cboxClassName
			// 
			this.cboxClassName.BackColor = System.Drawing.Color.White;
			this.cboxClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxClassName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxClassName.FormattingEnabled = true;
			this.cboxClassName.Location = new System.Drawing.Point(10, 156);
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
			this.lblClassName.Location = new System.Drawing.Point(313, 127);
			this.lblClassName.Name = "lblClassName";
			this.lblClassName.Size = new System.Drawing.Size(48, 29);
			this.lblClassName.TabIndex = 51;
			this.lblClassName.Text = "کلاس";
			// 
			// lblLessonName
			// 
			this.lblLessonName.AutoSize = true;
			this.lblLessonName.BackColor = System.Drawing.Color.White;
			this.lblLessonName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblLessonName.Location = new System.Drawing.Point(318, 212);
			this.lblLessonName.Name = "lblLessonName";
			this.lblLessonName.Size = new System.Drawing.Size(47, 29);
			this.lblLessonName.TabIndex = 53;
			this.lblLessonName.Text = "درس";
			// 
			// cboxLessonName
			// 
			this.cboxLessonName.BackColor = System.Drawing.Color.White;
			this.cboxLessonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxLessonName.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboxLessonName.FormattingEnabled = true;
			this.cboxLessonName.Location = new System.Drawing.Point(10, 241);
			this.cboxLessonName.Name = "cboxLessonName";
			this.cboxLessonName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cboxLessonName.Size = new System.Drawing.Size(351, 37);
			this.cboxLessonName.TabIndex = 3;
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
			this.btnDeleteAll.IconSize = 25;
			this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteAll.Location = new System.Drawing.Point(789, 688);
			this.btnDeleteAll.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnDeleteAll.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteAll.Size = new System.Drawing.Size(351, 43);
			this.btnDeleteAll.TabIndex = 0;
			this.btnDeleteAll.Text = "حذف تمام نمرات";
			this.btnDeleteAll.UseVisualStyleBackColor = false;
			this.btnDeleteAll.Click += new System.EventHandler(this.DeleteAllMarksButton_Click);
			// 
			// btnApply
			// 
			this.btnApply.AutoSize = true;
			this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnApply.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Add;
			this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApply.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnApply.ForeColor = System.Drawing.Color.White;
			this.btnApply.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
			this.btnApply.IconColor = System.Drawing.Color.White;
			this.btnApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnApply.IconSize = 30;
			this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnApply.Location = new System.Drawing.Point(789, 746);
			this.btnApply.MouseEnterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnApply.MouseLeaveForeColor = System.Drawing.Color.White;
			this.btnApply.Name = "btnApply";
			this.btnApply.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnApply.Size = new System.Drawing.Size(351, 43);
			this.btnApply.TabIndex = 1;
			this.btnApply.Text = "ثبت نمرات";
			this.btnApply.UseVisualStyleBackColor = false;
			this.btnApply.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// btnRepeatForAll
			// 
			this.btnRepeatForAll.AutoSize = true;
			this.btnRepeatForAll.BackColor = System.Drawing.Color.White;
			this.btnRepeatForAll.ButtonType = MyCustomButton.MyCustomButton.ButtonTypes.Edit;
			this.btnRepeatForAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnRepeatForAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRepeatForAll.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnRepeatForAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnRepeatForAll.IconChar = FontAwesome.Sharp.IconChar.Repeat;
			this.btnRepeatForAll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnRepeatForAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnRepeatForAll.IconSize = 25;
			this.btnRepeatForAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRepeatForAll.Location = new System.Drawing.Point(12, 67);
			this.btnRepeatForAll.MouseEnterForeColor = System.Drawing.Color.White;
			this.btnRepeatForAll.MouseLeaveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnRepeatForAll.Name = "btnRepeatForAll";
			this.btnRepeatForAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnRepeatForAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRepeatForAll.Size = new System.Drawing.Size(230, 41);
			this.btnRepeatForAll.TabIndex = 1;
			this.btnRepeatForAll.Text = "ثبت برای همه";
			this.btnRepeatForAll.UseVisualStyleBackColor = false;
			this.btnRepeatForAll.Click += new System.EventHandler(this.RepeatForAllButton_Click);
			// 
			// gboxDisplay
			// 
			this.gboxDisplay.Controls.Add(this.cboxGradeName);
			this.gboxDisplay.Controls.Add(this.lblGradeName);
			this.gboxDisplay.Controls.Add(this.lblClassName);
			this.gboxDisplay.Controls.Add(this.lblLessonName);
			this.gboxDisplay.Controls.Add(this.cboxLessonName);
			this.gboxDisplay.Controls.Add(this.cboxClassName);
			this.gboxDisplay.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxDisplay.Location = new System.Drawing.Point(779, 13);
			this.gboxDisplay.Name = "gboxDisplay";
			this.gboxDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxDisplay.Size = new System.Drawing.Size(370, 297);
			this.gboxDisplay.TabIndex = 56;
			this.gboxDisplay.TabStop = false;
			this.gboxDisplay.Text = "نمایش نمرات ";
			// 
			// gboxRepeatedMark
			// 
			this.gboxRepeatedMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gboxRepeatedMark.Controls.Add(this.numRepeatMark);
			this.gboxRepeatedMark.Controls.Add(this.lblRepeatedMark);
			this.gboxRepeatedMark.Controls.Add(this.btnRepeatForAll);
			this.gboxRepeatedMark.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gboxRepeatedMark.Location = new System.Drawing.Point(779, 316);
			this.gboxRepeatedMark.Name = "gboxRepeatedMark";
			this.gboxRepeatedMark.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gboxRepeatedMark.Size = new System.Drawing.Size(370, 124);
			this.gboxRepeatedMark.TabIndex = 57;
			this.gboxRepeatedMark.TabStop = false;
			this.gboxRepeatedMark.Text = "تکرار نمره ";
			// 
			// numRepeatMark
			// 
			this.numRepeatMark.BackColor = System.Drawing.Color.White;
			this.numRepeatMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numRepeatMark.DecimalPlaces = 2;
			this.numRepeatMark.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numRepeatMark.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
			this.numRepeatMark.Location = new System.Drawing.Point(248, 67);
			this.numRepeatMark.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numRepeatMark.Name = "numRepeatMark";
			this.numRepeatMark.Size = new System.Drawing.Size(113, 37);
			this.numRepeatMark.TabIndex = 58;
			this.numRepeatMark.Leave += new System.EventHandler(this.RepeatedMarkNumericUpDown_Leave);
			// 
			// lblRepeatedMark
			// 
			this.lblRepeatedMark.AutoSize = true;
			this.lblRepeatedMark.BackColor = System.Drawing.Color.White;
			this.lblRepeatedMark.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblRepeatedMark.Location = new System.Drawing.Point(324, 37);
			this.lblRepeatedMark.Name = "lblRepeatedMark";
			this.lblRepeatedMark.Size = new System.Drawing.Size(40, 29);
			this.lblRepeatedMark.TabIndex = 33;
			this.lblRepeatedMark.Text = "نمره";
			this.lblRepeatedMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UCMark
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gboxDisplay);
			this.Controls.Add(this.gboxRepeatedMark);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.dgvMarks);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "UCMark";
			this.Size = new System.Drawing.Size(1157, 807);
			this.Load += new System.EventHandler(this.UCMark_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
			this.gboxDisplay.ResumeLayout(false);
			this.gboxDisplay.PerformLayout();
			this.gboxRepeatedMark.ResumeLayout(false);
			this.gboxRepeatedMark.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numRepeatMark)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dgvMarks;
		private Label lblGradeName;
		private ComboBox cboxGradeName;
		private ComboBox cboxClassName;
		private Label lblClassName;
		private Label lblLessonName;
		private ComboBox cboxLessonName;
		private MyCustomButton.MyCustomButton btnDeleteAll;
		private MyCustomButton.MyCustomButton btnApply;
		private MyCustomButton.MyCustomButton btnRepeatForAll;
		private GroupBox gboxDisplay;
		private GroupBox gboxRepeatedMark;
		private Label lblRepeatedMark;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn Firstname;
		private DataGridViewTextBoxColumn Lastname;
		private DataGridViewTextBoxColumn Mark;
		private DataGridViewTextBoxColumn Status;
		private NumericUpDown numRepeatMark;
	}
}
