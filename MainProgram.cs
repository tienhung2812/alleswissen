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

namespace DauTruong100
{
    public partial class MainProgram : Form
    {
        public static int row = 1;
        public static int row_h = 1;
        public  string Answer = "";
        public MainProgram()
        {
            InitializeComponent();
            
        }
        private OleDbConnection returnConnection(string fileName)
        {
            return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + "; Jet OLEDB:Engine Type=5;Extended Properties=\"Excel 8.0;\"");
        }
        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            Label[] labels = new Label[101];
            int c = 0;
            int b = 0;
            for (int i = 1; i < 101; i++)
            {
                int n = i;


                labels[i] = new Label();
                labels[i].Text = Convert.ToString(i);
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].Font = new Font(labels[i].Font.FontFamily, labels[i].Font.Size + 4);
                labels[i].AutoSize = false;
                labels[i].BackColor = Color.Aqua;
                labels[i].Location = new Point(14 + 130 * c, 300 + 33 * b);
                c = c + 1;
                labels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                labels[i].Size = new Size(90, 30);
                if (n % 10 == 0)
                {
                    b = b + 2;
                    c = 0;
                }
                Controls.Add(labels[i]);
                labels[i].Click += ChangeBackColor;
                // Here you can modify the value of the label which is at labels[i]
               
                
            }

        }
        
        private void ChangeBackColor(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.BackColor == Color.Aqua) control.BackColor = Color.Red;
            else control.BackColor = Color.Aqua;
        }

        public void btnEasy_Click(object sender, EventArgs e)
        {

            FileStream stream = File.Open(@"cau_hoi_de.xlsx", FileMode.Open, FileAccess.Read);

            
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
                textBoxQuestion.Text = result.Tables[0].Rows[row][1].ToString();
            }
            Answer = result.Tables[0].Rows[row][5].ToString();
            lbA.Text = result.Tables[0].Rows[row][2].ToString();
            lbA.BackColor = Color.White;
            lbB.Text = result.Tables[0].Rows[row][3].ToString();
            lbB.BackColor = Color.White;
            lbC.Text = result.Tables[0].Rows[row][4].ToString();
            lbC.BackColor = Color.White;
           
            row = row + 1;
            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();
        }

        private void lbA_Click(object sender, EventArgs e)
        {
            if (lbA.Text == Answer) lbA.BackColor = Color.Blue;
            else lbA.BackColor = Color.Red;
        }

        private void lbB_Click(object sender, EventArgs e)
        {
            if (lbB.Text == Answer) lbB.BackColor = Color.Blue;
            else lbB.BackColor = Color.Red;
        }

        private void lbC_Click(object sender, EventArgs e)
        {
            if (lbC.Text == Answer) lbC.BackColor = Color.Blue;
            else lbC.BackColor = Color.Red;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            FileStream stream = File.Open(@"cau_hoi_kho.xlsx", FileMode.Open, FileAccess.Read);


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
                textBoxQuestion.Text = result.Tables[0].Rows[row_h][1].ToString();
            }
            Answer = result.Tables[0].Rows[row_h][5].ToString();
            lbA.Text = result.Tables[0].Rows[row_h][2].ToString();
            lbA.BackColor = Color.White;
            lbB.Text = result.Tables[0].Rows[row_h][3].ToString();
            lbB.BackColor = Color.White;
            lbC.Text = result.Tables[0].Rows[row_h][4].ToString();
            lbC.BackColor = Color.White;

            row_h = row_h + 1;
            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();
        }

        private void lb2Answer_Click(object sender, EventArgs e)
        {
            if(lb2Answer.BackColor == Color.Gray) lb2Answer.BackColor = Color.White;
            else lb2Answer.BackColor = Color.Gray;
        }

        private void lbKhangia_Click(object sender, EventArgs e)
        {
            if(lbKhangia.BackColor == Color.Gray) lbKhangia.BackColor = Color.White;
            else lbKhangia.BackColor = Color.Gray;
        }

        private void lbChange_Click(object sender, EventArgs e)
        {
            if(lbChange.BackColor == Color.Gray) lbChange.BackColor = Color.White;
            else lbChange.BackColor = Color.Gray;
        }
    }
}
