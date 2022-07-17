using SchoolClassLibrary.DataLayer;
using SchoolClassLibrary.DataLayer.Entities;
using System.Data;

namespace SchoolUI.UserControls
{
	public partial class UCGradeClassMajor : UserControl
	{
		// Constructors
		public UCGradeClassMajor()
		{
			InitializeComponent();

			Operations.SelectAllOnTextBox(txtGradeName, txtClassName);
		}

		// Fields
		private readonly SchoolContext context = new();

		// Methods
		// Grade Methods
		private void AddGradeButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtGradeName))
				return;

			if (Operations.DoesEntityExists<Grade>(context, grade => grade.Name == txtGradeName.Text, "پایه تکراری", "پایه‌ای با مشخصات وارد شده از قبل وجود دارد.\nلطفاً مشخصات جدید وارد نمایید."))
				return;

			Grade newGrade = new() { Name = txtGradeName.Text, SchoolID = Program.CurrentUser.SchoolID };

			context.Grades.Add(newGrade);

			context.SaveChanges();

			UpdateDGVGrade();
		}

		private void EditGradeButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtGradeName))
				return;

			int gradeToEditId = Convert.ToInt32(lboxGrade.SelectedValue);

			if (Operations.DoesEntityExists<Grade>(context, grade => grade.Name == txtGradeName.Text && grade.ID != gradeToEditId, "پایه تکراری", "پایه‌ای با مشخصات وارد شده از قبل وجود دارد.\nلطفاً مشخصات جدید وارد نمایید."))
				return;

			var gradeToEdit = context.Grades.Find(gradeToEditId);

			gradeToEdit.Name = txtGradeName.Text;

			context.SaveChanges();

			UpdateDGVGrade();
		}

		private void DeleteGradeButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteEntity<Grade>(context, Convert.ToInt32(lboxGrade.SelectedValue));

			UpdateDGVGrade();
		}

		private void DeleteAllGradesButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteAllEntities<Grade>(context, grade => grade.SchoolID == Program.CurrentUser.SchoolID);

			UpdateDGVGrade();
		}

		private void GradesListBox_SelectedValueChanged(object sender, EventArgs e)
		{
			List<Control> controlsToDisable = new() { btnEditGrade, btnDeleteAllGrades, btnDeleteGrade, btnAddClass };

			UpdateClassListBox();

			Operations.IfEmptyDoThese(lboxGrade, controlsToDisable, txtGradeName);
			Operations.ShowListBoxInfoInTextBoxComboBox(lboxGrade, new List<TextBox>() { txtGradeName });
		}

		// Class Methods
		private void AddClassButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtClassName))
				return;

			if (Operations.DoesEntityExists<Class>(context, tclass => tclass.Name == txtClassName.Text, "کلاس تکراری", "کلاسی با مشخصات وارد شده از قبل وجود دارد.\nلطفاً مشخصات جدید وارد نمایید."))
				return;

			Class newClass = new() { Name = txtClassName.Text, GradeID = Convert.ToInt32(lboxGrade.SelectedValue) };

			context.Classes.Add(newClass);

			context.SaveChanges();

			UpdateClassListBox();
		}

		private void EditClassButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtClassName))
				return;

			int classToEditId = Convert.ToInt32(lboxClass.SelectedValue);

			if (Operations.DoesEntityExists<Class>(context, tclass => tclass.Name == txtClassName.Text && tclass.ID != classToEditId, "کلاس تکراری", "کلاسی با مشخصات وارد شده از قبل وجود دارد.\nلطفاً مشخصات جدید وارد نمایید."))
				return;

			var classToEdit = context.Classes.Find(classToEditId);

			classToEdit.Name = txtClassName.Text;

			context.SaveChanges();

			UpdateClassListBox();
		}

		private void DeleteClassButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteEntity<Class>(context, Convert.ToInt32(lboxClass.SelectedValue));

			UpdateClassListBox();
		}

		private void DeleteAllClassesButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteAllEntities<Class>(context, tclass => tclass.ID == Convert.ToInt32(lboxGrade.SelectedValue));

			UpdateClassListBox();
		}

		private void ClassListBox_SelectedValueChanged(object sender, EventArgs e)
		{
			Operations.IfEmptyDoThese(lboxClass, new List<Control>() { btnEditClass, btnDeleteAllClasses, btnDeleteClass }, txtClassName);
			Operations.ShowListBoxInfoInTextBoxComboBox(lboxClass, new List<TextBox>() { txtClassName });
		}

		// UCGradeClassMajor Methods
		private void UCGradeMajorClass_Load(object sender, EventArgs e)
		{
			UpdateDGVGrade();

			lboxGrade.SelectedValueChanged += new EventHandler(GradesListBox_SelectedValueChanged);

			UpdateClassListBox();
		}

		// Utility Methods
		private void UpdateDGVGrade()
		{
			Operations.Populate<Grade, ListBox>(context, lboxGrade, grade => grade.SchoolID == Program.CurrentUser.SchoolID);

			GradesListBox_SelectedValueChanged(null, null);
		}

		private void UpdateClassListBox()
		{
			Operations.Populate<Class, ListBox>(context, lboxClass, tclass => tclass.GradeID == Convert.ToInt32(lboxGrade.SelectedValue));
			
			ClassListBox_SelectedValueChanged(null, null);
		}
	}
}
