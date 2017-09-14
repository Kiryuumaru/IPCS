using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace IPCS
{
    public class StyleMethods
    {
        public static string ToString(MetroStyleManager manager)
        {
            string output = "";

            switch (manager.Theme)
            {
                case MetroThemeStyle.Dark: output += "Dark"; break;
                case MetroThemeStyle.Light: output += "Light"; break;
                default: output += "Light"; break;
            }
            output += ":";
            switch (manager.Style)
            {
                case MetroColorStyle.Black: output += "Black"; break;
                case MetroColorStyle.Blue: output += "Blue"; break;
                case MetroColorStyle.Brown: output += "Brown"; break;
                case MetroColorStyle.Green: output += "Green"; break;
                case MetroColorStyle.Lime: output += "Lime"; break;
                case MetroColorStyle.Magenta: output += "Magenta"; break;
                case MetroColorStyle.Orange: output += "Orange"; break;
                case MetroColorStyle.Pink: output += "Pink"; break;
                case MetroColorStyle.Purple: output += "Purple"; break;
                case MetroColorStyle.Red: output += "Red"; break;
                case MetroColorStyle.Silver: output += "Silver"; break;
                case MetroColorStyle.Teal: output += "Teal"; break;
                case MetroColorStyle.White: output += "White"; break;
                case MetroColorStyle.Yellow: output += "Yellow"; break;
                default: output += "Blue"; break;
            }

            return output;
        }

        public static MetroStyleManager ToManager(string output)
        {
            MetroStyleManager manager = new MetroStyleManager();
            string theme = output.Substring(0, output.IndexOf(':'));
            string style = output.Substring(output.IndexOf(':')+1);

            if (theme.Equals("Dark")) manager.Theme = MetroThemeStyle.Dark;
            else if (theme.Equals("Light")) manager.Theme = MetroThemeStyle.Light;
            else manager.Theme = MetroThemeStyle.Light;

            if (style.Equals("Black")) manager.Style = MetroColorStyle.Black;
            else if (style.Equals("Blue")) manager.Style = MetroColorStyle.Blue;
            else if (style.Equals("Brown")) manager.Style = MetroColorStyle.Brown;
            else if (style.Equals("Green")) manager.Style = MetroColorStyle.Green;
            else if (style.Equals("Lime")) manager.Style = MetroColorStyle.Lime;
            else if (style.Equals("Magenta")) manager.Style = MetroColorStyle.Magenta;
            else if (style.Equals("Orange")) manager.Style = MetroColorStyle.Orange;
            else if (style.Equals("Pink")) manager.Style = MetroColorStyle.Pink;
            else if (style.Equals("Purple")) manager.Style = MetroColorStyle.Purple;
            else if (style.Equals("Red")) manager.Style = MetroColorStyle.Red;
            else if (style.Equals("Silver")) manager.Style = MetroColorStyle.Silver;
            else if (style.Equals("Teal")) manager.Style = MetroColorStyle.Teal;
            else if (style.Equals("White")) manager.Style = MetroColorStyle.White;
            else if (style.Equals("Yellow")) manager.Style = MetroColorStyle.Yellow;
            else manager.Style = MetroColorStyle.Blue;

            return manager;
        }

        public static System.Drawing.Color ToSystemColor(MetroColorStyle style)
        {
            switch (style)
            {
                case MetroColorStyle.Black: return MetroColors.Black;
                case MetroColorStyle.Blue: return MetroColors.Blue;
                case MetroColorStyle.Brown: return MetroColors.Brown;
                case MetroColorStyle.Green: return MetroColors.Green;
                case MetroColorStyle.Lime: return MetroColors.Lime;
                case MetroColorStyle.Magenta: return MetroColors.Magenta;
                case MetroColorStyle.Orange: return MetroColors.Orange;
                case MetroColorStyle.Pink: return MetroColors.Pink;
                case MetroColorStyle.Purple: return MetroColors.Purple;
                case MetroColorStyle.Red: return MetroColors.Red;
                case MetroColorStyle.Silver: return MetroColors.Silver;
                case MetroColorStyle.Teal: return MetroColors.Teal;
                case MetroColorStyle.White: return MetroColors.White;
                case MetroColorStyle.Yellow: return MetroColors.Yellow;
                default: return MetroColors.Blue;
            }
        }

        public static System.Drawing.Color ToSystemColor(MetroThemeStyle theme)
        {
            switch (theme)
            {
                case MetroThemeStyle.Light: return MetroColors.White;
                case MetroThemeStyle.Dark: return MetroColors.Black;
                default : return MetroColors.White;
            }
        }

        public static System.Drawing.Color AdjustBrightness(System.Drawing.Color c1, double factor)
        {
            if (factor < 0)
            {
                factor = 1 - (-factor);
                return System.Drawing.Color.FromArgb(c1.A, (int)(c1.R * factor), (int)(c1.G * factor), (int)(c1.B * factor));
            }
            double temp = factor * 255;
            return System.Drawing.Color.FromArgb((int)(255 - temp), c1.R, c1.G, c1.B);
        }
    }
}
