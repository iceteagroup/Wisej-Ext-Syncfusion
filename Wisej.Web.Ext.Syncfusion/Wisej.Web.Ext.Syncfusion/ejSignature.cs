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
	/// The Slider provides support to select a value from a particular range as well 
	/// as selects a range value. The Slider has a sliding base on which the handles are moved. 
	/// There are three types of Sliders such as default Slider, min-range Slider and range Slider.
	/// </summary>
	public class ejSignature : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejSignature"/> class.
		/// </summary>
		public ejSignature() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejSignature"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejSignature(object options) : base("ejSignature", options)
		{
			this.WiredEvents = new[] {
				"change",
				"mouseUp",
				"mouseDown",
				"mouseMove"
			};
		}
	}
}
