namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPivotTreeMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotTreeMap));
			this.ejPivotTreeMap1 = new Wisej.Web.Ext.Syncfusion.ejPivotTreeMap();
			this.label4 = new Wisej.Web.Label();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivottreemap/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpivottreemap";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotTreeMap1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(545, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/pivottreemap/DefaultFunctionalit" +
    "ies";
			// 
			// ejPivotTreeMap1
			// 
			this.ejPivotTreeMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPivotTreeMap1.Location = new System.Drawing.Point(14, 14);
			this.ejPivotTreeMap1.Name = "ejPivotTreeMap1";
			this.ejPivotTreeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotTreeMap1.Options"))));
			this.ejPivotTreeMap1.Size = new System.Drawing.Size(424, 285);
			this.ejPivotTreeMap1.Text = "ejPivotTreeMap1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(382, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(332, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Note: Issue with hover and has an external datasource";
			// 
			// ejPivotTreeMap
			// 
			this.Controls.Add(this.label4);
			this.Name = "ejPivotTreeMap";
			this.Controls.SetChildIndex(this.linkDocs, 0);
			this.Controls.SetChildIndex(this.linkAPI, 0);
			this.Controls.SetChildIndex(this.linkDemo, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.panel, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotTreeMap ejPivotTreeMap1;
		private Label label4;
	}
}
