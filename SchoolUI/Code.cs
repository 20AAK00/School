using SchoolUI.Forms;
using SchoolClassLibrary.DataLayer;
using SchoolClassLibrary.DataLayer.Entities;

namespace SchoolUI
{
	public class Operations
	{
		/// <summary>
		/// Shows a <i>FormMessage</i> for delete confirmation.
		/// </summary>
		/// <param name="message">Message to show in <i>FormMessage</i>.</param>
		/// <returns></returns>
		public static bool DeleteConfirmation(string message = "آیا از حذف رکورد انتخاب شده مطمئن هستید؟")
		{
			using FormMessage formMessage = new()
			{
				Message = message,
				FormButtons = FormMessage.FormMessageButtonTypes.YesNo
			};

			if (formMessage.ShowDialog() == DialogResult.Cancel)
				return false;

			return true;
		}

		public static void ShowDGVInfoInTextBoxComboBox(DataGridView dgv, Dictionary<int, TextBox> textboxes, Dictionary<int, ComboBox> comboBoxes)
		{
			if (textboxes != null)
				foreach (KeyValuePair<int, TextBox> pair in textboxes)
					pair.Value.Text = dgv.CurrentRow.Cells[pair.Key].Value.ToString();

			if (comboBoxes != null)
				foreach (KeyValuePair<int, ComboBox> pair in comboBoxes)
					pair.Value.SelectedItem = dgv.CurrentRow.Cells[pair.Key].Value.ToString();
		}

		public static void ShowListBoxInfoInTextBoxComboBox(ListBox lbox, List<TextBox> textboxes = null, List<ComboBox> comboBoxes = null)
		{
			if (textboxes != null)
				foreach (var textbox in textboxes)
					textbox.Text = lbox.GetItemText(lbox.SelectedItem);

			if (comboBoxes != null)
				foreach (var combobox in comboBoxes)
					combobox.SelectedText = lbox.GetItemText(lbox.SelectedItem);
		}

		public static void EnableDisableControls(List<Control> controlsToEnable, List<Control> controlsToDisable)
		{
			if (controlsToEnable != null)
				foreach (Control control in controlsToEnable)
					control.Enabled = true;

			if (controlsToDisable != null)
				foreach (Control control in controlsToDisable)
					control.Enabled = false;
		}

		public static void DisplayHideControls(List<Control> controlsToShow, List<Control> controlsToHide)
		{
			if (controlsToShow != null)
				foreach (Control control in controlsToShow)
					control.Visible = true;

			if (controlsToHide != null)
				foreach (Control control in controlsToHide)
					control.Visible = false;
		}

		/// <summary>
		/// A method for handling <i>Enter</i> and <i>Click</i> events of textboxes with selecting all the text when active. Also changes the textboxes <i>BackColor</i> to <i>White</i> when <i>TextChanged</i> event raises.
		/// </summary>
		/// <param name="textBoxes"></param>
		public static void SelectAllOnTextBox(params TextBox[] textBoxes)
		{
			var selectAll = new EventHandler((sender, e) => { ((TextBox)sender).SelectAll(); });
			var whiten = new EventHandler((sender, e) => { ((TextBox)sender).BackColor = Color.White; });

			foreach (var textbox in textBoxes)
			{
				textbox.Enter += selectAll;
				textbox.Click += selectAll;
				textbox.TextChanged += whiten;
			}
		}

		/// <summary>
		/// Finds if any of the given textboxes is empty and returns false. If none is empty returns true. Also if a textbox is empty, changes its <i>BackColor</i>.
		/// </summary>
		/// <param name="textBoxes"><i>TextBoxes</i> to check.</param>
		/// <returns></returns>
		public static bool FindMakeEmptyTextBoxRed(params TextBox[] textBoxes)
		{
			bool flag = false;

			foreach (var textbox in textBoxes)
				if (string.IsNullOrWhiteSpace(textbox.Text))
				{
					textbox.BackColor = Color.FromArgb(251, 213, 212);
					flag = true;
				}

			return flag;
		}

		/// <summary>
		/// Deletes an entity from database. Show a delete confimation first.
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="id"></param>
		public static void DeleteEntity<TEntity>(SchoolContext context, int id) where TEntity : class
		{
			if (!DeleteConfirmation())
				return;

			context.Remove(context.Set<TEntity>().Find(id));

			context.SaveChanges();
		}

		public static void DeleteAllEntities<TEntity>(SchoolContext context, Func<TEntity, bool> whereCallback) where TEntity : class
		{
			if (!DeleteConfirmation())
				return;

			context.RemoveRange(context.Set<TEntity>().Where(whereCallback).Select(entity => entity));

			context.SaveChanges();
		}

		public static void IfEmptyDoThese(DataGridView dgv, List<Control> controls, params TextBox[] textBoxes)
		{
			if (dgv.RowCount == 0)
			{
				foreach (var control in controls)
					control.Enabled = false;

				foreach (var textbox in textBoxes)
					textbox.Text = string.Empty;
			}
			else
				foreach (var control in controls)
					control.Enabled = true;
		}

		public static void IfEmptyDoThese(ListBox lbox, List<Control> controls, params TextBox[] textBoxes)
		{
			if (lbox.Items.Count == 0)
			{
				foreach (var control in controls)
					control.Enabled = false;

				foreach (var textbox in textBoxes)
					textbox.Text = string.Empty;
			}
			else
				foreach (var control in controls)
					control.Enabled = true;
		}

		/// <summary>
		/// Checks if a course with given month and year already available. If true, a <i>FormMessage</i> is shown.
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="context"></param>
		/// <param name="whereCallback"></param>
		/// <param name="errorTitle">Title of <i>FormMessage</i>.</param>
		/// <param name="errorMessage">Message to be shown in <i>FormMessage</i>.</param>
		/// <returns></returns>
		public static bool DoesEntityExists<TEntity>(SchoolContext context, Func<TEntity, bool> whereCallback, string errorTitle, string errorMessage) where TEntity: class
		{
			if (context.Set<TEntity>().Where(whereCallback).Any())
			{
				using FormMessage message = new()
				{
					Title = errorTitle,
					Message = errorMessage,
					FormButtons = FormMessage.FormMessageButtonTypes.OK
				};

				message.ShowDialog();

				return true;
			}

			return false;
		}

		/// <summary>
		/// Can populate a ComboBox/ListBox with entities of type <i>ISource</i>.
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <param name="context"></param>
		/// <param name="cbox"></param>
		/// <param name="whereCallback"></param>
		public static void Populate<TEntity, TList>(SchoolContext context, TList clbox, Func<TEntity, bool> whereCallback)
			where TEntity : class, ISource
			where TList : ListControl
		{
			var listOfEntities = context.Set<TEntity>().Where(whereCallback).Select(entity => new { entity.ID, entity.Name }).ToList();

			clbox.DataSource = listOfEntities;
			clbox.DisplayMember = "Name";
			clbox.ValueMember = "ID";
		}
	}
}
