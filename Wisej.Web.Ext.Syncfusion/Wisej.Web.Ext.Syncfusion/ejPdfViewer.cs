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
	/// PDF viewer for JavaScript is a visualization component for viewing and 
	/// printing the PDF documents in web pages. It is powered by HTML5 or 
	/// JavaScript and provides various customizations.
	/// </summary>
	public class ejPdfViewer : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejPdfViewer"/> class.
		/// </summary>
		public ejPdfViewer() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejPdfViewer"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejPdfViewer(object options) : base("ejPdfViewer", options)
		{
			this.WiredEvents = new[] {
				"pageClick",
				"documentLoad",
				"documentUnload"
			};
		}
	}
}
