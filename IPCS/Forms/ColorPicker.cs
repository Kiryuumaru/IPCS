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

namespace IPCS.Forms
{
    public partial class ColorPicker : CustomForm
    {
        MetroStyleManager metroStyleManager;
        public ColorPicker(MetroStyleManager styleManager)
        {
            InitializeComponent();
            metroStyleManager = styleManager;
            metroStyleManagerPicker.Theme = metroStyleManager.Theme;
            metroStyleManagerPicker.Style = metroStyleManager.Style;
            if (styleManager.Theme == MetroThemeStyle.Dark) metroToggle.CheckState = CheckState.Checked;
        }

        public MetroStyleManager GetStyleManager
        {
            get { return metroStyleManagerPicker; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            metroStyleManager.Theme = metroStyleManagerPicker.Theme;
            metroStyleManager.Style = metroStyleManagerPicker.Style;
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
