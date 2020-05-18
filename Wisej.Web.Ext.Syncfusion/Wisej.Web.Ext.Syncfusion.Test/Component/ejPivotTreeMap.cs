using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejPivotTreeMap : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejPivotTreeMap()
		{
			InitializeComponent();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejPivotTreeMap1.Widget.getJSONRecordsAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(data);
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "ejPivotTreeMapData.json");
				}
				catch (Exception ex)
				{
					AlertBox.Show(ex.Message);
				}
			}
		}
	}
}
