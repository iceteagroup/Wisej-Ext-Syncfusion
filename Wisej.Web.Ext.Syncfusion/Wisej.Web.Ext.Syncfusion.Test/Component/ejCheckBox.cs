using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejCheckBox : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejCheckBox()
		{
			InitializeComponent();

			this.ejCheckBox1.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox2.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox3.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox4.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox5.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox6.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox7.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox8.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox9.Widget.change += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
		}

		private void ejCheckBoxes_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
