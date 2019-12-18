namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejGrid));
			this.ejGrid1 = new Wisej.Web.Ext.Syncfusion.ejGrid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/grid/getting-started";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejgrid";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejGrid1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(547, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/grid/DefaultFunctionalities";
			// 
			// ejGrid1
			// 
			this.ejGrid1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejGrid1.Location = new System.Drawing.Point(3, 3);
			this.ejGrid1.Name = "ejGrid1";
			this.ejGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejGrid1.Options"))));
			this.ejGrid1.Size = new System.Drawing.Size(447, 307);
			this.ejGrid1.Text = "ejGrid1";
			// 
			// ejGrid
			// 
			this.Name = "ejGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejGrid ejGrid1;
	}
}
