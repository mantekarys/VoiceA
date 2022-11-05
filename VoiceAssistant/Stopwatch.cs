using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public partial class Stopwatch : Form
    {
        private int totalSeconds = 0;
        public Stopwatch()
        {
            InitializeComponent();
        }

        private void Stopwatch_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34,34,34);
                this.DisplayLabel.BackColor = this.BackColor;
                this.DisplayLabel.ForeColor = Color.Bisque;
                this.ResetButton.BackColor = Color.FromArgb(51, 78, 108);
                this.ResetButton.ForeColor = Color.Bisque;
                this.ResetButton.FlatAppearance.BorderColor= Color.FromArgb(51, 78, 108);
                this.ControlButton.BackColor = Color.FromArgb(51, 78, 108);
                this.ControlButton.ForeColor = Color.Bisque;
                this.ControlButton.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
            }
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            if (ControlButton.Text == "Start")
            {
                timer1.Enabled = true;
                ControlButton.Text = "Pause";
            }
            else
            {
                timer1.Enabled = false;
                ControlButton.Text = "Start";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ControlButton.Text = "Start";
            totalSeconds = 0;
            DisplayLabel.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalSeconds++;
            DisplayLabel.Text = getTimeString(totalSeconds);
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

        private void DisplayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
