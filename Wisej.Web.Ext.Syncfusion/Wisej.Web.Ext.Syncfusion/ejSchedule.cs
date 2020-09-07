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
	/// An Event calendar that manages the list of various activities like events/appointments.
	/// </summary>
	public class ejSchedule : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejSchedule"/> class.
		/// </summary>
		public ejSchedule() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejSchedule"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejSchedule(object options) : base("ejSchedule", options)
		{
			this.WiredEvents = new[] {
				"keyDown",
				"cellClick",
				"cellHover",
				"navigation",
				"actionBegin",
				"menuItemClick",
				"actionComplete",
				"cellDoubleClick",
				"appointmentClicked",
				"appointmentChanged",
				"overflowButtonClick",
			};
		}
	}
}
