using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace IPCS
{
    public partial class MainForm : CustomForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenColor_Click(object sender, EventArgs e)
        {
            ColorPicker form = new ColorPicker(metroStyleManager);
            form.ShowDialog();
        }
    }
}
