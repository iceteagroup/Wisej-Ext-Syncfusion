using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejRecurrenceEditor : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejRecurrenceEditor()
		{
			InitializeComponent();

			this.ejRecurrenceEditor1.Widget.change += new WidgetEventHandler(ejRecurrenceEditor1_WidgetEvent);
		}

		private void ejRecurrenceEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGenerateRule_Click(object sender, EventArgs e)
		{
			var rule = await this.ejRecurrenceEditor1.Widget.getRecurrenceRuleAsync();

			AlertBox.Show(rule);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejRecurrenceEditor1.Widget.enableSpinners = this.checkBoxEnableSpinners.Checked;

			this.ejRecurrenceEditor1.Update();
		}
	}
}
