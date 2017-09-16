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
            InitializeComponent();
            UpdateComponents();
        }

        public void UpdateComponents()
        {
            Program.MainStyleManager.Owner = this;
            StyleManager = Program.MainStyleManager;
            pnlMain.Controls.Add(new Panels.PnlMain());
            StyleManager.Update();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Program.Logout();
            Application.Exit();
        }
    }
}
