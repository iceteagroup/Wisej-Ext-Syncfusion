using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejDropDownList : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		public ejDropDownList()
		{
			InitializeComponent();
		}

		private void ejDropDownList_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$@"<b>{e.Type}</b><br/>
				{e.Data}",
				MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Update(this.ejDropDownList1);
			Update(this.ejDropDownList2);
		}

		private void Update(Wisej.Web.Ext.Syncfusion.ejDropDownList ejList)
		{
			ejList.Options.allowVirtualScrolling = this.checkBoxAllowVirtualScrolling.Checked;
			ejList.Options.caseSensitiveSearch = this.checkBoxCaseSensitiveSearch.Checked;
			ejList.Options.enableIncrementalSearch = this.checkBoxEnableIncrementalSearch.Checked;
			ejList.Options.enableFilterSearch = this.checkBoxEnableFilterSearch.Checked;

			ejList.Update();
		}
	}
}
