using Syncfusion.EJ.Export;
using System;
using System.Linq;
using System.Web;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejPivotClient : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejPivotClient()
		{
			InitializeComponent();

			this.ejPivotClient1.Widget.cellEdit += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Widget.saveReport += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Widget.beforeExport += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Widget.cellSelection += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Widget.cellDoubleClick += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
		}

		private void ejPivotClient1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejPivotClient1.Options.chartType = this.comboBox1.Text.ToLower();
			this.ejPivotClient1.Options.enableCellClick = this.checkBox1.Checked;
			this.ejPivotClient1.Options.enableSplitter = this.checkBox2.Checked;

			this.ejPivotClient1.Update();
		}

		private void ejPivotClient1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.Url.Segments.Last())
			{
				case "Export":
					ExportPivotClientData(e);
					break;

				default:
					break;

			}
		}

		private void ExportPivotClientData(WebRequestEventArgs webRequestEvent)
		{
			var pivotClientExport = new PivotClientExport();
			pivotClientExport.ExportPivotClient("myPivotClient", webRequestEvent.Request.Form[0], webRequestEvent.Response);
		}
	}
}
