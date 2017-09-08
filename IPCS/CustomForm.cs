using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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

        private bool customControlBox = true;
        [Category("Window Style"), Browsable(true)]
        [Description("Custom control box from CustomForm")]
        public bool CustomControlBox
        {
            get { return customControlBox; }
            set { customControlBox = value; }
        }

        #region Windows ControlBox

        private Controls.MetroLink windowClose;
        private Controls.MetroLink windowMaximize;
        private Controls.MetroLink windowMinimize;
        private Controls.MetroPanel CustomPanelWinControl;
        private void AddControlBox()
        {
            if (!CustomControlBox) return;
            windowClose = new Controls.MetroLink();
            windowMaximize = new Controls.MetroLink();
            windowMinimize = new Controls.MetroLink();
            CustomPanelWinControl = new Controls.MetroPanel();
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
            windowClose.Image = global::IPCS.Properties.Resources.x_white;
            windowClose.NoFocusImage = global::IPCS.Properties.Resources.x_white;
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
            windowMinimize.Image = global::IPCS.Properties.Resources.line_white;
            windowMinimize.NoFocusImage = global::IPCS.Properties.Resources.line_white;
            windowMinimize.MouseHover += WindowMinimize_MouseHover;
            windowMinimize.MouseDown += WindowMinimize_MouseDown;
            windowMinimize.MouseClick += WindowMinimize_MouseClick;
            // 
            // CustomPanelWinControl
            // 
            CustomPanelWinControl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            CustomPanelWinControl.Controls.Add(windowClose);
            CustomPanelWinControl.Controls.Add(windowMinimize);
            CustomPanelWinControl.Controls.Add(windowMaximize);
            CustomPanelWinControl.Margin = new Padding(0);
            CustomPanelWinControl.Size = new Size(135, 30);
            CustomPanelWinControl.TabIndex = 0;

            Controls.Add(CustomPanelWinControl);

            RefreshControlBox();
        }

        private void WindowMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void WindowMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void WindowMinimize_MouseHover(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RefreshControlBox()
        {
            if (!CustomControlBox) return;

            if (WindowState == FormWindowState.Maximized)
            {
                windowMaximize.Image = global::IPCS.Properties.Resources.drect_white;
                windowMaximize.NoFocusImage = global::IPCS.Properties.Resources.drect_white;
            }
            else
            {
                windowMaximize.Image = global::IPCS.Properties.Resources.rect_white;
                windowMaximize.NoFocusImage = global::IPCS.Properties.Resources.rect_white;
            }
            Color colorTheme = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.5);
            windowClose.BackColor = colorTheme;
            windowMaximize.BackColor = colorTheme;
            windowMinimize.BackColor = colorTheme;
            CustomPanelWinControl.Location = new Point(ClientSize.Width - 135, 0);
        }
        
        #endregion
    }
}
