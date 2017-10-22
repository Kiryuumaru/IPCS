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
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties
        
        public Product Product { get; }

        #endregion

        #region Threads

        public void ReInitializeComponent()
        {
            lblPriceCurr.Text = Defaults.CurrencyChar;
            lblCostCurr.Text = Defaults.CurrencyChar;
            txtBoxName.Text = Product.ProductName;
            txtBoxPrice.Text = Product.Price.ToString("N");
            txtBoxCost.Text = Product.Cost.ToString("N");
            txtBoxQuantity.Text = Product.Quantity.ToString();
            productPicture.Image = Product.ProductPicture;
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
            this.DialogResult = DialogResult.Cancel;
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
                Product prod = new Product(id, name, price, cost, quantity, productPicture.Image);
                Program.User.Inventory.ReplaceProduct(Product.ID, prod);
                NotifText = "Product changes saved";
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                productPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        #endregion
    }
}
