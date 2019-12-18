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
			this.textBox1 = new Wisej.Web.TextBox();
			this.textBox2 = new Wisej.Web.TextBox();
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
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDateRangePicker1);
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
			this.ejDateRangePicker1.Location = new System.Drawing.Point(126, 141);
			this.ejDateRangePicker1.Name = "ejDateRangePicker1";
			this.ejDateRangePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"1/1/2020 - 1/15/2020\"}")));
			this.ejDateRangePicker1.Size = new System.Drawing.Size(200, 30);
			this.ejDateRangePicker1.Text = "ejDateRangePicker1";
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBox1.Label.Size = 50;
			this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBox1.Label.Text = "Start Date";
			this.textBox1.Location = new System.Drawing.Point(28, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 60);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "2020-01-01";
			this.textBox1.Watermark = "Select date...";
			// 
			// textBox2
			// 
			this.textBox2.AutoSize = false;
			this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBox2.Label.Size = 50;
			this.textBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBox2.Label.Text = "End Date";
			this.textBox2.Location = new System.Drawing.Point(28, 127);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(195, 60);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "2020-01-15";
			this.textBox2.Watermark = "Select date...";
			// 
			// ejDateRangePicker
			// 
			this.Name = "ejDateRangePicker";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDateRangePicker ejDateRangePicker1;
		private TextBox textBox2;
		private TextBox textBox1;
	}
}
