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
	/// The TagCloud allows the user to display a list of links or tags with a structured 
	/// cloud format where the importance of the tags can differentiate with varied font sizes, 
	/// colors, and styles.
	/// </summary>
	public class ejTagCloud : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejTagCloud"/> class.
		/// </summary>
		public ejTagCloud() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejTagCloud"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejTagCloud(object options) : base("ejTagCloud", options)
		{
			this.WiredEvents = new[] {
				"click",
				"create",
				"destroy",
				"mouseOut",
				"mouseOver"
			};
		}
	}
}
