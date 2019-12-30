using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejSunburstChart : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejSunburstChart()
		{
			InitializeComponent();

			this.ejSunburstChart1.Widget.click += new WidgetEventHandler(ejSunburstChart1_WidgetEvent);
			this.ejSunburstChart1.Widget.legendItemClick += new WidgetEventHandler(ejSunburstChart1_WidgetEvent);
		}

		private void ejSunburstChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
