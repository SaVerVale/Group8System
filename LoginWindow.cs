using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Kape;

namespace Group8Sytem
{
    public partial class LoginWindow : Form
    {
        // Your MySQL connection string. Replace with your database credentials.
        private string connectionString = "server=localhost;user=root;password=;database=db_inventory_system;";

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserNameTxt.Text;
            string password = PasswordTxt.Text;

            if (AuthenticateUser(username, password))
            {
                // Set the logged-in user's information in the SessionManager
                SessionManager.SetLoggedInUser(username);
                // Successful login, open the main application form (Form1)
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "Enter Your Username here")
            {
                UserNameTxt.Text = "";
                UserNameTxt.ForeColor = Color.Black;
            }

        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "")
            {
                UserNameTxt.Text = "Enter Your Username here:";
                UserNameTxt.ForeColor = Color.LightGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "Password")
            {
                PasswordTxt.Text = "";
                PasswordTxt.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "")
            {
                UserNameTxt.Text = "First Name";
                UserNameTxt.ForeColor = Color.LightGray;
            }
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signupWin = new SignUp();
            signupWin.ShowDialog();
            this.Close();
        }
    }
}
