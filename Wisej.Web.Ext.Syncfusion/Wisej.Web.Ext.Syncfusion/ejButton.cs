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
	/// The Essential JavaScript Button control allows you to perform an action by 
	/// clicking on it.
	/// </summary>
	/// <remarks>
	/// 
	/// <para>
	/// The Essential JavaScript Button control has the feature of 
	/// displaying both text and images. When the Button is clicked, it looks as if 
	/// it is being pushed in and released. The Text property is used to display the 
	/// Text content in Button. The Button control displays images using the sprite 
	/// CSS and Image Position properties. The Essential JavaScript Buttons control 
	/// has theme support. While using input type submit, reset and button to be render 
	/// as button, has text only support.
	/// </para>
	/// <para>
	/// See docs at: <see href="https://help.syncfusion.com/api/js/ejbutton"/>
	/// </para>
	/// </remarks>
	public class ejButton : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejButton"/> class.
		/// </summary>
		public ejButton() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejButton"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejButton(object options) : base("ejButton", "<button style='width:100%;height:100%'>", options)
		{
			this.WidgetWiredEvents = new[] {
				"click"
			};
		}
	}
}
