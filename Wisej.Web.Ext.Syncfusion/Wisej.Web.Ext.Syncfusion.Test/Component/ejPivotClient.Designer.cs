namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPivotClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotClient));
			this.ejPivotClient1 = new Wisej.Web.Ext.Syncfusion.ejPivotClient();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivotclient/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpivotclient";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotClient1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(639, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/pivotclient/Relational/DefaultFu" +
    "nctionalities";
			// 
			// ejPivotClient1
			// 
			this.ejPivotClient1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPivotClient1.Location = new System.Drawing.Point(12, 14);
			this.ejPivotClient1.Name = "ejPivotClient1";
			this.ejPivotClient1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotClient1.Options"))));
			this.ejPivotClient1.Size = new System.Drawing.Size(429, 284);
			this.ejPivotClient1.Text = "ejPivotClient1";
			// 
			// ejPivotClient
			// 
			this.Name = "ejPivotClient";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotClient ejPivotClient1;
	}
}
