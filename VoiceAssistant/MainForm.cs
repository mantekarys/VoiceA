using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using System.Threading;
using System.Reflection;
using System.Configuration;
using System.Collections.Specialized;
using Gma.System.MouseKeyHook;

namespace VoiceAssistant
{
    public partial class MainForm : Form
    {
        Overlay overlayDislay;
        private List<Alarm> alarms;
        public MainForm()
        {
            InitializeComponent();

            notifyIcon1.Visible = false;

            notifyIcon1.ContextMenu = new System.Windows.Forms.ContextMenu();
            var menuItem1 = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            notifyIcon1.ContextMenu.MenuItems.AddRange(
                        new System.Windows.Forms.MenuItem[] { menuItem1 });

            // Initialize menuItem1
            menuItem1.Index = 0;
            menuItem1.Text = "E&xit";
            menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            Setup();

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            alarms = Alarm.ReadFile(@"Alarms.txt");
            
            overlayDislay = new Overlay(alarms);
            ThemeApply();
            overlayDislay.Show();
            overlayDislay.ShowInTaskbar = false;
            DisplayTable.Hide();
            SettingsTablePanel.Hide();
            
        }

        private void CommandFolder_Click(object sender, EventArgs e)
        {
            DisplayTable.Hide();
            DisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            System.Diagnostics.Process.Start(@"Commands.txt");
        }

        private void CommandList_Click(object sender, EventArgs e)
        {            
            DisplayTable.Show();
            SettingsTablePanel.Hide();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            DisplayTable.Hide();
            SettingsTablePanel.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            notifyIcon1.Visible = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                Hide();
                notifyIcon1.Visible = true;

                notifyIcon1.ShowBalloonTip(6000);
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void buttonShortcuts_Click(object sender, EventArgs e)
        {
            DisplayTable.Hide();
            SettingsTablePanel.Hide();
            var shortcutForm = new ShortcutBookmarkListForm();
            shortcutForm.Show();
        }

        #region keybind code
        private string keys;
        private IKeyboardMouseEvents GlobalHook;
        ActivationKey.KeyType KeyT;

        private bool Active
        {
            get
            {
                return !textBoxActivationKey.Enabled;
            }
            set
            {
                textBoxActivationKey.Enabled = !value;
                SaveButton.Enabled = !value;
            }
        }

        private void Setup()
        {
            keys = "";
            Active = false;
            KeyT = ActivationKey.KeyType.Keyboard;
            GlobalHook = Hook.GlobalEvents();
            GlobalHook.MouseUp += GlobalHook_MouseUp;
            GlobalHook.KeyUp += GlobalHook_KeyUp;
        }

        private void GlobalHook_MouseUp(object sender, MouseEventArgs e)
        {
            if (Active)
            {
                if (keys == "")
                    keys = e.Button.ToString();

                KeyT = ActivationKey.KeyType.Mouse;
                UpdateText();
                Active = false;
            }
        }

        private void GlobalHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (Active)
            {
                if (keys == "")
                    keys = e.KeyData.ToString();

                KeyT = ActivationKey.KeyType.Keyboard;
                UpdateText();
                Active = false;
            }
        }

        private void UpdateText()
        {
            if (keys != null)
                textBoxActivationKey.Text = keys.Replace(",", " + ");
            else
                textBoxActivationKey.Text = "";
        }
        #endregion

        #region functional methods
        private void SettingsTableTheme()
        {
            if (Properties.Settings.Default.Theme)
            {
                SettingsTablePanel.BackColor = Color.FromArgb(36, 59, 83);
                SaveButton.BackColor = Color.FromArgb(51, 78, 108);
                SaveButton.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
            }
           

        }

        private void CreateCommandList()
        {
            while (DisplayTable.Controls.Count > 0)
            {
                DisplayTable.Controls[0].Dispose();
            }
            DisplayTable.Controls.Clear();
            DisplayTable.RowCount = 1;
            DisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            if (Properties.Settings.Default.Theme)
                DisplayTable.BackColor = Color.FromArgb(36, 59, 83);
            else
                DisplayTable.BackColor = Color.Azure;
            DisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            DisplayTable.Controls.Add(new Label() { Text = "Command" }, 0, 0);
            DisplayTable.Controls.Add(new Label() { Text = "Description" }, 1, 0);
            String[] commnadlines = File.ReadAllLines(@"Commands.txt");
            foreach (string line in commnadlines)
            {
                String[] parts = line.Split(';');
                DisplayTable.RowCount = DisplayTable.RowCount + 1;
                DisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                DisplayTable.Controls.Add(new Label() { Text = parts[0].ToString() }, 0, DisplayTable.RowCount - 1);
                DisplayTable.Controls.Add(new Label() { Text = parts[1].ToString() }, 1, DisplayTable.RowCount - 1);
            }
        }

        private void ThemeApply()
        {
            if (Properties.Settings.Default.Theme)
            {
                MainForm current = this;
                current.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
                CommandFolder.BackColor = Color.FromArgb(51, 78, 108);
                CommandFolder.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                CommandList.BackColor = Color.FromArgb(51, 78, 108);
                CommandList.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                Settings.BackColor = Color.FromArgb(51, 78, 108);
                Settings.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                buttonShortcuts.BackColor = Color.FromArgb(51, 78, 108);
                buttonShortcuts.FlatAppearance.BorderColor = Color.FromArgb(51, 78, 108);
                DisplayTable.BackColor = current.BackColor;
            }
            else
            {
                this.CommandFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.CommandList.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.Settings.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.buttonShortcuts.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.SettingsTablePanel.BackColor = Color.Azure;
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = Color.Black;
            }
            SettingsTableTheme();
            CreateCommandList();
        }
        #endregion

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = checkBox1.Checked;
            Properties.Settings.Default.Keybind = textBoxActivationKey.Text;
            Properties.Settings.Default.Save();
            ActivationKey.Set(keys);
            ActivationKey.SetType(KeyT);
            ThemeApply();
        }

        private void textBoxActivationKey_MouseUp(object sender, MouseEventArgs e)
        {          
            if (!Active)
            {
                keys = "";
                Active = true;
                UpdateText();
            }
    
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Alarm alarm in alarms)
            {
                if (alarm.Hour == DateTime.Now.Hour && alarm.Minute == DateTime.Now.Minute && alarm.Days[((int)DateTime.Now.DayOfWeek + 6) % 7] && alarm.Enabled)
                {
                    timer1.Enabled = false;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\alarm.wav");
                    player.Play();
                    DateTime time = DateTime.Now;
                    MessageBox.Show(String.Format("It's {0}:{1}", time.Hour.ToString("D2"), time.Minute.ToString("D2")));
                    await Task.Delay(60000);
                    timer1.Enabled = true;
                    break;
                }
            }
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
