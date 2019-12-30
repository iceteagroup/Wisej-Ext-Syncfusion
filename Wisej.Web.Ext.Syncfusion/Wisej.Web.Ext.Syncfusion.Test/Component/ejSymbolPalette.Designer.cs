namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSymbolPalette
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejSymbolPalette));
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			this.ejSymbolPalette1 = new Wisej.Web.Ext.Syncfusion.ejSymbolPalette();
			this.ejDiagram1 = new Wisej.Web.Ext.Syncfusion.ejDiagram();
			this.checkBoxShowPaletteItemName = new Wisej.Web.CheckBox();
			this.checkBoxAllowDrag = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/slider/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejslider";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxAllowDrag);
			this.groupBox1.Controls.Add(this.checkBoxShowPaletteItemName);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowPaletteItemName, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowDrag, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDiagram1);
			this.panel.Controls.Add(this.ejSymbolPalette1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(586, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/diagram/GettingStarted/SymbolPal" +
    "ette";
			// 
			// ejSymbolPalette1
			// 
			this.ejSymbolPalette1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
			this.ejSymbolPalette1.Location = new System.Drawing.Point(3, 3);
			this.ejSymbolPalette1.Name = "ejSymbolPalette1";
			this.ejSymbolPalette1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejSymbolPalette1.Options"))));
			this.ejSymbolPalette1.Size = new System.Drawing.Size(250, 307);
			this.ejSymbolPalette1.TabIndex = 2;
			this.ejSymbolPalette1.Text = "ejSymbolPalette1";
			widgetTemplate1.Id = "svgTemplate";
			widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
			this.ejSymbolPalette1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate[] {
        widgetTemplate1};
			// 
			// ejDiagram1
			// 
			this.ejDiagram1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejDiagram1.Location = new System.Drawing.Point(259, 3);
			this.ejDiagram1.Name = "ejDiagram1";
			this.ejDiagram1.Size = new System.Drawing.Size(191, 307);
			this.ejDiagram1.TabIndex = 1;
			this.ejDiagram1.Text = "ejDiagram1";
			this.ejDiagram1.Appear += new System.EventHandler(this.ejDiagram1_Appear);
			// 
			// checkBoxShowPaletteItemName
			// 
			this.checkBoxShowPaletteItemName.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowPaletteItemName.AutoSize = false;
			this.checkBoxShowPaletteItemName.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowPaletteItemName.Checked = true;
			this.checkBoxShowPaletteItemName.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowPaletteItemName.Location = new System.Drawing.Point(28, 47);
			this.checkBoxShowPaletteItemName.Name = "checkBoxShowPaletteItemName";
			this.checkBoxShowPaletteItemName.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShowPaletteItemName.TabIndex = 9;
			this.checkBoxShowPaletteItemName.Text = "Show Palette Item Text";
			// 
			// checkBoxAllowDrag
			// 
			this.checkBoxAllowDrag.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowDrag.AutoSize = false;
			this.checkBoxAllowDrag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowDrag.Checked = true;
			this.checkBoxAllowDrag.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxAllowDrag.Location = new System.Drawing.Point(28, 129);
			this.checkBoxAllowDrag.Name = "checkBoxAllowDrag";
			this.checkBoxAllowDrag.Size = new System.Drawing.Size(195, 38);
			this.checkBoxAllowDrag.TabIndex = 10;
			this.checkBoxAllowDrag.Text = "Allow Drag";
			// 
			// ejSymbolPalette
			// 
			this.Name = "ejSymbolPalette";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSymbolPalette ejSymbolPalette1;
		private Syncfusion.ejDiagram ejDiagram1;
		private CheckBox checkBoxShowPaletteItemName;
		private CheckBox checkBoxAllowDrag;
	}
}
