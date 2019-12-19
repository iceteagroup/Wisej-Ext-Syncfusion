namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejDateTimePicker
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
			this.ejDateTimePicker1 = new Wisej.Web.Ext.Syncfusion.ejDateTimePicker();
			this.textBoxDateTimeFormat = new Wisej.Web.TextBox();
			this.numericUpDownStartDay = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDay)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/datetimepicker/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdatetimepicker";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDownStartDay);
			this.groupBox1.Controls.Add(this.textBoxDateTimeFormat);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBoxDateTimeFormat, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDownStartDay, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDateTimePicker1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(539, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/datetimepicker/defaultfunctional" +
    "ities";
			// 
			// ejDateTimePicker1
			// 
			this.ejDateTimePicker1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejDateTimePicker1.Location = new System.Drawing.Point(126, 141);
			this.ejDateTimePicker1.Name = "ejDateTimePicker1";
			this.ejDateTimePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"2020-01-01 00:00:00\"}")));
			this.ejDateTimePicker1.Size = new System.Drawing.Size(200, 30);
			this.ejDateTimePicker1.Text = "ejDateTimePicker1";
			// 
			// textBox1
			// 
			this.textBoxDateTimeFormat.AutoSize = false;
			this.textBoxDateTimeFormat.Label.Size = 50;
			this.textBoxDateTimeFormat.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxDateTimeFormat.Label.Text = "Date Time Format";
			this.textBoxDateTimeFormat.Location = new System.Drawing.Point(28, 43);
			this.textBoxDateTimeFormat.Name = "textBox1";
			this.textBoxDateTimeFormat.Size = new System.Drawing.Size(195, 60);
			this.textBoxDateTimeFormat.TabIndex = 2;
			this.textBoxDateTimeFormat.Text = "M/d/yyyy h:mm tt";
			// 
			// numericUpDown1
			// 
			this.numericUpDownStartDay.AutoSize = false;
			this.numericUpDownStartDay.Label.Size = 50;
			this.numericUpDownStartDay.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownStartDay.Label.Text = "Start Day";
			this.numericUpDownStartDay.Location = new System.Drawing.Point(28, 138);
			this.numericUpDownStartDay.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.numericUpDownStartDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownStartDay.Name = "numericUpDown1";
			this.numericUpDownStartDay.Size = new System.Drawing.Size(195, 60);
			this.numericUpDownStartDay.TabIndex = 3;
			this.numericUpDownStartDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// ejDateTimePicker
			// 
			this.Name = "ejDateTimePicker";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartDay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDateTimePicker ejDateTimePicker1;
		private TextBox textBoxDateTimeFormat;
		private NumericUpDown numericUpDownStartDay;
	}
}
