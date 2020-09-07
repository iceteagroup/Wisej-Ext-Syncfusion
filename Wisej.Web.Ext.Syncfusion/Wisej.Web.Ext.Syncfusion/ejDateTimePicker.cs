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
	/// The Essential JavaScript DateTimePicker control is used to input the date and 
	/// time with a specific format. The DateTimePicker control combines the DatePicker 
	/// and TimePicker controls so that users can select the date and time with their 
	/// desired format.
	/// </summary>
	public class ejDateTimePicker : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejDateTimePicker"/> class.
		/// </summary>
		public ejDateTimePicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejDateTimePicker"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejDateTimePicker(object options) : base("ejDateTimePicker", "<input style='width:100%;height:100%' />", options)
		{
			this.WiredEvents = new[] {
				"open",
				"close",
				"change",
				"beforeOpen",
				"beforeClose",
			};
		}
	}
}
