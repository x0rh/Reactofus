namespace Reactofus
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRamDisk = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAvailableDevices = new System.Windows.Forms.ComboBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.cbPause = new System.Windows.Forms.CheckBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.linkLabelBug = new System.Windows.Forms.LinkLabel();
            this.linkLabelUpdateDevices = new System.Windows.Forms.LinkLabel();
            this.cbFormatDrive = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tbRamDiskISOPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseISORamDisk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRamDisk.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageRamDisk);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 84);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRamDisk
            // 
            this.tabPageRamDisk.Controls.Add(this.btnBrowseISORamDisk);
            this.tabPageRamDisk.Controls.Add(this.label2);
            this.tabPageRamDisk.Controls.Add(this.tbRamDiskISOPath);
            this.tabPageRamDisk.Location = new System.Drawing.Point(4, 22);
            this.tabPageRamDisk.Name = "tabPageRamDisk";
            this.tabPageRamDisk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRamDisk.Size = new System.Drawing.Size(405, 58);
            this.tabPageRamDisk.TabIndex = 0;
            this.tabPageRamDisk.Text = "RamDisk ISO";
            this.tabPageRamDisk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(160, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reactofus Logo Here";
            // 
            // cbAvailableDevices
            // 
            this.cbAvailableDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAvailableDevices.FormattingEnabled = true;
            this.cbAvailableDevices.Location = new System.Drawing.Point(12, 45);
            this.cbAvailableDevices.Name = "cbAvailableDevices";
            this.cbAvailableDevices.Size = new System.Drawing.Size(365, 21);
            this.cbAvailableDevices.TabIndex = 1;
            this.cbAvailableDevices.Text = "Choose USB device";
            this.cbAvailableDevices.SelectedIndexChanged += new System.EventHandler(this.cbAvailableDevices_SelectedIndexChanged);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(346, 158);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Start (stop)";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // cbPause
            // 
            this.cbPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPause.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPause.Location = new System.Drawing.Point(310, 158);
            this.cbPause.Name = "cbPause";
            this.cbPause.Size = new System.Drawing.Size(30, 23);
            this.cbPause.TabIndex = 4;
            this.cbPause.Text = "| |";
            this.cbPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPause.UseVisualStyleBackColor = true;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(385, 9);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkLabelGitHub.TabIndex = 5;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "GitHub";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // linkLabelBug
            // 
            this.linkLabelBug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelBug.AutoSize = true;
            this.linkLabelBug.Location = new System.Drawing.Point(393, 26);
            this.linkLabelBug.Name = "linkLabelBug";
            this.linkLabelBug.Size = new System.Drawing.Size(32, 13);
            this.linkLabelBug.TabIndex = 6;
            this.linkLabelBug.TabStop = true;
            this.linkLabelBug.Text = "Bug?";
            this.linkLabelBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBug_LinkClicked);
            // 
            // linkLabelUpdateDevices
            // 
            this.linkLabelUpdateDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelUpdateDevices.AutoSize = true;
            this.linkLabelUpdateDevices.Location = new System.Drawing.Point(383, 48);
            this.linkLabelUpdateDevices.Name = "linkLabelUpdateDevices";
            this.linkLabelUpdateDevices.Size = new System.Drawing.Size(42, 13);
            this.linkLabelUpdateDevices.TabIndex = 7;
            this.linkLabelUpdateDevices.TabStop = true;
            this.linkLabelUpdateDevices.Text = "Update";
            this.linkLabelUpdateDevices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdateDevices_LinkClicked);
            // 
            // cbFormatDrive
            // 
            this.cbFormatDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFormatDrive.AutoSize = true;
            this.cbFormatDrive.Location = new System.Drawing.Point(218, 162);
            this.cbFormatDrive.Name = "cbFormatDrive";
            this.cbFormatDrive.Size = new System.Drawing.Size(86, 17);
            this.cbFormatDrive.TabIndex = 8;
            this.cbFormatDrive.Text = "Format Drive";
            this.cbFormatDrive.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbStatus,
            this.statusProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(437, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbStatus
            // 
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(320, 17);
            this.tbStatus.Spring = true;
            this.tbStatus.Text = "Ready";
            this.tbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(145, 16);
            this.statusProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tbRamDiskISOPath
            // 
            this.tbRamDiskISOPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRamDiskISOPath.Location = new System.Drawing.Point(6, 27);
            this.tbRamDiskISOPath.Name = "tbRamDiskISOPath";
            this.tbRamDiskISOPath.Size = new System.Drawing.Size(355, 20);
            this.tbRamDiskISOPath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ReactOS ISO Path (livecd/bootcd):";
            // 
            // btnBrowseISORamDisk
            // 
            this.btnBrowseISORamDisk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseISORamDisk.Location = new System.Drawing.Point(367, 25);
            this.btnBrowseISORamDisk.Name = "btnBrowseISORamDisk";
            this.btnBrowseISORamDisk.Size = new System.Drawing.Size(32, 23);
            this.btnBrowseISORamDisk.TabIndex = 2;
            this.btnBrowseISORamDisk.Text = "...";
            this.btnBrowseISORamDisk.UseVisualStyleBackColor = true;
            this.btnBrowseISORamDisk.Click += new System.EventHandler(this.btnBrowseISORamDisk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 206);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbFormatDrive);
            this.Controls.Add(this.linkLabelUpdateDevices);
            this.Controls.Add(this.linkLabelBug);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.cbPause);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.cbAvailableDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reactofus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRamDisk.ResumeLayout(false);
            this.tabPageRamDisk.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRamDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAvailableDevices;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.CheckBox cbPause;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.LinkLabel linkLabelBug;
        private System.Windows.Forms.LinkLabel linkLabelUpdateDevices;
        private System.Windows.Forms.CheckBox cbFormatDrive;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tbStatus;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.Button btnBrowseISORamDisk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRamDiskISOPath;
    }
}

