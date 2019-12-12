using System;
using System.IO;
using Wisej.Core;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejFileExplorer : TestBase
	{
		public ejFileExplorer()
		{
			InitializeComponent();
		}

		private void ejFileExplorer1_WebRequest(object sender, WebRequestEventArgs e)
		{
			var rest = JSON.Parse(e.Request.InputStream);
			switch (rest.ActionType)
			{
				case "Read":
					e.Response.Write(OnRead(rest));
					break;

				default:
					AlertBox.Show($"Action not implemented {rest.ActionType}", MessageBoxIcon.Stop);
					break;
			}
		}

		private dynamic OnRead(dynamic rest)
		{
			dynamic result = new DynamicObject();
			string path = Application.MapPath(rest.Path);

			var attributes = File.GetAttributes(path);
			if (attributes.HasFlag(FileAttributes.Directory))
			{
				var directory = new DirectoryInfo(path);
				result.cwd = new
				{
					name = directory.Name,
					type = "Directory",
					size = 0,
					hasChild= false,
					isFile = false,
					dateModified = directory.LastWriteTime.ToString("M/d/yyyy h:mm:ss tt")
				};

				var files = Directory.EnumerateFileSystemEntries(path, "*.*", SearchOption.TopDirectoryOnly);

				result.files = 
					files.Select((f) => {

						if (File.GetAttributes(f).HasFlag(FileAttributes.Directory))
						{
							var info = new DirectoryInfo(f);
							return new
							{
								name = info.Name,
								type = "Directory",
								size = 0L,
								hasChild = false,
								isFile = false,
								dateModified = info.LastWriteTime.ToString("M/d/yyyy h:mm:ss tt"),
							};
						}
						else
						{
							var info = new FileInfo(f);
							return new
							{
								name = info.Name,
								type = "File",
								size = info.Length,
								hasChild = false,
								isFile = true,
								dateModified = info.LastWriteTime.ToString("M/d/yyyy h:mm:ss tt"),
							};
						}
					}).ToArray();

				result.dateFormat = "M/d/yyyy h:mm:ss tt";

				return result;
			}
			else
			{
				return null;
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejFileExplorer1.Options.showFooter = this.checkBox1.Checked;
			this.ejFileExplorer1.Options.showToolbar = this.checkBox2.Checked;
			this.ejFileExplorer1.Options.layout = this.comboBox1.Text.ToLower();

			this.ejFileExplorer1.Update();
		}
	}
}
