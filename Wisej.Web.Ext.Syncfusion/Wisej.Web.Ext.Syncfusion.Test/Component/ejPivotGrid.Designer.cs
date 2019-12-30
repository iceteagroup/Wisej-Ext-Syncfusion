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
			this.checkBoxCellClick = new Wisej.Web.CheckBox();
			this.checkBoxShowRowHeaderItems = new Wisej.Web.CheckBox();
			this.checkBoxColumnGrandTotal = new Wisej.Web.CheckBox();
			this.checkBoxShowColumnHeaderItems = new Wisej.Web.CheckBox();
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
			this.groupBox1.Controls.Add(this.checkBoxShowColumnHeaderItems);
			this.groupBox1.Controls.Add(this.checkBoxColumnGrandTotal);
			this.groupBox1.Controls.Add(this.checkBoxShowRowHeaderItems);
			this.groupBox1.Controls.Add(this.checkBoxCellClick);
			this.groupBox1.Size = new System.Drawing.Size(250, 429);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxCellClick, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowRowHeaderItems, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxColumnGrandTotal, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowColumnHeaderItems, 0);
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
			this.ejPivotGrid1.Text = "ejPivotGrid1";
			// 
			// checkBoxCellClick
			// 
			this.checkBoxCellClick.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxCellClick.AutoSize = false;
			this.checkBoxCellClick.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxCellClick.Checked = true;
			this.checkBoxCellClick.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxCellClick.Location = new System.Drawing.Point(28, 38);
			this.checkBoxCellClick.Name = "checkBoxCellClick";
			this.checkBoxCellClick.Size = new System.Drawing.Size(195, 38);
			this.checkBoxCellClick.TabIndex = 8;
			this.checkBoxCellClick.Text = "Enable Cell Click";
			// 
			// checkBoxShowRowHeaderItems
			// 
			this.checkBoxShowRowHeaderItems.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowRowHeaderItems.AutoSize = false;
			this.checkBoxShowRowHeaderItems.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowRowHeaderItems.Checked = true;
			this.checkBoxShowRowHeaderItems.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowRowHeaderItems.Location = new System.Drawing.Point(28, 99);
			this.checkBoxShowRowHeaderItems.Name = "checkBoxShowRowHeaderItems";
			this.checkBoxShowRowHeaderItems.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShowRowHeaderItems.TabIndex = 9;
			this.checkBoxShowRowHeaderItems.Text = "Show Header Row Items";
			// 
			// checkBoxColumnGrandTotal
			// 
			this.checkBoxColumnGrandTotal.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxColumnGrandTotal.AutoSize = false;
			this.checkBoxColumnGrandTotal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxColumnGrandTotal.Checked = true;
			this.checkBoxColumnGrandTotal.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxColumnGrandTotal.Location = new System.Drawing.Point(28, 221);
			this.checkBoxColumnGrandTotal.Name = "checkBoxColumnGrandTotal";
			this.checkBoxColumnGrandTotal.Size = new System.Drawing.Size(195, 38);
			this.checkBoxColumnGrandTotal.TabIndex = 10;
			this.checkBoxColumnGrandTotal.Text = "Column Grand Total";
			// 
			// checkBoxShowColumnHeaderItems
			// 
			this.checkBoxShowColumnHeaderItems.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowColumnHeaderItems.AutoSize = false;
			this.checkBoxShowColumnHeaderItems.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowColumnHeaderItems.Checked = true;
			this.checkBoxShowColumnHeaderItems.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowColumnHeaderItems.Location = new System.Drawing.Point(28, 160);
			this.checkBoxShowColumnHeaderItems.Name = "checkBoxShowColumnHeaderItems";
			this.checkBoxShowColumnHeaderItems.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShowColumnHeaderItems.TabIndex = 11;
			this.checkBoxShowColumnHeaderItems.Text = "Show Header Row Items";
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
		private CheckBox checkBoxShowColumnHeaderItems;
		private CheckBox checkBoxColumnGrandTotal;
		private CheckBox checkBoxShowRowHeaderItems;
		private CheckBox checkBoxCellClick;
		private Button buttonSave;
		private Upload buttonLoad;
	}
}
