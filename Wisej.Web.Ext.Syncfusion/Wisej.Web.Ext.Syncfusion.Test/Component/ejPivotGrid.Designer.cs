namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPivotGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotGrid));
			this.ejPivotGrid1 = new Wisej.Web.Ext.Syncfusion.ejPivotGrid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivotgrid/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpivotgrid";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotGrid1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(566, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/pivotgrid/relational/defaultfunc" +
    "tionalities";
			// 
			// ejPivotGrid1
			// 
			this.ejPivotGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPivotGrid1.Location = new System.Drawing.Point(19, 16);
			this.ejPivotGrid1.Name = "ejPivotGrid1";
			this.ejPivotGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotGrid1.Options"))));
			this.ejPivotGrid1.Size = new System.Drawing.Size(415, 281);
			this.ejPivotGrid1.Text = "ejPivotGrid1";
			// 
			// ejPivotGrid
			// 
			this.Name = "ejPivotGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotGrid ejPivotGrid1;
	}
}
