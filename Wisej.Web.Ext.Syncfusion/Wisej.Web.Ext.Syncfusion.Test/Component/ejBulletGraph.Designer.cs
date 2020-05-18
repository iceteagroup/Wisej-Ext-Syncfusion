namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejBulletGraph
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejBulletGraph));
			this.ejBulletGraph1 = new Wisej.Web.Ext.Syncfusion.ejBulletGraph();
			this.ejBulletGraph2 = new Wisej.Web.Ext.Syncfusion.ejBulletGraph();
			this.numericUpDownVal = new Wisej.Web.NumericUpDown();
			this.numericUpDownCompMeasureVal = new Wisej.Web.NumericUpDown();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompMeasureVal)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/bulletgraph/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejbulletgraph";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.numericUpDownCompMeasureVal);
			this.groupBox1.Controls.Add(this.numericUpDownVal);
			this.groupBox1.Size = new System.Drawing.Size(250, 395);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDownVal, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDownCompMeasureVal, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 314);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejBulletGraph2);
			this.panel.Controls.Add(this.ejBulletGraph1);
			this.panel.Size = new System.Drawing.Size(666, 395);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(516, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/bulletgraph/DefaultFunctionaliti" +
    "es";
			// 
			// ejBulletGraph1
			// 
			this.ejBulletGraph1.Location = new System.Drawing.Point(34, 48);
			this.ejBulletGraph1.Name = "ejBulletGraph1";
			this.ejBulletGraph1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejBulletGraph1.Options"))));
			this.ejBulletGraph1.Size = new System.Drawing.Size(596, 83);
			this.ejBulletGraph1.TabIndex = 5;
			this.ejBulletGraph1.Text = "ejBulletGraph1";
			// 
			// ejBulletGraph2
			// 
			this.ejBulletGraph2.Location = new System.Drawing.Point(29, 182);
			this.ejBulletGraph2.Name = "ejBulletGraph2";
			this.ejBulletGraph2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejBulletGraph2.Options"))));
			this.ejBulletGraph2.Size = new System.Drawing.Size(606, 83);
			this.ejBulletGraph2.TabIndex = 2;
			this.ejBulletGraph2.Text = "ejBulletGraph2";
			// 
			// numericUpDownVal
			// 
			this.numericUpDownVal.AutoSize = false;
			this.numericUpDownVal.LabelText = "Revenue Value";
			this.numericUpDownVal.Location = new System.Drawing.Point(28, 109);
			this.numericUpDownVal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownVal.Name = "numericUpDownVal";
			this.numericUpDownVal.Size = new System.Drawing.Size(195, 41);
			this.numericUpDownVal.TabIndex = 2;
			this.numericUpDownVal.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// numericUpDownCompMeasureVal
			// 
			this.numericUpDownCompMeasureVal.AutoSize = false;
			this.numericUpDownCompMeasureVal.LabelText = "Revenue Comparative Value";
			this.numericUpDownCompMeasureVal.Location = new System.Drawing.Point(28, 187);
			this.numericUpDownCompMeasureVal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownCompMeasureVal.Name = "numericUpDownCompMeasureVal";
			this.numericUpDownCompMeasureVal.Size = new System.Drawing.Size(195, 41);
			this.numericUpDownCompMeasureVal.TabIndex = 3;
			this.numericUpDownCompMeasureVal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Forward",
            "Backward"});
			this.comboBox1.LabelText = "Flow Direction";
			this.comboBox1.Location = new System.Drawing.Point(28, 264);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 4;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 49);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 31);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Apply Range Stroke to Labels";
			// 
			// ejBulletGraph
			// 
			this.Name = "ejBulletGraph";
			this.Size = new System.Drawing.Size(1075, 585);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompMeasureVal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejBulletGraph ejBulletGraph1;
		private Syncfusion.ejBulletGraph ejBulletGraph2;
		private NumericUpDown numericUpDownVal;
		private NumericUpDown numericUpDownCompMeasureVal;
		private ComboBox comboBox1;
		private CheckBox checkBox1;
	}
}
