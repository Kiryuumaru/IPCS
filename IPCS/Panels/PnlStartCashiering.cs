﻿using System;
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
using IPCS.Data;

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

            AutoCompleteStringCollection itemList = new AutoCompleteStringCollection();
            foreach (Data.Product item in Program.User.Inventory.Products)
            {
                itemList.Add(item.ID.ToString("0000") + " : " + item.ProductName);
            }
            pnlSearch.AutoCompleteSource = itemList;
            RefreshItemViewer();
        }

        public void UpdateComponents()
        {
            RefreshItemViewer();
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
            RefreshItemViewer();
        }

        private void RefreshItemViewer()
        {
            try
            {
                int index = metroGridCart.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = metroGridCart.Rows[index];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                for (int i = 0; i < Cart.Count; i++)
                {
                    if (Cart[i].Product.ID == id)
                    {
                        productPicture.Image = Cart[i].Product.ProductPicture;
                        lblId.Text = Cart[i].Product.ID.ToString("0000");
                        lblName.Text = Cart[i].Product.ProductName;
                        lblPrice.Text = Defaults.CurrencyChar + Cart[i].Product.Price.ToString("0.00");
                        lblQuantity.Text = Cart[i].Quantity.ToString();
                        lblStock.Text = Cart[i].Product.Stock.ToString();
                        lblTotal.Text = Defaults.CurrencyChar + Cart[i].Total.ToString("0.00");
                        break;
                    }
                }
            }
            catch
            {
                productPicture.Image = null;
                lblId.Text = "N/A";
                lblName.Text = "N/A";
                lblPrice.Text = "N/A";
                lblQuantity.Text = "N/A";
                lblStock.Text = "N/A";
                lblTotal.Text = "N/A";
            }
            double total = 0;
            foreach(Item item in Cart)
            {
                total += item.Total;
            }
            lblTotalCash.Text = "Total :  " + Defaults.CurrencyChar + total.ToString("0.00");
            int newWidth = (int)((metroPanelTotal.Width / 2) - (lblTotalCash.Width / 2));
            lblTotalCash.Location = new Point(newWidth, 18);
        }

        #endregion

        #region Events

        private void metroGridCart_SelectionChanged(object sender, EventArgs e)
        {
            RefreshItemViewer();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)Parent;
            if (Cart.Count != 0)
            {
                Forms.ReceiptForm form = new Forms.ReceiptForm(Cart);
                form.StyleManager = Program.MainStyleManager;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Cart.Clear();
                    RefreshPrivControls();
                }
            }
            else
            {
                parent.NotifText = "Cart is empty!";
            }
        }

        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblId.Text.ToString());
                Data.Product product = Program.User.Inventory.GetProduct(id);
                int currentQuantity = 1;
                foreach(Item item in Cart) if (item.Product.ID == product.ID) currentQuantity = item.Quantity;
                Forms.GetQuantityForm form = new Forms.GetQuantityForm(product, currentQuantity);
                form.StyleManager = Program.MainStyleManager;
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string text = pnlSearch.Text.Substring(0, pnlSearch.Text.IndexOf(':') - 1);
                int id = Convert.ToInt32(text);
                Data.Product product = Program.User.Inventory.GetProduct(id);
                Forms.GetQuantityForm form = new Forms.GetQuantityForm(product, 1);
                form.StyleManager = Program.MainStyleManager;
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
                        break;
                    }
                }
            }
            catch
            {
                MainForm form = (MainForm)Parent;
                form.NotifText = "Select product first";
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            Cart.Clear();
            RefreshPrivControls();
        }

        #endregion
    }
}
