using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vong_ve_dich_trinh_chieu
{
    public partial class team2 : Form
    {
        int pack = 60;
        bool Start = true;
        int n = -1;
        int count = 0;
        string[] quest = new string[3];
        Bitmap bmp;
        bool is_star = true;
        bool is_next = false;
        int team = 2;
        int bell = 1;
        int i = 0;
        public team2()
        {
            InitializeComponent();
            _m_which_team();
            _m_which_pack();
            _m_reset_count_down();

            if (Start == true)
            {
                timer2.Enabled = true;
            }
            if (is_star == true)
            {
                _m_ngoi_sao_hy_vong();
                timer3.Enabled = true;
            }

            //if (is_next == true) ;
        }
        public void _m_which_team()
        {
            if (team == 1)
            {
                team_1.BackColor = Question.BackColor;
                team_2.BackColor = Color.FromName("ActiveBorder");
                team_3.BackColor = Color.FromName("ActiveBorder");
                team_1.Text = "Team 1";
                team_2.Text = "Team 2";
                team_3.Text = "Team 3";
                if (bell == 2)
                {
                    Status_2.BlinkingEnable = true;
                }
                else if (bell == 3)
                {
                    Status_3.BlinkingEnable = true;
                }
            }
            else if (team == 2)
            {
                team_2.BackColor = Question.BackColor;
                team_1.BackColor = Color.FromName("ActiveBorder");
                team_3.BackColor = Color.FromName("ActiveBorder");
                team_1.Text = "Team 1";
                team_2.Text = "Team 2";
                team_3.Text = "Team 3";
                if (bell == 1)
                {
                    Status_1.BlinkingEnable = true;
                }
                else if (bell == 3)
                {
                    Status_3.BlinkingEnable = true;
                }
            }
            else if (team == 3)
            {
                team_3.BackColor = Question.BackColor;
                team_2.BackColor = Color.FromName("ActiveBorder");
                team_1.BackColor = Color.FromName("ActiveBorder");
                team_1.Text = "Team 1";
                team_2.Text = "Team 2";
                team_3.Text = "Team 3";
                if (bell == 2)
                {
                    Status_2.BlinkingEnable = true;
                }
                else if (bell == 1)
                {
                    Status_3.BlinkingEnable = true;
                }
            }
        }
        public void _m_which_pack()
        {

            if (pack == 40)
            {
                Pack.Text = "40";
            }
            else if (pack == 60)
            {
                Pack.Text = "60";
            }
            else if (pack == 80)
            {
                Pack.Text = "80";
            }
            pack_40.Visible = false;
            pack_60.Visible = false;
            pack_80.Visible = false;
        }

        private void _m_reset_count_down()
        {

            if (pack == 40)
            {
                if (count == 0) Count_down_clock.Text = "10";
                if (count == 1) Count_down_clock.Text = "10";
                if (count == 2) Count_down_clock.Text = "15";
            }
            if (pack == 60)
            {
                if (count == 0) Count_down_clock.Text = "10";
                if (count == 1) Count_down_clock.Text = "15";
                if (count == 2) Count_down_clock.Text = "20";
            }
            if (pack == 80)
            {
                if (count == 0) Count_down_clock.Text = "15";
                if (count == 1) Count_down_clock.Text = "20";
                if (count == 2) Count_down_clock.Text = "20";
            }
        }// Reset đồng hồ đếm ngược
        private void _m_reset_timer1()
        {
            timer1.Enabled = true;
        }// Reset timer1 

        private void _m_ngoi_sao_hy_vong()
        {
            bmp = (Bitmap)Bitmap.FromFile(@"C:\Users\eeit2\Documents\Visual Studio 2013\Projects\AW\Vong_ve_dich_trinh_chieu\pic\mini_star.gif");
            Star.SizeMode = PictureBoxSizeMode.StretchImage;
            Star.Image = bmp;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Star.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Count_down_clock.Text = (UInt32.Parse(Count_down_clock.Text) - 1).ToString();
            if (Count_down_clock.Text == "0")
            {
                timer1.Enabled = false;
                count += 1;
                _m_reset_count_down();
                timer2.Enabled = true;
                if (count > 2)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    Count_down_clock.Text = "0";
                    this.Hide();
                    team3 team3 = new team3();
                    team3.Show();
                    team3.Activate();
                }

            }//Ngắt timer1 khởi động timer2
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Question.Text = quest[count];
            n += 1;
            if (n == 5)
            {
                timer2.Enabled = false;
                _m_reset_timer1();
                n = 0;
            }
        }
    }
}

