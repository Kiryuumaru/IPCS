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
            InitializeComponent();
            UpdateComponents();
        }

        public void UpdateComponents()
        {
            linkUserAccount.Width = (int)CreateGraphics().MeasureString(Program.name + "WWW", Font).Width;
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
