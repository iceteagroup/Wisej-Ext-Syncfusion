namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejChart));
			this.ejChart1 = new Wisej.Web.Ext.Syncfusion.ejChart();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.textBox1 = new Wisej.Web.TextBox();
			this.buttonPrint = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejchart";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.buttonPrint);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 382);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonPrint, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 301);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejChart1);
			this.panel.Size = new System.Drawing.Size(455, 448);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/chart/line";
			// 
			// ejChart1
			// 
			this.ejChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejChart1.Location = new System.Drawing.Point(54, 39);
			this.ejChart1.Name = "ejChart1";
			this.ejChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejChart1.Options"))));
			this.ejChart1.Size = new System.Drawing.Size(345, 367);
			this.ejChart1.Text = "ejChart1";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Center",
            "Near",
            "Far"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.Label.Text = "Legend Alignment";
			this.comboBox1.Location = new System.Drawing.Point(25, 44);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "Center";
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.Label.Size = 50;
			this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBox1.Label.Text = "Chart Title";
			this.textBox1.Location = new System.Drawing.Point(25, 124);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 60);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Efficiency of oil-fired power production";
			// 
			// buttonPrint
			// 
			this.buttonPrint.Display = Wisej.Web.Display.Icon;
			this.buttonPrint.ImageSource = "icon-print";
			this.buttonPrint.Location = new System.Drawing.Point(28, 219);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(42, 42);
			this.buttonPrint.TabIndex = 9;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 219);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// ejChart
			// 
			this.Name = "ejChart";
			this.Size = new System.Drawing.Size(864, 638);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejChart ejChart1;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private Button buttonSave;
		private Button buttonPrint;
	}
}
