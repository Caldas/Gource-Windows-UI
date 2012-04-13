using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MineSolutions.GourceUI.Properties;
using MineSolutions.Library.CommandLibrary;

namespace MineSolutions.GourceUI
{
    public partial class MainForm : Form
    {
        #region [ Constructors ]

        public MainForm()
        {
            InitializeComponent();
            ReloadSettings();
        }

        #endregion

        #region [ Form and Controls Events Methods ]

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SpeedRealTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SecondsPerDayMaskedTextBox.Enabled = !SpeedRealTimeCheckBox.Checked;
        }

        private void UseScreenResolutionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            widthDimensionMaskedTextBox.ReadOnly = UseScreenResolutionCheckBox.Checked;
            heightDimensionMaskedTextBox.ReadOnly = UseScreenResolutionCheckBox.Checked;
            if (UseScreenResolutionCheckBox.Checked) 
            {
                widthDimensionMaskedTextBox.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
                heightDimensionMaskedTextBox.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
            }
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
        }

        private void SaveSettings()
        {
            Settings.Default.GourcePathSetting = GourcePathTextBox.Text;
            Settings.Default.GitCmdPathSetting = GitCmdPathTextBox.Text;
            Settings.Default.GitProjectPathSetting = GitProjectPathTextBox.Text;

            Settings.Default.Save();
        }

        #endregion

        #region [ Path Methods ]

        private void GourcePathTextBox_Click(object sender, EventArgs e)
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

        private void GitCmdPathTextBox_Click(object sender, EventArgs e)
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

        private void GitProjectPathTextBox_Click(object sender, EventArgs e)
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

        #endregion

        #region [ Action Methods ]

        private void RunButton_Click(object sender, EventArgs e)
        {
            List<String> commands = new List<String>();
            commands.Add(@"cd " + Settings.Default.GitProjectPathSetting);
            commands.Add(@"""" + Settings.Default.GitCmdPathSetting + @"\git.cmd"" log --pretty=format:user:%aN%n%ct --reverse --raw --encoding=UTF-8 --no-renames > " + Settings.Default.GourcePathSetting + @"\log.log");
            commands.Add(@"cd " + Settings.Default.GourcePathSetting);
            commands.Add("gource.exe log.log " + GetSpeedArgument() + " --bloom-multiplier 0.5 --bloom-intensity 2 " + GetDisplayArgument() + GetTitleArgument());
            Command.Execute(commands);
        }

        #endregion

        #region [ Get Argument Methods ]

        private String GetSpeedArgument() 
        {
            if (SpeedRealTimeCheckBox.Checked)
                return "--realtime";
            else
                return "-s " + SecondsPerDayMaskedTextBox.Text;
        }

        private String GetTitleArgument()
        {
            if (!String.IsNullOrWhiteSpace(TitleTextBox.Text))
                return "--title \""+TitleTextBox.Text+"\"";

            return String.Empty;
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

        #endregion
    }
}