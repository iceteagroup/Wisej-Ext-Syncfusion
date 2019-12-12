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
	/// The pivot client control for the Essential JavaScript provides support to bind both 
	/// the OLAP and relational data sources. You can visualize the results in graphical and 
	/// tabular formats (chart and grid). The pivot client control is also used to create and 
	/// edit a report on-the-fly that is stored for later use.
	/// </summary>
	public class ejPivotClient : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotClient"/> class.
		/// </summary>
		public ejPivotClient() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotClient"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejPivotClient(object options) : base("ejPivotClient", options)
		{
		}
	}
}
