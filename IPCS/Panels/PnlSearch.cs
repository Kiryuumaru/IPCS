using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCS.Panels
{
    public partial class PnlSearch : UserControl
    {
        #region Constructor

        public PnlSearch()
        {
            InitializeComponent();
            ReInitializeComponent();
            UpdateComponent();
        }

        #endregion

        #region Properties

        [Category("Layout"), Browsable(true)]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                value.Height = 23;
                base.Size = value;
            }
        }

        private AutoCompleteStringCollection _AutoCompleteSource;
        [Category("Metro Appearance"), Browsable(true)]
        public AutoCompleteStringCollection AutoCompleteSource
        {
            get
            {
                return _AutoCompleteSource;
            }
            set
            {
                _AutoCompleteSource = value;
                comboBoxSearch.Items.Clear();
                for (int i = 0; i < _AutoCompleteSource.Count; i++)
                {
                    comboBoxSearch.Items.Add(_AutoCompleteSource[i]);
                }
            }
        }

        [Category("Appearance"), Browsable(true)]
        public new string Text
        {
            get
            {
                return txtBoxSearch.Text;
            }
            set
            {
                txtBoxSearch.Text = value;
            }
        }

        [Category("Metro Appearance"), Browsable(true)]
        public string WaterMark
        {
            get
            {
                return txtBoxSearch.WaterMark;
            }
            set
            {
                txtBoxSearch.WaterMark = value;
            }
        }

        [Category("Metro Appearance"), Browsable(true)]
        public Color WaterMarkColor
        {
            get
            {
                return txtBoxSearch.WaterMarkColor;
            }
            set
            {
                txtBoxSearch.WaterMarkColor = value;
            }
        }

        [Category("Metro Appearance"), Browsable(true)]
        public Font WaterMarkFont
        {
            get
            {
                return txtBoxSearch.WaterMarkFont;
            }
            set
            {
                txtBoxSearch.WaterMarkFont = value;
            }
        }

        #endregion

        #region Threads

        public void ReInitializeComponent()
        {
            if (AutoCompleteSource == null) AutoCompleteSource = new AutoCompleteStringCollection();
            for (int i = 0; i < AutoCompleteSource.Count; i++)
            {
                comboBoxSearch.Items.Add(AutoCompleteSource[i]);
            }
        }

        public void UpdateComponent()
        {

        }

        #endregion

        #region Events

        private void txtBoxSearch_Click(object sender, EventArgs e)
        {
            comboBoxSearch.DroppedDown = true;
            System.Threading.Thread.Sleep(100);
            txtBoxSearch.SelectAll();
        }

        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                comboBoxSearch.SelectedIndex = 0;
                System.Threading.Thread.Sleep(100);
                txtBoxSearch.SelectAll();
            }
        }

        private void txtBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            comboBoxSearch.Items.Clear();
            for (int i = 0; i < AutoCompleteSource.Count; i++)
            {
                if (AutoCompleteSource[i].Contains(txtBoxSearch.Text))
                {
                    comboBoxSearch.Items.Add(AutoCompleteSource[i]);
                }
            }
            if (comboBoxSearch.Items.Count == 0) comboBoxSearch.Items.Add("----------none----------");
            comboBoxSearch.DroppedDown = true;
        }

        private void comboBoxSearch_TextChanged(object sender, EventArgs e)
        {
            txtBoxSearch.Text = comboBoxSearch.Text;
        }

        #endregion
    }
}
