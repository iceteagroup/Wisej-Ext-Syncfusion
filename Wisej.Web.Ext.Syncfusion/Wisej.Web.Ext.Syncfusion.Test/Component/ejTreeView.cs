using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejTreeView : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejTreeView()
		{
			InitializeComponent();

			this.ejTreeView1.Widget.nodeClick += new WidgetEventHandler(ejTreeView1_WidgetEvent);
			this.ejTreeView1.Widget.nodeCollapse += new WidgetEventHandler(ejTreeView1_WidgetEvent);
		}

		private void ejTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGetCheckedNodes_Click(object sender, EventArgs e)
		{
			var checkedNodes = await this.ejTreeView1.Widget.getCheckedNodesAsync();

			AlertBox.Show(JSON.Stringify(checkedNodes));
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeView1.Options.autoCheck = this.checkBoxAutoCheck.Checked;
			this.ejTreeView1.Options.showCheckbox = this.checkBoxShowCheckbox.Checked;

			this.ejTreeView1.Update();
		}
	}
}
