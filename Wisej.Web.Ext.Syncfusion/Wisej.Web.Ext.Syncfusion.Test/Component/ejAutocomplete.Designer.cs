namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejAutocomplete
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejAutocomplete));
			this.ejAutocomplete1 = new Wisej.Web.Ext.Syncfusion.ejAutocomplete();
			this.button1 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Size = new System.Drawing.Size(585, 24);
			this.linkDocs.Text = "https://help.syncfusion.com/js/autocomplete/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejautocomplete";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejAutocomplete1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(572, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/autocomplete/DefaultFunctionalit" +
    "ies";
			// 
			// ejAutocomplete1
			// 
			this.ejAutocomplete1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejAutocomplete1.Location = new System.Drawing.Point(126, 141);
			this.ejAutocomplete1.Name = "ejAutocomplete1";
			this.ejAutocomplete1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejAutocomplete1.Options"))));
			this.ejAutocomplete1.Size = new System.Drawing.Size(200, 30);
			this.ejAutocomplete1.Text = "ejAutocomplete1";
			// 
			// button1
			// 
			this.button1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(28, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "Get TextBox Value";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ejAutocomplete
			// 
			this.Name = "ejAutocomplete";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejAutocomplete ejAutocomplete1;
		private Button button1;
	}
}
