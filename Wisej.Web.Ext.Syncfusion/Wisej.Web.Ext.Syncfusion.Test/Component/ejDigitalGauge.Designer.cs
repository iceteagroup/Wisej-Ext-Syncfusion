namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejDigitalGauge
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
			this.ejDigitalGauge1 = new Wisej.Web.Ext.Syncfusion.ejDigitalGauge();
			this.textBox1 = new Wisej.Web.TextBox();
			this.label4 = new Wisej.Web.Label();
			this.trackBar1 = new Wisej.Web.TrackBar();
			this.label5 = new Wisej.Web.Label();
			this.trackBar2 = new Wisej.Web.TrackBar();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/digitalgauge/ove";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdigitalgauge";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.trackBar2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 437);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.trackBar1, 0);
			this.groupBox1.Controls.SetChildIndex(this.label4, 0);
			this.groupBox1.Controls.SetChildIndex(this.trackBar2, 0);
			this.groupBox1.Controls.SetChildIndex(this.label5, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 356);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDigitalGauge1);
			this.panel.Size = new System.Drawing.Size(455, 437);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(582, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/digitalgauge/DefaultFunctionalit" +
    "ies";
			// 
			// ejDigitalGauge1
			// 
			this.ejDigitalGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejDigitalGauge1.Location = new System.Drawing.Point(76, 106);
			this.ejDigitalGauge1.Name = "ejDigitalGauge1";
			this.ejDigitalGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"items\":[{\"segmentSettings\":{\"width\":1,\"spacing\":0,\"color\":\"" +
        "#8c8c8c\"},\"characterSettings\":{\"opacity\":0.8,\"spacing\":2},\"value\":\"123456789\",\"p" +
        "osition\":{\"x\":52,\"y\":52}}]}")));
			this.ejDigitalGauge1.Size = new System.Drawing.Size(300, 222);
			this.ejDigitalGauge1.Text = "ejDigitalGauge1";
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.Label.Size = 50;
			this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBox1.Label.Text = "Text";
			this.textBox1.Location = new System.Drawing.Point(28, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 60);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "123456789";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Segment Spacing";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(28, 150);
			this.trackBar1.Maximum = 1;
			this.trackBar1.Minimum = -2;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(195, 36);
			this.trackBar1.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 243);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Character Spacing";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(28, 265);
			this.trackBar2.Maximum = 4;
			this.trackBar2.Minimum = 1;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(195, 36);
			this.trackBar2.TabIndex = 6;
			this.trackBar2.Value = 2;
			// 
			// ejDigitalGauge
			// 
			this.Name = "ejDigitalGauge";
			this.Size = new System.Drawing.Size(864, 627);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDigitalGauge ejDigitalGauge1;
		private TextBox textBox1;
		private Label label4;
		private TrackBar trackBar1;
		private Label label5;
		private TrackBar trackBar2;
	}
}
