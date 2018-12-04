using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vong_ve_dich_client
{
    public partial class Form1 : Form
    {
        string quest;
        int team = 1;
        bool is_run = true;
        bool is_next = false;
        int[] score_vong_ve_dich = new int[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Bell_Click(object sender, EventArgs e)
        {
            Bell.BackColor = Color.DarkRed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Countdown.Text = (UInt32.Parse(Countdown.Text) - 1).ToString();
            Countdown.Value -= Countdown.Maximum / 15;
            if(Countdown.Value == 0)
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Countdown.Text = "15";
            Countdown.Value = 1500;
            Bell.BackColor = Color.Red;
            Bell.ForeColor = Color.Yellow;
            timer2.Start();
        }
        private void re_fill()
        {
            Countdown.Text = "15";
            Countdown.Value = 1500;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(is_run == true)
            {
                timer1.Start();
                is_run = false;
            }
            if(is_next == true)
            {
                re_fill();
            }

        }

        
    }
}
