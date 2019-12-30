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
	/// The symbol palette control allows to predefine the frequently used nodes 
	/// and connectors and to drag and drop those nodes/connectors to drawing area.
	/// </summary>
	public class ejSymbolPalette : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejSymbolPalette"/> class.
		/// </summary>
		public ejSymbolPalette() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejSymbolPalette"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejSymbolPalette(object options) : base("ejSymbolPalette", options)
		{
			this.WidgetWiredEvents = new[] {
				"selectionChange"
			};
		}
	}
}
