using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejDatePicker : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejDatePicker()
		{
			InitializeComponent();

			this.ejDatePicker1.Widget.open += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Widget.close += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Widget.select += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Widget.change += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
		}

		private void ejDatePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDatePicker1.Options.allowDrillDown = this.checkBox2.Checked;
			this.ejDatePicker1.Options.showOtherMonths = this.checkBox3.Checked;
			this.ejDatePicker1.Options.enableStrictMode = this.checkBox1.Checked;
		}
	}
}
