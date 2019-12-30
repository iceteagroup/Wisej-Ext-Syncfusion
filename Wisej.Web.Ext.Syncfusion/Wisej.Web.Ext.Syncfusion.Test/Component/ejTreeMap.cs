using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejTreeMap : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejTreeMap()
		{
			InitializeComponent();

			this.ejTreeMap1.Widget.click += new WidgetEventHandler(ejTreeMap1_WidgetEvent);
			this.ejTreeMap1.Widget.doubleClick += new WidgetEventHandler(ejTreeMap1_WidgetEvent);
		}

		private void ejTreeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
