using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public class TestBase : UserControl
	{

		public TestBase()
		{
			InitializeComponent();
		}

		protected LinkLabel linkDocs;
		private ImageList imageList1;
		private System.ComponentModel.IContainer components;
		protected LinkLabel linkAPI;
		protected GroupBox groupBox1;
		protected Button buttonUpdate;
		protected Panel panel;
		private Label label1;
		private Label label2;
		private Label label3;
		protected LinkLabel linkDemo;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.linkDocs = new Wisej.Web.LinkLabel();
			this.imageList1 = new Wisej.Web.ImageList(this.components);
			this.linkAPI = new Wisej.Web.LinkLabel();
			this.linkDemo = new Wisej.Web.LinkLabel();
			this.groupBox1 = new Wisej.Web.GroupBox();
			this.buttonUpdate = new Wisej.Web.Button();
			this.panel = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.label3 = new Wisej.Web.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkDocs.ImageList = this.imageList1;
			this.linkDocs.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
			this.linkDocs.Location = new System.Drawing.Point(118, 25);
			this.linkDocs.Name = "linkDocs";
			this.linkDocs.Size = new System.Drawing.Size(456, 24);
			this.linkDocs.TabIndex = 0;
			this.linkDocs.Text = "https://help.syncfusion.com/js/overview";
			this.linkDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkDocs.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(32, 16);
			// 
			// linkAPI
			// 
			this.linkAPI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkAPI.ImageList = this.imageList1;
			this.linkAPI.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
			this.linkAPI.Location = new System.Drawing.Point(118, 55);
			this.linkAPI.Name = "linkAPI";
			this.linkAPI.Size = new System.Drawing.Size(456, 24);
			this.linkAPI.TabIndex = 1;
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/global";
			this.linkAPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkAPI.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
			// 
			// linkDemo
			// 
			this.linkDemo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkDemo.ImageList = this.imageList1;
			this.linkDemo.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
			this.linkDemo.Location = new System.Drawing.Point(118, 85);
			this.linkDemo.Name = "linkDemo";
			this.linkDemo.Size = new System.Drawing.Size(456, 24);
			this.linkDemo.TabIndex = 2;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/";
			this.linkDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkDemo.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonUpdate);
			this.groupBox1.Location = new System.Drawing.Point(60, 151);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 315);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Text = "Properties";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.buttonUpdate.Location = new System.Drawing.Point(28, 234);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(195, 52);
			this.buttonUpdate.TabIndex = 0;
			this.buttonUpdate.Text = "Update";
			// 
			// panel
			// 
			this.panel.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.panel.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel.Location = new System.Drawing.Point(367, 151);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(455, 315);
			this.panel.TabIndex = 4;
			this.panel.TabStop = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "DOCS:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "API:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "DEMO:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TestBase
			// 
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkDemo);
			this.Controls.Add(this.linkAPI);
			this.Controls.Add(this.linkDocs);
			this.Name = "TestBase";
			this.Size = new System.Drawing.Size(864, 505);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void linkDocs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Navigate(e.Link, "Syncfusion");
		}
	}
}