namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejTreeView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTreeView));
			this.ejTreeView1 = new Wisej.Web.Ext.Syncfusion.ejTreeView();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeView1);
			// 
			// ejTreeView1
			// 
			this.ejTreeView1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejTreeView1.Location = new System.Drawing.Point(164, 44);
			this.ejTreeView1.Name = "ejTreeView1";
			this.ejTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeView1.Options"))));
			this.ejTreeView1.Size = new System.Drawing.Size(124, 225);
			this.ejTreeView1.Text = "ejTreeView1";
			// 
			// ejTreeView
			// 
			this.Name = "ejTreeView";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeView ejTreeView1;
	}
}
