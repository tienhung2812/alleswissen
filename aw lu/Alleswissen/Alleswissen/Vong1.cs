using System;
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
    public partial class Vong1 : Form
    {
        private MySqlConnection conn;
        public int id = 1;

        private int cout_question;
        private int cout_goi;
        private bool running;
        private bool Openned;
        private int prev_team = 1;

        private int timerun = 60 * 10;
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

        public Vong1()
        {
            running = false;
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

        private void Vong1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer2.Enabled = true;
            timer2.Interval = 100;
            pB.Maximum = 6000;
            pB.Step = -10;
            pB.Value = pB.Maximum;
            btnT.Text = "Vòng 1";
        }

        private void refill()
        {
            pB.Value = pB.Maximum;
            timerun = 6000;
            pB.Value = pB.Maximum;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            LayCauHoi1();
            if (vong != 1)
            {
                Vong2 v2 = new Vong2();
                this.Close();
                v2.Show();

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
            btnQ.Text = currQuestion;
            LayRun();
            if ((run == 1) && (r))
            {
                timerun = 6000;
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Start();
                r = false;
            }
            else if ((run == 0) && (!r))
            {
                timer2.Enabled = false;
            }
            else if ((run == 1) && (!r) && (timer2.Enabled == false))
            {
                timer2.Enabled = true;
            }

            if(prev_team != goi)
            {
                refill();
                prev_team = goi;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerun--;
            pB.PerformStep();
            if (timerun == 0)
            {
                timer2.Stop();
                timerun = tg;
                r = true;
            }
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
        }
    }
}
