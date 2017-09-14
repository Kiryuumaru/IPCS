using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPCS.Forms;

namespace IPCS
{

    public partial class MainForm : CustomForm
    {
        public MainForm()
        {
            Program.MainStyleManager.Owner = this;
            InitializeComponent();
            UpdateComponents();
            Panels.PnlMain panel = new Panels.PnlMain();
            panel.Parent = this;
            pnlMain.Controls.Add(panel);
        }

        public void UpdateComponents()
        {
            StyleManager = Program.MainStyleManager;
            RefreshComponents();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Program.Logout();
            Application.Exit();
        }
    }
}
