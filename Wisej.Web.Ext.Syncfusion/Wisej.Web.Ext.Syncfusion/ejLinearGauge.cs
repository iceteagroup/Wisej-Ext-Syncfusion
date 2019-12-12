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
	/// The Gauge control for Essential Studio displays numerical information in the 
	/// form of a scale that can be customized and oriented either vertically or horizontally. 
	/// </summary>
	public class ejLinearGauge : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejLinearGauge"/> class.
		/// </summary>
		public ejLinearGauge() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejLinearGauge"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejLinearGauge(object options) : base("ejLinearGauge", options)
		{
			this.WidgetWiredEvents = new[] {
				"init",
				"mouseClick",
				"rightClick",
				"doubleClick",
				"renderComplete"
			};
		}
	}
}
