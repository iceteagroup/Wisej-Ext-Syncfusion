//# sourceURL=wisej.web.ext.SyncfusionWidget.ejRichTextEditor.js

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

// add local state properties.
this.setStateProperties(this.getStateProperties().concat(["html"]));

this.addListener("initialized", function (e) {

	var me = this;
	$(this.container).on("ejRTEchange", function () { me.setDirty(true); });
	$(this.container).on("ejRTEkeydown", function () { me.setDirty(true); });

});

/**
 * Returns the HTML content of the RTE.
 */
this.getHtml = function()
{
	if (this.widget)
		return this.widget.getHtml();
}

/**
 * Sets the HTML content of the RTE.
 */
this.setHtml = function (value) {

	if (this.widget) {
		this.widget.setHtml(value);
	}
	else {
		this.addListenerOnce("initialized", function (e) {
			this.setHtml(value);
		});
	}
}

/**
 * Resizes the hosted widget to always fit our container.
 */
this.resizeWidget = function () {

	if (this.widget) {
		try {
			var bounds = this.getBounds();

			if (!bounds)
				return;

			this.widget.option({
				width: bounds.width,
				height: bounds.height - 2
			});
			
		} catch (ex) { }
	}
};
