//# sourceURL=wisej.web.ext.SyncfusionWidget.ejRotator.js

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
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	if (this.widget) {

		var wrapper = this.widget._wrapper;
		var outerWrapper = this.widget._outerWrapper;
		var gapX = outerWrapper.width() - wrapper.width();
		var gapY = outerWrapper.height() - wrapper.height();

		var bounds = this.getBounds();
		this.widget.option({
			slideWidth: bounds.width - gapX,
			slideHeight: bounds.height - gapY
		});
	}
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {
	return {
		activeItemIndex: args.activeItemIndex
	};
};
