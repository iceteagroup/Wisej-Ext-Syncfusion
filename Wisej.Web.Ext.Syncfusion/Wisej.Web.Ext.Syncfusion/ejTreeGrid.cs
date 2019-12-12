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
	/// The Essential JavaScript TreeGrid is an efficient control designed for 
	/// representing the hierarchical data in a tabular format, combining the 
	/// visual representation of Grid and TreeView controls. It represents the 
	/// data from datasource such as array of JSON objects, ej.DataManager or 
	/// self-referential datasource.
	/// </summary>
	public class ejTreeGrid : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejTreeGrid"/> class.
		/// </summary>
		public ejTreeGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejTreeGrid"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejTreeGrid(object options) : base("ejTreeGrid", options)
		{
			this.WidgetWiredEvents = new[] {
				"endEdit",
				"expanded",
				"collapsed",
				"columnDrag",
				"rowSelected",
				"recordClick",
				"toolbarClick",
				"cellSelected",
				"detailsShown",
				"rowDataBound",
				"detailsHidden",
				"queryCellInfo",
				"detailsDataBound",
				"recordDoubleClick",
			};
		}
	}
}
