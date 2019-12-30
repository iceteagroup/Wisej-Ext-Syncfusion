using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejToolbar : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejToolbar()
		{
			InitializeComponent();

			this.ejToolbar1.Widget.click += new WidgetEventHandler(ejToolbar1_WidgetEvent);
			this.ejToolbar1.Widget.itemHover += new WidgetEventHandler(ejToolbar1_WidgetEvent);
		}

		private void ejToolbar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
