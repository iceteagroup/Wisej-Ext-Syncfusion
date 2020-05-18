namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSlider
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
			this.panel1 = new Wisej.Web.Panel();
			this.label4 = new Wisej.Web.Label();
			this.ejSlider1 = new Wisej.Web.Ext.Syncfusion.ejSlider();
			this.panel2 = new Wisej.Web.Panel();
			this.label5 = new Wisej.Web.Label();
			this.ejSlider2 = new Wisej.Web.Ext.Syncfusion.ejSlider();
			this.label6 = new Wisej.Web.Label();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Size = new System.Drawing.Size(250, 427);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.label6, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 342);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.panel2);
			this.panel.Controls.Add(this.panel1);
			this.panel.Size = new System.Drawing.Size(455, 427);
			this.panel.Text = "x";
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(606, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/slider/DefaultFunctionalities";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ejSlider1);
			this.panel1.Location = new System.Drawing.Point(39, 45);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(383, 78);
			this.panel1.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Range";
			// 
			// ejSlider1
			// 
			this.ejSlider1.Dock = Wisej.Web.DockStyle.Bottom;
			this.ejSlider1.Location = new System.Drawing.Point(0, 46);
			this.ejSlider1.Name = "ejSlider1";
			this.ejSlider1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"sliderType\":\"range\",\"values\":[30,60]}")));
			this.ejSlider1.Size = new System.Drawing.Size(383, 32);
			this.ejSlider1.TabIndex = 3;
			this.ejSlider1.Text = "ejSlider1";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.ejSlider2);
			this.panel2.Location = new System.Drawing.Point(39, 190);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(383, 78);
			this.panel2.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = Wisej.Web.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(383, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "Min-Range";
			// 
			// ejSlider2
			// 
			this.ejSlider2.Dock = Wisej.Web.DockStyle.Bottom;
			this.ejSlider2.Location = new System.Drawing.Point(0, 46);
			this.ejSlider2.Name = "ejSlider2";
			this.ejSlider2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":60,\"sliderType\":\"minrange\"}")));
			this.ejSlider2.Size = new System.Drawing.Size(383, 32);
			this.ejSlider2.TabIndex = 2;
			this.ejSlider2.Text = "ejSlider2";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(28, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(195, 41);
			this.label6.TabIndex = 2;
			this.label6.Text = "Note: Property changes only affect the \"Range\" slider";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 89);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 9;
			this.checkBox2.Text = "Allow Mouse Wheel";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 139);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Show Buttons";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 189);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 11;
			this.checkBox3.Text = "Show Scale";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox4.Location = new System.Drawing.Point(28, 239);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 12;
			this.checkBox4.Text = "Show Small Ticks";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "MinRange",
            "Range"});
			this.comboBox1.LabelText = "Slider Type";
			this.comboBox1.Location = new System.Drawing.Point(28, 289);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.Text = "Default";
			// 
			// ejSlider
			// 
			this.Name = "ejSlider";
			this.Size = new System.Drawing.Size(864, 617);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSlider ejSlider1;
		private Panel panel2;
		private Label label5;
		private Syncfusion.ejSlider ejSlider2;
		private Panel panel1;
		private Label label4;
		private Label label6;
		private ComboBox comboBox1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
	}
}
