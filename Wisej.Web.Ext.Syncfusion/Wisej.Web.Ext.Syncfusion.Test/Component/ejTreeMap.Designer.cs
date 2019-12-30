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
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate2 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate3 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			this.ejTreeMap1 = new Wisej.Web.Ext.Syncfusion.ejTreeMap();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/treemap/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtreemap#members";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeMap1);
			// 
			// linkDemo
			// 
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
			this.ejTreeMap1.Size = new System.Drawing.Size(415, 276);
			this.ejTreeMap1.Text = "ejTreeMap1";
			widgetTemplate1.Id = "headertemplate";
			widgetTemplate1.Template = "<div style=\"margin-top:3px;\">\r\n            <label style=\"color:gray;font-size:16p" +
    "x;font-weight:normal;margin-left:5px;\" id=\"Label1\">{{:header}}</label><br />    " +
    "        \r\n      </div>";
			widgetTemplate1.Type = "application/jsrender";
			widgetTemplate2.Id = "labeltemplate";
			widgetTemplate2.Template = "<div style=\"background-color: transparent;\">\r\n            <label style=\"color:bla" +
    "ck;font-size:large;font-weight:normal;\" >{{:Country}}</label><br />            \r" +
    "\n        </div> ";
			widgetTemplate2.Type = "application/jsrender";
			widgetTemplate3.Id = "template";
			widgetTemplate3.Template = resources.GetString("widgetTemplate3.Template");
			widgetTemplate3.Type = "application/jsrender";
			this.ejTreeMap1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate[] {
        widgetTemplate1,
        widgetTemplate2,
        widgetTemplate3};
			// 
			// ejTreeMap
			// 
			this.Name = "ejTreeMap";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeMap ejTreeMap1;
	}
}
