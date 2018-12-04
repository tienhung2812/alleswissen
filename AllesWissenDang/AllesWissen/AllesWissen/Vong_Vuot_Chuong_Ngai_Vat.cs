using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllesWissen
{
    public partial class Vong_Vuot_Chuong_Ngai_Vat : Form
    {
        private int time = 60;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Vong_Vuot_Chuong_Ngai_Vat()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // run down
            int timerun = 600;
            timerun--;
            pbTimer.PerformStep();

            if (timerun == 0)
            {
                timer1.Stop();
                timerun = 60;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Set up timer
            pbTimer.Maximum = time * 100;
            pbTimer.Step = -10;
            pbTimer.Value = pbTimer.Maximum;
            
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
           
            //----------------------------------------//

            // Set up Mp3 

            player.URL = @"KD - 60 giay.mp3";
            player.controls.play();
        }

        private void Vong_Vuot_Chuong_Ngai_Vat_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
        }
    }
}
