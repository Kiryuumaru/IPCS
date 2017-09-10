using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using IPCS.Forms;

namespace IPCS
{
    public partial class MainForm : CustomForm
    {
        public MainForm()
        {
            InitializeComponent();
            Program.InitializeServer();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            linkUserAccount.Text = Program.name;
            RefreshComponents();
        }

        private void buttonOpenColor_Click(object sender, EventArgs e)
        {
            new ColorPicker(metroStyleManager).ShowDialog();
        }

        private void UserAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
