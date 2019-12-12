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

using System.ComponentModel;
using Wisej.Core;

namespace Wisej.Web.Ext.Syncfusion
{
	/// <summary>
	/// FileExplorer provides a Windows Explorer-like functionality for any web application. 
	/// It allows end-users to browse, select and upload files or change the folder structure 
	/// by renaming, moving and deleting files or folders. File and folder management capabilities 
	/// are fully customizable and can be disabled when necessary.
	/// </summary>
	public class ejFileExplorer : ejBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="ejFileExplorer"/> class.
		/// </summary>
		public ejFileExplorer() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="ejFileExplorer"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public ejFileExplorer(object options) : base("ejFileExplorer", options)
		{
			this.WidgetWiredEvents = new[] {
				"cut",
				"copy",
				"open",
				"paste",
				"create",
				"select",

			};
		}
	}
}
