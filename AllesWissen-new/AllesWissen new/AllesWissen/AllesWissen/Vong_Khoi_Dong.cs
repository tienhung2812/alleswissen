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
    public partial class Vong_Khoi_Dong : Form
    {
        private MySqlConnection conn;

        

        private int time = 60;
        public int cout_question = 1;
        public int Score_KhoiDong_Team1 = 0;
        public int Score_KhoiDong_Team2 = 0;
        public int Score_KhoiDong_Team3 = 0;
        public int cout_team = 1;
        
        //private int timerun = 60 * 10;
        //FileStream stream = File.Open(@"cau_hoi_de.xlsx", FileMode.Open, FileAccess.Read);
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Vong_Khoi_Dong()
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
            StartCount(false, cout_team, 1, 0, 0);
            TextBox tb = new TextBox();
            tb.KeyUp += (sender, args) => {
                if (args.KeyCode == Keys.Space)
                {
                    btnPause.PerformClick();
                }
            };
        }

        private bool LayCauHoi(int id,int goi)
        {
            
            string query = $"SELECT * FROM cauhoi WHERE vong =1 AND goi = {goi} AND cau ={id}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lbQuestion.Text = (string)reader["cauhoi"];
                        
                        
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
        private bool StartCount(bool start,int thisinh, int vong, int goi, int cau)
        {
            string query;
            if (start)
            {
                query = $"UPDATE op SET thisinh = {thisinh}, vong={vong}, goi = {goi}, cau = {cau}, run =1, hiendapan = 0 WHERE id={1}";
            }
            else
            {
                query = $"UPDATE op SET thisinh = {thisinh}, vong={vong}, goi = {goi}, cau = {cau}, run =0 , hiendapan = 0, dapan = 0 WHERE id={1}";
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

        // Progress bar count down 60s per team
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
            //Status(cout_team, 1, 0, cout_question);
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

            if (LayCauHoi(cout_question,cout_team) != true) { MessageBox.Show("Get question failed"); };
            if (Status(cout_team, 1, cout_team, cout_question) != true) { MessageBox.Show("Update status failed"); };
            StartCount(true,cout_team, 1, cout_team, cout_question);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            StartCount(false, cout_team,1, cout_team, cout_question);
            timer1.Enabled = false;
            
        }
        private void btnNext_Team_Click(object sender, EventArgs e)
        {
            StartCount(false, cout_team, 1, cout_team, cout_question);
            cout_question = 1;
            timer1.Enabled = false;
            player.controls.stop();
            cout_team++;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer player1= new WMPLib.WindowsMediaPlayer();
            player1.URL = @"KĐ_đúng.mp3";
            player1.controls.play();

            cout_question++;
            LayCauHoi(cout_question,cout_team);
            if (Status(cout_team, 1, cout_team, cout_question) != true) { MessageBox.Show("Update status failed"); };
            StartCount(true, cout_team, 1, cout_team, cout_question);
            if (cout_team ==1)
            {
                Score_KhoiDong_Team1 = Score_KhoiDong_Team1 + 10;
                lbScoreTeam1.Text = Convert.ToString(Score_KhoiDong_Team1);
                NhapDiem(cout_team, Score_KhoiDong_Team1);


            }
            else if (cout_team == 2)
            {
                Score_KhoiDong_Team2 = Score_KhoiDong_Team2 + 10;
                lbScoreTeam2.Text = Convert.ToString(Score_KhoiDong_Team2);
                NhapDiem(cout_team, Score_KhoiDong_Team2);
            }
            else if (cout_team == 3)
            {
                Score_KhoiDong_Team3 = Score_KhoiDong_Team3 + 10;
                lbScoreTeam3.Text = Convert.ToString(Score_KhoiDong_Team3);
                NhapDiem(cout_team, Score_KhoiDong_Team3);
            }

            
            timer1.Enabled = true;
            
            
           
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
            player2.URL = @"KĐ_sai.mp3";
            player2.controls.play();
            timer1.Enabled = true;
            cout_question++;
            LayCauHoi(cout_question,cout_team);
            StartCount(true, cout_team, 1, cout_team, cout_question);
            if (Status(cout_team, 1, cout_team, cout_question) != true) { MessageBox.Show("Update status failed"); };
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            
            Vong_Vuot_Chuong_Ngai_Vat vvcnv = new Vong_Vuot_Chuong_Ngai_Vat();
            this.Hide();
            vvcnv.Show();
            StartCount(false, 0, 2, 0, 0);
            
        }

        private void Vong_Khoi_Dong_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (cout_team == 1)
            {
                Score_KhoiDong_Team1 = Score_KhoiDong_Team1 - 10;
                lbScoreTeam1.Text = Convert.ToString(Score_KhoiDong_Team1);
            }
            else if (cout_team == 2)
            {
                Score_KhoiDong_Team2 = Score_KhoiDong_Team2 - 10;
                lbScoreTeam2.Text = Convert.ToString(Score_KhoiDong_Team2);
            }
            else if (cout_team == 3)
            {
                Score_KhoiDong_Team3 = Score_KhoiDong_Team3 - 10;
                lbScoreTeam3.Text = Convert.ToString(Score_KhoiDong_Team3);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            StartCount(true,cout_team, 1, cout_team, cout_question);
            timer1.Enabled = true;
            //player.controls.play();
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
    }
}
