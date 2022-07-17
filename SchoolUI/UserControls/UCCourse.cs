using System.Globalization;
using SchoolClassLibrary.DataLayer;
using SchoolUI.Forms;
using SchoolClassLibrary.DataLayer.Entities;

namespace SchoolUI.UserControls
{
	public partial class UCCourse : UserControl
	{
		// Constructors
		public UCCourse()
		{
			InitializeComponent();

			context = new();
		}

		// Properties
		private readonly SchoolContext context;

		// Methods
		// Course UserControl
		private void UCCourse_Load(object sender, EventArgs e)
		{
			// Populating cboxYear
			PersianCalendar pc = new();
			int currentYear = pc.GetYear(DateTime.Now);

			// Example: 1402 - 1401 | Every year it automatically updates
			for (int i = 0; i <= currentYear - 1401; i++)
				cboxYear.Items.Add((currentYear + i).ToString() + " - " + (currentYear + i + 1).ToString());

			cboxMonth.SelectedIndex = 0;
			cboxYear.SelectedIndex = 0;

			UpdateCourseDGV();
		}

		// Add Button
		private void AddButton_Click(object sender, EventArgs e)
		{
			string newMonth = cboxMonth.SelectedItem.ToString();
			string newYear = cboxYear.SelectedItem.ToString();

			if (Operations.DoesEntityExists<Course>(context, course => course.Month == newMonth && course.Year == newYear, "دوره تکراری", "دوره‌ای با مشخصات وارد شده از قبل وجود دارد.\nلطفاً مشخصات جدید وارد نمائید."))
				return;

			Course newCourse = new() { Month = newMonth, Year = newYear, SchoolID = Program.CurrentUser.SchoolID };

			context.Courses.Add(newCourse);
			context.SaveChanges();

			UpdateCourseDGV();
		}

		// Edit Button
		private void EditButton_Click(object sender, EventArgs e)
		{
			string newMonth = cboxMonth.SelectedItem.ToString();
			string newYear = cboxYear.SelectedItem.ToString();
			int courseToEditId = Convert.ToInt32(dgvCourses.CurrentRow.Cells[0].Value);

			if (Operations.DoesEntityExists<Course>(context, course => course.Month == newMonth && course.Year == newYear && course.ID != courseToEditId, "دوره تکراری", "دوره‌ای با مشخصات وارد شده از قبل وجود دارد.\nلطفاً مشخصات جدید وارد نمائید."))
				return;

			var selectedCourse = context.Courses.Where(course => course.ID == courseToEditId).First();

			selectedCourse.Month = newMonth;
			selectedCourse.Year = newYear;

			context.SaveChanges();

			// If the edited course is the selected current course, update the current course
			if (selectedCourse.ID == Program.CurrentCourse.ID) 
				Program.CurrentCourse.Set(selectedCourse.ID, selectedCourse.Month, selectedCourse.Year);

			UpdateCourseDGV();
		}

		// Delete Button
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			int currentRowId = Convert.ToInt32(dgvCourses.CurrentRow.Cells[0].Value);

			Operations.DeleteEntity<Course>(context, currentRowId);

			// If the deleted course is the selected current course, replace the last added course with currently selected
			if (Program.CurrentCourse.ID == currentRowId)
				Program.CurrentCourse.SetLastCourseCurrent(context);

			UpdateCourseDGV();
		}

		// Delete All Button
		private void DeleteAllButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteAllEntities<Course>(context, (course) => course.SchoolID == Program.CurrentUser.SchoolID);

			Program.CurrentCourse.Set(0, string.Empty, string.Empty);

			UpdateCourseDGV();
		}

		// Change Course Button
		private void ChangeCourseButton_Click(object sender, EventArgs e)
		{
			Program.CurrentCourse.Set(
				Convert.ToInt32(dgvCourses.CurrentRow.Cells[0].Value),
				dgvCourses.CurrentRow.Cells[1].Value.ToString(),
				dgvCourses.CurrentRow.Cells[2].Value.ToString()
				);
		}

		// Course DataGridView
		private void DGVCourse_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Operations.ShowDGVInfoInTextBoxComboBox(dgvCourses, null, new Dictionary<int, ComboBox>() { { 1, cboxMonth }, { 2, cboxYear } } );
		}

		private void DGVCourse_UsedDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			Operations.IfEmptyDoThese(dgvCourses, new List<Control>() { btnDeleteAll, btnEdit, btnChangeCurrentCourse, btnDelete, btnSearch });
		}

		/// <summary>
		/// Updates the <i>dgvCourse</i> with courses of current school.
		/// </summary>
		private void UpdateCourseDGV()
		{
			dgvCourses.DataSource = context.Courses.Where(course => course.SchoolID == Program.CurrentUser.SchoolID).Select(
				course => new { course.ID, course.Month, course.Year }
				).ToList();

			dgvCourses.Columns[0].Visible = false;
			dgvCourses.Columns[1].HeaderText = "ماه";
			dgvCourses.Columns[2].HeaderText = "سال";

			DGVCourse_UsedDeletedRow(null, null);
		}
	}
}
