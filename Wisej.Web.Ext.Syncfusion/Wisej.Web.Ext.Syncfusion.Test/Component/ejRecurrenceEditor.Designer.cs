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
			// panel
			// 
			this.panel.Controls.Add(this.ejRecurrenceEditor1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/schedule/RecurrenceEditor";
			// 
			// ejRecurrenceEditor1
			// 
			this.ejRecurrenceEditor1.Location = new System.Drawing.Point(13, 9);
			this.ejRecurrenceEditor1.Name = "ejRecurrenceEditor1";
			this.ejRecurrenceEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"selectedRecurrenceType\":1,\"isResponsive\":true}")));
			this.ejRecurrenceEditor1.Size = new System.Drawing.Size(427, 294);
			this.ejRecurrenceEditor1.Text = "ejRecurrenceEditor1";
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
	}
}
