using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejSymbolPalette : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejSymbolPalette()
		{
			InitializeComponent();
		}

		private void ejDiagram1_Appear(object sender, EventArgs e)
		{
			this.ejSymbolPalette1.Options.diagramId = $"id_{this.ejDiagram1.Handle}_container";
		}

		private void ejDiagram1_WidgetEvent(object sender, WidgetEventArgs e)
		{

		}
	}
}
