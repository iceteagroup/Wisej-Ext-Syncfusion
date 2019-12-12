using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejColorPicker : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejColorPicker()
		{
			InitializeComponent();
		}

		private void ejColorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$@"<b>{e.Type}</b><br/>
				{e.Data}",
				MessageBoxIcon.Information);

			if (e.Type == "select")
				this.textBox1.Text = e.Data?.value ?? "";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			ejColorPicker1.Options.value = textBox1.Text;
		}
	}
}
