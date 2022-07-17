using SchoolClassLibrary.DataLayer;
using SchoolClassLibrary.DataLayer.Entities;
using System.ComponentModel;
using System.Data;
using SchoolUI.Forms;

namespace SchoolUI.UserControls
{
	public partial class UCMark : UserControl
	{
		private class DGVMarkInfo
		{
			public int ID { get; set; }
			public string Firstname { get; set; }
			public string Lastname { get; set; }
			public double? Value { get; set; }
			public string Status { get; set; }
		}

		// Constructors
		public UCMark()
		{
			InitializeComponent();

			context = new();
		}

		// Fields
		private readonly SchoolContext context;

		// Methods
		private void UCMark_Load(object sender, EventArgs e)
		{
			UpdateGradesComboBox();

			UpdateClassesComboBox();

			UpdateLessonsComboBox();

			UpdateDGVMarks();

			cboxGradeName.SelectedValueChanged += new EventHandler(GradesComboBox_SelectedValueChanged);
			cboxClassName.SelectedValueChanged += new EventHandler(ClassesComboBox_SelectedValueChanged);
			cboxLessonName.SelectedValueChanged += new EventHandler(LessonsComboBox_SelectedValueChanged);
		}

		private void ApplyButton_Click(object sender, EventArgs e)
		{
			List<Mark> marksToAdd = new();
			List<Mark> marksToEdit = new();

			for (int i = 0; i < dgvMarks.RowCount; i++)
			{
				Mark newMark = new()
				{
					StudentID = Convert.ToInt32(dgvMarks.Rows[i].Cells[0].Value),
					LessonID = Convert.ToInt32(cboxLessonName.SelectedValue),
					CourseID = Program.CurrentCourse.ID
				};

				object value = dgvMarks.Rows[i].Cells[3].Value;

				if (value == null)
					newMark.Value = null;
				else
				{
					if (double.TryParse(value.ToString(), out double o))
						newMark.Value = o;
					else
						newMark.Value = 100;
				}

				if (dgvMarks.Rows[i].Cells[4].Value.ToString() == "Add")
					marksToAdd.Add(newMark);
				else
					marksToEdit.Add(newMark);
			}

			context.Marks.AddRange(marksToAdd);

			foreach (var markToEdit in marksToEdit)
			{
				var mark = context.Marks.Find(markToEdit.StudentID, markToEdit.LessonID, markToEdit.CourseID);
				mark.Value = markToEdit.Value;
			}

			context.SaveChanges();

			using FormMessage formMessage = new()
			{
				Message = "تمام نمرات ثبت شد",
				Title = "ثبت شد",
				FormButtons = FormMessage.FormMessageButtonTypes.OK
			};

			formMessage.ShowDialog();
		}

		private void GradesComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateClassesComboBox();
		}

		private void ClassesComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateLessonsComboBox();
		}

		private void LessonsComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateDGVMarks();
		}

		private void RepeatForAllButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dgvMarks.RowCount; i++)
				dgvMarks.Rows[i].Cells[3].Value = numRepeatMark.Value;
		}

		private void DGVMarks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			string cellContent = dgvMarks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

			if (!double.TryParse(cellContent, out double i))
				dgvMarks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Empty;
			else
				if (!((i >= 0) && (i <= 20) && (i % 0.25 == 0)))
				dgvMarks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Empty;
		}

		private void RepeatedMarkNumericUpDown_Leave(object sender, EventArgs e)
		{
			if (Convert.ToDouble(numRepeatMark.Value) % 0.25 != 0)
				numRepeatMark.Value = Math.Floor(Convert.ToDecimal(numRepeatMark.Value));
		}

		private void DeleteAllMarksButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dgvMarks.RowCount; i++)
				dgvMarks.Rows[i].Cells[3].Value = string.Empty;
		}

		private void UpdateGradesComboBox()
		{
			Operations.Populate<Grade, ComboBox>(context, cboxGradeName, grade => grade.SchoolID == Program.CurrentUser.SchoolID);
		}

		private void UpdateClassesComboBox()
		{
			Operations.Populate<Class, ComboBox>(context, cboxClassName, tclass => tclass.GradeID == Convert.ToInt32(cboxGradeName.SelectedValue));
		}

		private void UpdateLessonsComboBox()
		{
			Operations.Populate<Lesson, ComboBox>(context, cboxLessonName, lesson => lesson.GradeID == Convert.ToInt32(cboxGradeName.SelectedValue));
		}

		private void UpdateDGVMarks()
		{
			if (!Program.CurrentCourse.IsSelected)
			{
				using FormMessage message = new()
				{
					Message = "لطفاً برای مشاهده نمرات دوره‌ای را انتخاب کنید.",
					FormButtons = FormMessage.FormMessageButtonTypes.OK,
					Title = "دوره‌ای انتخاب نشده است"
				};

				message.ShowDialog();

				return;
			}
				
			dgvMarks.Rows.Clear();

			var dgvMarkInfo = (from student in context.Students
							   where student.ClassID == Convert.ToInt32(cboxClassName.SelectedValue)
							   select new DGVMarkInfo()
							   {
								   ID = student.ID,
								   Firstname = student.Firstname,
								   Lastname = student.Lastname,
								   Value = student.Marks.Where(mark => mark.CourseID == Program.CurrentCourse.ID && mark.LessonID == Convert.ToInt32(cboxLessonName.SelectedValue)).Select(mark => mark.Value).SingleOrDefault()
							   }).ToList();

			foreach (var item in dgvMarkInfo)
			{
				item.Status = (item.Value == null) ? "Add" : "Edit";
				dgvMarks.Rows.Add(item.ID, item.Firstname, item.Lastname, item.Value, item.Status);
			}

			dgvMarks.Sort(dgvMarks.Columns[2], ListSortDirection.Ascending);
		}
	}
}
