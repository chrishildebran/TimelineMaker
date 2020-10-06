

namespace Timeline
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{

				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnSelectTargetFolder = new System.Windows.Forms.Button();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.cmbEventType = new System.Windows.Forms.ComboBox();
			this.txtRootDirectory = new System.Windows.Forms.TextBox();
			this.lblEventStartDate = new System.Windows.Forms.Label();
			this.lblEventEndDate = new System.Windows.Forms.Label();
			this.lblEventType = new System.Windows.Forms.Label();
			this.txtWho = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.btnMakeFolders = new System.Windows.Forms.Button();
			this.lblInterval = new System.Windows.Forms.Label();
			this.txtIntervalAmount = new System.Windows.Forms.TextBox();
			this.cmbIntervalUnit = new System.Windows.Forms.ComboBox();
			this.lblGoalFolderName = new System.Windows.Forms.Label();
			this.lblWhereEventCity = new System.Windows.Forms.Label();
			this.txtWhereEventCity = new System.Windows.Forms.TextBox();
			this.lblWhereEventState = new System.Windows.Forms.Label();
			this.txtWhereEventState = new System.Windows.Forms.TextBox();
			this.btnResetForm = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();

			this.SuspendLayout();
			this.folderBrowserDialog1.SelectedPath = "D:\\";
			this.btnSelectTargetFolder.Location = new System.Drawing.Point(28, 32);
			this.btnSelectTargetFolder.Name = "btnSelectTargetFolder";
			this.btnSelectTargetFolder.Size = new System.Drawing.Size(98, 23);
			this.btnSelectTargetFolder.TabIndex = 1;
			this.btnSelectTargetFolder.Text = "Target Folder";
			this.btnSelectTargetFolder.UseVisualStyleBackColor = true;
			this.btnSelectTargetFolder.Click += new System.EventHandler(this.BtnRootFolderSelect);
			this.dtpStartDate.CustomFormat = "";
			this.dtpStartDate.Location = new System.Drawing.Point(153, 75);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
			this.dtpStartDate.TabIndex = 3;
			this.dtpEndDate.Location = new System.Drawing.Point(153, 117);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
			this.dtpEndDate.TabIndex = 4;
			this.cmbEventType.FormattingEnabled = true;
			this.cmbEventType.Items.AddRange(new object[] {
		"Anniversary",
		"Birthday",
		"Christmas",
		"Halloween",
		"Independence Day",
		"New Years Day",
		"Presidents Day",
		"School-Elementary",
		"School-Junior High",
		"School-High",
		"School-College",
		"Shelter",
		"Thanksgiving",
		"Vacation",
		"Veterans Day",
		"Work"});
			this.cmbEventType.Location = new System.Drawing.Point(153, 159);
			this.cmbEventType.Name = "cmbEventType";
			this.cmbEventType.Size = new System.Drawing.Size(200, 21);
			this.cmbEventType.TabIndex = 6;
			this.cmbEventType.Visible = false;
			this.txtRootDirectory.Location = new System.Drawing.Point(153, 33);
			this.txtRootDirectory.Name = "txtRootDirectory";
			this.txtRootDirectory.Size = new System.Drawing.Size(200, 20);
			this.txtRootDirectory.TabIndex = 7;
			this.txtRootDirectory.Text = "D:\\";
			this.lblEventStartDate.AutoSize = true;
			this.lblEventStartDate.Location = new System.Drawing.Point(38, 79);
			this.lblEventStartDate.Name = "lblEventStartDate";
			this.lblEventStartDate.Size = new System.Drawing.Size(86, 13);
			this.lblEventStartDate.TabIndex = 8;
			this.lblEventStartDate.Text = "Event Start Date";
			this.lblEventEndDate.AutoSize = true;
			this.lblEventEndDate.Location = new System.Drawing.Point(38, 121);
			this.lblEventEndDate.Name = "lblEventEndDate";
			this.lblEventEndDate.Size = new System.Drawing.Size(83, 13);
			this.lblEventEndDate.TabIndex = 9;
			this.lblEventEndDate.Text = "Event End Date";
			this.lblEventType.AutoSize = true;
			this.lblEventType.Location = new System.Drawing.Point(38, 163);
			this.lblEventType.Name = "lblEventType";
			this.lblEventType.Size = new System.Drawing.Size(62, 13);
			this.lblEventType.TabIndex = 10;
			this.lblEventType.Text = "Event Type";
			this.txtWho.Location = new System.Drawing.Point(153, 202);
			this.txtWho.Name = "txtWho";
			this.txtWho.Size = new System.Drawing.Size(200, 20);
			this.txtWho.TabIndex = 11;
			this.txtWho.Text = "Chris Hildebran";
			this.txtWho.Visible = false;
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(38, 206);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 12;
			this.lblName.Text = "Name";
			this.btnMakeFolders.Location = new System.Drawing.Point(278, 495);
			this.btnMakeFolders.Name = "btnMakeFolders";
			this.btnMakeFolders.Size = new System.Drawing.Size(75, 23);
			this.btnMakeFolders.TabIndex = 16;
			this.btnMakeFolders.Text = "Make";
			this.btnMakeFolders.UseVisualStyleBackColor = true;
			this.btnMakeFolders.Click += new System.EventHandler(this.button2_Click);
			this.lblInterval.AutoSize = true;
			this.lblInterval.Location = new System.Drawing.Point(38, 248);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(80, 13);
			this.lblInterval.TabIndex = 17;
			this.lblInterval.Text = "Occurs Every...";
			this.txtIntervalAmount.Location = new System.Drawing.Point(153, 244);
			this.txtIntervalAmount.Name = "txtIntervalAmount";
			this.txtIntervalAmount.Size = new System.Drawing.Size(40, 20);
			this.txtIntervalAmount.TabIndex = 18;
			this.txtIntervalAmount.Text = "1";
			this.txtIntervalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.cmbIntervalUnit.FormattingEnabled = true;
			this.cmbIntervalUnit.Items.AddRange(new object[] {
		"Year(s)",
		"Quarter(s)",
		"Month(s)",
		"Week(s)",
		"Day(s)"});
			this.cmbIntervalUnit.Location = new System.Drawing.Point(213, 244);
			this.cmbIntervalUnit.Name = "cmbIntervalUnit";
			this.cmbIntervalUnit.SelectionStart = 4;
			this.cmbIntervalUnit.Size = new System.Drawing.Size(140, 21);
			this.cmbIntervalUnit.TabIndex = 19;
			this.lblGoalFolderName.AutoSize = true;
			this.lblGoalFolderName.Location = new System.Drawing.Point(38, 572);
			this.lblGoalFolderName.Name = "lblGoalFolderName";
			this.lblGoalFolderName.Size = new System.Drawing.Size(283, 13);
			this.lblGoalFolderName.TabIndex = 20;
			this.lblGoalFolderName.Text = "Goal: 1968-09-06_Chris Hildebran_Birthday_Reno Nevada";
			this.lblWhereEventCity.AutoSize = true;
			this.lblWhereEventCity.Location = new System.Drawing.Point(38, 291);
			this.lblWhereEventCity.Name = "lblWhereEventCity";
			this.lblWhereEventCity.Size = new System.Drawing.Size(24, 13);
			this.lblWhereEventCity.TabIndex = 22;
			this.lblWhereEventCity.Text = "City";
			this.txtWhereEventCity.Location = new System.Drawing.Point(155, 287);
			this.txtWhereEventCity.Name = "txtWhereEventCity";
			this.txtWhereEventCity.Size = new System.Drawing.Size(200, 20);
			this.txtWhereEventCity.TabIndex = 21;
			this.txtWhereEventCity.Text = "City";
			this.txtWhereEventCity.Visible = false;
			this.lblWhereEventState.AutoSize = true;
			this.lblWhereEventState.Location = new System.Drawing.Point(38, 333);
			this.lblWhereEventState.Name = "lblWhereEventState";
			this.lblWhereEventState.Size = new System.Drawing.Size(32, 13);
			this.lblWhereEventState.TabIndex = 24;
			this.lblWhereEventState.Text = "State";
			this.txtWhereEventState.Location = new System.Drawing.Point(153, 329);
			this.txtWhereEventState.Name = "txtWhereEventState";
			this.txtWhereEventState.Size = new System.Drawing.Size(200, 20);
			this.txtWhereEventState.TabIndex = 23;
			this.txtWhereEventState.Text = "State";
			this.txtWhereEventState.Visible = false;
			this.btnResetForm.Location = new System.Drawing.Point(185, 495);
			this.btnResetForm.Name = "btnResetForm";
			this.btnResetForm.Size = new System.Drawing.Size(75, 23);
			this.btnResetForm.TabIndex = 26;
			this.btnResetForm.Text = "Reset";
			this.btnResetForm.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 386);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Compiled To Create \"\\YYYYMMDD_Weekday_TLM\"";

			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 611);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnResetForm);
			this.Controls.Add(this.lblWhereEventState);
			this.Controls.Add(this.txtWhereEventState);
			this.Controls.Add(this.lblWhereEventCity);
			this.Controls.Add(this.txtWhereEventCity);
			this.Controls.Add(this.lblGoalFolderName);
			this.Controls.Add(this.cmbIntervalUnit);
			this.Controls.Add(this.txtIntervalAmount);
			this.Controls.Add(this.lblInterval);
			this.Controls.Add(this.btnMakeFolders);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtWho);
			this.Controls.Add(this.lblEventType);
			this.Controls.Add(this.lblEventEndDate);
			this.Controls.Add(this.lblEventStartDate);
			this.Controls.Add(this.txtRootDirectory);
			this.Controls.Add(this.cmbEventType);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.btnSelectTargetFolder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Timeline Folders";
			this.Load += new System.EventHandler(this.Form1_Load);

			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnSelectTargetFolder;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.ComboBox cmbEventType;
		private System.Windows.Forms.TextBox txtRootDirectory;
		private System.Windows.Forms.Label lblEventStartDate;
		private System.Windows.Forms.Label lblEventEndDate;
		private System.Windows.Forms.Label lblEventType;
		private System.Windows.Forms.TextBox txtWho;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnMakeFolders;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.TextBox txtIntervalAmount;
		private System.Windows.Forms.ComboBox cmbIntervalUnit;
		private System.Windows.Forms.Label lblGoalFolderName;
		private System.Windows.Forms.Label lblWhereEventCity;
		private System.Windows.Forms.TextBox txtWhereEventCity;
		private System.Windows.Forms.Label lblWhereEventState;
		private System.Windows.Forms.TextBox txtWhereEventState;
		private System.Windows.Forms.Button btnResetForm;
		private System.Windows.Forms.Label label1;

	}
}

