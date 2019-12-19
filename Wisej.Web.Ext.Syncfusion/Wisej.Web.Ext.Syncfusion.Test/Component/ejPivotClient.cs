using System;
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
			this.ejPivotClient1.Options.chartType = this.comboBoxChartType.Text.ToLower();
			this.ejPivotClient1.Options.enableCellClick = this.checkBoxEnableCellClick.Checked;
			this.ejPivotClient1.Options.enableSplitter = this.checkBoxEnableSplitter.Checked;

			this.ejPivotClient1.Update();
		}
	}
}
