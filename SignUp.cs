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

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginWindow loginWin = new LoginWindow();
            loginWin.ShowDialog();
            this.Close();

        }
    }
}
