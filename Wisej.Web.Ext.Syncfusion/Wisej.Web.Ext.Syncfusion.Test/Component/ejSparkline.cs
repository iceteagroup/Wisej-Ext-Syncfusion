using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejSparkline : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejSparkline()
		{
			InitializeComponent();

			this.ejSparkline1.Widget.click += new WidgetEventHandler(ejSparkline1_WidgetEvent);
		}

		private void ejSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSparkline1.Options.type = this.comboBoxChartType.Text.ToLower();
			this.ejSparkline1.Options.enableCanvasRendering = this.checkBoxCanvasRendering.Checked;

			this.ejSparkline1.Update();
		}
	}
}
