namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejKanban
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejKanban));
			this.ejKanban1 = new Wisej.Web.Ext.Syncfusion.ejKanban();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonGetVisibleColumnNames = new Wisej.Web.Button();
			this.checkBoxAllowDragAndDrop = new Wisej.Web.CheckBox();
			this.comboBoxSelectionType = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/kanban/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejkanban";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxSelectionType);
			this.groupBox1.Controls.Add(this.checkBoxAllowDragAndDrop);
			this.groupBox1.Controls.Add(this.buttonGetVisibleColumnNames);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Size = new System.Drawing.Size(250, 365);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonGetVisibleColumnNames, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowDragAndDrop, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxSelectionType, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 284);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejKanban1);
			this.panel.Size = new System.Drawing.Size(455, 365);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(574, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/kanban/Columns/HeaderTemplate";
			// 
			// ejKanban1
			// 
			this.ejKanban1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejKanban1.Location = new System.Drawing.Point(18, 18);
			this.ejKanban1.Name = "ejKanban1";
			this.ejKanban1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejKanban1.Options"))));
			this.ejKanban1.Size = new System.Drawing.Size(416, 327);
			this.ejKanban1.Text = "ejKanban1";
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 221);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 221);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 8;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonGetVisibleColumnNames
			// 
			this.buttonGetVisibleColumnNames.Location = new System.Drawing.Point(28, 42);
			this.buttonGetVisibleColumnNames.Name = "buttonGetVisibleColumnNames";
			this.buttonGetVisibleColumnNames.Size = new System.Drawing.Size(195, 30);
			this.buttonGetVisibleColumnNames.TabIndex = 9;
			this.buttonGetVisibleColumnNames.Text = "Get Visible Column Names";
			this.buttonGetVisibleColumnNames.Click += new System.EventHandler(this.buttonGetVisibleColumnNames_Click);
			// 
			// checkBoxAllowDragAndDrop
			// 
			this.checkBoxAllowDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowDragAndDrop.AutoSize = false;
			this.checkBoxAllowDragAndDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowDragAndDrop.Checked = true;
			this.checkBoxAllowDragAndDrop.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxAllowDragAndDrop.Location = new System.Drawing.Point(28, 89);
			this.checkBoxAllowDragAndDrop.Name = "checkBoxAllowDragAndDrop";
			this.checkBoxAllowDragAndDrop.Size = new System.Drawing.Size(195, 38);
			this.checkBoxAllowDragAndDrop.TabIndex = 12;
			this.checkBoxAllowDragAndDrop.Text = "Allow Drag and Drop";
			// 
			// comboBoxOrientation
			// 
			this.comboBoxSelectionType.AutoSize = false;
			this.comboBoxSelectionType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxSelectionType.Items.AddRange(new object[] {
            "Single",
            "Multiple"});
			this.comboBoxSelectionType.Label.Size = 50;
			this.comboBoxSelectionType.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxSelectionType.Label.Text = "Selection Type";
			this.comboBoxSelectionType.Location = new System.Drawing.Point(28, 144);
			this.comboBoxSelectionType.Name = "comboBoxOrientation";
			this.comboBoxSelectionType.Size = new System.Drawing.Size(195, 60);
			this.comboBoxSelectionType.TabIndex = 13;
			this.comboBoxSelectionType.Text = "Single";
			// 
			// ejKanban
			// 
			this.Name = "ejKanban";
			this.Size = new System.Drawing.Size(864, 555);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejKanban ejKanban1;
		private Upload buttonLoad;
		private Button buttonSave;
		private Button buttonGetVisibleColumnNames;
		private CheckBox checkBoxAllowDragAndDrop;
		private ComboBox comboBoxSelectionType;
	}
}
