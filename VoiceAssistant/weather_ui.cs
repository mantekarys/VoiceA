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
    public partial class weather_ui : Form
    {
        WeatherInfo weather = new WeatherInfo();

        public weather_ui()
        {
            InitializeComponent();
        }
        public weather_ui(string location)
        {
            InitializeComponent();

            //string location = textBox_Search.Text;

            try
            {
                label_Error.Visible = false;
                string[] info = weather.GetInfo(location);

                UpdateFields(info);
            }
            catch
            {
                label_Error.Visible = true;
            }
        }

        public void Search_Voice(string location)
        {
            try
            {
                label_Error.Visible = false;
                string[] info = weather.GetInfo(location);

                UpdateFields(info);
            }
            catch
            {
                label_Error.Visible = true;
            }
        }

        public void UpdateFields(string[] info)
        {
            label_Location.Text = info[7];
            label_Date.Text = info[8];

            label_Temperature.Text = info[0];
            label_Humidity.Text = info[1];
            label_Pressure.Text = info[2];
            label_Wind_Speed.Text = info[3];
            label_Wind_Direction.Text = info[4];
            label_Clouds.Text = info[5];
            label_Precipation.Text = info[6];
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string location = textBox_Search.Text;

            try
            {
                label_Error.Visible = false;
                string[] info = weather.GetInfo(location);

                UpdateFields(info);
            }
            catch
            {
                label_Error.Visible = true;
            }
        }

        private void weather_ui_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                this.textBox_Search.BackColor = Color.FromArgb(72, 101, 129);
                this.textBox_Search.ForeColor = Color.Bisque;
                this.textBox_Search.BorderStyle = BorderStyle.None;
                this.button_Search.BackColor = Color.FromArgb(51, 78, 108);
                this.button_Search.ForeColor = Color.Bisque;
                this.button_Search.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);

            }

        }
    }
}
