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
	/// The Rating control provides an intuitive Rating experience that enables you 
	/// to select a number of stars that represent a Rating. You can configure the 
	/// item size, orientation and the number of displayed items in the Rating control. 
	/// You can also customize the Rating star image by using custom CSS.
	/// </summary>
	public class ejRating : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejRating"/> class.
		/// </summary>
		public ejRating() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejRating"/> class.
		/// </summary>s
		/// <param name="options">Initial set of options.</param>
		public ejRating(object options) : base("ejRating", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"change",
				"mouseout",
				"mouseover"
			};
		}
	}
}
