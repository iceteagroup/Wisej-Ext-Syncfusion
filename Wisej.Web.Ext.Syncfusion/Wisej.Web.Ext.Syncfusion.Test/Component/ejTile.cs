using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejTile : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejTile()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTile5.Options.badge = new {
				enabled = true,
				value = (int)this.numericUpDown1.Value
			};

			this.ejTile5.Update();


			this.ejTile1.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile6.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile1.Update();
			this.ejTile6.Update();


		}
	}
}
