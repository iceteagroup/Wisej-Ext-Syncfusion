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
	/// MediaPlayer component is a html5 component which is used to embed a media in a web page such as web videos, YouTube and audio files.
	/// </summary>
	public class ejMediaPlayer : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejMediaPlayer"/> class.
		/// </summary>
		public ejMediaPlayer() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejMediaPlayer"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejMediaPlayer(object options) : base("ejMediaPlayer", options)
		{
			this.WiredEvents = new[] {
				"onRepeat",
				"onPlaying",
				"onActionBegin",
				"onActionComplete"
			};
		}
	}
}
