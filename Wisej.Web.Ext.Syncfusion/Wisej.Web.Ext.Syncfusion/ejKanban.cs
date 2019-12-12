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
	/// The Kanban control for JavaScript is an efficient way to visualize the workflow 
	/// at each stage along its path to completion. The most important features available 
	/// are Swim lane, filtering, and editing.
	/// </summary>
	public class ejKanban : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejKanban"/> class.
		/// </summary>
		public ejKanban() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejKanban"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejKanban(object options) : base("ejKanban", options)
		{
			this.WidgetWiredEvents = new[] {
				"cardClick",
				"dataBound",
				"cellClick",
				"contextClick",
				"swimlaneClick",
			};
		}
	}
}
