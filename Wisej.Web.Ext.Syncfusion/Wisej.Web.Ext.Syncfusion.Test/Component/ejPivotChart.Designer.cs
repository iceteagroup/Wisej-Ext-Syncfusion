namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPivotChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotChart));
			this.ejPivotChart1 = new Wisej.Web.Ext.Syncfusion.ejPivotChart();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportExcel = new Wisej.Web.Button();
			this.buttonSaveJson = new Wisej.Web.Button();
			this.checkBoxEnable3D = new Wisej.Web.CheckBox();
			this.numericUpDownRotation = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivotchart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpivotchart";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDownRotation);
			this.groupBox1.Controls.Add(this.checkBoxEnable3D);
			this.groupBox1.Controls.Add(this.buttonSaveJson);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportExcel);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportExcel, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSaveJson, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnable3D, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDownRotation, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotChart1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/knockout/PivotChart";
			// 
			// ejPivotChart1
			// 
			this.ejPivotChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejPivotChart1.Location = new System.Drawing.Point(28, 17);
			this.ejPivotChart1.Name = "ejPivotChart1";
			this.ejPivotChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotChart1.Options"))));
			this.ejPivotChart1.Size = new System.Drawing.Size(396, 278);
			this.ejPivotChart1.Text = "ejPivotChart1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".xlsx";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 167);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 11;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportExcel
			// 
			this.buttonExportExcel.Display = Wisej.Web.Display.Icon;
			this.buttonExportExcel.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
			this.buttonExportExcel.Location = new System.Drawing.Point(76, 167);
			this.buttonExportExcel.Name = "buttonExportExcel";
			this.buttonExportExcel.Size = new System.Drawing.Size(42, 42);
			this.buttonExportExcel.TabIndex = 10;
			this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
			// 
			// buttonSaveJson
			// 
			this.buttonSaveJson.Display = Wisej.Web.Display.Icon;
			this.buttonSaveJson.ImageSource = "icon-save";
			this.buttonSaveJson.Location = new System.Drawing.Point(124, 167);
			this.buttonSaveJson.Name = "buttonSaveJson";
			this.buttonSaveJson.Size = new System.Drawing.Size(42, 42);
			this.buttonSaveJson.TabIndex = 12;
			this.buttonSaveJson.Click += new System.EventHandler(this.buttonSaveJson_Click);
			// 
			// checkBoxEnable3D
			// 
			this.checkBoxEnable3D.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnable3D.AutoSize = false;
			this.checkBoxEnable3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnable3D.Location = new System.Drawing.Point(28, 36);
			this.checkBoxEnable3D.Name = "checkBoxEnable3D";
			this.checkBoxEnable3D.Size = new System.Drawing.Size(195, 38);
			this.checkBoxEnable3D.TabIndex = 13;
			this.checkBoxEnable3D.Text = "Enable 3D";
			// 
			// numericUpDownRotation
			// 
			this.numericUpDownRotation.AutoSize = false;
			this.numericUpDownRotation.Label.Size = 50;
			this.numericUpDownRotation.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownRotation.Label.Text = "Rotation";
			this.numericUpDownRotation.Location = new System.Drawing.Point(28, 80);
			this.numericUpDownRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDownRotation.Name = "numericUpDownRotation";
			this.numericUpDownRotation.Size = new System.Drawing.Size(195, 60);
			this.numericUpDownRotation.TabIndex = 14;
			// 
			// ejPivotChart
			// 
			this.Name = "ejPivotChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotChart ejPivotChart1;
		private Upload buttonLoad;
		private Button buttonExportExcel;
		private Button buttonSaveJson;
		private CheckBox checkBoxEnable3D;
		private NumericUpDown numericUpDownRotation;
	}
}
