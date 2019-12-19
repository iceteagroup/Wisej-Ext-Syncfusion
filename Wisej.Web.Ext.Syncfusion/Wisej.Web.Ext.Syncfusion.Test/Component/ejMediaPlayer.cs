using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Test.Component
{
	public partial class ejMediaPlayer : Wisej.Web.Ext.Syncfusion.Test.Component.TestBase
	{
		bool isMute = false;

		public ejMediaPlayer()
		{
			InitializeComponent();

			this.ejMediaPlayer1.Widget.onRepeat += new WidgetEventHandler(ejMediaPlayer1_WidgetEvent);
			this.ejMediaPlayer1.Widget.onPlaying += new WidgetEventHandler(ejMediaPlayer1_WidgetEvent);
			this.ejMediaPlayer1.Widget.onActionBegin += new WidgetEventHandler(ejMediaPlayer1_WidgetEvent);
		}

		private void buttonMute_Click(object sender, EventArgs e)
		{
			if (isMute)
			{
				this.ejMediaPlayer1.Widget.unmute();
				isMute = false;
			} else
			{
				this.ejMediaPlayer1.Widget.mute();
				isMute = true;
			}
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Widget.play();
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Widget.pause();
		}

		private void buttonFullScreen_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Widget.makeFullScreen();
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Widget.next();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Widget.stop();
		}

		private void ejMediaPlayer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Options.renderMode = this.comboBoxRenderMode.Text.ToLower();

			this.ejMediaPlayer1.Update();
		}
	}
}
