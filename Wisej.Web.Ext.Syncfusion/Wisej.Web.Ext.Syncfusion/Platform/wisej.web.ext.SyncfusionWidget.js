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
 * wisej.web.ext.SyncfusionWidget
 *
 * Wraps all the basic functionality of Syncfusion.
 */
qx.Class.define("wisej.web.ext.SyncfusionWidget", {

	extend: wisej.web.Widget,

	construct: function () {

		this.base(arguments);

		this.addListener("focus", this._onFocus);
	},

	properties: {

		/**
		 * WidgetClass property.
		 *
		 * The name of the actual ej javascript class.
		 */
		widgetClass: { init: null, check: "String" },

		/**
		 * Additional HTML to add to the inner container that may be needed by the widget.
		 */
		widgetHtml: { init: null, check: "String" },

		/**
		 * Collection of event handlers to attach to the widget's events.
		 */
		widgetEvents: { init: [], check: "Array" },

		/**
		 * Names of the events fired by the widget that should be wired back to the server.
		 */
		widgetWiredEvents: { init: [], check: "Array" },

		/**
		 * Collection of additional javascript methods to add to the widget.
		 */
		widgetFunctions: { init: [], check: "Array", apply: "_applyWidgetFunctions" },

		/**
		 * Collection of template scripts to register with the browser.
		 */
		widgetTemplates: { init: [], check: "Array", apply: "_applyWidgetTemplates" }
	},

	members: {

		/**
		 * Initializes the widget.
		 *
		 * This function is called when the InitScript property of
		 * wisej.web.Widget changes.
		 *
		 * 'this' refers to the container which is a wisej.web.Widget instance.
		 *
		 * 'this.container' refers to the DOM element and can be used to initialize
		 * the third party javascript widget.
		 *
		 * @param options {Map} Options map (optional).
		 */
		init: function (options) {

			// disable the ejMenu animation, it's way too slow.
			window.ej.Menu.prototype.defaults.animationType = "none";

			var html = this.getWidgetHtml();
			if (html) {
				this.container.innerHTML = html;
				this.container = this.container.firstChild;
			}

			this._registerEventHandlers(options);
			var className = this.getWidgetClass();
			this.widget = $(this.container)[className](options).data(className);

			// resize the hosted widget when this is resized.
			this.addListener("resize", function (e) {

				// force the DOM update now, or the hosted
				// widget will find the container element with the previous size.
				qx.ui.core.queue.Manager.flush();

				qx.event.Timer.once(this.resizeWidget, this, 0);
			});

			qx.event.Timer.once(this.resizeWidget, this, 0);
		},

		/**
		 * Updates the widget when the options object changes.
		 *
		 * @param options {Map} Options map (optional).
		 * @param old {Map} Previous options map (optional).
		 */
		update: function (options, old) {
			this.widget.option(options);
		},

		/**
		 * Resizes the hosted widget to always fit our container.
		 */
		resizeWidget: function () {

			if (this.widget) {
				var bounds = this.getBounds();
				if (bounds) {
					try {
						this.widget.option({
							width: bounds.width,
							height: bounds.height
						});
					} catch (ex) { }

					if (typeof (this.widget.redraw) === "function") {
						this.widget.redraw();
					}
					else if (typeof (this.widget.refresh) === "function") {
						this.widget.refresh();
					}
				}
			}
		},

		// registers the user functions with this widget class.
		// if their names collide with existing functions they will
		// override them. collisions are logged in the console.
		_registerFunctions: function (functions) {

			var name, source;

			if (functions && functions.length > 0) {
				for (var i = 0; i < functions.length; i++) {
					name = functions[i].name;
					if (!name) continue;
					source = functions[i].source;
					if (!source) continue;

					var func = new Function("//# sourceURL=" + this.getName() + "." + name +
						"\r\n\r\n" + source);

					if (this[name] !== undefined)
						this.core.logWarning("Function " + name + " is being overridden.");

					this[name] = this._makeFunctionWrapper(name, func);
				}
			}
		},

		// creates a wrapper for the user function.
		_makeFunctionWrapper: function (name, func) {

			var me = this;
			function wrapper() {

				if (!me.widget) {
					var args = Array.prototype.slice.call(arguments);
					this.addListenerOnce('initialized', function (e) {
						func.apply(me, args);
					});
					return;
				}

				func.apply(me, arguments);
			};

			return wrapper;
		},

		// attaches the specified event callback functions
		// to the options map.
		_registerEventHandlers: function (options) {

			var name, source;
			var handlers = this.getWidgetEvents();
			var wiredEvents = this.getWidgetWiredEvents();

			if (handlers && handlers.length > 0) {
				for (var i = 0; i < handlers.length; i++) {
					name = handlers[i].name;
					if (!name) continue;
					source = handlers[i].source;
					if (!source) continue;

					var handler = new Function("e",
						"//# sourceURL=" + this.getName() + ".on" + qx.lang.String.firstUp(name) +
						"\r\n\r\n" + source);

					options[name] = this._makeEventHandler(handler);
				}
			}

			if (wiredEvents && wiredEvents.length > 0) {
				for (var i = 0; i < wiredEvents.length; i++) {
					for (var i = 0; i < wiredEvents.length; i++) {
						name = wiredEvents[i];
						if (!name) continue;

						if (options[name] === undefined) {
							options[name] = this._makeEventHandler(null);
						}
					}
				}
			}
		},

		//creates a closure to handle a widget's event callback.
		_makeEventHandler: function (handler) {
			var me = this;
			function callback(args) {

				if (handler)
					handler.call(this, args);

				var wiredEvents = me.getWidgetWiredEvents();
				if (wiredEvents && wiredEvents.indexOf(args.type) > -1) {

					// make sure there is always one field or
					// the wisej system sends null instead of {}.
					var eventData = me.filterEventData(args);
					eventData.type = args.type;

					me.fireWidgetEvent(
						args.type,
						eventData);
				}
			};

			return callback;
		},

		// Returns a data map that can be converted to JSON.
		filterEventData: function (args) {
			return { };
		},

		/**
		 * Applies the WidgetFunctions property.
		 *
		 * Creates the user function on this widget.
		 */
		_applyWidgetFunctions: function (value, old) {

			this._registerFunctions(value);
		},

		/**
		 * Applies the WidgetTemplates property.
		 *
		 * Registers the custom templates functions received from the app.
		 */
		_applyWidgetTemplates: function (value, old) {

			var templates = value;
			if (!templates || templates.length == 0)
				return;

			var tpl, t;
			for (var i = 0; i < templates.length; i++) {

				t = templates[i];
				if (!t.id || !t.template)
					continue;

				// build the template <script id="id" type="text/x-jsrender">template</script>.
				tpl = document.createElement("script");
				tpl.id = t.id;
				tpl.innerHTML = t.template;
				tpl.type = t.type || "text/x-jsrender";
				document.body.appendChild(tpl);
			}

		},

		// fires the "render" event when in design mode to notify
		// the html renderer that the widget has been initialized.
		//
		// widgets may replace this function to fire the "render" event
		// according to the widget's implementation.
		//
		_onInitialized: function () {

			if (wisej.web.DesignMode)
				this.fireEvent("render");

			this.fireEvent("initialized");

			if (this.initWidget)
				this.initWidget();
		},

		// handles the "focus" event to try and set the
		// focus to the inner widget.
		_onFocus: function (e) {

			try {
				if (this.widget) {
					if (this.widget.wrapper)
						this.widget.wrapper.focus();
					else if (this.widget.element)
						this.widget.element.focus();
				}
			} catch (ex) { }
		}
	},
	destroy: function(){

		if (this.widget)
			this.widget.destroy();
	}
});

