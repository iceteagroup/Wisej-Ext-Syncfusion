namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejListView));
			this.ejListView1 = new Wisej.Web.Ext.Syncfusion.ejListView();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/listview/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejlistview";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejListView1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(532, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/listview/DefaultFunctionalities";
			// 
			// ejListView1
			// 
			this.ejListView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejListView1.Location = new System.Drawing.Point(139, 69);
			this.ejListView1.Name = "ejListView1";
			this.ejListView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejListView1.Options"))));
			this.ejListView1.Size = new System.Drawing.Size(175, 175);
			this.ejListView1.Text = "ejListView1";
			// 
			// ejListView
			// 
			this.Name = "ejListView";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejListView ejListView1;
	}
}
