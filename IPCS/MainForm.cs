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

namespace IPCS
{
    public partial class MainForm : CustomForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTheme_Click(object sender, EventArgs e)
        {
            if (metroStyleManager.Theme == MetroFramework.MetroThemeStyle.Light) metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;
        }
    }
}
