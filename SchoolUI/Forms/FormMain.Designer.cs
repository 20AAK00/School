using SchoolUI.UserControls.Reusables;
using FontAwesome.Sharp;

namespace SchoolUI.Forms
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ucTitleBar = new SchoolUI.UserControls.Reusables.UCTitleBar();
			this.pnlWholeMenu = new System.Windows.Forms.Panel();
			this.pnlDatabase = new System.Windows.Forms.Panel();
			this.btnRestore = new FontAwesome.Sharp.IconButton();
			this.btnBackup = new FontAwesome.Sharp.IconButton();
			this.btnDatabase = new FontAwesome.Sharp.IconButton();
			this.pnlRankDatabaseSeparator = new System.Windows.Forms.Panel();
			this.btnRank = new FontAwesome.Sharp.IconButton();
			this.pnlReportRankSeparator = new System.Windows.Forms.Panel();
			this.btnReport = new FontAwesome.Sharp.IconButton();
			this.pnlOperations = new System.Windows.Forms.Panel();
			this.btnMarks = new FontAwesome.Sharp.IconButton();
			this.btnTeachers = new FontAwesome.Sharp.IconButton();
			this.btnStudents = new FontAwesome.Sharp.IconButton();
			this.btnLessons = new FontAwesome.Sharp.IconButton();
			this.btnGradeClassMajor = new FontAwesome.Sharp.IconButton();
			this.btnCourses = new FontAwesome.Sharp.IconButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnOperations = new FontAwesome.Sharp.IconButton();
			this.btnGoToDashboard = new FontAwesome.Sharp.IconButton();
			this.lblCurrentCourse = new System.Windows.Forms.Label();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.pnlTopBar = new System.Windows.Forms.Panel();
			this.btnUserAccount = new FontAwesome.Sharp.IconButton();
			this.lblHeader = new System.Windows.Forms.Label();
			this.pnlHeaderSeparator = new System.Windows.Forms.Panel();
			this.pnlContent = new System.Windows.Forms.Panel();
			this.pnlWholeMenu.SuspendLayout();
			this.pnlDatabase.SuspendLayout();
			this.pnlOperations.SuspendLayout();
			this.pnlTopBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ucTitleBar
			// 
			this.ucTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.ucTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.ucTitleBar.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ucTitleBar.Location = new System.Drawing.Point(0, 0);
			this.ucTitleBar.Name = "ucTitleBar";
			this.ucTitleBar.Size = new System.Drawing.Size(1400, 40);
			this.ucTitleBar.TabIndex = 0;
			// 
			// pnlWholeMenu
			// 
			this.pnlWholeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlWholeMenu.Controls.Add(this.pnlDatabase);
			this.pnlWholeMenu.Controls.Add(this.btnDatabase);
			this.pnlWholeMenu.Controls.Add(this.pnlRankDatabaseSeparator);
			this.pnlWholeMenu.Controls.Add(this.btnRank);
			this.pnlWholeMenu.Controls.Add(this.pnlReportRankSeparator);
			this.pnlWholeMenu.Controls.Add(this.btnReport);
			this.pnlWholeMenu.Controls.Add(this.pnlOperations);
			this.pnlWholeMenu.Controls.Add(this.panel1);
			this.pnlWholeMenu.Controls.Add(this.btnOperations);
			this.pnlWholeMenu.Controls.Add(this.btnGoToDashboard);
			this.pnlWholeMenu.Controls.Add(this.lblCurrentCourse);
			this.pnlWholeMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlWholeMenu.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlWholeMenu.Location = new System.Drawing.Point(1160, 40);
			this.pnlWholeMenu.Name = "pnlWholeMenu";
			this.pnlWholeMenu.Size = new System.Drawing.Size(240, 860);
			this.pnlWholeMenu.TabIndex = 1;
			// 
			// pnlDatabase
			// 
			this.pnlDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlDatabase.Controls.Add(this.btnRestore);
			this.pnlDatabase.Controls.Add(this.btnBackup);
			this.pnlDatabase.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDatabase.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlDatabase.Location = new System.Drawing.Point(0, 561);
			this.pnlDatabase.Name = "pnlDatabase";
			this.pnlDatabase.Size = new System.Drawing.Size(240, 102);
			this.pnlDatabase.TabIndex = 43;
			this.pnlDatabase.Visible = false;
			// 
			// btnRestore
			// 
			this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnRestore.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRestore.FlatAppearance.BorderSize = 0;
			this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestore.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnRestore.ForeColor = System.Drawing.Color.White;
			this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
			this.btnRestore.IconColor = System.Drawing.Color.White;
			this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnRestore.IconSize = 25;
			this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRestore.Location = new System.Drawing.Point(0, 50);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRestore.Size = new System.Drawing.Size(240, 50);
			this.btnRestore.TabIndex = 13;
			this.btnRestore.Tag = "بارگذاری فایل پشتیبان";
			this.btnRestore.Text = "بارگذاری فایل پشتیبان";
			this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRestore.UseVisualStyleBackColor = false;
			// 
			// btnBackup
			// 
			this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBackup.FlatAppearance.BorderSize = 0;
			this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackup.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnBackup.ForeColor = System.Drawing.Color.White;
			this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.Rotate;
			this.btnBackup.IconColor = System.Drawing.Color.White;
			this.btnBackup.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnBackup.IconSize = 25;
			this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackup.Location = new System.Drawing.Point(0, 0);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnBackup.Size = new System.Drawing.Size(240, 50);
			this.btnBackup.TabIndex = 12;
			this.btnBackup.Tag = "تهیه نسخه پشتیبان";
			this.btnBackup.Text = "تهیه نسخه پشتیبان";
			this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBackup.UseVisualStyleBackColor = false;
			// 
			// btnDatabase
			// 
			this.btnDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnDatabase.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDatabase.FlatAppearance.BorderSize = 0;
			this.btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDatabase.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDatabase.ForeColor = System.Drawing.Color.White;
			this.btnDatabase.IconChar = FontAwesome.Sharp.IconChar.Database;
			this.btnDatabase.IconColor = System.Drawing.Color.White;
			this.btnDatabase.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnDatabase.IconSize = 30;
			this.btnDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDatabase.Location = new System.Drawing.Point(0, 511);
			this.btnDatabase.Name = "btnDatabase";
			this.btnDatabase.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.btnDatabase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDatabase.Size = new System.Drawing.Size(240, 50);
			this.btnDatabase.TabIndex = 42;
			this.btnDatabase.Tag = "پایگاه داده‌ها";
			this.btnDatabase.Text = "پایگاه داده‌ها";
			this.btnDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDatabase.UseVisualStyleBackColor = false;
			this.btnDatabase.Click += new System.EventHandler(this.DatabaseButton_Click);
			// 
			// pnlRankDatabaseSeparator
			// 
			this.pnlRankDatabaseSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlRankDatabaseSeparator.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRankDatabaseSeparator.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlRankDatabaseSeparator.Location = new System.Drawing.Point(0, 508);
			this.pnlRankDatabaseSeparator.Name = "pnlRankDatabaseSeparator";
			this.pnlRankDatabaseSeparator.Size = new System.Drawing.Size(240, 3);
			this.pnlRankDatabaseSeparator.TabIndex = 41;
			// 
			// btnRank
			// 
			this.btnRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnRank.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRank.FlatAppearance.BorderSize = 0;
			this.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRank.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnRank.ForeColor = System.Drawing.Color.White;
			this.btnRank.IconChar = FontAwesome.Sharp.IconChar.ArrowDown19;
			this.btnRank.IconColor = System.Drawing.Color.White;
			this.btnRank.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnRank.IconSize = 30;
			this.btnRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRank.Location = new System.Drawing.Point(0, 458);
			this.btnRank.Name = "btnRank";
			this.btnRank.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.btnRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRank.Size = new System.Drawing.Size(240, 50);
			this.btnRank.TabIndex = 40;
			this.btnRank.Tag = "رتبه‌بندی";
			this.btnRank.Text = "رتبه‌بندی";
			this.btnRank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRank.UseVisualStyleBackColor = false;
			// 
			// pnlReportRankSeparator
			// 
			this.pnlReportRankSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlReportRankSeparator.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlReportRankSeparator.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlReportRankSeparator.Location = new System.Drawing.Point(0, 455);
			this.pnlReportRankSeparator.Name = "pnlReportRankSeparator";
			this.pnlReportRankSeparator.Size = new System.Drawing.Size(240, 3);
			this.pnlReportRankSeparator.TabIndex = 39;
			// 
			// btnReport
			// 
			this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReport.FlatAppearance.BorderSize = 0;
			this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReport.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnReport.ForeColor = System.Drawing.Color.White;
			this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
			this.btnReport.IconColor = System.Drawing.Color.White;
			this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnReport.IconSize = 30;
			this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReport.Location = new System.Drawing.Point(0, 405);
			this.btnReport.Name = "btnReport";
			this.btnReport.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnReport.Size = new System.Drawing.Size(240, 50);
			this.btnReport.TabIndex = 38;
			this.btnReport.Tag = "کارنامه";
			this.btnReport.Text = "کارنامه";
			this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReport.UseVisualStyleBackColor = false;
			this.btnReport.Click += new System.EventHandler(this.ReportButton_Click);
			// 
			// pnlOperations
			// 
			this.pnlOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlOperations.Controls.Add(this.btnMarks);
			this.pnlOperations.Controls.Add(this.btnTeachers);
			this.pnlOperations.Controls.Add(this.btnStudents);
			this.pnlOperations.Controls.Add(this.btnLessons);
			this.pnlOperations.Controls.Add(this.btnGradeClassMajor);
			this.pnlOperations.Controls.Add(this.btnCourses);
			this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlOperations.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlOperations.Location = new System.Drawing.Point(0, 103);
			this.pnlOperations.Name = "pnlOperations";
			this.pnlOperations.Size = new System.Drawing.Size(240, 302);
			this.pnlOperations.TabIndex = 37;
			this.pnlOperations.Visible = false;
			// 
			// btnMarks
			// 
			this.btnMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnMarks.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMarks.FlatAppearance.BorderSize = 0;
			this.btnMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMarks.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnMarks.ForeColor = System.Drawing.Color.White;
			this.btnMarks.IconChar = FontAwesome.Sharp.IconChar.FileContract;
			this.btnMarks.IconColor = System.Drawing.Color.White;
			this.btnMarks.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnMarks.IconSize = 25;
			this.btnMarks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMarks.Location = new System.Drawing.Point(0, 250);
			this.btnMarks.Name = "btnMarks";
			this.btnMarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnMarks.Size = new System.Drawing.Size(240, 50);
			this.btnMarks.TabIndex = 22;
			this.btnMarks.Tag = "نمرات";
			this.btnMarks.Text = "نمرات";
			this.btnMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMarks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMarks.UseVisualStyleBackColor = false;
			this.btnMarks.Click += new System.EventHandler(this.MarksButton_Click);
			// 
			// btnTeachers
			// 
			this.btnTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTeachers.FlatAppearance.BorderSize = 0;
			this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTeachers.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnTeachers.ForeColor = System.Drawing.Color.White;
			this.btnTeachers.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
			this.btnTeachers.IconColor = System.Drawing.Color.White;
			this.btnTeachers.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnTeachers.IconSize = 25;
			this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTeachers.Location = new System.Drawing.Point(0, 200);
			this.btnTeachers.Name = "btnTeachers";
			this.btnTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnTeachers.Size = new System.Drawing.Size(240, 50);
			this.btnTeachers.TabIndex = 21;
			this.btnTeachers.Tag = "دبیران";
			this.btnTeachers.Text = "دبیران";
			this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTeachers.UseVisualStyleBackColor = false;
			this.btnTeachers.Click += new System.EventHandler(this.TeachersButton_Click);
			// 
			// btnStudents
			// 
			this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnStudents.FlatAppearance.BorderSize = 0;
			this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStudents.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnStudents.ForeColor = System.Drawing.Color.White;
			this.btnStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
			this.btnStudents.IconColor = System.Drawing.Color.White;
			this.btnStudents.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnStudents.IconSize = 25;
			this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStudents.Location = new System.Drawing.Point(0, 150);
			this.btnStudents.Name = "btnStudents";
			this.btnStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnStudents.Size = new System.Drawing.Size(240, 50);
			this.btnStudents.TabIndex = 20;
			this.btnStudents.Tag = "دانش‌آموزان";
			this.btnStudents.Text = "دانش‌آموزان";
			this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnStudents.UseVisualStyleBackColor = false;
			this.btnStudents.Click += new System.EventHandler(this.StudentsButton_Click);
			// 
			// btnLessons
			// 
			this.btnLessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnLessons.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLessons.FlatAppearance.BorderSize = 0;
			this.btnLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLessons.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnLessons.ForeColor = System.Drawing.Color.White;
			this.btnLessons.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
			this.btnLessons.IconColor = System.Drawing.Color.White;
			this.btnLessons.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnLessons.IconSize = 25;
			this.btnLessons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLessons.Location = new System.Drawing.Point(0, 100);
			this.btnLessons.Name = "btnLessons";
			this.btnLessons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnLessons.Size = new System.Drawing.Size(240, 50);
			this.btnLessons.TabIndex = 14;
			this.btnLessons.Tag = "دروس";
			this.btnLessons.Text = "دروس";
			this.btnLessons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLessons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLessons.UseVisualStyleBackColor = false;
			this.btnLessons.Click += new System.EventHandler(this.LessonsButton_Click);
			// 
			// btnGradeClassMajor
			// 
			this.btnGradeClassMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnGradeClassMajor.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnGradeClassMajor.FlatAppearance.BorderSize = 0;
			this.btnGradeClassMajor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGradeClassMajor.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnGradeClassMajor.ForeColor = System.Drawing.Color.White;
			this.btnGradeClassMajor.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
			this.btnGradeClassMajor.IconColor = System.Drawing.Color.White;
			this.btnGradeClassMajor.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnGradeClassMajor.IconSize = 25;
			this.btnGradeClassMajor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGradeClassMajor.Location = new System.Drawing.Point(0, 50);
			this.btnGradeClassMajor.Name = "btnGradeClassMajor";
			this.btnGradeClassMajor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnGradeClassMajor.Size = new System.Drawing.Size(240, 50);
			this.btnGradeClassMajor.TabIndex = 13;
			this.btnGradeClassMajor.Tag = "پایه و کلاس";
			this.btnGradeClassMajor.Text = "پایه و کلاس";
			this.btnGradeClassMajor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGradeClassMajor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGradeClassMajor.UseVisualStyleBackColor = false;
			this.btnGradeClassMajor.Click += new System.EventHandler(this.GradeClassMajorButton_Click);
			// 
			// btnCourses
			// 
			this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCourses.FlatAppearance.BorderSize = 0;
			this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCourses.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCourses.ForeColor = System.Drawing.Color.White;
			this.btnCourses.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
			this.btnCourses.IconColor = System.Drawing.Color.White;
			this.btnCourses.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnCourses.IconSize = 25;
			this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCourses.Location = new System.Drawing.Point(0, 0);
			this.btnCourses.Name = "btnCourses";
			this.btnCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCourses.Size = new System.Drawing.Size(240, 50);
			this.btnCourses.TabIndex = 12;
			this.btnCourses.Tag = "دوره‌ها";
			this.btnCourses.Text = "دوره‌ها";
			this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCourses.UseVisualStyleBackColor = false;
			this.btnCourses.Click += new System.EventHandler(this.CoursesButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 3);
			this.panel1.TabIndex = 28;
			// 
			// btnOperations
			// 
			this.btnOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.btnOperations.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnOperations.FlatAppearance.BorderSize = 0;
			this.btnOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOperations.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnOperations.ForeColor = System.Drawing.Color.White;
			this.btnOperations.IconChar = FontAwesome.Sharp.IconChar.Cogs;
			this.btnOperations.IconColor = System.Drawing.Color.White;
			this.btnOperations.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnOperations.IconSize = 30;
			this.btnOperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOperations.Location = new System.Drawing.Point(0, 50);
			this.btnOperations.Name = "btnOperations";
			this.btnOperations.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.btnOperations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnOperations.Size = new System.Drawing.Size(240, 50);
			this.btnOperations.TabIndex = 12;
			this.btnOperations.Text = "عملیات";
			this.btnOperations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOperations.UseVisualStyleBackColor = false;
			this.btnOperations.Click += new System.EventHandler(this.OperationsButton_Click);
			// 
			// btnGoToDashboard
			// 
			this.btnGoToDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnGoToDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnGoToDashboard.FlatAppearance.BorderSize = 0;
			this.btnGoToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGoToDashboard.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnGoToDashboard.ForeColor = System.Drawing.Color.White;
			this.btnGoToDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart;
			this.btnGoToDashboard.IconColor = System.Drawing.Color.White;
			this.btnGoToDashboard.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnGoToDashboard.IconSize = 30;
			this.btnGoToDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGoToDashboard.Location = new System.Drawing.Point(0, 0);
			this.btnGoToDashboard.Name = "btnGoToDashboard";
			this.btnGoToDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.btnGoToDashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnGoToDashboard.Size = new System.Drawing.Size(240, 50);
			this.btnGoToDashboard.TabIndex = 11;
			this.btnGoToDashboard.Tag = "برو به داشبورد";
			this.btnGoToDashboard.Text = "برو به داشبورد";
			this.btnGoToDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGoToDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGoToDashboard.UseVisualStyleBackColor = false;
			this.btnGoToDashboard.Click += new System.EventHandler(this.GoToDashboardButton_Click);
			// 
			// lblCurrentCourse
			// 
			this.lblCurrentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblCurrentCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblCurrentCourse.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCurrentCourse.ForeColor = System.Drawing.Color.White;
			this.lblCurrentCourse.Location = new System.Drawing.Point(0, 810);
			this.lblCurrentCourse.Name = "lblCurrentCourse";
			this.lblCurrentCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentCourse.Size = new System.Drawing.Size(240, 50);
			this.lblCurrentCourse.TabIndex = 10;
			this.lblCurrentCourse.Text = "دوره کنونی";
			this.lblCurrentCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlBottom.Location = new System.Drawing.Point(0, 897);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(1160, 3);
			this.pnlBottom.TabIndex = 3;
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlLeft.Location = new System.Drawing.Point(0, 40);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(3, 857);
			this.pnlLeft.TabIndex = 4;
			// 
			// pnlTopBar
			// 
			this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlTopBar.Controls.Add(this.btnUserAccount);
			this.pnlTopBar.Controls.Add(this.lblHeader);
			this.pnlTopBar.Controls.Add(this.pnlHeaderSeparator);
			this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTopBar.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlTopBar.Location = new System.Drawing.Point(3, 40);
			this.pnlTopBar.Name = "pnlTopBar";
			this.pnlTopBar.Size = new System.Drawing.Size(1157, 50);
			this.pnlTopBar.TabIndex = 6;
			// 
			// btnUserAccount
			// 
			this.btnUserAccount.AutoSize = true;
			this.btnUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnUserAccount.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnUserAccount.FlatAppearance.BorderSize = 0;
			this.btnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUserAccount.Font = new System.Drawing.Font("P - IRAN Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnUserAccount.ForeColor = System.Drawing.Color.White;
			this.btnUserAccount.IconChar = FontAwesome.Sharp.IconChar.User;
			this.btnUserAccount.IconColor = System.Drawing.Color.White;
			this.btnUserAccount.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.btnUserAccount.IconSize = 25;
			this.btnUserAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUserAccount.Location = new System.Drawing.Point(0, 0);
			this.btnUserAccount.Name = "btnUserAccount";
			this.btnUserAccount.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.btnUserAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnUserAccount.Size = new System.Drawing.Size(169, 50);
			this.btnUserAccount.TabIndex = 13;
			this.btnUserAccount.Tag = "نام کاربر (سمت)";
			this.btnUserAccount.Text = "نام کاربر (سمت)";
			this.btnUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUserAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnUserAccount.UseVisualStyleBackColor = false;
			// 
			// lblHeader
			// 
			this.lblHeader.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblHeader.Font = new System.Drawing.Font("P - IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblHeader.ForeColor = System.Drawing.Color.White;
			this.lblHeader.Location = new System.Drawing.Point(672, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.lblHeader.Size = new System.Drawing.Size(480, 50);
			this.lblHeader.TabIndex = 4;
			this.lblHeader.Text = "هدر";
			this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlHeaderSeparator
			// 
			this.pnlHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.pnlHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlHeaderSeparator.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlHeaderSeparator.Location = new System.Drawing.Point(1152, 0);
			this.pnlHeaderSeparator.Name = "pnlHeaderSeparator";
			this.pnlHeaderSeparator.Size = new System.Drawing.Size(5, 50);
			this.pnlHeaderSeparator.TabIndex = 3;
			// 
			// pnlContent
			// 
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pnlContent.Location = new System.Drawing.Point(3, 90);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(1157, 807);
			this.pnlContent.TabIndex = 7;
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1400, 900);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.pnlTopBar);
			this.Controls.Add(this.pnlLeft);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlWholeMenu);
			this.Controls.Add(this.ucTitleBar);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.pnlWholeMenu.ResumeLayout(false);
			this.pnlDatabase.ResumeLayout(false);
			this.pnlOperations.ResumeLayout(false);
			this.pnlTopBar.ResumeLayout(false);
			this.pnlTopBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private UCTitleBar ucTitleBar;
		private Panel pnlWholeMenu;
		private Label lblCurrentCourse;
		private Panel pnlBottom;
		private Panel pnlLeft;
		private IconButton btnGoToDashboard;
		private IconButton btnOperations;
		private Panel panel1;
		private Panel pnlDatabase;
		private IconButton btnRestore;
		private IconButton btnBackup;
		private IconButton btnDatabase;
		private Panel pnlRankDatabaseSeparator;
		private IconButton btnRank;
		private Panel pnlReportRankSeparator;
		private IconButton btnReport;
		private Panel pnlOperations;
		private IconButton btnGradeClassMajor;
		private IconButton btnCourses;
		private Panel pnlTopBar;
		private IconButton btnUserAccount;
		private Label lblHeader;
		private Panel pnlHeaderSeparator;
		private Panel pnlContent;
		private IconButton btnMarks;
		private IconButton btnTeachers;
		private IconButton btnStudents;
		private IconButton btnLessons;
	}
}