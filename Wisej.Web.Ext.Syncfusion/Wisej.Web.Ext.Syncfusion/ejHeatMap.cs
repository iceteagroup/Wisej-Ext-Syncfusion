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
	/// Essential HeatMap JS represents tabular data values as gradient colors instead 
	/// of numbers,low and high values are different colors with different gradients.
	/// </summary>
	public class ejHeatMap : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejHeatMap"/> class.
		/// </summary>
		public ejHeatMap() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejHeatMap"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejHeatMap(object options) : base("ejHeatMap", options)
		{
			this.WiredEvents = new[] {
				"cellSelected",
				"cellMouseOver"
			};
		}
	}
}
