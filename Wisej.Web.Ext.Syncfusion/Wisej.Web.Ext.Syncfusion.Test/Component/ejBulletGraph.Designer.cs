namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejBulletGraph
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejBulletGraph));
			this.ejBulletGraph1 = new Wisej.Web.Ext.Syncfusion.ejBulletGraph();
			this.ejBulletGraph2 = new Wisej.Web.Ext.Syncfusion.ejBulletGraph();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/bulletgraph/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejbulletgraph";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejBulletGraph2);
			this.panel.Controls.Add(this.ejBulletGraph1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(516, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/bulletgraph/DefaultFunctionaliti" +
    "es";
			// 
			// ejBulletGraph1
			// 
			this.ejBulletGraph1.Location = new System.Drawing.Point(27, 48);
			this.ejBulletGraph1.Name = "ejBulletGraph1";
			this.ejBulletGraph1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejBulletGraph1.Options"))));
			this.ejBulletGraph1.Size = new System.Drawing.Size(398, 83);
			this.ejBulletGraph1.TabIndex = 5;
			this.ejBulletGraph1.Text = "ejBulletGraph1";
			// 
			// ejBulletGraph2
			// 
			this.ejBulletGraph2.Location = new System.Drawing.Point(27, 182);
			this.ejBulletGraph2.Name = "ejBulletGraph2";
			this.ejBulletGraph2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejBulletGraph2.Options"))));
			this.ejBulletGraph2.Size = new System.Drawing.Size(398, 83);
			this.ejBulletGraph2.TabIndex = 2;
			this.ejBulletGraph2.Text = "ejBulletGraph2";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.Label.Text = "Revenue Value";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 49);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.AutoSize = false;
			this.numericUpDown2.Label.Size = 50;
			this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown2.Label.Text = "Revenue Comparative Value";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 127);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 60);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// ejBulletGraph
			// 
			this.Name = "ejBulletGraph";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejBulletGraph ejBulletGraph1;
		private Syncfusion.ejBulletGraph ejBulletGraph2;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
	}
}
