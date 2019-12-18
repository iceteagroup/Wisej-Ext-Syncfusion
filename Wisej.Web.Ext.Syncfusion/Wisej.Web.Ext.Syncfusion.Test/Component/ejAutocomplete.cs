using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejAutocomplete : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejAutocomplete()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AlertBox.Show(this.ejAutocomplete1.Value);
		}
	}
}
