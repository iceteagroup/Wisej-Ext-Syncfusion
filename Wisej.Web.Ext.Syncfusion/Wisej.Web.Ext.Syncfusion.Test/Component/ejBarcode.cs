using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejBarcode : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejBarcode()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejBarcode1.Text = this.textBox1.Text;
			this.ejBarcode1.Options.symbologyType = this.comboBox1.Text;
		}
	}
}
