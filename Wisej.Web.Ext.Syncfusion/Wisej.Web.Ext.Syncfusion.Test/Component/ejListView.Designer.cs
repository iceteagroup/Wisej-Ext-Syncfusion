namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejListView));
			this.ejListView1 = new Wisej.Web.Ext.Syncfusion.ejListView();
			this.textBoxAddNewItem = new Wisej.Web.TextBox();
			this.buttonAddNewItem = new Wisej.Web.Button();
			this.buttonGetSelectedItems = new Wisej.Web.Button();
			this.buttonClearSelected = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/listview/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejlistview";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonClearSelected);
			this.groupBox1.Controls.Add(this.buttonGetSelectedItems);
			this.groupBox1.Controls.Add(this.buttonAddNewItem);
			this.groupBox1.Controls.Add(this.textBoxAddNewItem);
			this.groupBox1.Size = new System.Drawing.Size(250, 467);
			this.groupBox1.Controls.SetChildIndex(this.textBoxAddNewItem, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonAddNewItem, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonGetSelectedItems, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonClearSelected, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 386);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejListView1);
			this.panel.Size = new System.Drawing.Size(455, 467);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(532, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/listview/DefaultFunctionalities";
			// 
			// ejListView1
			// 
			this.ejListView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejListView1.Location = new System.Drawing.Point(96, 34);
			this.ejListView1.Name = "ejListView1";
			this.ejListView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejListView1.Options"))));
			this.ejListView1.Size = new System.Drawing.Size(261, 397);
			this.ejListView1.Text = "ejListView1";
			// 
			// textBoxAddNewItem
			// 
			this.textBoxAddNewItem.AutoSize = false;
			this.textBoxAddNewItem.Label.Size = 50;
			this.textBoxAddNewItem.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxAddNewItem.Label.Text = "Add New Item";
			this.textBoxAddNewItem.Location = new System.Drawing.Point(28, 35);
			this.textBoxAddNewItem.Name = "textBoxAddNewItem";
			this.textBoxAddNewItem.Size = new System.Drawing.Size(195, 60);
			this.textBoxAddNewItem.TabIndex = 2;
			this.textBoxAddNewItem.Text = "Top 1000 Albums";
			// 
			// buttonAddNewItem
			// 
			this.buttonAddNewItem.Location = new System.Drawing.Point(28, 101);
			this.buttonAddNewItem.Name = "buttonAddNewItem";
			this.buttonAddNewItem.Size = new System.Drawing.Size(195, 30);
			this.buttonAddNewItem.TabIndex = 3;
			this.buttonAddNewItem.Text = "Add Item";
			this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
			// 
			// buttonGetSelectedItems
			// 
			this.buttonGetSelectedItems.Location = new System.Drawing.Point(28, 196);
			this.buttonGetSelectedItems.Name = "buttonGetSelectedItems";
			this.buttonGetSelectedItems.Size = new System.Drawing.Size(195, 30);
			this.buttonGetSelectedItems.TabIndex = 4;
			this.buttonGetSelectedItems.Text = "Get Selected Items";
			this.buttonGetSelectedItems.Click += new System.EventHandler(this.buttonGetSelectedItems_Click);
			// 
			// buttonClearSelected
			// 
			this.buttonClearSelected.Location = new System.Drawing.Point(28, 291);
			this.buttonClearSelected.Name = "buttonClearSelected";
			this.buttonClearSelected.Size = new System.Drawing.Size(195, 30);
			this.buttonClearSelected.TabIndex = 5;
			this.buttonClearSelected.Text = "Clear Selected Items";
			this.buttonClearSelected.Click += new System.EventHandler(this.buttonClearSelected_Click);
			// 
			// ejListView
			// 
			this.Name = "ejListView";
			this.Size = new System.Drawing.Size(864, 657);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejListView ejListView1;
		private TextBox textBoxAddNewItem;
		private Button buttonAddNewItem;
		private Button buttonGetSelectedItems;
		private Button buttonClearSelected;
	}
}
