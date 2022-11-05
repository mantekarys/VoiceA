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
    public partial class RemoveShortcutForm : Form
    {
        int Type; // 0 - shortcut, 1 - url
        ShortcutBookmarkListForm Parent;

        public RemoveShortcutForm(int type, ShortcutBookmarkListForm parent)
        {
            InitializeComponent();

            Type = 0;
            if (type == 0 || type == 1)
                Type = type;

            Parent = parent;
            UpdateList();
        }

        public void UpdateList()
        {
            string[] files_m = TaskUtils.GetFileNames(Constants.ShortcutsFolder);
            string files = "";

            if (Type == 0)
                files = GetShortcuts(files_m);
            else if (Type == 1)
                files = GetBookmarks(files_m);

            textBoxList.Text = files;
        }

        private string GetShortcuts(string[] lines)
        {
            string shortcuts = "";

            foreach (string file in lines)
                if (file.EndsWith(".lnk"))
                    shortcuts += file.Replace(".lnk", "") + "\r\n";

            return shortcuts.TrimEnd("\r\n".ToCharArray());
        }

        private string GetBookmarks(string[] lines)
        {
            string bookmarks = "";

            foreach (string file in lines)
                if (file.EndsWith(".url"))
                    bookmarks += file.Replace(".url", "") + "\r\n";

            return bookmarks.TrimEnd("\r\n".ToCharArray());
        }

        private string GetAtIndex(RichTextBox RTB, int index)
        {
            string text = RTB.Text;
            int ind = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (i == index)
                    return text.Split('\n')[ind].Replace("\r", "");

                if (text[i] == '\n')
                    ind++;
            }

            return null;
        }

        private void textBoxList_MouseUp(object sender, MouseEventArgs e)
        {
            string line = GetAtIndex(textBoxList, textBoxList.SelectionStart);
            Shortcut.Remove(line, Constants.ShortcutsFolder);
            UpdateList();
            Parent.Display();
        }

        private void textBoxList_MouseMove(object sender, MouseEventArgs e)
        {
            this.Focus();
        }

        private void RemoveShortcutForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme) 
            { 
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                this.textBoxList.BackColor = Color.FromArgb(51, 78, 108);
                this.textBoxList.ForeColor = Color.Bisque;
                this.textBoxList.BorderStyle = BorderStyle.None;
            }
        }
    }
}
