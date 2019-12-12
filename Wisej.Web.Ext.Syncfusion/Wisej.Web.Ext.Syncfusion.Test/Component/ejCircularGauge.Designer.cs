namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejCircularGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejCircularGauge));
			this.ejCircularGauge1 = new Wisej.Web.Ext.Syncfusion.ejCircularGauge();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.trackBar1 = new Wisej.Web.TrackBar();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.trackBar2 = new Wisej.Web.TrackBar();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/circulargauge/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejcirculargauge";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.trackBar2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Size = new System.Drawing.Size(250, 472);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.trackBar1, 0);
			this.groupBox1.Controls.SetChildIndex(this.label4, 0);
			this.groupBox1.Controls.SetChildIndex(this.trackBar2, 0);
			this.groupBox1.Controls.SetChildIndex(this.label5, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 391);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejCircularGauge1);
			this.panel.Size = new System.Drawing.Size(455, 472);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(509, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/radialgauge/defaultfunctionaliti" +
    "es";
			// 
			// ejCircularGauge1
			// 
			this.ejCircularGauge1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejCircularGauge1.Location = new System.Drawing.Point(79, 91);
			this.ejCircularGauge1.Name = "ejCircularGauge1";
			this.ejCircularGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejCircularGauge1.Options"))));
			this.ejCircularGauge1.Size = new System.Drawing.Size(296, 290);
			this.ejCircularGauge1.Text = "ejCircularGauge1";
			this.ejCircularGauge1.Value = 50;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.Label.Text = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 41);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(28, 146);
			this.trackBar1.Maximum = 0;
			this.trackBar1.Minimum = -30;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(195, 36);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.Value = -30;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Range Distance";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 214);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Range Size";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(28, 236);
			this.trackBar2.Maximum = 12;
			this.trackBar2.Minimum = 2;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(195, 36);
			this.trackBar2.TabIndex = 4;
			this.trackBar2.Value = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = ((Wisej.Web.CheckState)(Wisej.Web.CheckState.Checked));
			this.checkBox1.Location = new System.Drawing.Point(28, 309);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(183, 38);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Show Ticks";
			// 
			// ejCircularGauge
			// 
			this.Name = "ejCircularGauge";
			this.Size = new System.Drawing.Size(864, 662);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejCircularGauge ejCircularGauge1;
		private NumericUpDown numericUpDown1;
		private Label label4;
		private TrackBar trackBar1;
		private Label label5;
		private TrackBar trackBar2;
		private CheckBox checkBox1;
	}
}
