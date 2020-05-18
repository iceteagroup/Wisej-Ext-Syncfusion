using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
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

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Options.saveWithBackground = this.checkBox1.Checked;
			this.ejSignature1.Options.showRoundedCorner = this.checkBox2.Checked;

			this.ejSignature1.Update();
		}
	}
}
