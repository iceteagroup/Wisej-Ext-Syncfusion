//# sourceURL=wisej.web.ext.SyncfusionWidget.ejKanban.js

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

/**
 * Additional widget initialization.
 */
this.initWidget = function () {

	this.container.style.boxSizing = "border-box";
};


/**
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	if (this.widget) {

		var bounds = this.getBounds();

		if (!bounds)
			return;

		this.widget.option({
			scrollSettings: {
				width: bounds.width - 2,
				height: bounds.height - 2,
			}
		});
	}
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	return {
		status: args.status,
		rowIndex: args.rowIndex,
		cellIndex: args.cellIndex,
	}
};