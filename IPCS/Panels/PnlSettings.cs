using System;
using System.Windows.Forms;
using System.Threading;
using MetroFramework;
using MetroFramework.Controls;

namespace IPCS.Panels
{
    public partial class PnlSettings : UserControl
    {
        public PnlSettings()
        {
            InitializeComponent();
            UpdateComponents();
            ConponentTransitions();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void UpdateComponents()
        {
            tileYellow.Tag = MetroColorStyle.Yellow;
            tileYellow.BackColor = MetroColors.Yellow;
            tileRed.Tag = MetroColorStyle.Red;
            tileRed.BackColor = MetroColors.Red;
            tilePurple.Tag = MetroColorStyle.Purple;
            tilePurple.BackColor = MetroColors.Purple;
            tileMagenta.Tag = MetroColorStyle.Magenta;
            tileMagenta.BackColor = MetroColors.Magenta;
            tilePink.Tag = MetroColorStyle.Pink;
            tilePink.BackColor = MetroColors.Pink;
            tileOrange.Tag = MetroColorStyle.Orange;
            tileOrange.BackColor = MetroColors.Orange;
            tileBrown.Tag = MetroColorStyle.Brown;
            tileBrown.BackColor = MetroColors.Brown;
            tileTeal.Tag = MetroColorStyle.Teal;
            tileTeal.BackColor = MetroColors.Teal;
            tileSilver.Tag = MetroColorStyle.Silver;
            tileSilver.BackColor = MetroColors.Silver;
            tileBlue.Tag = MetroColorStyle.Blue;
            tileBlue.BackColor = MetroColors.Blue;
            tileGreen.Tag = MetroColorStyle.Green;
            tileGreen.BackColor = MetroColors.Green;
            tileLime.Tag = MetroColorStyle.Lime;
            tileLime.BackColor = MetroColors.Lime;
            if (Program.MainStyleManager.Theme == MetroThemeStyle.Dark) metroToggle.CheckState = CheckState.Checked;
        }

        public void ConponentTransitions()
        {
            //Thread thread = new Thread(new ThreadStart(ConponentTransitions));
        }

        private void Tile_MouseClick(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            MetroColorStyle colorStyle = (MetroColorStyle)tile.Tag;
            Program.MainStyleManager.Style = colorStyle;

        }

        private void Toggle_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = metroToggle.CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    Program.MainStyleManager.Theme = MetroThemeStyle.Dark;
                    break;
                case CheckState.Unchecked:
                    Program.MainStyleManager.Theme = MetroThemeStyle.Light;
                    break;
                case CheckState.Indeterminate:
                    Program.MainStyleManager.Theme = MetroThemeStyle.Default;
                    break;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Program.Logout();
            Application.Restart();
        }
    }
}