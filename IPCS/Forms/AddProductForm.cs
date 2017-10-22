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
using MetroFramework.Controls;

namespace IPCS.Forms
{
    public partial class AddProductForm : CustomForm
    {
        #region Constructor

        public AddProductForm()
        {
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties



        #endregion

        #region Threads

        public void ReInitializeComponent()
        {
            lblPriceCurr.Text = Defaults.CurrencyChar;
            lblCostCurr.Text = Defaults.CurrencyChar;
        }

        public void UpdateComponent()
        {

        }

        #endregion

        #region Events

        private void doubleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && (sender as MetroTextBox).Text.IndexOf('.') > -1)
            {
                if ((sender as MetroTextBox).Text.Length - (sender as MetroTextBox).Text.IndexOf('.') > 2)
                {
                    e.Handled = true;
                }
            }

            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void integerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NotifText = "Adding product";
            try
            {
                int id = Program.User.Inventory.ProductCount + 1;
                string name = txtBoxName.Text;
                double price = Convert.ToDouble(txtBoxPrice.Text);
                double cost = Convert.ToDouble(txtBoxCost.Text);
                int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                if (price <= 0 || cost <= 0 || quantity <= 0) throw new Exception();
                Data.Product prod = new Data.Product(id, name, price, cost, quantity, productPicture.Image);
                Program.User.Inventory.AddProduct(prod);
                NotifText = "New product added";
                DialogResult = DialogResult.OK;
                Dispose();
            }
            catch
            {
                NotifText = "Invalid input(s)!";
            }
        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                productPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        #endregion
    }
}
