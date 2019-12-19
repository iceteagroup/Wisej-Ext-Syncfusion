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
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.label4 = new Wisej.Web.Label();
			this.trackBar1 = new Wisej.Web.TrackBar();
			this.buttonLoad = new Wisej.Web.Upload();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pdfviewer/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpdfviewer";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 350);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.trackBar1, 0);
			this.groupBox1.Controls.SetChildIndex(this.label4, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 269);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPdfViewer1);
			this.panel.Size = new System.Drawing.Size(455, 379);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/pdf/GettingStarted";
			// 
			// ejPdfViewer1
			// 
			this.ejPdfViewer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPdfViewer1.Location = new System.Drawing.Point(29, 28);
			this.ejPdfViewer1.Name = "ejPdfViewer1";
			this.ejPdfViewer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"enableHighlightAnnotation\":true,\"enableTextMarkupAnnotations\":true,\"enableStrik" +
        "ethroughAnnotation\":true,\"enableSignature\":false}")));
			this.ejPdfViewer1.Size = new System.Drawing.Size(395, 321);
			this.ejPdfViewer1.Text = "ejPdfViewer1";
			this.ejPdfViewer1.Initialized += new System.EventHandler(this.ejPdfViewer1_Initialized);
			this.ejPdfViewer1.WebRequest += new Wisej.Web.WebRequestHandler(this.ejPdfViewer1_WebRequest);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 29);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 31);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Enable Markup";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 66);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 31);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "Enable Signature";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Zoom (50-400%)";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(28, 135);
			this.trackBar1.Maximum = 400;
			this.trackBar1.Minimum = 50;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(195, 36);
			this.trackBar1.TabIndex = 4;
			this.trackBar1.TickFrequency = 25;
			this.trackBar1.Value = 100;
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".pdf";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 189);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 7;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// ejPdfViewer
			// 
			this.Name = "ejPdfViewer";
			this.Size = new System.Drawing.Size(864, 569);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPdfViewer ejPdfViewer1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Label label4;
		private TrackBar trackBar1;
		private Upload buttonLoad;
	}
}
