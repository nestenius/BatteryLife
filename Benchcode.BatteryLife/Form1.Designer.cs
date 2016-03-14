namespace Benchcode.BatteryLife
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPowerLevel = new System.Windows.Forms.Label();
            this.lblPowerLevelVal = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.prbPowerLevel = new System.Windows.Forms.ProgressBar();
            this.lblMinPower = new System.Windows.Forms.Label();
            this.dudMinPower = new System.Windows.Forms.DomainUpDown();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.chkFullBatteryNotification = new System.Windows.Forms.CheckBox();
            this.lblMinPowerTitle = new System.Windows.Forms.Label();
            this.cmbMinPower = new System.Windows.Forms.ComboBox();
            this.lblMaxPowerTitle = new System.Windows.Forms.Label();
            this.cmbMaxPower = new System.Windows.Forms.ComboBox();
            this.lblSoundTitle = new System.Windows.Forms.Label();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.btnBrowseSound = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStopSound = new System.Windows.Forms.Button();
            this.btnPlaySound = new System.Windows.Forms.Button();
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.llblPoweredBy = new System.Windows.Forms.LinkLabel();
            this.lblPercent = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPowerLevel
            // 
            this.lblPowerLevel.AutoSize = true;
            this.lblPowerLevel.Location = new System.Drawing.Point(12, 9);
            this.lblPowerLevel.Name = "lblPowerLevel";
            this.lblPowerLevel.Size = new System.Drawing.Size(66, 13);
            this.lblPowerLevel.TabIndex = 0;
            this.lblPowerLevel.Text = "Power Level";
            // 
            // lblPowerLevelVal
            // 
            this.lblPowerLevelVal.AutoSize = true;
            this.lblPowerLevelVal.Location = new System.Drawing.Point(84, 9);
            this.lblPowerLevelVal.Name = "lblPowerLevelVal";
            this.lblPowerLevelVal.Size = new System.Drawing.Size(0, 13);
            this.lblPowerLevelVal.TabIndex = 1;
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(137, 9);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(0, 13);
            this.lblTimeRemaining.TabIndex = 2;
            // 
            // prbPowerLevel
            // 
            this.prbPowerLevel.Location = new System.Drawing.Point(15, 37);
            this.prbPowerLevel.Name = "prbPowerLevel";
            this.prbPowerLevel.Size = new System.Drawing.Size(328, 23);
            this.prbPowerLevel.TabIndex = 3;
            // 
            // lblMinPower
            // 
            this.lblMinPower.AutoSize = true;
            this.lblMinPower.Location = new System.Drawing.Point(145, 99);
            this.lblMinPower.Name = "lblMinPower";
            this.lblMinPower.Size = new System.Drawing.Size(137, 13);
            this.lblMinPower.TabIndex = 4;
            this.lblMinPower.Text = " when power level drops to ";
            // 
            // dudMinPower
            // 
            this.dudMinPower.Location = new System.Drawing.Point(283, 92);
            this.dudMinPower.Name = "dudMinPower";
            this.dudMinPower.Size = new System.Drawing.Size(40, 20);
            this.dudMinPower.TabIndex = 6;
            this.dudMinPower.TextChanged += new System.EventHandler(this.dudMinPowerLevel_TextChanged);
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Location = new System.Drawing.Point(145, 149);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(157, 13);
            this.lblMaxPower.TabIndex = 7;
            this.lblMaxPower.Text = "when my battery is fully charged";
            // 
            // chkFullBatteryNotification
            // 
            this.chkFullBatteryNotification.AutoSize = true;
            this.chkFullBatteryNotification.Location = new System.Drawing.Point(308, 149);
            this.chkFullBatteryNotification.Name = "chkFullBatteryNotification";
            this.chkFullBatteryNotification.Size = new System.Drawing.Size(15, 14);
            this.chkFullBatteryNotification.TabIndex = 8;
            this.chkFullBatteryNotification.UseVisualStyleBackColor = true;
            this.chkFullBatteryNotification.CheckedChanged += new System.EventHandler(this.chkFullBatteryNotification_CheckedChanged);
            // 
            // lblMinPowerTitle
            // 
            this.lblMinPowerTitle.AutoSize = true;
            this.lblMinPowerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPowerTitle.Location = new System.Drawing.Point(15, 72);
            this.lblMinPowerTitle.Name = "lblMinPowerTitle";
            this.lblMinPowerTitle.Size = new System.Drawing.Size(173, 13);
            this.lblMinPowerTitle.TabIndex = 9;
            this.lblMinPowerTitle.Text = "Minimum Power Level Setting";
            // 
            // cmbMinPower
            // 
            this.cmbMinPower.FormattingEnabled = true;
            this.cmbMinPower.Items.AddRange(new object[] {
            "Text Notification",
            "Sound Notification",
            "Both"});
            this.cmbMinPower.Location = new System.Drawing.Point(18, 91);
            this.cmbMinPower.Name = "cmbMinPower";
            this.cmbMinPower.Size = new System.Drawing.Size(121, 21);
            this.cmbMinPower.TabIndex = 10;
            this.cmbMinPower.SelectedIndexChanged += new System.EventHandler(this.cmbMinPower_SelectedIndexChanged);
            // 
            // lblMaxPowerTitle
            // 
            this.lblMaxPowerTitle.AutoSize = true;
            this.lblMaxPowerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPowerTitle.Location = new System.Drawing.Point(15, 120);
            this.lblMaxPowerTitle.Name = "lblMaxPowerTitle";
            this.lblMaxPowerTitle.Size = new System.Drawing.Size(176, 13);
            this.lblMaxPowerTitle.TabIndex = 11;
            this.lblMaxPowerTitle.Text = "Maximum Power Level Setting";
            // 
            // cmbMaxPower
            // 
            this.cmbMaxPower.FormattingEnabled = true;
            this.cmbMaxPower.Items.AddRange(new object[] {
            "Text Notification",
            "Sound Notification",
            "Both"});
            this.cmbMaxPower.Location = new System.Drawing.Point(18, 140);
            this.cmbMaxPower.Name = "cmbMaxPower";
            this.cmbMaxPower.Size = new System.Drawing.Size(121, 21);
            this.cmbMaxPower.TabIndex = 12;
            this.cmbMaxPower.SelectedIndexChanged += new System.EventHandler(this.cmbMaxPower_SelectedIndexChanged);
            // 
            // lblSoundTitle
            // 
            this.lblSoundTitle.AutoSize = true;
            this.lblSoundTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoundTitle.Location = new System.Drawing.Point(15, 176);
            this.lblSoundTitle.Name = "lblSoundTitle";
            this.lblSoundTitle.Size = new System.Drawing.Size(145, 13);
            this.lblSoundTitle.TabIndex = 13;
            this.lblSoundTitle.Text = "Select the sound to play";
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.Location = new System.Drawing.Point(18, 200);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(170, 20);
            this.txtSoundPath.TabIndex = 14;
            this.txtSoundPath.TextChanged += new System.EventHandler(this.txtSoundPath_TextChanged);
            // 
            // btnBrowseSound
            // 
            this.btnBrowseSound.Location = new System.Drawing.Point(195, 200);
            this.btnBrowseSound.Name = "btnBrowseSound";
            this.btnBrowseSound.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSound.TabIndex = 15;
            this.btnBrowseSound.Text = "Browse";
            this.btnBrowseSound.UseVisualStyleBackColor = true;
            this.btnBrowseSound.Click += new System.EventHandler(this.btnBrowseSound_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.wav";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStopSound
            // 
            this.btnStopSound.BackgroundImage = global::Benchcode.BatteryLife.Properties.Resources.icon_stop;
            this.btnStopSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStopSound.Location = new System.Drawing.Point(308, 200);
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.Size = new System.Drawing.Size(26, 23);
            this.btnStopSound.TabIndex = 17;
            this.btnStopSound.UseVisualStyleBackColor = true;
            this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
            // 
            // btnPlaySound
            // 
            this.btnPlaySound.BackgroundImage = global::Benchcode.BatteryLife.Properties.Resources.icon_play;
            this.btnPlaySound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlaySound.Location = new System.Drawing.Point(276, 200);
            this.btnPlaySound.Name = "btnPlaySound";
            this.btnPlaySound.Size = new System.Drawing.Size(26, 23);
            this.btnPlaySound.TabIndex = 16;
            this.btnPlaySound.UseVisualStyleBackColor = true;
            this.btnPlaySound.Click += new System.EventHandler(this.btnPlaySound_Click);
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.Location = new System.Drawing.Point(147, 242);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(188, 13);
            this.lblPoweredBy.TabIndex = 18;
            this.lblPoweredBy.Text = "Developed by: Bikash Singh Maharjan";
            // 
            // llblPoweredBy
            // 
            this.llblPoweredBy.AutoSize = true;
            this.llblPoweredBy.Location = new System.Drawing.Point(223, 255);
            this.llblPoweredBy.Name = "llblPoweredBy";
            this.llblPoweredBy.Size = new System.Drawing.Size(0, 13);
            this.llblPoweredBy.TabIndex = 19;
            this.llblPoweredBy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPoweredBy_LinkClicked);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(327, 96);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 13);
            this.lblPercent.TabIndex = 20;
            this.lblPercent.Text = "%";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Battery Life";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 271);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(322, 77);
            this.axWindowsMediaPlayer1.TabIndex = 21;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 266);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.llblPoweredBy);
            this.Controls.Add(this.lblPoweredBy);
            this.Controls.Add(this.btnStopSound);
            this.Controls.Add(this.btnPlaySound);
            this.Controls.Add(this.btnBrowseSound);
            this.Controls.Add(this.txtSoundPath);
            this.Controls.Add(this.lblSoundTitle);
            this.Controls.Add(this.cmbMaxPower);
            this.Controls.Add(this.lblMaxPowerTitle);
            this.Controls.Add(this.cmbMinPower);
            this.Controls.Add(this.lblMinPowerTitle);
            this.Controls.Add(this.chkFullBatteryNotification);
            this.Controls.Add(this.lblMaxPower);
            this.Controls.Add(this.dudMinPower);
            this.Controls.Add(this.lblMinPower);
            this.Controls.Add(this.prbPowerLevel);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblPowerLevelVal);
            this.Controls.Add(this.lblPowerLevel);
            this.Name = "Form1";
            this.Text = "Battery Life - Beta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPowerLevel;
        private System.Windows.Forms.Label lblPowerLevelVal;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.ProgressBar prbPowerLevel;
        private System.Windows.Forms.Label lblMinPower;
        private System.Windows.Forms.DomainUpDown dudMinPower;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.CheckBox chkFullBatteryNotification;
        private System.Windows.Forms.Label lblMinPowerTitle;
        private System.Windows.Forms.ComboBox cmbMinPower;
        private System.Windows.Forms.Label lblMaxPowerTitle;
        private System.Windows.Forms.ComboBox cmbMaxPower;
        private System.Windows.Forms.Label lblSoundTitle;
        private System.Windows.Forms.TextBox txtSoundPath;
        private System.Windows.Forms.Button btnBrowseSound;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPlaySound;
        private System.Windows.Forms.Button btnStopSound;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.LinkLabel llblPoweredBy;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

