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
            NotifText = "Server Ready";
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Program.Login(txtUsername.Text, txtPassword.Text);

            Dispose();
        }
    }
}
