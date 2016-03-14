using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benchcode.BatteryLife
{
    public partial class Form1 : Form
    {
        //Component declarations
        private ContextMenuStrip BatteryLifeContextMenu;
        private ToolStripMenuItem OpenBatteryLife;
        private ToolStripMenuItem ExitBatteryLife;

        private bool IsNotifying;
        private bool IsPlaying;
        private bool DoCheck;

        public Form1()
        {
            IsNotifying = false;
            IsPlaying = false;
            DoCheck = true;
            InitializeComponent();
            CheckBatteryStatus();
            PopulateComboBox();
            PopulateDomainDropDown();
            PopulateFullBatteryNotification();
            txtSoundPath.Text = Properties.Settings.Default.SoundPath;
            llblPoweredBy.Links.Add(0, 17, "http://www.benchcode.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }
        private void PopulateComboBox()
        {
            cmbMinPower.SelectedIndex = Properties.Settings.Default.MinPowerSetting;
            cmbMaxPower.SelectedIndex = Properties.Settings.Default.MaxPowerSetting;
        }
        private void PopulateDomainDropDown()
        {
            for (var i = 100; i >= 1; i--)
            {
                dudMinPower.Items.Add(i);
            }

            int minPowerLevel = 1;
            if (int.TryParse(Properties.Settings.Default.MinPowerLevel , out minPowerLevel))
            {
                dudMinPower.SelectedIndex = minPowerLevel - 1;
            }
        }

        private void PopulateFullBatteryNotification()
        {
            bool fullBatteryNotification = false;
            if (bool.TryParse(Properties.Settings.Default.FullBatteryNotification, out fullBatteryNotification))
            {
                chkFullBatteryNotification.Checked = fullBatteryNotification;
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            CheckBatteryStatus();
        }

        private void CheckBatteryStatus()
        {
            //System.Management.ObjectQuery query = new ObjectQuery("Select * FROM Win32_Battery");
            //ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            //ManagementObjectCollection collection = searcher.Get();

            //foreach (ManagementObject mo in collection)
            //{
            //    foreach (PropertyData property in mo.Properties)
            //    {
            //        if (property.Name.ToLower().Equals("estimatedchargeremaining"))
            //        {
            //            lblPowerLevelVal.Text = property.Value + " %";
            //        }
            //    }
            //}
            PowerState state = PowerState.GetPowerState();
            lblPowerLevelVal.Text = (state.BatteryLifePercent >= 0 && state.BatteryLifePercent <= 100) ? state.BatteryLifePercent + " %" : "0 %";
            prbPowerLevel.Value = (state.BatteryLifePercent >= 0 && state.BatteryLifePercent <= 100) ? state.BatteryLifePercent : 0;
            if(state.ACLineStatus == ACLineStatus.Online)
            {
                lblTimeRemaining.Text = "Plugged in, Charging.";
                if (state.BatteryLifePercent < 100 && !DoCheck)
                {
                    DoCheck = true;
                }
            }
            else
            {
                if (state.BatteryLifeTime == -1)
                {
                    lblTimeRemaining.Text = string.Empty;//Time Unknown
                }
                else
                {
                    TimeSpan result = TimeSpan.FromMinutes((double)state.BatteryLifeTime / 60);
                    lblTimeRemaining.Text = result.ToString("hh' hr 'mm" ) + " min remaining.";

                    var minPowerLevel = Properties.Settings.Default.MinPowerLevel;
                    int intMinPowerLevel = 5;
                    if (int.TryParse(minPowerLevel, out intMinPowerLevel))
                    {
                        if (state.BatteryLifePercent < intMinPowerLevel && !DoCheck)
                        {
                            DoCheck = true;
                        }
                        if (state.BatteryLifePercent == intMinPowerLevel && DoCheck)
                        {
                            var minPowerSelectedIndex = Properties.Settings.Default.MinPowerSetting;
                            switch (minPowerSelectedIndex)
                            {
                                case 0:
                                    if (!IsNotifying)
                                    {
                                        notifyIcon1.Visible = true;
                                        notifyIcon1.Text = "Battery Life";
                                        notifyIcon1.BalloonTipTitle = "Battery Life";
                                        notifyIcon1.BalloonTipText = "Power level is now " + minPowerLevel + "%";
                                        notifyIcon1.ShowBalloonTip(10000);
                                        IsNotifying = true;
                                    }
                                    break;
                                case 1:
                                    if (!IsPlaying)
                                    {
                                        axWindowsMediaPlayer1.URL = Properties.Settings.Default.SoundPath;
                                        axWindowsMediaPlayer1.Ctlcontrols.play();
                                        IsPlaying = true;
                                    }
                                    break;
                                case 2:
                                    if (!IsNotifying)
                                    {
                                        notifyIcon1.Visible = true;
                                        notifyIcon1.Text = "Battery Life";
                                        notifyIcon1.BalloonTipTitle = "Battery Life";
                                        notifyIcon1.BalloonTipText = "Power level is now " + minPowerLevel + "%. Click here to stop music.";
                                        notifyIcon1.ShowBalloonTip(30000);
                                        notifyIcon1.BalloonTipClicked += notifyIcon1_BalloonTipClicked;
                                        IsNotifying = true;
                                    }
                                    if (!IsPlaying)
                                    {
                                        axWindowsMediaPlayer1.URL = Properties.Settings.Default.SoundPath;
                                        axWindowsMediaPlayer1.Ctlcontrols.play();
                                        IsPlaying = true;
                                    }
                                    break;
                            }
                            DoCheck = false;
                        }
                    }                  
                }
            }
           
            if (state.BatteryLifePercent == 100 && DoCheck)
            {
                var maxPowerSelectedIndex = Properties.Settings.Default.MaxPowerSetting;
                switch (maxPowerSelectedIndex)
                {
                    case 0:
                        if (!IsNotifying)
                        {
                            notifyIcon1.Visible = true;
                            notifyIcon1.Text = "Battery Life";
                            notifyIcon1.BalloonTipTitle = "Battery Life";
                            notifyIcon1.BalloonTipText = "Power level is now 100%";
                            notifyIcon1.ShowBalloonTip(10000);
                            IsNotifying = true;
                        }
                        break;
                    case 1:
                        if (!IsPlaying) 
                        { 
                            axWindowsMediaPlayer1.URL = Properties.Settings.Default.SoundPath;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            IsPlaying = true;
                        }
                        break;
                    case 2:
                        if (!IsNotifying) 
                        { 
                            notifyIcon1.Visible = true;
                            notifyIcon1.Text = "Battery Life";
                            notifyIcon1.BalloonTipTitle = "Battery Life";
                            notifyIcon1.BalloonTipText = "Power level is now 100%. Click here to stop music.";
                            notifyIcon1.ShowBalloonTip(30000);
                            notifyIcon1.BalloonTipClicked +=notifyIcon1_BalloonTipClicked;
                            IsNotifying = true;
                        }
                        if (!IsPlaying)
                        {
                            axWindowsMediaPlayer1.URL = Properties.Settings.Default.SoundPath;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            IsPlaying = true;
                        }
                        break;
                }
                DoCheck = false;
            }
           
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Properties.Settings.Default.SoundPath;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            notifyIcon1.Visible = true;
            IsNotifying = false;

            IsPlaying = false;
        }

        private void dudMinPowerLevel_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["MinPowerLevel"] = dudMinPower.Text;
            Properties.Settings.Default.Save();
        }

        private void chkFullBatteryNotification_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["FullBatteryNotification"] = chkFullBatteryNotification.Checked.ToString();
            Properties.Settings.Default.Save();
        }

        private void btnBrowseSound_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string soundFile = openFileDialog1.FileName;
                txtSoundPath.Text = soundFile;
            }
        }

        private void llblPoweredBy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void cmbMinPower_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["MinPowerSetting"] = cmbMinPower.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void cmbMaxPower_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["MaxPowerSetting"] = cmbMaxPower.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;

                BatteryLifeContextMenu = new ContextMenuStrip();
                OpenBatteryLife = new ToolStripMenuItem();
                ExitBatteryLife = new ToolStripMenuItem();

                BatteryLifeContextMenu.SuspendLayout();

                this.BatteryLifeContextMenu.Items.AddRange(
                    new ToolStripItem[] { this.OpenBatteryLife, this.ExitBatteryLife });
                this.BatteryLifeContextMenu.Name = "BatteryLifeContextMenu";
                this.BatteryLifeContextMenu.Size = new Size(153, 70);

                this.OpenBatteryLife.Name = "OpenBatteryLife";
                this.OpenBatteryLife.Size = new Size(152, 22);
                this.OpenBatteryLife.Text = "Open";
                this.OpenBatteryLife.Click += OpenBatteryLife_Click;

                this.ExitBatteryLife.Name = "ExitBatteryLife";
                this.ExitBatteryLife.Size = new Size(152, 22);
                this.ExitBatteryLife.Text = "Exit";
                this.ExitBatteryLife.Click += ExitBatteryLife_Click;

                this.BatteryLifeContextMenu.ResumeLayout(false);

                notifyIcon1.ContextMenuStrip = BatteryLifeContextMenu;
            }
        }
        private void OpenBatteryLife_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            IsNotifying = false;
            WindowState = FormWindowState.Normal;
        }

        private void ExitBatteryLife_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            IsNotifying = false;
            WindowState = FormWindowState.Normal;
        }
        private void txtSoundPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["SoundPath"] = txtSoundPath.Text;
            Properties.Settings.Default.Save();
        }

        private void btnPlaySound_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Properties.Settings.Default.SoundPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            IsPlaying = true;
        }

        private void btnStopSound_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Properties.Settings.Default.SoundPath;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            IsPlaying = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }

    }
}
