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
    public partial class AccountSettings : CustomForm
    {
        MetroStyleManager metroStyleManager;
        public AccountSettings(MetroStyleManager styleManager)
        {
            InitializeComponent();
            UpdateComponents();
            metroStyleManager = styleManager;
        }

        public void UpdateComponents()
        {
            tileYellow.Tag = MetroColorStyle.Yellow;
            tileRed.Tag = MetroColorStyle.Red;
            tilePurple.Tag = MetroColorStyle.Purple;
            tileMagenta.Tag = MetroColorStyle.Magenta;
            tilePink.Tag = MetroColorStyle.Pink;
            tileOrange.Tag = MetroColorStyle.Orange;
            tileBrown.Tag = MetroColorStyle.Brown;
            tileTeal.Tag = MetroColorStyle.Teal;
            tileSilver.Tag = MetroColorStyle.Silver;
            tileBlue.Tag = MetroColorStyle.Blue;
            tileGreen.Tag = MetroColorStyle.Green;
            tileLime.Tag = MetroColorStyle.Lime;
            if (metroStyleManagerPicker.Theme == MetroThemeStyle.Dark) metroToggle.CheckState = CheckState.Checked;
            RefreshComponents();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Program.StyleManager.Theme = metroStyleManagerPicker.Theme;
            Program.StyleManager.Style = metroStyleManagerPicker.Style;
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
