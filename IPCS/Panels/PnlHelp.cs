using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCS.Panels
{
    public partial class PnlHelp : UserControl
    {
        #region Constructor

        public PnlHelp()
        {
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties



        #endregion

        #region Thread

        public void ReInitializeComponent()
        {
            lblVersion.Text = Application.ProductVersion;
            lblCopyright.Text = Properties.Resources.Copyright;

        }

        public void UpdateComponent()
        {

        }

        #endregion

        #region Events

        private void lblLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.Website);
        }

        #endregion
    }
}
