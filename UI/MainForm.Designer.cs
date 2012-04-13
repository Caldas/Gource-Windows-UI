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
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.SecondsPerDayLabel = new System.Windows.Forms.Label();
            this.SecondsPerDayMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SpeedRealTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeedGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DimensionLabel = new System.Windows.Forms.Label();
            this.widthDimensionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.widthDimensionLabel = new System.Windows.Forms.Label();
            this.heightDimensionLabel = new System.Windows.Forms.Label();
            this.heightDimensionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.UseTransparencyCheckBox = new System.Windows.Forms.CheckBox();
            this.UseScreenResolutionCheckBox = new System.Windows.Forms.CheckBox();
            this.PathGroupBox.SuspendLayout();
            this.GeneralGroupBox.SuspendLayout();
            this.SpeedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemNotifyIcon
            // 
            this.SystemNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemNotifyIcon.Icon")));
            this.SystemNotifyIcon.Text = "notifyIcon1";
            this.SystemNotifyIcon.Visible = true;
            // 
            // GourcePathLabel
            // 
            this.GourcePathLabel.AutoSize = true;
            this.GourcePathLabel.Location = new System.Drawing.Point(12, 16);
            this.GourcePathLabel.Name = "GourcePathLabel";
            this.GourcePathLabel.Size = new System.Drawing.Size(67, 13);
            this.GourcePathLabel.TabIndex = 0;
            this.GourcePathLabel.Text = "Gouce Path:";
            // 
            // GourcePathTextBox
            // 
            this.GourcePathTextBox.Location = new System.Drawing.Point(102, 16);
            this.GourcePathTextBox.Name = "GourcePathTextBox";
            this.GourcePathTextBox.ReadOnly = true;
            this.GourcePathTextBox.Size = new System.Drawing.Size(335, 20);
            this.GourcePathTextBox.TabIndex = 1;
            this.GourcePathTextBox.Click += new System.EventHandler(this.GourcePathTextBox_Click);
            // 
            // GitCmdPathTextBox
            // 
            this.GitCmdPathTextBox.Location = new System.Drawing.Point(102, 42);
            this.GitCmdPathTextBox.Name = "GitCmdPathTextBox";
            this.GitCmdPathTextBox.ReadOnly = true;
            this.GitCmdPathTextBox.Size = new System.Drawing.Size(335, 20);
            this.GitCmdPathTextBox.TabIndex = 2;
            this.GitCmdPathTextBox.Click += new System.EventHandler(this.GitCmdPathTextBox_Click);
            // 
            // GitCmdPathLabel
            // 
            this.GitCmdPathLabel.AutoSize = true;
            this.GitCmdPathLabel.Location = new System.Drawing.Point(12, 42);
            this.GitCmdPathLabel.Name = "GitCmdPathLabel";
            this.GitCmdPathLabel.Size = new System.Drawing.Size(72, 13);
            this.GitCmdPathLabel.TabIndex = 0;
            this.GitCmdPathLabel.Text = "Git Cmd Path:";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(361, 268);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 12;
            this.RunButton.Text = "&Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // GitProjectPathTextBox
            // 
            this.GitProjectPathTextBox.Location = new System.Drawing.Point(102, 68);
            this.GitProjectPathTextBox.Name = "GitProjectPathTextBox";
            this.GitProjectPathTextBox.ReadOnly = true;
            this.GitProjectPathTextBox.Size = new System.Drawing.Size(335, 20);
            this.GitProjectPathTextBox.TabIndex = 3;
            this.GitProjectPathTextBox.Click += new System.EventHandler(this.GitProjectPathTextBox_Click);
            // 
            // GitProjectPathLabel
            // 
            this.GitProjectPathLabel.AutoSize = true;
            this.GitProjectPathLabel.Location = new System.Drawing.Point(12, 68);
            this.GitProjectPathLabel.Name = "GitProjectPathLabel";
            this.GitProjectPathLabel.Size = new System.Drawing.Size(84, 13);
            this.GitProjectPathLabel.TabIndex = 0;
            this.GitProjectPathLabel.Text = "Git Project Path:";
            // 
            // PathGroupBox
            // 
            this.PathGroupBox.Controls.Add(this.GourcePathLabel);
            this.PathGroupBox.Controls.Add(this.GitProjectPathTextBox);
            this.PathGroupBox.Controls.Add(this.GourcePathTextBox);
            this.PathGroupBox.Controls.Add(this.GitProjectPathLabel);
            this.PathGroupBox.Controls.Add(this.GitCmdPathLabel);
            this.PathGroupBox.Controls.Add(this.GitCmdPathTextBox);
            this.PathGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PathGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PathGroupBox.Name = "PathGroupBox";
            this.PathGroupBox.Size = new System.Drawing.Size(448, 102);
            this.PathGroupBox.TabIndex = 0;
            this.PathGroupBox.TabStop = false;
            this.PathGroupBox.Text = "Path";
            // 
            // GeneralGroupBox
            // 
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
            this.GeneralGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralGroupBox.Location = new System.Drawing.Point(0, 102);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(448, 114);
            this.GeneralGroupBox.TabIndex = 0;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "General";
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
            this.SecondsPerDayMaskedTextBox.Size = new System.Drawing.Size(49, 20);
            this.SecondsPerDayMaskedTextBox.TabIndex = 10;
            // 
            // SpeedRealTimeCheckBox
            // 
            this.SpeedRealTimeCheckBox.AutoSize = true;
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
            this.SpeedGroupBox.Controls.Add(this.SpeedRealTimeCheckBox);
            this.SpeedGroupBox.Controls.Add(this.SecondsPerDayLabel);
            this.SpeedGroupBox.Controls.Add(this.SecondsPerDayMaskedTextBox);
            this.SpeedGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpeedGroupBox.Location = new System.Drawing.Point(0, 216);
            this.SpeedGroupBox.Name = "SpeedGroupBox";
            this.SpeedGroupBox.Size = new System.Drawing.Size(448, 46);
            this.SpeedGroupBox.TabIndex = 0;
            this.SpeedGroupBox.TabStop = false;
            this.SpeedGroupBox.Text = "Speed";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(15, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(102, 17);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(335, 20);
            this.TitleTextBox.TabIndex = 4;
            // 
            // DimensionLabel
            // 
            this.DimensionLabel.AutoSize = true;
            this.DimensionLabel.Location = new System.Drawing.Point(15, 46);
            this.DimensionLabel.Name = "DimensionLabel";
            this.DimensionLabel.Size = new System.Drawing.Size(59, 13);
            this.DimensionLabel.TabIndex = 0;
            this.DimensionLabel.Text = "Dimension:";
            // 
            // widthDimensionMaskedTextBox
            // 
            this.widthDimensionMaskedTextBox.Location = new System.Drawing.Point(102, 43);
            this.widthDimensionMaskedTextBox.Mask = "9999";
            this.widthDimensionMaskedTextBox.Name = "widthDimensionMaskedTextBox";
            this.widthDimensionMaskedTextBox.Size = new System.Drawing.Size(36, 20);
            this.widthDimensionMaskedTextBox.TabIndex = 5;
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
            // UseScreenResolutionCheckBox
            // 
            this.UseScreenResolutionCheckBox.AutoSize = true;
            this.UseScreenResolutionCheckBox.Location = new System.Drawing.Point(237, 47);
            this.UseScreenResolutionCheckBox.Name = "UseScreenResolutionCheckBox";
            this.UseScreenResolutionCheckBox.Size = new System.Drawing.Size(135, 17);
            this.UseScreenResolutionCheckBox.TabIndex = 7;
            this.UseScreenResolutionCheckBox.Text = "Use Screen Resolution";
            this.UseScreenResolutionCheckBox.UseVisualStyleBackColor = true;
            this.UseScreenResolutionCheckBox.CheckedChanged += new System.EventHandler(this.UseScreenResolutionCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 302);
            this.Controls.Add(this.SpeedGroupBox);
            this.Controls.Add(this.GeneralGroupBox);
            this.Controls.Add(this.PathGroupBox);
            this.Controls.Add(this.RunButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Gource Win";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.PathGroupBox.ResumeLayout(false);
            this.PathGroupBox.PerformLayout();
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralGroupBox.PerformLayout();
            this.SpeedGroupBox.ResumeLayout(false);
            this.SpeedGroupBox.PerformLayout();
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
    }
}

