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
using IPCS.Data;

namespace IPCS.Forms
{
    public partial class EditProductForm : CustomForm
    {
        #region Constructor

        public EditProductForm(Product product)
        {
            Product = product;
            InitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties
        
        public Product Product { get; }

        #endregion

        #region Threads

        public void UpdateComponent()
        {
            txtBoxName.Text = Product.ProductName;
            txtBoxPrice.Text = Product.Price.ToString("0.00");
            txtBoxCost.Text = Product.Cost.ToString("0.00");
            txtBoxQuantity.Text = Product.Quantity.ToString();
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
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NotifText = "Saving product changes";
            try
            {
                int id = Program.User.Inventory.ProductCount + 1;
                string name = txtBoxName.Text;
                double price = Convert.ToDouble(txtBoxPrice.Text);
                double cost = Convert.ToDouble(txtBoxCost.Text);
                int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                if (price <= 0 || cost <= 0 || quantity <= 0) throw new Exception();
                Data.Product prod = new Data.Product(id, name, price, cost, quantity);
                Program.User.Inventory.ReplaceProduct(Product.ID, prod);
                NotifText = "Product changes saved";
                MetroMessageBox.Show(this, "You successfully saved product changes!", "Edit product", MessageBoxButtons.OK, 150);
                Dispose();
            }
            catch
            {
                NotifText = "Invalid input: input must be non-negative and non-zero integer";
            }
            Dispose();
        }

        #endregion
    }
}
