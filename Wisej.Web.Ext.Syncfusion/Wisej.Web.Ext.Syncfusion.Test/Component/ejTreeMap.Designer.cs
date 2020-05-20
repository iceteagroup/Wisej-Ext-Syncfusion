namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejTreeMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTreeMap));
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate4 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate5 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate6 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			this.ejTreeMap1 = new Wisej.Web.Ext.Syncfusion.ejTreeMap();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/treemap/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtreemap#members";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Size = new System.Drawing.Size(250, 433);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 348);
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeMap1);
			this.panel.Size = new System.Drawing.Size(455, 433);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/treemap/FlatCollection";
			// 
			// ejTreeMap1
			// 
			this.ejTreeMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejTreeMap1.CssStyle = "\r\n.e-treemap-leaflabel {\r\n    color: black;\r\n}";
			this.ejTreeMap1.Location = new System.Drawing.Point(19, 18);
			this.ejTreeMap1.Name = "ejTreeMap1";
			this.ejTreeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeMap1.Options"))));
			this.ejTreeMap1.Size = new System.Drawing.Size(415, 394);
			this.ejTreeMap1.TabIndex = 0;
			this.ejTreeMap1.Text = "ejTreeMap1";
			widgetTemplate4.Id = "headertemplate";
			widgetTemplate4.Template = "<div style=\"margin-top:3px;\">\r\n    <label style=\"color:gray;font-size:16px;font-w" +
    "eight:normal;margin-left:5px;\" id=\"Label1\">{{:header}}</label><br />\r\n</div>";
			widgetTemplate4.Type = "application/jsrender";
			widgetTemplate5.Id = "labeltemplate";
			widgetTemplate5.Template = "<div style=\"background-color: transparent;\">\r\n    <label style=\"color:black;font-" +
    "size:large;font-weight:normal;\" >{{:Country}}</label><br />\r\n</div> ";
			widgetTemplate5.Type = "application/jsrender";
			widgetTemplate6.Id = "template";
			widgetTemplate6.Template = resources.GetString("widgetTemplate6.Template");
			widgetTemplate6.Type = "application/jsrender";
			this.ejTreeMap1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate[] {
        widgetTemplate4,
        widgetTemplate5,
        widgetTemplate6};
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 36);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 30);
			this.checkBox2.TabIndex = 0;
			this.checkBox2.Text = "Enable Gradient";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 99);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 30);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.Text = "Highlight on Selection";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "squarified",
            "sliceanddicehorizontal",
            "sliceanddicevertical",
            "sliceanddiceauto"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Items Layout Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 162);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Squarified";
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "default",
            "multiple"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Group Selection Mode";
			this.comboBox2.Location = new System.Drawing.Point(28, 255);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 60);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.Text = "default";
			// 
			// ejTreeMap
			// 
			this.Name = "ejTreeMap";
			this.Size = new System.Drawing.Size(864, 623);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeMap ejTreeMap1;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
	}
}
