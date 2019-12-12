using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejCircularGauge : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejCircularGauge()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejCircularGauge1.Value = 
				Convert.ToInt32(this.numericUpDown1.Value);

			var scales = this.ejCircularGauge1.Options.scales;
			for (var i = 0; i < scales.Length; i++)
			{
				scales[i].showTicks = this.checkBox1.Checked;
			}

			var ranges = scales[0].ranges;
			for (var i = 0; i < ranges.Length; i++)
			{
				ranges[i].distanceFromScale = this.trackBar1.Value;
				ranges[i].size = this.trackBar2.Value;
			}

			this.ejCircularGauge1.Update();
		}	
	}
}
