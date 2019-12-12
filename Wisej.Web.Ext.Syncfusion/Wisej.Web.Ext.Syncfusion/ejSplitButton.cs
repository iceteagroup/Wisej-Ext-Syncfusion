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
	/// The Split button allows you to perform an action using clicking the button 
	/// and choosing extra options from the dropdown button. The Split button 
	/// also can display both text and images.
	/// </summary>
	public class ejSplitButton : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejSplitButton"/> class.
		/// </summary>
		public ejSplitButton() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejSplitButton"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejSplitButton(object options) : base("ejSplitButton", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"close",
				"beforeOpen",
				"itemSelected",
				"itemMouseOut",
				"itemMouseOver"
			};
		}
	}
}
