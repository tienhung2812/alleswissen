using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AllesWissen
{
    public partial class Vong_tang_Toc : Form
    {
        private MySqlConnection conn;

        private int[] diemhientai = new int [3];
        private int time = 30;
        public int score1 = 0;
        public int score2 = 0;
        public int score3 = 0;
        private string link = @"D:\a3.mp4";
        private int cout_question;
        private bool q3 = false;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Vong_tang_Toc()
        {
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
            cout_question = 0;
            InitializeComponent();
            
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Set up timer
            pbTimer.Maximum = 3000;
            pbTimer.Step = -10;
            pbTimer.Value = pbTimer.Maximum;

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;

            //----------------------------------------//

            // Set up Mp3 
            if (q3) axWindowsMediaPlayer1.Ctlcontrols.play();
            else
            {
                player.URL = @"TT - 30s.mp3";
                player.controls.play();
            }
            
            StartCount(true, 0, 3, 0, cout_question);
        }

        private void Vong_tang_Toc_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // run down
            int timerun = 3000;
            timerun--;
            pbTimer.PerformStep();

            if (timerun == 0)
            {
                timer1.Stop();
                timerun = 3000;
            }
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
        private bool LayCauHoi(int id)
        {
            string ma;
            string query = $"SELECT * FROM cauhoi WHERE vong = 3 AND cau = {id}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lbQuestion.Text = (string)reader["cauhoi"];

                        ma = (string)reader["ma"];
                        reader.Close();
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
        private bool Status(int doi, int vong, int goi, int cau)
        {
            string query = $"UPDATE thisinh SET vong={vong}, goi = {goi}, cau = {cau} WHERE id={doi}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
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
        private bool StartCount(bool start, int thisinh, int vong, int goi, int cau)
        {
            string query;
            if (start)
            {
                query = $"UPDATE op SET thisinh = {thisinh}, vong={vong}, goi = {goi}, cau = {cau}, run =1, hiendapan = 0 WHERE id={1}";
            }
            else
            {
                query = $"UPDATE op SET thisinh = {thisinh}, vong={vong}, goi = {goi}, cau = {cau}, run =0, hiendapan = 0, bell = 0  WHERE id={1}";
            }
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
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
        private bool hiendapan()
        {
            string query = $"UPDATE op SET hiendapan = 1 WHERE id={1}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
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

        private void Ques1_Click(object sender, EventArgs e)
        {
            if (Ques1.BackColor == Color.Gray) Ques1.BackColor = Color.White;
            else Ques1.BackColor = Color.Gray;
            player.URL = @"mo cau hoi.mp3";
            player.controls.play();
            LayCauHoi(1);
            cout_question = 1;
            StartCount(false, 0, 3, 0, 1);
        }

        private void Ques2_Click(object sender, EventArgs e)
        {
            if (Ques2.BackColor == Color.Gray) Ques2.BackColor = Color.White;
            else Ques2.BackColor = Color.Gray;
            player.URL = @"mo cau hoi.mp3";
            player.controls.play();
            LayCauHoi(2);
            cout_question = 2;
            StartCount(false, 0, 3, 0, 2);
        }

        private void Ques3_Click(object sender, EventArgs e)
        {
            if (Ques3.BackColor == Color.Gray) Ques3.BackColor = Color.White;
            else Ques3.BackColor = Color.Gray;
            //player.URL = @"mo cau hoi.mp3";
            //player.controls.play();

            axWindowsMediaPlayer1.URL = link;
            q3 = true;
            LayCauHoi(3);
            cout_question = 3;
            StartCount(false, 0, 3, 0, 3);
        }

        private void Ques4_Click(object sender, EventArgs e)
        {
            if (Ques4.BackColor == Color.Gray) Ques4.BackColor = Color.White;
            else Ques4.BackColor = Color.Gray;
            player.URL = @"mo cau hoi.mp3";
            player.controls.play();
            LayCauHoi(4);
            cout_question = 4;
            StartCount(false, 0, 3, 0, 4);
        }

        private bool LayDapAn(int doi)
        {
            string query = $"SELECT * FROM thisinh WHERE id = {doi}";
            string dapan;
            int thoigian;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dapan = (string)reader["dapan"];
                        thoigian = (int)reader["thoigian"];
                        if (doi == 1)
                        {
                            lbAnswerTeam1.Text = $"{dapan} : {thoigian}";
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam1Round3.Text = diemhientai[0].ToString();
                        }
                        else if (doi == 2)
                        {
                            lbAnswerTeam2.Text = $"{dapan} : { thoigian}";
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam2Round3.Text = diemhientai[1].ToString();
                        }
                        else
                        {
                            lbAnswerTeam3.Text = $"{dapan} : {thoigian}";
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam3Round3.Text = diemhientai[2].ToString();
                        }

                        reader.Close();
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
        private bool NhapDiem(int doi, int diem)
        {
            string query = $"UPDATE thisinh SET diem={diem} WHERE id={doi}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
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

        private void AnsQues1_Click(object sender, EventArgs e)
        {
            if (AnsQues1.BackColor == Color.Gray) AnsQues1.BackColor = Color.White;
            else AnsQues1.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                LayDapAn(i);
            }
            hiendapan();
        }
        private void AnsQues2_Click(object sender, EventArgs e)
        {
            if (AnsQues2.BackColor == Color.Gray) AnsQues2.BackColor = Color.White;
            else AnsQues2.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                LayDapAn(i);
            }
            hiendapan();
        }
        private void AnsQues3_Click(object sender, EventArgs e)
        {
            if (AnsQues3.BackColor == Color.Gray) AnsQues3.BackColor = Color.White;
            else AnsQues3.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                  LayDapAn(i);
            }
            hiendapan();
        }
        private void AnsQues4_Click(object sender, EventArgs e)
        {
            if (AnsQues4.BackColor == Color.Gray) AnsQues4.BackColor = Color.White;
            else AnsQues4.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                    LayDapAn(i);
                }
            q3 = false;
            hiendapan();
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            Vong_Ve_Dich vcd = new Vong_Ve_Dich();
            this.Hide();
            vcd.Show();
            StartCount(false, 0, 4, 0, 0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int score =  Convert.ToInt32(tbScoreTeam1.Text);
            lbScoreTeam1Round3.Text = score.ToString();
            NhapDiem(1, score);

            score = Convert.ToInt32(tbScoreTeam2.Text);
            lbScoreTeam2Round3.Text = score.ToString();
            NhapDiem(2, score);

            score =  Convert.ToInt32(tbScoreTeam3.Text);
            lbScoreTeam3Round3.Text = score.ToString();
            NhapDiem(3, score);
            q3 = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            player.controls.pause();
            StartCount(false, 0, 3, 0, cout_question);
            q3 = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            player.controls.play();
            StartCount(true, 0, 3, 0, cout_question);
            q3 = false;
        }
    }
}
