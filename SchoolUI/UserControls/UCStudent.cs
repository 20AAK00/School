using SchoolClassLibrary.DataLayer.Entities;
using SchoolClassLibrary.DataLayer;
using SchoolUI.Forms;

namespace SchoolUI.UserControls
{
	public partial class UCStudent : UserControl
	{
		// Constructors
		public UCStudent()
		{
			InitializeComponent();

			Operations.SelectAllOnTextBox(txtFirstname, txtLastname, txtFathername, txtNationalCode, txtSearch);

			pboxPicture.Tag = string.Empty;

			context = new();
		}

		// Fields
		private readonly SchoolContext context;

		// Methods
		private void GradeComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateClassComboBox();
		}

		private void MajorComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateClassComboBox();
		}

		private void ClassComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateDGVStudent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtFirstname, txtLastname, txtNationalCode))
				return;

			if (Operations.DoesEntityExists<Student>(context, student => student.NationalCode == txtNationalCode.Text, "دانش‌آموز تکراری", "دانش‌آموزی با این کد ملی از قبل وجود دارد.\nلطفاً ال=طلاعات جدید وارد نمایید."))
				return;

			string newImageFilename = string.Empty;

			if (pboxPicture.Tag.ToString() != string.Empty)
			{
				newImageFilename = txtNationalCode.Text + Path.GetExtension(pboxPicture.Tag.ToString());
				CopyImageToAppData(pboxPicture.ImageLocation, newImageFilename);
			}

			Student newStudent = new()
			{
				Firstname = txtFirstname.Text,
				Lastname = txtLastname.Text,
				Fathername = txtFathername.Text,
				NationalCode = txtNationalCode.Text,
				PhotoAddress = newImageFilename,
				ClassID = Convert.ToInt32(cboxClassName.SelectedValue)
			};

			context.Students.Add(newStudent);

			context.SaveChanges();

			UpdateDGVStudent();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			if (Operations.FindMakeEmptyTextBoxRed(txtFirstname, txtLastname, txtNationalCode))
				return;

			int studentToEditId = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value);

			if (Operations.DoesEntityExists<Student>(context, student => student.NationalCode == txtNationalCode.Text && student.ID != studentToEditId, "دانش‌آموز تکراری", "دانش‌آموزی با این کد ملی از قبل وجود دارد.\nلطفاً اطلاعات جدید وارد نمایید."))
				return;

			var studentToEdit = context.Students.Find(studentToEditId);

			studentToEdit.Firstname = txtFirstname.Text;
			studentToEdit.Lastname = txtLastname.Text;
			studentToEdit.Fathername = txtFathername.Text;
			studentToEdit.NationalCode = txtNationalCode.Text;
			studentToEdit.ClassID = Convert.ToInt32(cboxClassName.SelectedValue);

			string newImageFilename = string.Empty;

			if (pboxPicture.Tag.ToString() != string.Empty)
			{
				newImageFilename = txtNationalCode.Text + Path.GetExtension(pboxPicture.Tag.ToString());
				studentToEdit.PhotoAddress = newImageFilename;
				CopyImageToAppData(pboxPicture.ImageLocation, newImageFilename);
			}
			else if (pboxPicture.ImageLocation == string.Empty)
			{
				studentToEdit.PhotoAddress = string.Empty;
			}

			context.SaveChanges();

			UpdateDGVStudent();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteEntity<Student>(context, Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value));

			UpdateDGVStudent();
		}

		private void DeleteAllButton_Click(object sender, EventArgs e)
		{
			Operations.DeleteAllEntities<Student>(context, student => student.ClassID == Convert.ToInt32(cboxClassName.SelectedValue));

			UpdateDGVStudent();
		}

		private void AddPicButton_Click(object sender, EventArgs e)
		{
			using OpenFileDialog openFile = new()
			{
				Multiselect = false,
				Title = "Browse For Student Picture",
				Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
			};

			if (openFile.ShowDialog() == DialogResult.Cancel)
				return;

			pboxPicture.ImageLocation = openFile.FileName;
			pboxPicture.Tag = openFile.SafeFileName;
		}

		private void DeletePicButton_Click(object sender, EventArgs e)
		{
			pboxPicture.ImageLocation = string.Empty;
			pboxPicture.Tag = string.Empty;
			pboxPicture.Image = Resources.StudentDefaultPicture;
		}

		private void UCStudent_Load(object sender, EventArgs e)
		{
			Operations.Populate<Grade, ComboBox>(context, cboxGradeName, grade => grade.SchoolID == Program.CurrentUser.SchoolID);

			GradeComboBox_SelectedValueChanged(null, null);
			UpdateDGVStudent();
			StudentsDGV_UserDeletedRow(null, null);

			cboxGradeName.SelectedValueChanged += new EventHandler(GradeComboBox_SelectedValueChanged);
			cboxClassName.SelectedValueChanged += new EventHandler(ClassComboBox_SelectedValueChanged);
		}

		private void StudentDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Operations.ShowDGVInfoInTextBoxComboBox(
				dgvStudents,
				new Dictionary<int, TextBox>()
				{ 
					{ 1, txtFirstname },
					{ 2, txtLastname },
					{ 3, txtFathername },
					{ 4, txtNationalCode }
				},
				null
				);

			string pictureURL = dgvStudents.CurrentRow.Cells[5].Value.ToString();

			if (pictureURL != string.Empty)
				pboxPicture.ImageLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StudentImages", dgvStudents.CurrentRow.Cells[5].Value.ToString());
			else
				DeletePicButton_Click(null, null);
				
			pboxPicture.Tag = string.Empty;
		}

		private void StudentsDGV_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			if (dgvStudents.RowCount == 0)
			{
				Operations.EnableDisableControls(null, new List<Control>() { btnEdit, btnDelete, btnDeleteAll, btnSeach });

				txtFirstname.Text = string.Empty;
				txtLastname.Text = string.Empty;
				txtFathername.Text = string.Empty;
				txtNationalCode.Text = string.Empty;
				txtSearch.Text = string.Empty;
				pboxPicture.ImageLocation = string.Empty;
			}
			else
			{
				Operations.EnableDisableControls(new List<Control>() { btnEdit, btnDelete, btnDeleteAll, btnSeach }, null);
			}
		}

		private void UpdateClassComboBox()
		{
			Operations.Populate<Class, ComboBox>(context, cboxClassName, tclass => tclass.GradeID == Convert.ToInt32(cboxGradeName.SelectedValue));
		}

		private void UpdateDGVStudent()
		{
			dgvStudents.DataSource = (from student in context.Students
									  where student.ClassID == Convert.ToUInt32(cboxClassName.SelectedValue)
									  select new
									  {
										  student.ID,
										  student.Firstname,
										  student.Lastname,
										  student.Fathername,
										  student.NationalCode,
										  student.PhotoAddress
									  }).ToList();

			dgvStudents.Columns[0].Visible = false;
			dgvStudents.Columns[1].HeaderText = "نام";
			dgvStudents.Columns[2].HeaderText = "نام خانوادگی";
			dgvStudents.Columns[3].HeaderText = "نام پدر";
			dgvStudents.Columns[4].HeaderText = "کد ملی";
			dgvStudents.Columns[5].Visible = false;

			StudentsDGV_UserDeletedRow(null, null);
		}

		private void CopyImageToAppData(string sourceImageAddress, string newImageSafeFilename)
		{
			var imagesFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StudentImages");

			if (!Directory.Exists(imagesFolderPath))
				Directory.CreateDirectory(imagesFolderPath);

			File.Copy(
				sourceImageAddress,
				Path.Combine(
					imagesFolderPath,
					newImageSafeFilename
					)
				);
		}
	}
}
