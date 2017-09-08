using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;

namespace IPCS
{
    public class ColorMethods
    {
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
