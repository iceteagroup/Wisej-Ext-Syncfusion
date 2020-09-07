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
	/// The Essential Javascript Pager control allows you to navigate between records 
	/// which are sectioned into pages. The navigation between pages which is key 
	/// functionality of Pager is done using built-in numeric and navigation buttons 
	/// and provides easy user interaction.
	/// </summary>
	public class ejPager : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejPager"/> class.
		/// </summary>
		public ejPager() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejPager"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejPager(object options) : base("ejPager", options)
		{
			this.WiredEvents = new[] {
				"click",
				"change"
			};
		}
	}
}
