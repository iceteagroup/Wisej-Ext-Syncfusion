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
	/// Essential TreeMap for JavaScript is ideal for visualizing large amounts of data. 
	/// TreeMap holds a set of nested nodes to display hierarchical data. Each nested node 
	/// may contain sub-nodes containing area proportional to a specified data value bounded. 
	/// Color and annotation can be used to provide extra information about the leaf nodes.
	/// </summary>
	public class ejTreeMap : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejTreeMap"/> class.
		/// </summary>
		public ejTreeMap() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejTreeMap"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejTreeMap(object options) : base("ejTreeMap", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"refreshed",
				"rightClick",
				"doubleClick",
				"drillStarted",
				"drillDownItemSelected"
			};
		}
	}
}
