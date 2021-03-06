﻿using System;
using System.Windows.Forms;
using ACT_FFXIV_Kapture.Resource;

namespace ACT_FFXIV_Kapture.Presentation
{
	public partial class AboutView : UserControl
	{
		public AboutView()
		{
			InitializeComponent();

			about_TitleLabel.Text = Strings.KaptureLootTracker;
			about_UpdateButton.Text = Strings.CheckForUpdates;
			about_ViewLogsButton.Text = Strings.ViewPluginLog;

			about_VersionKeyLabel.Text = Strings.Version;

			about_AuthorKeyLabel.Text = Strings.Author;
			about_AuthorValueLabel.Text = Strings.Kalilistic;
			about_AuthorValueLabel.Tag = "https://github.com/kalilistic";

			about_SupportKeyLabel.Text = Strings.Support;
			about_SupportValueLabel.Text = Strings.Discord;
			about_SupportValueLabel.Tag = "https://discord.gg/ftn4k7x";

			about_SourceKeyLabel.Text = Strings.Source;
			about_SourceValueLabel.Text = Strings.Github;
			about_SourceValueLabel.Tag = "https://github.com/kalilistic/Kapture";

			about_LicenseKeyLabel.Text = Strings.License;
			about_LicenseValueLabel.Text = Strings.MIT;
			about_LicenseValueLabel.Tag = "https://github.com/kalilistic/Kapture/blob/master/LICENSE";

			about_AuthorValueLabel.Click += Link_Click;
			about_SupportValueLabel.Click += Link_Click;
			about_SourceValueLabel.Click += Link_Click;
			about_LicenseValueLabel.Click += Link_Click;

			about_UpdateButton.Click += UpdateBtn_Click;
			about_ViewLogsButton.Click += ViewLogsBtn_Click;
		}

		public string Version
		{
			get => about_VersionValueLabel.Text;
			set => about_VersionValueLabel.Text = value;
		}

		public event EventHandler<string> LinkClicked;
		public event EventHandler<bool> UpdateClicked;
		public event EventHandler<bool> ViewLogsClicked;

		private void Link_Click(object sender, EventArgs e)
		{
			LinkClicked?.Invoke(this, ((Label) sender).Tag.ToString());
		}

		private void UpdateBtn_Click(object sender, EventArgs e)
		{
			UpdateClicked?.Invoke(this, true);
		}

		private void ViewLogsBtn_Click(object sender, EventArgs e)
		{
			ViewLogsClicked?.Invoke(this, true);
		}
	}
}