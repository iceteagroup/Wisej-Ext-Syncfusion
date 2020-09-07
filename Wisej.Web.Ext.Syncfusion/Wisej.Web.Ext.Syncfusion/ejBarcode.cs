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


using System.Drawing;

namespace Wisej.Web.Ext.Syncfusion
{
	/// <summary>
	/// The Syncfusion Essential JS Barcode widget enables rendering of one 
	/// dimension and two dimension barcodes in web page. 
	/// </summary>
	/// <remarks>
	/// The Barcode provides you with a simple and inexpensive method of 
	/// encoding text information that can be easily read by electronic readers.
	/// </remarks>
	public class ejBarcode : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejBarcode"/> class.
		/// </summary>
		public ejBarcode() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejBarcode"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejBarcode(object options) : base("ejBarcode", options)
		{
			this.WiredEvents = new[] {
				"load",
			};
		}

		/// <summary>
		/// Specifies the text to be encoded in the barcode.
		/// </summary>
		public override string Text
		{
			get { return this.Options.text ?? ""; }
			set { this.Options.text = value ?? ""; }
		}

		/// <summary>
		/// Specifies the color of the text/data at the bottom of the barcode.
		/// </summary>
		public override Color ForeColor
		{
			get { return this.Options.textColor ?? Color.Empty; }
			set { this.Options.textColor = value; }
		}
	}
}
