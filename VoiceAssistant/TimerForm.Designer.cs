
namespace VoiceAssistant
{
    partial class TimerForm
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
            this.HourComboBox = new System.Windows.Forms.ComboBox();
            this.HoursLabels = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.MinuteComboBox = new System.Windows.Forms.ComboBox();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SecondComboBox = new System.Windows.Forms.ComboBox();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.ControlButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HourComboBox
            // 
            this.HourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourComboBox.FormattingEnabled = true;
            this.HourComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HourComboBox.Location = new System.Drawing.Point(68, 29);
            this.HourComboBox.Name = "HourComboBox";
            this.HourComboBox.Size = new System.Drawing.Size(129, 21);
            this.HourComboBox.TabIndex = 0;
            this.HourComboBox.SelectedIndexChanged += new System.EventHandler(this.HourComboBox_SelectedIndexChanged);
            // 
            // HoursLabels
            // 
            this.HoursLabels.Location = new System.Drawing.Point(203, 29);
            this.HoursLabels.Name = "HoursLabels";
            this.HoursLabels.Size = new System.Drawing.Size(58, 21);
            this.HoursLabels.TabIndex = 1;
            this.HoursLabels.Text = "hours";
            this.HoursLabels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.Location = new System.Drawing.Point(402, 29);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(58, 21);
            this.MinutesLabel.TabIndex = 3;
            this.MinutesLabel.Text = "minutes";
            this.MinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinuteComboBox
            // 
            this.MinuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinuteComboBox.FormattingEnabled = true;
            this.MinuteComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinuteComboBox.Location = new System.Drawing.Point(267, 29);
            this.MinuteComboBox.Name = "MinuteComboBox";
            this.MinuteComboBox.Size = new System.Drawing.Size(129, 21);
            this.MinuteComboBox.TabIndex = 2;
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.Location = new System.Drawing.Point(601, 29);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(58, 21);
            this.SecondsLabel.TabIndex = 5;
            this.SecondsLabel.Text = "seconds";
            this.SecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondComboBox
            // 
            this.SecondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondComboBox.FormattingEnabled = true;
            this.SecondComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.SecondComboBox.Location = new System.Drawing.Point(466, 29);
            this.SecondComboBox.Name = "SecondComboBox";
            this.SecondComboBox.Size = new System.Drawing.Size(129, 21);
            this.SecondComboBox.TabIndex = 4;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.Location = new System.Drawing.Point(65, 70);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(600, 115);
            this.DisplayLabel.TabIndex = 6;
            this.DisplayLabel.Text = "00:00:00";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlButton
            // 
            this.ControlButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlButton.Location = new System.Drawing.Point(126, 244);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(135, 43);
            this.ControlButton.TabIndex = 7;
            this.ControlButton.Text = "Start";
            this.ControlButton.UseVisualStyleBackColor = false;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(460, 244);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(135, 43);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 310);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.SecondComboBox);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.MinuteComboBox);
            this.Controls.Add(this.HoursLabels);
            this.Controls.Add(this.HourComboBox);
            this.MaximumSize = new System.Drawing.Size(750, 349);
            this.MinimumSize = new System.Drawing.Size(750, 349);
            this.Name = "TimerForm";
            this.Text = "TimerForm";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox HourComboBox;
        private System.Windows.Forms.Label HoursLabels;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.ComboBox MinuteComboBox;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.ComboBox SecondComboBox;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer timer1;
    }
}