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

        public ReceiptForm(List<Item> cart, double cash)
        {
            Cart = cart;
            Cash = cash;
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties

        private List<Item> Cart;
        private double Total;
        private double Cash;

        #endregion

        #region Threads

        public void ReInitializeComponent()
        {
            txtBoxReceipt.Text = ReceiptFormat();
        }

        public void UpdateComponent()
        {

        }

        private string ReceiptFormat()
        {
            List<string> value = new List<string>();
            string output = "";
            double change;
            string name;
            string qty;
            string price;
            string subTotal;

            value.Add("-------------------------------------------------------");
            value.Add("Qty  Label Name          Price           Total");
            foreach (Item item in Cart)
            {
                qty = String.Format("{0,-5}", item.Quantity.ToString());
                name = String.Format("{0,-20}", item.Product.ProductName);
                price = Defaults.CurrencyChar + String.Format("{0,-15}", item.Product.Price.ToString("N"));
                subTotal = Defaults.CurrencyChar + String.Format("{0,-15}", item.Total.ToString("N"));
                value.Add(qty + name + price + subTotal);

                Total += item.Total;
            }
            change = Cash - Total;
            value.Add("");
            value.Add(String.Format("{0,56}", String.Format("{0,-24}", " Total : " + Defaults.CurrencyChar + Total.ToString("N"))));
            value.Add(String.Format("{0,56}", String.Format("{0,-24}", "  Cash : " + Defaults.CurrencyChar + Cash.ToString("N"))));
            value.Add(String.Format("{0,56}", String.Format("{0,-24}", "Change : " + Defaults.CurrencyChar + change.ToString("N"))));
            value.Add("-------------------------------------------------------");

            foreach (string line in value)
            {
                output += line;
                output += Environment.NewLine;
            }

            return output;
        }

        #endregion

        #region Events



        #endregion
    }
}
