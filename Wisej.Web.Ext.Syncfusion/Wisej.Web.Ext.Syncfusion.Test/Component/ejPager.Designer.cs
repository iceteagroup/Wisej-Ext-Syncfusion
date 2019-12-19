namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejPager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPager));
			this.ejPager1 = new Wisej.Web.Ext.Syncfusion.ejPager();
			this.ejRotator1 = new Wisej.Web.Ext.Syncfusion.ejRotator();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pager/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpager";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejRotator1);
			this.panel.Controls.Add(this.ejPager1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(519, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/pager/DefaultFunctionalities";
			// 
			// ejPager1
			// 
			this.ejPager1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejPager1.Location = new System.Drawing.Point(20, 250);
			this.ejPager1.Name = "ejPager1";
			this.ejPager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"pageSize\":1,\"totalPages\":6,\"totalRecordsCount\":6,\"pageCount\":3,\"isResponsive\":t" +
        "rue}")));
			this.ejPager1.Size = new System.Drawing.Size(412, 44);
			this.ejPager1.TabIndex = 3;
			this.ejPager1.Text = "ejPager1";
			// 
			// ejRotator1
			// 
			this.ejRotator1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejRotator1.Location = new System.Drawing.Point(20, 20);
			this.ejRotator1.Name = "ejRotator1";
			this.ejRotator1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejRotator1.Options"))));
			this.ejRotator1.Size = new System.Drawing.Size(412, 224);
			this.ejRotator1.TabIndex = 2;
			this.ejRotator1.Text = "ejRotator1";
			// 
			// ejPager
			// 
			this.Name = "ejPager";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPager ejPager1;
		private Syncfusion.ejRotator ejRotator1;
	}
}
