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
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
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
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
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
			this.ejFileExplorer1.Location = new System.Drawing.Point(51, 47);
			this.ejFileExplorer1.Name = "ejFileExplorer1";
			this.ejFileExplorer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"showFooter\":true,\"showToolbar\":true,\"layout\":\"tile\",\"path\":\"/\"}")));
			this.ejFileExplorer1.Size = new System.Drawing.Size(358, 224);
			this.ejFileExplorer1.Text = "ejFileExplorer1";
			this.ejFileExplorer1.WebRequest += new Wisej.Web.WebRequestHandler(this.ejFileExplorer1_WebRequest);
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 63);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 22);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "Show Toolbar";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 28);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 22);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Show Footer";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Tile",
            "Grid",
            "LargeIcons"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.Label.Text = "Layout";
			this.comboBox1.Location = new System.Drawing.Point(28, 104);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.Text = "Tile";
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
		private ComboBox comboBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
