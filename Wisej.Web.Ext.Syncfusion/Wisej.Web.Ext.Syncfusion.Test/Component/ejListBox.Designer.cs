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
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonSave = new Wisej.Web.Button();
			this.comboBoxVirtualScrollMode = new Wisej.Web.ComboBox();
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxVirtualScrollMode);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Size = new System.Drawing.Size(250, 326);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxVirtualScrollMode, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 245);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejListBox1);
			this.panel.Size = new System.Drawing.Size(455, 326);
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
			this.ejListBox1.Location = new System.Drawing.Point(98, 16);
			this.ejListBox1.Name = "ejListBox1";
			this.ejListBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejListBox1.Options"))));
			this.ejListBox1.Size = new System.Drawing.Size(257, 291);
			this.ejListBox1.Text = "ejListBox1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 182);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 12;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 182);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 11;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// comboBoxVirtualScrollMode
			// 
			this.comboBoxVirtualScrollMode.AutoSize = false;
			this.comboBoxVirtualScrollMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxVirtualScrollMode.Items.AddRange(new object[] {
            "Continuous",
            "Normal"});
			this.comboBoxVirtualScrollMode.Label.Size = 50;
			this.comboBoxVirtualScrollMode.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxVirtualScrollMode.Label.Text = "Virtual Scroll Mode";
			this.comboBoxVirtualScrollMode.Location = new System.Drawing.Point(28, 41);
			this.comboBoxVirtualScrollMode.Name = "comboBoxVirtualScrollMode";
			this.comboBoxVirtualScrollMode.Size = new System.Drawing.Size(195, 60);
			this.comboBoxVirtualScrollMode.TabIndex = 13;
			this.comboBoxVirtualScrollMode.Text = "Normal";
			// 
			// ejListBox
			// 
			this.Name = "ejListBox";
			this.Size = new System.Drawing.Size(864, 516);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejListBox ejListBox1;
		private Upload buttonLoad;
		private Button buttonSave;
		private ComboBox comboBoxVirtualScrollMode;
	}
}
