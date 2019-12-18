namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejGantt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejGantt));
			this.ejGantt1 = new Wisej.Web.Ext.Syncfusion.ejGantt();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/gantt/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejgantt";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejGantt1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(576, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/gantt/Sorting/DefaultFunctionali" +
    "ties";
			// 
			// ejGantt1
			// 
			this.ejGantt1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejGantt1.Location = new System.Drawing.Point(3, 3);
			this.ejGantt1.Name = "ejGantt1";
			this.ejGantt1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejGantt1.Options"))));
			this.ejGantt1.Size = new System.Drawing.Size(447, 307);
			this.ejGantt1.Text = "ejGantt1";
			// 
			// ejGantt
			// 
			this.Name = "ejGantt";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejGantt ejGantt1;
	}
}
