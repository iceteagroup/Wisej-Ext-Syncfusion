//# sourceURL=wisej.web.ext.SyncfusionWidget.ejGantt.js

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

	// reset the data sets or it will merge the existing values.
	this.widget.model.resources = [];
	this.widget.model.dataSource = [];

	this.widget.option(options);
};

/**
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	if (this.widget) {
		this.widget.windowResize();
	}
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	switch (args.type) {
		case "taskbarClick":
			return { index: args.index, item: args.data.item };
		case "rowSelected":
			return { index: args.recordIndex, item: args.data.item };
	}
};
