// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="VTEX OnLine Applications">
//     Copyright (c) VTEX OnLine Applications. All rights reserved.
// </copyright>
// <author>Fábio Caldas</author>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GourceUI.Properties;
using CommandLibrary;

namespace GourceUI
{
    /*
    -p, --start-position POSITION
            Begin at some position in the log (between 0.0 and 1.0 or 'random').

        --stop-position  POSITION
            Stop (exit) at some position in the log (does not work with STDIN).

    -t, --stop-at-time SECONDS
            Stop (exit) after a specified number of seconds.

        --stop-at-end
            Stop (exit) at the end of the log / stream.

        --loop
            Loop back to the start of the log when the end is reached.

    -a, --auto-skip-seconds SECONDS
            Skip to next entry if nothing happens for a number of seconds.

    -e, --elasticity FLOAT
            Elasticity of nodes.

    -b, --background-colour FFFFFF
            Background colour in hex.

    --logo IMAGE
            Logo to display in the foreground.

    --logo-offset XxY
            Offset position of the logo.

    --font-size SIZE
            Font size used by the date and title.

    --font-colour FFFFFF
            Font colour used by the date and title in hex.

    --key
            Show file extension key.

    --date-format FORMAT
            Specify display date string (strftime format).

    --log-command VCS
            Show the VCS log command used by gource (git,svn,hg,bzr,cvs2cl).

    --log-format VCS
            Specify the log format (git,svn,hg,bzr,cvs2cl,custom).

            Required when reading from STDIN.

    --git-branch
            Get the git log of a branch other than the current one.

    --follow-user USER
            Have the camera automatically follow a particular user.

    --highlight-dirs
            Highlight the names of all directories.

    --highlight-user USER
            Highlight the names of a particular user.

    --highlight-users
            Highlight the names of all users.

    --highlight-colour FFFFFF
            Font colour for highlighted users in hex.
    
    --selection-colour FFFFFF
            Font colour for selected users and files.

    --dir-colour FFFFFF
            Font colour for directories.

    --file-filter REGEX
            Filter out any files matching a specified regular expression.

    --file-extensions
            Show filename extensions only.

    --user-filter REGEX
            Filter out any users matching a specified regular expression.

    --colour-images
            Colourize user images.

    --crop AXIS
            Crop view on an axis (vertical,horizontal).

    --padding FLOAT
            Camera view padding.

    --multi-sampling
            Enable multi-sampling.

    --no-vsync
            Disable vsync.

    --max-files
            Set the maximum number of files or 0 for no limit.

            Excess files will be discarded.

    --max-file-lag SECONDS
            Max time files of a commit can take to appear.

            Use -1 for no limit.

    --max-user-speed UNITS
            Max speed users can travel per second.

    --user-friction SECONDS
            Time users take to come to a halt.

    --user-scale SCALE
            Change scale of users.

    --disable-auto-rotate
            Disable automatic camera rotation.

    --hide DISPLAY_ELEMENT
            Hide one or more display elements from the list below:

            bloom     - bloom effect
            date      - current date
            dirnames  - names of directories
            files     - file icons
            filenames - names of files
            mouse     - mouse cursor
            progress  - progress bar widget
            root      - root directory of tree
            tree      - animated tree structure
            users     - user avatars
            usernames - names of users

            Separate multiple elements with commas (eg 'mouse,progress')

    --hash-seed SEED
            Change the seed of hash function.

    -o, --output-ppm-stream FILE
            Output a PPM image stream to a file ('-' for STDOUT).

            This will automatically hide the progress bar initially and
            enable 'stop-at-end' unless other behaviour is specified.

    -r, --output-framerate FPS
            Framerate of output (25,30,60). Used with --output-ppm-stream.

    --output-custom-log FILE
            Output a custom format log file ('-' for STDOUT).

    --load-config CONFIG_FILE
            Load a gource conf file.

    --save-config CONFIG_FILE
            Save a gource conf file with the current options.
    */
    public partial class MainForm : Form
    {
        #region [ Constructors ]

        public MainForm()
        {
            InitializeComponent();
            ReloadSettings();
            UseScreenResolutionCheckBox_CheckedChanged(null, EventArgs.Empty);
        }

        #endregion

        #region [ Form and Controls Events Methods ]

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SpeedRealTimeCheckBox_CheckedChanged(Object sender, EventArgs e)
        {
            SecondsPerDayMaskedTextBox.Enabled = !SpeedRealTimeCheckBox.Checked;
        }

        private void UseScreenResolutionCheckBox_CheckedChanged(Object sender, EventArgs e)
        {
            widthDimensionMaskedTextBox.ReadOnly = UseScreenResolutionCheckBox.Checked;
            heightDimensionMaskedTextBox.ReadOnly = UseScreenResolutionCheckBox.Checked;
            if (UseScreenResolutionCheckBox.Checked) 
            {
                widthDimensionMaskedTextBox.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
                heightDimensionMaskedTextBox.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
            }
        }

        private void UseBloomCheckBox_CheckedChanged(Object sender, EventArgs e)
        {
            IntensityMaskedTextBox.Enabled = UseBloomCheckBox.Checked;
            MultiplierMaskedTextBox.Enabled = UseBloomCheckBox.Checked;

            if (UseBloomCheckBox.Checked)
            { 
                IntensityMaskedTextBox.Text = String.Empty;
                MultiplierMaskedTextBox.Text = String.Empty;
            }
        }

        private void TimeScaleTrackBar_Scroll(Object sender, EventArgs e)
        {
            Decimal decimalTimeScale = (Decimal)TimeScaleTrackBar.Value / 10;
            TimeScaleMaskedTextBox.Text = decimalTimeScale.ToString().Replace(",", ".").PadRight(3, '0');
        }

        #endregion

        #region [ Settings Methods ]

        private void ReloadSettings()
        {
            GourcePathTextBox.Text = Settings.Default.GourcePathSetting;
            GourcePathFolderBrowserDialog.SelectedPath = Settings.Default.GourcePathSetting;

            GitCmdPathTextBox.Text = Settings.Default.GitCmdPathSetting;
            GitCmdPathFolderBrowserDialog.SelectedPath = Settings.Default.GitCmdPathSetting;

            GitProjectPathTextBox.Text = Settings.Default.GitProjectPathSetting;
            GitProjectPathFolderBrowserDialog.SelectedPath = Settings.Default.GitProjectPathSetting;

            UserImageDirectoryPathTextBox.Text = Settings.Default.UserImageDirectoryPathSetting;
            UserImageDirectoryPathFolderBrowserDialog.SelectedPath = Settings.Default.UserImageDirectoryPathSetting;

            BackgroundImagePathTextBox.Text = Settings.Default.BackgroundImagePathSetting;
            BackgroundImagePathOpenFileDialog.FileName = Settings.Default.BackgroundImagePathSetting;

            DefaultUserImagePathTextBox.Text = Settings.Default.DefaultUserImagePathSetting;
            DefaultUserImagePathOpenFileDialog.FileName = Settings.Default.DefaultUserImagePathSetting;
        }

        private void SaveSettings()
        {
            Settings.Default.GourcePathSetting = GourcePathTextBox.Text;
            Settings.Default.GitCmdPathSetting = GitCmdPathTextBox.Text;
            Settings.Default.GitProjectPathSetting = GitProjectPathTextBox.Text;
            Settings.Default.UserImageDirectoryPathSetting = UserImageDirectoryPathTextBox.Text;
            Settings.Default.BackgroundImagePathSetting = BackgroundImagePathTextBox.Text;
            Settings.Default.DefaultUserImagePathSetting = DefaultUserImagePathTextBox.Text;
            Settings.Default.Save();
        }

        #endregion

        #region [ Path Methods ]

        private void GourcePathTextBox_Click(Object sender, EventArgs e)
        {
            GourcePathFolderBrowserDialog.ShowDialog();
            if (String.IsNullOrWhiteSpace(GourcePathFolderBrowserDialog.SelectedPath))
            {
                MessageBox.Show("You must select a gource folder path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GourcePathTextBox.Text = GourcePathFolderBrowserDialog.SelectedPath;
            SaveSettings();
        }

        private void GitCmdPathTextBox_Click(Object sender, EventArgs e)
        {
            GitCmdPathFolderBrowserDialog.ShowDialog();
            if (String.IsNullOrWhiteSpace(GitCmdPathFolderBrowserDialog.SelectedPath))
            {
                MessageBox.Show("You must select a git cmd folder path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GitCmdPathTextBox.Text = GitCmdPathFolderBrowserDialog.SelectedPath;
            SaveSettings();
        }

        private void GitProjectPathTextBox_Click(Object sender, EventArgs e)
        {
            GitProjectPathFolderBrowserDialog.ShowDialog();
            if (String.IsNullOrWhiteSpace(GitProjectPathFolderBrowserDialog.SelectedPath))
            {
                MessageBox.Show("You must select a git project folder path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GitProjectPathTextBox.Text = GitProjectPathFolderBrowserDialog.SelectedPath;
            SaveSettings();
        }

        private void UserImageDirectoryPathTextBox_Click(object sender, EventArgs e)
        {
            UserImageDirectoryPathFolderBrowserDialog.ShowDialog();
            UserImageDirectoryPathTextBox.Text = UserImageDirectoryPathFolderBrowserDialog.SelectedPath;
            SaveSettings();
        }

        private void BackgroundImagePathTextBox_Click(object sender, EventArgs e)
        {
            BackgroundImagePathOpenFileDialog.ShowDialog();
            BackgroundImagePathTextBox.Text = BackgroundImagePathOpenFileDialog.FileName;
            SaveSettings();
        }

        private void DefaultUserImagePathTextBox_Click(object sender, EventArgs e)
        {
            DefaultUserImagePathOpenFileDialog.ShowDialog();
            DefaultUserImagePathTextBox.Text = DefaultUserImagePathOpenFileDialog.FileName;
            SaveSettings();
        }

        #endregion

        #region [ Action Methods ]

        private void RunButton_Click(Object sender, EventArgs e)
        {
            List<String> commands = new List<String>();
            commands.Add(@"cd " + Settings.Default.GitProjectPathSetting);
            commands.Add(@"""" + Settings.Default.GitCmdPathSetting + @"\git.cmd"" log --pretty=format:user:%aN%n%ct --reverse --raw --encoding=UTF-8 --no-renames > " + Settings.Default.GourcePathSetting + @"\log.log");
            commands.Add(@"cd " + Settings.Default.GourcePathSetting);
            commands.Add("gource.exe " + GetPath() + GetBloomArgument() + GetCameraModeArgument() + GetDisplayArgument() + GetFileIdleTimeArgument() + GetSpeedArgument() + GetTitleArgument() + GetTimeScale());
            Command.Execute(commands);
        }

        #endregion

        #region [ Get Argument Methods ]

        private String GetBloomArgument() 
        {
            if (UseBloomCheckBox.Checked)
                return "--bloom-multiplier " + MultiplierMaskedTextBox.Text + " --bloom-intensity " + IntensityMaskedTextBox.Text + " ";
            else
                return "--disable-bloom ";
        }

        private String GetCameraModeArgument() 
        {
            if (OverviewRadioButton.Checked)
                return "--camera-mode overview ";
            else
                return "--camera-mode track ";
        }

        private String GetDisplayArgument()
        {
            String displayArgument = String.Empty;

            if (FullScreenCheckBox.Checked)
                displayArgument += "-f ";
            else
                displayArgument += "-w ";

            if (!String.IsNullOrWhiteSpace(widthDimensionMaskedTextBox.Text) && !String.IsNullOrWhiteSpace(heightDimensionMaskedTextBox.Text))
                displayArgument += String.Format("--viewport {0}x{1} ", widthDimensionMaskedTextBox.Text, heightDimensionMaskedTextBox.Text);

            if (UseTransparencyCheckBox.Checked)
                displayArgument += "--transparent ";

            return displayArgument;
        }

        private String GetFileIdleTimeArgument() 
        {
            if (!String.IsNullOrWhiteSpace(FileIdleDisplayMaskedTextBox.Text))
                return "--file-idle-time " + FileIdleDisplayMaskedTextBox.Text + " ";

            return "--file-idle-time 0 ";
        }

        private String GetPath() 
        {
            //TODO: Improve Path
            /*  --path PATH
                path    Either a supported version control directory, a pre-generated log
                file (see log commands or the custom log format), a Gource conf
                file or '-' to read STDIN.

                If path is omitted, gource will attempt to read a log from the  current directory.
             * 
            */
            return "log.log ";
        }

        private String GetSpeedArgument() 
        {
            if (SpeedRealTimeCheckBox.Checked)
                return "--realtime ";
            else
                return "-s " + SecondsPerDayMaskedTextBox.Text + " ";
        }

        private String GetTitleArgument()
        {
            if (!String.IsNullOrWhiteSpace(TitleTextBox.Text))
                return "--title \""+TitleTextBox.Text+"\" ";

            return String.Empty;
        }

        private String GetTimeScale() 
        {
            if (!String.IsNullOrWhiteSpace(TimeScaleMaskedTextBox.Text))
                return "-c " + TimeScaleMaskedTextBox.Text.Replace(",", ".") + " ";

            return "-c 1 ";
        }

        #endregion
    }
}