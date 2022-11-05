using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 current = this;
            current.AutoScroll = true;
            Button b1 = new Button();
            //current.Controls.Add(b1);
            b1.Height = 50;
            b1.Location = new Point(200, 700);
            current.Controls.Add(b1);
            if(b1.)
        }
    }
}
