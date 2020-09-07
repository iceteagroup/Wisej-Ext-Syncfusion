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
	/// Sparklines are easy to interpret and also it conveys much more information 
	/// to the user by visualizing the data in a small amount of space.
	/// </summary>
	public class ejSparkline : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejSparkline"/> class.
		/// </summary>
		public ejSparkline() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejSparkline"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejSparkline(object options) : base("ejSparkline", options)
		{
			this.WiredEvents = new[] {
				"load",
				"click",
				"rightClick",
				"doubleClick",
				"pointRegionMouseMove",
				"pointRegionMouseClick"
			};
		}
	}
}
