namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSparkline
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
			this.ejSparkline1 = new Wisej.Web.Ext.Syncfusion.ejSparkline();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/sparkline/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsparkline";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejSparkline1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(583, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/sparkline/DefaultFunctionalities" +
    "";
			// 
			// ejSparkline1
			// 
			this.ejSparkline1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejSparkline1.Location = new System.Drawing.Point(139, 69);
			this.ejSparkline1.Name = "ejSparkline1";
			this.ejSparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"dataSource\":[2,6,-1,1,12,5,-2,7,-3,5,8,10],\"negativePointCo" +
        "lor\":\"red\",\"highPointColor\":\"blue\",\"tooltip\":{\"visible\":true,\"font\":{\"size\":\"12p" +
        "x\"}},\"type\":\"column\"}")));
			this.ejSparkline1.Size = new System.Drawing.Size(175, 175);
			this.ejSparkline1.TabIndex = 1;
			this.ejSparkline1.Text = "ejSparkline1";
			// 
			// ejSparkline
			// 
			this.Name = "ejSparkline";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSparkline ejSparkline1;
	}
}
