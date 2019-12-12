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
	/// The Essential JavaScript ListView widget builds interactive ListView interface. 
	/// This control allows you to select an item from a list-like interface and display 
	/// a set of data items in different layouts or views. Lists are used for displaying 
	/// data, data navigation, result lists, and data entry.
	/// </summary>
	public class ejListView : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejListView"/> class.
		/// </summary>
		public ejListView() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejListView"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejListView(object options) : base("ejListView", options)
		{
			this.WidgetWiredEvents = new[] {
				"ajaxError",
				"ajaxSuccess",
				"ajaxComplete",
				"ajaxBeforeLoad",
			};
		}
	}
}
