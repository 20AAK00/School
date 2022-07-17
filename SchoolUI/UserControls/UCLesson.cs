using SchoolClassLibrary.DataLayer;
using SchoolClassLibrary.DataLayer.Entities;
using SchoolUI.Forms;

namespace SchoolUI.UserControls
{
	public partial class UCLesson : UserControl
	{
		// Constructors
		public UCLesson()
		{
			InitializeComponent();

			Operations.SelectAllOnTextBox(txtName, txtSearch);

			context = new();
		}

		// Fields
		private readonly SchoolContext context;

		// Methods
		public void UCLesson_Load(object sender, EventArgs e)
		{
			Operations.Populate<Grade, ComboBox>(context, cboxGrade, grade => grade.SchoolID == Program.CurrentUser.SchoolID);

			Operations.Populate<Teacher, ComboBox>(context, cboxTeachers, teacher => teacher.SchoolID == Program.CurrentUser.SchoolID);

			GradeComboBox_SelectedValueChanged(null, null);

			cboxGrade.SelectedValueChanged += new EventHandler(GradeComboBox_SelectedValueChanged);
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtName))
				return;

			for (int i = 0; i < dgvLesson.RowCount; i++)
				if (txtName.Text == dgvLesson.Rows[i].Cells[1].Value.ToString())
				{
					using FormMessage message = new()
					{
						Message = "درسی با این نام از قبل وجود دارد!",
						FormButtons = FormMessage.FormMessageButtonTypes.OK
					};

					message.ShowDialog();
					return;
				}

			Lesson newLesson = new()
			{
				Name = txtName.Text,
				NumberOfUnits = Convert.ToInt32(numNumberOfUnits.Value),
				TeacherID = Convert.ToInt32(cboxTeachers.SelectedValue),
			};

			newLesson.GradeID = Convert.ToInt32(cboxGrade.SelectedValue);

			context.Lessons.Add(newLesson);

			context.SaveChanges();

			UpdateDGVLessons();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtName))
				return;

			for (int i = 0; i < dgvLesson.RowCount; i++)
				if (txtName.Text == dgvLesson.Rows[i].Cells[1].Value.ToString())
				{
					using FormMessage message = new()
					{
						Message = "درسی با این نام از قبل وجود دارد!",
						FormButtons = FormMessage.FormMessageButtonTypes.OK
					};

					message.ShowDialog();
					return;
				}

			var lessonToEdit = context.Lessons.Find(Convert.ToInt32(dgvLesson.CurrentRow.Cells[0].Value));

			lessonToEdit.Name = txtName.Text;
			lessonToEdit.NumberOfUnits = Convert.ToInt32(numNumberOfUnits.Value);
			lessonToEdit.TeacherID = Convert.ToInt32(cboxTeachers.SelectedValue);

			lessonToEdit.GradeID = Convert.ToInt32(cboxGrade.SelectedValue);

			context.SaveChanges();

			UpdateDGVLessons();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteEntity<Lesson>(context, Convert.ToInt32(dgvLesson.CurrentRow.Cells[0].Value));

			UpdateDGVLessons();
		}

		private void DeleteAllButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteAllEntities<Lesson>(context, lesson => lesson.GradeID == Convert.ToInt32(cboxGrade.SelectedValue));

			UpdateDGVLessons();
		}

		private void LessonDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			txtName.Text = dgvLesson.CurrentRow.Cells[1].Value.ToString();
			numNumberOfUnits.Value = Convert.ToDecimal(dgvLesson.CurrentRow.Cells[2].Value);
			cboxTeachers.SelectedValue = Convert.ToInt32(dgvLesson.CurrentRow.Cells[3].Value);
		}

		private void GradeComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateDGVLessons();
		}

		// Utility
		private void UpdateDGVLessons()
		{
			dgvLesson.DataSource = (from lesson in context.Lessons
									where lesson.GradeID == Convert.ToInt32(cboxGrade.SelectedValue)
									select new
									{
										lesson.ID,
										lesson.Name,
										lesson.NumberOfUnits,
										lesson.TeacherID,
										TeachrName = lesson.Teacher.Firstname + " " + lesson.Teacher.Lastname
									}).ToList();

			dgvLesson.Columns[0].Visible = false;
			dgvLesson.Columns[1].HeaderText = "نام درس";
			dgvLesson.Columns[2].HeaderText = "تعداد واحد";
			dgvLesson.Columns[3].Visible = false;
			dgvLesson.Columns[4].HeaderText = "نام دبیر";

			LessonDGV_UserDeletedRow(null, null);
		}

		private void LessonDGV_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			Operations.IfEmptyDoThese(dgvLesson, new List<Control>() { btnDelete, btnDeleteAll, btnEdit, btnSearch }, txtName);
		}
	}
}
