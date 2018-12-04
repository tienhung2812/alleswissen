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
    
    public partial class Trinhchieu : Form
    {
        public static int row = 1;
        public static int row_h = 1;
        private int time = 60;
        private int timerun = 60*10;
        public Trinhchieu()
        {
            InitializeComponent();
        }
        private OleDbConnection returnConnection(string fileName)
        {
            return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + "; Jet OLEDB:Engine Type=5;Extended Properties=\"Excel 8.0;\"");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            doi1.Text = "Team 1\n";
            doi2.Text = "Team 2\n";
            doi3.Text = "Team 3\n";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // Start buttton each team a team play, press one
        private void button1_Click(object sender, EventArgs e)
        {
            // set maximum time = 60s
            progressBar1.Maximum = time*100;
            progressBar1.Step = -10;
            progressBar1.Value = progressBar1.Maximum;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
            cauhoi.Text = "aasdsadasdas";
            timer1.Tick += new EventHandler(timer1_Tick);
            // end time session
            // start excel queue 
            string t = @"cau_hoi_de.xlsx";
            FileStream stream = File.Open(t, FileMode.Open, FileAccess.Read);


            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader.AsDataSet();
            //...
            //4. DataSet - Create column names from first row
            excelReader.IsFirstRowAsColumnNames = true;

            DataTable dt = result.Tables[0];
            //5. Data Reader methods
            while (excelReader.Read())
            {
                cauhoi.Text = result.Tables[0].Rows[row][1].ToString();
            }
            
            row = row + 1;
            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();

        }
        // Progress bar count down 60s per team
        private void timer1_Tick(object sender, EventArgs e)
        {

            // run down
            timerun--;
            progressBar1.PerformStep();

            if (timerun == 0)
            {
                timer1.Stop();
                timerun = 60;
            }

        }
    }
}
