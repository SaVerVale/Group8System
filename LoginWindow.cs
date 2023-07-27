﻿using System;
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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "First Name")
            {
                UserNameTxt.Text = "";
                UserNameTxt.ForeColor = Color.Black;
            }

        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "")
            {
                UserNameTxt.Text = "First Name";
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
    }
}
