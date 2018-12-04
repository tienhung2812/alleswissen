using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Excel;

namespace vongkhoidong
{
    
    public partial class clientvong1 : Form
    {
        
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;
        public int id = 1;
        private string localquestion;
        private string localanswer;
        private int time = 60;
        private int timerun = 60 * 10;
        public static int row = 1;
        public static int row_h = 1;
        public bool r = true;
        public clientvong1()
        {
            InitializeComponent();
        }
       
            
        private void clientvong1_Load(object sender, EventArgs e)
        {
            label1.Text = "Doi 1";
            // set maximum time = 60s
            progressBar1.Maximum = time * 100;
            progressBar1.Step = -10;
            progressBar1.Value = progressBar1.Maximum;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Enabled = true;
            timer1.Interval = 100;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            txtQ.Text = localquestion;
            timerun = 6000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            // end time session
            // start excel queue 
            

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // run down
            timerun--;
            progressBar1.PerformStep();

            if (timerun == 0)
            {
                timer1.Stop();
                timerun = 60*10;
                progressBar1.Value = progressBar1.Maximum;
            }
        }

        private void clientvong1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString()=="E" && r)
            {
                timer1.Stop();
                r = false;
            }
            else
            {
                timer1.Start();
                r = true;
            }
            if (e.KeyCode.ToString()=="N")
            {
                id++;
                txtQ.Text = localquestion;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
