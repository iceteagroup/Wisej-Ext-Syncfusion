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
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.buttonGetCheckedNodes = new Wisej.Web.Button();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.checkBox5 = new Wisej.Web.CheckBox();
			this.checkBox6 = new Wisej.Web.CheckBox();
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
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.buttonGetCheckedNodes);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 412);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonGetCheckedNodes, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox6, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 327);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeView1);
			this.panel.Size = new System.Drawing.Size(455, 412);
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
			this.ejTreeView1.Location = new System.Drawing.Point(129, 98);
			this.ejTreeView1.Name = "ejTreeView1";
			this.ejTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeView1.Options"))));
			this.ejTreeView1.Size = new System.Drawing.Size(194, 214);
			this.ejTreeView1.TabIndex = 0;
			this.ejTreeView1.Text = "ejTreeView1";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 34);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 31);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Auto Check";
			// 
			// buttonGetCheckedNodes
			// 
			this.buttonGetCheckedNodes.Location = new System.Drawing.Point(28, 286);
			this.buttonGetCheckedNodes.Name = "buttonGetCheckedNodes";
			this.buttonGetCheckedNodes.Size = new System.Drawing.Size(195, 30);
			this.buttonGetCheckedNodes.TabIndex = 8;
			this.buttonGetCheckedNodes.Text = "Get Checked Nodes";
			this.buttonGetCheckedNodes.Click += new System.EventHandler(this.buttonGetCheckedNodes_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 76);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 31);
			this.checkBox2.TabIndex = 9;
			this.checkBox2.Text = "Show Checkbox";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 118);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 31);
			this.checkBox3.TabIndex = 10;
			this.checkBox3.Text = "Allow Drag and Drop";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Location = new System.Drawing.Point(28, 160);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 31);
			this.checkBox4.TabIndex = 11;
			this.checkBox4.Text = "Allow Editing";
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox5.Location = new System.Drawing.Point(28, 202);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(195, 31);
			this.checkBox5.TabIndex = 12;
			this.checkBox5.Text = "Allow Keyboard Navigation";
			// 
			// checkBox6
			// 
			this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox6.AutoSize = false;
			this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox6.Location = new System.Drawing.Point(28, 244);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(195, 31);
			this.checkBox6.TabIndex = 13;
			this.checkBox6.Text = "Allow Multi Selection";
			// 
			// ejTreeView
			// 
			this.Name = "ejTreeView";
			this.Size = new System.Drawing.Size(864, 602);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeView ejTreeView1;
		private CheckBox checkBox1;
		private Button buttonGetCheckedNodes;
		private CheckBox checkBox2;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
	}
}
