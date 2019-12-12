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
	/// The CircularGauge control visualizes the numerical values of scales in a circular manner.  
	/// It is also a feature-rich control that provides extensive appearance customization 
	/// options with support for the animation of a pointer element.
	/// </summary>
	public class ejCircularGauge : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejCircularGauge"/> class.
		/// </summary>
		public ejCircularGauge() : this(null)
		{
			this.Options = new
			{
				scales = new[] {
					new {
						pointers = new[] {
							new {
								value = 0
							}
						}
					}
				}
			};
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejCircularGauge"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejCircularGauge(object options) : base("ejCircularGauge", options)
		{
			this.WidgetWiredEvents = new[] {
				"rightClick",
				"mouseClick",
				"doubleClick"
			};
		}

		/// <summary>
		/// Specifies the value of the first pointer.
		/// </summary>
		public int Value
		{
			get
			{
				try
				{
					return this.Options.scales[0].pointers[0].value;
				}
				catch { return 0; }
			}
			set
			{
				try
				{
					this.Options.scales[0].pointers[0].value = value;
					Update();
				}
				catch { }
			}
		}
	}
}
