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
	/// The Report Viewer is a visualization control used to display SSRS, RDL, RDLC, 
	/// and Syncfusion Report Server reports within web applications. It allows you to 
	/// view RDL/RDLC reports with or without using SSRS or Syncfusion server. You can 
	/// bind data sources, parameters, and render reports with all major capabilities 
	/// of RDL reporting and export the report to PDF, Excel, CSV, Word, PowerPoint, 
	/// and HTML formats.
	/// </summary>
	public class ejReportViewer : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejReportViewer"/> class.
		/// </summary>
		public ejReportViewer() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejReportViewer"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejReportViewer(object options) : base("ejReportViewer", options)
		{
			this.WidgetWiredEvents = new[] {
				"viewReportClick",
				"toolbarItemClick",
				"printProgresschanged",
				"exportProgressChanged"
				
			};
		}
	}
}
