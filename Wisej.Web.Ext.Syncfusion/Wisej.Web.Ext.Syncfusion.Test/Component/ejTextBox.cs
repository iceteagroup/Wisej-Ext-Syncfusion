using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejTextBox : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejTextBox()
		{
			InitializeComponent();

			this.ejMaskEdit1.Widget.change += new WidgetEventHandler(ejTextbox_WidgetEvent);
			this.ejNumericTextbox1.Widget.change += new WidgetEventHandler(ejTextbox_WidgetEvent);
			this.ejPercentageTextbox1.Widget.change += new WidgetEventHandler(ejTextbox_WidgetEvent);
		}

		private void ejTextbox_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
