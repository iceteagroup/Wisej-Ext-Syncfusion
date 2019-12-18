namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSignature
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
			this.ejSignature1 = new Wisej.Web.Ext.Syncfusion.ejSignature();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/signature/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsignature";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejSignature1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(616, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/signature/DefaultFunctionalities" +
    "";
			// 
			// ejSignature1
			// 
			this.ejSignature1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejSignature1.Location = new System.Drawing.Point(17, 23);
			this.ejSignature1.Name = "ejSignature1";
			this.ejSignature1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"strokeWidth\":3}")));
			this.ejSignature1.Size = new System.Drawing.Size(418, 266);
			this.ejSignature1.Text = "ejSignature1";
			this.ejSignature1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejSignature1_WidgetEvent);
			// 
			// ejSignature
			// 
			this.Name = "ejSignature";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSignature ejSignature1;
	}
}
