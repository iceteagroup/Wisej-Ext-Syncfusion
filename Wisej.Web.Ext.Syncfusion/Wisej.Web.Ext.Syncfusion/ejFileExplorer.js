//# sourceURL=wisej.web.ext.SyncfusionWidget.ejFileExplorer.js

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

	this.widget.option("ajaxAction", this.getPostbackUrl());
	this.widget.refresh();

};

/**
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	if (this.widget) {
		try {
			this.widget.option({ width: "100%", height:"100%" });
			this.widget.adjustSize();
		} catch (ex) { }
	}
};