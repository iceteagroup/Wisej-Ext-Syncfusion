namespace Wisej.Web.Ext.Syncfusion.Test
{
	partial class MainView
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new Wisej.Web.Panel();
			this.listBox1 = new Wisej.Web.ListBox();
			this.panel2 = new Wisej.Web.Panel();
			this.panel3 = new Wisej.Web.Panel();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.label1 = new Wisej.Web.Label();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(43, 53, 124);
			this.panel1.HeaderSize = 30;
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Wisej.Web.Padding(20);
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(250, 631);
			this.panel1.TabIndex = 0;
			this.panel1.TabStop = true;
			this.panel1.Text = "Component";
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.listBox1.DisplayMember = "Name";
			this.listBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.listBox1.IconMember = "Icon";
			this.listBox1.Location = new System.Drawing.Point(20, 20);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(208, 559);
			this.listBox1.TabIndex = 0;
			this.listBox1.ValueMember = "Name";
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Dock = Wisej.Web.DockStyle.Fill;
			this.panel2.HeaderBackColor = System.Drawing.Color.FromArgb(245, 146, 30);
			this.panel2.HeaderSize = 30;
			this.panel2.Location = new System.Drawing.Point(250, 100);
			this.panel2.Name = "panel2";
			this.panel2.ShowCloseButton = false;
			this.panel2.ShowHeader = true;
			this.panel2.Size = new System.Drawing.Size(894, 631);
			this.panel2.TabIndex = 1;
			this.panel2.TabStop = true;
			this.panel2.Text = "Test";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = Wisej.Web.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1144, 100);
			this.panel3.TabIndex = 0;
			this.panel3.TabStop = true;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "default-theme",
            "flat-azure-dark",
            "flat-lime",
            "flat-lime-dark",
            "flat-saffron",
            "flat-saffron-dark",
            "gradient-azure",
            "gradient-azure-dark",
            "gradient-lime",
            "gradient-lime-dark",
            "gradient-saffron",
            "gradient-saffron-dark",
            "material",
            "office-365"});
			this.comboBox1.Location = new System.Drawing.Point(920, 49);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 35);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "default-theme";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("default, Verdana", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(43, 53, 124);
			this.label1.Location = new System.Drawing.Point(129, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(575, 48);
			this.label1.TabIndex = 1;
			this.label1.Text = "Syncfusion Integration Tests";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageSource = "Images\\syncfusion.png";
			this.pictureBox1.Location = new System.Drawing.Point(21, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(71, 69);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(1144, 731);
			this.Load += new System.EventHandler(this.MainView_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private ListBox listBox1;
		private Panel panel2;
		private Panel panel3;
		private Label label1;
		private PictureBox pictureBox1;
		private ComboBox comboBox1;
	}
}
