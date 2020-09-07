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


using System.ComponentModel;
using System.Drawing;

namespace Wisej.Web.Ext.Syncfusion
{
	/// <summary>
	/// The Essential Studio for JavaScript Web Tiles are simple, opaque rectangles 
	/// or squares and they are arrayed on the start screen in a grid-like pattern. 
	/// Tapping or selecting a Tile, launches the app or does some other action that 
	/// is represented by the Tile. Tiles are arranged in a group separated by columns 
	/// that looks like a start screen of a device and it can be either static or live.
	/// </summary>
	public class ejTile : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejTile"/> class.
		/// </summary>
		public ejTile() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejTile"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejTile(object options) : base("ejTile", options)
		{
			this.WiredEvents = new[] {
				"mouseUp",
				"mouseDown"
			};
		}

		/// <summary>
		/// Specifies the text to display on the tile.
		/// </summary>
		public override string Text
		{
			get { return this.Options.text ?? ""; }
			set { this.Options.text = value ?? ""; }
		}
	}
}
