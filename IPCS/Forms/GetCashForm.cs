using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace IPCS.Forms
{
    public partial class GetCashForm : CustomForm
    {
        #region Constructor

        public GetCashForm(double total)
        {
            Cash = 0;
            Total = total;
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties

        public double Cash;
        public double Total;

        #endregion

        #region Threads
        
        public void ReInitializeComponent()
        {
            lblCashCurr.Text = Defaults.CurrencyChar;
            lblTotalCurr.Text = Defaults.CurrencyChar;
            lblTotal.Text = Total.ToString("N");
            ActiveControl = txtBoxCash;
        }

        public void UpdateComponent()
        {

        }

        #endregion

        #region Events

        private void txtBoxCash_Click(object sender, EventArgs e)
        {
            txtBoxCash.SelectAll();
        }

        private void txtBoxCash_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cash = Convert.ToDouble(txtBoxCash.Text);
            } catch { }
            NotifSetDefault();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(Cash >= Total)
            {
                DialogResult = DialogResult.OK;
                Dispose();
            }
            else
            {
                NotifText = "Invalid input cash!";
                ActiveControl = txtBoxCash;
            }
        }

        #endregion
    }
}
