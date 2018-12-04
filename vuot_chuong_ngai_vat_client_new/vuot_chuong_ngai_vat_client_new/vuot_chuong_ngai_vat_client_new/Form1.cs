using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vuot_chuong_ngai_vat_client_new
{
    public partial class Form1 : Form
    {
        UInt32 time;
        bool is_start = true;
        string answer;
        bool is_question = true;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Bell.BackColor = Color.Red;
            Submit.BackColor = Color.Blue;
            Bell.ForeColor = Color.Yellow;
            Submit.ForeColor = Color.Yellow;
            timer2.Start();
        }

        private void Bell_Click(object sender, EventArgs e)
        {
            Bell.BackColor = Color.DarkRed;
            timer1.Stop();
        }
        private void Submit_click(object sender, EventArgs e)
        {
            time = UInt32.Parse(Count_down.Text);
            Submit.BackColor = Color.Blue;
            answer = Answer.Text;
            MessageBox.Show("You just submited!");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Count_down.Text = (UInt32.Parse(Count_down.Text) - 1).ToString();
            
            Count_down.Value -= 100 / 15;
            if (Count_down.Text == "0")
            {
                timer1.Stop();
                Count_down.Value = 0;
                count += 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(is_start == true)
            {
                Count_down.Text = "15";
                Count_down.Value = 100;
                timer1.Start();
                is_start = false;
            }
            if(is_question == true)
            {
                Question.Text = "Bunny~~";
                is_question = false;
            }
        }

        

        
    }
}
