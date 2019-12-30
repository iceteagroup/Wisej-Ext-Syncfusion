using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test
{
	public partial class ejTreeGrid : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejTreeGrid()
		{
			InitializeComponent();

			this.ejTreeGrid1.Widget.recordClick += new WidgetEventHandler(ejTreeGrid1_WidgetEvent);
			this.ejTreeGrid1.Widget.cellSelected += new WidgetEventHandler(ejTreeGrid1_WidgetEvent);
		}

		private void ejTreeGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGetSelectedCells_Click(object sender, EventArgs e)
		{
			var selectedCells = await this.ejTreeGrid1.Widget.getSelectedCellsAsync();

			AlertBox.Show(selectedCells.ToString());
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeGrid1.Options.allowTextWrap = this.checkBoxAllowTextWrap.Checked;
			this.ejTreeGrid1.Options.allowSelection = this.checkBoxAllowSelection.Checked;

			this.ejTreeGrid1.Update();
		}
	}
}
