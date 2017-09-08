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
            base.DisplayHeader = false;
            AddControlBox();
        }

        #endregion

        #region Paint Method

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.5));
            Pen pen = new Pen(brush, 3);
            e.Graphics.FillRectangle(brush, 0, 0, Width, 30);
            e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            RefreshControlBox();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion

        private bool _ControlBox = true;
        [Category("Window Style"), Browsable(true)]
        [Description("Custom control box from CustomForm")]
        public new bool ControlBox
        {
            get { return _ControlBox; }
            set { _ControlBox = value; }
        }

        #region Windows ControlBox

        private enum WindowsButton
        {
            close, maximized, minimized, tray
        }

        private Controls.MetroLink windowClose;
        private Controls.MetroLink windowMaximize;
        private Controls.MetroLink windowTray;
        private Controls.MetroPanel CustomPanelWinControl;
        private void AddControlBox()
        {
            if (!ControlBox) return;
            windowClose = new Controls.MetroLink();
            windowMaximize = new Controls.MetroLink();
            windowTray = new Controls.MetroLink();
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
            windowClose.MouseEnter += WindowButton_MouseEnter;
            windowClose.MouseClick += WindowButton_MouseClick;
            windowClose.MouseLeave += WindowButton_MouseLeave;
            windowClose.Tag = WindowsButton.close;
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
            windowMaximize.MouseEnter += WindowButton_MouseEnter;
            windowMaximize.MouseClick += WindowButton_MouseClick;
            windowMaximize.MouseLeave += WindowButton_MouseLeave;
            // 
            // windowTray
            // 
            windowTray.ImageSize = 32;
            windowTray.Location = new Point(0, 0);
            windowTray.Margin = new Padding(0);
            windowTray.Size = new Size(45, 30);
            windowTray.TabStop = false;
            windowTray.Theme = Theme;
            windowTray.UseCustomBackColor = true;
            windowTray.UseSelectable = true;
            windowTray.Image = global::IPCS.Properties.Resources.line_white;
            windowTray.NoFocusImage = global::IPCS.Properties.Resources.line_white;
            windowTray.MouseEnter += WindowButton_MouseEnter;
            windowTray.MouseClick += WindowButton_MouseClick;
            windowTray.MouseLeave += WindowButton_MouseLeave;
            windowTray.Tag = WindowsButton.tray;
            // 
            // CustomPanelWinControl
            // 
            CustomPanelWinControl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            CustomPanelWinControl.Controls.Add(windowClose);
            CustomPanelWinControl.Controls.Add(windowTray);
            CustomPanelWinControl.Controls.Add(windowMaximize);
            CustomPanelWinControl.Margin = new Padding(0);
            CustomPanelWinControl.Size = new Size(135, 30);
            CustomPanelWinControl.BackColor = Color.Transparent;
            CustomPanelWinControl.TabIndex = 0;

            Controls.Add(CustomPanelWinControl);

            RefreshControlBox();
        }

        private void WindowButton_MouseClick(object sender, MouseEventArgs e)
        {
            Controls.MetroLink button = (Controls.MetroLink)sender;
            WindowsButton buttonType = (WindowsButton)button.Tag;
            switch (buttonType)
            {
                case WindowsButton.close:
                    Application.Exit();
                    break;
                case WindowsButton.maximized:
                    WindowState = FormWindowState.Normal;
                    break;
                case WindowsButton.minimized:
                    WindowState = FormWindowState.Maximized;
                    break;
                case WindowsButton.tray:
                    WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        private void WindowButton_MouseEnter(object sender, EventArgs e)
        {
            Controls.MetroLink button = (Controls.MetroLink)sender;
            WindowsButton buttonType = (WindowsButton)button.Tag;
            switch (buttonType)
            {
                case WindowsButton.close:
                    button.BackColor = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.7);
                    break;
                case WindowsButton.maximized:
                    button.BackColor = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.7);
                    break;
                case WindowsButton.minimized:
                    button.BackColor = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.7);
                    break;
                case WindowsButton.tray:
                    button.BackColor = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.7);
                    break;
            }
        }

        private void WindowButton_MouseLeave(object sender, EventArgs e)
        {
            Controls.MetroLink button = (Controls.MetroLink)sender;
            WindowsButton buttonType = (WindowsButton)button.Tag;
            switch (buttonType)
            {
                case WindowsButton.close:
                    button.BackColor = colorTheme;
                    break;
                case WindowsButton.maximized:
                    button.BackColor = colorTheme;
                    break;
                case WindowsButton.minimized:
                    button.BackColor = colorTheme;
                    break;
                case WindowsButton.tray:
                    button.BackColor = colorTheme;
                    break;
            }
        }

        private Color colorTheme;
        private void RefreshControlBox()
        {
            if (!ControlBox) return;

            if (WindowState == FormWindowState.Maximized)
            {
                windowMaximize.Image = global::IPCS.Properties.Resources.drect_white;
                windowMaximize.NoFocusImage = global::IPCS.Properties.Resources.drect_white;
                windowMaximize.Tag = WindowsButton.maximized;
            }
            else
            {
                windowMaximize.Image = global::IPCS.Properties.Resources.rect_white;
                windowMaximize.NoFocusImage = global::IPCS.Properties.Resources.rect_white;
                windowMaximize.Tag = WindowsButton.minimized;
            }
            colorTheme = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.5);
            windowClose.BackColor = colorTheme;
            windowMaximize.BackColor = colorTheme;
            windowTray.BackColor = colorTheme;
            CustomPanelWinControl.Location = new Point(ClientSize.Width - 135, 0);
        }
        
        #endregion
    }
}
