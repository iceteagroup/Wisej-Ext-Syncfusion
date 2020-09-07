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


using Wisej.Core;

namespace Wisej.Web.Ext.Syncfusion
{
	/// <summary>
	/// Rich text editor is a component that help you to display or edit the content including 
	/// tables, hyperlinks, paragraphs, lists, video, and images. The editor supports file and 
	/// folder management using FileExplorer component.
	/// </summary>
	public class ejRichTextEditor : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejRichTextEditor"/> class.
		/// </summary>
		public ejRichTextEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejRichTextEditor"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejRichTextEditor(object options) : base("ejRTE", "<textarea style='width:100%;height:100%'>", options)
		{
			this.WiredEvents = new[] { "change", "execute" };
		}

		/// <summary>
		/// Overrides the base Text property and updates the value in the component by calling 'setHTML'
		/// </summary>
		public override string Text
		{
			get { return base.Text; }
			set
			{
				if (value != base.Text)
				{
					base.Text = value;

					if (!this._inWebUpdate)
						Call("setHtml", value);
				}
			}
		}

		/// <summary>
		/// Causes the control to update the corresponding client side widget.When in design
		/// mode, causes the rendered control to update its entire surface in the designer.
		/// </summary>
		public override void Update()
		{
			// overridden to update the HTML editor when the user reloads the page.
			if (((IWisejControl)this).IsNew)
			{
				if (this.Text != "")
					Call("setHtml", this.Text);
			}

			base.Update();
		}

		/// <summary>
		/// Processes changes between client and server. 
		/// </summary>
		/// <param name="state"></param>
		protected override void OnWebUpdate(dynamic state)
		{
			this._inWebUpdate = true;
			string html = state.html;
			try
			{
				if (html != null)
				{
					state.text = html;
					base.OnWebUpdate((object)state);

					// if the app changed the text while processing OnTextChanged, update the client.
					if (this.Text != html)
						Call("setHtml", this.Text);
				}
			}
			finally
			{
				this._inWebUpdate = false;
			}
		}

		private bool _inWebUpdate;
	}
}
