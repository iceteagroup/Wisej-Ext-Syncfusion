namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejFileExplorer
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
			this.ejFileExplorer1 = new Wisej.Web.Ext.Syncfusion.ejFileExplorer();
			this.checkBoxShowToolbar = new Wisej.Web.CheckBox();
			this.checkBoxShowFooter = new Wisej.Web.CheckBox();
			this.comboBoxLayout = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/fileexplorer/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejfileexplorer";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxLayout);
			this.groupBox1.Controls.Add(this.checkBoxShowToolbar);
			this.groupBox1.Controls.Add(this.checkBoxShowFooter);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowFooter, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowToolbar, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxLayout, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejFileExplorer1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(536, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/fileexplorer/DefaultFunctionalit" +
    "ies";
			// 
			// ejFileExplorer1
			// 
			this.ejFileExplorer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejFileExplorer1.Location = new System.Drawing.Point(26, 21);
			this.ejFileExplorer1.Name = "ejFileExplorer1";
			this.ejFileExplorer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"showFooter\":true,\"showToolbar\":true,\"layout\":\"tile\",\"path\":\"/\"}")));
			this.ejFileExplorer1.Size = new System.Drawing.Size(400, 270);
			this.ejFileExplorer1.TabIndex = 0;
			this.ejFileExplorer1.Text = "ejFileExplorer1";
			this.ejFileExplorer1.WebRequest += new Wisej.Web.WebRequestHandler(this.ejFileExplorer1_WebRequest);
			// 
			// checkBoxShowToolbar
			// 
			this.checkBoxShowToolbar.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowToolbar.AutoSize = false;
			this.checkBoxShowToolbar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowToolbar.Checked = true;
			this.checkBoxShowToolbar.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowToolbar.Location = new System.Drawing.Point(28, 63);
			this.checkBoxShowToolbar.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBoxShowToolbar.Name = "checkBoxShowToolbar";
			this.checkBoxShowToolbar.Size = new System.Drawing.Size(195, 22);
			this.checkBoxShowToolbar.TabIndex = 6;
			this.checkBoxShowToolbar.Text = "Show Toolbar";
			// 
			// checkBoxShowFooter
			// 
			this.checkBoxShowFooter.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowFooter.AutoSize = false;
			this.checkBoxShowFooter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowFooter.Checked = true;
			this.checkBoxShowFooter.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowFooter.Location = new System.Drawing.Point(28, 28);
			this.checkBoxShowFooter.Name = "checkBoxShowFooter";
			this.checkBoxShowFooter.Size = new System.Drawing.Size(195, 22);
			this.checkBoxShowFooter.TabIndex = 5;
			this.checkBoxShowFooter.Text = "Show Footer";
			// 
			// comboBoxLayout
			// 
			this.comboBoxLayout.AutoSize = false;
			this.comboBoxLayout.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxLayout.Items.AddRange(new object[] {
            "Tile",
            "Grid",
            "LargeIcons"});
			this.comboBoxLayout.Label.Size = 50;
			this.comboBoxLayout.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxLayout.LabelText = "Layout";
			this.comboBoxLayout.Location = new System.Drawing.Point(28, 104);
			this.comboBoxLayout.Name = "comboBoxLayout";
			this.comboBoxLayout.Size = new System.Drawing.Size(195, 60);
			this.comboBoxLayout.TabIndex = 7;
			this.comboBoxLayout.Text = "Tile";
			// 
			// ejFileExplorer
			// 
			this.Name = "ejFileExplorer";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejFileExplorer ejFileExplorer1;
		private ComboBox comboBoxLayout;
		private CheckBox checkBoxShowToolbar;
		private CheckBox checkBoxShowFooter;
	}
}
