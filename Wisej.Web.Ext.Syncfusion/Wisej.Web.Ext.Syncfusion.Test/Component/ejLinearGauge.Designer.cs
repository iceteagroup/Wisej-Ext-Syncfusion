namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejLinearGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejLinearGauge));
			this.ejLinearGauge1 = new Wisej.Web.Ext.Syncfusion.ejLinearGauge();
			this.numericUpDownVal = new Wisej.Web.NumericUpDown();
			this.comboBoxOrientation = new Wisej.Web.ComboBox();
			this.comboBoxLabelPosition = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/lineargauge/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejlineargauge";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxLabelPosition);
			this.groupBox1.Controls.Add(this.comboBoxOrientation);
			this.groupBox1.Controls.Add(this.numericUpDownVal);
			this.groupBox1.Size = new System.Drawing.Size(250, 407);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDownVal, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxOrientation, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxLabelPosition, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 326);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejLinearGauge1);
			this.panel.Size = new System.Drawing.Size(455, 407);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(600, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/lineargauge/DefaultFunctionaliti" +
    "es";
			// 
			// ejLinearGauge1
			// 
			this.ejLinearGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejLinearGauge1.Location = new System.Drawing.Point(69, 17);
			this.ejLinearGauge1.Name = "ejLinearGauge1";
			this.ejLinearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejLinearGauge1.Options"))));
			this.ejLinearGauge1.Size = new System.Drawing.Size(314, 370);
			this.ejLinearGauge1.Text = "ejLinearGauge1";
			// 
			// numValue
			// 
			this.numericUpDownVal.AutoSize = false;
			this.numericUpDownVal.Label.Size = 50;
			this.numericUpDownVal.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownVal.Label.Text = "Value";
			this.numericUpDownVal.Location = new System.Drawing.Point(28, 48);
			this.numericUpDownVal.Name = "numValue";
			this.numericUpDownVal.Size = new System.Drawing.Size(195, 60);
			this.numericUpDownVal.TabIndex = 2;
			this.numericUpDownVal.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// cmbOrientation
			// 
			this.comboBoxOrientation.AutoSize = false;
			this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
			this.comboBoxOrientation.Label.Size = 50;
			this.comboBoxOrientation.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxOrientation.Label.Text = "Orientation";
			this.comboBoxOrientation.Location = new System.Drawing.Point(25, 137);
			this.comboBoxOrientation.Name = "cmbOrientation";
			this.comboBoxOrientation.Size = new System.Drawing.Size(200, 60);
			this.comboBoxOrientation.TabIndex = 3;
			this.comboBoxOrientation.Text = "Vertical";
			// 
			// cmbLabelPosition
			// 
			this.comboBoxLabelPosition.AutoSize = false;
			this.comboBoxLabelPosition.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxLabelPosition.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom"});
			this.comboBoxLabelPosition.Label.Size = 50;
			this.comboBoxLabelPosition.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxLabelPosition.Label.Text = "Outer Custom Label Position";
			this.comboBoxLabelPosition.Location = new System.Drawing.Point(23, 226);
			this.comboBoxLabelPosition.Name = "cmbLabelPosition";
			this.comboBoxLabelPosition.Size = new System.Drawing.Size(200, 60);
			this.comboBoxLabelPosition.TabIndex = 4;
			this.comboBoxLabelPosition.Text = "Bottom";
			// 
			// ejLinearGauge
			// 
			this.Name = "ejLinearGauge";
			this.Size = new System.Drawing.Size(864, 597);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejLinearGauge ejLinearGauge1;
		private NumericUpDown numericUpDownVal;
		private ComboBox comboBoxOrientation;
		private ComboBox comboBoxLabelPosition;
	}
}
