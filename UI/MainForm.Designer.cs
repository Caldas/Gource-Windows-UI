namespace MineSolutions.GourceUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SystemNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.GourcePathLabel = new System.Windows.Forms.Label();
            this.GourcePathTextBox = new System.Windows.Forms.TextBox();
            this.GourcePathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GitCmdPathTextBox = new System.Windows.Forms.TextBox();
            this.GitCmdPathLabel = new System.Windows.Forms.Label();
            this.GitCmdPathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.RunButton = new System.Windows.Forms.Button();
            this.GitProjectPathTextBox = new System.Windows.Forms.TextBox();
            this.GitProjectPathLabel = new System.Windows.Forms.Label();
            this.GitProjectPathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PathGroupBox = new System.Windows.Forms.GroupBox();
            this.DefaultUserImagePathTextBox = new System.Windows.Forms.TextBox();
            this.DefaultUserImagePathLabel = new System.Windows.Forms.Label();
            this.UserImageDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.UserImageDirectoryPathLabel = new System.Windows.Forms.Label();
            this.BackgroundImagePathTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundImagePathLabel = new System.Windows.Forms.Label();
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.TrackRadioButton = new System.Windows.Forms.RadioButton();
            this.OverviewRadioButton = new System.Windows.Forms.RadioButton();
            this.CameraModeLabel = new System.Windows.Forms.Label();
            this.UseScreenResolutionCheckBox = new System.Windows.Forms.CheckBox();
            this.UseTransparencyCheckBox = new System.Windows.Forms.CheckBox();
            this.FullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.heightDimensionLabel = new System.Windows.Forms.Label();
            this.heightDimensionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.widthDimensionLabel = new System.Windows.Forms.Label();
            this.widthDimensionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DimensionLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SecondsPerDayLabel = new System.Windows.Forms.Label();
            this.SecondsPerDayMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SpeedRealTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeedGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeScaleTrackBar = new System.Windows.Forms.TrackBar();
            this.FileIdleDisplayLabel = new System.Windows.Forms.Label();
            this.FileIdleDisplayMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TimeScaleLabel = new System.Windows.Forms.Label();
            this.TimeScaleMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BloomGroupBox = new System.Windows.Forms.GroupBox();
            this.MultiplierMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MultiplierLabel = new System.Windows.Forms.Label();
            this.IntensityMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IntensityLabel = new System.Windows.Forms.Label();
            this.UseBloomCheckBox = new System.Windows.Forms.CheckBox();
            this.UserImageDirectoryPathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BackgroundImagePathOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefaultUserImagePathOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PathGroupBox.SuspendLayout();
            this.GeneralGroupBox.SuspendLayout();
            this.SpeedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeScaleTrackBar)).BeginInit();
            this.BloomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemNotifyIcon
            // 
            this.SystemNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemNotifyIcon.Icon")));
            this.SystemNotifyIcon.Text = "Gource Win";
            this.SystemNotifyIcon.Visible = true;
            // 
            // GourcePathLabel
            // 
            this.GourcePathLabel.AutoSize = true;
            this.GourcePathLabel.Location = new System.Drawing.Point(8, 16);
            this.GourcePathLabel.Name = "GourcePathLabel";
            this.GourcePathLabel.Size = new System.Drawing.Size(67, 13);
            this.GourcePathLabel.TabIndex = 0;
            this.GourcePathLabel.Text = "Gouce Path:";
            // 
            // GourcePathTextBox
            // 
            this.GourcePathTextBox.Location = new System.Drawing.Point(143, 16);
            this.GourcePathTextBox.Name = "GourcePathTextBox";
            this.GourcePathTextBox.ReadOnly = true;
            this.GourcePathTextBox.Size = new System.Drawing.Size(294, 20);
            this.GourcePathTextBox.TabIndex = 1;
            this.GourcePathTextBox.Click += new System.EventHandler(this.GourcePathTextBox_Click);
            // 
            // GitCmdPathTextBox
            // 
            this.GitCmdPathTextBox.Location = new System.Drawing.Point(143, 42);
            this.GitCmdPathTextBox.Name = "GitCmdPathTextBox";
            this.GitCmdPathTextBox.ReadOnly = true;
            this.GitCmdPathTextBox.Size = new System.Drawing.Size(294, 20);
            this.GitCmdPathTextBox.TabIndex = 2;
            this.GitCmdPathTextBox.Click += new System.EventHandler(this.GitCmdPathTextBox_Click);
            // 
            // GitCmdPathLabel
            // 
            this.GitCmdPathLabel.AutoSize = true;
            this.GitCmdPathLabel.Location = new System.Drawing.Point(8, 42);
            this.GitCmdPathLabel.Name = "GitCmdPathLabel";
            this.GitCmdPathLabel.Size = new System.Drawing.Size(72, 13);
            this.GitCmdPathLabel.TabIndex = 0;
            this.GitCmdPathLabel.Text = "Git Cmd Path:";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(627, 277);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 12;
            this.RunButton.Text = "&Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // GitProjectPathTextBox
            // 
            this.GitProjectPathTextBox.Location = new System.Drawing.Point(143, 68);
            this.GitProjectPathTextBox.Name = "GitProjectPathTextBox";
            this.GitProjectPathTextBox.ReadOnly = true;
            this.GitProjectPathTextBox.Size = new System.Drawing.Size(294, 20);
            this.GitProjectPathTextBox.TabIndex = 3;
            this.GitProjectPathTextBox.Click += new System.EventHandler(this.GitProjectPathTextBox_Click);
            // 
            // GitProjectPathLabel
            // 
            this.GitProjectPathLabel.AutoSize = true;
            this.GitProjectPathLabel.Location = new System.Drawing.Point(8, 68);
            this.GitProjectPathLabel.Name = "GitProjectPathLabel";
            this.GitProjectPathLabel.Size = new System.Drawing.Size(84, 13);
            this.GitProjectPathLabel.TabIndex = 0;
            this.GitProjectPathLabel.Text = "Git Project Path:";
            // 
            // PathGroupBox
            // 
            this.PathGroupBox.Controls.Add(this.DefaultUserImagePathTextBox);
            this.PathGroupBox.Controls.Add(this.DefaultUserImagePathLabel);
            this.PathGroupBox.Controls.Add(this.UserImageDirectoryPathTextBox);
            this.PathGroupBox.Controls.Add(this.UserImageDirectoryPathLabel);
            this.PathGroupBox.Controls.Add(this.BackgroundImagePathTextBox);
            this.PathGroupBox.Controls.Add(this.BackgroundImagePathLabel);
            this.PathGroupBox.Controls.Add(this.GourcePathLabel);
            this.PathGroupBox.Controls.Add(this.GitProjectPathTextBox);
            this.PathGroupBox.Controls.Add(this.GourcePathTextBox);
            this.PathGroupBox.Controls.Add(this.GitProjectPathLabel);
            this.PathGroupBox.Controls.Add(this.GitCmdPathLabel);
            this.PathGroupBox.Controls.Add(this.GitCmdPathTextBox);
            this.PathGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PathGroupBox.Name = "PathGroupBox";
            this.PathGroupBox.Size = new System.Drawing.Size(448, 179);
            this.PathGroupBox.TabIndex = 0;
            this.PathGroupBox.TabStop = false;
            this.PathGroupBox.Text = "Path";
            // 
            // DefaultUserImagePathTextBox
            // 
            this.DefaultUserImagePathTextBox.Location = new System.Drawing.Point(143, 146);
            this.DefaultUserImagePathTextBox.Name = "DefaultUserImagePathTextBox";
            this.DefaultUserImagePathTextBox.ReadOnly = true;
            this.DefaultUserImagePathTextBox.Size = new System.Drawing.Size(294, 20);
            this.DefaultUserImagePathTextBox.TabIndex = 9;
            this.DefaultUserImagePathTextBox.Click += new System.EventHandler(this.DefaultUserImagePathTextBox_Click);
            // 
            // DefaultUserImagePathLabel
            // 
            this.DefaultUserImagePathLabel.AutoSize = true;
            this.DefaultUserImagePathLabel.Location = new System.Drawing.Point(8, 146);
            this.DefaultUserImagePathLabel.Name = "DefaultUserImagePathLabel";
            this.DefaultUserImagePathLabel.Size = new System.Drawing.Size(126, 13);
            this.DefaultUserImagePathLabel.TabIndex = 8;
            this.DefaultUserImagePathLabel.Text = "Default User Image Path:";
            // 
            // UserImageDirectoryPathTextBox
            // 
            this.UserImageDirectoryPathTextBox.Location = new System.Drawing.Point(143, 94);
            this.UserImageDirectoryPathTextBox.Name = "UserImageDirectoryPathTextBox";
            this.UserImageDirectoryPathTextBox.ReadOnly = true;
            this.UserImageDirectoryPathTextBox.Size = new System.Drawing.Size(294, 20);
            this.UserImageDirectoryPathTextBox.TabIndex = 7;
            this.UserImageDirectoryPathTextBox.Click += new System.EventHandler(this.UserImageDirectoryPathTextBox_Click);
            // 
            // UserImageDirectoryPathLabel
            // 
            this.UserImageDirectoryPathLabel.AutoSize = true;
            this.UserImageDirectoryPathLabel.Location = new System.Drawing.Point(8, 94);
            this.UserImageDirectoryPathLabel.Name = "UserImageDirectoryPathLabel";
            this.UserImageDirectoryPathLabel.Size = new System.Drawing.Size(134, 13);
            this.UserImageDirectoryPathLabel.TabIndex = 6;
            this.UserImageDirectoryPathLabel.Text = "User Image Directory Path:";
            // 
            // BackgroundImagePathTextBox
            // 
            this.BackgroundImagePathTextBox.Location = new System.Drawing.Point(143, 120);
            this.BackgroundImagePathTextBox.Name = "BackgroundImagePathTextBox";
            this.BackgroundImagePathTextBox.ReadOnly = true;
            this.BackgroundImagePathTextBox.Size = new System.Drawing.Size(294, 20);
            this.BackgroundImagePathTextBox.TabIndex = 5;
            this.BackgroundImagePathTextBox.Click += new System.EventHandler(this.BackgroundImagePathTextBox_Click);
            // 
            // BackgroundImagePathLabel
            // 
            this.BackgroundImagePathLabel.AutoSize = true;
            this.BackgroundImagePathLabel.Location = new System.Drawing.Point(8, 120);
            this.BackgroundImagePathLabel.Name = "BackgroundImagePathLabel";
            this.BackgroundImagePathLabel.Size = new System.Drawing.Size(125, 13);
            this.BackgroundImagePathLabel.TabIndex = 4;
            this.BackgroundImagePathLabel.Text = "Background Image Path:";
            // 
            // GeneralGroupBox
            // 
            this.GeneralGroupBox.Controls.Add(this.TrackRadioButton);
            this.GeneralGroupBox.Controls.Add(this.OverviewRadioButton);
            this.GeneralGroupBox.Controls.Add(this.CameraModeLabel);
            this.GeneralGroupBox.Controls.Add(this.UseScreenResolutionCheckBox);
            this.GeneralGroupBox.Controls.Add(this.UseTransparencyCheckBox);
            this.GeneralGroupBox.Controls.Add(this.FullScreenCheckBox);
            this.GeneralGroupBox.Controls.Add(this.heightDimensionLabel);
            this.GeneralGroupBox.Controls.Add(this.heightDimensionMaskedTextBox);
            this.GeneralGroupBox.Controls.Add(this.widthDimensionLabel);
            this.GeneralGroupBox.Controls.Add(this.widthDimensionMaskedTextBox);
            this.GeneralGroupBox.Controls.Add(this.DimensionLabel);
            this.GeneralGroupBox.Controls.Add(this.TitleTextBox);
            this.GeneralGroupBox.Controls.Add(this.TitleLabel);
            this.GeneralGroupBox.Location = new System.Drawing.Point(0, 185);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(448, 125);
            this.GeneralGroupBox.TabIndex = 0;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "General";
            // 
            // TrackRadioButton
            // 
            this.TrackRadioButton.AutoSize = true;
            this.TrackRadioButton.Location = new System.Drawing.Point(178, 100);
            this.TrackRadioButton.Name = "TrackRadioButton";
            this.TrackRadioButton.Size = new System.Drawing.Size(53, 17);
            this.TrackRadioButton.TabIndex = 12;
            this.TrackRadioButton.Text = "Track";
            this.TrackRadioButton.UseVisualStyleBackColor = true;
            // 
            // OverviewRadioButton
            // 
            this.OverviewRadioButton.AutoSize = true;
            this.OverviewRadioButton.Checked = true;
            this.OverviewRadioButton.Location = new System.Drawing.Point(102, 100);
            this.OverviewRadioButton.Name = "OverviewRadioButton";
            this.OverviewRadioButton.Size = new System.Drawing.Size(70, 17);
            this.OverviewRadioButton.TabIndex = 11;
            this.OverviewRadioButton.TabStop = true;
            this.OverviewRadioButton.Text = "Overview";
            this.OverviewRadioButton.UseVisualStyleBackColor = true;
            // 
            // CameraModeLabel
            // 
            this.CameraModeLabel.AutoSize = true;
            this.CameraModeLabel.Location = new System.Drawing.Point(12, 102);
            this.CameraModeLabel.Name = "CameraModeLabel";
            this.CameraModeLabel.Size = new System.Drawing.Size(76, 13);
            this.CameraModeLabel.TabIndex = 10;
            this.CameraModeLabel.Text = "Camera Mode:";
            // 
            // UseScreenResolutionCheckBox
            // 
            this.UseScreenResolutionCheckBox.AutoSize = true;
            this.UseScreenResolutionCheckBox.Checked = true;
            this.UseScreenResolutionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseScreenResolutionCheckBox.Location = new System.Drawing.Point(237, 47);
            this.UseScreenResolutionCheckBox.Name = "UseScreenResolutionCheckBox";
            this.UseScreenResolutionCheckBox.Size = new System.Drawing.Size(135, 17);
            this.UseScreenResolutionCheckBox.TabIndex = 7;
            this.UseScreenResolutionCheckBox.Text = "Use Screen Resolution";
            this.UseScreenResolutionCheckBox.UseVisualStyleBackColor = true;
            this.UseScreenResolutionCheckBox.CheckedChanged += new System.EventHandler(this.UseScreenResolutionCheckBox_CheckedChanged);
            // 
            // UseTransparencyCheckBox
            // 
            this.UseTransparencyCheckBox.AutoSize = true;
            this.UseTransparencyCheckBox.Location = new System.Drawing.Point(102, 75);
            this.UseTransparencyCheckBox.Name = "UseTransparencyCheckBox";
            this.UseTransparencyCheckBox.Size = new System.Drawing.Size(113, 17);
            this.UseTransparencyCheckBox.TabIndex = 8;
            this.UseTransparencyCheckBox.Text = "Use Transparency";
            this.UseTransparencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FullScreenCheckBox
            // 
            this.FullScreenCheckBox.AutoSize = true;
            this.FullScreenCheckBox.Location = new System.Drawing.Point(237, 75);
            this.FullScreenCheckBox.Name = "FullScreenCheckBox";
            this.FullScreenCheckBox.Size = new System.Drawing.Size(79, 17);
            this.FullScreenCheckBox.TabIndex = 9;
            this.FullScreenCheckBox.Text = "Full Screen";
            this.FullScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // heightDimensionLabel
            // 
            this.heightDimensionLabel.AutoSize = true;
            this.heightDimensionLabel.Location = new System.Drawing.Point(212, 48);
            this.heightDimensionLabel.Name = "heightDimensionLabel";
            this.heightDimensionLabel.Size = new System.Drawing.Size(13, 13);
            this.heightDimensionLabel.TabIndex = 0;
            this.heightDimensionLabel.Text = "h";
            // 
            // heightDimensionMaskedTextBox
            // 
            this.heightDimensionMaskedTextBox.Location = new System.Drawing.Point(173, 43);
            this.heightDimensionMaskedTextBox.Mask = "9999";
            this.heightDimensionMaskedTextBox.Name = "heightDimensionMaskedTextBox";
            this.heightDimensionMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.heightDimensionMaskedTextBox.TabIndex = 6;
            // 
            // widthDimensionLabel
            // 
            this.widthDimensionLabel.AutoSize = true;
            this.widthDimensionLabel.Location = new System.Drawing.Point(141, 48);
            this.widthDimensionLabel.Name = "widthDimensionLabel";
            this.widthDimensionLabel.Size = new System.Drawing.Size(15, 13);
            this.widthDimensionLabel.TabIndex = 0;
            this.widthDimensionLabel.Text = "w";
            // 
            // widthDimensionMaskedTextBox
            // 
            this.widthDimensionMaskedTextBox.Location = new System.Drawing.Point(102, 43);
            this.widthDimensionMaskedTextBox.Mask = "9999";
            this.widthDimensionMaskedTextBox.Name = "widthDimensionMaskedTextBox";
            this.widthDimensionMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.widthDimensionMaskedTextBox.TabIndex = 5;
            // 
            // DimensionLabel
            // 
            this.DimensionLabel.AutoSize = true;
            this.DimensionLabel.Location = new System.Drawing.Point(12, 46);
            this.DimensionLabel.Name = "DimensionLabel";
            this.DimensionLabel.Size = new System.Drawing.Size(59, 13);
            this.DimensionLabel.TabIndex = 0;
            this.DimensionLabel.Text = "Dimension:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(102, 17);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(335, 20);
            this.TitleTextBox.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // SecondsPerDayLabel
            // 
            this.SecondsPerDayLabel.AutoSize = true;
            this.SecondsPerDayLabel.Location = new System.Drawing.Point(12, 16);
            this.SecondsPerDayLabel.Name = "SecondsPerDayLabel";
            this.SecondsPerDayLabel.Size = new System.Drawing.Size(90, 13);
            this.SecondsPerDayLabel.TabIndex = 0;
            this.SecondsPerDayLabel.Text = "Seconds Per Day";
            // 
            // SecondsPerDayMaskedTextBox
            // 
            this.SecondsPerDayMaskedTextBox.Location = new System.Drawing.Point(102, 13);
            this.SecondsPerDayMaskedTextBox.Mask = "999999";
            this.SecondsPerDayMaskedTextBox.Name = "SecondsPerDayMaskedTextBox";
            this.SecondsPerDayMaskedTextBox.ReadOnly = true;
            this.SecondsPerDayMaskedTextBox.Size = new System.Drawing.Size(49, 20);
            this.SecondsPerDayMaskedTextBox.TabIndex = 10;
            this.SecondsPerDayMaskedTextBox.Text = "0";
            // 
            // SpeedRealTimeCheckBox
            // 
            this.SpeedRealTimeCheckBox.AutoSize = true;
            this.SpeedRealTimeCheckBox.Checked = true;
            this.SpeedRealTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeedRealTimeCheckBox.Location = new System.Drawing.Point(163, 15);
            this.SpeedRealTimeCheckBox.Name = "SpeedRealTimeCheckBox";
            this.SpeedRealTimeCheckBox.Size = new System.Drawing.Size(74, 17);
            this.SpeedRealTimeCheckBox.TabIndex = 11;
            this.SpeedRealTimeCheckBox.Text = "Real Time";
            this.SpeedRealTimeCheckBox.UseVisualStyleBackColor = true;
            this.SpeedRealTimeCheckBox.CheckedChanged += new System.EventHandler(this.SpeedRealTimeCheckBox_CheckedChanged);
            // 
            // SpeedGroupBox
            // 
            this.SpeedGroupBox.Controls.Add(this.TimeScaleTrackBar);
            this.SpeedGroupBox.Controls.Add(this.FileIdleDisplayLabel);
            this.SpeedGroupBox.Controls.Add(this.FileIdleDisplayMaskedTextBox);
            this.SpeedGroupBox.Controls.Add(this.TimeScaleLabel);
            this.SpeedGroupBox.Controls.Add(this.TimeScaleMaskedTextBox);
            this.SpeedGroupBox.Controls.Add(this.SpeedRealTimeCheckBox);
            this.SpeedGroupBox.Controls.Add(this.SecondsPerDayLabel);
            this.SpeedGroupBox.Controls.Add(this.SecondsPerDayMaskedTextBox);
            this.SpeedGroupBox.Location = new System.Drawing.Point(454, 0);
            this.SpeedGroupBox.Name = "SpeedGroupBox";
            this.SpeedGroupBox.Size = new System.Drawing.Size(258, 107);
            this.SpeedGroupBox.TabIndex = 0;
            this.SpeedGroupBox.TabStop = false;
            this.SpeedGroupBox.Text = "Speed";
            // 
            // TimeScaleTrackBar
            // 
            this.TimeScaleTrackBar.Location = new System.Drawing.Point(144, 38);
            this.TimeScaleTrackBar.Maximum = 39;
            this.TimeScaleTrackBar.Minimum = 1;
            this.TimeScaleTrackBar.Name = "TimeScaleTrackBar";
            this.TimeScaleTrackBar.Size = new System.Drawing.Size(104, 45);
            this.TimeScaleTrackBar.TabIndex = 16;
            this.TimeScaleTrackBar.Value = 10;
            this.TimeScaleTrackBar.Scroll += new System.EventHandler(this.TimeScaleTrackBar_Scroll);
            // 
            // FileIdleDisplayLabel
            // 
            this.FileIdleDisplayLabel.AutoSize = true;
            this.FileIdleDisplayLabel.Location = new System.Drawing.Point(12, 71);
            this.FileIdleDisplayLabel.Name = "FileIdleDisplayLabel";
            this.FileIdleDisplayLabel.Size = new System.Drawing.Size(80, 13);
            this.FileIdleDisplayLabel.TabIndex = 14;
            this.FileIdleDisplayLabel.Text = "File Idle Display";
            // 
            // FileIdleDisplayMaskedTextBox
            // 
            this.FileIdleDisplayMaskedTextBox.Location = new System.Drawing.Point(102, 68);
            this.FileIdleDisplayMaskedTextBox.Mask = "9999";
            this.FileIdleDisplayMaskedTextBox.Name = "FileIdleDisplayMaskedTextBox";
            this.FileIdleDisplayMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.FileIdleDisplayMaskedTextBox.TabIndex = 15;
            this.FileIdleDisplayMaskedTextBox.Text = "0";
            // 
            // TimeScaleLabel
            // 
            this.TimeScaleLabel.AutoSize = true;
            this.TimeScaleLabel.Location = new System.Drawing.Point(12, 43);
            this.TimeScaleLabel.Name = "TimeScaleLabel";
            this.TimeScaleLabel.Size = new System.Drawing.Size(60, 13);
            this.TimeScaleLabel.TabIndex = 12;
            this.TimeScaleLabel.Text = "Time Scale";
            // 
            // TimeScaleMaskedTextBox
            // 
            this.TimeScaleMaskedTextBox.Location = new System.Drawing.Point(102, 40);
            this.TimeScaleMaskedTextBox.Mask = "9.9";
            this.TimeScaleMaskedTextBox.Name = "TimeScaleMaskedTextBox";
            this.TimeScaleMaskedTextBox.ReadOnly = true;
            this.TimeScaleMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.TimeScaleMaskedTextBox.TabIndex = 13;
            this.TimeScaleMaskedTextBox.Text = "10";
            // 
            // BloomGroupBox
            // 
            this.BloomGroupBox.Controls.Add(this.MultiplierMaskedTextBox);
            this.BloomGroupBox.Controls.Add(this.MultiplierLabel);
            this.BloomGroupBox.Controls.Add(this.IntensityMaskedTextBox);
            this.BloomGroupBox.Controls.Add(this.IntensityLabel);
            this.BloomGroupBox.Controls.Add(this.UseBloomCheckBox);
            this.BloomGroupBox.Location = new System.Drawing.Point(454, 113);
            this.BloomGroupBox.Name = "BloomGroupBox";
            this.BloomGroupBox.Size = new System.Drawing.Size(258, 100);
            this.BloomGroupBox.TabIndex = 13;
            this.BloomGroupBox.TabStop = false;
            this.BloomGroupBox.Text = "Bloom Efects";
            // 
            // MultiplierMaskedTextBox
            // 
            this.MultiplierMaskedTextBox.Location = new System.Drawing.Point(102, 65);
            this.MultiplierMaskedTextBox.Mask = "9999";
            this.MultiplierMaskedTextBox.Name = "MultiplierMaskedTextBox";
            this.MultiplierMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.MultiplierMaskedTextBox.TabIndex = 18;
            this.MultiplierMaskedTextBox.Text = "1";
            // 
            // MultiplierLabel
            // 
            this.MultiplierLabel.AutoSize = true;
            this.MultiplierLabel.Location = new System.Drawing.Point(12, 68);
            this.MultiplierLabel.Name = "MultiplierLabel";
            this.MultiplierLabel.Size = new System.Drawing.Size(48, 13);
            this.MultiplierLabel.TabIndex = 17;
            this.MultiplierLabel.Text = "Multiplier";
            // 
            // IntensityMaskedTextBox
            // 
            this.IntensityMaskedTextBox.Location = new System.Drawing.Point(102, 39);
            this.IntensityMaskedTextBox.Mask = "9999";
            this.IntensityMaskedTextBox.Name = "IntensityMaskedTextBox";
            this.IntensityMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.IntensityMaskedTextBox.TabIndex = 16;
            this.IntensityMaskedTextBox.Text = "2";
            // 
            // IntensityLabel
            // 
            this.IntensityLabel.AutoSize = true;
            this.IntensityLabel.Location = new System.Drawing.Point(12, 42);
            this.IntensityLabel.Name = "IntensityLabel";
            this.IntensityLabel.Size = new System.Drawing.Size(46, 13);
            this.IntensityLabel.TabIndex = 1;
            this.IntensityLabel.Text = "Intensity";
            // 
            // UseBloomCheckBox
            // 
            this.UseBloomCheckBox.AutoSize = true;
            this.UseBloomCheckBox.Checked = true;
            this.UseBloomCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseBloomCheckBox.Location = new System.Drawing.Point(15, 19);
            this.UseBloomCheckBox.Name = "UseBloomCheckBox";
            this.UseBloomCheckBox.Size = new System.Drawing.Size(105, 17);
            this.UseBloomCheckBox.TabIndex = 0;
            this.UseBloomCheckBox.Text = "Use Bloom Efect";
            this.UseBloomCheckBox.UseVisualStyleBackColor = true;
            this.UseBloomCheckBox.CheckedChanged += new System.EventHandler(this.UseBloomCheckBox_CheckedChanged);
            // 
            // BackgroundImagePathOpenFileDialog
            // 
            this.BackgroundImagePathOpenFileDialog.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";
            // 
            // DefaultUserImagePathOpenFileDialog
            // 
            this.DefaultUserImagePathOpenFileDialog.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 324);
            this.Controls.Add(this.BloomGroupBox);
            this.Controls.Add(this.SpeedGroupBox);
            this.Controls.Add(this.GeneralGroupBox);
            this.Controls.Add(this.PathGroupBox);
            this.Controls.Add(this.RunButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gource Win";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.PathGroupBox.ResumeLayout(false);
            this.PathGroupBox.PerformLayout();
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralGroupBox.PerformLayout();
            this.SpeedGroupBox.ResumeLayout(false);
            this.SpeedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeScaleTrackBar)).EndInit();
            this.BloomGroupBox.ResumeLayout(false);
            this.BloomGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SystemNotifyIcon;
        private System.Windows.Forms.Label GourcePathLabel;
        private System.Windows.Forms.TextBox GourcePathTextBox;
        private System.Windows.Forms.FolderBrowserDialog GourcePathFolderBrowserDialog;
        private System.Windows.Forms.TextBox GitCmdPathTextBox;
        private System.Windows.Forms.Label GitCmdPathLabel;
        private System.Windows.Forms.FolderBrowserDialog GitCmdPathFolderBrowserDialog;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox GitProjectPathTextBox;
        private System.Windows.Forms.Label GitProjectPathLabel;
        private System.Windows.Forms.FolderBrowserDialog GitProjectPathFolderBrowserDialog;
        private System.Windows.Forms.GroupBox PathGroupBox;
        private System.Windows.Forms.GroupBox GeneralGroupBox;
        private System.Windows.Forms.Label SecondsPerDayLabel;
        private System.Windows.Forms.MaskedTextBox SecondsPerDayMaskedTextBox;
        private System.Windows.Forms.CheckBox SpeedRealTimeCheckBox;
        private System.Windows.Forms.GroupBox SpeedGroupBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label DimensionLabel;
        private System.Windows.Forms.MaskedTextBox widthDimensionMaskedTextBox;
        private System.Windows.Forms.Label widthDimensionLabel;
        private System.Windows.Forms.Label heightDimensionLabel;
        private System.Windows.Forms.MaskedTextBox heightDimensionMaskedTextBox;
        private System.Windows.Forms.CheckBox FullScreenCheckBox;
        private System.Windows.Forms.CheckBox UseTransparencyCheckBox;
        private System.Windows.Forms.CheckBox UseScreenResolutionCheckBox;
        private System.Windows.Forms.Label TimeScaleLabel;
        private System.Windows.Forms.MaskedTextBox TimeScaleMaskedTextBox;
        private System.Windows.Forms.Label CameraModeLabel;
        private System.Windows.Forms.RadioButton TrackRadioButton;
        private System.Windows.Forms.RadioButton OverviewRadioButton;
        private System.Windows.Forms.Label FileIdleDisplayLabel;
        private System.Windows.Forms.MaskedTextBox FileIdleDisplayMaskedTextBox;
        private System.Windows.Forms.GroupBox BloomGroupBox;
        private System.Windows.Forms.CheckBox UseBloomCheckBox;
        private System.Windows.Forms.Label IntensityLabel;
        private System.Windows.Forms.MaskedTextBox IntensityMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox MultiplierMaskedTextBox;
        private System.Windows.Forms.Label MultiplierLabel;
        private System.Windows.Forms.TrackBar TimeScaleTrackBar;
        private System.Windows.Forms.TextBox DefaultUserImagePathTextBox;
        private System.Windows.Forms.Label DefaultUserImagePathLabel;
        private System.Windows.Forms.TextBox UserImageDirectoryPathTextBox;
        private System.Windows.Forms.Label UserImageDirectoryPathLabel;
        private System.Windows.Forms.TextBox BackgroundImagePathTextBox;
        private System.Windows.Forms.Label BackgroundImagePathLabel;
        private System.Windows.Forms.FolderBrowserDialog UserImageDirectoryPathFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog BackgroundImagePathOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog DefaultUserImagePathOpenFileDialog;
    }
}

