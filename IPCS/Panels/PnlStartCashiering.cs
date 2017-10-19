using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace IPCS.Panels
{
    public partial class PnlStartCashiering : UserControl
    {
        #region Constructor

        public PnlStartCashiering(Form parent)
        {
            Parent = parent;
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponents();
        }

        #endregion

        #region Objects

        private class Item
        {
            public Item(Data.Product product, int quantity)
            {
                Product = product;
                Quantity = quantity;
                Total = quantity * product.Price;
            }

            public Data.Product Product;
            public int Quantity;
            public double Total;
        }

        #endregion

        #region Properties

        private List<Item> Cart;
        public new Form Parent;

        #endregion

        #region Threads

        public void ReInitializeComponent()
        {
            Cart = new List<Item>();
            CartColumn1.Tag = Data.Columns.ID;
            CartColumn2.Tag = Data.Columns.ProductName;
            CartColumn3.Tag = Data.Columns.Price;
            CartColumn4.Tag = Data.Columns.Cart_ItemQuantity;
            CartColumn5.Tag = Data.Columns.Cart_ItemTotal;

            ListColumn1.Tag = Data.Columns.ID;
            ListColumn2.Tag = Data.Columns.ProductName;
            ListColumn3.Tag = Data.Columns.Stock;
            ListColumn4.Tag = Data.Columns.Price;
        }

        public void UpdateComponents()
        {
            Program.User.Inventory.SetDataGridTable(metroGridList);
            SetCartGridTable(metroGridCart);
        }
        
        private void SetCartGridTable(DataGridView dataGridView)
        {
            List<object> data;
            Data.Columns column;
            dataGridView.Rows.Clear();
            foreach (Item item in Cart)
            {
                data = new List<object>();
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    column = (Data.Columns)dataGridView.Columns[i].Tag;
                    switch (column)
                    {
                        case Data.Columns.ID:
                            data.Add(item.Product.ID.ToString("0000"));
                            break;
                        case Data.Columns.ProductName:
                            data.Add(item.Product.ProductName);
                            break;
                        case Data.Columns.Price:
                            data.Add(Defaults.CurrencyChar + item.Product.Price.ToString("0.00"));
                            break;
                        case Data.Columns.Cart_ItemQuantity:
                            data.Add(item.Quantity);
                            break;
                        case Data.Columns.Cart_ItemTotal:
                            data.Add(Defaults.CurrencyChar + item.Total.ToString("0.00"));
                            break;
                    }
                }
                dataGridView.Rows.Add(data.ToArray());
            }
        }

        private void AddCart(Data.Product product, int quantity)
        {
            Item item = new Item(product, quantity);

            foreach(Item cartItem in Cart)
            {
                if(cartItem.Product.ID == item.Product.ID)
                {
                    cartItem.Quantity = quantity;
                    return;
                }
            }
            Cart.Add(item);
        }

        private void RefreshPrivControls()
        {
            SetCartGridTable(metroGridCart);
            MainForm form = (MainForm)Parent;
            form.NotifSetDefault();
        }

        #endregion

        #region Events

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = metroGridList.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = metroGridList.Rows[index];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Data.Product product = Program.User.Inventory.GetProduct(id);
                Forms.GetQuantityForm form = new Forms.GetQuantityForm(product);
                MainForm parent = (MainForm)Parent;
                form.Theme = parent.Theme;
                form.Style = parent.Style;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int quantity = form.Value;
                    AddCart(product, quantity);
                    RefreshPrivControls();
                }
            }
            catch
            {
                MainForm form = (MainForm)Parent;
                form.NotifText = "Select product first";
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = metroGridCart.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = metroGridCart.Rows[index];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                for(int i = 0; i < Cart.Count; i++)
                {
                    if (Cart[i].Product.ID == id)
                    {
                        Cart.Remove(Cart[i]);
                        RefreshPrivControls();
                    }
                }
            }
            catch
            {
                MainForm form = (MainForm)Parent;
                form.NotifText = "Select product first";
            }
        }

        #endregion
    }
}
