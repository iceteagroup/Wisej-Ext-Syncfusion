namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejComboBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejComboBox));
			this.ejComboBox1 = new Wisej.Web.Ext.Syncfusion.ejComboBox();
			this.checkBoxAutofill = new Wisej.Web.CheckBox();
			this.checkBoxShowClearButton = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/combobox/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejcombobox";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxShowClearButton);
			this.groupBox1.Controls.Add(this.checkBoxAutofill);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAutofill, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowClearButton, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejComboBox1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(518, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/combobox/DefaultFunctionalities";
			// 
			// ejComboBox1
			// 
			this.ejComboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejComboBox1.Location = new System.Drawing.Point(101, 141);
			this.ejComboBox1.Name = "ejComboBox1";
			this.ejComboBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejComboBox1.Options"))));
			this.ejComboBox1.Size = new System.Drawing.Size(250, 30);
			this.ejComboBox1.TabIndex = 0;
			this.ejComboBox1.Text = "ejComboBox1";
			// 
			// checkBoxAutofill
			// 
			this.checkBoxAutofill.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAutofill.AutoSize = false;
			this.checkBoxAutofill.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAutofill.Checked = true;
			this.checkBoxAutofill.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxAutofill.Location = new System.Drawing.Point(28, 36);
			this.checkBoxAutofill.Name = "checkBoxAutofill";
			this.checkBoxAutofill.Size = new System.Drawing.Size(195, 38);
			this.checkBoxAutofill.TabIndex = 8;
			this.checkBoxAutofill.Text = "Autofill";
			// 
			// checkBoxShowClearButton
			// 
			this.checkBoxShowClearButton.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowClearButton.AutoSize = false;
			this.checkBoxShowClearButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowClearButton.Checked = true;
			this.checkBoxShowClearButton.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowClearButton.Location = new System.Drawing.Point(28, 96);
			this.checkBoxShowClearButton.Name = "checkBoxShowClearButton";
			this.checkBoxShowClearButton.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShowClearButton.TabIndex = 9;
			this.checkBoxShowClearButton.Text = "Show Clear Button";
			// 
			// ejComboBox
			// 
			this.Name = "ejComboBox";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejComboBox ejComboBox1;
		private CheckBox checkBoxAutofill;
		private CheckBox checkBoxShowClearButton;
	}
}
