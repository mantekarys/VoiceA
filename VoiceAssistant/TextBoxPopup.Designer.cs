
namespace VoiceAssistant
{
    partial class TextBoxPopup
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
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.ConfirmationButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.Location = new System.Drawing.Point(0, 0);
            this.NotificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(713, 100);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "Failas bus įvardintas kaip:";
            this.NotificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationLabel.Click += new System.EventHandler(this.NotificationLabel_Click);
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.AcceptsReturn = true;
            this.InputTxtBox.Location = new System.Drawing.Point(16, 117);
            this.InputTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTxtBox.Multiline = true;
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputTxtBox.Size = new System.Drawing.Size(713, 153);
            this.InputTxtBox.TabIndex = 1;
            // 
            // ConfirmationButton
            // 
            this.ConfirmationButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmationButton.Location = new System.Drawing.Point(631, 293);
            this.ConfirmationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmationButton.Name = "ConfirmationButton";
            this.ConfirmationButton.Size = new System.Drawing.Size(100, 37);
            this.ConfirmationButton.TabIndex = 2;
            this.ConfirmationButton.Text = "Ok";
            this.ConfirmationButton.UseVisualStyleBackColor = false;
            this.ConfirmationButton.Click += new System.EventHandler(this.ConfirmationButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NotificationLabel);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 100);
            this.panel1.TabIndex = 3;
            // 
            // TextBoxPopup
            // 
            this.AcceptButton = this.ConfirmationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmationButton);
            this.Controls.Add(this.InputTxtBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(766, 382);
            this.MinimumSize = new System.Drawing.Size(766, 382);
            this.Name = "TextBoxPopup";
            this.ShowIcon = false;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.TextBoxPopup_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.Button ConfirmationButton;
        private System.Windows.Forms.Panel panel1;
    }
}