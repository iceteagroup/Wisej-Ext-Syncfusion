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
	/// A Map is a graphical representation of geographical data. It is used to represent 
	/// the statistical data of a particular geographical area on Earth. Using pan and zoom, 
	/// the maps can be navigated. Maps supports enhanced data visualization with bubbles 
	/// and labels using data bound to the map.
	/// </summary>
	public class ejMap : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejMap"/> class.
		/// </summary>
		public ejMap() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejMap"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejMap(object options) : base("ejMap", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"onLoad",
				"panned",
				"refreshed",
			};
		}
	}
}
