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
	/// The Report Designer control for Javascript helps to create and edit reports 
	/// in open Report Definition Language (RDL) specification by products like 
	/// Microsoft SQL Server Reporting Services. It comes with a wide range of report 
	/// items to transform data into meaningful information and quickly build the reports.
	/// </summary>
	public class ejReportDesigner : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejReportDesigner"/> class.
		/// </summary>
		public ejReportDesigner() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejReportDesigner"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejReportDesigner(object options) : base("ejReportDesigner", options)
		{
			this.WidgetWiredEvents = new[] {
				"reportSaved",
				"previewReport",
				"reportModified",
				"openReportClick",
				"saveReportClick"
			};
		}
	}
}
