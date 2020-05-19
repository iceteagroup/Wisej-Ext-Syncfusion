namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejDateRangePicker
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
			this.ejDateRangePicker1 = new Wisej.Web.Ext.Syncfusion.ejDateRangePicker();
			this.textBoxStartDay = new Wisej.Web.TextBox();
			this.textBoxEndDay = new Wisej.Web.TextBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/daterangepicker/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdaterangepicker";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.textBoxEndDay);
			this.groupBox1.Controls.Add(this.textBoxStartDay);
			this.groupBox1.Size = new System.Drawing.Size(250, 407);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBoxStartDay, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBoxEndDay, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 326);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDateRangePicker1);
			this.panel.Size = new System.Drawing.Size(455, 407);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(546, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/daterangepicker/defaultfunctiona" +
    "lities";
			// 
			// ejDateRangePicker1
			// 
			this.ejDateRangePicker1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejDateRangePicker1.Location = new System.Drawing.Point(126, 187);
			this.ejDateRangePicker1.Name = "ejDateRangePicker1";
			this.ejDateRangePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"1/1/2020 - 1/15/2020\"}")));
			this.ejDateRangePicker1.Size = new System.Drawing.Size(200, 30);
			this.ejDateRangePicker1.TabIndex = 0;
			this.ejDateRangePicker1.Text = "ejDateRangePicker1";
			// 
			// textBoxStartDay
			// 
			this.textBoxStartDay.AutoSize = false;
			this.textBoxStartDay.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBoxStartDay.Label.Size = 50;
			this.textBoxStartDay.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxStartDay.LabelText = "Start Date";
			this.textBoxStartDay.Location = new System.Drawing.Point(28, 152);
			this.textBoxStartDay.Name = "textBoxStartDay";
			this.textBoxStartDay.Size = new System.Drawing.Size(195, 60);
			this.textBoxStartDay.TabIndex = 2;
			this.textBoxStartDay.Text = "2020-01-01";
			this.textBoxStartDay.Watermark = "Select date...";
			// 
			// textBoxEndDay
			// 
			this.textBoxEndDay.AutoSize = false;
			this.textBoxEndDay.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBoxEndDay.Label.Size = 50;
			this.textBoxEndDay.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxEndDay.LabelText = "End Date";
			this.textBoxEndDay.Location = new System.Drawing.Point(28, 239);
			this.textBoxEndDay.Name = "textBoxEndDay";
			this.textBoxEndDay.Size = new System.Drawing.Size(195, 60);
			this.textBoxEndDay.TabIndex = 3;
			this.textBoxEndDay.Text = "2020-01-15";
			this.textBoxEndDay.Watermark = "Select date...";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 31);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Allow Edit";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 94);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 31);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "Enable Time Picker";
			// 
			// ejDateRangePicker
			// 
			this.Name = "ejDateRangePicker";
			this.Size = new System.Drawing.Size(864, 597);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDateRangePicker ejDateRangePicker1;
		private TextBox textBoxEndDay;
		private TextBox textBoxStartDay;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
