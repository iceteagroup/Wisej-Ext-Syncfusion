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
	/// The Toolbar control supports displaying a list of tools within a web page. 
	/// This control is capable of customizing toolbar items with any functionality 
	/// by using enriched client-side methods. This control is composed of collection 
	/// of unordered lists containing text and images contained into a div.
	/// </summary>
	public class ejToolbar : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejToolbar"/> class.
		/// </summary>
		public ejToolbar() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejToolbar"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejToolbar(object options) : base("ejToolbar", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"itemHover",
				"itemLeave",
				"overflowOpen",
				"overflowClose"
			};
		}
	}
}
