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

namespace AllesWissen
{
    public partial class Vong_Khoi_Dong : Form
    {
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
            InitializeComponent();
            TextBox tb = new TextBox();
            tb.KeyUp += (sender, args) => {
                if (args.KeyCode == Keys.Space)
                {
                    btnPause.PerformClick();
                }
            };
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
            FileStream stream = File.Open(@"cau_hoi_de.xlsx", FileMode.Open, FileAccess.Read);
            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader.AsDataSet();
            //...
            //4. DataSet - Create column names from first cout_question
            excelReader.IsFirstRowAsColumnNames = true;
            
           
            //5. Data Reader methods
            while (excelReader.Read())
            {
                lbQuestion.Text = result.Tables[0].Rows[cout_question][1].ToString();
            }
            
            excelReader.Close();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
           
                timer1.Enabled = false;                     
        }
        private void btnNext_Team_Click(object sender, EventArgs e)
        {
            cout_question = 12 * cout_team;
            timer1.Enabled = false;
            player.controls.stop();
            cout_team++;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer player1= new WMPLib.WindowsMediaPlayer();
            player1.URL = @"KĐ_đúng.mp3";
            player1.controls.play();
            if (cout_team ==1)
            {
                Score_KhoiDong_Team1 = Score_KhoiDong_Team1 + 10;
                lbScoreTeam1.Text = Convert.ToString(Score_KhoiDong_Team1);
            }
            else if (cout_team == 2)
            {
                Score_KhoiDong_Team2 = Score_KhoiDong_Team2 + 10;
                lbScoreTeam2.Text = Convert.ToString(Score_KhoiDong_Team2);
            }
            else if (cout_team == 3)
            {
                Score_KhoiDong_Team3 = Score_KhoiDong_Team3 + 10;
                lbScoreTeam3.Text = Convert.ToString(Score_KhoiDong_Team3);
            }
            timer1.Enabled = true;
           if (cout_question % 11 !=0) cout_question++;
            FileStream stream = File.Open(@"cau_hoi_de.xlsx", FileMode.Open, FileAccess.Read);
            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader1 = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader1.AsDataSet();
            //...
            //4. DataSet - Create column names from first cout_question
            excelReader1.IsFirstRowAsColumnNames = true;


            //5. Data Reader methods
            while (excelReader1.Read())
            {
                lbQuestion.Text = result.Tables[0].Rows[cout_question][1].ToString();
            }
            excelReader1.Close();
           
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
            player2.URL = @"KĐ_sai.mp3";
            player2.controls.play();
            timer1.Enabled = true;
            cout_question++;
            FileStream stream = File.Open(@"cau_hoi_de.xlsx", FileMode.Open, FileAccess.Read);
            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader1 = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader1.AsDataSet();
            //...
            //4. DataSet - Create column names from first cout_question
            excelReader1.IsFirstRowAsColumnNames = true;


            //5. Data Reader methods
            while (excelReader1.Read())
            {
                lbQuestion.Text = result.Tables[0].Rows[cout_question][1].ToString();
            }
            excelReader1.Close();
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            
            Vong_Vuot_Chuong_Ngai_Vat vvcnv = new Vong_Vuot_Chuong_Ngai_Vat();
            this.Hide();
            vvcnv.Show();
            
        }

        private void pbTimer_Click(object sender, EventArgs e)
        {

        }

        private void Vong_Khoi_Dong_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
        }
    }
}
