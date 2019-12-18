namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSunburstChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejSunburstChart));
			this.ejSunburstChart1 = new Wisej.Web.Ext.Syncfusion.ejSunburstChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/sunburstchart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsunburstchart";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejSunburstChart1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(488, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/sunburst/Default";
			// 
			// ejSunburstChart1
			// 
			this.ejSunburstChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejSunburstChart1.Location = new System.Drawing.Point(34, 28);
			this.ejSunburstChart1.Name = "ejSunburstChart1";
			this.ejSunburstChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejSunburstChart1.Options"))));
			this.ejSunburstChart1.Size = new System.Drawing.Size(385, 257);
			this.ejSunburstChart1.Text = "ejSunburstChart1";
			// 
			// ejSunburstChart
			// 
			this.Name = "ejSunburstChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSunburstChart ejSunburstChart1;
	}
}
