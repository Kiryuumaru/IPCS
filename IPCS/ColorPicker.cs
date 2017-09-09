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
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace IPCS
{
    public partial class ColorPicker : MetroForm
    {
        public ColorPicker(MetroStyleManager style)
        {
            InitializeComponent();
            metroStyleManagerPicker = style;
        }

        public MetroStyleManager GetStyleManager
        {
            get { return metroStyleManagerPicker; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            metroStyleManagerPicker.Update();
        }

        private void Tile_MouseClick(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            MetroColorStyle colorStyle = (MetroColorStyle)tile.Tag;
            metroStyleManagerPicker.Style = colorStyle;
        }

        private void metroToggle_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = metroToggle.CheckState;
            if (state == CheckState.Checked) metroStyleManagerPicker.Theme = MetroThemeStyle.Dark;
            if (state == CheckState.Unchecked) metroStyleManagerPicker.Theme = MetroThemeStyle.Light;
            if (state == CheckState.Indeterminate) metroStyleManagerPicker.Theme = MetroThemeStyle.Default;
        }
    }
}
