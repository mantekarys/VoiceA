
namespace VoiceAssistant
{
    partial class ShortcutBookmarkListForm
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
            this.labelShortcuts = new System.Windows.Forms.Label();
            this.labelBookmarks = new System.Windows.Forms.Label();
            this.labelVerticalLine = new System.Windows.Forms.Label();
            this.labelAddShortcut = new System.Windows.Forms.Label();
            this.labelRemoveShortcut = new System.Windows.Forms.Label();
            this.labelRemoveBookmark = new System.Windows.Forms.Label();
            this.labelAddBookmark = new System.Windows.Forms.Label();
            this.textBoxShortcuts = new System.Windows.Forms.RichTextBox();
            this.textBoxBookmarks = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShortcuts
            // 
            this.labelShortcuts.AutoSize = true;
            this.labelShortcuts.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortcuts.Location = new System.Drawing.Point(60, 20);
            this.labelShortcuts.Name = "labelShortcuts";
            this.labelShortcuts.Size = new System.Drawing.Size(88, 22);
            this.labelShortcuts.TabIndex = 0;
            this.labelShortcuts.Text = "Shortcuts";
            // 
            // labelBookmarks
            // 
            this.labelBookmarks.AutoSize = true;
            this.labelBookmarks.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookmarks.Location = new System.Drawing.Point(268, 20);
            this.labelBookmarks.Name = "labelBookmarks";
            this.labelBookmarks.Size = new System.Drawing.Size(106, 22);
            this.labelBookmarks.TabIndex = 1;
            this.labelBookmarks.Text = "Bookmarks";
            // 
            // labelVerticalLine
            // 
            this.labelVerticalLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVerticalLine.Location = new System.Drawing.Point(208, 20);
            this.labelVerticalLine.Name = "labelVerticalLine";
            this.labelVerticalLine.Size = new System.Drawing.Size(1, 480);
            this.labelVerticalLine.TabIndex = 2;
            // 
            // labelAddShortcut
            // 
            this.labelAddShortcut.AutoSize = true;
            this.labelAddShortcut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddShortcut.Location = new System.Drawing.Point(26, 478);
            this.labelAddShortcut.Name = "labelAddShortcut";
            this.labelAddShortcut.Size = new System.Drawing.Size(21, 22);
            this.labelAddShortcut.TabIndex = 5;
            this.labelAddShortcut.Text = "+";
            this.labelAddShortcut.Click += new System.EventHandler(this.labelAddShortcut_Click);
            // 
            // labelRemoveShortcut
            // 
            this.labelRemoveShortcut.AutoSize = true;
            this.labelRemoveShortcut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveShortcut.Location = new System.Drawing.Point(53, 478);
            this.labelRemoveShortcut.Name = "labelRemoveShortcut";
            this.labelRemoveShortcut.Size = new System.Drawing.Size(16, 22);
            this.labelRemoveShortcut.TabIndex = 6;
            this.labelRemoveShortcut.Text = "-";
            this.labelRemoveShortcut.Click += new System.EventHandler(this.labelRemoveShortcut_Click);
            // 
            // labelRemoveBookmark
            // 
            this.labelRemoveBookmark.AutoSize = true;
            this.labelRemoveBookmark.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveBookmark.Location = new System.Drawing.Point(261, 478);
            this.labelRemoveBookmark.Name = "labelRemoveBookmark";
            this.labelRemoveBookmark.Size = new System.Drawing.Size(16, 22);
            this.labelRemoveBookmark.TabIndex = 8;
            this.labelRemoveBookmark.Text = "-";
            this.labelRemoveBookmark.Click += new System.EventHandler(this.labelRemoveBookmark_Click);
            // 
            // labelAddBookmark
            // 
            this.labelAddBookmark.AutoSize = true;
            this.labelAddBookmark.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBookmark.Location = new System.Drawing.Point(234, 478);
            this.labelAddBookmark.Name = "labelAddBookmark";
            this.labelAddBookmark.Size = new System.Drawing.Size(21, 22);
            this.labelAddBookmark.TabIndex = 7;
            this.labelAddBookmark.Text = "+";
            this.labelAddBookmark.Click += new System.EventHandler(this.labelAddBookmark_Click);
            // 
            // textBoxShortcuts
            // 
            this.textBoxShortcuts.Location = new System.Drawing.Point(30, 60);
            this.textBoxShortcuts.Name = "textBoxShortcuts";
            this.textBoxShortcuts.ReadOnly = true;
            this.textBoxShortcuts.Size = new System.Drawing.Size(148, 400);
            this.textBoxShortcuts.TabIndex = 9;
            this.textBoxShortcuts.Text = "";
            this.textBoxShortcuts.WordWrap = false;
            this.textBoxShortcuts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxShortcuts_MouseMove);
            this.textBoxShortcuts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxShortcuts_MouseUp);
            // 
            // textBoxBookmarks
            // 
            this.textBoxBookmarks.Location = new System.Drawing.Point(238, 60);
            this.textBoxBookmarks.Name = "textBoxBookmarks";
            this.textBoxBookmarks.ReadOnly = true;
            this.textBoxBookmarks.Size = new System.Drawing.Size(148, 400);
            this.textBoxBookmarks.TabIndex = 10;
            this.textBoxBookmarks.Text = "";
            this.textBoxBookmarks.WordWrap = false;
            this.textBoxBookmarks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxBookmarks_MouseMove);
            this.textBoxBookmarks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxBookmarks_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VoiceAssistant.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(364, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ShortcutBookmarkListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxBookmarks);
            this.Controls.Add(this.textBoxShortcuts);
            this.Controls.Add(this.labelRemoveBookmark);
            this.Controls.Add(this.labelAddBookmark);
            this.Controls.Add(this.labelRemoveShortcut);
            this.Controls.Add(this.labelAddShortcut);
            this.Controls.Add(this.labelVerticalLine);
            this.Controls.Add(this.labelBookmarks);
            this.Controls.Add(this.labelShortcuts);
            this.MaximumSize = new System.Drawing.Size(434, 560);
            this.MinimumSize = new System.Drawing.Size(434, 560);
            this.Name = "ShortcutBookmarkListForm";
            this.ShowIcon = false;
            this.Text = "Shortcut & Bookmark";
            this.Load += new System.EventHandler(this.ShortcutBookmarkListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShortcuts;
        private System.Windows.Forms.Label labelBookmarks;
        private System.Windows.Forms.Label labelVerticalLine;
        private System.Windows.Forms.Label labelAddShortcut;
        private System.Windows.Forms.Label labelRemoveShortcut;
        private System.Windows.Forms.Label labelRemoveBookmark;
        private System.Windows.Forms.Label labelAddBookmark;
        private System.Windows.Forms.RichTextBox textBoxShortcuts;
        private System.Windows.Forms.RichTextBox textBoxBookmarks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}