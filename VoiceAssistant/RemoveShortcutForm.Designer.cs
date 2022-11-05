
namespace VoiceAssistant
{
    partial class RemoveShortcutForm
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
            this.labelSelect = new System.Windows.Forms.Label();
            this.textBoxList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.Location = new System.Drawing.Point(12, 9);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(144, 16);
            this.labelSelect.TabIndex = 0;
            this.labelSelect.Text = "Click shortcut to delete:";
            // 
            // textBoxList
            // 
            this.textBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxList.Location = new System.Drawing.Point(15, 28);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.ReadOnly = true;
            this.textBoxList.Size = new System.Drawing.Size(141, 369);
            this.textBoxList.TabIndex = 1;
            this.textBoxList.Text = "";
            this.textBoxList.WordWrap = false;
            this.textBoxList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxList_MouseMove);
            this.textBoxList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxList_MouseUp);
            // 
            // RemoveShortcutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 409);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.labelSelect);
            this.MaximumSize = new System.Drawing.Size(191, 448);
            this.MinimumSize = new System.Drawing.Size(191, 448);
            this.Name = "RemoveShortcutForm";
            this.ShowIcon = false;
            this.Text = "Remove a shortcut";
            this.Load += new System.EventHandler(this.RemoveShortcutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.RichTextBox textBoxList;
    }
}