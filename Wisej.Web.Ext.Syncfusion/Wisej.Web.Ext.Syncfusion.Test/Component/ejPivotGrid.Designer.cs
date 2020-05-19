namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPivotGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotGrid));
			this.ejPivotGrid1 = new Wisej.Web.Ext.Syncfusion.ejPivotGrid();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.checkBoxShow3 = new Wisej.Web.CheckBox();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonLoad = new Wisej.Web.Upload();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivotgrid/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpivotgrid";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.checkBoxShow3);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 429);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShow3, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 348);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotGrid1);
			this.panel.Size = new System.Drawing.Size(455, 429);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(566, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/pivotgrid/relational/defaultfunc" +
    "tionalities";
			// 
			// ejPivotGrid1
			// 
			this.ejPivotGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPivotGrid1.Location = new System.Drawing.Point(19, 16);
			this.ejPivotGrid1.Name = "ejPivotGrid1";
			this.ejPivotGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotGrid1.Options"))));
			this.ejPivotGrid1.Size = new System.Drawing.Size(415, 395);
			this.ejPivotGrid1.TabIndex = 0;
			this.ejPivotGrid1.Text = "ejPivotGrid1";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Enable Cell Click";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 99);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 9;
			this.checkBox2.Text = "Show Header Row Items";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox4.Location = new System.Drawing.Point(28, 221);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 10;
			this.checkBox4.Text = "Column Grand Total";
			// 
			// checkBoxShow3
			// 
			this.checkBoxShow3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShow3.AutoSize = false;
			this.checkBoxShow3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShow3.Checked = true;
			this.checkBoxShow3.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShow3.Location = new System.Drawing.Point(28, 160);
			this.checkBoxShow3.Name = "checkBoxShow3";
			this.checkBoxShow3.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShow3.TabIndex = 11;
			this.checkBoxShow3.Text = "Show Header Row Items";
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 282);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 15;
			this.buttonSave.Visible = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 282);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 14;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// ejPivotGrid
			// 
			this.Name = "ejPivotGrid";
			this.Size = new System.Drawing.Size(864, 619);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotGrid ejPivotGrid1;
		private CheckBox checkBoxShow3;
		private CheckBox checkBox4;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Button buttonSave;
		private Upload buttonLoad;
	}
}
