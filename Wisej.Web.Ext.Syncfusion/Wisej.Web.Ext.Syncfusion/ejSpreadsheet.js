//# sourceURL=wisej.web.ext.SyncfusionWidget.ejSpreadsheet.js

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

	var serviceUrl = this.getPostbackUrl();
	this.widget.option({
		importSettings: {
			importMapper: serviceUrl
		},
		exportSettings: {
			excelUrl: serviceUrl + "&format=xlsx",
			csvUrl: serviceUrl + "&format=csv",
			pdfUrl: serviceUrl + "&format=pdf"
		},
	});
};

/**
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	if (this.widget) {

		var bounds = this.getBounds();
		this.widget.option({
			scrollSettings: {
				width: bounds.width,
				height: bounds.height,
			}
		});
		this.widget.refreshSpreadsheet();
	}
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {
	return {
		columnIndex: args.columnIndex,
		rowIndex: args.rowIndex,
		columnName: args.columnName,
		value: args.value,
		prevValue: args.prevValue,
		sheetIndex: args.sheetIndex,
		selectedRange: args.selectedRange,
		activeIndex: args.activeIndex,
		text: args.text,
		parentText: args.parentText
	};
};