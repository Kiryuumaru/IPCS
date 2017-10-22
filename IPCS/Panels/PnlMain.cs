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
using System.Threading;

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

            tabResize.Tag = "Maximized";
            pnlSettings.Hide();
            Tab_Click(tabHome, new EventArgs());
        }

        public void UpdateComponent()
        {

        }

        private void MinimizeTab()
        {
            string tag = (string)tabResize.Tag;
            if (tag == "Minimized") return;
            for (int i = 210; i >= 50; i -= 50)
            {
                pnlTab.Size = new Size(i, pnlControl.Height);
            }
            pnlTab.Size = new Size(50, pnlControl.Height);
            tabResize.Image = Properties.Resources.ic_chevron_right_gray_48pt_2x;
            tabResize.LightThemeImage = Properties.Resources.ic_chevron_right_black_48pt_2x;
            tabResize.DarkThemeImage = Properties.Resources.ic_chevron_right_white_48pt_2x;
            tabResize.Tag = "Minimized";
        }

        private void MaximizeTab()
        {
            string tag = (string)tabResize.Tag;
            if (tag == "Maximized") return;
            for (int i = 50; i <= 210; i += 50)
            {
                pnlTab.Size = new Size(i, pnlControl.Height);
            }
            pnlTab.Size = new Size(210, pnlControl.Height);
            tabResize.Image = Properties.Resources.ic_chevron_left_gray_48pt_2x;
            tabResize.LightThemeImage = Properties.Resources.ic_chevron_left_black_48pt_2x;
            tabResize.DarkThemeImage = Properties.Resources.ic_chevron_left_white_48pt_2x;
            tabResize.Tag = "Maximized";
        }

        #endregion

        #region Events

        private void Tab_Click(object sender, EventArgs e)
        {
            PnlTab tab = (PnlTab)sender;
            if (tab.Name.Equals("tabResize"))
            {
                string tag = (string)tab.Tag;
                if (tag == "Maximized")
                {
                    MinimizeTab();
                }
                else
                {
                    MaximizeTab();
                }
            }
            else if (tab.Name.Equals("tabSettings"))
            {
                if (pnlSettings.Visible) pnlSettings.Hide();
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
                            PnlStartCashiering panel = (PnlStartCashiering)p;
                            panel.ReInitializeComponent();
                            panel.UpdateComponents();
                            p.Show();
                            MinimizeTab();
                        }
                        else if (p.Name.Equals("PnlManageInventory") && tab.Name.Equals("tabManageInventory"))
                        {
                            PnlManageInventory panel = (PnlManageInventory)p;
                            panel.ReInitializeComponent();
                            panel.UpdateComponents();
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
