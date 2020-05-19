using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejDateRangePicker : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejDateRangePicker()
		{
			InitializeComponent();

			this.ejDateRangePicker1.Widget.open += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
			this.ejDateRangePicker1.Widget.close += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
			this.ejDateRangePicker1.Widget.select += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
			this.ejDateRangePicker1.Widget.change += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDateRangePicker1.Options.value = $"{DateTime.Parse(this.textBoxStartDay.Text).ToShortDateString()} - {DateTime.Parse(this.textBoxEndDay.Text).ToShortDateString()}";
			this.ejDateRangePicker1.Options.allowEdit = this.checkBox1.Checked;
			this.ejDateRangePicker1.Options.enableTimePicker = this.checkBox2.Checked;

			this.ejDateRangePicker1.Update();
		}

		private void ejDateRangePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
