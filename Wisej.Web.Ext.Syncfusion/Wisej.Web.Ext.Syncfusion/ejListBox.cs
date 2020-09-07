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
	/// The ListBox control provides a list of options for users to select from. 
	/// It is capable of including other HTML elements such as images, text boxes, 
	/// check boxes, and radio buttons and so on. It also supports data binding, 
	/// template options and multi-select options.
	/// </summary>
	public class ejListBox : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejListBox"/> class.
		/// </summary>
		public ejListBox() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejListBox"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejListBox(object options) : base("ejListBox", options)
		{
			this.WiredEvents = new[] {
				"change",
				"select",
				"itemDrag",
				"unselect",
				"checkChange"
			};
		}
	}
}
