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
	/// The Toggle Button allows you to perform the toggle option by using checked 
	/// and unchecked state. This Toggle Button can be helpful to user to check their 
	/// states. The Toggle Button control displays both text and images.
	/// </summary>
	public class ejToggleButton : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejToggleButton"/> class.
		/// </summary>
		public ejToggleButton() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejToggleButton"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejToggleButton(object options) : base("ejToggleButton", "<input type='checkbox' style='height:100%;width:100%' />", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"change"
			};
		}
	}
}
