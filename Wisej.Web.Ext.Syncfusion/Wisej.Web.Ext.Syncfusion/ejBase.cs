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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Wisej.Base;
using Wisej.Core;
using Wisej.Design;

namespace Wisej.Web.Ext.Syncfusion
{
	/// <summary>
	/// The <see cref="ejBase"/> class is the foundation of all Syncfusion JS1 visual controls.
	/// </summary>
	[ToolboxBitmap(typeof(ejBase), "ejSyncfusion.bmp")]
	public abstract class ejBase : Widget
	{
		internal const string DEFAULT_THEME = "default-theme";
		internal const string NAMESPACE = "Wisej.Web.Ext.Syncfusion";
		internal const string RESOURCES_ROOT = "Wisej.Web.Ext.Syncfusion.Syncfusion";
		internal const string THEMENAME_KEY = "Wisej.Web.Ext.Syncfusion.ThemeName";

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="ejBase"/> class.
		/// </summary>
		/// <remarks>
		/// See demo at: <see href="https://js.syncfusion.com/demos/web/"/>
		/// </remarks>
		/// <param name="className"></param>
		/// <param name="options"></param>
		public ejBase(string className, object options)
		{
			if (String.IsNullOrEmpty(className))
				throw new ArgumentNullException(nameof(className));

			this.Options = options;
			this.WidgetClass = className;
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejBase"/> class.
		/// </summary>
		/// <param name="className"></param>
		/// <param name="html"></param>
		/// <param name="options"></param>
		public ejBase(string className, string html, object options)
		{
			if (String.IsNullOrEmpty(className))
				throw new ArgumentNullException(nameof(className));

			this.Options = options;
			this.WidgetHtml = html;
			this.WidgetClass = className;
		}

		#endregion

		#region Events

		/// <summary>
		/// Fired when the Syncfusion widget is created and it available to receive calls.
		/// </summary>
		public event EventHandler Initialized
		{
			add { AddHandler(nameof(Initialized), value); }
			remove { RemoveHandler(nameof(Initialized), value); }
		}

		/// <summary>
		/// Raises the <see cref="Initialized"/> event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnInitialized(EventArgs e)
		{
			this.IsInitialized = true;

			ProcessDeferredCalls();

			((EventHandler)base.Events[nameof(Initialized)])?.Invoke(this, e);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Returns or sets the theme for all the Syncfusion widgets in the application.
		/// </summary>
		public static string Theme
		{
			get { return Application.Session[THEMENAME_KEY] ?? DEFAULT_THEME; }
			set
			{
				if (String.IsNullOrEmpty(value))
					value = DEFAULT_THEME;

				if (Theme != value)
				{
					Application.Session[THEMENAME_KEY] = value;

					foreach (ejBase widget in Application.FindComponents(c => c is ejBase))
					{
						widget.Packages.Clear();
						widget.Update();
					}
				}
			}
		}

		/// <summary>
		/// Returns whether the javascript widget has been initialized.
		/// </summary>
		public bool IsInitialized
		{
			get;
			private set;
		}

		/// <summary>
		/// Returns or sets the configuration options;
		/// </summary>
		[DesignerActionList]
		[MergableProperty(false)]
		[SRCategory("CatBehavior")]
		[SRDescription("WidgetOptionsDescr")]
		[WisejSerializerOptions(WisejSerializerOptions.None)]
		public override dynamic Options
		{
			get { return base.Options; }
			set
			{
				if (value != null)
				{
					if (value is string)
					{
						value = WisejSerializer.Parse((string)value);
					}
					else if (!(value is Wisej.Core.DynamicObject))
					{
						// make sure to convert non-writable anonymous classes to
						// our DynamicObject instance.
						value = WisejSerializer.Parse(WisejSerializer.Serialize((object)value));
					}
				}

				base.Options = value;
			}
		}

		/// <summary>
		/// Property for additional Syncfusion packages
		/// </summary>
		[DefaultValue(null)]
		public Package[] Includes
		{
			get { return this._includes; }
			set
			{
				if (this._includes != value)
				{
					this._includes = value;
					this.Packages.Clear();
				}
			}
		}
		private Package[] _includes;

		/// <summary>
		/// Property for Syncfusion localization packages
		/// </summary>
		[DefaultValue(null)]
		public Package[] Locales
		{
			get { return this._locales; }
			set
			{
				if (this._locales != value)
				{
					this._locales = value;
					this.Packages.Clear();
				}
			}
		}
		private Package[] _locales;

		/// <summary>
		/// Property for required Syncfusion packages
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override List<Package> Packages
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				var packages = base.Packages;
				if (packages.Count == 0)
				{
					packages.Add(new Package() {
						Name = "jquery.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/external/jquery-3.4.1.min.js")
					});
					packages.Add(new Package()
					{
						Name = "jquery.validate.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/external/jquery.validate.min.js")
					});
					packages.Add(new Package()
					{
						Name = "jsrender.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/external/jsrender.min.js")
					});
					packages.Add(new Package()
					{
						Name = "ej.web.all.js",
						Source = this.GetResourceURL($"{RESOURCES_ROOT}/assets/scripts/web/ej.web.all.min.js")
					});

					// add the theme package.
					var themeUrl = ejBase.Theme;
					if (!themeUrl.Contains("/"))
					{
						packages.Add(new Package()
						{
							Name = themeUrl,
							Source = this.GetResourceURL($"{RESOURCES_ROOT}/assets/css/web/{themeUrl}/ej.web.all.min.css")
						});
					}
					else if (themeUrl.StartsWith("web/"))
					{
						packages.Add(new Package()
						{
							Name = themeUrl,
							Source = this.GetResourceURL($"{RESOURCES_ROOT}/assets/css/{themeUrl}/ej.web.all.min.css")
						});
					}
					else if (themeUrl.StartsWith("mobile/"))
					{
						packages.Add(new Package()
						{
							Name = themeUrl,
							Source = this.GetResourceURL($"{RESOURCES_ROOT}/assets/css/mobile/ej.mobile.all.min")
						});

						var name = themeUrl.Replace("mobile/", "").Replace("-theme", "");

						packages.Add(new Package()
						{
							Name = themeUrl,
							Source = this.GetResourceURL($"{RESOURCES_ROOT}/assets/css/{themeUrl}/ej.mobile.{name}-core.min.css")
						});

						packages.Add(new Package()
						{
							Name = themeUrl,
							Source = this.GetResourceURL($"{RESOURCES_ROOT}/assets/css/{themeUrl}/ej.mobile.{name}.min.css")
						});
					}
					else
					{
						packages.Add(new Package()
						{
							Name = themeUrl,
							Source = $"{themeUrl}/ej.web.all.min.css"
						});
					}

					// add locales.
					if (this.Locales != null)
					{
						foreach (var l in this.Locales)
						{
							if (l.Source != null)
							{
								if (l.Source.StartsWith("i18n/", StringComparison.InvariantCultureIgnoreCase) 
									|| l.Source.StartsWith("i10/", StringComparison.InvariantCultureIgnoreCase))
								{
									this.Packages.Add(new Package {
										Name = l.Name,
										Source = $"{RESOURCES_ROOT}/assets/scripts/{l.Source}"
									});
								}
								else
								{
									this.Packages.Add(l);
								}
							}
						}
					}

					// add custom packages.
					if (this.Includes != null)
					{
						this.Packages.AddRange(this.Includes);
					}
				}
				return packages;
			}
		}

		/// <summary>
		/// optional html to use as the container.
		/// </summary>
		private string WidgetHtml { get; set; }

		/// <summary>
		/// the class name for the widget.
		/// </summary>
		private string WidgetClass { get; set; }

		/// <summary>
		/// list of events to wire back to the server.
		/// </summary>
		protected string[] WidgetWiredEvents { get; set; }

		/// <summary>
		/// The script used to initialize the widget
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string InitScript
		{
			// disable inlining or we lose the calling assembly in GetResourceString().
			[MethodImpl(MethodImplOptions.NoInlining)]
			get { return this.GetResourceString($"{NAMESPACE}.{this.GetControlType().Name}"); }
			set { }
		}

		/// <summary>
		/// The JS functions used in the widget
		/// </summary>
		[DefaultValue(null)]
		public WidgetFunction[] WidgetFunctions
		{
			get;
			set;
		}

		/// <summary>
		/// The widget event handlers.
		/// </summary>
		[DefaultValue(null)]
		public WidgetEventHandler[] WidgetEvents
		{
			get;
			set;
		}

		/// <summary>
		/// The templates used by the widget
		/// </summary>
		[DefaultValue(null)]
		public WidgetTemplate[] WidgetTemplates
		{
			get;
			set;
		}

		/// <summary>
		/// Returns a <see cref="System.Dynamic.DynamicObject"/> that can
		/// convert calls into JavaScript calls targeting the third party "widget" object.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public dynamic Widget
		{
			get
			{
				this._target = this._target ?? new WidgetTarget(this, "widget");
				return this._target;
			}
		}
		private WidgetTarget _target;

		#endregion

		#region Methods

		/// <summary>
		/// Returns the type derived from ejBase.
		/// </summary>
		private Type GetControlType()
		{
			var type = this.GetType();
			while (type.BaseType != typeof(ejBase) && type.BaseType != null)
			{
				type = type.BaseType;
			}
			return type;
		}

		/// <summary>
		/// Invokes a method on the wrapped widget. If the widgets is not initialized yet, it
		/// will queue the call and wait until it's initialized.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private object CallWidget(string name, object[] args)
		{
			if (!this.IsInitialized)
			{
				if (this.deferredCalls == null)
					 this.deferredCalls = new ConcurrentQueue<DeferredCall>();

				object result = null;

				TaskCompletionSource<dynamic> tcs = null;
				if (name.EndsWith("Async"))
				{
					name = name.Substring(0, name.Length - "Async".Length);
					tcs = new TaskCompletionSource<dynamic>();
					result = tcs.Task;
				}

				this.deferredCalls.Enqueue(new DeferredCall() { 

					MethodName = name,
					Arguments = args,
					Tcs = tcs
				});

				return result;
			}
			else
			{
				if (name.EndsWith("Async"))
				{
					name = name.Substring(0, name.Length - "Async".Length);
					return this.CallAsync(name, args);
				}
				else
				{
					this.Call(name, args);
					return null;
				}
			}
		}

		/// <summary>
		/// Returns the Image encoded in a base64 string.
		/// </summary>
		/// <param name="base64">base64 string to convert to an image.</param>
		/// <returns>An <see cref="Image"/>.</returns>
		internal static Image ImageFromBase64(string base64)
		{
			// data:image/gif;base64,R0lGODlhCQAJAIABAAAAAAAAACH5BAEAAAEALAAAAAAJAAkAAAILjI+py+0NojxyhgIAOw==
			try
			{
				if (String.IsNullOrEmpty(base64))
					return null;

				int pos = base64.IndexOf("base64,");
				if (pos < 0)
					return null;

				base64 = base64.Substring(pos + 7);
				byte[] buffer = Convert.FromBase64String(base64);

				MemoryStream stream = new MemoryStream(buffer);
				return Image.FromStream(stream);
			}
			catch { }

			return null;
		}

		#endregion

		#region Wisej Implementation

		/// <summary>
		/// Processes the event from the client.
		/// </summary>
		/// <param name="e">Event arguments.</param>
		protected override void OnWebEvent(Core.WisejEventArgs e)
		{
			switch (e.Type)
			{
				case "initialized":
					OnInitialized(EventArgs.Empty);
					break;

				default:
					base.OnWebEvent(e);
					break;
			}
		}
		/// <summary>
		/// Wire the client config to the server
		/// </summary>
		/// <param name="config"></param>
		protected override void OnWebRender(dynamic config)
		{
			base.OnWebRender((object)config);

			config.className = "wisej.web.ext.SyncfusionWidget";
			config.widgetHtml = this.WidgetHtml;
			config.widgetClass = this.WidgetClass;
			config.widgetEvents = this.WidgetEvents;
			config.widgetFunctions = this.WidgetFunctions;
			config.widgetTemplates = this.WidgetTemplates;
			config.widgetWiredEvents = this.WidgetWiredEvents;

			// replace this.GetPostbackUrl() with this.GetServiceURL()
			// to generate a rest URL with the session id in the path
			// instead of the ?sid= parameter.
			config.postbackUrl = this.GetServiceURL();
			//config.postbackUrl = this.GetPostbackURL();

			config.wiredEvents.Add("initialized");
		}

		#endregion

		#region WidgetTemplate

		/// <summary>
		/// Represents a Syncfusion template.
		/// </summary>
		/// <remarks>
		/// Templates in the Syncfusion library are either plain global JavaScript functions, or
		/// HTML snippets using their template syntax.
		/// </remarks>
		public class WidgetTemplate
		{
			/// <summary>
			/// The identifier of the <see cref="WidgetTemplate"/>
			/// </summary>
			[DefaultValue("")]
			public string Id
			{
				get { return this._id; }
				set
				{
					value = value ?? string.Empty;
					this._id = value;
				}
			}
			private string _id = string.Empty;

			/// <summary>
			/// The template used by the <see cref="WidgetTemplate"/>
			/// </summary>
			[DefaultValue("")]
			[Editor("Wisej.Design.HtmlEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
			public string Template
			{
				get { return this._template; }
				set
				{
					value = value ?? string.Empty;
					this._template = value;
				}
			}
			private string _template = string.Empty;

			/// <summary>
			/// Type of the template. Use "text/x-jsrender" for HTML templates or
			/// "text/javascript" for simpler javascript functions.
			/// </summary>
			[DefaultValue("text/x-jsrender")]
			public string Type
			{
				get { return this._type; }
				set
				{
					value = value ?? string.Empty;
					this._type = value;
				}
			}
			private string _type = "text/x-jsrender";

			/// <summary>
			/// String representation of <see cref="WidgetTemplate"/>
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return this.Id ?? SR.GetString("toStringNone");
			}

		}

		#endregion

		#region WidgetEventHandler

		/// <summary>
		/// Represents a JavScript handler attached to an event fired by the
		/// third party widget.
		/// </summary>
		/// <remarks>
		/// Refer to "this" in the context of the function to target the wisej.web.Widget instance, and to
		/// "this.widget" to refer to the third party widget.
		/// </remarks>
		public class WidgetEventHandler
		{
			/// <summary>
			/// The name of the <see cref="WidgetEventHandler"/>
			/// </summary>
			[DefaultValue("")]
			public string Name
			{
				get { return this._name; }
				set
				{
					value = value ?? string.Empty;
					this._name = value;
				}
			}
			private string _name = string.Empty;

			/// <summary>
			/// The source code of the <see cref="WidgetEventHandler"/>
			/// </summary>
			[Editor("Wisej.Design.CodeEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
			public string Source
			{
				get { return this._source; }
				set
				{
					value = value ?? string.Empty;
					this._source = value;
				}
			}
			private string _source = string.Empty;

			/// <summary>
			/// Gets the string representation of <see cref="WidgetEventHandler"/>
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return this.Name ?? SR.GetString("toStringNone");
			}
		}

		#endregion

		#region WidgetFunction

		/// <summary>
		/// Represents a JavaScript function attached to the widget on the browser.
		/// </summary>
		/// <remarks>
		/// Refer to "this" in the context of the function to target the wisej.web.Widget instance, and to
		/// "this.widget" to refer to the third party widget.
		/// </remarks>
		public class WidgetFunction
		{
			/// <summary>
			/// The name of the <see cref="WidgetFunction"/>
			/// </summary>
			[DefaultValue("")]
			public string Name
			{
				get { return this._name; }
				set
				{
					value = value ?? string.Empty;
					this._name = value;
				}
			}
			private string _name = string.Empty;

			/// <summary>
			/// The source code for the <see cref="WidgetFunction"/>
			/// </summary>
			[Editor("Wisej.Design.CodeEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
			public string Source
			{
				get { return this._source; }
				set
				{
					value = value ?? string.Empty;
					this._source = value;
				}
			}
			private string _source = string.Empty;

			/// <summary>
			/// String representation of <see cref="WidgetFunction"/>
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return this.Name ?? SR.GetString("toStringNone");
			}
		}

		#endregion

		#region WidgetTarget

		/// <summary>
		/// Represents the third party widget as the target of dynamic method calls.
		/// </summary>
		/// <remarks>
		/// Converts dynamic method calls to this.Call("this.widget.{method}", args);
		/// </remarks>
		public class WidgetTarget : System.Dynamic.DynamicObject
		{
			private ejBase owner;
			private string target;
			private Dictionary<string, object> events = new Dictionary<string, object>();

			internal WidgetTarget(ejBase owner, string target)
			{
				Debug.Assert(owner != null);

				this.owner = owner;
				this.target = target;
				this.owner.WidgetEvent += this.OnWidgetEvent;
			}

			/// <summary>
			/// Invokes the specified member.
			/// </summary>
			/// <param name="binder"></param>
			/// <param name="args"></param>
			/// <param name="result"></param>
			/// <returns></returns>
			public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
			{
				result = null;
				var name = binder.Name;

				// is it an event?
				if (Array.IndexOf(this.owner.WidgetWiredEvents, name) > -1)
				{
					return false;
				}

				result = this.owner.CallWidget($"this.{this.target}.{name}", args);

				return true;
			}

			/// <summary>
			/// Returns the requested member.
			/// </summary>
			/// <param name="binder"></param>
			/// <param name="result"></param>
			/// <returns></returns>
			public override bool TryGetMember(GetMemberBinder binder, out object result)
			{
				result = null;
				var name = binder.Name;

				// is it an event?
				if (Array.IndexOf(this.owner.WidgetWiredEvents, name) > -1)
				{
					if (!this.events.TryGetValue(name, out result))
					{
						result = new Wisej.Web.WidgetEventHandler(delegate { });
						this.events[name] = result;
					}

					return true;
				}
				else
				{
					// otherwise can be a child object of the widget.
					result = new WidgetTarget(this.owner, $"{this.target}.{name}");
					return true;
				}
			}

			/// <summary>
			/// Sets the specified member.
			/// </summary>
			/// <param name="binder"></param>
			/// <param name="value"></param>
			/// <returns></returns>
			public override bool TrySetMember(SetMemberBinder binder, object value)
			{
				var name = binder.Name;

				if (this.events.ContainsKey(name) || Array.IndexOf(this.owner.WidgetWiredEvents, name) > -1)
				{
					this.events[name] = (Wisej.Web.WidgetEventHandler)value;
					return true;
				}

				return base.TrySetMember(binder, value);
			}

			private void OnWidgetEvent(object sender, WidgetEventArgs e)
			{
				object handler;
				if (this.events.TryGetValue(e.Type, out handler))
				{
					((Wisej.Web.WidgetEventHandler)handler).Invoke(sender, e);
				}
			}
		}

		#endregion

		#region DeferredCall

		private class DeferredCall
		{
			internal string MethodName;
			internal object[] Arguments;
			internal TaskCompletionSource<dynamic> Tcs;
		}

		private ConcurrentQueue<DeferredCall> deferredCalls;

		private void ProcessDeferredCalls()
		{
			if (this.deferredCalls == null || this.deferredCalls.Count == 0)
				return;

			DeferredCall call = null;
			while (this.deferredCalls.TryDequeue(out call))
			{
				if (call.Tcs == null)
				{
					this.Call(call.MethodName, call.Arguments);
				}
				else
				{
					this.Call(call.MethodName, (result) =>
					{
						if (result is Exception)
							call.Tcs.SetException((Exception)result);
						else
							call.Tcs.SetResult(result);

					}, call.Arguments);
				}
			}
		}

		#endregion
	}
}
