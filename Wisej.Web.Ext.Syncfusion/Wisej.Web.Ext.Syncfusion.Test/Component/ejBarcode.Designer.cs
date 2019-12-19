namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejBarcode
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
			this.textBoxBarcodeValue = new Wisej.Web.TextBox();
			this.ejBarcode1 = new Wisej.Web.Ext.Syncfusion.ejBarcode();
			this.comboBoxSymbology = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/barcode/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejbarcode";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxSymbology);
			this.groupBox1.Controls.Add(this.textBoxBarcodeValue);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBoxBarcodeValue, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxSymbology, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejBarcode1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/barcode/qrbarcode";
			// 
			// textBox1
			// 
			this.textBoxBarcodeValue.AutoSize = false;
			this.textBoxBarcodeValue.Label.Size = 50;
			this.textBoxBarcodeValue.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxBarcodeValue.Label.Text = "Text";
			this.textBoxBarcodeValue.Location = new System.Drawing.Point(25, 44);
			this.textBoxBarcodeValue.Name = "textBox1";
			this.textBoxBarcodeValue.Size = new System.Drawing.Size(200, 60);
			this.textBoxBarcodeValue.TabIndex = 1;
			this.textBoxBarcodeValue.Text = "HTTP://WISEJ.COM";
			// 
			// ejBarcode1
			// 
			this.ejBarcode1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejBarcode1.Location = new System.Drawing.Point(119, 35);
			this.ejBarcode1.Name = "ejBarcode1";
			this.ejBarcode1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"text\":\"HTTP://WISEJ.COM\"}")));
			this.ejBarcode1.Size = new System.Drawing.Size(215, 243);
			this.ejBarcode1.Text = "HTTP://WISEJ.COM";
			// 
			// comboBox1
			// 
			this.comboBoxSymbology.AutoSize = false;
			this.comboBoxSymbology.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxSymbology.Items.AddRange(new object[] {
            "QRBarcode",
            "DataMatrix",
            "Code39",
            "Code39Extended",
            "Code11",
            "Codabar",
            "Code32",
            "Code93",
            "Code93Extended",
            "Code128A",
            "Code128B",
            "Code128C"});
			this.comboBoxSymbology.Label.Size = 50;
			this.comboBoxSymbology.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxSymbology.Label.Text = "Symbology";
			this.comboBoxSymbology.Location = new System.Drawing.Point(25, 120);
			this.comboBoxSymbology.Name = "comboBox1";
			this.comboBoxSymbology.Size = new System.Drawing.Size(200, 60);
			this.comboBoxSymbology.TabIndex = 2;
			this.comboBoxSymbology.Text = "QRBarcode";
			// 
			// ejBarcode
			// 
			this.Name = "ejBarcode";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBoxBarcodeValue;
		private Syncfusion.ejBarcode ejBarcode1;
		private ComboBox comboBoxSymbology;
	}
}
