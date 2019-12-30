namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSparkline
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
			this.ejSparkline1 = new Wisej.Web.Ext.Syncfusion.ejSparkline();
			this.comboBoxChartType = new Wisej.Web.ComboBox();
			this.checkBoxCanvasRendering = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/sparkline/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsparkline";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxCanvasRendering);
			this.groupBox1.Controls.Add(this.comboBoxChartType);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxChartType, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxCanvasRendering, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejSparkline1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(583, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/sparkline/DefaultFunctionalities" +
    "";
			// 
			// ejSparkline1
			// 
			this.ejSparkline1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejSparkline1.Location = new System.Drawing.Point(36, 33);
			this.ejSparkline1.Name = "ejSparkline1";
			this.ejSparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"dataSource\":[2,6,-1,1,12,5,-2,7,-3,5,8,10],\"negativePointCo" +
        "lor\":\"red\",\"highPointColor\":\"blue\",\"tooltip\":{\"visible\":true,\"font\":{\"size\":\"12p" +
        "x\"}},\"type\":\"column\"}")));
			this.ejSparkline1.Size = new System.Drawing.Size(380, 247);
			this.ejSparkline1.TabIndex = 1;
			this.ejSparkline1.Text = "ejSparkline1";
			// 
			// comboBoxChartType
			// 
			this.comboBoxChartType.AutoSize = false;
			this.comboBoxChartType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxChartType.Items.AddRange(new object[] {
            "Line",
            "WinLoss",
            "Column",
            "Area"});
			this.comboBoxChartType.Label.Size = 50;
			this.comboBoxChartType.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxChartType.Label.Text = "Chart Type";
			this.comboBoxChartType.Location = new System.Drawing.Point(28, 34);
			this.comboBoxChartType.Name = "comboBoxChartType";
			this.comboBoxChartType.Size = new System.Drawing.Size(195, 60);
			this.comboBoxChartType.TabIndex = 4;
			this.comboBoxChartType.Text = "Line";
			// 
			// checkBoxCanvasRendering
			// 
			this.checkBoxCanvasRendering.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxCanvasRendering.AutoSize = false;
			this.checkBoxCanvasRendering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxCanvasRendering.Checked = true;
			this.checkBoxCanvasRendering.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxCanvasRendering.Location = new System.Drawing.Point(28, 140);
			this.checkBoxCanvasRendering.Name = "checkBoxCanvasRendering";
			this.checkBoxCanvasRendering.Size = new System.Drawing.Size(195, 38);
			this.checkBoxCanvasRendering.TabIndex = 7;
			this.checkBoxCanvasRendering.Text = "Canvas Rendering";
			// 
			// ejSparkline
			// 
			this.Name = "ejSparkline";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSparkline ejSparkline1;
		private ComboBox comboBoxChartType;
		private CheckBox checkBoxCanvasRendering;
	}
}
