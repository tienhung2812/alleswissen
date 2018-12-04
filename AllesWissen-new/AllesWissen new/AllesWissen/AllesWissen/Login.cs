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

namespace AllesWissen
{
    public partial class Login : Form

    {
        private MySqlConnection conn;
        public static string connString;
        public static string server;
        public static string database = "alleswissen";
        public static string uid = "root";
        public static string password = "";

        public static string port = "3306";
        public static string StaticServer = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIPadd.Text))
            {
                server = "localhost";

            }
            else
            {
                server = txtIPadd.Text;
            }
            

            
            connString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password}" +
                    $";";

            try
            {
                conn = new MySqlConnection(connString);
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
            if (OpenConnection())
            {
                MessageBox.Show($"Connect successful");
                StaticServer = txtIPadd.Text;
                Vong_Khoi_Dong vvcnv = new Vong_Khoi_Dong();
                this.Hide();
                vvcnv.Show();
            }
            else
            {
                MessageBox.Show($"Connect unsuccessful");
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
    }
}
