using SchoolClassLibrary.DataLayer;
using System.Globalization;

namespace SchoolUI.Forms
{
	public partial class FormLogin : Form
	{
		// Constructors
		public FormLogin()
		{
			InitializeComponent();

			// FormLogin title assignment
			ucTitleBar.Title = "سیستم دستیار مدرسه | ورود به سیستم";

			// Copyright label assignment
			string copyrightMessage = "© کلیه حقوق این نرم‌افزار متعلق به علیرضا علیزاده کلانتری می‌باشد. | 1401";

			PersianCalendar pc = new();
			int currentYear = pc.GetYear(DateTime.Now);

			if (currentYear == 1401)
				lblCopyright.Text = copyrightMessage;
			else
				lblCopyright.Text = copyrightMessage + $" - { currentYear }";

			Operations.SelectAllOnTextBox(txtUsername, txtPassword);

			context = new();
		} // End of constructor

		// Properties
		private readonly SchoolContext context;

		// Methods
		// Login Button
		private void LoginButtom_Click(object sender, EventArgs e)
		{
			using FormMessage message = new() { FormButtons = FormMessage.FormMessageButtonTypes.OK };

			// If any of the textboxes is empty
			if (Operations.FindMakeEmptyTextBoxRed(txtUsername, txtPassword))
			{
				message.Title = "اطلاعات نامعتبر";
				message.Message = "لطفاً اطلاعات کامل و معتبر وارد کنید.";
				message.ShowDialog();

				return;
			}

			Cursor = Cursors.WaitCursor;

			try
			{
				// Find the staff with the given Username and Password
				var validatedStaff = (from staff in context.Staffs
									  where staff.Username == txtUsername.Text && staff.Password == txtPassword.Text
									  join school in context.Schools
									  on staff.SchoolID equals school.ID
									  select new
									  {
										  staff.Firstname,
										  staff.Lastname,
										  staff.Role,
										  school.ID,
										  SchoolName = school.Name,
										  SchoolSection = school.Section
									  }).First();

				// Initializing CurrentUser
				Program.CurrentUser = new()
				{
					Firstname = validatedStaff.Firstname,
					Lastname = validatedStaff.Lastname,
					Role = validatedStaff.Role,
					SchoolID = validatedStaff.ID,
					SchoolName = validatedStaff.SchoolName,
					SchoolSection = validatedStaff.SchoolSection
				};

				DialogResult = DialogResult.OK;
			}
			catch (Exception)
			{
				message.Title = "کاربری یافت نشد";
				message.Message = "کاربری با اطلاعات وارد شده یافت نشد!";
				message.ShowDialog();

				Cursor = Cursors.Default;

				return;
			}
		} // End of LoginButton_Click()
	}
}
