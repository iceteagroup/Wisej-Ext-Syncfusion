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
			// panel
			// 
			this.panel.Controls.Add(this.panel2);
			this.panel.Controls.Add(this.panel1);
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
			this.panel1.TabStop = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 16);
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
			this.panel2.TabStop = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = Wisej.Web.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(383, 16);
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
			// ejSlider
			// 
			this.Name = "ejSlider";
			this.groupBox1.ResumeLayout(false);
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
	}
}
