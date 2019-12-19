namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejDropDownTree
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejDropDownTree));
			this.ejDropDownTree1 = new Wisej.Web.Ext.Syncfusion.ejDropDownTree();
			this.checkBoxShowCheckbox = new Wisej.Web.CheckBox();
			this.checkBoxEnableFilterSearch = new Wisej.Web.CheckBox();
			this.numericUpDownPopupHeight = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopupHeight)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/dropdowntree/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdropdowntree";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDownPopupHeight);
			this.groupBox1.Controls.Add(this.checkBoxEnableFilterSearch);
			this.groupBox1.Controls.Add(this.checkBoxShowCheckbox);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowCheckbox, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableFilterSearch, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDownPopupHeight, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDropDownTree1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(553, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/dropdowntree/DefaultFunctionalit" +
    "ies";
			// 
			// ejDropDownTree1
			// 
			this.ejDropDownTree1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejDropDownTree1.Location = new System.Drawing.Point(126, 141);
			this.ejDropDownTree1.Name = "ejDropDownTree1";
			this.ejDropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownTree1.Options"))));
			this.ejDropDownTree1.Size = new System.Drawing.Size(200, 30);
			this.ejDropDownTree1.Text = "ejDropDownTree1";
			// 
			// checkBox1
			// 
			this.checkBoxShowCheckbox.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowCheckbox.AutoSize = false;
			this.checkBoxShowCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowCheckbox.Checked = true;
			this.checkBoxShowCheckbox.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowCheckbox.Location = new System.Drawing.Point(28, 36);
			this.checkBoxShowCheckbox.Name = "checkBox1";
			this.checkBoxShowCheckbox.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShowCheckbox.TabIndex = 7;
			this.checkBoxShowCheckbox.Text = "Multi-Select";
			// 
			// checkBox2
			// 
			this.checkBoxEnableFilterSearch.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnableFilterSearch.AutoSize = false;
			this.checkBoxEnableFilterSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnableFilterSearch.Checked = true;
			this.checkBoxEnableFilterSearch.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxEnableFilterSearch.Location = new System.Drawing.Point(28, 94);
			this.checkBoxEnableFilterSearch.Name = "checkBox2";
			this.checkBoxEnableFilterSearch.Size = new System.Drawing.Size(195, 38);
			this.checkBoxEnableFilterSearch.TabIndex = 8;
			this.checkBoxEnableFilterSearch.Text = "Enable Filter Search";
			// 
			// numericUpDown1
			// 
			this.numericUpDownPopupHeight.AutoSize = false;
			this.numericUpDownPopupHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownPopupHeight.Label.Size = 50;
			this.numericUpDownPopupHeight.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownPopupHeight.Label.Text = "Popup Height";
			this.numericUpDownPopupHeight.Location = new System.Drawing.Point(28, 142);
			this.numericUpDownPopupHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDownPopupHeight.Name = "numericUpDown1";
			this.numericUpDownPopupHeight.Size = new System.Drawing.Size(195, 60);
			this.numericUpDownPopupHeight.TabIndex = 9;
			this.numericUpDownPopupHeight.Value = new decimal(new int[] {
            152,
            0,
            0,
            0});
			// 
			// ejDropDownTree
			// 
			this.Name = "ejDropDownTree";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopupHeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDropDownTree ejDropDownTree1;
		private CheckBox checkBoxShowCheckbox;
		private CheckBox checkBoxEnableFilterSearch;
		private NumericUpDown numericUpDownPopupHeight;
	}
}
