namespace SchoolUI.UserControls.Reusables
{
	public partial class UCTitleBar : UserControl
	{
		// Constructors
		public UCTitleBar()
		{
			InitializeComponent();
		}

		// Properties
		public string Title { set { lblTitle.Text = value; } }

		// Methods
		// Close Button
		/// <summary>
		/// Sets the parent form's DialogResult to Cancel and disposes it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseButton_Click(object sender, EventArgs e)
		{
			((Form)Parent).DialogResult = DialogResult.Cancel;
			((Form)Parent).Dispose();
		}

		// Minimize Button
		/// <summary>
		/// Minimizes the parent form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			((Form)Parent).WindowState = FormWindowState.Minimized;
		}
	}
}
