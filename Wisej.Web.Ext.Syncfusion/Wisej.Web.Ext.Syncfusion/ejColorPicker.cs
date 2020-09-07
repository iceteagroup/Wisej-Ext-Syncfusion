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
	/// The ColorPicker control provides you a rich visual interface for color selection.
	/// </summary>
	/// <remarks>
	/// You can select the color from the professionally designed palettes or custom color. 
	/// By clicking a point on the color, you can change the active color to the color that 
	/// is located under the pointer.
	/// </remarks>

	public class ejColorPicker : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejColorPicker"/> class.
		/// </summary>
		public ejColorPicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejColorPicker"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejColorPicker(object options) : base("ejColorPicker", "<input style='height:100%;width:100%' />", options)
		{
			this.WiredEvents = new[] {
				"open",
				"close",
				"change",
				"select"
			};
		}

		/// <summary>
		/// Defines the text value that is displayed in the DropDownList textbox.
		/// In case of MultiSelectMode, returns the selected item's texts and separated by 
		/// delimiterChar in string type.
		/// </summary>
		public override string Text
		{
			get { return this._text; }
			set
			{
				if (this._text != value)
				{
					this._text = value;
					Call("setValue", value);
				}
			}
		}
		private string _text = "";

		/// <summary>
		/// Processes changes between client and server. 
		/// </summary>
		/// <param name="state"></param>
		protected override void OnWebUpdate(dynamic state)
		{
			this.Text = state.value ?? "";
		}
	}
}
