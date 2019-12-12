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
	/// The Essential JavaScript Gantt control is designed to visualize and edit the 
	/// project schedule, and track the project progress. It helps to organize and schedule the 
	/// projects and also you can update the project schedule through 
	/// interactions like editing, dragging and resizing.
	/// </summary>
	public class ejGantt : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejGantt"/> class.
		/// </summary>
		public ejGantt() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejGantt"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejGantt(object options) : base("ejGantt", options)
		{
			this.WidgetWiredEvents = new[] {
				"rowSelected",
				"taskbarClick" };
		}
	}
}
