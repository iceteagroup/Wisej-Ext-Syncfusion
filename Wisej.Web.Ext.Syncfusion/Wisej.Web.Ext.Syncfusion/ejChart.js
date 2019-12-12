//# sourceURL=wisej.web.ext.SyncfusionWidget.ejChart.js

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

this.update = function (options, old) {

	// reset the series or it will merge the points.
	this.widget.model.series = [];

	this.widget.option(options);
};

/**
 * exportImage
 *
 * Exports the chart as an image.
 */
this.exportImage = function () {

	if (this.widget) {

		this.widget.option({ enableCanvasRendering: true });

		var canvas = this.widget.export("image");
		if (canvas && canvas.toDataURL)
			return canvas.toDataURL();
	}

};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	var data = args.data;
	switch (args.type) {
		case "legendItemClick":
			return {
				text: data.legendItem.LegendItem.Text,
				seriesIndex: data.legendItem.LegendItem.SeriesIndex
			}
			break;
		default:
			return {
				id: data.id,
				size: data.size,
				pageX: data.pageX,
				pageY: data.pageY,
				location: data.location,
				seriesIndex: data.seriesIndex 
			}
			break;
	}
};