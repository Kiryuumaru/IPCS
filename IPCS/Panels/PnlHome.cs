using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCS.Data;

namespace IPCS.Panels
{
    public partial class PnlHome : UserControl
    {
        #region Constructor

        public PnlHome()
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
            double totalSale = 0;
            double totalGain = 0;
            string warnings = "";
            foreach(Product product in Program.User.Inventory.Products)
            {
                totalSale += product.CurrentSale;
                totalGain += product.CurrentGain;
                if (product.Stock == 0)
                {
                    warnings += Environment.NewLine;
                    warnings += product.ProductName;
                }
            }
            lblTotalSale.Text = "Total sale: " + Defaults.CurrencyChar + totalSale.ToString("N");
            lblTotalGain.Text = "Total gain: " + Defaults.CurrencyChar + totalGain.ToString("N");

            if (warnings == "")
            {
                lblWarnings.Hide();
            }
            else
            {
                lblWarnings.Text = "Out of stock products: " + warnings;
            }

        }

        public void UpdateComponent()
        {

        }

        #endregion
    }
}
