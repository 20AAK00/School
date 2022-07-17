using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolClassLibrary.DataLayer;
using SchoolClassLibrary.DataLayer.Entities;
using Stimulsoft.Base;
using Stimulsoft.Report;

namespace SchoolUI.Forms
{
	public partial class FormReport : Form
	{
		// Constructors
		public FormReport()
		{
			InitializeComponent();
		}

		// Properties
		private readonly SchoolContext context = new();

		private void FormReport_Load(object sender, EventArgs e)
		{
			AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);

			Operations.Populate<Grade, ComboBox>(context, cboxGrade, grade => grade.SchoolID == Program.CurrentUser.SchoolID);

			Operations.Populate<Class, ComboBox>(context, cboxClass, tclass => tclass.GradeID == Convert.ToInt32(cboxGrade.SelectedValue));

			cboxGrade.SelectedValueChanged += new EventHandler(GradesComboBox_SelectedValueChanged);
		}

		private void GradesComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			Operations.Populate<Class, ComboBox>(context, cboxClass, tclass => tclass.GradeID == Convert.ToInt32(cboxGrade.SelectedValue));
		}

		private void CancelButton_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

		private void PrintButton_Click(object sender, EventArgs e)
		{
			StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHl2AD0gPVknKsaW0un+3PuM6TTcPMUAWEURKXNso0e5OFPaZYasFtsxNoDemsFOXbvf7SIcnyAkFX/4u37NTfx7g+0IqLXw6QIPolr1PvCSZz8Z5wjBNakeCVozGGOiuCOQDy60XNqfbgrOjxgQ5y/u54K4g7R/xuWmpdx5OMAbUbcy3WbhPCbJJYTI5Hg8C/gsbHSnC2EeOCuyA9ImrNyjsUHkLEh9y4WoRw7lRIc1x+dli8jSJxt9C+NYVUIqK7MEeCmmVyFEGN8mNnqZp4vTe98kxAr4dWSmhcQahHGuFBhKQLlVOdlJ/OT+WPX1zS2UmnkTrxun+FWpCC5bLDlwhlslxtyaN9pV3sRLO6KXM88ZkefRrH21DdR+4j79HA7VLTAsebI79t9nMgmXJ5hB1JKcJMUAgWpxT7C7JUGcWCPIG10NuCd9XQ7H4ykQ4Ve6J2LuNo9SbvP6jPwdfQJB6fJBnKg4mtNuLMlQ4pnXDc+wJmqgw25NfHpFmrZYACZOtLEJoPtMWxxwDzZEYYfT";

			StiReport report = new();
			report.Load(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Reports\Report.mrt");

			report["SchoolID"] = Program.CurrentUser.SchoolID;
			report["CourseID"] = Program.CurrentCourse.ID;
			report["ClassID"] = Convert.ToInt32(cboxClass.SelectedValue);
			report["GradeID"] = Convert.ToInt32(cboxGrade.SelectedValue);

			report.Show();
		}
	}
}
