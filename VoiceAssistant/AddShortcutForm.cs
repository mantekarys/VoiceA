using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public partial class AddShortcutForm : Form
    {
        int Type; // 0 - shortcut, 1 - url
        ShortcutBookmarkListForm Parent;

        public AddShortcutForm(int type, ShortcutBookmarkListForm parent)
        {
            InitializeComponent();

            Type = 0;
            if (type == 0 || type == 1)
                Type = type;

            if (Type == 0)
                labelPath.Text = "File path:";
            else if (Type == 1)
                labelPath.Text = "URL:";

            Parent = parent;
            labelError.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string path = textBoxPath.Text;

            if (!string.IsNullOrWhiteSpace(name))
            {
                if (!string.IsNullOrWhiteSpace(path))
                {
                    if (Type == 0)
                    {
                        if (!Shortcut.Contains(name))
                        {
                            Shortcut.Create(name, Constants.ShortcutsFolder, path);
                            labelError.Text = textBoxName.Text = textBoxPath.Text = "";
                            Parent.Display();
                        }
                        else
                        {
                            labelError.Text = $"Shortcut \"{ name }\" already exists.";
                        }
                    }
                    else if (Type == 1)
                    {
                        if (!Shortcut.Contains(name))
                        {
                            Shortcut.CreateURL(name, Constants.ShortcutsFolder, path);
                            labelError.Text = textBoxName.Text = textBoxPath.Text = "";
                            Parent.Display();
                        }
                        else
                        {
                            labelError.Text = $"Bookmark \"{ name }\" already exists.";
                        }
                    }
                }
                else
                {
                    labelError.Text = "Path is not specified.";
                }
            }
            else
            {
                labelError.Text = "Name is not specified.";
            }
        }

        private void AddShortcutForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                this.buttonAdd.BackColor = Color.FromArgb(51, 78, 108);
                this.buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                this.textBoxName.BackColor = Color.FromArgb(72, 101, 129);
                this.textBoxPath.BackColor = Color.FromArgb(72, 101, 129);
                this.textBoxPath.BorderStyle = BorderStyle.None;
                this.textBoxName.BorderStyle = BorderStyle.None;
                this.textBoxPath.ForeColor = Color.Bisque;
                this.textBoxName.ForeColor = Color.Bisque;
            }
        }
    }
}
