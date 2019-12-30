namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejRecurrenceEditor
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
			this.ejRecurrenceEditor1 = new Wisej.Web.Ext.Syncfusion.ejRecurrenceEditor();
			this.buttonGenerateRule = new Wisej.Web.Button();
			this.checkBoxEnableSpinners = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "N/A";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejrecurrenceeditor";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxEnableSpinners);
			this.groupBox1.Controls.Add(this.buttonGenerateRule);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonGenerateRule, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableSpinners, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejRecurrenceEditor1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(520, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/schedule/RecurrenceEditor";
			// 
			// ejRecurrenceEditor1
			// 
			this.ejRecurrenceEditor1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejRecurrenceEditor1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.ejRecurrenceEditor1.Location = new System.Drawing.Point(45, 9);
			this.ejRecurrenceEditor1.Name = "ejRecurrenceEditor1";
			this.ejRecurrenceEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"selectedRecurrenceType\":1,\"isResponsive\":true}")));
			this.ejRecurrenceEditor1.Size = new System.Drawing.Size(362, 294);
			this.ejRecurrenceEditor1.Text = "ejRecurrenceEditor1";
			// 
			// buttonGenerateRule
			// 
			this.buttonGenerateRule.Location = new System.Drawing.Point(28, 134);
			this.buttonGenerateRule.Name = "buttonGenerateRule";
			this.buttonGenerateRule.Size = new System.Drawing.Size(195, 30);
			this.buttonGenerateRule.TabIndex = 3;
			this.buttonGenerateRule.Text = "Generate Rule";
			this.buttonGenerateRule.Click += new System.EventHandler(this.buttonGenerateRule_Click);
			// 
			// checkBoxEnableSpinners
			// 
			this.checkBoxEnableSpinners.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnableSpinners.AutoSize = false;
			this.checkBoxEnableSpinners.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnableSpinners.Checked = true;
			this.checkBoxEnableSpinners.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxEnableSpinners.Location = new System.Drawing.Point(28, 42);
			this.checkBoxEnableSpinners.Name = "checkBoxEnableSpinners";
			this.checkBoxEnableSpinners.Size = new System.Drawing.Size(195, 38);
			this.checkBoxEnableSpinners.TabIndex = 8;
			this.checkBoxEnableSpinners.Text = "Enable Spinners";
			// 
			// ejRecurrenceEditor
			// 
			this.Name = "ejRecurrenceEditor";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejRecurrenceEditor ejRecurrenceEditor1;
		private Button buttonGenerateRule;
		private CheckBox checkBoxEnableSpinners;
	}
}
