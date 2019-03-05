using Microsoft.Win32;
using System;
using System.Media;
using System.Windows.Forms;

namespace BreakTimer
{
    public partial class BreakForm : Form
    {
        private SoundPlayer player;
        private TimerForm timerForm;
        private int hours, minutes, seconds;
        private bool forceBreak;
        public BreakForm(TimerForm frm, String forced = "none")
        {
            InitializeComponent();
            resetTimer();
            if (forced == "forced")
                forceBreak = true;
            else if (forced == "unForced")
                forceBreak = false;
            else
                forceBreak = Properties.Settings.Default.forcedBreak;
            this.timerForm = frm;
            if (forceBreak)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.ShowInTaskbar = false;
                this.TopMost = true;
                this.hours_label.Font = new System.Drawing.Font("Consolas", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.minutes_label.Font = new System.Drawing.Font("Consolas", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.seconds_label.Font = new System.Drawing.Font("Consolas", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.minutes_seperator.Font = new System.Drawing.Font("Consolas", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.hours_seperator.Font = new System.Drawing.Font("Consolas", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                timerForm.notifyIcon.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
                this.ShowInTaskbar = true;
                this.TopMost = false;
            }
        }

        private void BreakForm_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            Application.AddMessageFilter(new AltF4Filter());
            disableTaskManager();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((hours == 0) && (minutes == 0) && (seconds == 0))
            {
                timer.Enabled = false;
                timerForm.notifyIcon.Visible = true;
                if (Properties.Settings.Default.playSound)
                {
                    try
                    {
                        player = new SoundPlayer(@"BreakEnd.wav");
                        player.Play();
                    }
                    catch //Catch Nothing, Just continue without sound
                    {
                        //Display a Balloon to the user to notify him about non existance of the sound file.
                        timerForm.notifyIcon.BalloonTipTitle = "BreakTimer";
                        timerForm.notifyIcon.BalloonTipText = "No Sound file found,\nMake sure there is a sound file in the same folder with the application";
                        timerForm.notifyIcon.ShowBalloonTip(5000);
                    }
                }
                timerForm.Show();
                this.Close();
            }
            else
            {
                if (seconds < 1)
                {
                    seconds = 59;
                    minutes -= 1;
                }
                if (minutes < 1)
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
        private void resetTimer()
        {
            hours = Properties.Settings.Default.breakHours;
            minutes = Properties.Settings.Default.breakMinutes;
            seconds = Properties.Settings.Default.breakSeconds;
            hours_label.Text = hours.ToString().PadLeft(2, '0');
            minutes_label.Text = minutes.ToString().PadLeft(2, '0');
            seconds_label.Text = seconds.ToString().PadLeft(2, '0');
        }

        private void BreakForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            enableTaskManager();
        }

        //Task Manager Enabling/Disabling funcitons
        private void disableTaskManager()
        {
            RegistryKey regkey = default(RegistryKey);
            string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registry Error!");
            }

        }

        private void enableTaskManager()
        {
            RegistryKey regkey = default(RegistryKey);
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                regkey.DeleteValue("DisableTaskMgr", false);
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registry Error!");
            }

        }
    }
}
