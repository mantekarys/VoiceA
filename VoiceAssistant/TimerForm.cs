using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public partial class TimerForm : Form
    {
        private int totalSeconds;
        public TimerForm()
        {
            InitializeComponent();
            HourComboBox.Text = "00";
            MinuteComboBox.Text = "00";
            SecondComboBox.Text = "00";
        }
        public TimerForm(int seconds)
        {
            if(seconds > 86399)
            {
                totalSeconds = 86399;
            }
            else
            {
                totalSeconds = seconds;
            }
            InitializeComponent();
            timer1.Enabled = true;
            DisplayLabel.Text = getTimeString(totalSeconds);
            HourComboBox.Enabled = false;
            MinuteComboBox.Enabled = false;
            SecondComboBox.Enabled = false;
            int sec = totalSeconds;
            int hours = sec / 3600;
            sec -= hours * 3600;
            int minutes = sec / 60;
            sec = sec % 60;
            HourComboBox.Text = hours.ToString("D2");
            MinuteComboBox.Text = minutes.ToString("D2");
            SecondComboBox.Text = sec.ToString("D2");
            ControlButton.Text = "Pause";
        }
        private void TimerForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.DisplayLabel.BackColor = this.BackColor;
                this.DisplayLabel.ForeColor = Color.Bisque;
                this.HoursLabels.BackColor = this.BackColor;
                this.HoursLabels.ForeColor = Color.Bisque;
                this.MinutesLabel.BackColor = this.BackColor;
                this.MinutesLabel.ForeColor = Color.Bisque;
                this.SecondsLabel.BackColor = this.BackColor;
                this.SecondsLabel.ForeColor = Color.Bisque;
                this.HourComboBox.BackColor = Color.FromArgb(51, 78, 108);
                this.HourComboBox.ForeColor = Color.Bisque;
                this.MinuteComboBox.BackColor = Color.FromArgb(51, 78, 108);
                this.MinuteComboBox.ForeColor = Color.Bisque;
                this.SecondComboBox.BackColor = Color.FromArgb(51, 78, 108);
                this.SecondComboBox.ForeColor = Color.Bisque;
                this.ControlButton.BackColor = Color.FromArgb(51, 78, 108);
                this.ControlButton.ForeColor = Color.Bisque;
                this.ControlButton.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                this.StopButton.BackColor = Color.FromArgb(51, 78, 108);
                this.StopButton.ForeColor = Color.Bisque;
                this.StopButton.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);

            }

        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            if (HourComboBox.Text == "00" && MinuteComboBox.Text == "00" && SecondComboBox.Text == "00")
            {
                return;
            }
            if (HourComboBox.Enabled)
            {
                timer1.Enabled = true;
                HourComboBox.Enabled = false;
                MinuteComboBox.Enabled = false;
                SecondComboBox.Enabled = false;
                totalSeconds = int.Parse(HourComboBox.Text) * 3600 + int.Parse(MinuteComboBox.Text) * 60 + int.Parse(SecondComboBox.Text);
                DisplayLabel.Text = getTimeString(totalSeconds);
                ControlButton.Text = "Pause";
            }
            else if (timer1.Enabled)
            {
                timer1.Enabled = false;
                ControlButton.Text = "Start";
            }
            else
            {
                timer1.Enabled = true;
                ControlButton.Text = "Pause";
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            HourComboBox.Enabled = true;
            MinuteComboBox.Enabled = true;
            SecondComboBox.Enabled = true;
            totalSeconds = 0;
            DisplayLabel.Text = "00:00:00";
            timer1.Enabled = false;
            ControlButton.Text = "Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            DisplayLabel.Text = getTimeString(totalSeconds);
            if (totalSeconds == 0)
            {
                timer1.Enabled = false;
                HourComboBox.Enabled = true;
                MinuteComboBox.Enabled = true;
                SecondComboBox.Enabled = true;
                ControlButton.Text = "Start";
                MessageBox.Show("Timer is up!");
            }
        }

        private static string getTimeString(int totalSeconds)
        {
            int seconds = totalSeconds;
            int hours = seconds / 3600;
            seconds -= hours * 3600;
            int minutes = seconds / 60;
            seconds = seconds % 60;
            TimeSpan time = new TimeSpan(hours, minutes, seconds);
            string timeString = String.Format("{0:hh\\:mm\\:ss}", time);
            return timeString;
        }

        private void HourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
