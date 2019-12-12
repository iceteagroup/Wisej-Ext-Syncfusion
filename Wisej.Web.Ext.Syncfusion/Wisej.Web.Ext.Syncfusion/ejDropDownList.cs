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
	/// The DropDownList control provides a list of options to choose an item from the list. 
	/// It can including other HTML elements such as images, textboxes, check box, radio buttons, 
	/// and so on.
	/// </summary>
	public class ejDropDownList : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejDropDownList"/> class.
		/// </summary>
		public ejDropDownList() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejDropDownList"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejDropDownList(object options) : base("ejDropDownList", "<input style='height:100%;width:100%' />", options)
		{
			this.WidgetWiredEvents = new[] {
				"change",
				"search",
				"select",
				"cascade",
				"actionBegin",
				"actionFailure",
				"actionSuccess",
				"actionComplete",
				"beforePopupHide",
				"beforePopupShown",
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
					Call("setText", value);
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
			this.Text = state.text ?? "";
		}
	}
}
