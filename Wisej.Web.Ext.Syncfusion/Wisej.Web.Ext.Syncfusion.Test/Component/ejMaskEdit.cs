using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejMaskEdit : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejMaskEdit()
		{
			InitializeComponent();

			this.ejMaskEdit1.Widget.change += new WidgetEventHandler(ejMaskEdit1_WidgetEvent);
			this.ejMaskEdit1.Widget.keyPress += new WidgetEventHandler(ejMaskEdit1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejMaskEdit1.Options.inputMode = this.comboBoxInputMode.Text;

			this.ejMaskEdit1.Update();
		}

		private void ejMaskEdit1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
