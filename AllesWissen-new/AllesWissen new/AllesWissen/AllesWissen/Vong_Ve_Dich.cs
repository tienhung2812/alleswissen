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
    public partial class Vong_Ve_Dich : Form
    {
        private MySqlConnection conn;
        private int[] diemhientai = new int[3];

        public int time = 0;
        public int score1 = 0;
        public int score2 = 0;
        public int score3 = 0;
        public int dem_goi4 = 1;
        public int dem_goi6 = 1;
        public int dem_goi8 = 1;
        public int goi4 = 0;
        public int goi6 = 0;
        public int goi8 = 0;
        public int team = 1;
        public int dem_team1 = 1;
        public int dem_team2 = 1;
        public int dem_team3 = 1;
        public int TimeOther = 5;
        private int  goi;
        private int bellon;
        private bool pauseTimer;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Vong_Ve_Dich()
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
        private bool LayCauHoi(int id,int goi,int vong)
        {
            string ma;
            string query = $"SELECT * FROM cauhoi WHERE vong = 4 and goi = {goi} AND cau = {id}";
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
                            
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam1Round4.Text = diemhientai[0].ToString();
                        }
                        else if (doi == 2)
                        {
                            
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam2Round4.Text = diemhientai[1].ToString();
                        }
                        else
                        {
                            
                            diemhientai[doi - 1] = (int)reader["diem"];
                            lbScoreTeam3Round4.Text = diemhientai[2].ToString();
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
                        conn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
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
                query = $"UPDATE op SET thisinh = {thisinh}, vong={vong}, goi = {goi}, cau = {cau}, run =1 WHERE id={1}";
            }
            else
            {
                query = $"UPDATE op SET thisinh = {thisinh}, vong={vong}, goi = {goi}, cau = {cau}, run =0 WHERE id={1}";
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
        private void Vong_Ve_Dich_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // run down
            int timerun = time*10;
            timerun--;
           
            pbTimer.PerformStep();

            if (timerun == 0)
            {
                timer1.Stop();
                timerun = time;
                
            }
            LayBell();
            if (bellon != 0)
            {
                Bell.Text = $"Chuông: {bellon}";
                player.URL = @"Gianhquyen.mp3";
                player.controls.play();
                timer1.Enabled = false;
                player.controls.pause();
                if (pauseTimer == false)
                {
                    
                    pauseTimer = true;

                    switch (goi)
                    {
                        case 40:
                            StartCount(false, team, 4, goi, dem_goi4 - 1);
                            break;
                        case 60:
                            StartCount(false, team, 4, goi, dem_goi6 - 1);
                            break;
                        case 80:
                            StartCount(false, team, 4, goi, dem_goi8 - 1);
                            break;
                    }
                }

            }
            
            

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (goi4 != 0 )
            {
                LayCauHoi(dem_goi4,40,4);
                    if (dem_goi4 % 3 == 0) time = 15; else time = 10;
                // music(time);

                StartCount(false, team, 4, 40, dem_goi4);

                dem_goi4++;
                
               
            }
            if (goi6 != 0)
            {
                LayCauHoi(dem_goi6,60,4);
                if (dem_goi6 % 3 == 0) time = 20; else if (dem_goi6 % 2 == 0) time = 15; else time = 10;
                   
                StartCount(false, team, 4, 60, dem_goi6);
                dem_goi6++;
                

            }
            if (goi8 != 0)
            {
                LayCauHoi(dem_goi8, 80, 4);
                if ((dem_goi8 % 3 == 0) || (dem_goi8%2==0)) time = 20; else time = 15;
                StartCount(false, team, 4, 80, dem_goi8);
                dem_goi8++;
                
            }
            // Set up timer

            timer2.Stop();
            //----------------------------------------//
            
            // Set up Mp3 
            
            
        }
        public void music(int time)
        {
            if (time == 10)
            {
                player.URL = @"VD - 10 giay.mp3";
                player.controls.play();
            }
            else if (time == 15)
            {
                player.URL = @"VD - 15 giay.mp3";
                player.controls.play();
            }
            else if (time == 20)
            {
                player.URL = @"VD - 20 giay.mp3";
                player.controls.play();
            }
        }
        private void P40_Click(object sender, EventArgs e)
        {
            goi4 = goi4 + 1;
            P40.BackColor = Color.DarkGray;
            goi = 40;
            StartCount(false, team, 4, 40, 0);

        }

        private void btnNext_Team_Click(object sender, EventArgs e)
        {
            lbQuestion.Text = "";
            team++;
            Star.BackColor = Color.White;
            P40.BackColor = Color.White;
            P60.BackColor = Color.White;
            P80.BackColor = Color.White;
            goi4 = 0;
            goi6 = 0;
            goi8 = 0;

    }
        
        private void Star_Click(object sender, EventArgs e)
        {
            
            Star.BackColor = Color.DarkGray;
            player.URL = @"Ngoi sao hi vong.mp3";
            player.controls.play();
        }

        private void P60_Click(object sender, EventArgs e)
        {
            goi6 = goi6 + 1;
            P60.BackColor = Color.DarkGray;
            goi = 60;
            StartCount(false, team, 4, 60, 0);

        }

        private void P80_Click(object sender, EventArgs e)
        {
            goi8 = goi8 + 1;
            P80.BackColor = Color.DarkGray;
            goi = 80;
            StartCount(false, team, 4, 80, 0);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(tbScoreTeam1.Text);
            lbScoreTeam1Round4.Text = score.ToString();
            NhapDiem(1, score);

            score = Convert.ToInt32(tbScoreTeam2.Text);
            lbScoreTeam2Round4.Text = score.ToString();
            NhapDiem(2, score);

            score = Convert.ToInt32(tbScoreTeam3.Text);
            lbScoreTeam3Round4.Text = score.ToString();
            NhapDiem(3, score);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            player.controls.pause();
            switch (goi)
            {
                case 40:
                    StartCount(false, team, 4, goi, dem_goi4-1);
                    break;
                case 60:
                    StartCount(false, team, 4, goi, dem_goi6-1);
                    break;
                case 80:
                    StartCount(false, team, 4, goi, dem_goi8-1);
                    break;
            }
        }



       
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (time>=0)
            lbTime.Text = Convert.ToString(time--);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeOther = 5;
            timer3.Enabled = true;
            timer3.Start();
            timer3.Interval = 1000;
            player.URL = @"VD - 5 giay cho cac thi sinh con lai.mp3";
            player.controls.play();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (TimeOther >= 0)
                lbTimeOther.Text = Convert.ToString(TimeOther--);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            music(time);
            pbTimer.Maximum = time * 100;
            pbTimer.Step = -10;
            pbTimer.Value = pbTimer.Maximum;
            timer2.Enabled = true;
            timer2.Start();
            timer2.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
            switch (goi)
            {
                case 40:
                    StartCount(true, team, 4, goi,dem_goi4-1);
                    break;
                case 60:
                    StartCount(true, team, 4, goi, dem_goi6-1);
                    break;
                case 80:
                    StartCount(true, team, 4, goi, dem_goi8-1);
                    break;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            player.controls.play();
            switch (goi)
            {
                case 40:
                    StartCount(true, team, 4, goi, dem_goi4-1);
                    break;
                case 60:
                    StartCount(true, team, 4, goi, dem_goi6-1);
                    break;
                case 80:
                    StartCount(true, team, 4, goi, dem_goi8-1);
                    break;
            }
            
            resetBellon();
            
        }
    }

        
    
}
