using SchoolUI.UserControls;
using SchoolClassLibrary.DataLayer;
using SchoolClassLibrary.DataLayer.Entities;

namespace SchoolUI.Forms
{
	public partial class FormMain : Form
	{
		// Constructors
		public FormMain()
		{
			InitializeComponent();

			Program.CurrentCourse.Changed += new Action(ShowCurrentCourse);
		}

		// Properties
		// ActivePanel is for the currently showing menu panel.
		private Panel ActiveMenuPanel = null;

		// Methods
		// FormMain
		private void FormMain_Load(object sender, EventArgs e)
		{
			using FormLogin formLogin = new();

			if (formLogin.ShowDialog() == DialogResult.Cancel)
				Environment.Exit(0);

			Program.CurrentCourse.SetLastCourseCurrent(new SchoolContext());

			ucTitleBar.Title = "سیستم دستیار مدرسه | " + Program.CurrentUser.SchoolName;
			btnUserAccount.Text = $"{ Program.CurrentUser.Fullname } ({ Program.CurrentUser.Role })";

			ShowCurrentCourse();

			ShowUserControl(new UCDashboard(), btnGoToDashboard);
		}

		// GoToDashboard Button
		private void GoToDashboardButton_Click(object sender, EventArgs e)
		{
			ShowUserControl(new UCDashboard(), sender);
		}

		// Operations Button
		private void OperationsButton_Click(object sender, EventArgs e)
		{
			ShowPanel(pnlOperations);
		}

		// Courses Button
		private void CoursesButton_Click(object sender, EventArgs e)
		{
			ShowUserControl(new UCCourse(), sender);
		}

		// GradeClassMajor Button
		private void GradeClassMajorButton_Click(object sender, EventArgs e)
		{
			ShowUserControl(new UCGradeClassMajor(), sender);
		}

		// Lessons Button
		private void LessonsButton_Click(object sender, EventArgs e)
		{
			ShowUserControl(new UCLesson(), sender);
		}

		// Students Button
		private void StudentsButton_Click(object sender, EventArgs e)
		{
			ShowUserControl(new UCStudent(), sender);
		}

		// Teachers Button
		private void TeachersButton_Click(object sender, EventArgs e)
		{
			ShowUserControl(new UCTeacher(), sender);
		}

		// Marks Button
		private void MarksButton_Click(object sender, EventArgs e)
		{
			ShowUserControl(new UCMark(), sender);
		}

		// Report Button
		private void ReportButton_Click(object sender, EventArgs e)
		{
			if (!Program.CurrentCourse.IsSelected)
			{
				using FormMessage formMessage = new("دوره‌ای انتخاب نشده است", "لطفاً برای مشاهده کارنامه دوره مورد نظر را انتخاب کنید.", FormMessage.FormMessageButtonTypes.OK);
				
				formMessage.ShowDialog();

				return;
			}

			using FormReport formReport = new();
			formReport.ShowDialog();
		}

		// Database Button
		private void DatabaseButton_Click(object sender, EventArgs e)
		{
			ShowPanel(pnlDatabase);
		}

		// Utility Methods
		/// <summary>
		/// Shows or hides menu panels. If the <i>ActiveMenuPanel</i> has the same type as the <i>panelToShow</i>, the panel will be hidden.
		/// </summary>
		/// <param name="panelToShow">Panel to show or hide</param>
		private void ShowPanel(Panel panelToShow)
		{
			if (ActiveMenuPanel != null)
			{
				ActiveMenuPanel.Visible = false;

				if (ActiveMenuPanel == panelToShow)
				{
					ActiveMenuPanel = null;
					return;
				}
			}

			ActiveMenuPanel = panelToShow;
			ActiveMenuPanel.Visible = true;
		}

		/// <summary>
		/// Shows the <i>userControl</i> in the <i>pnlContent</i> of <i>FormMain</i>. If the currently showing user control has the same type as the <i>userControl</i>, this method does nothing. Otherwise, disposes the currently showing user control and adds the <i>userControl</i>.
		/// </summary>
		/// <param name="userControl">The new user control to show in pnlContent.</param>
		/// <param name="sender">Changes the lblHeader text with sender button's Tag propery.</param>
		private void ShowUserControl(UserControl userControl, object sender)
		{
			if (pnlContent.HasChildren)
			{
				if (pnlContent.Controls[0].GetType() == userControl.GetType())
					return;

				pnlContent.Controls[0].Dispose();
			}

			lblHeader.Text = ((Button)sender).Tag.ToString();

			pnlContent.Controls.Clear();
			pnlContent.Controls.Add(userControl);
		}

		public void ShowCurrentCourse()
		{
			if (Program.CurrentCourse.ID == 0)
			{
				lblCurrentCourse.Text = "دوره‌ای انتخاب نشده است";
				lblCurrentCourse.ForeColor = Color.FromArgb(238, 69, 64);
				return;
			}

			lblCurrentCourse.ForeColor = Color.White;
			lblCurrentCourse.Text = Program.CurrentCourse.Name;
		}
	}
}