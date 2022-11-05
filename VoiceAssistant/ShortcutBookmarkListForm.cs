using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public partial class ShortcutBookmarkListForm : Form
    {
        string[] Files;

        public ShortcutBookmarkListForm()
        {
            InitializeComponent();

            Display();
        }

        public void Display()
        {
            Files = TaskUtils.GetFileNames(Constants.ShortcutsFolder);
            textBoxShortcuts.Text = GetShortcuts();
            textBoxBookmarks.Text = GetBookmarks();
        }

        private string GetShortcuts()
        {
            string shortcuts = "";

            int index = 1;
            foreach (string file in Files)
            {
                if (file.EndsWith(".lnk"))
                {
                    shortcuts += index + ". " + file.Replace(".lnk", "") + "\r\n";
                    index++;
                }
            }

            return shortcuts.TrimEnd("\r\n".ToCharArray());
        }

        private string GetBookmarks()
        {
            string bookmarks = "";

            int index = 1;
            foreach (string file in Files)
            {
                if (file.EndsWith(".url"))
                {
                    bookmarks += index + ". " + file.Replace(".url", "") + "\r\n";
                    index++;
                }
            }

            return bookmarks.TrimEnd("\r\n".ToCharArray());
        }

        private void labelAddShortcut_Click(object sender, EventArgs e)
        {
            var addShortcutForm = new AddShortcutForm(0, this);
            addShortcutForm.Show();
        }

        private void labelRemoveShortcut_Click(object sender, EventArgs e)
        {
            var removeShortcutForm = new RemoveShortcutForm(0, this);
            removeShortcutForm.Show();
        }

        private void labelAddBookmark_Click(object sender, EventArgs e)
        {
            var addShortcutForm = new AddShortcutForm(1, this);
            addShortcutForm.Show();
        }

        private void labelRemoveBookmark_Click(object sender, EventArgs e)
        {
            var removeShortcutForm = new RemoveShortcutForm(1, this);
            removeShortcutForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Display();
        }

        private string GetAtIndex(RichTextBox RTB, int index)
        {
            string text = RTB.Text;
            int ind = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (i == index)
                    return text.Split('\n')[ind].Replace("\r", "").Substring(3);

                if (text[i] == '\n')
                    ind++;
            }

            return null;
        }

        private void textBoxBookmarks_MouseUp(object sender, MouseEventArgs e)
        {
            string line = GetAtIndex(textBoxBookmarks, textBoxBookmarks.SelectionStart);
            Shortcut.Open(line, Constants.ShortcutsFolder);
        }

        private void textBoxShortcuts_MouseUp(object sender, MouseEventArgs e)
        {
            string line = GetAtIndex(textBoxShortcuts, textBoxShortcuts.SelectionStart);
            Shortcut.Open(line, Constants.ShortcutsFolder);
        }

        private void textBoxShortcuts_MouseMove(object sender, MouseEventArgs e)
        {
            this.Focus();
        }

        private void textBoxBookmarks_MouseMove(object sender, MouseEventArgs e)
        {
            this.Focus();
        }

        private void ShortcutBookmarkListForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                this.pictureBox1.BackColor = Color.Bisque;
                this.textBoxShortcuts.BackColor = Color.FromArgb(72, 101, 129);
                this.textBoxShortcuts.BorderStyle = BorderStyle.None;
                this.textBoxShortcuts.ForeColor = Color.Bisque;
                this.textBoxBookmarks.BackColor = Color.FromArgb(72, 101, 129);
                this.textBoxBookmarks.BorderStyle = BorderStyle.None;
                this.textBoxBookmarks.ForeColor = Color.Bisque;

            }
        }
    }
}
