using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCS.Forms
{
    public partial class GetCashForm : CustomForm
    {
        #region Constructor

        public GetCashForm()
        {
            InitializeComponent();
            Cash = 0;
        }

        #endregion

        #region Properties

        public int Cash;

        #endregion

        #region Threads



        #endregion

        #region Events

        private void txtBoxQuantity_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #endregion
    }
}
