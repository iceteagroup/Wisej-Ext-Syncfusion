using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejSignature : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejSignature()
		{
			InitializeComponent();

			this.ejSignature1.Widget.change += new WidgetEventHandler(ejSignature1_WidgetEvent);
		}

		private void ejSignature1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Widget.save("UserSignature");
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Widget.clear();
		}

		private void buttonRedo_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Widget.redo();
		}

		private void buttonUndo_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Widget.undo();
		}
	}
}
