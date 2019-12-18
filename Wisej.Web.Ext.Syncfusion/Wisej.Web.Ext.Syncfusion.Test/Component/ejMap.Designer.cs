namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejMap));
			this.ejMap1 = new Wisej.Web.Ext.Syncfusion.ejMap();
			this.label4 = new Wisej.Web.Label();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejMap1);
			// 
			// ejMap1
			// 
			this.ejMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejMap1.Location = new System.Drawing.Point(17, 15);
			this.ejMap1.Name = "ejMap1";
			this.ejMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejMap1.Options"))));
			this.ejMap1.Size = new System.Drawing.Size(418, 283);
			this.ejMap1.Text = "ejMap1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(314, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(508, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "NOTE: This seems like a pretty complicated control... might be better to just rem" +
    "ove.";
			// 
			// ejMap
			// 
			this.Controls.Add(this.label4);
			this.Name = "ejMap";
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

		private Syncfusion.ejMap ejMap1;
		private Label label4;
	}
}
