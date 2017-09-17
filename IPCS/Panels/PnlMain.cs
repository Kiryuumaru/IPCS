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
            tabShow.Hide();
            UserControl pnlHome = new PnlHome();
            UserControl pnlStartCashiering = new PnlStartCashiering();
            UserControl pnlManageInventory = new PnlManageInventory();
            UserControl pnlSettings = new PnlSettings();
            UserControl pnlHelp = new PnlHelp();

            pnlHome.Dock = DockStyle.Fill;
            pnlStartCashiering.Dock = DockStyle.Fill;
            pnlManageInventory.Dock = DockStyle.Fill;
            pnlSettings.Dock = DockStyle.Fill;
            pnlHelp.Dock = DockStyle.Fill;

            pnlCenter.Controls.Add(pnlHome);
            pnlCenter.Controls.Add(pnlStartCashiering);
            pnlCenter.Controls.Add(pnlManageInventory);
            pnlControl.Controls.Add(pnlSettings);
            pnlCenter.Controls.Add(pnlHelp);

            Tab_Click(tabHome, new EventArgs());
        }

        private void Tab_Click(object sender, EventArgs e)
        {
            UserControl tab = (UserControl)sender;
            foreach (Control p in pnlCenter.Controls)
            {
                if (p is UserControl)
                {
                    if (p.Name.Equals("PnlHome") && tab.Name.Equals("tabHome")) p.Show();
                    else if (p.Name.Equals("PnlStartCashiering") && tab.Name.Equals("tabStartCashiering")) p.Show();
                    else if (p.Name.Equals("PnlManageInventory") && tab.Name.Equals("tabManageInventory")) p.Show();
                    else if (p.Name.Equals("PnlHelp") && tab.Name.Equals("tabHelp")) p.Show();
                    else if (tab.Name.Equals("tabShow")) MaximizeTab();
                    else if (tab.Name.Equals("tabHide")) MinimizeTab();
                    else if (tab.Name.Equals("tabSettings"))
                    {
                        MaximizeTab();
                        p.BringToFront();
                        pnlTab.SendToBack();
                    }
                    else p.Hide();

                }
            }
        }

        private void MinimizeTab()
        {
            tabShow.Show();
            lblUsername.Hide();
            pnlControl.Size = new Size(50, pnlControl.Height);
        }

        private void MaximizeTab()
        {
            tabShow.Hide();
            lblUsername.Show();
            pnlControl.Size = new Size(210, pnlControl.Height);
        }
    }
}
