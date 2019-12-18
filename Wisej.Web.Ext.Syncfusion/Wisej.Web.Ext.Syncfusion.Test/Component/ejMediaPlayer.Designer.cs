namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	partial class ejMediaPlayer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejMediaPlayer));
			this.ejMediaPlayer1 = new Wisej.Web.Ext.Syncfusion.ejMediaPlayer();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/mediaplayer/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejmediaplayer";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejMediaPlayer1);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(619, 24);
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/mediaplayer/DefaultFunctionaliti" +
    "es";
			// 
			// ejMediaPlayer1
			// 
			this.ejMediaPlayer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ejMediaPlayer1.Location = new System.Drawing.Point(21, 20);
			this.ejMediaPlayer1.Name = "ejMediaPlayer1";
			this.ejMediaPlayer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejMediaPlayer1.Options"))));
			this.ejMediaPlayer1.Size = new System.Drawing.Size(410, 272);
			this.ejMediaPlayer1.Text = "ejMediaPlayer1";
			// 
			// ejMediaPlayer
			// 
			this.Name = "ejMediaPlayer";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejMediaPlayer ejMediaPlayer1;
	}
}
