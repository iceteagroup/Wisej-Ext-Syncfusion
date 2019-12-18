namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejListBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejListBox));
			this.ejListBox1 = new Wisej.Web.Ext.Syncfusion.ejListBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/listbox/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejlistbox";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejListBox1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(543, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/listbox/DefaultFunctionalities";
			// 
			// ejListBox1
			// 
			this.ejListBox1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejListBox1.Location = new System.Drawing.Point(139, 68);
			this.ejListBox1.Name = "ejListBox1";
			this.ejListBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejListBox1.Options"))));
			this.ejListBox1.Size = new System.Drawing.Size(175, 176);
			this.ejListBox1.Text = "ejListBox1";
			// 
			// ejListBox
			// 
			this.Name = "ejListBox";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejListBox ejListBox1;
	}
}
