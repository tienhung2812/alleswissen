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
    public partial class Vong2 : Form
    {
        private MySqlConnection conn;
        public int id = 1;

        private int cout_question;
        private int cout_goi;
        private bool running;
        private bool Openned;

        private int bellon;
        private int timerun = 1500;
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
        private int dapan1;
        private int hda;
        private string[] dapan = new string[3];
        private int[] thoigian = new int[3];

        public Vong2()
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

        private void Vong2_Load(object sender, EventArgs e)
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
            btnT.Text = "Vòng 2";
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
                        thoigian[id - 1] = (int)reader["thoigian"];
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

        private bool LayDA()
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
                        dapan1 = (int)reader["dapan"];
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
                        bellon = (int)reader["bell"];
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
            LayDA();
            if (dapan1 == 1) { pBC1.Visible = true; }
            else if (dapan1 == 2) { pBC2.Visible = true; }
            else if (dapan1 == 3) { pBC3.Visible = true; }
            else if (dapan1 == 4) { pBC4.Visible = true; }
            if (hda == 0)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                btnDA1.Visible = true;
                btnDA2.Visible = true;
                btnDA3.Visible = true;
            }
            else
            {
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                btnDA1.Text = "Team 1: Thời gian: " + Convert.ToString(thoigian[0]) + "  Câu trả lời:" + dapan[0];
                btnDA2.Text = "Team 2: Thời gian: " + Convert.ToString(thoigian[1]) + "  Câu trả lời:" + dapan[1];
                btnDA3.Text = "Team 3: Thời gian: " + Convert.ToString(thoigian[2]) + "  Câu trả lời:" + dapan[2];
            }
            LayCauHoi1();
            if (vong != 2)
            {
                Vong3 v3 = new Vong3();
                this.Close();
                v3.Show();

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
                timerun = 1500;
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

            if (bellon != 0)
            {
                bell.Visible = true;
                bell.Text = "Đội " + Convert.ToString(bellon) +" đã nhấn chuông";
            }
            else
            {
                bell.Visible = false;
                bell.Text = "";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerun--;
            pB.PerformStep();
            if (timerun == 0)
            {
                timer2.Stop();
                timerun = 1500;
                r = true;
            }
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
        }

        private void btnDA3_Click(object sender, EventArgs e)
        {

        }
    }
}
