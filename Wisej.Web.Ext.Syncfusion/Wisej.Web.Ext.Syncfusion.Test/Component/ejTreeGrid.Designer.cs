namespace Wisej.Web.Ext.Syncfusion.Test
{
	partial class ejTreeGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTreeGrid));
			this.ejTreeGrid1 = new Wisej.Web.Ext.Syncfusion.ejTreeGrid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/treegrid/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtreegrid";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeGrid1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(592, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/treegrid/DefaultFunctionalities";
			// 
			// ejTreeGrid1
			// 
			this.ejTreeGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejTreeGrid1.Location = new System.Drawing.Point(32, 28);
			this.ejTreeGrid1.Name = "ejTreeGrid1";
			this.ejTreeGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeGrid1.Options"))));
			this.ejTreeGrid1.Size = new System.Drawing.Size(389, 257);
			this.ejTreeGrid1.Text = "ejTreeGrid1";
			// 
			// ejTreeGrid
			// 
			this.Name = "ejTreeGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeGrid ejTreeGrid1;
	}
}
