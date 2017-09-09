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
using IPCS.Forms;

namespace IPCS
{
    public partial class MetroForm : CustomForm
    {
        public MetroForm()
        {
            InitializeComponent();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void buttonOpenColor_Click(object sender, EventArgs e)
        {
            ColorPicker form = new ColorPicker(metroStyleManager);
            form.ShowDialog();
        }
    }
}
