namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejMaskEdit
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
			this.ejMaskEdit1 = new Wisej.Web.Ext.Syncfusion.ejMaskEdit();
			this.label4 = new Wisej.Web.Label();
			this.panel1 = new Wisej.Web.Panel();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.textBox1 = new Wisej.Web.TextBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/maskedit/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejmaskedit";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 430);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 347);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.panel1);
			this.panel.Size = new System.Drawing.Size(455, 430);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "N/A";
			// 
			// ejMaskEdit1
			// 
			this.ejMaskEdit1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejMaskEdit1.Location = new System.Drawing.Point(4, 25);
			this.ejMaskEdit1.Name = "ejMaskEdit1";
			this.ejMaskEdit1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"watermarkText\":\"Enter password\",\"inputMode\":\"Password\"}")));
			this.ejMaskEdit1.Size = new System.Drawing.Size(200, 30);
			this.ejMaskEdit1.TabIndex = 2;
			this.ejMaskEdit1.Text = "ejMaskEdit1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Password Format";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ejMaskEdit1);
			this.panel1.Location = new System.Drawing.Point(122, 184);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(208, 61);
			this.panel1.TabIndex = 2;
			// 
			// comboBoxInputMode
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Password",
            "Text"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Input Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 172);
			this.comboBox1.Name = "comboBoxInputMode";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "Password";
			// 
			// textBox1
			// 
			this.textBox1.LabelText = "Custom Character";
			this.textBox1.Location = new System.Drawing.Point(28, 269);
			this.textBox1.MaxLength = 1;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 41);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "*";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 31);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Hide Prompt on Leave";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 104);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 31);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "Show Prompt Char";
			// 
			// ejMaskEdit
			// 
			this.Name = "ejMaskEdit";
			this.Size = new System.Drawing.Size(864, 620);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejMaskEdit ejMaskEdit1;
		private Panel panel1;
		private Label label4;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
