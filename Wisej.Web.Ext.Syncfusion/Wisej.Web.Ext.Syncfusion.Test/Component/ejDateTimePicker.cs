using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejDateTimePicker : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejDateTimePicker()
		{
			InitializeComponent();

			this.ejDateTimePicker1.Widget.open += new WidgetEventHandler(ejDateTimePicker1_WidgetEvent);
			this.ejDateTimePicker1.Widget.close += new WidgetEventHandler(ejDateTimePicker1_WidgetEvent);
			this.ejDateTimePicker1.Widget.change += new WidgetEventHandler(ejDateTimePicker1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDateTimePicker1.Options.dateTimeFormat = this.textBox1.Text;
			this.ejDateTimePicker1.Options.startDay = this.numericUpDown1.Value;

			this.ejDateTimePicker1.Update();
		}

		private void ejDateTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		
	}
}
