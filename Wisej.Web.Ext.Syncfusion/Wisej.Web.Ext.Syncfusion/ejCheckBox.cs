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
	/// The CheckBox control allows you to check an option to perform an action. 
	/// This control allows you to select true, false or an intermediate option. 
	/// These CheckBoxes are supported with themes. The HTML CheckBox control is 
	/// rendered as Essential JavaScript CheckBox control.
	/// </summary>
	public class ejCheckBox : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejCheckBox"/> class.
		/// </summary>
		public ejCheckBox() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejCheckBox"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejCheckBox(object options) : base("ejCheckBox", "<input style='width:100%;height:100%'>", options)
		{
			this.WidgetWiredEvents = new[] {
				"change",
				"beforeChange"
			};
		}
	}
}
