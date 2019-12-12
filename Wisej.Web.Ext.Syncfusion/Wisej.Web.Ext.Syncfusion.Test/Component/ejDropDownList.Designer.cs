namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejDropDownList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejDropDownList));
			this.ejDropDownList1 = new Wisej.Web.Ext.Syncfusion.ejDropDownList();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.ejDropDownList2 = new Wisej.Web.Ext.Syncfusion.ejDropDownList();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/dropdownlist/dropdownlist";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdropdownlist";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDropDownList2);
			this.panel.Controls.Add(this.ejDropDownList1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(554, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/dropdownlist/defaultfunctionalit" +
    "ies";
			// 
			// ejDropDownList1
			// 
			this.ejDropDownList1.Anchor = Wisej.Web.AnchorStyles.Top;
			this.ejDropDownList1.Location = new System.Drawing.Point(78, 47);
			this.ejDropDownList1.Name = "ejDropDownList1";
			this.ejDropDownList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownList1.Options"))));
			this.ejDropDownList1.Size = new System.Drawing.Size(309, 30);
			this.ejDropDownList1.TabIndex = 3;
			this.ejDropDownList1.Text = "ejDropDownList1";
			this.ejDropDownList1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejDropDownList_WidgetEvent);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 48);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 22);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Virtual Scroll";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 83);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 22);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Case Sensitive Search";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 118);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 22);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "Incremental Search";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Location = new System.Drawing.Point(28, 153);
			this.checkBox4.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 22);
			this.checkBox4.TabIndex = 4;
			this.checkBox4.Text = "Filter Search";
			// 
			// ejDropDownList2
			// 
			this.ejDropDownList2.Anchor = Wisej.Web.AnchorStyles.Top;
			this.ejDropDownList2.Location = new System.Drawing.Point(78, 117);
			this.ejDropDownList2.Name = "ejDropDownList2";
			this.ejDropDownList2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownList2.Options"))));
			this.ejDropDownList2.Size = new System.Drawing.Size(309, 30);
			this.ejDropDownList2.TabIndex = 2;
			this.ejDropDownList2.Text = "ejDropDownList2";
			this.ejDropDownList2.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejDropDownList_WidgetEvent);
			// 
			// ejDropDownList
			// 
			this.Name = "ejDropDownList";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDropDownList ejDropDownList1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Syncfusion.ejDropDownList ejDropDownList2;
	}
}
