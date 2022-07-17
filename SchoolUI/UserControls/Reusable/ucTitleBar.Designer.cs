namespace SchoolUI.UserControls.Reusables;

partial class UCTitleBar
{
	/// <summary> 
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Component Designer generated code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnClose = new FontAwesome.Sharp.IconButton();
			this.btnMinimize = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("P - IRAN Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTitle.Size = new System.Drawing.Size(1000, 40);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "عنوان پنجره";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClose
			// 
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("P - IRAN Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
			this.btnClose.IconColor = System.Drawing.Color.White;
			this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnClose.IconSize = 25;
			this.btnClose.Location = new System.Drawing.Point(960, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 4;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("P - IRAN Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.btnMinimize.IconColor = System.Drawing.Color.White;
			this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnMinimize.IconSize = 20;
			this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMinimize.Location = new System.Drawing.Point(920, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(40, 40);
			this.btnMinimize.TabIndex = 5;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// UCTitleBar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(40)))), ((int)(((byte)(138)))));
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "UCTitleBar";
			this.Size = new System.Drawing.Size(1000, 40);
			this.ResumeLayout(false);

	}

	#endregion

	private Label lblTitle;
	private FontAwesome.Sharp.IconButton btnClose;
	private FontAwesome.Sharp.IconButton btnMinimize;
}
