using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejSchedule : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejSchedule()
		{
			InitializeComponent();

			this.ejSchedule1.Instance.cellClick += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.menuItemClick += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.cellDoubleClick += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.appointmentClicked += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.appointmentChanged += new WidgetEventHandler(ejSchedule1_WidgetEvent);
		}

		private void ejSchedule1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSchedule1.Options.showWeekend = this.checkBox1.Checked;
			this.ejSchedule1.Options.allowDelete = this.checkBox2.Checked;
			this.ejSchedule1.Options.allowKeyboardNavigation = this.checkBox3.Checked;
			this.ejSchedule1.Options.allowInline = this.checkBox4.Checked;
			this.ejSchedule1.Options.showAppointmentNavigator = this.checkBox5.Checked;
			this.ejSchedule1.Options.currentView = this.comboBox1.Text.ToLowerInvariant();
			this.ejSchedule1.Options.orientation = this.comboBox2.Text.ToLowerInvariant();

			this.ejSchedule1.Update();
		}
	}
}
