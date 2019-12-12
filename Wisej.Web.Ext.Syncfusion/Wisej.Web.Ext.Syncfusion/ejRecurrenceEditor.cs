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
	/// The Recurrence Editor includes the entire recurrence related information 
	/// in a separate portable manner which can be either utilized as a separate 
	/// widget or else can be embed within the appointment window of Scheduler to 
	/// enable recurrence options within it. The recurrence rule can be easily 
	/// generated based on the frequency selected. The customizations like changing 
	/// the labels of the Recurrence Editor is also possible to achieve through its 
	/// properties. The frequencies available are Never, Daily, Weekly, Monthly, 
	/// Yearly and Every weekday.
	/// </summary>
	public class ejRecurrenceEditor : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejRecurrenceEditor"/> class.
		/// </summary>
		public ejRecurrenceEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejRecurrenceEditor"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejRecurrenceEditor(object options) : base("ejRecurrenceEditor", options)
		{
			this.WidgetWiredEvents = new[] {
				"change",
			};
		}
	}
}
