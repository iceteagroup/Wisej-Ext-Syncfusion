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
	/// The Ribbon control for JavaScript provides with rich customizable user interfaces like 
	/// Office 2010, SharePoint 2010, and Office Web Apps 2010. The Ribbon Tab appears across 
	/// the top of the page. Each Tab organizes a set of groups that has labels to identify 
	/// them and also contains a set of controls and group expander.
	/// </summary>
	public class ejRibbon : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejRibbon"/> class.
		/// </summary>
		public ejRibbon() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejRibbon"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejRibbon(object options) : base("ejRibbon", options)
		{
			this.WidgetWiredEvents = new[] {
				"expand",
				"gropuClick",
				"qatMenuItemClick",
				"toggleButtonClick"
			};
		}
	}
}
