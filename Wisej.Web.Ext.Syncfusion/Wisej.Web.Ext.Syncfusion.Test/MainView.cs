using System;
using Wisej.Web;
using System.Linq;
using Wisej.Web.Ext.Syncfusion.Test.Component;
using System.Collections;

namespace Wisej.Web.Ext.Syncfusion.Test
{
	public partial class MainView : Page
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void MainView_Load(object sender, EventArgs e)
		{
			this.listBox1.DataSource = PopulateTestList();
		}

		private IList PopulateTestList()
		{
			var asm = this.GetType().Assembly;
			return asm.GetTypes()
				.Where(o => o.Name.StartsWith("ej"))
				.Select(o => new { Icon="Images/syncfusion.png", Name=o.Name, Type=o })
				.ToList();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var list = (ListBox)sender;
			var type = (Type)((dynamic)list.SelectedItem).Type;
			var testPanel = (TestBase)Activator.CreateInstance(type);

			var container = this.panel2;
			container.Controls.Clear(true);
			testPanel.Dock = DockStyle.Fill;
			testPanel.Parent = container;

			container.Text = type.Name;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ejBase.Theme = this.comboBox1.Text;
			Application.Reload();
		}
	}
}
