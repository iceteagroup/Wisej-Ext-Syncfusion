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


using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Wisej.Web.Ext.Syncfusion
{
	/// <summary>
	/// Essential Chart for JavaScript is a visually stunning Charting component. 
	/// It includes common Chart types ranging from line Charts to specialized financial Charts.
	/// </summary>
	public class ejChart : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejChart"/> class.
		/// </summary>
		public ejChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejChart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejChart(object options) : base("ejChart", options)
		{
			this.WidgetWiredEvents = new[] {
				"chartClick",
				"axisLabelClick",
				"annotationClick",
				"legendItemClick",
				"chartDoubleClick",
			};
		}

		/// <summary>
		/// Exports the chart to an image asynchronously.
		/// </summary>
		/// <returns>The image that represents the chart.</returns>
		public Task<Image> ExportImageAsync()
		{
			var tcs = new TaskCompletionSource<Image>();

			ExportImage((result) => {

				tcs.SetResult(result);
			});

			return tcs.Task;
		}

		/// <summary>
		/// Exports the chart to an image.
		/// </summary>
		/// <param name="callback">Callback method that receives the image.</param>
		public void ExportImage(Action<Image> callback)
		{

			if (callback == null)
				throw new ArgumentNullException("callback");

			Call("exportImage", (result) =>
			{
				var image = ImageFromBase64(result as string);
				if (image != null)
				{
					// set the background color.
					var bitmap = new Bitmap(image);
					using (var g = Graphics.FromImage(bitmap))
					{
						g.Clear(this.BackColor);
						g.DrawImageUnscaled(image, 0, 0);
					}
					image = bitmap;
				}

				callback(image);

			}, null);
		}
	}
}
