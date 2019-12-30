///////////////////////////////////////////////////////////////////////////////
//
// (C) 2019 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////


namespace Wisej.Web.Ext.Syncfusion
{
	/// <summary>
	/// 
	/// </summary>
	public class ejSunburstChart : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejSunburstChart"/> class.
		/// </summary>
		public ejSunburstChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejSunburstChart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejSunburstChart(object options) : base("ejSunburstChart", options)
		{
			this.WidgetWiredEvents = new[] {
				"load",
				"click",
				"loaded",
				"rightClick",
				"doubleClick",
				"drillDownBack",
				"drillDownClick",
				"legendItemClick",
				"pointRegionClick",
				"pointRegionMouseMove"
			};
		}
	}
}
