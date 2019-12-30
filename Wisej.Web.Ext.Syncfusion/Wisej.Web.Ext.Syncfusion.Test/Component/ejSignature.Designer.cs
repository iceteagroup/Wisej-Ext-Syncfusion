namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejSignature
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
			this.ejSignature1 = new Wisej.Web.Ext.Syncfusion.ejSignature();
			this.button1 = new Wisej.Web.Button();
			this.buttonClear = new Wisej.Web.Button();
			this.buttonUndo = new Wisej.Web.Button();
			this.buttonRedo = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/signature/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsignature";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonRedo);
			this.groupBox1.Controls.Add(this.buttonUndo);
			this.groupBox1.Controls.Add(this.buttonClear);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonClear, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUndo, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonRedo, 0);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejSignature1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(616, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/signature/DefaultFunctionalities" +
    "";
			// 
			// ejSignature1
			// 
			this.ejSignature1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejSignature1.Location = new System.Drawing.Point(23, 19);
			this.ejSignature1.Name = "ejSignature1";
			this.ejSignature1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"strokeWidth\":3}")));
			this.ejSignature1.Size = new System.Drawing.Size(407, 274);
			this.ejSignature1.TabIndex = 1;
			this.ejSignature1.Text = "ejSignature1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save Image";
			this.button1.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(28, 114);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(195, 30);
			this.buttonClear.TabIndex = 2;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonUndo
			// 
			this.buttonUndo.Display = Wisej.Web.Display.Icon;
			this.buttonUndo.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/undo-button.svg";
			this.buttonUndo.Location = new System.Drawing.Point(28, 162);
			this.buttonUndo.Name = "buttonUndo";
			this.buttonUndo.Size = new System.Drawing.Size(42, 42);
			this.buttonUndo.TabIndex = 9;
			this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
			// 
			// buttonRedo
			// 
			this.buttonRedo.Display = Wisej.Web.Display.Icon;
			this.buttonRedo.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button-1.svg";
			this.buttonRedo.Location = new System.Drawing.Point(76, 162);
			this.buttonRedo.Name = "buttonRedo";
			this.buttonRedo.Size = new System.Drawing.Size(42, 42);
			this.buttonRedo.TabIndex = 10;
			this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
			// 
			// ejSignature
			// 
			this.Name = "ejSignature";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSignature ejSignature1;
		private Button button1;
		private Button buttonClear;
		private Button buttonRedo;
		private Button buttonUndo;
	}
}
