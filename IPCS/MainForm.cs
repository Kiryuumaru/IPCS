using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using IPCS.Forms;

namespace IPCS
{
    public partial class MainForm : CustomForm
    {
        public MainForm()
        {
            new LoginForm().ShowDialog();
            InitializeComponent();
            UpdateComponents();
        }

        public void UpdateComponents()
        {
            linkUserAccount.Text = Program.User.Username;
            metroToolTip.SetToolTip(linkUserAccount, Program.User.Username + " is signed in");
            metroStyleManager.Theme = Program.StyleManager.Theme;
            metroStyleManager.Style = Program.StyleManager.Style;
            RefreshComponents();
        }

        private void UserAccount_Click(object sender, EventArgs e)
        {
            new AccountSettings(metroStyleManager).ShowDialog();
        }

        private void UserAccount_MouseEnter(object sender, EventArgs e)
        {
            if (metroStyleManager.Theme == MetroThemeStyle.Light) linkUserAccount.ForeColor = Color.FromArgb(0, 0, 0);
            else linkUserAccount.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void UserAccount_MouseLeave(object sender, EventArgs e)
        {
            linkUserAccount.ForeColor = SystemColors.ControlDarkDark;
        }
    }
}
