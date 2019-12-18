namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejTagCloud
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTagCloud));
			this.ejTagCloud1 = new Wisej.Web.Ext.Syncfusion.ejTagCloud();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/tagcloud/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtagcloud";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTagCloud1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(524, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/tagcloud/DefaultFunctionalities";
			// 
			// ejTagCloud1
			// 
			this.ejTagCloud1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejTagCloud1.Location = new System.Drawing.Point(26, 19);
			this.ejTagCloud1.Name = "ejTagCloud1";
			this.ejTagCloud1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTagCloud1.Options"))));
			this.ejTagCloud1.Size = new System.Drawing.Size(400, 275);
			this.ejTagCloud1.Text = "ejTagCloud1";
			// 
			// ejTagCloud
			// 
			this.Name = "ejTagCloud";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTagCloud ejTagCloud1;
	}
}
