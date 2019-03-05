using Microsoft.Win32;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace BreakTimer
{
    public partial class TimerForm : Form
    {
        private SoundPlayer player;
        private int hours, minutes, seconds;
        private bool pause;
        private SettingForm settingForm;
        private BreakForm breakForm;

        public TimerForm()
        {
            InitializeComponent();
            resetTimer();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.Visible == false)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Hide();
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if((hours == 0) && (minutes == 0) && (seconds == 0))
            {
                timer.Enabled = false;
                timerStopButton.Enabled = false;
                timerPauseButton.Enabled = false;
                timerStartButton.Enabled = true;
                resetTimer();
                if (Properties.Settings.Default.playSound)
                {
                    try
                    {
                        player = new SoundPlayer(@"BreakStart.wav");
                        player.Play();
                    }

                    catch { }
                }

                breakForm = new BreakForm(this);
                breakForm.Show();
                this.Hide();
            }
            else
            {
                if (hours == 0 && minutes == 0 && seconds == 30)
                {
                    if (Properties.Settings.Default.playSound)
                    {
                        try
                        {
                            player = new SoundPlayer(@"BreakApproach.wav");
                            player.Play();
                        }
                        catch { }
                    }
                    notifyIcon.BalloonTipTitle = "BreakTimer";
                    notifyIcon.BalloonTipText = "Still 30 seconds to the break, try to finish what are you doing.";
                    notifyIcon.ShowBalloonTip(5000);
                }
                if (seconds < 1)
                {
                    seconds = 59;
                    minutes -= 1;
                }
                if(minutes < 1)
                {
                    if (hours == 0)
                    {
                        hours = 0;
                    }
                    else
                    {
                        hours -= 1;
                        minutes = 59;
                    }
                }
                hours_label.Text = hours.ToString().PadLeft(2, '0');
                minutes_label.Text = minutes.ToString().PadLeft(2, '0');
                seconds_label.Text = seconds.ToString().PadLeft(2, '0');
                seconds -= 1;
            }
        }

        private void aboutToolStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BreakTimer\n2015 - 2016\nDesigned By Majed Ali");
        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void showTheTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Hide();
            }
        }

        private void timerPauseButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            pause = true;
            timerPauseButton.Enabled = false;
            timerStartButton.Enabled = true;
        }

        private void timerStopButton_Click(object sender, EventArgs e)
        {
            pause = false;
            timer.Enabled = false;
            timerStartButton.Enabled = true;
            timerPauseButton.Enabled = false;
            timerStopButton.Enabled = false;
            hours_label.Text = hours.ToString().PadLeft(2, '0');
            minutes_label.Text = minutes.ToString().PadLeft(2, '0');
            seconds_label.Text = seconds.ToString().PadLeft(2, '0');
            resetTimer();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingForm = new SettingForm();
            settingForm.Show();
        }

        private void launchOnStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (launchOnStartupToolStripMenuItem.Checked == true)
            {
                setStartup(false);
                launchOnStartupToolStripMenuItem.Checked = false;
            }
                
            else
            {
                setStartup(true);
                launchOnStartupToolStripMenuItem.Checked = true;
            }
                
        }

        private void timerStartButton_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                resetTimer();
                timer.Enabled = true;
                timerStartButton.Enabled = false;
                timerPauseButton.Enabled = true;
                timerStopButton.Enabled = true;
            }
            else
            {
                timer.Enabled = true;
                timerStartButton.Enabled = false;
                timerPauseButton.Enabled = true;
            }

        }

        private void resetTimer()
        {
            hours = Properties.Settings.Default.timerHours;
            minutes = Properties.Settings.Default.timerMinutes;
            seconds = Properties.Settings.Default.timerSeconds;
            hours_label.Text = hours.ToString().PadLeft(2, '0');
            minutes_label.Text = minutes.ToString().PadLeft(2, '0');
            seconds_label.Text = seconds.ToString().PadLeft(2, '0');
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            launchMinimizedToolStripMenuItem.Checked = Properties.Settings.Default.launchMinimized;
            if (Properties.Settings.Default.launchMinimized)
            {
                if (Properties.Settings.Default.hideOnMinimize)
                {

                    BeginInvoke(new MethodInvoker(delegate
                    {
                        Hide();
                    }));
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                
            }

            hideWhenMinimizeToolStripMenuItem.Checked = Properties.Settings.Default.hideOnMinimize;
            if (istStartup())
            {
                launchOnStartupToolStripMenuItem.Checked = true;
            }
            else
            {
                launchOnStartupToolStripMenuItem.Checked = false;
            }
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            this.Hide();
            e.Cancel = true;
        }

        private void hideWhenMinimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideWhenMinimizeToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.hideOnMinimize = false;
                hideWhenMinimizeToolStripMenuItem.Checked = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.hideOnMinimize = true;
                hideWhenMinimizeToolStripMenuItem.Checked = true;
                Properties.Settings.Default.Save();
            }
        }

        private void TimerForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized && Properties.Settings.Default.hideOnMinimize)
            {
                this.Hide();
            }
        }

        private void preferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            settingForm = new SettingForm();
            settingForm.Show();
        }

        private void startTheTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerStartButton_Click(sender, e);
        }

        private void pauseTheTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerPauseButton_Click(sender, e);
        }

        private void stopTheTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerStopButton_Click(sender, e);
        }

        private void takeBreakableBreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerStopButton_Click(sender, e);
            breakForm = new BreakForm(this, "unForced");
            breakForm.Show();
            this.Hide();
        }

        private void takeUnBreakableBreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerStopButton_Click(sender, e);
            breakForm = new BreakForm(this, "forced");
            breakForm.Show();
            this.Hide();
        }

        private void launchMinimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (launchMinimizedToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.launchMinimized = false;
                launchMinimizedToolStripMenuItem.Checked = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.launchMinimized = true;
                launchMinimizedToolStripMenuItem.Checked = true;
                Properties.Settings.Default.Save();
            }
        }

        private void aboutBreakTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutToolStrip_Click(sender, e);
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have the latest version.");
        }

        private void setStartup(bool isStartup)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (isStartup)
                rk.SetValue("BreakTimer", Application.ExecutablePath.ToString());
            else
                rk.DeleteValue("BreakTimer", false);
        }

        private bool istStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rk.GetValue("BreakTimer") == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
