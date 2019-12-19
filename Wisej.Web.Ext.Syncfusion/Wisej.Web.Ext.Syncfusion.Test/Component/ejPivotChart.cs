using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejPivotChart : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejPivotChart()
		{
			InitializeComponent();

			this.ejPivotChart1.Widget.drillSuccess += new WidgetEventHandler(ejPivotChart1_WidgetEvent);
		}

		private void ejPivotChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExportExcel_Click(object sender, EventArgs e)
		{
			//TODO:
			//this.ejPivotChart1.Widget.exportPivotChart("excel");
		}

		private async void buttonSaveJson_Click(object sender, EventArgs e)
		{
			var data = await this.ejPivotChart1.Widget.optionAsync("dataSource");
			var json = Wisej.Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "pivotchart.json");
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejPivotChart1.Widget.renderChartFromJSON(JSON.Parse(json));

					this.ejPivotChart1.Update();
				}
			}
		}
	}
}
