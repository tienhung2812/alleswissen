using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace Vong_vuot_chuong_ngai_vat_trinh_chieu
{
   
    public partial class Form1 : Form
    {
        /* public int currentstatus[];
    private MySqlConnection conn;
        private string server;
        private string port;
        private string database;*/
        bool is_next = true;
        int count = 0;
        int which_bell_ring = 1;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }
       /* public bool getA(int uid)
        {
            string query = $"SELECT ans FROM thisinh WHERE id = {uid}";


            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        currentstatus[uid] = (int)reader["ans"];
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
        }*/
        /*private bool OpenConnection()
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
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            /*for(int i=1; i<=3;i++){getA(i);}
         if(currentstatus[0] == 1)
         {
             Notification_1.BlinkingEnable = true;
         }
            
         if(currentstatus[1] == 1)
         {
             Notification_2.BlinkingEnable = true;
         }
         if(currentstatus[2] == 1)
         {
             Notification_3.BlinkingEnable = true;
         }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Count_down.Text = (UInt32.Parse(Count_down.Text) - 1).ToString();
            Count_down.Value -= 100 / 15;
            if(Count_down.Text == "0")
            {
                Count_down.Value = 0;
                timer1.Enabled = false;
                //uodate câu trả lời của 3 đội và đáp án tại đây
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((A1.Text != "") && (Count_down.Text == "0") && (is_next == true))
            {
                Count_down.Text = "15";
                Count_down.Value = 100;
                timer1.Enabled = true;
            }
            else if ((B1.Text != "") && (Count_down.Text == "0") && (is_next == true))
            {
                Count_down.Text = "15";
                Count_down.Value = 100;
                timer1.Enabled = true;
            }
            else if ((C1.Text != "") && (Count_down.Text == "0") && (is_next == true))
            {
                Count_down.Text = "15";
                Count_down.Value = 100;
                timer1.Enabled = true;
            }
            else if ((D1.Text != "") && (Count_down.Text == "0") && (is_next == true))
            {
                Count_down.Text = "15";
                Count_down.Value = 100;
                timer1.Enabled = true;
            }
        }
    }
    public class BlinkingLabel:Label
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
            if(this.BackColor == this.FisrtColor)
            {
                this.BackColor = this.SecondColor;
            }
           
            else  this.BackColor = this.FisrtColor;
            
        }
    [Category ("Blinking label setting")]
        public Color FisrtColor { get; set; }
    [Category ("Blinking label setting")]
        public Color SecondColor { get; set; }
    [Category ("Blinking label setting")]
        public int Interval 
    {
        get{return this.timer.Interval;} 
        set{this.timer.Interval = value;} 
    }
    [Category ("Blinking label setting")]
        public bool BlinkingEnable 
    { 
        get{return this.timer.Enabled;} 
        set{this.timer.Enabled = value;}
    }
    } // Status label
}
