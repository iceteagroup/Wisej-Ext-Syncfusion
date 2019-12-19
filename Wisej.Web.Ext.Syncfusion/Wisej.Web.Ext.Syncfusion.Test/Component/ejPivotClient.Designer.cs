namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPivotClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotClient));
			this.comboBoxChartType = new Wisej.Web.ComboBox();
			this.checkBoxEnableCellClick = new Wisej.Web.CheckBox();
			this.checkBoxEnableSplitter = new Wisej.Web.CheckBox();
			this.ejPivotClient1 = new Wisej.Web.Ext.Syncfusion.ejPivotClient();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivotclient/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpivotclient";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxEnableSplitter);
			this.groupBox1.Controls.Add(this.checkBoxEnableCellClick);
			this.groupBox1.Controls.Add(this.comboBoxChartType);
			this.groupBox1.Size = new System.Drawing.Size(250, 396);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxChartType, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableCellClick, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableSplitter, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 315);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotClient1);
			this.panel.Size = new System.Drawing.Size(455, 396);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(639, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/pivotclient/Relational/DefaultFu" +
    "nctionalities";
			// 
			// comboBoxChartType
			// 
			this.comboBoxChartType.AutoSize = false;
			this.comboBoxChartType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxChartType.Items.AddRange(new object[] {
            "Line",
            "Spline",
            "Column",
            "Area",
            "SplineArea",
            "StepLine",
            "StepArea",
            "Pie",
            "Bar",
            "StackingArea",
            "StackingColumn",
            "StackingBar",
            "Pyramid",
            "Funnel",
            "Doughnut",
            "Scatter",
            "Bubble"});
			this.comboBoxChartType.Label.Size = 50;
			this.comboBoxChartType.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxChartType.Label.Text = "Chart Type";
			this.comboBoxChartType.Location = new System.Drawing.Point(28, 43);
			this.comboBoxChartType.Name = "comboBoxChartType";
			this.comboBoxChartType.Size = new System.Drawing.Size(195, 60);
			this.comboBoxChartType.TabIndex = 3;
			this.comboBoxChartType.Text = "Line";
			// 
			// checkBoxEnableCellClick
			// 
			this.checkBoxEnableCellClick.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnableCellClick.AutoSize = false;
			this.checkBoxEnableCellClick.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnableCellClick.Checked = true;
			this.checkBoxEnableCellClick.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxEnableCellClick.Location = new System.Drawing.Point(28, 139);
			this.checkBoxEnableCellClick.Name = "checkBoxEnableCellClick";
			this.checkBoxEnableCellClick.Size = new System.Drawing.Size(195, 38);
			this.checkBoxEnableCellClick.TabIndex = 7;
			this.checkBoxEnableCellClick.Text = "Enable Cell Click";
			// 
			// checkBoxEnableSplitter
			// 
			this.checkBoxEnableSplitter.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnableSplitter.AutoSize = false;
			this.checkBoxEnableSplitter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnableSplitter.Checked = true;
			this.checkBoxEnableSplitter.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxEnableSplitter.Location = new System.Drawing.Point(28, 211);
			this.checkBoxEnableSplitter.Name = "checkBoxEnableSplitter";
			this.checkBoxEnableSplitter.Size = new System.Drawing.Size(195, 38);
			this.checkBoxEnableSplitter.TabIndex = 8;
			this.checkBoxEnableSplitter.Text = "Enable Splitter";
			// 
			// ejPivotClient1
			// 
			this.ejPivotClient1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPivotClient1.Location = new System.Drawing.Point(12, 14);
			this.ejPivotClient1.Name = "ejPivotClient1";
			this.ejPivotClient1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotClient1.Options"))));
			this.ejPivotClient1.Size = new System.Drawing.Size(429, 365);
			this.ejPivotClient1.Text = "ejPivotClient1";
			// 
			// ejPivotClient
			// 
			this.Name = "ejPivotClient";
			this.Size = new System.Drawing.Size(864, 586);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotClient ejPivotClient1;
		private ComboBox comboBoxChartType;
		private CheckBox checkBoxEnableCellClick;
		private CheckBox checkBoxEnableSplitter;
	}
}
