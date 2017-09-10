using System;
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
            NotifText = "Initializeing Server";
            Program.InitializeServer();
            NotifText = "Server Ready";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Program.Login(txtUsername.Text, txtPassword.Text);
            new MainForm().ShowDialog();
            Dispose();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            new SignupForm().ShowDialog();
        }
    }
}
