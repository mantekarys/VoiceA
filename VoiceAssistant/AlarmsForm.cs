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
    public partial class AlarmsForm : Form
    {
        List<Alarm> Alarms;
        public AlarmsForm(List<Alarm> alarms)
        {
            Alarms = alarms;
            InitializeComponent();
        }

        private void AlarmsForm_Load(object sender, EventArgs e)
        {
            while (tableLayoutPanel2.Controls.Count > 0)
            {
                tableLayoutPanel2.Controls[0].Dispose();
            }
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.RowCount = 0;
            for (int i = 0; i < Alarms.Count; i++)
            {
                tableLayoutPanel2.Controls.Add(new Label() { Text = String.Format("{0}:{1}", Alarms[i].Hour.ToString("D2"), Alarms[i].Minute.ToString("D2")), TextAlign = ContentAlignment.BottomCenter, Font = new Font("Arial", 15, FontStyle.Regular), Height = 30 }, 0, i);
                for (int j = 0; j < 7; j++)
                {
                    Button button = new Button() { Size = new Size(42, 30), Name = i.ToString() };
                    button.Click += dayButton_Click;
                    switch (j)
                    {
                        case 0:
                            button.Text = "Mon";
                            break;
                        case 1:
                            button.Text = "Tue";
                            break;
                        case 2:
                            button.Text = "Wed";
                            break;
                        case 3:
                            button.Text = "Thu";
                            break;
                        case 4:
                            button.Text = "Fri";
                            break;
                        case 5:
                            button.Text = "Sat";
                            break;
                        case 6:
                            button.Text = "Sun";
                            break;
                    }
                    if (Alarms[i].Days[j])
                    {
                        button.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                    else
                    {
                        button.Font = new Font(this.Font, FontStyle.Regular);
                    }
                    tableLayoutPanel2.Controls.Add(button, j + 1, i);
                }
                Button enabled = new Button() { Size = new Size(65, 30), Name = i.ToString() };
                if (Alarms[i].Enabled)
                {
                    enabled.Text = "Enabled";
                    enabled.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);
                }
                else
                {
                    enabled.Text = "Disabled";
                    enabled.Font = new Font(this.Font, FontStyle.Regular);
                }
                enabled.Click += enableButton_Click;
                tableLayoutPanel2.Controls.Add(enabled, 9, i);

                Button delete = new Button() { Size = new Size(65, 30), Name = i.ToString(), Text = "Delete" };
                delete.Click += deleteButton_Click;
                tableLayoutPanel2.Controls.Add(delete, 10, i);
            }

            ThemeApply();
        }

        private void dayButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool day = false;
            switch (button.Text)
            {
                case "Mon":
                    Alarms[int.Parse(button.Name)].Days[0] = !Alarms[int.Parse(button.Name)].Days[0];
                    day = Alarms[int.Parse(button.Name)].Days[0];
                    break;
                case "Tue":
                    Alarms[int.Parse(button.Name)].Days[1] = !Alarms[int.Parse(button.Name)].Days[1];
                    day = Alarms[int.Parse(button.Name)].Days[1];
                    break;
                case "Wed":
                    Alarms[int.Parse(button.Name)].Days[2] = !Alarms[int.Parse(button.Name)].Days[2];
                    day = Alarms[int.Parse(button.Name)].Days[2];
                    break;
                case "Thu":
                    Alarms[int.Parse(button.Name)].Days[3] = !Alarms[int.Parse(button.Name)].Days[3];
                    day = Alarms[int.Parse(button.Name)].Days[3];
                    break;
                case "Fri":
                    Alarms[int.Parse(button.Name)].Days[4] = !Alarms[int.Parse(button.Name)].Days[4];
                    day = Alarms[int.Parse(button.Name)].Days[4];
                    break;
                case "Sat":
                    Alarms[int.Parse(button.Name)].Days[5] = !Alarms[int.Parse(button.Name)].Days[5];
                    day = Alarms[int.Parse(button.Name)].Days[5];
                    break;
                case "Sun":
                    Alarms[int.Parse(button.Name)].Days[6] = !Alarms[int.Parse(button.Name)].Days[6];
                    day = Alarms[int.Parse(button.Name)].Days[6];
                    break;
            }
            if (day)
            {
                button.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else
            {
                button.Font = new Font(this.Font, FontStyle.Regular);
            }
            Alarm.UpdateFile("Alarms.txt", Alarms);
        }
        private void enableButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Alarms[int.Parse(button.Name)].Enabled = !Alarms[int.Parse(button.Name)].Enabled;
            if (Alarms[int.Parse(button.Name)].Enabled)
            {
                button.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);
                button.Text = "Enabled";
            }
            else
            {
                button.Font = new Font(this.Font, FontStyle.Regular);
                button.Text = "Disabled";
            }
            Alarm.UpdateFile("Alarms.txt", Alarms);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Alarms.RemoveAt(int.Parse(button.Name));
            Alarm.UpdateFile("Alarms.txt", Alarms);
            AlarmsForm_Load(sender, e);
        }
        public void Reload()
        {
            AlarmsForm_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlarmAddForm form = new AlarmAddForm(Alarms, this);
            form.Show();
        }

        private void ThemeApply()
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                button1.BackColor = Color.FromArgb(51, 78, 108);
                button1.ForeColor = Color.Bisque;
                button1.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                foreach (Control c in this.tableLayoutPanel2.Controls)
                {
                    if (c is Button)
                    {
                        Button temp = (Button)c;
                        temp.BackColor = Color.FromArgb(51, 78, 108);
                        temp.ForeColor = Color.Bisque;
                        temp.FlatStyle = FlatStyle.Flat;
                        temp.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                    }
                }
            }
        }
    }
}
