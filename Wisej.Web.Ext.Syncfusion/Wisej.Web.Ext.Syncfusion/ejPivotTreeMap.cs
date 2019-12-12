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
	/// The PivotTreemap is a lightweight control that reads OLAP information and 
	/// visualizes it in graphical format with the ability to drill up and down.
	/// </summary>
	public class ejPivotTreeMap : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotTreeMap"/> class.
		/// </summary>
		public ejPivotTreeMap() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotTreeMap"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejPivotTreeMap(object options) : base("ejPivotTreeMap", options)
		{
			this.WidgetWiredEvents = new[] {
				"drillSuccess",
				"afterServiceInvoke",
				"beforeServiceInvoke"
			};
		}
	}
}
