using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public partial class TextBoxPopup : Form
    {
        private string noteName;
        public TextBoxPopup()
        {
            InitializeComponent();
        }

        private void TextBoxPopup_Load(object sender, EventArgs e)
        {
            noteName += " " + DateTime.Now.ToString("yyyyMMddHHmm");
            NotificationLabel.Text += noteName;
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.NotificationLabel.BackColor = this.BackColor;
                this.NotificationLabel.ForeColor = Color.Bisque;
                this.ConfirmationButton.BackColor = Color.FromArgb(51, 78, 108);
                this.ConfirmationButton.ForeColor = Color.Bisque;
                this.ConfirmationButton.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                this.InputTxtBox.BackColor = Color.FromArgb(72, 101, 129);
                this.InputTxtBox.ForeColor = Color.Bisque;
                this.InputTxtBox.BorderStyle = BorderStyle.None;
            }

        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory,@"Notes\", noteName + ".txt");
            using (StreamWriter fs = new StreamWriter(path))
            {
                fs.Write(InputTxtBox.Text);
            }
                this.Hide(); //for closing form

        }

        private void NotificationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
