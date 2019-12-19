namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejTimePicker
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ejTimePicker1 = new Wisej.Web.Ext.Syncfusion.ejTimePicker();
			this.buttonGetTime = new Wisej.Web.Button();
			this.buttonTimeNow = new Wisej.Web.Button();
			this.buttonShowHidePopup = new Wisej.Web.Button();
			this.checkBoxEnabled = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/timepicker/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtimepicker";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxEnabled);
			this.groupBox1.Controls.Add(this.buttonShowHidePopup);
			this.groupBox1.Controls.Add(this.buttonTimeNow);
			this.groupBox1.Controls.Add(this.buttonGetTime);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonGetTime, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonTimeNow, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonShowHidePopup, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnabled, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTimePicker1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(530, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/timepicker/defaultfunctionalitie" +
    "s";
			// 
			// ejTimePicker1
			// 
			this.ejTimePicker1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejTimePicker1.Location = new System.Drawing.Point(126, 141);
			this.ejTimePicker1.Name = "ejTimePicker1";
			this.ejTimePicker1.Size = new System.Drawing.Size(200, 30);
			this.ejTimePicker1.Text = "ejTimePicker1";
			// 
			// buttonGetTime
			// 
			this.buttonGetTime.Location = new System.Drawing.Point(28, 88);
			this.buttonGetTime.Name = "buttonGetTime";
			this.buttonGetTime.Size = new System.Drawing.Size(195, 30);
			this.buttonGetTime.TabIndex = 2;
			this.buttonGetTime.Text = "Get Time";
			this.buttonGetTime.Click += new System.EventHandler(this.buttonGetTime_Click);
			// 
			// buttonTimeNow
			// 
			this.buttonTimeNow.Location = new System.Drawing.Point(28, 138);
			this.buttonTimeNow.Name = "buttonTimeNow";
			this.buttonTimeNow.Size = new System.Drawing.Size(195, 30);
			this.buttonTimeNow.TabIndex = 3;
			this.buttonTimeNow.Text = "Time Now";
			this.buttonTimeNow.Click += new System.EventHandler(this.buttonTimeNow_Click);
			// 
			// buttonShowHidePopup
			// 
			this.buttonShowHidePopup.Location = new System.Drawing.Point(28, 188);
			this.buttonShowHidePopup.Name = "buttonShowHidePopup";
			this.buttonShowHidePopup.Size = new System.Drawing.Size(195, 30);
			this.buttonShowHidePopup.TabIndex = 4;
			this.buttonShowHidePopup.Text = "Show / Hide Popup";
			this.buttonShowHidePopup.Click += new System.EventHandler(this.buttonShowHidePopup_Click);
			// 
			// checkBoxEnabled
			// 
			this.checkBoxEnabled.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnabled.AutoSize = false;
			this.checkBoxEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnabled.Checked = true;
			this.checkBoxEnabled.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxEnabled.Location = new System.Drawing.Point(28, 30);
			this.checkBoxEnabled.Name = "checkBoxEnabled";
			this.checkBoxEnabled.Size = new System.Drawing.Size(195, 38);
			this.checkBoxEnabled.TabIndex = 7;
			this.checkBoxEnabled.Text = "Enabled";
			// 
			// ejTimePicker
			// 
			this.Name = "ejTimePicker";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTimePicker ejTimePicker1;
		private Button buttonShowHidePopup;
		private Button buttonTimeNow;
		private Button buttonGetTime;
		private CheckBox checkBoxEnabled;
	}
}
