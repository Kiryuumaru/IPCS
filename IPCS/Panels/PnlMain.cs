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

        public PnlMain(Form parent)
        {
            Parent = parent;
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties

        public new Form Parent { get; }

        #endregion

        #region Threads

        UserControl pnlHome;
        UserControl pnlStartCashiering;
        UserControl pnlManageInventory;
        UserControl pnlSettings;
        UserControl pnlHelp;
        public void ReInitializeComponent()
        {
            pnlHome = new PnlHome();
            pnlStartCashiering = new PnlStartCashiering(Parent);
            pnlManageInventory = new PnlManageInventory(Parent);
            pnlSettings = new PnlSettings();
            pnlHelp = new PnlHelp();
            lblUsername.Text = Program.User.Username;
            profilePicture.Image = Program.User.ProfilePic;
            tabShow.Hide();

            pnlHome.Dock = DockStyle.Fill;
            pnlStartCashiering.Dock = DockStyle.Fill;
            pnlManageInventory.Dock = DockStyle.Fill;
            pnlSettings.Dock = DockStyle.Right;
            pnlHelp.Dock = DockStyle.Fill;

            pnlCenter.Controls.Add(pnlHome);
            pnlCenter.Controls.Add(pnlStartCashiering);
            pnlCenter.Controls.Add(pnlManageInventory);
            pnlControl.Controls.Add(pnlSettings);
            pnlCenter.Controls.Add(pnlHelp);
            pnlSettings.Hide();
            Tab_Click(tabHome, new EventArgs());
        }

        public void UpdateComponent()
        {

        }

        private void MinimizeTab()
        {
            tabShow.Show();
            pnlTab.Size = new Size(50, pnlControl.Height);
        }

        private void MaximizeTab()
        {
            tabShow.Hide();
            pnlTab.Size = new Size(210, pnlControl.Height);
        }

        #endregion

        #region Events

        private void Tab_Click(object sender, EventArgs e)
        {
            PnlTab tab = (PnlTab)sender;
            if (tab.Name.Equals("tabShow"))
            {
                MaximizeTab();
            }
            else if (tab.Name.Equals("tabHide"))
            {
                MinimizeTab();
            }
            else if (tab.Name.Equals("tabSettings"))
            {
                if(pnlSettings.Visible) pnlSettings.Hide();
                else pnlSettings.Show();
            }
            else
            {
                foreach (Control p in pnlCenter.Controls)
                {
                    if (p is UserControl)
                    {
                        if (p.Name.Equals("PnlHome") && tab.Name.Equals("tabHome"))
                        {
                            p.Show();
                        }
                        else if (p.Name.Equals("PnlStartCashiering") && tab.Name.Equals("tabStartCashiering"))
                        {
                            p.Show();
                            PnlStartCashiering panel = (PnlStartCashiering)p;
                            panel.UpdateComponents();
                            MinimizeTab();
                        }
                        else if (p.Name.Equals("PnlManageInventory") && tab.Name.Equals("tabManageInventory"))
                        {
                            p.Show();
                            MinimizeTab();
                        }
                        else if (p.Name.Equals("PnlHelp") && tab.Name.Equals("tabHelp"))
                        {
                            p.Show();
                        }
                        else
                        {
                            p.Hide();
                        }
                        if (pnlSettings.Visible) pnlSettings.Hide();
                    }
                }
            }
        }

        #endregion
    }
}
