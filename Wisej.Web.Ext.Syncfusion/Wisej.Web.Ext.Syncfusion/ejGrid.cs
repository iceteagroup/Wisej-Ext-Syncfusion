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
	/// The Grid control for JavaScript is an efficient display engine for tabular data. 
	/// It will pull data from a datasource such as array of JSON objects, OData web services,
	/// or ej.DataManager; binding data fields to columns and displaying a column header to identify
	/// the field. It is a feature-rich control that provides extensive appearance customization options 
	/// with support for grouped records. This Grid is very useful for generating complex grid-based 
	/// reports with rich formatting. The most important features available in the Grid control for 
	/// JavaScript are paging, sorting, filtering, searching, grouping, and editing
	/// </summary>
	public class ejGrid : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejGrid"/> class.
		/// </summary>
		public ejGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejGrid"/> class.
		/// </summary>
		public ejGrid(object options) : base("ejGrid", options)
		{
			this.WiredEvents = new[] {
				"cellSave",
				"batchSave",
				"rowSelected",
				"cellSelected",
				"toolbarClick",
			};
		}
	}
}
