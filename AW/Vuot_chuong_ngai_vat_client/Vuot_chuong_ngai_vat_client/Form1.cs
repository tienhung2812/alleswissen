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


namespace Vuot_chuong_ngai_vat_client
{
    public partial class Vong_vuot_chuong_ngai_vat_client : Form
    {
        public int currentuser;
        private MySqlConnection conn;
        private string server;
        private string port;
        private string database;
        bool is_next_question = false;
        bool is_start = true;
        bool is_count_down_start = true;
        public Vong_vuot_chuong_ngai_vat_client()
        {
            InitializeComponent();
            for(int i=1;i<=3;i++)
            {
                updA(i,0);
            }
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        } // Disable close button
        bool _m_is_click = false;

        private void Bell_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            _m_is_click = true;
            UInt32 Time = UInt32.Parse(Cdown.Text);
            updA(currentuser,1);
        }
        /*public bool updA(int uid, int a)
        {
            string query = $"UPDATE thisinh SET ans = {a} WHERE id = {uid}";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            Cdown.Text = (UInt32.Parse(Cdown.Text) - 1).ToString();
            Cdown.Value -= 100 / 15;
            if(Cdown.Text == "0")
            {
                Cdown.Value = 0;
                timer1.Enabled = false;
            }
        }

        private void t_Load(object sender, EventArgs e)
        {

        }
        
        private void Submit_click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            timer1.Enabled = false;
            string _m_Text_out = Answer.Text;  
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(is_start == true)
            {
                //Question.Text = ;
                if(is_count_down_start == true)
                {
                    timer1.Enabled = true;
                }
            }
        }

    }
}
