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
	/// Essential Diagram JavaScript creates rich Visio-like applications. 
	/// It's Framework comprises of many Elements that helps you to create 
	/// an application easily. The rich feature set of the Diagram control 
	/// includes Snapping, Guidelines, Gridlines, Serialization and Zooming.
	/// </summary>
	public class ejDiagram : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejDiagram"/> class.
		/// </summary>
		public ejDiagram() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejDiagram"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejDiagram(object options) : base("ejDiagram", options)
		{
			this.WiredEvents = new[] {
				"click",
				"itemClick",
				"textChange",
				"doubleClick",
				"connectionChange",
				"contextMenuClick",
				"connectorTargetChange",
				"connectorCollectionChange",
			};
		}
	}
}
