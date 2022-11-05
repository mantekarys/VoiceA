
namespace VoiceAssistant
{
    partial class ConverterForm
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
            this.ConvertingLabel = new System.Windows.Forms.Label();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.InputFromTxtBox = new System.Windows.Forms.TextBox();
            this.InputToTxtBox = new System.Windows.Forms.TextBox();
            this.FirstValComboBox = new System.Windows.Forms.ComboBox();
            this.SecondValComboBox = new System.Windows.Forms.ComboBox();
            this.Coverting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConvertingLabel
            // 
            this.ConvertingLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertingLabel.Location = new System.Drawing.Point(84, 43);
            this.ConvertingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConvertingLabel.Name = "ConvertingLabel";
            this.ConvertingLabel.Size = new System.Drawing.Size(192, 49);
            this.ConvertingLabel.TabIndex = 0;
            this.ConvertingLabel.Text = "Converting:";
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitComboBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Items.AddRange(new object[] {
            "Time",
            "Distance",
            "Mass",
            "Temperature",
            "Currency"});
            this.UnitComboBox.Location = new System.Drawing.Point(284, 43);
            this.UnitComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(223, 47);
            this.UnitComboBox.TabIndex = 1;
            this.UnitComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // InputFromTxtBox
            // 
            this.InputFromTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.InputFromTxtBox.Location = new System.Drawing.Point(56, 187);
            this.InputFromTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputFromTxtBox.MaxLength = 12;
            this.InputFromTxtBox.Name = "InputFromTxtBox";
            this.InputFromTxtBox.ReadOnly = true;
            this.InputFromTxtBox.Size = new System.Drawing.Size(391, 46);
            this.InputFromTxtBox.TabIndex = 2;
            this.InputFromTxtBox.TextChanged += new System.EventHandler(this.InputFromTxtBox_TextChanged);
            // 
            // InputToTxtBox
            // 
            this.InputToTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.InputToTxtBox.Location = new System.Drawing.Point(56, 413);
            this.InputToTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputToTxtBox.Name = "InputToTxtBox";
            this.InputToTxtBox.ReadOnly = true;
            this.InputToTxtBox.Size = new System.Drawing.Size(391, 46);
            this.InputToTxtBox.TabIndex = 3;
            // 
            // FirstValComboBox
            // 
            this.FirstValComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstValComboBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstValComboBox.FormattingEnabled = true;
            this.FirstValComboBox.IntegralHeight = false;
            this.FirstValComboBox.Location = new System.Drawing.Point(539, 187);
            this.FirstValComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstValComboBox.Name = "FirstValComboBox";
            this.FirstValComboBox.Size = new System.Drawing.Size(223, 47);
            this.FirstValComboBox.TabIndex = 4;
            this.FirstValComboBox.SelectedIndexChanged += new System.EventHandler(this.FirstValComboBox_SelectedIndexChanged);
            // 
            // SecondValComboBox
            // 
            this.SecondValComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondValComboBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondValComboBox.FormattingEnabled = true;
            this.SecondValComboBox.IntegralHeight = false;
            this.SecondValComboBox.Location = new System.Drawing.Point(539, 413);
            this.SecondValComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondValComboBox.Name = "SecondValComboBox";
            this.SecondValComboBox.Size = new System.Drawing.Size(223, 47);
            this.SecondValComboBox.TabIndex = 5;
            this.SecondValComboBox.SelectedIndexChanged += new System.EventHandler(this.SecondValComboBox_SelectedIndexChanged);
            // 
            // Coverting
            // 
            this.Coverting.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coverting.Location = new System.Drawing.Point(372, 304);
            this.Coverting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Coverting.Name = "Coverting";
            this.Coverting.Size = new System.Drawing.Size(240, 42);
            this.Coverting.TabIndex = 6;
            this.Coverting.Text = "To";
            this.Coverting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.Coverting);
            this.Controls.Add(this.SecondValComboBox);
            this.Controls.Add(this.FirstValComboBox);
            this.Controls.Add(this.InputToTxtBox);
            this.Controls.Add(this.InputFromTxtBox);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.ConvertingLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(861, 605);
            this.MinimumSize = new System.Drawing.Size(861, 605);
            this.Name = "ConverterForm";
            this.Text = "ConverterForm";
            this.Load += new System.EventHandler(this.ConverterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConvertingLabel;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.TextBox InputFromTxtBox;
        private System.Windows.Forms.TextBox InputToTxtBox;
        private System.Windows.Forms.ComboBox FirstValComboBox;
        private System.Windows.Forms.ComboBox SecondValComboBox;
        private System.Windows.Forms.Label Coverting;
    }
}