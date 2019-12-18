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
			this.textBox1 = new Wisej.Web.TextBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
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
			this.textBox1.AutoSize = false;
			this.textBox1.Label.Size = 50;
			this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBox1.Label.Text = "Date Time Format";
			this.textBox1.Location = new System.Drawing.Point(28, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 60);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "M/d/yyyy h:mm tt";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.Label.Text = "Start Day";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 138);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
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
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDateTimePicker ejDateTimePicker1;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
	}
}
