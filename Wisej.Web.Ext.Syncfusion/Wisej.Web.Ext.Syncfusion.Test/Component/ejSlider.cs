using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejSlider : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejSlider()
		{
			InitializeComponent();

			this.ejSlider1.Widget.change += new WidgetEventHandler(ejSlider1_WidgetEvent);
		}

		private void ejSlider1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
