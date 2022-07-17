using SchoolClassLibrary.DataLayer;
using System.Linq;

namespace SchoolUI.UserControls
{
	public partial class UCDashboard : UserControl
	{
		// Constructors
		public UCDashboard()
		{
			InitializeComponent();
		}

		// Properties
		private readonly SchoolContext context = new();

		// Methods
		private void UCDashboard_Load(object sender, EventArgs e)
		{
			lblSchoolName.Text = Program.CurrentUser.SchoolName;
			lblSection.Text = Program.CurrentUser.SchoolSection;

			lblGrade.Text = (from grade in context.Grades
							 where grade.SchoolID == Program.CurrentUser.SchoolID
							 select grade.ID).Count().ToString();

			lblClass.Text = (from tclass in context.Classes
							 where tclass.Grade.SchoolID == Program.CurrentUser.SchoolID
							 select tclass.ID).Count().ToString();

			lblCourse.Text = (from course in context.Courses
							  where course.SchoolID == Program.CurrentUser.SchoolID
							  select course.ID).Count().ToString();

			lblStudent.Text = (from student in context.Students
							   where student.Class.Grade.SchoolID == Program.CurrentUser.SchoolID
							   select student.ID).Count().ToString();

			lblTeacher.Text = (from teacher in context.Teachers
							   where teacher.SchoolID == Program.CurrentUser.SchoolID
							   select teacher.ID).Count().ToString();
		}
	}
}
