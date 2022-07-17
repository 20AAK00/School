using SchoolClassLibrary.DataLayer;
using SchoolUI.Forms;

namespace SchoolUI
{
	public static class Program
	{
		// Classes
		public class User
		{
			private string section;

			// Properties
			public string Firstname { get; set; }
			public string Lastname { get; set; }
			public string Fullname { get { return Firstname + " " + Lastname; } }
			public string Role { get; set; }
			public int SchoolID { get; set; }
			public string SchoolName { get; set; }
			public string SchoolSection
			{
				get => section;
				set
				{
					if (value == "دوره دوم متوسطه")
						IsMajorAvailable = true;
					else
						IsMajorAvailable = false;

					section = value;
				}
}
			public bool IsMajorAvailable { get; private set; }
		}

		public class StaticCourse
		{
			// Fields
			private int id = 0;
			private string month = string.Empty;
			private string year = string.Empty;

			// Properties
			public int ID
			{
				get => id;
				set
				{
					id = value;
					OnChanged();
				}
			}
			public string Month
			{
				get => month;
				set
				{
					month = value;
					OnChanged();
				}
			}
			public string Year
			{
				get => year;
				set
				{
					year = value;
					OnChanged();
				}
			}
			public string Name { get => month + " " + year; }
			public bool IsSelected
			{
				get
				{
					if (ID == 0)
						return false;

					return true;
				}
			}

			// Events
			public event Action Changed;

			// Methods
			private void OnChanged() => Changed?.Invoke();

			public void Set(int id, string month, string year)
			{
				this.id = id;
				this.month = month;
				this.year = year;

				OnChanged();
			}

			/// <summary>
			/// Sets the last added course of current School as the current course.
			/// </summary>
			/// <param name="context"></param>
			public void SetLastCourseCurrent(SchoolContext context)
			{
				try
				{
					var lastAvailableCourse = context.Courses.Where(course => course.SchoolID == CurrentUser.SchoolID).OrderBy(course => course.ID).Select(course => new { course.ID, course.Month, course.Year }).Last();

					Set(lastAvailableCourse.ID, lastAvailableCourse.Month, lastAvailableCourse.Year);
				}
				catch (Exception)
				{
					Set(0, string.Empty, string.Empty);
				}
			}
		}

		// Properties
		public static User CurrentUser { get; set; }
		public static StaticCourse CurrentCourse { get; set; } = new();

		// Methods
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new FormMain());
		}
	}
}