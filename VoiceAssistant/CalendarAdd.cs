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
    public partial class CalendarAdd : Form
    {
        public CalendarAdd()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Console.WriteLine("Event is added");
                Task.Factory.StartNew(() =>
                {
                    var form = new CalendarForm();
                    form.Add(textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                });
            }
            else
            {
                Console.WriteLine("Bad input");
            }
        }

        private void CalendarAdd_Load(object sender, EventArgs e)
        {
            ThemeApply();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Name should not be left blank!");
            }
            else if (textBox1.Text.Length > 30)
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Name should be shorter than 31 symbol");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Date should be larger than current");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Ending Date should be after or during starting date");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }
        private void ThemeApply()
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                this.textBox1.BackColor = Color.FromArgb(72, 101, 129);
                this.textBox1.ForeColor = Color.Bisque;
                this.textBox1.BorderStyle = BorderStyle.None;
                this.button1.BackColor = Color.FromArgb(51, 78, 108);
                this.button1.ForeColor = Color.Bisque;
                this.button1.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
            }
        }
    }
}
