using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPCS.Forms;
using MetroFramework;

namespace IPCS.Panels
{
    public partial class PnlManageInventory : UserControl
    {
        #region Constructor

        public PnlManageInventory(Form parent)
        {
            Parent = parent;
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponents();
        }

        #endregion

        #region Properties

        public new Form Parent { get; }

        #endregion

        #region Threads

        private void ReInitializeComponent()
        {
            pnlAdminPrivilege.Hide();
            pnlUnlockPrivilege.Show();
            InventoryColumn1.Tag = Data.Columns.ID;
            InventoryColumn2.Tag = Data.Columns.ProductName;
            InventoryColumn3.Tag = Data.Columns.Price;
            InventoryColumn4.Tag = Data.Columns.Cost;
            InventoryColumn5.Tag = Data.Columns.Stock;
            InventoryColumn6.Tag = Data.Columns.CurrentSale;
            InventoryColumn7.Tag = Data.Columns.ExpextedSale;
            InventoryColumn8.Tag = Data.Columns.CurrentGain;
            InventoryColumn9.Tag = Data.Columns.ExpectedGain;
        }

        private void UpdateComponents()
        {
            Program.User.Inventory.SetDataGridTable(metroGridInventory);
        }

        private void btnHidePrivelege_Click(object sender, EventArgs e)
        {
            pnlAdminPrivilege.Hide();
            pnlUnlockPrivilege.Show();
            txtBoxPassword.Text = "";
            MainForm form = (MainForm)Parent;
            form.NotifSetDefault();
        }

        private void RefreshPrivControls()
        {
            int index;
            try { index = metroGridInventory.CurrentCell.RowIndex; }
            catch { index = 0; }
            UpdateComponents();
            MainForm form = (MainForm)Parent;
            form.NotifSetDefault();
            metroGridInventory.Rows[index].Selected = true;
        }

        #endregion

        #region Events

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (Program.User.CheckPassword(txtBoxPassword.Text))
            {
                pnlAdminPrivilege.Show();
                pnlUnlockPrivilege.Hide();
                MainForm form = (MainForm)Parent;
                form.NotifSetDefault();
            }
            else
            {
                MainForm form = (MainForm)Parent;
                form.NotifText = "Admin password is wrong!";
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int index = metroGridInventory.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = metroGridInventory.Rows[index];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Data.Product product = Program.User.Inventory.GetProduct(id);
                EditProductForm form = new EditProductForm(product);
                MainForm formParent = (MainForm)Parent;
                form.Theme = formParent.Theme;
                form.Style = formParent.Style;
                form.ShowDialog();
                RefreshPrivControls();
            }
            catch
            {
                MainForm form = (MainForm)Parent;
                form.NotifText = "Select product first";
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            MainForm formParent = (MainForm)Parent;
            form.Theme = formParent.Theme;
            form.Style = formParent.Style;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshPrivControls();
                MetroMessageBox.Show(this, "You successfully added new product!", "Add product", MessageBoxButtons.OK, 150);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int index = metroGridInventory.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = metroGridInventory.Rows[index];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                DialogResult dialogResult = MetroMessageBox.Show(this, "Are you sure to delete " + Program.User.Inventory.Products[id-1].ProductName + "(s) data?", "Delete Product", MessageBoxButtons.YesNo, 150);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.User.Inventory.DeleteProduct(id);
                    RefreshPrivControls();
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
