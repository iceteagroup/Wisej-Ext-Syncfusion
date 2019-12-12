//# sourceURL=wisej.web.ext.SyncfusionWidget.ejDropDownList.js

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
this.setStateProperties(this.getStateProperties().concat(["text"]));

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	this.setDirty(true);

	return {
		text: args.text,
		isChecked:
		args.isChecked,
		selectedText: args.selectedText,
		value: args.value
	};
};

/**
 * Returns the text value.
 */
this.getText = function () {
	if (this.widget)
		return this.widget.option("text");
}

/**
 * Sets the text value.
 */
this.setText = function (value) {

	if (this.widget)
		this.widget.option("text", value);
}