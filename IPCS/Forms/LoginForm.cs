﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace IPCS.Forms
{
    public partial class LoginForm : CustomForm
    {
        public LoginForm()
        {
            InitializeComponent();
            NotifText = "Initializeing Server...";
            Program.InitializeServer();
            NotifText = "Server Ready";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnSignup.Enabled = false;
            NotifText = "Signing in...";
            Program.Login(txtUsername.Text, txtPassword.Text);
            if (Program.User.Online)
            {
                NotifText = Program.User.Username + " is signed in";
                Dispose();
            }
            else
            {
                NotifText = "User doesn`t exist";
            }
            btnLogin.Enabled = true;
            btnSignup.Enabled = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Hide();
            new SignupForm().ShowDialog();
            Show();
            FocusMe();
        }
    }
}
