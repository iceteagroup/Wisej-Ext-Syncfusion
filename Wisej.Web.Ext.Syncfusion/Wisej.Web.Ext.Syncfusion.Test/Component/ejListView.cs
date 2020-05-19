using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejListView : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejListView()
		{
			InitializeComponent();
		}

		private void buttonAddNewItem_Click(object sender, EventArgs e)
		{
			this.ejListView1.Widget.addItem(new { text = "My New Item" }, 0, "");

			this.ejListView1.Update();
		}

		private async void buttonGetSelectedItems_Click(object sender, EventArgs e)
		{
			var checkedItems = await this.ejListView1.Widget.getCheckedItemsTextAsync();

			AlertBox.Show(Wisej.Core.WisejSerializer.Serialize(checkedItems));
		}

		private void buttonClearSelected_Click(object sender, EventArgs e)
		{
			this.ejListView1.Widget.unCheckAllItem();

			this.ejListView1.Update();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejListView1.Options.enableCheckMark = this.checkBox1.Checked;
			this.ejListView1.Options.enableFiltering = this.checkBox2.Checked;
			this.ejListView1.Options.enableGroupList = this.checkBox3.Checked;

			this.ejListView1.Update();
		}
	}
}
