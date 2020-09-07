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
	/// The TimePicker control for JavaScript allows users to select a time value. 
	/// The available times can be restricted to a range by setting minimum and 
	/// maximum time values. The TimePicker sets the time as a mask to prevent 
	/// users from entering invalid values.
	/// </summary>
	public class ejTimePicker : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejTimePicker"/> class.
		/// </summary>
		public ejTimePicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejTimePicker"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejTimePicker(object options) : base("ejTimePicker", "<input style='width:100%;height:100%'>", options)
		{
			this.WiredEvents = new[] {
				"open",
				"close",
				"change",
				"select",
				"beforeOpen",
				"beforeChange"
			};
		}
	}
}
