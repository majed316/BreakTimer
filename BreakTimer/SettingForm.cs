using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace BreakTimer
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            //Load Timer Setting 
            hTimerTextBox.Text = Properties.Settings.Default.timerHours.ToString();
            mTimerTextbox.Text = Properties.Settings.Default.timerMinutes.ToString();
            sTimerTextBox.Text = Properties.Settings.Default.timerSeconds.ToString();

            //Load Break setting
            hBreakTextBox.Text = Properties.Settings.Default.breakHours.ToString();
            mBreakTextBox.Text = Properties.Settings.Default.breakMinutes.ToString();
            sBreakTextBox.Text = Properties.Settings.Default.breakSeconds.ToString();

            //Load Other Settings
            isPlaySound.Checked = Properties.Settings.Default.playSound;
            isForcedBreak.Checked = Properties.Settings.Default.forcedBreak;
            startupCheck.Checked = getStartup();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.timerHours = Convert.ToInt32(hTimerTextBox.Text);
            Properties.Settings.Default.timerMinutes = Convert.ToInt32(mTimerTextbox.Text);
            Properties.Settings.Default.timerSeconds = Convert.ToInt32(sTimerTextBox.Text);
            Properties.Settings.Default.breakHours = Convert.ToInt32(hBreakTextBox.Text);
            Properties.Settings.Default.breakMinutes = Convert.ToInt32(mBreakTextBox.Text);
            Properties.Settings.Default.breakSeconds = Convert.ToInt32(sBreakTextBox.Text);
            Properties.Settings.Default.playSound = isPlaySound.Checked;
            Properties.Settings.Default.forcedBreak = isForcedBreak.Checked;
            Properties.Settings.Default.Save();
            
            //set startup status
            if (startupCheck.Checked)
            {
                setStartup(true);
            }
            else
            {
                setStartup(false);
            }

            //close the form
            this.Close();
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

        private bool getStartup()
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
