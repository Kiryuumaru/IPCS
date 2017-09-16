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

        #region Constructor

        public PnlMain()
        {
            InitializeComponent();
            UpdateComponents();
        }

        #endregion

        public void UpdateComponents()
        {
            lblUsername.Text = Program.User.Username;
            profilePicture.Image = Program.User.ProfilePic;
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
            UserControl tab = (UserControl)sender;
            foreach (Control p in pnlCenter.Controls)
            {
                if (p is UserControl)
                {
                    if (p.Name.Equals("PnlHome") && tab.Tag.Equals("Home")) p.Show();
                    else if (p.Name.Equals("PnlStartCashiering") && tab.Tag.Equals("StartCashiering")) p.Show();
                    else if (p.Name.Equals("PnlManageInventory") && tab.Tag.Equals("ManageInventory")) p.Show();
                    else if (p.Name.Equals("PnlSettings") && tab.Tag.Equals("Settings")) p.Show();
                    else if (p.Name.Equals("PnlHelp") && tab.Tag.Equals("Help")) p.Show();
                    else p.Hide();
                }
            }
        }
    }
}
