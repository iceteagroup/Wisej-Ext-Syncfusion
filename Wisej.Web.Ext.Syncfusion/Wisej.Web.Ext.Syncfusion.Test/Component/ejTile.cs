using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejTile : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejTile()
		{
			InitializeComponent();

			ejTile1.Widget.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile2.Widget.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile3.Widget.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile4.Widget.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile5.Widget.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile6.Widget.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);

		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTile5.Options.badge = new {
				enabled = true,
				value = (int)this.numericUpDown1.Value
			};

			this.ejTile5.Update();


			this.ejTile1.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile6.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile1.Update();
			this.ejTile6.Update();


		}

		private void ejTile_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
