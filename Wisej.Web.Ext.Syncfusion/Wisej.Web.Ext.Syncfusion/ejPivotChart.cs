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
	/// The pivot chart control for Essential JavaScript is a lightweight control 
	/// that reads both OLAP and relational data sources and visualizes them in a 
	/// graphical format with the ability to drill up and down.
	/// </summary>
	public class ejPivotChart : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotChart"/> class.
		/// </summary>
		public ejPivotChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotChart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejPivotChart(object options) : base("ejPivotChart", options)
		{
			this.WiredEvents = new[] {
				"drillSuccess",
				"afterServiceInvoke",
				"beforeServiceInvoke"
			};
		}
	}
}
