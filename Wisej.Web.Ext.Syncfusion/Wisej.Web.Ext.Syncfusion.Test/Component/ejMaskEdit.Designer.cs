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
			// panel
			// 
			this.panel.Controls.Add(this.panel1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "N/A";
			// 
			// ejMaskEdit1
			// 
			this.ejMaskEdit1.Location = new System.Drawing.Point(3, 25);
			this.ejMaskEdit1.Name = "ejMaskEdit1";
			this.ejMaskEdit1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"watermarkText\":\"Enter password\",\"inputMode\":\"Password\"}")));
			this.ejMaskEdit1.Size = new System.Drawing.Size(200, 30);
			this.ejMaskEdit1.Text = "ejMaskEdit1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Password Format";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ejMaskEdit1);
			this.panel1.Location = new System.Drawing.Point(122, 126);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(208, 61);
			this.panel1.TabIndex = 2;
			this.panel1.TabStop = true;
			// 
			// ejMaskEdit
			// 
			this.Name = "ejMaskEdit";
			this.groupBox1.ResumeLayout(false);
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
	}
}
