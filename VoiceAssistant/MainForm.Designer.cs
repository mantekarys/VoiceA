
namespace VoiceAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CommandFolder = new System.Windows.Forms.Button();
            this.CommandList = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.buttonShortcuts = new System.Windows.Forms.Button();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.SettingsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBoxActivationKey = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DisplayTable = new System.Windows.Forms.TableLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ControlPanel.SuspendLayout();
            this.DisplayPanel.SuspendLayout();
            this.SettingsTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandFolder
            // 
            this.CommandFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CommandFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandFolder.Location = new System.Drawing.Point(0, 4);
            this.CommandFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommandFolder.Name = "CommandFolder";
            this.CommandFolder.Size = new System.Drawing.Size(219, 30);
            this.CommandFolder.TabIndex = 0;
            this.CommandFolder.Text = "Command folder";
            this.CommandFolder.UseVisualStyleBackColor = false;
            this.CommandFolder.Click += new System.EventHandler(this.CommandFolder_Click);
            // 
            // CommandList
            // 
            this.CommandList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CommandList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandList.Location = new System.Drawing.Point(0, 41);
            this.CommandList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommandList.Name = "CommandList";
            this.CommandList.Size = new System.Drawing.Size(219, 30);
            this.CommandList.TabIndex = 1;
            this.CommandList.Text = "Command list";
            this.CommandList.UseVisualStyleBackColor = false;
            this.CommandList.Click += new System.EventHandler(this.CommandList_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Location = new System.Drawing.Point(0, 78);
            this.Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(219, 30);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlPanel.Controls.Add(this.buttonShortcuts);
            this.ControlPanel.Controls.Add(this.Settings);
            this.ControlPanel.Controls.Add(this.CommandList);
            this.ControlPanel.Controls.Add(this.CommandFolder);
            this.ControlPanel.Location = new System.Drawing.Point(4, 4);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(219, 585);
            this.ControlPanel.TabIndex = 4;
            // 
            // buttonShortcuts
            // 
            this.buttonShortcuts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShortcuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShortcuts.Location = new System.Drawing.Point(1, 113);
            this.buttonShortcuts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShortcuts.Name = "buttonShortcuts";
            this.buttonShortcuts.Size = new System.Drawing.Size(215, 31);
            this.buttonShortcuts.TabIndex = 4;
            this.buttonShortcuts.Text = "Shortcuts";
            this.buttonShortcuts.UseVisualStyleBackColor = false;
            this.buttonShortcuts.Click += new System.EventHandler(this.buttonShortcuts_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPanel.AutoScroll = true;
            this.DisplayPanel.Controls.Add(this.SettingsTablePanel);
            this.DisplayPanel.Controls.Add(this.DisplayTable);
            this.DisplayPanel.Location = new System.Drawing.Point(229, 4);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(543, 580);
            this.DisplayPanel.TabIndex = 5;
            this.DisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayPanel_Paint);
            // 
            // SettingsTablePanel
            // 
            this.SettingsTablePanel.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.SettingsTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsTablePanel.ColumnCount = 2;
            this.SettingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTablePanel.Controls.Add(this.label1, 0, 0);
            this.SettingsTablePanel.Controls.Add(this.label2, 0, 1);
            this.SettingsTablePanel.Controls.Add(this.SaveButton, 1, 2);
            this.SettingsTablePanel.Controls.Add(this.textBoxActivationKey, 1, 1);
            this.SettingsTablePanel.Controls.Add(this.checkBox1, 1, 0);
            this.SettingsTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTablePanel.Location = new System.Drawing.Point(0, 25);
            this.SettingsTablePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsTablePanel.Name = "SettingsTablePanel";
            this.SettingsTablePanel.RowCount = 3;
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.SettingsTablePanel.Size = new System.Drawing.Size(543, 247);
            this.SettingsTablePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key Binding";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(274, 202);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 28);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBoxActivationKey
            // 
            this.textBoxActivationKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::VoiceAssistant.Properties.Settings.Default, "Keybind", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxActivationKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxActivationKey.Location = new System.Drawing.Point(274, 102);
            this.textBoxActivationKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxActivationKey.Name = "textBoxActivationKey";
            this.textBoxActivationKey.Size = new System.Drawing.Size(266, 22);
            this.textBoxActivationKey.TabIndex = 5;
            this.textBoxActivationKey.Text = global::VoiceAssistant.Properties.Settings.Default.Keybind;
            this.textBoxActivationKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxActivationKey_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::VoiceAssistant.Properties.Settings.Default.Theme;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::VoiceAssistant.Properties.Settings.Default, "Theme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(274, 2);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(266, 96);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DisplayTable
            // 
            this.DisplayTable.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.DisplayTable.AutoSize = true;
            this.DisplayTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisplayTable.BackColor = System.Drawing.Color.Transparent;
            this.DisplayTable.ColumnCount = 2;
            this.DisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.DisplayTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayTable.Location = new System.Drawing.Point(0, 0);
            this.DisplayTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayTable.Name = "DisplayTable";
            this.DisplayTable.RowCount = 1;
            this.DisplayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DisplayTable.Size = new System.Drawing.Size(543, 25);
            this.DisplayTable.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "You can find the VoiceAssistant in the hidden icons";
            this.notifyIcon1.BalloonTipTitle = "VoiceAssistent";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon12";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(779, 590);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.ControlPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(650, 516);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowIcon = false;
            this.Text = "DigitalAssistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControlPanel.ResumeLayout(false);
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayPanel.PerformLayout();
            this.SettingsTablePanel.ResumeLayout(false);
            this.SettingsTablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CommandFolder;
        private System.Windows.Forms.Button CommandList;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonShortcuts;
        private System.Windows.Forms.TableLayoutPanel DisplayTable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel SettingsTablePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBoxActivationKey;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

