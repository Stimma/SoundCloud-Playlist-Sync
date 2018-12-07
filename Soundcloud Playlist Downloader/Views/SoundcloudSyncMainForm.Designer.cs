﻿using Soundcloud_Playlist_Downloader.Properties;

namespace Soundcloud_Playlist_Downloader.Views
{
    partial class SoundcloudSyncMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundcloudSyncMainForm));
            this.syncButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.favoritesRadio = new System.Windows.Forms.RadioButton();
            this.userPlaylists = new System.Windows.Forms.RadioButton();
            this.playlistRadio = new System.Windows.Forms.RadioButton();
            this.artistRadio = new System.Windows.Forms.RadioButton();
            this.chk_folderByArtist = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.config5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_highquality = new System.Windows.Forms.CheckBox();
            this.tt_qualityExplanation = new System.Windows.Forms.ToolTip(this.components);
            this.chk_convertToMp3 = new System.Windows.Forms.CheckBox();
            this.chk_replaceIllegalCharacters = new System.Windows.Forms.CheckBox();
            this.chk_includeArtistinFilename = new System.Windows.Forms.CheckBox();
            this.lbl_exclude = new System.Windows.Forms.Label();
            this.chk_excl_m4a = new System.Windows.Forms.CheckBox();
            this.chk_exl_aac = new System.Windows.Forms.CheckBox();
            this.pnl_convert = new System.Windows.Forms.Panel();
            this.rbttn_twoWay = new System.Windows.Forms.RadioButton();
            this.rbttn_oneWay = new System.Windows.Forms.RadioButton();
            this.gbox_syncMethod = new System.Windows.Forms.GroupBox();
            this.gbox_downMethod = new System.Windows.Forms.GroupBox();
            this.trackRadio = new System.Windows.Forms.RadioButton();
            this.gbox_url = new System.Windows.Forms.GroupBox();
            this.url = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_configurationPrefix = new System.Windows.Forms.Label();
            this.lbl_currentConfig = new System.Windows.Forms.Label();
            this.chk_configActive = new System.Windows.Forms.CheckBox();
            this.gbox_advanced_conversion = new System.Windows.Forms.GroupBox();
            this.chk_IncludeCreationDate = new System.Windows.Forms.CheckBox();
            this.chk_CreatePlaylists = new System.Windows.Forms.CheckBox();
            this.nudConcurrency = new System.Windows.Forms.NumericUpDown();
            this.concurrency = new System.Windows.Forms.Label();
            this.gbox_localdir = new System.Windows.Forms.GroupBox();
            this.directoryPath = new System.Windows.Forms.TextBox();
            this.lb_progressOfTracks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl_general = new System.Windows.Forms.TabControl();
            this.tabPage_BasicOptions = new System.Windows.Forms.TabPage();
            this.tabPage_AdvancedOptions = new System.Windows.Forms.TabPage();
            this.gbox_advanced_other = new System.Windows.Forms.GroupBox();
            this.chk_MergePlaylists = new System.Windows.Forms.CheckBox();
            this.gbox_advanced_enginebehaviour = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_convert.SuspendLayout();
            this.gbox_syncMethod.SuspendLayout();
            this.gbox_downMethod.SuspendLayout();
            this.gbox_url.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbox_advanced_conversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConcurrency)).BeginInit();
            this.gbox_localdir.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl_general.SuspendLayout();
            this.tabPage_BasicOptions.SuspendLayout();
            this.tabPage_AdvancedOptions.SuspendLayout();
            this.gbox_advanced_other.SuspendLayout();
            this.gbox_advanced_enginebehaviour.SuspendLayout();
            this.SuspendLayout();
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(6, 253);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(201, 23);
            this.syncButton.TabIndex = 4;
            this.syncButton.Text = "Synchronize";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(327, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(62, 20);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 224);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(201, 23);
            this.progressBar.TabIndex = 10;
            // 
            // favoritesRadio
            // 
            this.favoritesRadio.AutoSize = true;
            this.favoritesRadio.Location = new System.Drawing.Point(6, 57);
            this.favoritesRadio.Name = "favoritesRadio";
            this.favoritesRadio.Size = new System.Drawing.Size(253, 17);
            this.favoritesRadio.TabIndex = 12;
            this.favoritesRadio.Text = "All songs favorited by the user at this profile URL";
            this.favoritesRadio.UseVisualStyleBackColor = true;
            // 
            // userPlaylists
            // 
            this.userPlaylists.AutoSize = true;
            this.userPlaylists.Checked = true;
            this.userPlaylists.ForeColor = System.Drawing.Color.Black;
            this.userPlaylists.Location = new System.Drawing.Point(6, 16);
            this.userPlaylists.Name = "userPlaylists";
            this.userPlaylists.Size = new System.Drawing.Size(165, 17);
            this.userPlaylists.TabIndex = 15;
            this.userPlaylists.TabStop = true;
            this.userPlaylists.Text = "All playlists from this user URL";
            this.userPlaylists.UseVisualStyleBackColor = true;
            // 
            // playlistRadio
            // 
            this.playlistRadio.AutoSize = true;
            this.playlistRadio.Location = new System.Drawing.Point(6, 36);
            this.playlistRadio.Name = "playlistRadio";
            this.playlistRadio.Size = new System.Drawing.Size(168, 17);
            this.playlistRadio.TabIndex = 11;
            this.playlistRadio.Text = "All songs from this playlist URL";
            this.playlistRadio.UseVisualStyleBackColor = true;
            // 
            // artistRadio
            // 
            this.artistRadio.AutoSize = true;
            this.artistRadio.Location = new System.Drawing.Point(6, 80);
            this.artistRadio.Name = "artistRadio";
            this.artistRadio.Size = new System.Drawing.Size(155, 17);
            this.artistRadio.TabIndex = 13;
            this.artistRadio.Text = "All songs by this artists URL";
            this.artistRadio.UseVisualStyleBackColor = true;
            // 
            // chk_folderByArtist
            // 
            this.chk_folderByArtist.AutoSize = true;
            this.chk_folderByArtist.Checked = true;
            this.chk_folderByArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_folderByArtist.Location = new System.Drawing.Point(6, 40);
            this.chk_folderByArtist.Name = "chk_folderByArtist";
            this.chk_folderByArtist.Size = new System.Drawing.Size(172, 17);
            this.chk_folderByArtist.TabIndex = 15;
            this.chk_folderByArtist.Text = "Sort songs into folders by artist ";
            this.chk_folderByArtist.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.clientIDToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationsToolStripMenuItem
            // 
            this.configurationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.config1ToolStripMenuItem,
            this.config2ToolStripMenuItem,
            this.config3ToolStripMenuItem,
            this.config4ToolStripMenuItem,
            this.config5ToolStripMenuItem});
            this.configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            this.configurationsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.configurationsToolStripMenuItem.Text = "Configurations";
            // 
            // config1ToolStripMenuItem
            // 
            this.config1ToolStripMenuItem.Name = "config1ToolStripMenuItem";
            this.config1ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.config1ToolStripMenuItem.Text = "Config 1";
            this.config1ToolStripMenuItem.Click += new System.EventHandler(this.config1ToolStripMenuItem_Click);
            // 
            // config2ToolStripMenuItem
            // 
            this.config2ToolStripMenuItem.Name = "config2ToolStripMenuItem";
            this.config2ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.config2ToolStripMenuItem.Text = "Config 2";
            this.config2ToolStripMenuItem.Click += new System.EventHandler(this.config2ToolStripMenuItem_Click);
            // 
            // config3ToolStripMenuItem
            // 
            this.config3ToolStripMenuItem.Name = "config3ToolStripMenuItem";
            this.config3ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.config3ToolStripMenuItem.Text = "Config 3";
            this.config3ToolStripMenuItem.Click += new System.EventHandler(this.config3ToolStripMenuItem_Click);
            // 
            // config4ToolStripMenuItem
            // 
            this.config4ToolStripMenuItem.Name = "config4ToolStripMenuItem";
            this.config4ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.config4ToolStripMenuItem.Text = "Config 4";
            this.config4ToolStripMenuItem.Click += new System.EventHandler(this.config4ToolStripMenuItem_Click);
            // 
            // config5ToolStripMenuItem
            // 
            this.config5ToolStripMenuItem.Name = "config5ToolStripMenuItem";
            this.config5ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.config5ToolStripMenuItem.Text = "Config 5";
            this.config5ToolStripMenuItem.Click += new System.EventHandler(this.config5ToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // clientIDToolStripMenuItem
            // 
            this.clientIDToolStripMenuItem.Name = "clientIDToolStripMenuItem";
            this.clientIDToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.clientIDToolStripMenuItem.Text = "Client ID";
            this.clientIDToolStripMenuItem.Click += new System.EventHandler(this.clientIDToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // chk_highquality
            // 
            this.chk_highquality.AutoSize = true;
            this.chk_highquality.Checked = true;
            this.chk_highquality.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_highquality.Location = new System.Drawing.Point(6, 19);
            this.chk_highquality.Name = "chk_highquality";
            this.chk_highquality.Size = new System.Drawing.Size(213, 17);
            this.chk_highquality.TabIndex = 17;
            this.chk_highquality.Text = "Choose high quality versions if available";
            this.tt_qualityExplanation.SetToolTip(this.chk_highquality, "Some songs (not all) can be downloaded in high quality. These files are usually m" +
        "uch larger than the low quality MP3, thus taking more time to download. ");
            this.chk_highquality.UseVisualStyleBackColor = true;
            this.chk_highquality.CheckedChanged += new System.EventHandler(this.chk_highquality_CheckedChanged);
            // 
            // chk_convertToMp3
            // 
            this.chk_convertToMp3.AutoSize = true;
            this.chk_convertToMp3.Checked = true;
            this.chk_convertToMp3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_convertToMp3.Location = new System.Drawing.Point(3, 3);
            this.chk_convertToMp3.Name = "chk_convertToMp3";
            this.chk_convertToMp3.Size = new System.Drawing.Size(156, 17);
            this.chk_convertToMp3.TabIndex = 18;
            this.chk_convertToMp3.Text = "Convert high quality to MP3";
            this.tt_qualityExplanation.SetToolTip(this.chk_convertToMp3, "Writing metadata to high quality files in a lossless format is problematic for so" +
        "me fields. There isn\'t a broadly used standard like ID3 for MP3.");
            this.chk_convertToMp3.UseVisualStyleBackColor = true;
            this.chk_convertToMp3.CheckedChanged += new System.EventHandler(this.chk_convertToMp3_CheckedChanged);
            // 
            // chk_replaceIllegalCharacters
            // 
            this.chk_replaceIllegalCharacters.AutoSize = true;
            this.chk_replaceIllegalCharacters.Checked = true;
            this.chk_replaceIllegalCharacters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_replaceIllegalCharacters.Location = new System.Drawing.Point(6, 19);
            this.chk_replaceIllegalCharacters.Name = "chk_replaceIllegalCharacters";
            this.chk_replaceIllegalCharacters.Size = new System.Drawing.Size(333, 17);
            this.chk_replaceIllegalCharacters.TabIndex = 22;
            this.chk_replaceIllegalCharacters.Text = "Replace illegal characters in filename with equivalent instead of _";
            this.tt_qualityExplanation.SetToolTip(this.chk_replaceIllegalCharacters, "Characters to be replaced: / ? < > \\ : * | \"\r\nWill be replaced with Halfwidth and" +
        " Fullwidth Forms\r\n");
            this.chk_replaceIllegalCharacters.UseVisualStyleBackColor = true;
            // 
            // chk_includeArtistinFilename
            // 
            this.chk_includeArtistinFilename.AutoSize = true;
            this.chk_includeArtistinFilename.Checked = true;
            this.chk_includeArtistinFilename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeArtistinFilename.Location = new System.Drawing.Point(185, 40);
            this.chk_includeArtistinFilename.Name = "chk_includeArtistinFilename";
            this.chk_includeArtistinFilename.Size = new System.Drawing.Size(168, 17);
            this.chk_includeArtistinFilename.TabIndex = 20;
            this.chk_includeArtistinFilename.Text = "Include artist name in filename";
            this.chk_includeArtistinFilename.UseVisualStyleBackColor = true;
            // 
            // lbl_exclude
            // 
            this.lbl_exclude.AutoSize = true;
            this.lbl_exclude.Location = new System.Drawing.Point(51, 25);
            this.lbl_exclude.Name = "lbl_exclude";
            this.lbl_exclude.Size = new System.Drawing.Size(48, 13);
            this.lbl_exclude.TabIndex = 23;
            this.lbl_exclude.Text = "Exclude:";
            // 
            // chk_excl_m4a
            // 
            this.chk_excl_m4a.AutoSize = true;
            this.chk_excl_m4a.Location = new System.Drawing.Point(105, 25);
            this.chk_excl_m4a.Name = "chk_excl_m4a";
            this.chk_excl_m4a.Size = new System.Drawing.Size(49, 17);
            this.chk_excl_m4a.TabIndex = 24;
            this.chk_excl_m4a.Text = ".m4a";
            this.chk_excl_m4a.UseVisualStyleBackColor = true;
            // 
            // chk_exl_aac
            // 
            this.chk_exl_aac.AutoSize = true;
            this.chk_exl_aac.Location = new System.Drawing.Point(105, 44);
            this.chk_exl_aac.Name = "chk_exl_aac";
            this.chk_exl_aac.Size = new System.Drawing.Size(47, 17);
            this.chk_exl_aac.TabIndex = 25;
            this.chk_exl_aac.Text = ".aac";
            this.chk_exl_aac.UseVisualStyleBackColor = true;
            // 
            // pnl_convert
            // 
            this.pnl_convert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_convert.Controls.Add(this.chk_convertToMp3);
            this.pnl_convert.Controls.Add(this.chk_exl_aac);
            this.pnl_convert.Controls.Add(this.lbl_exclude);
            this.pnl_convert.Controls.Add(this.chk_excl_m4a);
            this.pnl_convert.Location = new System.Drawing.Point(20, 42);
            this.pnl_convert.Name = "pnl_convert";
            this.pnl_convert.Size = new System.Drawing.Size(199, 68);
            this.pnl_convert.TabIndex = 26;
            // 
            // rbttn_twoWay
            // 
            this.rbttn_twoWay.AutoSize = true;
            this.rbttn_twoWay.Location = new System.Drawing.Point(6, 39);
            this.rbttn_twoWay.Name = "rbttn_twoWay";
            this.rbttn_twoWay.Size = new System.Drawing.Size(279, 17);
            this.rbttn_twoWay.TabIndex = 28;
            this.rbttn_twoWay.Text = "Two-way sync: Locally delete songs removed from SC";
            this.rbttn_twoWay.UseVisualStyleBackColor = true;
            this.rbttn_twoWay.CheckedChanged += new System.EventHandler(this.rbttn_twoWay_CheckedChanged);
            // 
            // rbttn_oneWay
            // 
            this.rbttn_oneWay.AutoSize = true;
            this.rbttn_oneWay.Checked = true;
            this.rbttn_oneWay.Location = new System.Drawing.Point(6, 17);
            this.rbttn_oneWay.Name = "rbttn_oneWay";
            this.rbttn_oneWay.Size = new System.Drawing.Size(268, 17);
            this.rbttn_oneWay.TabIndex = 29;
            this.rbttn_oneWay.TabStop = true;
            this.rbttn_oneWay.Text = "One-way sync: Re-download locally removed songs";
            this.rbttn_oneWay.UseVisualStyleBackColor = true;
            // 
            // gbox_syncMethod
            // 
            this.gbox_syncMethod.Controls.Add(this.rbttn_oneWay);
            this.gbox_syncMethod.Controls.Add(this.rbttn_twoWay);
            this.gbox_syncMethod.Location = new System.Drawing.Point(20, 256);
            this.gbox_syncMethod.Name = "gbox_syncMethod";
            this.gbox_syncMethod.Size = new System.Drawing.Size(393, 62);
            this.gbox_syncMethod.TabIndex = 30;
            this.gbox_syncMethod.TabStop = false;
            this.gbox_syncMethod.Text = "Sync Method";
            // 
            // gbox_downMethod
            // 
            this.gbox_downMethod.Controls.Add(this.userPlaylists);
            this.gbox_downMethod.Controls.Add(this.trackRadio);
            this.gbox_downMethod.Controls.Add(this.playlistRadio);
            this.gbox_downMethod.Controls.Add(this.artistRadio);
            this.gbox_downMethod.Controls.Add(this.favoritesRadio);
            this.gbox_downMethod.Location = new System.Drawing.Point(20, 126);
            this.gbox_downMethod.Name = "gbox_downMethod";
            this.gbox_downMethod.Size = new System.Drawing.Size(393, 124);
            this.gbox_downMethod.TabIndex = 31;
            this.gbox_downMethod.TabStop = false;
            this.gbox_downMethod.Text = "Download Method";
            this.gbox_downMethod.Enter += new System.EventHandler(this.gbox_downMethod_Enter);
            // 
            // trackRadio
            // 
            this.trackRadio.AutoSize = true;
            this.trackRadio.Location = new System.Drawing.Point(6, 100);
            this.trackRadio.Name = "trackRadio";
            this.trackRadio.Size = new System.Drawing.Size(212, 17);
            this.trackRadio.TabIndex = 14;
            this.trackRadio.Text = "Single track URL (ignores sync method)";
            this.trackRadio.UseVisualStyleBackColor = true;
            // 
            // gbox_url
            // 
            this.gbox_url.Controls.Add(this.url);
            this.gbox_url.Location = new System.Drawing.Point(20, 13);
            this.gbox_url.Name = "gbox_url";
            this.gbox_url.Size = new System.Drawing.Size(393, 48);
            this.gbox_url.TabIndex = 32;
            this.gbox_url.TabStop = false;
            this.gbox_url.Text = "SoundCloud URL";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(6, 19);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(284, 20);
            this.url.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_configurationPrefix);
            this.groupBox2.Controls.Add(this.lbl_currentConfig);
            this.groupBox2.Controls.Add(this.chk_configActive);
            this.groupBox2.Location = new System.Drawing.Point(445, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 47);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config State";
            // 
            // lbl_configurationPrefix
            // 
            this.lbl_configurationPrefix.AutoSize = true;
            this.lbl_configurationPrefix.Location = new System.Drawing.Point(6, 23);
            this.lbl_configurationPrefix.Name = "lbl_configurationPrefix";
            this.lbl_configurationPrefix.Size = new System.Drawing.Size(69, 13);
            this.lbl_configurationPrefix.TabIndex = 40;
            this.lbl_configurationPrefix.Text = "Configuration";
            // 
            // lbl_currentConfig
            // 
            this.lbl_currentConfig.AutoSize = true;
            this.lbl_currentConfig.Location = new System.Drawing.Point(73, 23);
            this.lbl_currentConfig.Name = "lbl_currentConfig";
            this.lbl_currentConfig.Size = new System.Drawing.Size(13, 13);
            this.lbl_currentConfig.TabIndex = 39;
            this.lbl_currentConfig.Text = "1";
            // 
            // chk_configActive
            // 
            this.chk_configActive.AutoSize = true;
            this.chk_configActive.Checked = true;
            this.chk_configActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_configActive.Location = new System.Drawing.Point(92, 22);
            this.chk_configActive.Name = "chk_configActive";
            this.chk_configActive.Size = new System.Drawing.Size(56, 17);
            this.chk_configActive.TabIndex = 38;
            this.chk_configActive.Text = "Active";
            this.chk_configActive.UseVisualStyleBackColor = true;
            this.chk_configActive.CheckedChanged += new System.EventHandler(this.chk_configActive_CheckedChanged);
            // 
            // gbox_advanced_conversion
            // 
            this.gbox_advanced_conversion.Controls.Add(this.chk_highquality);
            this.gbox_advanced_conversion.Controls.Add(this.pnl_convert);
            this.gbox_advanced_conversion.Location = new System.Drawing.Point(21, 15);
            this.gbox_advanced_conversion.Name = "gbox_advanced_conversion";
            this.gbox_advanced_conversion.Size = new System.Drawing.Size(391, 118);
            this.gbox_advanced_conversion.TabIndex = 33;
            this.gbox_advanced_conversion.TabStop = false;
            this.gbox_advanced_conversion.Text = "Conversion";
            // 
            // chk_IncludeCreationDate
            // 
            this.chk_IncludeCreationDate.AutoSize = true;
            this.chk_IncludeCreationDate.Location = new System.Drawing.Point(185, 17);
            this.chk_IncludeCreationDate.Name = "chk_IncludeCreationDate";
            this.chk_IncludeCreationDate.Size = new System.Drawing.Size(187, 17);
            this.chk_IncludeCreationDate.TabIndex = 32;
            this.chk_IncludeCreationDate.Text = "Include SoundCloud creation date";
            this.chk_IncludeCreationDate.UseVisualStyleBackColor = true;
            // 
            // chk_CreatePlaylists
            // 
            this.chk_CreatePlaylists.AutoSize = true;
            this.chk_CreatePlaylists.Checked = true;
            this.chk_CreatePlaylists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_CreatePlaylists.Location = new System.Drawing.Point(6, 17);
            this.chk_CreatePlaylists.Name = "chk_CreatePlaylists";
            this.chk_CreatePlaylists.Size = new System.Drawing.Size(154, 17);
            this.chk_CreatePlaylists.TabIndex = 31;
            this.chk_CreatePlaylists.Text = "Generate m3u8 playlist files";
            this.chk_CreatePlaylists.UseVisualStyleBackColor = true;
            // 
            // nudConcurrency
            // 
            this.nudConcurrency.Location = new System.Drawing.Point(126, 45);
            this.nudConcurrency.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudConcurrency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConcurrency.Name = "nudConcurrency";
            this.nudConcurrency.ReadOnly = true;
            this.nudConcurrency.Size = new System.Drawing.Size(45, 20);
            this.nudConcurrency.TabIndex = 30;
            this.nudConcurrency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // concurrency
            // 
            this.concurrency.AutoSize = true;
            this.concurrency.Location = new System.Drawing.Point(3, 52);
            this.concurrency.Name = "concurrency";
            this.concurrency.Size = new System.Drawing.Size(120, 13);
            this.concurrency.TabIndex = 29;
            this.concurrency.Text = "Amount of concurrency:";
            // 
            // gbox_localdir
            // 
            this.gbox_localdir.Controls.Add(this.directoryPath);
            this.gbox_localdir.Controls.Add(this.browseButton);
            this.gbox_localdir.Location = new System.Drawing.Point(20, 67);
            this.gbox_localdir.Name = "gbox_localdir";
            this.gbox_localdir.Size = new System.Drawing.Size(393, 51);
            this.gbox_localdir.TabIndex = 34;
            this.gbox_localdir.TabStop = false;
            this.gbox_localdir.Text = "Local Directory";
            // 
            // directoryPath
            // 
            this.directoryPath.Location = new System.Drawing.Point(6, 19);
            this.directoryPath.Name = "directoryPath";
            this.directoryPath.Size = new System.Drawing.Size(315, 20);
            this.directoryPath.TabIndex = 5;
            // 
            // lb_progressOfTracks
            // 
            this.lb_progressOfTracks.BackColor = System.Drawing.SystemColors.Menu;
            this.lb_progressOfTracks.FormattingEnabled = true;
            this.lb_progressOfTracks.HorizontalScrollbar = true;
            this.lb_progressOfTracks.Location = new System.Drawing.Point(6, 19);
            this.lb_progressOfTracks.Name = "lb_progressOfTracks";
            this.lb_progressOfTracks.Size = new System.Drawing.Size(199, 199);
            this.lb_progressOfTracks.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_progressOfTracks);
            this.groupBox1.Controls.Add(this.syncButton);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Location = new System.Drawing.Point(445, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 285);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Progress";
            // 
            // tabControl_general
            // 
            this.tabControl_general.Controls.Add(this.tabPage_BasicOptions);
            this.tabControl_general.Controls.Add(this.tabPage_AdvancedOptions);
            this.tabControl_general.Location = new System.Drawing.Point(12, 38);
            this.tabControl_general.Name = "tabControl_general";
            this.tabControl_general.SelectedIndex = 0;
            this.tabControl_general.Size = new System.Drawing.Size(427, 357);
            this.tabControl_general.TabIndex = 40;
            // 
            // tabPage_BasicOptions
            // 
            this.tabPage_BasicOptions.Controls.Add(this.gbox_url);
            this.tabPage_BasicOptions.Controls.Add(this.gbox_localdir);
            this.tabPage_BasicOptions.Controls.Add(this.gbox_syncMethod);
            this.tabPage_BasicOptions.Controls.Add(this.gbox_downMethod);
            this.tabPage_BasicOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BasicOptions.Name = "tabPage_BasicOptions";
            this.tabPage_BasicOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BasicOptions.Size = new System.Drawing.Size(419, 331);
            this.tabPage_BasicOptions.TabIndex = 0;
            this.tabPage_BasicOptions.Text = "Basic Options";
            this.tabPage_BasicOptions.UseVisualStyleBackColor = true;
            // 
            // tabPage_AdvancedOptions
            // 
            this.tabPage_AdvancedOptions.Controls.Add(this.gbox_advanced_other);
            this.tabPage_AdvancedOptions.Controls.Add(this.gbox_advanced_enginebehaviour);
            this.tabPage_AdvancedOptions.Controls.Add(this.gbox_advanced_conversion);
            this.tabPage_AdvancedOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AdvancedOptions.Name = "tabPage_AdvancedOptions";
            this.tabPage_AdvancedOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AdvancedOptions.Size = new System.Drawing.Size(419, 331);
            this.tabPage_AdvancedOptions.TabIndex = 1;
            this.tabPage_AdvancedOptions.Text = "Advanced Options";
            this.tabPage_AdvancedOptions.UseVisualStyleBackColor = true;
            // 
            // gbox_advanced_other
            // 
            this.gbox_advanced_other.Controls.Add(this.chk_includeArtistinFilename);
            this.gbox_advanced_other.Controls.Add(this.chk_folderByArtist);
            this.gbox_advanced_other.Controls.Add(this.chk_IncludeCreationDate);
            this.gbox_advanced_other.Controls.Add(this.chk_MergePlaylists);
            this.gbox_advanced_other.Controls.Add(this.chk_CreatePlaylists);
            this.gbox_advanced_other.Location = new System.Drawing.Point(21, 225);
            this.gbox_advanced_other.Name = "gbox_advanced_other";
            this.gbox_advanced_other.Size = new System.Drawing.Size(391, 83);
            this.gbox_advanced_other.TabIndex = 35;
            this.gbox_advanced_other.TabStop = false;
            this.gbox_advanced_other.Text = "Other";
            // 
            // chk_MergePlaylists
            // 
            this.chk_MergePlaylists.AutoSize = true;
            this.chk_MergePlaylists.Checked = true;
            this.chk_MergePlaylists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_MergePlaylists.Location = new System.Drawing.Point(6, 63);
            this.chk_MergePlaylists.Name = "chk_MergePlaylists";
            this.chk_MergePlaylists.Size = new System.Drawing.Size(156, 17);
            this.chk_MergePlaylists.TabIndex = 33;
            this.chk_MergePlaylists.Text = "Merge SoundCloud playlists";
            this.chk_MergePlaylists.UseVisualStyleBackColor = true;
            // 
            // gbox_advanced_enginebehaviour
            // 
            this.gbox_advanced_enginebehaviour.Controls.Add(this.chk_replaceIllegalCharacters);
            this.gbox_advanced_enginebehaviour.Controls.Add(this.nudConcurrency);
            this.gbox_advanced_enginebehaviour.Controls.Add(this.concurrency);
            this.gbox_advanced_enginebehaviour.Location = new System.Drawing.Point(21, 139);
            this.gbox_advanced_enginebehaviour.Name = "gbox_advanced_enginebehaviour";
            this.gbox_advanced_enginebehaviour.Size = new System.Drawing.Size(391, 80);
            this.gbox_advanced_enginebehaviour.TabIndex = 34;
            this.gbox_advanced_enginebehaviour.TabStop = false;
            this.gbox_advanced_enginebehaviour.Text = "Download Behaviour";
            // 
            // SoundcloudSyncMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 428);
            this.Controls.Add(this.tabControl_general);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SoundcloudSyncMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_convert.ResumeLayout(false);
            this.pnl_convert.PerformLayout();
            this.gbox_syncMethod.ResumeLayout(false);
            this.gbox_syncMethod.PerformLayout();
            this.gbox_downMethod.ResumeLayout(false);
            this.gbox_downMethod.PerformLayout();
            this.gbox_url.ResumeLayout(false);
            this.gbox_url.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbox_advanced_conversion.ResumeLayout(false);
            this.gbox_advanced_conversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConcurrency)).EndInit();
            this.gbox_localdir.ResumeLayout(false);
            this.gbox_localdir.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl_general.ResumeLayout(false);
            this.tabPage_BasicOptions.ResumeLayout(false);
            this.tabPage_AdvancedOptions.ResumeLayout(false);
            this.gbox_advanced_other.ResumeLayout(false);
            this.gbox_advanced_other.PerformLayout();
            this.gbox_advanced_enginebehaviour.ResumeLayout(false);
            this.gbox_advanced_enginebehaviour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.TextBox directoryPath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton userPlaylists;
        private System.Windows.Forms.RadioButton playlistRadio;
        private System.Windows.Forms.RadioButton favoritesRadio;
        private System.Windows.Forms.RadioButton artistRadio;
        private System.Windows.Forms.CheckBox chk_folderByArtist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_highquality;
        private System.Windows.Forms.ToolTip tt_qualityExplanation;
        private System.Windows.Forms.CheckBox chk_convertToMp3;
        private System.Windows.Forms.CheckBox chk_includeArtistinFilename;
        private System.Windows.Forms.CheckBox chk_replaceIllegalCharacters;
        private System.Windows.Forms.Label lbl_exclude;
        private System.Windows.Forms.CheckBox chk_excl_m4a;
        private System.Windows.Forms.CheckBox chk_exl_aac;
        private System.Windows.Forms.Panel pnl_convert;
        private System.Windows.Forms.RadioButton rbttn_twoWay;
        private System.Windows.Forms.RadioButton rbttn_oneWay;
        private System.Windows.Forms.GroupBox gbox_syncMethod;
        private System.Windows.Forms.GroupBox gbox_downMethod;
        private System.Windows.Forms.GroupBox gbox_url;
        private System.Windows.Forms.GroupBox gbox_advanced_conversion;
        private System.Windows.Forms.GroupBox gbox_localdir;
        private System.Windows.Forms.RadioButton trackRadio;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Label concurrency;
        private System.Windows.Forms.NumericUpDown nudConcurrency;
        private System.Windows.Forms.ListBox lb_progressOfTracks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem clientIDToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_CreatePlaylists;
        private System.Windows.Forms.CheckBox chk_IncludeCreationDate;
        private System.Windows.Forms.ToolStripMenuItem configurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config2ToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_configActive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_currentConfig;
        private System.Windows.Forms.ToolStripMenuItem config3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem config5ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_configurationPrefix;
        private System.Windows.Forms.TabControl tabControl_general;
        private System.Windows.Forms.TabPage tabPage_BasicOptions;
        private System.Windows.Forms.TabPage tabPage_AdvancedOptions;
        private System.Windows.Forms.CheckBox chk_MergePlaylists;
        private System.Windows.Forms.GroupBox gbox_advanced_other;
        private System.Windows.Forms.GroupBox gbox_advanced_enginebehaviour;
    }
}