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
    public partial class Vedich : Form
    {
        int pack = 40;
        bool Start = true;
        int count = 0;
        string[] quest = new string[3];
        Bitmap bmp;
        bool is_star = true;
        bool is_next = true;
        int team = 1;
        int bell = 2;
        bool is_next_team = false;
        public Vedich()
        {
            InitializeComponent();
        }
        private void team1_Load(object sender, EventArgs e)
        {
            _m_which_team();
            _m_which_pack();
            _m_reset_count_down();
            timer2.Enabled = true;
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
                    Status_1.BlinkingEnable = false;
                    Status_1.BackColor = Color.FromName("Control");
                    Status_3.BlinkingEnable = false;
                    Status_3.BackColor = Color.FromName("Control");
                }
                else if (bell == 3)
                {
                    Status_3.BlinkingEnable = true;
                    Status_1.BlinkingEnable = false;
                    Status_1.BackColor = Color.FromName("Control");
                    Status_2.BlinkingEnable = false;
                    Status_2.BackColor = Color.FromName("Control");
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
                    Status_2.BlinkingEnable = false;
                    Status_2.BackColor = Color.FromName("Control");
                    Status_3.BlinkingEnable = false;
                    Status_3.BackColor = Color.FromName("Control");
                }
                else if (bell == 3)
                {
                    Status_3.BlinkingEnable = true;
                    Status_1.BlinkingEnable = false;
                    Status_2.BlinkingEnable = false;
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
                    Status_1.BlinkingEnable = false;
                    Status_3.BlinkingEnable = false;
                }
                else if (bell == 1)
                {
                    Status_1.BlinkingEnable = true;
                    Status_2.BlinkingEnable = false;
                    Status_3.BlinkingEnable = false;
                }
            }
        }
        public void _m_which_pack()
        {
           
            if( pack == 40)
            {
                Pack.Text = "40";
            }
            else if(pack == 60)
            {
                Pack.Text = "60";
            }
            else if(pack == 80)
            {
                Pack.Text = "80";
            }
            pack_40.Visible = false;
            pack_60.Visible = false;
            pack_80.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Count_down_clock.Text = (UInt32.Parse(Count_down_clock.Text) - 1).ToString();
            Count_down.Value = Int32.Parse(Count_down_clock.Text);
            if (Count_down_clock.Text == "0")
            {
                timer1.Enabled = false;
            }
            if (is_star == true)
            {
                _m_ngoi_sao_hy_vong();
                timer3.Enabled = true;
            }

        }
        private void _m_reset_count_down()
        {
            
            if(pack == 40)
            {
                if (count == 0)
                { 
                    Count_down_clock.Text = "10";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
                if (count == 1)
                {
                    Count_down_clock.Text = "10";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
                if (count == 2)
                { 
                    Count_down_clock.Text = "15";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
            }
            if (pack == 60)
            {
                if (count == 0)
                {
                    Count_down_clock.Text = "10";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
                if (count == 1)
                { 
                    Count_down_clock.Text = "15";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
                if (count == 2)
                {
                    Count_down_clock.Text = "20";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
            }
            if (pack == 80)
            {
                if (count == 0) 
                { 
                    Count_down_clock.Text = "15";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
                if (count == 1) 
                { 
                    Count_down_clock.Text = "20";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
                if (count == 2) 
                { 
                    Count_down_clock.Text = "20";
                    Count_down.Value = Count_down.Maximum = Int32.Parse(Count_down_clock.Text);
                }
            }
        }// Reset đồng hồ đếm ngược 
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

        private void _m_next_team()
        {
            count = 0;
            team += 1;
            pack = 60; 
            bell = 1;
            _m_which_team();
            _m_which_pack();
            _m_reset_count_down();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Start == true)
            {
                timer1.Enabled = true;
            }
            if ((Count_down_clock.Text == "0") && (is_next == true))
            {
                count += 1;
                if ((count > 2) && (Count_down_clock.Text == "0"))
                {
                    timer1.Enabled = false;
                    if (is_next_team == true) _m_next_team();
                }
                _m_reset_count_down();
                timer1.Enabled = true;
                //is_next = false;
            }
        }

        
 
    }


        public class BlinkingLabel : Label
        {
            Timer timer;
            public BlinkingLabel()
            {
                timer = new Timer();
                this.FisrtColor = Color.FromName("Control");
                this.timer.Tick += new System.EventHandler(timer_Tick);
            }
            void timer_Tick(object sender, System.EventArgs e)
            {
                if (this.BackColor == this.FisrtColor)
                {
                    this.BackColor = this.SecondColor;
                }

                else this.BackColor = this.FisrtColor;

            }
            [Category("Blinking label setting")]
            public Color FisrtColor { get; set; }
            [Category("Blinking label setting")]
            public Color SecondColor { get; set; }
            [Category("Blinking label setting")]
            public int Interval
            {
                get { return this.timer.Interval; }
                set { this.timer.Interval = value; }
            }
            [Category("Blinking label setting")]
            public bool BlinkingEnable
            {
                get { return this.timer.Enabled; }
                set { this.timer.Enabled = value; }
            }
        } // Status label
    
}

