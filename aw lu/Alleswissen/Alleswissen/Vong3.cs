﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MySql.Data.MySqlClient;

namespace Alleswissen
{
    public partial class Vong3 : Form
    {
        private MySqlConnection conn;
        public int id = 1;

        

        private int cout_question;
        private string prev_question;
        private int cout_goi;
        private bool running;
        private bool Openned;

        private bool nap;
        private bool Bat;
        private string t = @"D:\a";

        private int timerun = 30 * 100;
        public static int row = 1;
        public static int row_h = 1;
        public bool r = true;

        private int[] score = new int[3];
        private int vong;
        private int goi;
        private int cau;
        private string currQuestion;
        private int tg;
        private int run;
        private int hda;
        private string[] dapan = new string[3];
        private int[] thoigian = new int[3];

        public Vong3()
        {
            running = false;
            nap = false;
            prev_question = "0";
            try
            {
                conn = new MySqlConnection(Login.connString);
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to the server failed!");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }

            }
            InitializeComponent();
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }

            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to the server failed!");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }
        }

        private void Vong3_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer2.Enabled = true;
            timer2.Interval = 100;
            pB.Maximum = 1500;
            pB.Step = -10;
            pB.Value = pB.Maximum;
            WMP.uiMode = "none";
            btnT.Text = "Vòng 3";
        }

        private bool LayCauHoi1()
        {
            string query = $"SELECT * FROM op WHERE id = 1";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        vong = (int)reader["vong"];
                        goi = (int)reader["goi"];
                        cau = (int)reader["cau"];
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }

                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool LayCauHoi2(int v, int g, int c)
        {
            string query = $"SELECT * FROM cauhoi WHERE vong = {v} AND goi= {g} AND cau= {c}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        currQuestion = (string)reader["cauhoi"];
                        tg = (int)reader["thoigian"];
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }

                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool LayDiem(int id)
        {
            string query = $"SELECT * FROM thisinh WHERE id = {id}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        score[id - 1] = (int)reader["diem"];
                        thoigian[id- 1] = (int)reader["thoigian"];
                        dapan[id - 1] = (string)reader["dapan"];
                        conn.Close();
                        return true;

                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }

                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool LayRun()
        {
            string query = $"SELECT * FROM op WHERE id=1";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        run = (int)reader["run"];
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }

                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool LayHDA()
        {
            string query = $"SELECT * FROM op WHERE id=1";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        hda = (int)reader["hiendapan"];
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }

                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private void BatVid(string id)
        {
            WMP.URL = t + id + ".mp4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LayHDA();
            if (hda == 0)
            {
                WMP.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                btnDA1.Visible = false;
                btnDA2.Visible = false;
                btnDA3.Visible = false;
            }
            else
            {
                WMP.Visible = false;
                //panel4.Visible = true;
                //panel5.Visible = true;
                //panel6.Visible = true;
                btnDA1.Text = "Team 1: Thời gian: " + Convert.ToString(thoigian[0]) + "  Câu trả lời:" + dapan[0];
                btnDA2.Text = "Team 2: Thời gian: " + Convert.ToString(thoigian[1]) + "  Câu trả lời:" + dapan[1];
                btnDA3.Text = "Team 3: Thời gian: " + Convert.ToString(thoigian[2]) + "  Câu trả lời:" + dapan[2];
                btnDA1.Visible = true;
                btnDA2.Visible = true;
                btnDA3.Visible = true;
            }
            LayCauHoi1();
            if (Bat == false && cau != 0)
            {
                BatVid(Convert.ToString(cau));
                WMP.Ctlcontrols.stop();
                Bat = true;
            }
            if (vong != 3)
            {
                Vong4 v4 = new Vong4();
                this.Close();
                v4.Show();

                Openned = true;
            }

            for (int i = 1; i <= 3; i++)
            {
                LayDiem(i);
            }
            btnT1.Text = score[0].ToString();
            btnT2.Text = score[1].ToString();
            btnT3.Text = score[2].ToString();
            LayCauHoi2(vong, goi, cau);
            btnQ.Text = currQuestion + Convert.ToString(tg);
            LayRun();
            if ((run == 1) && (r))
            {
                timerun = 3000;
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Start();

                if (nap == false)
                {
                    WMP.Ctlcontrols.play();
                    nap = true; 
                }

                r = false;

            }
            else if ((run == 0))
            {
                timer2.Enabled = false;
                if (nap)
                {
                    //WMP.Ctlcontrols.pause();
                    nap = false;
                }
            }
            else if ((run == 1) && (!r) && (timer2.Enabled == false))
            {
                timer2.Enabled = true;
                if (!nap)
                {
                    WMP.Ctlcontrols.play();
                    nap = true;
                }
            }
            if (prev_question != Convert.ToString(cau))
            {
                Bat = false;
                prev_question = Convert.ToString(cau);
                timerun = 3000;
                pB.Value = pB.Maximum;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerun--;
            pB.PerformStep();
            if (timerun == 0)
            {
                timer2.Stop();
                timerun = 3000;
                r = true;
            }
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
        }

        private void btnQ_Click(object sender, EventArgs e)
        {

        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BatVid("1");
            WMP.Ctlcontrols.play();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}