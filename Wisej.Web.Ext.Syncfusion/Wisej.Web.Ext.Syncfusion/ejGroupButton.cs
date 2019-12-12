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
	/// The Essential JavaScript Group Button widget helps to display multiple buttons which are 
	/// stacked together in a single line and used as a navigation component. Also it manages the 
	/// checked/unchecked state for a set of buttons, since it supports radio and check button modes.
	/// </summary>
	public class ejGroupButton : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejGroupButton"/> class.
		/// </summary>
		public ejGroupButton() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejGroupButton"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejGroupButton(object options) : base("ejGroupButton", options)
		{
			this.WidgetWiredEvents = new[] {
				"select",
				"keyPress",
			};
		}
	}
}
