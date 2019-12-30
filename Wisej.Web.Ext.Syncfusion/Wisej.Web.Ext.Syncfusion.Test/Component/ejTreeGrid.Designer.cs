namespace Wisej.Web.Ext.Syncfusion.Test
{
	partial class ejTreeGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTreeGrid));
			this.ejTreeGrid1 = new Wisej.Web.Ext.Syncfusion.ejTreeGrid();
			this.checkBoxAllowTextWrap = new Wisej.Web.CheckBox();
			this.checkBoxAllowSelection = new Wisej.Web.CheckBox();
			this.buttonGetSelectedCells = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/treegrid/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtreegrid";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonGetSelectedCells);
			this.groupBox1.Controls.Add(this.checkBoxAllowSelection);
			this.groupBox1.Controls.Add(this.checkBoxAllowTextWrap);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowTextWrap, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowSelection, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonGetSelectedCells, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeGrid1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(592, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/treegrid/DefaultFunctionalities";
			// 
			// ejTreeGrid1
			// 
			this.ejTreeGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejTreeGrid1.Location = new System.Drawing.Point(19, 18);
			this.ejTreeGrid1.Name = "ejTreeGrid1";
			this.ejTreeGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeGrid1.Options"))));
			this.ejTreeGrid1.Size = new System.Drawing.Size(415, 276);
			this.ejTreeGrid1.Text = "ejTreeGrid1";
			// 
			// checkBoxAllowTextWrap
			// 
			this.checkBoxAllowTextWrap.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowTextWrap.AutoSize = false;
			this.checkBoxAllowTextWrap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowTextWrap.Location = new System.Drawing.Point(28, 35);
			this.checkBoxAllowTextWrap.Name = "checkBoxAllowTextWrap";
			this.checkBoxAllowTextWrap.Size = new System.Drawing.Size(195, 22);
			this.checkBoxAllowTextWrap.TabIndex = 8;
			this.checkBoxAllowTextWrap.Text = "Allow TextWrap";
			// 
			// checkBoxAllowSelection
			// 
			this.checkBoxAllowSelection.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowSelection.AutoSize = false;
			this.checkBoxAllowSelection.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowSelection.Checked = true;
			this.checkBoxAllowSelection.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxAllowSelection.Location = new System.Drawing.Point(28, 89);
			this.checkBoxAllowSelection.Name = "checkBoxAllowSelection";
			this.checkBoxAllowSelection.Size = new System.Drawing.Size(195, 22);
			this.checkBoxAllowSelection.TabIndex = 9;
			this.checkBoxAllowSelection.Text = "Allow Selection";
			// 
			// buttonGetSelectedCells
			// 
			this.buttonGetSelectedCells.Location = new System.Drawing.Point(28, 142);
			this.buttonGetSelectedCells.Name = "buttonGetSelectedCells";
			this.buttonGetSelectedCells.Size = new System.Drawing.Size(195, 30);
			this.buttonGetSelectedCells.TabIndex = 10;
			this.buttonGetSelectedCells.Text = "Get Selected Cells";
			this.buttonGetSelectedCells.Click += new System.EventHandler(this.buttonGetSelectedCells_Click);
			// 
			// ejTreeGrid
			// 
			this.Name = "ejTreeGrid";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeGrid ejTreeGrid1;
		private CheckBox checkBoxAllowTextWrap;
		private CheckBox checkBoxAllowSelection;
		private Button buttonGetSelectedCells;
	}
}
