namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejGrid));
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonSave = new Wisej.Web.Button();
			this.ejGrid1 = new Wisej.Web.Ext.Syncfusion.ejGrid();
			this.checkBoxAllowEditing = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/grid/getting-started";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejgrid";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxAllowEditing);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowEditing, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejGrid1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(547, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/grid/DefaultFunctionalities";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 159);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 10;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 159);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// ejGrid1
			// 
			this.ejGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejGrid1.Location = new System.Drawing.Point(3, 3);
			this.ejGrid1.Name = "ejGrid1";
			this.ejGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejGrid1.Options"))));
			this.ejGrid1.Size = new System.Drawing.Size(447, 307);
			this.ejGrid1.Text = "ejGrid1";
			// 
			// checkBox1
			// 
			this.checkBoxAllowEditing.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowEditing.AutoSize = false;
			this.checkBoxAllowEditing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowEditing.Checked = true;
			this.checkBoxAllowEditing.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxAllowEditing.Location = new System.Drawing.Point(28, 53);
			this.checkBoxAllowEditing.Name = "checkBox1";
			this.checkBoxAllowEditing.Size = new System.Drawing.Size(195, 38);
			this.checkBoxAllowEditing.TabIndex = 11;
			this.checkBoxAllowEditing.Text = "Editable";
			// 
			// ejGrid
			// 
			this.Name = "ejGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejGrid ejGrid1;
		private Upload buttonLoad;
		private Button buttonSave;
		private CheckBox checkBoxAllowEditing;
	}
}
