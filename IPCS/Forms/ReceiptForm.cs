using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using IPCS.Data;

namespace IPCS.Forms
{
    public partial class ReceiptForm : CustomForm
    {
        #region Constructor

        public ReceiptForm(List<Item> cart)
        {
            Cart = cart;
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties

        private List<Item> Cart;

        #endregion

        #region Threads

        public void ReInitializeComponent()
        {

        }
        
        public void UpdateComponent()
        {

        }

        #endregion

        #region Events



        #endregion
    }
}
