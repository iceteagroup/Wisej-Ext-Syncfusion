namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejDropDownTree
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejDropDownTree));
			this.ejDropDownTree1 = new Wisej.Web.Ext.Syncfusion.ejDropDownTree();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/dropdowntree/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdropdowntree";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDropDownTree1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(553, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/dropdowntree/DefaultFunctionalit" +
    "ies";
			// 
			// ejDropDownTree1
			// 
			this.ejDropDownTree1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejDropDownTree1.Location = new System.Drawing.Point(126, 141);
			this.ejDropDownTree1.Name = "ejDropDownTree1";
			this.ejDropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownTree1.Options"))));
			this.ejDropDownTree1.Size = new System.Drawing.Size(200, 30);
			this.ejDropDownTree1.Text = "ejDropDownTree1";
			// 
			// ejDropDownTree
			// 
			this.Name = "ejDropDownTree";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDropDownTree ejDropDownTree1;
	}
}
