using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{


    public partial class Overlay : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private Voice voice;
        List<Alarm> alarms;
        public Overlay(List<Alarm> alarms)
        {
            this.alarms = alarms;
            InitializeComponent();
            
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            this.TopMost = true;
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            voice = new Voice();
            voice.AddAlarms(alarms);
            voice.ChangeImage += this.OnChangeImage;
        }

        public void OnChangeImage(object source, OverlayEventArg e)
        {
            if(e.active)
                this.PictureBox.Image = global::VoiceAssistant.Properties.Resources.MicGreen;

            Task.Factory.StartNew(() =>
            {
                Task.Delay(3000).Wait();
                this.PictureBox.Image = global::VoiceAssistant.Properties.Resources.MicBlack;
            });
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

