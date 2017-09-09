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
            Pen pen = new Pen(brush, 3);
            if (NotificationBox)
            {
                e.Graphics.FillRectangle(brush, 0, Height - 30, Width, 30);
            }

            switch (BorderStyle)
            {
                case MetroFormBorderStyle.None:
                    break;
                case MetroFormBorderStyle.FixedSingle:
                    if (WindowState == FormWindowState.Normal) e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                    break;
            }
            RefreshComponents();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion

        #region Fields

        private bool _ControlBox = true;
        [Category("Window Style"), Browsable(true)]
        [Description("Custom control box from CustomForm")]
        public new bool ControlBox
        {
            get { return _ControlBox; }
            set { _ControlBox = value; }
        }

        private bool _NotifBox = true;
        [Category("Metro Appearance")]
        public bool NotificationBox
        {
            get { return _NotifBox; }
            set { _NotifBox = value; }
        }

        public new Padding Padding
        {
            get { return base.Padding; }
            set
            {
                value.Top = Math.Max(value.Top, ControlBox ? 35 : 5);
                value.Bottom = Math.Max(value.Bottom, NotificationBox ? 35 : 5);
                base.Padding = value;
            }
        }

        protected override Padding DefaultPadding
        {
            get { return new Padding(5, ControlBox ? 35 : 5, 5, NotificationBox ? 35 : 5); }
        }

        public void NotifText(string text)
        {
            notifLabel.Text = text;
            RefreshComponents();
        }

        #endregion

        #region Windows ControlBox

        private enum WindowsButton
        {
            close, maximized, minimized, tray
        }

        private Controls.MetroLink windowClose;
        private Controls.MetroLink windowMaximize;
        private Controls.MetroLink windowTray;
        private Controls.MetroLabel notifLabel;
        private Controls.MetroLabel titleLabel;
        private Controls.MetroPanel CustomPanelWinControl;
        private void AddControlBox()
        {
            if (!ControlBox) return;
            windowClose = new Controls.MetroLink();
            windowMaximize = new Controls.MetroLink();
            windowTray = new Controls.MetroLink();
            notifLabel = new Controls.MetroLabel();
            titleLabel = new Controls.MetroLabel();
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
            // notifLabel
            // 
            notifLabel.Text = "null";
            notifLabel.UseSelectable = true;
            notifLabel.UseSelectable = true;
            notifLabel.UseCustomBackColor = true;
            notifLabel.UseCustomForeColor = true;
            Controls.Add(notifLabel);
            // 
            // notifLabel
            // 
            titleLabel.Text = Name;
            titleLabel.UseSelectable = true;
            titleLabel.UseSelectable = true;
            titleLabel.UseCustomForeColor = true;
            titleLabel.FontWeight = MetroLabelWeight.Regular;
            titleLabel.ForeColor = Color.FromArgb(100, 100, 100);
            titleLabel.Location = new Point(7, 7);
            Controls.Add(titleLabel);
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

            RefreshComponents();
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
            button.BackColor = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.5);
        }

        private void WindowButton_MouseLeave(object sender, EventArgs e)
        {
            Controls.MetroLink button = (Controls.MetroLink)sender;
            button.BackColor = Color.Transparent;
        }
        
        private void RefreshComponents()
        {
            if (!ControlBox) return;

            if (WindowState == FormWindowState.Maximized)
            {
                if(Theme == MetroThemeStyle.Light)
                {
                    windowMaximize.Image = IPCS.Properties.Resources.drect_black;
                    windowMaximize.NoFocusImage = IPCS.Properties.Resources.drect_black;
                }
                else
                {
                    windowMaximize.Image = IPCS.Properties.Resources.drect_white;
                    windowMaximize.NoFocusImage = IPCS.Properties.Resources.drect_white;
                }
                windowMaximize.Tag = WindowsButton.maximized;
                CustomPanelWinControl.Location = new Point(ClientSize.Width - 135, 0);
            }
            else
            {
                if (Theme == MetroThemeStyle.Light)
                {
                    windowMaximize.Image = IPCS.Properties.Resources.rect_black;
                    windowMaximize.NoFocusImage = IPCS.Properties.Resources.rect_black;
                }
                else
                {
                    windowMaximize.Image = IPCS.Properties.Resources.rect_white;
                    windowMaximize.NoFocusImage = IPCS.Properties.Resources.rect_white;
                }
                windowMaximize.Tag = WindowsButton.minimized;
                CustomPanelWinControl.Location = new Point(ClientSize.Width - 137, 2);
            }
            if (Theme == MetroThemeStyle.Light)
            {
                windowClose.Image = IPCS.Properties.Resources.x_black;
                windowClose.NoFocusImage = IPCS.Properties.Resources.x_black;
                windowTray.Image = IPCS.Properties.Resources.line_black;
                windowTray.NoFocusImage = IPCS.Properties.Resources.line_black;
            }
            else
            {
                windowClose.Image = IPCS.Properties.Resources.x_white;
                windowClose.NoFocusImage = IPCS.Properties.Resources.x_white;
                windowTray.Image = IPCS.Properties.Resources.line_white;
                windowTray.NoFocusImage = IPCS.Properties.Resources.line_white;
            }
            windowClose.BackColor = Color.Transparent;
            windowMaximize.BackColor = Color.Transparent;
            windowTray.BackColor = Color.Transparent;
            notifLabel.BackColor = ColorMethods.AdjustBrightness(ColorMethods.ToSystemColor(Style), -0.5);
            notifLabel.ForeColor = MetroColors.White;
            notifLabel.Location = new Point(5, Height - 25);
        }
        
        #endregion
    }
}
