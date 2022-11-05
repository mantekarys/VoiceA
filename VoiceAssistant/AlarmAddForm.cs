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
    public partial class AlarmAddForm : Form
    {
        List<Alarm> Alarms;
        AlarmsForm Form;
        public AlarmAddForm(List<Alarm> alarms, AlarmsForm form)
        {
            Alarms = alarms;
            Form = form;
            InitializeComponent();
        }

        private void AlarmAddForm_Load(object sender, EventArgs e)
        {
            ThemeApply();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            int hours, minutes;
            string days = "";
            if (int.TryParse(comboBox1.Text, out hours) && int.TryParse(comboBox2.Text, out minutes))
            {
                label3.Visible = false;
                if (checkBox1.Checked)
                {
                    days = days + "0";
                }
                if (checkBox2.Checked)
                {
                    days = days + "1";
                }
                if (checkBox3.Checked)
                {
                    days = days + "2";
                }
                if (checkBox4.Checked)
                {
                    days = days + "3";
                }
                if (checkBox5.Checked)
                {
                    days = days + "4";
                }
                if (checkBox6.Checked)
                {
                    days = days + "5";
                }
                if (checkBox7.Checked)
                {
                    days = days + "6";
                }
                Alarm alarm = new Alarm(hours, minutes, days, true);
                Alarms.Add(alarm);
                Alarm.UpdateFile("Alarms.txt", Alarms);
                comboBox1.Text = null;
                comboBox2.Text = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                Form.Reload();
            }
            else
            {
                label3.Visible = true;
            }
        
        }

        private void ThemeApply()
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                this.button1.BackColor = Color.FromArgb(51, 78, 108);
                this.button1.ForeColor = Color.Bisque;
                this.button1.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                this.comboBox1.BackColor = Color.FromArgb(51, 78, 108);
                this.comboBox1.ForeColor = Color.Bisque;
                this.comboBox2.BackColor = Color.FromArgb(51, 78, 108);
                this.comboBox2.ForeColor = Color.Bisque;

            }
        }

       
    }
}
