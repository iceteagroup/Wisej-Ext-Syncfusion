namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejTreeView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTreeView));
			this.ejTreeView1 = new Wisej.Web.Ext.Syncfusion.ejTreeView();
			this.checkBoxAutoCheck = new Wisej.Web.CheckBox();
			this.buttonGetCheckedNodes = new Wisej.Web.Button();
			this.checkBoxShowCheckbox = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/treeview/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtreeview";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxShowCheckbox);
			this.groupBox1.Controls.Add(this.buttonGetCheckedNodes);
			this.groupBox1.Controls.Add(this.checkBoxAutoCheck);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAutoCheck, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonGetCheckedNodes, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowCheckbox, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeView1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(593, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/treeview/DefaultFunctionalities";
			// 
			// ejTreeView1
			// 
			this.ejTreeView1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejTreeView1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.ejTreeView1.Location = new System.Drawing.Point(164, 49);
			this.ejTreeView1.Name = "ejTreeView1";
			this.ejTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeView1.Options"))));
			this.ejTreeView1.Size = new System.Drawing.Size(124, 214);
			this.ejTreeView1.Text = "ejTreeView1";
			// 
			// checkBoxAutoCheck
			// 
			this.checkBoxAutoCheck.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAutoCheck.AutoSize = false;
			this.checkBoxAutoCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAutoCheck.Checked = true;
			this.checkBoxAutoCheck.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxAutoCheck.Location = new System.Drawing.Point(28, 34);
			this.checkBoxAutoCheck.Name = "checkBoxAutoCheck";
			this.checkBoxAutoCheck.Size = new System.Drawing.Size(195, 31);
			this.checkBoxAutoCheck.TabIndex = 7;
			this.checkBoxAutoCheck.Text = "Auto Check";
			// 
			// buttonGetCheckedNodes
			// 
			this.buttonGetCheckedNodes.Location = new System.Drawing.Point(28, 166);
			this.buttonGetCheckedNodes.Name = "buttonGetCheckedNodes";
			this.buttonGetCheckedNodes.Size = new System.Drawing.Size(195, 30);
			this.buttonGetCheckedNodes.TabIndex = 8;
			this.buttonGetCheckedNodes.Text = "Get Checked Nodes";
			this.buttonGetCheckedNodes.Click += new System.EventHandler(this.buttonGetCheckedNodes_Click);
			// 
			// checkBoxShowCheckbox
			// 
			this.checkBoxShowCheckbox.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowCheckbox.AutoSize = false;
			this.checkBoxShowCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowCheckbox.Location = new System.Drawing.Point(28, 100);
			this.checkBoxShowCheckbox.Name = "checkBoxShowCheckbox";
			this.checkBoxShowCheckbox.Size = new System.Drawing.Size(195, 31);
			this.checkBoxShowCheckbox.TabIndex = 9;
			this.checkBoxShowCheckbox.Text = "Show Checkbox";
			// 
			// ejTreeView
			// 
			this.Name = "ejTreeView";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeView ejTreeView1;
		private CheckBox checkBoxAutoCheck;
		private Button buttonGetCheckedNodes;
		private CheckBox checkBoxShowCheckbox;
	}
}
