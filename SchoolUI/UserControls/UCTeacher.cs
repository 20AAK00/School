using SchoolClassLibrary.DataLayer;
using SchoolClassLibrary.DataLayer.Entities;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace SchoolUI.UserControls
{
	public partial class UCTeacher : UserControl
	{
		// Constructors
		public UCTeacher()
		{
			InitializeComponent();

			context = new();

			Operations.SelectAllOnTextBox(txtFirstname, txtLastname, txtSearch);
		}

		// Fields
		private readonly SchoolContext context;

		// Methods
		// Teacher UserControl
		private void UCTeacher_Load(object sender, EventArgs e)
		{
			UpdateTeachersDGV();
		}

		// Add Button
		private void AddButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtFirstname, txtLastname))
				return;

			Teacher newTeacher = new()
			{
				Firstname = txtFirstname.Text,
				Lastname = txtLastname.Text,
				SchoolID = Program.CurrentUser.SchoolID
			};

			context.Teachers.Add(newTeacher);

			context.SaveChanges();

			UpdateTeachersDGV();
		}

		// Edit Button
		private void EditButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtFirstname, txtLastname))
				return;

			var teacherToEdit = context.Teachers.Find(Convert.ToInt32(dgvTeachers.CurrentRow.Cells[0].Value));

			teacherToEdit.Firstname = txtFirstname.Text;
			teacherToEdit.Lastname = txtLastname.Text;

			context.SaveChanges();

			UpdateTeachersDGV();
		}

		// Delete Button
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteEntity<Teacher>(context, Convert.ToInt32(dgvTeachers.CurrentRow.Cells[0].Value));

			UpdateTeachersDGV();
		}

		// Delete All Button
		private void DeleteAllButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteAllEntities<Teacher>(context, (teacher) => teacher.SchoolID == Program.CurrentUser.SchoolID);

			UpdateTeachersDGV();
		}

		// Teachers DataGridView
		private void DGVTeachers_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Operations.ShowDGVInfoInTextBoxComboBox(
				dgvTeachers,
				new Dictionary<int, TextBox>
				{
					{ 1, txtFirstname },
					{ 2, txtLastname }
				},
				null
				);
		}

		private void DGVTeachers_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			Operations.IfEmptyDoThese(dgvTeachers, new List<Control> { btnDelete, btnDeleteAll, btnEdit, btnSearch });
		}

		private void UpdateTeachersDGV()
		{
			var teachers = (from teacher in context.Teachers
							where teacher.SchoolID == Program.CurrentUser.SchoolID
							select new
							{
								teacher.ID,
								teacher.Firstname,
								teacher.Lastname
							}).ToList();

			dgvTeachers.DataSource = teachers;

			dgvTeachers.Columns[0].Visible = false;
			dgvTeachers.Columns[1].HeaderText = "نام";
			dgvTeachers.Columns[2].HeaderText = "نام خانوادگی";

			DGVTeachers_UserDeletedRow(null, null);
		}
	}
}
