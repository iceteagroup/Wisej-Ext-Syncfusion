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
	/// Essential JavaScript ProgressBar control is a graphical control element 
	/// http://en.wikipedia.org/wiki/Graphical_control_element used to visualize 
	/// the changing status of an extended operation. It is available in JavaScript 
	/// product. ProgressBar provides an interactive way to display the progression 
	/// of the task. You can configure the item size, orientation and the display text 
	/// on the ProgressBar control.
	/// </summary>
	public class ejProgressBar : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejProgressBar"/> class.
		/// </summary>
		public ejProgressBar() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejProgressBar"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejProgressBar(object options) : base("ejProgressBar", options)
		{
			this.WidgetWiredEvents = new[] {
				"start",
				"change",
				"complete"
			};
		}
	}
}
