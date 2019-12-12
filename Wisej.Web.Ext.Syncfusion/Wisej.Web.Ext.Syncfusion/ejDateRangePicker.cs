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
	/// The DateRangePicker control displaying two calendars 
	/// in a web page and allow to pick the two date to form 
	/// the ranges. Also its calendar consist of flexible option 
	/// to navigate back and forth from month and years and 
	/// pick the start and end date in any month. Flexible options 
	/// of this DateRangePicker provides the easiest way to get the 
	/// details within the date ranges in application
	/// </summary>
	public class ejDateRangePicker : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejDateRangePicker"/> class.
		/// </summary>
		public ejDateRangePicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejDateRangePicker"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejDateRangePicker(object options) : base("ejDateRangePicker", options)
		{
			this.WidgetWiredEvents = new[] {
				"open",
				"close",
				"select",
				"change",
				"beforeOpen",
				"beforeClose",
			};
		}
	}
}
