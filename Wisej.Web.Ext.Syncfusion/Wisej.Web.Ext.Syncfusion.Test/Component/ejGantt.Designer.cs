namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejGantt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejGantt));
			this.ejGantt1 = new Wisej.Web.Ext.Syncfusion.ejGantt();
			this.textBoxScheduleStartDate = new Wisej.Web.TextBox();
			this.checkBoxShowProgressStatus = new Wisej.Web.CheckBox();
			this.checkBoxShowColumnOptions = new Wisej.Web.CheckBox();
			this.textBoxScheduleEndDate = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/gantt/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejgantt";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxScheduleEndDate);
			this.groupBox1.Controls.Add(this.checkBoxShowColumnOptions);
			this.groupBox1.Controls.Add(this.checkBoxShowProgressStatus);
			this.groupBox1.Controls.Add(this.textBoxScheduleStartDate);
			this.groupBox1.Size = new System.Drawing.Size(250, 475);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBoxScheduleStartDate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowProgressStatus, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowColumnOptions, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBoxScheduleEndDate, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 394);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejGantt1);
			this.panel.Size = new System.Drawing.Size(601, 475);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(576, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/gantt/Sorting/DefaultFunctionali" +
    "ties";
			// 
			// ejGantt1
			// 
			this.ejGantt1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejGantt1.Location = new System.Drawing.Point(3, 3);
			this.ejGantt1.Name = "ejGantt1";
			this.ejGantt1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejGantt1.Options"))));
			this.ejGantt1.Size = new System.Drawing.Size(593, 467);
			this.ejGantt1.TabIndex = 0;
			this.ejGantt1.Text = "ejGantt1";
			// 
			// textBoxScheduleStartDate
			// 
			this.textBoxScheduleStartDate.AutoSize = false;
			this.textBoxScheduleStartDate.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBoxScheduleStartDate.Label.Size = 50;
			this.textBoxScheduleStartDate.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxScheduleStartDate.LabelText = "Schedule Start Date";
			this.textBoxScheduleStartDate.Location = new System.Drawing.Point(28, 36);
			this.textBoxScheduleStartDate.Name = "textBoxScheduleStartDate";
			this.textBoxScheduleStartDate.Size = new System.Drawing.Size(195, 60);
			this.textBoxScheduleStartDate.TabIndex = 3;
			this.textBoxScheduleStartDate.Text = "2019-02-17";
			this.textBoxScheduleStartDate.Watermark = "Select date...";
			// 
			// checkBoxShowProgressStatus
			// 
			this.checkBoxShowProgressStatus.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowProgressStatus.AutoSize = false;
			this.checkBoxShowProgressStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowProgressStatus.Checked = true;
			this.checkBoxShowProgressStatus.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowProgressStatus.Location = new System.Drawing.Point(28, 224);
			this.checkBoxShowProgressStatus.Name = "checkBoxShowProgressStatus";
			this.checkBoxShowProgressStatus.Size = new System.Drawing.Size(195, 22);
			this.checkBoxShowProgressStatus.TabIndex = 6;
			this.checkBoxShowProgressStatus.Text = "Show Progress Status";
			// 
			// checkBoxShowColumnOptions
			// 
			this.checkBoxShowColumnOptions.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowColumnOptions.AutoSize = false;
			this.checkBoxShowColumnOptions.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowColumnOptions.Checked = true;
			this.checkBoxShowColumnOptions.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowColumnOptions.Location = new System.Drawing.Point(28, 280);
			this.checkBoxShowColumnOptions.Name = "checkBoxShowColumnOptions";
			this.checkBoxShowColumnOptions.Size = new System.Drawing.Size(195, 22);
			this.checkBoxShowColumnOptions.TabIndex = 7;
			this.checkBoxShowColumnOptions.Text = "Show Column Options";
			// 
			// textBoxScheduleEndDate
			// 
			this.textBoxScheduleEndDate.AutoSize = false;
			this.textBoxScheduleEndDate.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBoxScheduleEndDate.Label.Size = 50;
			this.textBoxScheduleEndDate.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxScheduleEndDate.LabelText = "Schedule End Date";
			this.textBoxScheduleEndDate.Location = new System.Drawing.Point(28, 130);
			this.textBoxScheduleEndDate.Name = "textBoxScheduleEndDate";
			this.textBoxScheduleEndDate.Size = new System.Drawing.Size(195, 60);
			this.textBoxScheduleEndDate.TabIndex = 9;
			this.textBoxScheduleEndDate.Text = "2017-03-20";
			this.textBoxScheduleEndDate.Watermark = "Select date...";
			// 
			// ejGantt
			// 
			this.Name = "ejGantt";
			this.Size = new System.Drawing.Size(1010, 665);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejGantt ejGantt1;
		private TextBox textBoxScheduleStartDate;
		private CheckBox checkBoxShowColumnOptions;
		private CheckBox checkBoxShowProgressStatus;
		private TextBox textBoxScheduleEndDate;
	}
}
