using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejDropDownTree : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejDropDownTree()
		{
			InitializeComponent();

			this.ejDropDownTree1.Widget.change += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
			this.ejDropDownTree1.Widget.select += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
			this.ejDropDownTree1.Widget.checkChange += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDropDownTree1.Options.enableFilterSearch = this.checkBoxEnableFilterSearch.Checked;
			this.ejDropDownTree1.Options.treeViewSettings.showCheckbox = this.checkBoxShowCheckbox.Checked;
			this.ejDropDownTree1.Options.popupSettings.height = $"{this.numericUpDownPopupHeight.Value}px";

			this.ejDropDownTree1.Update();
		}

		private void ejDropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
