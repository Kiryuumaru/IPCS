using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;

namespace IPCS.Panels
{
    public partial class PnlMain : UserControl
    {
        public PnlMain()
        {
            InitializeComponent();
            UpdateComponents();
        }

        public void UpdateComponents()
        {
            lblUsername.Text = Program.User.Username;
            PnlHome pnlHome = new PnlHome();
            PnlStartCashiering pnlStartCashiering = new PnlStartCashiering();
            PnlManageInventory pnlManageInventory = new PnlManageInventory();
            PnlSettings pnlSettings = new PnlSettings();
            PnlHelp pnlHelp = new PnlHelp();

            pnlCenter.Controls.Add(pnlHome);
            pnlCenter.Controls.Add(pnlStartCashiering);
            pnlCenter.Controls.Add(pnlManageInventory);
            pnlCenter.Controls.Add(pnlSettings);
            pnlCenter.Controls.Add(pnlHelp);
        }

        private void Tab_Click(object sender, EventArgs e)
        {
            MetroLink tab = (MetroLink)sender;
            foreach (Control p in pnlCenter.Controls)
            {
                if (p is UserControl)
                {
                    if (p.Name.Equals("PnlHome") && tab.Name.Equals("lnkHome")) p.Show();
                    else if (p.Name.Equals("PnlStartCashiering") && tab.Name.Equals("lnkStartCashiering")) p.Show();
                    else if (p.Name.Equals("PnlManageInventory") && tab.Name.Equals("lnkManageInventory")) p.Show();
                    else if (p.Name.Equals("PnlSettings") && tab.Name.Equals("lnkSettings")) p.Show();
                    else if (p.Name.Equals("PnlHelp") && tab.Name.Equals("lnkHelp")) p.Show();
                    else p.Hide();
                }
            }
        }
    }
}
