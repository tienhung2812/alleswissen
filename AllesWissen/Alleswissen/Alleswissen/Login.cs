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

namespace Alleswissen
{
    public partial class Login : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public static string connString;
        public static string StaticUser = "";
        public static string StaticServer = "";

        public Login()
        {
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

        public bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM thisinh WHERE id = '{user}' AND pw = '{pass}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIP.Text))
            {
                server = "localhost";

            }
            else
            {
                server = txtIP.Text;
            }
            database = "alleswissen";
            uid = "root";
            password = "";
            port = "3306";


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

            string user = txtUser.Text;
            string pass = txtPassword.Text;
            if (IsLogin(user, pass))
            {
                MessageBox.Show($"Welcome user {user}");
                StaticUser = txtUser.Text;
                StaticServer = txtIP.Text;
                NextForm();
            }
            else
            {
                MessageBox.Show($"User {user} is not exist or incorrect password");
            }
        }

        private void NextForm()
        {
            Vong1 f2 = new Vong1();
            this.Hide();
            f2.Show();
        }
    }
}
