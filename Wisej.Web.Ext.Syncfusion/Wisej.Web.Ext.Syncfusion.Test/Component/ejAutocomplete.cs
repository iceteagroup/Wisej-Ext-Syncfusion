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

		private async void button1_Click(object sender, EventArgs e)
		{
			var selectedVal = await this.ejAutocomplete1.Widget.getValueAsync();

			AlertBox.Show(selectedVal);
		}
	}
}
