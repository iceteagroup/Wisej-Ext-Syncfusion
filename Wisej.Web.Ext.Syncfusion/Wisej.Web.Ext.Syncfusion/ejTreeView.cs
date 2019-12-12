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
	/// TreeView control for JavaScript represents hierarchical data in tree 
	/// like structure with advanced functions to perform edit, drag and drop,
	/// selection with checkboxes and more. TreeView can be generated from ‘UL LI’ elements,
	/// JSON data source or using OData services.
	/// </summary>
	public class ejTreeView : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejTreeView"/> class.
		/// </summary>
		public ejTreeView() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejTreeView"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejTreeView(object options) : base("ejTreeView", options)
		{
			this.WidgetWiredEvents = new[] {
				"nodeAdd",
				"nodeCut",
				"keyPress",
				"beforeAdd",		
				"beforeCut",
				"nodeCheck",
				"nodeClick",
				"nodeSelect",
				"nodeDelete",
				"beforeEdit",
				"beforeDelete",
				"nodeCollapse",
				"beforeCollapse"
			};
		}
	}
}
