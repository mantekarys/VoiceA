
namespace VoiceAssistant
{
    partial class Stopwatch
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
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.ControlButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.Location = new System.Drawing.Point(100, 31);
            this.DisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(800, 185);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "00:00:00";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisplayLabel.Click += new System.EventHandler(this.DisplayLabel_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlButton.Location = new System.Drawing.Point(225, 246);
            this.ControlButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(173, 62);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "Start";
            this.ControlButton.UseVisualStyleBackColor = false;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(589, 246);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(173, 62);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Stop";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 372);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.DisplayLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(994, 419);
            this.MinimumSize = new System.Drawing.Size(994, 419);
            this.Name = "Stopwatch";
            this.ShowIcon = false;
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Stopwatch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Timer timer1;
    }
}