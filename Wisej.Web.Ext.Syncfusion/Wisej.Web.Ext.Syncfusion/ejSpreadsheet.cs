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
	/// The Spreadsheet control is a Microsoft Excel-like Spreadsheet component for web. 
	/// It provides editing experience that is very similar to that of Excel and it is 
	/// able to import and export Excel workbook files. The Spreadsheet control includes 
	/// all the important features of Microsoft Excel like editing, sorting, filtering, 
	/// formulas, data validation, formatting, table, charts, import and export.
	/// </summary>
	public class ejSpreadsheet : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejSpreadsheet"/> class.
		/// </summary>
		public ejSpreadsheet() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejSpreadsheet"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejSpreadsheet(object options) : base("ejSpreadsheet", options)
		{
			this.WidgetWiredEvents = new[] {
				"cellSave",
				"tabClick",
				"cellEdit",
				"cellClick",
				"menuClick",
				"cellSelected"
			};
		}
	}
}
