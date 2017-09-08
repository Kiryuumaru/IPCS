using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using IPCS;

namespace MetroFramework.Forms
{
    public partial class CustomForm : MetroForm
    {
        #region Constructor

        public CustomForm()
        {
            base.ControlBox = false;
            AddControlBox();
        }

        #endregion

        #region Paint Method

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.5));
            e.Graphics.FillRectangle(brush, 0, 0, Width, 30);
            RefreshControlBox();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion

        private bool CustomControlBox = true;
        [Category("Window Style"), Browsable(true)]
        [Description("Custom control box from CustomForm")]
        public new bool ControlBox
        {
            get
            {
                Validate();
                return CustomControlBox;
            }
            set
            {
                CustomControlBox = value;
                Validate();
            }
        }

        #region Windows ControlBox

        private enum WindowButtons
        {
            Minimize,
            Maximize,
            Close
        }

        private void AddControlBox()
        {
            if (!CustomControlBox) return;

            Controls.MetroLink windowClose = new Controls.MetroLink();
            Controls.MetroLink windowMaximize = new Controls.MetroLink();
            Controls.MetroLink windowMinimize = new Controls.MetroLink();
            Controls.MetroPanel CustomPanelWinControl = new Controls.MetroPanel();
            // 
            // windowClose
            // 
            windowClose.ImageSize = 32;
            windowClose.Location = new Point(90, 0);
            windowClose.Margin = new Padding(0);
            windowClose.Size = new Size(45, 30);
            windowClose.TabStop = false;
            windowClose.Theme = Theme;
            windowClose.UseCustomBackColor = true;
            windowClose.UseSelectable = true;
            // 
            // windowMaximize
            // 
            windowMaximize.ImageSize = 32;
            windowMaximize.Location = new Point(45, 0);
            windowMaximize.Margin = new Padding(0);
            windowMaximize.Size = new Size(45, 30);
            windowMaximize.TabStop = false;
            windowMaximize.Theme = Theme;
            windowMaximize.UseCustomBackColor = true;
            windowMaximize.UseSelectable = true;
            // 
            // windowMinimize
            // 
            windowMinimize.ImageSize = 32;
            windowMinimize.Location = new Point(0, 0);
            windowMinimize.Margin = new Padding(0);
            windowMinimize.Size = new Size(45, 30);
            windowMinimize.TabStop = false;
            windowMinimize.Theme = Theme;
            windowMinimize.UseCustomBackColor = true;
            windowMinimize.UseSelectable = true;
            // 
            // CustomPanelWinControl
            // 
            CustomPanelWinControl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            CustomPanelWinControl.Controls.Add(windowClose);
            CustomPanelWinControl.Controls.Add(windowMinimize);
            CustomPanelWinControl.Controls.Add(windowMaximize);
            CustomPanelWinControl.Margin = new Padding(0);
            CustomPanelWinControl.Name = "CustomPanelWinControl";
            CustomPanelWinControl.Size = new Size(135, 30);
            CustomPanelWinControl.TabIndex = 0;

            Controls.Add(CustomPanelWinControl);

            RefreshControlBox();
        }

        private void RefreshControlBox()
        {
            //if (DesignMode) return;
            //if (!CustomControlBox) return;

            //if (WindowState == FormWindowState.Maximized)
            //{
            //    windowMaximize.Image = Properties.Resources.maximize2_white;
            //    windowMaximize.NoFocusImage = Properties.Resources.maximize2_white;
            //}
            //else
            //{
            //    windowMaximize.Image = Properties.Resources.maximize1_white;
            //    windowMaximize.NoFocusImage = Properties.Resources.maximize1_white;
            //}
            //Color colorTheme = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.5);
            //windowClose.BackColor = colorTheme;
            //windowMaximize.BackColor = colorTheme;
            //windowMinimize.BackColor = colorTheme;
            //CustomPanelWinControl.Location = new Point(ClientSize.Width - 135, 0);
        }

        #endregion
    }
}
