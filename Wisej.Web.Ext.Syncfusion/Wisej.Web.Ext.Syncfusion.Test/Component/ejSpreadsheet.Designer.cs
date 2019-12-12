namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSpreadsheet
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
			this.ejSpreadsheet1 = new Wisej.Web.Ext.Syncfusion.ejSpreadsheet();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonSave = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/spreadsheet/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejspreadsheet";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejSpreadsheet1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(558, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/spreadsheet/defaultfunctionaliti" +
    "es";
			// 
			// ejSpreadsheet1
			// 
			this.ejSpreadsheet1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejSpreadsheet1.Location = new System.Drawing.Point(26, 26);
			this.ejSpreadsheet1.Name = "ejSpreadsheet1";
			this.ejSpreadsheet1.Size = new System.Drawing.Size(401, 261);
			this.ejSpreadsheet1.Text = "ejSpreadsheet1";
			this.ejSpreadsheet1.WebRequest += new Wisej.Web.WebRequestHandler(this.ejSpreadsheet1_WebRequest);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 27);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 22);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Show Ribbon";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 64);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 22);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "Allow Editing";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".xlsx";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 114);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 9;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 114);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 8;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// ejSpreadsheet
			// 
			this.Name = "ejSpreadsheet";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSpreadsheet ejSpreadsheet1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Upload buttonLoad;
		private Button buttonSave;
	}
}
