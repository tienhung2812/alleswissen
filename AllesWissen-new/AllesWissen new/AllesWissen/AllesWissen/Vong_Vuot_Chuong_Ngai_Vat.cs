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
    public partial class Vong_Vuot_Chuong_Ngai_Vat : Form
    {
        private MySqlConnection conn;

        private int[] diemhientai = new int[3];
        private int time = 15;
        public int score1 = 0;
        public int score2 = 0;
        public int score3 = 0;
        private int cout_question = 0;
        private int bellon;
        private bool pauseTimer;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Vong_Vuot_Chuong_Ngai_Vat()
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

            InitializeComponent();
            bellon = 0;
            pauseTimer = false;
            // Test case
            //lbAnswerTeam1.Text = "heo";
            //lbAnswerTeam3.Text = "cho1";
            //lbAnswerTeam3.Text = "A: voi";
            //lbScoreTeam3Round2.Text = "0";
            timer2.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // run down
            int timerun = 150;
            timerun--;
            pbTimer.PerformStep();

            if (timerun == 0)
            {
                timer1.Stop();
                timerun = 15;
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
            string query = $"SELECT * FROM cauhoi WHERE vong = 2 AND cau = {id}";
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
                            lbScoreTeam1Round2.Text = diemhientai[0].ToString();
                        }
                        else if (doi == 2)
                        {
                            lbAnswerTeam2.Text = $"{dapan} : {thoigian}";
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam2Round2.Text = diemhientai[1].ToString();
                        }
                        else
                        {
                            lbAnswerTeam3.Text = $"{dapan} : {thoigian}";
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam3Round2.Text = diemhientai[2].ToString();
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
            string query = $"UPDATE thisinh SET diem= {diem} WHERE id={doi};";
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
        private bool StartCount(bool start, int thisinh, int vong, int goi, int cau, int bell)
        {
            string query;
            int a;
            if (start)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
            query = $"UPDATE op SET thisinh = {thisinh}, vong={vong}, goi = {goi}, cau = {cau}, run = {a}, bell = {bell}, hiendapan = 0, dapan = 0 WHERE id={1}";
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
        private bool LayBell()
        {
            string query = $"SELECT * FROM op WHERE id =1";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        bellon = (int)reader["bell"];
                        

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
        private bool hiendapan(int id)
        {
            string query = $"UPDATE op SET hiendapan = 1, dapan = {id} WHERE id={1}";
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
            pauseTimer = false;

            player.URL = @"VCNV - 15 giay.mp3";
            player.controls.play();
            StartCount(true, 0, 2, 0, cout_question,0);
        }

        private void Row1_Click(object sender, EventArgs e)
        {
            if (Row1.BackColor == Color.Gray) Row1.BackColor = Color.White;
            else Row1.BackColor = Color.Gray;
            player.URL = @"chon hang ngang.mp3";
            player.controls.play();
            LayCauHoi(1);
            StartCount(false, 0, 2, 0, 1,0);
            cout_question = 1;
            pauseTimer = false;
        }

        private void Vong_Vuot_Chuong_Ngai_Vat_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Row2_Click(object sender, EventArgs e)
        {
            if (Row2.BackColor == Color.Gray) Row2.BackColor = Color.White;
            else Row2.BackColor = Color.Gray;
            player.URL = @"chon hang ngang.mp3";
            player.controls.play();
            LayCauHoi(2);
            StartCount(false, 0, 2, 0, 2,0);
            cout_question = 2;
            pauseTimer = false;
        }

        private void Row3_Click(object sender, EventArgs e)
        {
            if (Row3.BackColor == Color.Gray) Row3.BackColor = Color.White;
            else Row3.BackColor = Color.Gray;
            player.URL = @"chon hang ngang.mp3";
            player.controls.play();
            LayCauHoi(3);
            StartCount(false, 0, 2, 0, 3,0);
            cout_question = 3;
            pauseTimer = false;
        }


        private void Row4_Click(object sender, EventArgs e)
        {
            if (Row4.BackColor == Color.Gray) Row4.BackColor = Color.White;
            else Row4.BackColor = Color.Gray;
            player.URL = @"chon hang ngang.mp3";
            player.controls.play();
            LayCauHoi(4);
            StartCount(false, 0, 2, 0, 4,0);
            cout_question = 4;
            pauseTimer = false;
        }

        private void Row5_Click(object sender, EventArgs e)
        {
            if (Row5.BackColor == Color.Gray) Row5.BackColor = Color.White;
            else Row5.BackColor = Color.Gray;
            player.URL = @"chon hang ngang.mp3";
            player.controls.play();
            LayCauHoi(5);
            StartCount(false, 0, 2, 0, 5,0);
            cout_question = 5;
            pauseTimer = false;
        }

        private void Row6_Click(object sender, EventArgs e)
        {
            if (Row6.BackColor == Color.Gray) Row6.BackColor = Color.White;
            else Row6.BackColor = Color.Gray;
            player.URL = @"chon hang ngang.mp3";
            player.controls.play();
            LayCauHoi(6);
            StartCount(false, 0, 2, 0, 6,0);
            cout_question = 6;
            pauseTimer = false;
        }

        private void AnsRow1_Click(object sender, EventArgs e)
        {
            if (AnsRow1.BackColor == Color.Gray) AnsRow1.BackColor = Color.White;
            else AnsRow1.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                if (LayDapAn(i)) { }else { MessageBox.Show("Get answer failed"); }
                    
            }
            if (!hiendapan(1))
            {
                MessageBox.Show("Fail");
            }
                
            
        }

        private void AnsRow2_Click(object sender, EventArgs e)
        {
            if (AnsRow2.BackColor == Color.Gray) AnsRow2.BackColor = Color.White;
            else AnsRow2.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                LayDapAn(i);
            }
            hiendapan(2);
        }

        private void AnsRow3_Click(object sender, EventArgs e)
        {
            if (AnsRow3.BackColor == Color.Gray) AnsRow4.BackColor = Color.White;
            else AnsRow3.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                LayDapAn(i);
            }
            hiendapan(3);
        }

        private void AnsRow4_Click(object sender, EventArgs e)
        {
            if (AnsRow4.BackColor == Color.Gray) AnsRow4.BackColor = Color.White;
            else AnsRow4.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                LayDapAn(i);
            }
            hiendapan(4);
        }

        private void AnsRow5_Click(object sender, EventArgs e)
        {
            if (AnsRow5.BackColor == Color.Gray) AnsRow5.BackColor = Color.White;
            else AnsRow5.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                LayDapAn(i);
            }
            hiendapan(5);
        }

        private void AnsRow6_Click(object sender, EventArgs e)
        {
            if (AnsRow6.BackColor == Color.Gray) AnsRow6.BackColor = Color.White;
            else AnsRow6.BackColor = Color.Gray;
            for (int i = 1; i <= 3; i++)
            {
                LayDapAn(i);
            }
            hiendapan(6);
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            Vong_tang_Toc vvcnv = new Vong_tang_Toc();
            this.Hide();
            vvcnv.Show();
            StartCount(false, 0, 3, 0, 0,0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(tbScoreTeam1.Text);
            lbScoreTeam1Round2.Text = score.ToString();
            NhapDiem(1, score);

            score = Convert.ToInt32(tbScoreTeam2.Text);
            lbScoreTeam2Round2.Text = score.ToString();
            NhapDiem(2, score);

            score = Convert.ToInt32(tbScoreTeam3.Text);
            lbScoreTeam3Round2.Text = score.ToString();
            NhapDiem(3, score);
        }



        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            player.controls.pause();
            StartCount(false, 0, 2, 0, cout_question,bellon);

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            player.controls.play();
            StartCount(true, 0, 2, 0, cout_question, bellon);
            pauseTimer = false;
            resetBellon();
        }

        private bool resetBellon()
        {
            string query = $"UPDATE op SET bell = 0 WHERE id={1}";

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            LayBell();
            if (bellon != 0)
            {
                Bellon.Text = $"Chuông: {bellon}";

                timer1.Enabled = false;
                player.controls.pause();
                if (pauseTimer == false)
                {
                    StartCount(false, 0, 2, 0, cout_question, bellon);
                    pauseTimer = true;
                }

            }
            else
            {
                Bellon.Text = "Chuông: ";

            }
        }
    }
}
