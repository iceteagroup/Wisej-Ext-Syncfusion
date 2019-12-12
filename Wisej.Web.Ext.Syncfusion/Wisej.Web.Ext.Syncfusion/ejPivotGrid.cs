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
	/// PivotGrid control is an easily configurable and presentation-quality business control. 
	/// It reads both OLAP and relational datasources, and allows to create multi-dimensional 
	/// views for analyzing and satisfying the needs of business user.
	/// </summary>
	public class ejPivotGrid : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotGrid"/> class.
		/// </summary>
		public ejPivotGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejPivotGrid"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejPivotGrid(object options) : base("ejPivotGrid", options)
		{
			this.WidgetWiredEvents = new[] {
				"cellEdit",
				"cellClick",
				"saveReport",
				"loadReport",
				"cellDoubleClick"
			};
		}
	}
}
