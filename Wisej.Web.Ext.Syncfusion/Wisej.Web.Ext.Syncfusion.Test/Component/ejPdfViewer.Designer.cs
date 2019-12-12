namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPdfViewer
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
			this.ejPdfViewer1 = new Wisej.Web.Ext.Syncfusion.ejPdfViewer();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPdfViewer1);
			// 
			// ejPdfViewer1
			// 
			this.ejPdfViewer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPdfViewer1.Location = new System.Drawing.Point(29, 28);
			this.ejPdfViewer1.Name = "ejPdfViewer1";
			this.ejPdfViewer1.Size = new System.Drawing.Size(395, 257);
			this.ejPdfViewer1.Text = "ejPdfViewer1";
			this.ejPdfViewer1.WebRequest += new Wisej.Web.WebRequestHandler(this.ejPdfViewer1_WebRequest);
			// 
			// ejPdfViewer
			// 
			this.Name = "ejPdfViewer";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPdfViewer ejPdfViewer1;
	}
}
