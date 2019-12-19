using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejGantt : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejGantt()
		{
			InitializeComponent();

			this.ejGantt1.Widget.rowSelected += new WidgetEventHandler(ejGantt1_WidgetEvent);
			this.ejGantt1.Widget.taskbarClick += new WidgetEventHandler(ejGantt1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejGantt1.Options.showColumnOptions = this.checkBoxShowColumnOptions.Checked;
			this.ejGantt1.Options.showProgressStatus = this.checkBoxShowProgressStatus.Checked;
			this.ejGantt1.Options.scheduleEndDate = DateTime.Parse(this.textBoxScheduleEndDate.Text).ToShortDateString();
			this.ejGantt1.Options.scheduleStartDate = DateTime.Parse(this.textBoxScheduleStartDate.Text).ToShortDateString();
			
			this.ejGantt1.Update();
		}

		private void ejGantt1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
