using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
	public partial class MusicPlayerForm : Form
	{
		bool play = true; //If play is true music is playing but if play is false so music is paused
		bool mute = true;
		string[] paths, files;
		List<string> trackpaths = new List<string>();
		public MusicPlayerForm()
		{
			InitializeComponent();
		}
		private void PlayPauseButton_Click(object sender, EventArgs e)
		{
			if (play == true)
			{
				MusicPlayer.Ctlcontrols.play();
				Bitmap b = new Bitmap(Properties.Resources.Pause);
				PlayPauseButton.Image = b;
				play = false;
			}
			else
			{
				MusicPlayer.Ctlcontrols.pause();
				Bitmap b = new Bitmap(Properties.Resources.Play);
				PlayPauseButton.Image = b;
				play = true;
			}
		}
		private void MusicListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (MusicListBox.SelectedIndex == -1) { return; }
			MusicPlayer.URL = trackpaths[MusicListBox.SelectedIndex];
			MusicPlayer.Ctlcontrols.play();
			Bitmap b = new Bitmap(Properties.Resources.Pause);
			PlayPauseButton.Image = b;
			play = false;
			MusicTrackBar.Value = 0;
			MusicTrackBar.Enabled = true;
			VolumeTrackBar.Enabled = true;
		}
		private void OpenButton_MouseHover(object sender, EventArgs e)
		{
			OpenButton.OnHoverBaseColor = Color.FromArgb(23, 21, 32);
		}
		private void NextButton_Click(object sender, EventArgs e)
		{
			if (MusicListBox.SelectedIndex < MusicListBox.Items.Count - 1)
			{
				MusicListBox.SelectedIndex = MusicListBox.SelectedIndex + 1;
			}
		}
		private void PreviousButton_Click(object sender, EventArgs e)
		{
			if (MusicListBox.SelectedIndex > 0)
			{
				MusicListBox.SelectedIndex = MusicListBox.SelectedIndex - 1;
			}
		}
		private void VolumeTrackBar_Scroll(object sender, ScrollEventArgs e)
		{
			MusicPlayer.settings.volume = VolumeTrackBar.Value;
			VolumeToolTip.SetToolTip(VolumeTrackBar, VolumeTrackBar.Value.ToString());
		}
		private void MusicTrackBar_MouseDown(object sender, MouseEventArgs e)
		{
			MusicPlayer.Ctlcontrols.currentPosition = MusicPlayer.currentMedia.duration * e.X / MusicTrackBar.Width;
		}
		private void MusicTrackBar_Scroll(object sender, ScrollEventArgs e)
		{
			MusicPlayer.Ctlcontrols.currentPosition = MusicTrackBar.Value;
		}
		private void TrackDuration_Tick(object sender, EventArgs e)
		{
			if (MusicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
			{
				MusicTrackBar.Maximum = (int)MusicPlayer.Ctlcontrols.currentItem.duration;
				MusicTrackBar.Value = (int)MusicPlayer.Ctlcontrols.currentPosition;
				TrackStartLabel.Text = MusicPlayer.Ctlcontrols.currentPositionString;
				TrackEndLabel.Text = MusicPlayer.Ctlcontrols.currentItem.durationString.ToString();
			}
			if (MusicTrackBar.Value == MusicTrackBar.Maximum && MusicListBox.SelectedIndex + 1 < trackpaths.Count)
			{
				MusicPlayer.URL = trackpaths[MusicListBox.SelectedIndex + 1];
				MusicListBox.SelectedIndex = MusicListBox.SelectedIndex + 1;
				MusicPlayer.Ctlcontrols.play();
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (files == null || MusicListBox.Items.Count < 1) { return; }
			else
			{
				for (int i = 0; i < files.Length; i++)
				{
					if (MusicListBox.SelectedItem == null) { return; }
					int j = MusicListBox.SelectedIndex;
					trackpaths.RemoveAt(j);
					MusicListBox.Items.RemoveAt(j);
					MusicPlayer.Ctlcontrols.stop();
				}
			}
		}
		private void MuteUnMuteButton_Click(object sender, EventArgs e)
		{
			if (mute == true)
			{
				Bitmap b = new Bitmap(Properties.Resources.output_onlinepngtools__1_);
				MuteUnMuteButton.Image = b;
				mute = false;
				VolumeTrackBar.Value = 0;
				MusicPlayer.settings.volume = 0;

			}
			else
			{
				Bitmap b = new Bitmap(Properties.Resources.output_onlinepngtools);
				MuteUnMuteButton.Image = b;
				mute = true;
				VolumeTrackBar.Value = 50;
				MusicPlayer.settings.volume = VolumeTrackBar.Value;
			}
		}
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void OpenButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = true;
			ofd.Filter = "Mp3 Files|*.mp3";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				files = ofd.SafeFileNames;
				paths = ofd.FileNames;
				for (int i = 0; i < files.Length; i++)
				{
					MusicListBox.Items.Add(files[i]);
				}
			}
			if (paths != null)
			{
				for (int i = 0; i < paths.Length; i++) trackpaths.Add(paths[i]);
			}
			OpenButton.OnHoverBaseColor = Color.FromArgb(30, 25, 35);
		}

	}
}
