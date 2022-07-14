
namespace Music_Player
{
	partial class MusicPlayerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerForm));
			this.VolumeTrackBar = new Guna.UI.WinForms.GunaMetroTrackBar();
			this.PlaybarPanel = new System.Windows.Forms.Panel();
			this.MuteUnMuteButton = new Guna.UI.WinForms.GunaButton();
			this.DeleteButton = new Guna.UI.WinForms.GunaButton();
			this.TrackEndLabel = new System.Windows.Forms.Label();
			this.TrackStartLabel = new System.Windows.Forms.Label();
			this.MusicTrackBar = new Guna.UI.WinForms.GunaTrackBar();
			this.OpenButton = new Guna.UI.WinForms.GunaButton();
			this.PreviousButton = new Guna.UI.WinForms.GunaButton();
			this.NextButton = new Guna.UI.WinForms.GunaButton();
			this.PlayPauseButton = new Guna.UI.WinForms.GunaButton();
			this.TopPanel = new System.Windows.Forms.Panel();
			this.MinimizeButton = new Guna.UI.WinForms.GunaButton();
			this.ExitButton = new Guna.UI.WinForms.GunaButton();
			this.MusicPictureBox = new System.Windows.Forms.PictureBox();
			this.MusicListBox = new System.Windows.Forms.ListBox();
			this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.TrackDuration = new System.Windows.Forms.Timer(this.components);
			this.VolumeToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.PlaybarPanel.SuspendLayout();
			this.TopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MusicPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// VolumeTrackBar
			// 
			this.VolumeTrackBar.Enabled = false;
			this.VolumeTrackBar.Location = new System.Drawing.Point(676, 26);
			this.VolumeTrackBar.Name = "VolumeTrackBar";
			this.VolumeTrackBar.Size = new System.Drawing.Size(100, 23);
			this.VolumeTrackBar.TabIndex = 4;
			this.VolumeTrackBar.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.VolumeTrackBar.TrackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
			this.VolumeTrackBar.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.VolumeTrackBar.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.VolumeTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeTrackBar_Scroll);
			// 
			// PlaybarPanel
			// 
			this.PlaybarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.PlaybarPanel.Controls.Add(this.MuteUnMuteButton);
			this.PlaybarPanel.Controls.Add(this.DeleteButton);
			this.PlaybarPanel.Controls.Add(this.TrackEndLabel);
			this.PlaybarPanel.Controls.Add(this.TrackStartLabel);
			this.PlaybarPanel.Controls.Add(this.MusicTrackBar);
			this.PlaybarPanel.Controls.Add(this.OpenButton);
			this.PlaybarPanel.Controls.Add(this.VolumeTrackBar);
			this.PlaybarPanel.Controls.Add(this.PreviousButton);
			this.PlaybarPanel.Controls.Add(this.NextButton);
			this.PlaybarPanel.Controls.Add(this.PlayPauseButton);
			this.PlaybarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PlaybarPanel.Location = new System.Drawing.Point(0, 350);
			this.PlaybarPanel.Name = "PlaybarPanel";
			this.PlaybarPanel.Size = new System.Drawing.Size(800, 100);
			this.PlaybarPanel.TabIndex = 0;
			// 
			// MuteUnMuteButton
			// 
			this.MuteUnMuteButton.AnimationHoverSpeed = 0.07F;
			this.MuteUnMuteButton.AnimationSpeed = 0.03F;
			this.MuteUnMuteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.MuteUnMuteButton.BorderColor = System.Drawing.Color.Black;
			this.MuteUnMuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.MuteUnMuteButton.FocusedColor = System.Drawing.Color.Empty;
			this.MuteUnMuteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MuteUnMuteButton.ForeColor = System.Drawing.Color.White;
			this.MuteUnMuteButton.Image = global::Music_Player.Properties.Resources.output_onlinepngtools;
			this.MuteUnMuteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MuteUnMuteButton.ImageSize = new System.Drawing.Size(20, 20);
			this.MuteUnMuteButton.Location = new System.Drawing.Point(644, 26);
			this.MuteUnMuteButton.Name = "MuteUnMuteButton";
			this.MuteUnMuteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.MuteUnMuteButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.MuteUnMuteButton.OnHoverForeColor = System.Drawing.Color.White;
			this.MuteUnMuteButton.OnHoverImage = null;
			this.MuteUnMuteButton.OnPressedColor = System.Drawing.Color.Black;
			this.MuteUnMuteButton.Size = new System.Drawing.Size(24, 23);
			this.MuteUnMuteButton.TabIndex = 11;
			this.MuteUnMuteButton.Click += new System.EventHandler(this.MuteUnMuteButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.AnimationHoverSpeed = 0.07F;
			this.DeleteButton.AnimationSpeed = 0.03F;
			this.DeleteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.DeleteButton.BorderColor = System.Drawing.Color.Black;
			this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.DeleteButton.FocusedColor = System.Drawing.Color.Empty;
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.DeleteButton.ForeColor = System.Drawing.Color.White;
			this.DeleteButton.Image = global::Music_Player.Properties.Resources.Delete;
			this.DeleteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.DeleteButton.ImageSize = new System.Drawing.Size(20, 20);
			this.DeleteButton.Location = new System.Drawing.Point(98, 16);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.DeleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.DeleteButton.OnHoverForeColor = System.Drawing.Color.White;
			this.DeleteButton.OnHoverImage = null;
			this.DeleteButton.OnPressedColor = System.Drawing.Color.Black;
			this.DeleteButton.Size = new System.Drawing.Size(54, 42);
			this.DeleteButton.TabIndex = 8;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// TrackEndLabel
			// 
			this.TrackEndLabel.AutoSize = true;
			this.TrackEndLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrackEndLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.TrackEndLabel.Location = new System.Drawing.Point(753, 73);
			this.TrackEndLabel.Name = "TrackEndLabel";
			this.TrackEndLabel.Size = new System.Drawing.Size(33, 16);
			this.TrackEndLabel.TabIndex = 7;
			this.TrackEndLabel.Text = "0:00";
			// 
			// TrackStartLabel
			// 
			this.TrackStartLabel.AutoSize = true;
			this.TrackStartLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrackStartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.TrackStartLabel.Location = new System.Drawing.Point(14, 73);
			this.TrackStartLabel.Name = "TrackStartLabel";
			this.TrackStartLabel.Size = new System.Drawing.Size(33, 16);
			this.TrackStartLabel.TabIndex = 6;
			this.TrackStartLabel.Text = "0:00";
			// 
			// MusicTrackBar
			// 
			this.MusicTrackBar.AllowDrop = true;
			this.MusicTrackBar.Enabled = false;
			this.MusicTrackBar.Location = new System.Drawing.Point(64, 71);
			this.MusicTrackBar.Name = "MusicTrackBar";
			this.MusicTrackBar.Size = new System.Drawing.Size(669, 23);
			this.MusicTrackBar.TabIndex = 4;
			this.MusicTrackBar.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.MusicTrackBar.TrackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.MusicTrackBar.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.MusicTrackBar.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.MusicTrackBar.Value = 0;
			this.MusicTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MusicTrackBar_Scroll);
			this.MusicTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicTrackBar_MouseDown);
			// 
			// OpenButton
			// 
			this.OpenButton.AnimationHoverSpeed = 0.07F;
			this.OpenButton.AnimationSpeed = 0.03F;
			this.OpenButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.OpenButton.BorderColor = System.Drawing.Color.Black;
			this.OpenButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.OpenButton.FocusedColor = System.Drawing.Color.Empty;
			this.OpenButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.OpenButton.ForeColor = System.Drawing.Color.White;
			this.OpenButton.Image = global::Music_Player.Properties.Resources.Create_Playlist;
			this.OpenButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.OpenButton.ImageSize = new System.Drawing.Size(20, 20);
			this.OpenButton.Location = new System.Drawing.Point(44, 16);
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.OpenButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.OpenButton.OnHoverForeColor = System.Drawing.Color.White;
			this.OpenButton.OnHoverImage = null;
			this.OpenButton.OnPressedColor = System.Drawing.Color.Black;
			this.OpenButton.Size = new System.Drawing.Size(54, 42);
			this.OpenButton.TabIndex = 5;
			this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
			this.OpenButton.MouseHover += new System.EventHandler(this.OpenButton_MouseHover);
			// 
			// PreviousButton
			// 
			this.PreviousButton.AnimationHoverSpeed = 0.07F;
			this.PreviousButton.AnimationSpeed = 0.03F;
			this.PreviousButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.PreviousButton.BorderColor = System.Drawing.Color.Black;
			this.PreviousButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.PreviousButton.FocusedColor = System.Drawing.Color.Empty;
			this.PreviousButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.PreviousButton.ForeColor = System.Drawing.Color.White;
			this.PreviousButton.Image = global::Music_Player.Properties.Resources.Previous;
			this.PreviousButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PreviousButton.ImageSize = new System.Drawing.Size(20, 20);
			this.PreviousButton.Location = new System.Drawing.Point(313, 16);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.PreviousButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.PreviousButton.OnHoverForeColor = System.Drawing.Color.White;
			this.PreviousButton.OnHoverImage = null;
			this.PreviousButton.OnPressedColor = System.Drawing.Color.Black;
			this.PreviousButton.Size = new System.Drawing.Size(54, 42);
			this.PreviousButton.TabIndex = 3;
			this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
			// 
			// NextButton
			// 
			this.NextButton.AnimationHoverSpeed = 0.07F;
			this.NextButton.AnimationSpeed = 0.03F;
			this.NextButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.NextButton.BorderColor = System.Drawing.Color.Black;
			this.NextButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.NextButton.FocusedColor = System.Drawing.Color.Empty;
			this.NextButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.NextButton.ForeColor = System.Drawing.Color.White;
			this.NextButton.Image = global::Music_Player.Properties.Resources.Next;
			this.NextButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NextButton.ImageSize = new System.Drawing.Size(20, 20);
			this.NextButton.Location = new System.Drawing.Point(433, 16);
			this.NextButton.Name = "NextButton";
			this.NextButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.NextButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.NextButton.OnHoverForeColor = System.Drawing.Color.White;
			this.NextButton.OnHoverImage = null;
			this.NextButton.OnPressedColor = System.Drawing.Color.Black;
			this.NextButton.Size = new System.Drawing.Size(54, 42);
			this.NextButton.TabIndex = 2;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// PlayPauseButton
			// 
			this.PlayPauseButton.AnimationHoverSpeed = 0.07F;
			this.PlayPauseButton.AnimationSpeed = 0.03F;
			this.PlayPauseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.PlayPauseButton.BorderColor = System.Drawing.Color.Black;
			this.PlayPauseButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.PlayPauseButton.FocusedColor = System.Drawing.Color.Empty;
			this.PlayPauseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.PlayPauseButton.ForeColor = System.Drawing.Color.White;
			this.PlayPauseButton.Image = global::Music_Player.Properties.Resources.Play;
			this.PlayPauseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PlayPauseButton.ImageSize = new System.Drawing.Size(20, 20);
			this.PlayPauseButton.Location = new System.Drawing.Point(373, 16);
			this.PlayPauseButton.Name = "PlayPauseButton";
			this.PlayPauseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.PlayPauseButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.PlayPauseButton.OnHoverForeColor = System.Drawing.Color.White;
			this.PlayPauseButton.OnHoverImage = null;
			this.PlayPauseButton.OnPressedColor = System.Drawing.Color.Black;
			this.PlayPauseButton.Size = new System.Drawing.Size(54, 42);
			this.PlayPauseButton.TabIndex = 1;
			this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.TopPanel.Controls.Add(this.MinimizeButton);
			this.TopPanel.Controls.Add(this.ExitButton);
			this.TopPanel.Controls.Add(this.MusicPictureBox);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(800, 64);
			this.TopPanel.TabIndex = 1;
			// 
			// MinimizeButton
			// 
			this.MinimizeButton.AnimationHoverSpeed = 0.07F;
			this.MinimizeButton.AnimationSpeed = 0.03F;
			this.MinimizeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.MinimizeButton.BorderColor = System.Drawing.Color.Black;
			this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.MinimizeButton.FocusedColor = System.Drawing.Color.Empty;
			this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MinimizeButton.ForeColor = System.Drawing.Color.White;
			this.MinimizeButton.Image = global::Music_Player.Properties.Resources.output_onlinepngtools__3_;
			this.MinimizeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MinimizeButton.ImageSize = new System.Drawing.Size(20, 20);
			this.MinimizeButton.Location = new System.Drawing.Point(743, 3);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.MinimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.MinimizeButton.OnHoverForeColor = System.Drawing.Color.White;
			this.MinimizeButton.OnHoverImage = null;
			this.MinimizeButton.OnPressedColor = System.Drawing.Color.Black;
			this.MinimizeButton.Size = new System.Drawing.Size(25, 29);
			this.MinimizeButton.TabIndex = 13;
			this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.AnimationHoverSpeed = 0.07F;
			this.ExitButton.AnimationSpeed = 0.03F;
			this.ExitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.ExitButton.BorderColor = System.Drawing.Color.Black;
			this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
			this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ExitButton.ForeColor = System.Drawing.Color.White;
			this.ExitButton.Image = global::Music_Player.Properties.Resources.output_onlinepngtools__2_;
			this.ExitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ExitButton.ImageSize = new System.Drawing.Size(20, 20);
			this.ExitButton.Location = new System.Drawing.Point(772, 2);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black;
			this.ExitButton.OnHoverForeColor = System.Drawing.Color.White;
			this.ExitButton.OnHoverImage = null;
			this.ExitButton.OnPressedColor = System.Drawing.Color.Black;
			this.ExitButton.Size = new System.Drawing.Size(25, 29);
			this.ExitButton.TabIndex = 12;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MusicPictureBox
			// 
			this.MusicPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.MusicPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MusicPictureBox.Image")));
			this.MusicPictureBox.Location = new System.Drawing.Point(0, 0);
			this.MusicPictureBox.Name = "MusicPictureBox";
			this.MusicPictureBox.Size = new System.Drawing.Size(100, 64);
			this.MusicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.MusicPictureBox.TabIndex = 0;
			this.MusicPictureBox.TabStop = false;
			// 
			// MusicListBox
			// 
			this.MusicListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.MusicListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MusicListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MusicListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			this.MusicListBox.FormattingEnabled = true;
			this.MusicListBox.ItemHeight = 19;
			this.MusicListBox.Location = new System.Drawing.Point(14, 81);
			this.MusicListBox.Name = "MusicListBox";
			this.MusicListBox.Size = new System.Drawing.Size(774, 247);
			this.MusicListBox.TabIndex = 2;
			this.MusicListBox.SelectedIndexChanged += new System.EventHandler(this.MusicListBox_SelectedIndexChanged);
			// 
			// MusicPlayer
			// 
			this.MusicPlayer.Enabled = true;
			this.MusicPlayer.Location = new System.Drawing.Point(288, 70);
			this.MusicPlayer.Name = "MusicPlayer";
			this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
			this.MusicPlayer.Size = new System.Drawing.Size(462, 258);
			this.MusicPlayer.TabIndex = 3;
			this.MusicPlayer.Visible = false;
			// 
			// TrackDuration
			// 
			this.TrackDuration.Enabled = true;
			this.TrackDuration.Tick += new System.EventHandler(this.TrackDuration_Tick);
			// 
			// VolumeToolTip
			// 
			this.VolumeToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
			this.VolumeToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
			// 
			// MusicPlayerForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MusicPlayer);
			this.Controls.Add(this.MusicListBox);
			this.Controls.Add(this.TopPanel);
			this.Controls.Add(this.PlaybarPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MusicPlayerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "True Music";
			this.PlaybarPanel.ResumeLayout(false);
			this.PlaybarPanel.PerformLayout();
			this.TopPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MusicPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaButton PlayPauseButton;
		private Guna.UI.WinForms.GunaButton NextButton;
		private Guna.UI.WinForms.GunaButton PreviousButton;
		private Guna.UI.WinForms.GunaMetroTrackBar VolumeTrackBar;
		private Guna.UI.WinForms.GunaButton OpenButton;
		private System.Windows.Forms.Panel PlaybarPanel;
		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.ListBox MusicListBox;
		private System.Windows.Forms.PictureBox MusicPictureBox;
		private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
		private Guna.UI.WinForms.GunaTrackBar MusicTrackBar;
		private System.Windows.Forms.Timer TrackDuration;
		private System.Windows.Forms.Label TrackEndLabel;
		private System.Windows.Forms.Label TrackStartLabel;
		private Guna.UI.WinForms.GunaButton DeleteButton;
		private Guna.UI.WinForms.GunaButton MuteUnMuteButton;
		private System.Windows.Forms.ToolTip VolumeToolTip;
		private Guna.UI.WinForms.GunaButton ExitButton;
		private Guna.UI.WinForms.GunaButton MinimizeButton;
	}
}

