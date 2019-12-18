namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejHeatMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejHeatMap));
			this.ejHeatMap1 = new Wisej.Web.Ext.Syncfusion.ejHeatMap();
			this.ejHeatMapLegend1 = new Wisej.Web.Ext.Syncfusion.ejHeatMapLegend();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/heatmap/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejheatmap";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejHeatMapLegend1);
			this.panel.Controls.Add(this.ejHeatMap1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/heatmap/celldatabinding";
			// 
			// ejHeatMap1
			// 
			this.ejHeatMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejHeatMap1.Location = new System.Drawing.Point(22, 20);
			this.ejHeatMap1.Name = "ejHeatMap1";
			this.ejHeatMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejHeatMap1.Options"))));
			this.ejHeatMap1.Size = new System.Drawing.Size(409, 233);
			this.ejHeatMap1.TabIndex = 2;
			this.ejHeatMap1.Text = "ejHeatMap1";
			// 
			// ejHeatMapLegend1
			// 
			this.ejHeatMapLegend1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejHeatMapLegend1.Location = new System.Drawing.Point(22, 259);
			this.ejHeatMapLegend1.Name = "ejHeatMapLegend1";
			this.ejHeatMapLegend1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"colorMappingCollection\":[{\"value\":0,\"color\":\"#8ec8f8\",\"label\":{\"text\":\"0\"}},{\"v" +
        "alue\":100,\"color\":\"#0d47a1\",\"label\":{\"text\":\"100\"}}],\"isResponsive\":true}")));
			this.ejHeatMapLegend1.Size = new System.Drawing.Size(409, 37);
			this.ejHeatMapLegend1.TabIndex = 1;
			this.ejHeatMapLegend1.Text = "ejHeatMapLegend1";
			// 
			// ejHeatMap
			// 
			this.Name = "ejHeatMap";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejHeatMap ejHeatMap1;
		private ejHeatMapLegend ejHeatMapLegend1;
	}
}
