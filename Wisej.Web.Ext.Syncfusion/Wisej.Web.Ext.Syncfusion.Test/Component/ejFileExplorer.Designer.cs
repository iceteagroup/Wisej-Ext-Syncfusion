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
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.checkBox5 = new Wisej.Web.CheckBox();
			this.checkBox6 = new Wisej.Web.CheckBox();
			this.checkBox7 = new Wisej.Web.CheckBox();
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
			this.groupBox1.Controls.Add(this.checkBox7);
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 598);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox6, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox7, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 507);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejFileExplorer1);
			this.panel.Size = new System.Drawing.Size(455, 598);
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
			this.ejFileExplorer1.Size = new System.Drawing.Size(400, 553);
			this.ejFileExplorer1.TabIndex = 0;
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
			this.checkBox2.Location = new System.Drawing.Point(28, 92);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 30);
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
			this.checkBox1.Location = new System.Drawing.Point(28, 37);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 30);
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
			this.comboBox1.LabelText = "Layout";
			this.comboBox1.Location = new System.Drawing.Point(28, 422);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.Text = "Tile";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(28, 147);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 30);
			this.checkBox3.TabIndex = 8;
			this.checkBox3.Text = "Allow Keyboard Navigation";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox4.Location = new System.Drawing.Point(28, 202);
			this.checkBox4.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 30);
			this.checkBox4.TabIndex = 9;
			this.checkBox4.Text = "Allow Multi Selection";
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox5.Location = new System.Drawing.Point(28, 257);
			this.checkBox5.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(195, 30);
			this.checkBox5.TabIndex = 10;
			this.checkBox5.Text = "Show Checkbox";
			// 
			// checkBox6
			// 
			this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox6.AutoSize = false;
			this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox6.Checked = true;
			this.checkBox6.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox6.Location = new System.Drawing.Point(28, 312);
			this.checkBox6.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(195, 30);
			this.checkBox6.TabIndex = 11;
			this.checkBox6.Text = "Show Context Menu";
			// 
			// checkBox7
			// 
			this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox7.AutoSize = false;
			this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox7.Checked = true;
			this.checkBox7.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox7.Location = new System.Drawing.Point(28, 367);
			this.checkBox7.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(195, 30);
			this.checkBox7.TabIndex = 12;
			this.checkBox7.Text = "Show Thumbnail";
			// 
			// ejFileExplorer
			// 
			this.Name = "ejFileExplorer";
			this.Size = new System.Drawing.Size(864, 788);
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
		private CheckBox checkBox7;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
	}
}
