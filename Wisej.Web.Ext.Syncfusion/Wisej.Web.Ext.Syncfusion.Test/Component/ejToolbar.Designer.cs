namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejToolbar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejToolbar));
			this.ejToolbar1 = new Wisej.Web.Ext.Syncfusion.ejToolbar();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/toolbar/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtoolbar";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejToolbar1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(617, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/toolbar/defaultfunctionalities";
			// 
			// ejToolbar1
			// 
			this.ejToolbar1.CssStyle = resources.GetString("ejToolbar1.CssStyle");
			this.ejToolbar1.Location = new System.Drawing.Point(43, 26);
			this.ejToolbar1.Name = "ejToolbar1";
			this.ejToolbar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"width\":\"auto\",\"height\":\"33px\"}")));
			this.ejToolbar1.Size = new System.Drawing.Size(366, 259);
			this.ejToolbar1.Text = "ejToolbar1";
			// 
			// ejToolbar
			// 
			this.Name = "ejToolbar";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejToolbar ejToolbar1;
	}
}
