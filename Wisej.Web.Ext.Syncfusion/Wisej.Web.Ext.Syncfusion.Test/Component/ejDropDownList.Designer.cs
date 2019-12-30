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
			this.checkBoxAllowVirtualScrolling = new Wisej.Web.CheckBox();
			this.checkBoxCaseSensitiveSearch = new Wisej.Web.CheckBox();
			this.checkBoxEnableIncrementalSearch = new Wisej.Web.CheckBox();
			this.checkBoxEnableFilterSearch = new Wisej.Web.CheckBox();
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
			this.groupBox1.Controls.Add(this.checkBoxEnableFilterSearch);
			this.groupBox1.Controls.Add(this.checkBoxEnableIncrementalSearch);
			this.groupBox1.Controls.Add(this.checkBoxCaseSensitiveSearch);
			this.groupBox1.Controls.Add(this.checkBoxAllowVirtualScrolling);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowVirtualScrolling, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxCaseSensitiveSearch, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableIncrementalSearch, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableFilterSearch, 0);
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
			this.ejDropDownList1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejDropDownList1.Location = new System.Drawing.Point(101, 106);
			this.ejDropDownList1.Name = "ejDropDownList1";
			this.ejDropDownList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownList1.Options"))));
			this.ejDropDownList1.Size = new System.Drawing.Size(250, 30);
			this.ejDropDownList1.TabIndex = 3;
			this.ejDropDownList1.Text = "ejDropDownList1";
			this.ejDropDownList1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejDropDownList_WidgetEvent);
			// 
			// checkBoxAllowVirtualScrolling
			// 
			this.checkBoxAllowVirtualScrolling.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowVirtualScrolling.AutoSize = false;
			this.checkBoxAllowVirtualScrolling.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowVirtualScrolling.Location = new System.Drawing.Point(28, 48);
			this.checkBoxAllowVirtualScrolling.Name = "checkBoxAllowVirtualScrolling";
			this.checkBoxAllowVirtualScrolling.Size = new System.Drawing.Size(195, 22);
			this.checkBoxAllowVirtualScrolling.TabIndex = 1;
			this.checkBoxAllowVirtualScrolling.Text = "Virtual Scroll";
			// 
			// checkBoxCaseSensitiveSearch
			// 
			this.checkBoxCaseSensitiveSearch.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxCaseSensitiveSearch.AutoSize = false;
			this.checkBoxCaseSensitiveSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxCaseSensitiveSearch.Location = new System.Drawing.Point(28, 83);
			this.checkBoxCaseSensitiveSearch.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBoxCaseSensitiveSearch.Name = "checkBoxCaseSensitiveSearch";
			this.checkBoxCaseSensitiveSearch.Size = new System.Drawing.Size(195, 22);
			this.checkBoxCaseSensitiveSearch.TabIndex = 2;
			this.checkBoxCaseSensitiveSearch.Text = "Case Sensitive Search";
			// 
			// checkBoxEnableIncrementalSearch
			// 
			this.checkBoxEnableIncrementalSearch.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnableIncrementalSearch.AutoSize = false;
			this.checkBoxEnableIncrementalSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnableIncrementalSearch.Location = new System.Drawing.Point(28, 118);
			this.checkBoxEnableIncrementalSearch.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBoxEnableIncrementalSearch.Name = "checkBoxEnableIncrementalSearch";
			this.checkBoxEnableIncrementalSearch.Size = new System.Drawing.Size(195, 22);
			this.checkBoxEnableIncrementalSearch.TabIndex = 3;
			this.checkBoxEnableIncrementalSearch.Text = "Incremental Search";
			// 
			// checkBoxEnableFilterSearch
			// 
			this.checkBoxEnableFilterSearch.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEnableFilterSearch.AutoSize = false;
			this.checkBoxEnableFilterSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEnableFilterSearch.Location = new System.Drawing.Point(28, 153);
			this.checkBoxEnableFilterSearch.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBoxEnableFilterSearch.Name = "checkBoxEnableFilterSearch";
			this.checkBoxEnableFilterSearch.Size = new System.Drawing.Size(195, 22);
			this.checkBoxEnableFilterSearch.TabIndex = 4;
			this.checkBoxEnableFilterSearch.Text = "Filter Search";
			// 
			// ejDropDownList2
			// 
			this.ejDropDownList2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.ejDropDownList2.Location = new System.Drawing.Point(101, 176);
			this.ejDropDownList2.Name = "ejDropDownList2";
			this.ejDropDownList2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownList2.Options"))));
			this.ejDropDownList2.Size = new System.Drawing.Size(250, 30);
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
		private CheckBox checkBoxEnableFilterSearch;
		private CheckBox checkBoxEnableIncrementalSearch;
		private CheckBox checkBoxCaseSensitiveSearch;
		private CheckBox checkBoxAllowVirtualScrolling;
		private Syncfusion.ejDropDownList ejDropDownList2;
	}
}
