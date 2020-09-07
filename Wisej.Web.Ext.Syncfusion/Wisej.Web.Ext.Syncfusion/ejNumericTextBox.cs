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
	/// NumericTextBox is used to display only numeric values. It has Spin buttons to increase or decrease the values in the Text Box.
	/// </summary>
	public class ejNumericTextbox : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejNumericTextbox"/> class.
		/// </summary>
		public ejNumericTextbox() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejNumericTextbox"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejNumericTextbox(object options) : base("ejNumericTextbox", "<input style='width:100%;height:100%'>", options)
		{
			this.WiredEvents = new[] {
				"change"
			};
		}
	}
}
