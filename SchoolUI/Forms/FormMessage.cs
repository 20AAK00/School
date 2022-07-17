namespace SchoolUI.Forms
{
	public partial class FormMessage : Form
	{
		// Enums
		/// <summary>
		/// An enum for FormMessage's FormType Property.
		/// </summary>
		public enum FormMessageButtonTypes
		{
			OK,
			YesNo
		}

		// Constructors
		public FormMessage()
		{
			InitializeComponent();
		}

		public FormMessage(string title, string message, FormMessageButtonTypes buttons)
		{
			InitializeComponent();

			ucTitleBar.Title = title;
			lblMessage.Text = message;
			FormButtons = buttons;
		}

		// Properties
		/// <summary>
		/// Stores the desired message to show in FormMessage.
		/// </summary>
		public string Message { set => lblMessage.Text = value; }
		public string Title { set => ucTitleBar.Title = value; }

		/// <summary>
		/// Sets the buttons' texts, title of the form and displays the suitable buttons according to the assigned value.
		/// </summary>
		public FormMessageButtonTypes FormButtons
		{
			set
			{
				if (value == FormMessageButtonTypes.OK)
				{
					btnOK.Text = "تأیید";
					btnCancel.Visible = false;
				}
				else
				{
					btnOK.Text = "بله";
					btnCancel.Text = "خیر";
					btnCancel.Visible = true;
				}
			}
		}

		// Methods
		// OK Button
		private void OKButton_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

		// Cancel Button
		private void CancelButton_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
	}
}
