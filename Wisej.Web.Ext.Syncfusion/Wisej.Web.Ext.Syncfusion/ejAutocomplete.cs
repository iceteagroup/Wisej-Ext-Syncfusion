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
	/// The Autocomplete control for JavaScript is a textbox control that provides 
	/// a list of suggestions based on the user query.
	/// </summary>
	/// <remarks>
	/// <para>
	/// When the user enters a text 
	/// in the text box, the control performs the search operation and provides a list of 
	/// results in the suggestion pop up. There are several filter types available to perform the search.
	/// </para>
	/// <para>
	/// See demo at: 
	/// </para>
	/// </remarks>
	public class ejAutocomplete : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejAutocomplete"/> class.
		/// </summary>
		public ejAutocomplete() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejAutocomplete"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejAutocomplete(object options) : base("ejAutocomplete", "<input style='width:100%;height:100%'>", options)
		{
			this.WidgetWiredEvents = new[] {
				"open",
				"close",
				"change",
				"select",
				"focusIn",
				"focusOut"
			};
		}

		public string Value
		{
			get {
				var ret = "";
				Eval("getValue", (r) => { ret = r; });
				return ret;
			}
			set {
				Call("setValue", value);
			}
		}
	}
}
