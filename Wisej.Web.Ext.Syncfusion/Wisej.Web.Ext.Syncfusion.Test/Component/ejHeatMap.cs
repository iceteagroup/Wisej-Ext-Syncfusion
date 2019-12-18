using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejHeatMap : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejHeatMap()
		{
			InitializeComponent();
		}

		private void ejHeatMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{

		}

		private void ejHeatMapLegend1_Appear(object sender, EventArgs e)
		{
			//this.ejHeatMap1.Options.legendCollection = new String[] { $"id_{this.ejHeatMapLegend1.Handle}_container" };
			//this.ejHeatMapLegend1.Update();
			//this.ejHeatMap1.Update();
		}
	}
}
