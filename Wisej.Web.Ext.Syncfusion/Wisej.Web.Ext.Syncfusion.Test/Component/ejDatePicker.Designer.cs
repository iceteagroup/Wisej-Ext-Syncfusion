namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejDatePicker
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
			this.ejDatePicker1 = new Wisej.Web.Ext.Syncfusion.ejDatePicker();
			this.checkBoxEnableStrictMode = new Wisej.Web.CheckBox();
			this.checkBoxShowOtherMonths = new Wisej.Web.CheckBox();
			this.checkBoxAllowDrillDown = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/datepicker/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdatepicker";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxAllowDrillDown);
			this.groupBox1.Controls.Add(this.checkBoxShowOtherMonths);
			this.groupBox1.Controls.Add(this.checkBoxEnableStrictMode);
			this.groupBox1.Size = new System.Drawing.Size(250, 396);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableStrictMode, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowOtherMonths, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowDrillDown, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 315);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDatePicker1);
			this.panel.Size = new System.Drawing.Size(455, 396);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(519, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/datepicker/defaultfunctionalitie" +
    "s";
			// 
			// ejDatePicker1
			// 
			this.ejDatePicker1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejDatePicker1.Location = new System.Drawing.Point(126, 182);
			this.ejDatePicker1.Name = "ejDatePicker1";
			this.ejDatePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"1/1/2020\",\"showOtherMonths\":true,\"enableStrictMode\":true}")));
			this.ejDatePicker1.Size = new System.Drawing.Size(200, 30);
			this.ejDatePicker1.Text = "ejDatePicker1";
			// 
			// checkBox1
			// 
			this.checkBoxEnableStrictMode.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnableStrictMode.AutoSize = false;
			this.checkBoxEnableStrictMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnableStrictMode.Checked = true;
			this.checkBoxEnableStrictMode.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxEnableStrictMode.Location = new System.Drawing.Point(28, 41);
			this.checkBoxEnableStrictMode.Name = "checkBox1";
			this.checkBoxEnableStrictMode.Size = new System.Drawing.Size(195, 38);
			this.checkBoxEnableStrictMode.TabIndex = 9;
			this.checkBoxEnableStrictMode.Text = "Strict Mode";
			// 
			// checkBox3
			// 
			this.checkBoxShowOtherMonths.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowOtherMonths.AutoSize = false;
			this.checkBoxShowOtherMonths.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowOtherMonths.Checked = true;
			this.checkBoxShowOtherMonths.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowOtherMonths.Location = new System.Drawing.Point(28, 110);
			this.checkBoxShowOtherMonths.Name = "checkBox3";
			this.checkBoxShowOtherMonths.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShowOtherMonths.TabIndex = 11;
			this.checkBoxShowOtherMonths.Text = "Show Other Months";
			// 
			// checkBox2
			// 
			this.checkBoxAllowDrillDown.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowDrillDown.AutoSize = false;
			this.checkBoxAllowDrillDown.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowDrillDown.Checked = true;
			this.checkBoxAllowDrillDown.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxAllowDrillDown.Location = new System.Drawing.Point(28, 179);
			this.checkBoxAllowDrillDown.Name = "checkBox2";
			this.checkBoxAllowDrillDown.Size = new System.Drawing.Size(195, 38);
			this.checkBoxAllowDrillDown.TabIndex = 12;
			this.checkBoxAllowDrillDown.Text = "Allow Drill Down";
			// 
			// ejDatePicker
			// 
			this.Name = "ejDatePicker";
			this.Size = new System.Drawing.Size(864, 586);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDatePicker ejDatePicker1;
		private CheckBox checkBoxEnableStrictMode;
		private CheckBox checkBoxShowOtherMonths;
		private CheckBox checkBoxAllowDrillDown;
	}
}
