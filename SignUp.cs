using Kape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8Sytem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void UserNameTxt_Enter(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "First Name")
            {
                UserNameTxt.Text = "";
                UserNameTxt.ForeColor = Color.Black;
            }
        }

        private void UserNameTxt_Leave(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "")
            {
                UserNameTxt.Text = "First Name";
                UserNameTxt.ForeColor = Color.LightGray;
            }
        }

        private void PasswordTxt_Enter(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "Password")
            {
                PasswordTxt.Text = "";
                PasswordTxt.ForeColor = Color.Black;
            }
        }

        private void PasswordTxt_Leave(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "")
            {
                UserNameTxt.Text = "First Name";
                UserNameTxt.ForeColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values of the username and password fields
                string username = UserNameTxt.Text.Trim();
                string password = PasswordTxt.Text.Trim();

                // Validate that the fields are not empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and password cannot be empty.");
                    return;
                }

                DbConnect dbConnector = new DbConnect();
                bool success = dbConnector.AddUser(username, password);

                if (success)
                {
                    MessageBox.Show("User successfully registered!");
                    this.Hide();
                    LoginWindow loginWin = new LoginWindow();
                    loginWin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: Unable to register user. Please try again.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginWindow lw = new LoginWindow();
            lw.ShowDialog();
            this.Close();
        }
    }
}
