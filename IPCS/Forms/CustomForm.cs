using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace IPCS.Forms
{
    public partial class CustomForm : MetroFramework.Forms.MetroForm
    {
        #region Constructor

        public CustomForm()
        {
            base.ControlBox = false;
            AddControlBox();
        }

        #endregion

        #region Paint Method

        SolidBrush brush;
        Pen pen;
        protected override void OnPaint(PaintEventArgs e)
        {
            brush = new SolidBrush(ColorMethods.ToSystemColor(Style));
            pen = new Pen(brush, 3);
            if (NotificationBox)
            {
                e.Graphics.FillRectangle(brush, 0, Height - 25, Width, 25);
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
            titleLabel.Text = Text;
            if(NotificationBox) Controls.Add(notifLabel);
            if(DisplayHeader) Controls.Add(titleLabel);
            if (ControlBox)
            {
                if (MinimizeBox) AddControlButton(windowTray);
                if (MaximizeBox) AddControlButton(windowMaximize);
                AddControlButton(windowClose);
            }
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
        
        public string NotifText
        {
            get { return notifLabel.Text; }
            set
            {
                notifLabel.Text = value;
                RefreshComponents();
            }
        }

        #endregion

        #region Windows ControlBox

        private enum WindowsButton
        {
            close, maximized, minimized, tray
        }

        private MetroLink windowClose;
        private MetroLink windowMaximize;
        private MetroLink windowTray;
        private MetroLabel notifLabel;
        private MetroLabel titleLabel;
        private MetroPanel CustomPanelWinControl;
        private void AddControlBox()
        {
            if (!ControlBox) return;
            windowClose = new MetroLink();
            windowMaximize = new MetroLink();
            windowTray = new MetroLink();
            notifLabel = new MetroLabel();
            titleLabel = new MetroLabel();
            CustomPanelWinControl = new MetroPanel();
            // 
            // windowClose
            // 
            windowClose.ImageSize = 32;
            windowClose.Margin = new Padding(0);
            windowClose.Size = new Size(45, 30);
            windowClose.TabStop = false;
            windowClose.Theme = Theme;
            windowClose.UseCustomBackColor = true;
            windowClose.UseSelectable = true;
            windowClose.Image = Properties.Resources.x_white.ToBitmap();
            windowClose.NoFocusImage = Properties.Resources.x_white.ToBitmap();
            windowClose.MouseEnter += WindowButton_MouseEnter;
            windowClose.MouseClick += WindowButton_MouseClick;
            windowClose.MouseLeave += WindowButton_MouseLeave;
            windowClose.Tag = WindowsButton.close;
            // 
            // windowMaximize
            // 
            windowMaximize.ImageSize = 32;
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
            windowTray.Margin = new Padding(0);
            windowTray.Size = new Size(45, 30);
            windowTray.TabStop = false;
            windowTray.Theme = Theme;
            windowTray.UseCustomBackColor = true;
            windowTray.UseSelectable = true;
            windowTray.MouseEnter += WindowButton_MouseEnter;
            windowTray.MouseClick += WindowButton_MouseClick;
            windowTray.MouseLeave += WindowButton_MouseLeave;
            windowTray.Tag = WindowsButton.tray;
            // 
            // notifLabel
            // 
            notifLabel.Text = "null desu";
            notifLabel.UseSelectable = true;
            notifLabel.UseCustomBackColor = true;
            notifLabel.UseCustomForeColor = true;
            notifLabel.FontWeight = MetroLabelWeight.Regular;
            notifLabel.FontSize = MetroLabelSize.Small;
            // 
            // titleLabel
            // 
            titleLabel.UseSelectable = true;
            titleLabel.UseCustomForeColor = true;
            titleLabel.FontWeight = MetroLabelWeight.Regular;
            titleLabel.ForeColor = Color.FromArgb(100, 100, 100);
            titleLabel.Location = new Point(7, 7);
            // 
            // CustomPanelWinControl
            // 
            CustomPanelWinControl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            CustomPanelWinControl.Controls.Add(windowClose);
            CustomPanelWinControl.Margin = new Padding(0);
            CustomPanelWinControl.BackColor = Color.Transparent;
            CustomPanelWinControl.TabIndex = 0;

            Controls.Add(CustomPanelWinControl);

            RefreshComponents();
        }

        private int controlBoxSpace = 0;
        private void AddControlButton(MetroLink button)
        {
            button.Location = new Point(controlBoxSpace, 0);
            controlBoxSpace += 45;
            CustomPanelWinControl.Size = new Size(controlBoxSpace, 30);
            CustomPanelWinControl.Controls.Add(button);
        }

        private void WindowButton_MouseClick(object sender, MouseEventArgs e)
        {
            MetroLink button = (MetroLink)sender;
            WindowsButton buttonType = (WindowsButton)button.Tag;
            switch (buttonType)
            {
                case WindowsButton.close:
                    this.Dispose();
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
            MetroLink button = (MetroLink)sender;
            button.BackColor = ColorMethods.ToSystemColor(Style);
        }

        private void WindowButton_MouseLeave(object sender, EventArgs e)
        {
            MetroLink button = (MetroLink)sender;
            button.BackColor = Color.Transparent;
        }

        public void RefreshComponents()
        {
            if (!ControlBox) return;

            if (WindowState == FormWindowState.Maximized)
            {
                if (Theme == MetroThemeStyle.Light)
                {
                    windowMaximize.Image = Properties.Resources.drect_black.ToBitmap();
                    windowMaximize.NoFocusImage = Properties.Resources.drect_black.ToBitmap();
                }
                else
                {
                    windowMaximize.Image = Properties.Resources.drect_white.ToBitmap();
                    windowMaximize.NoFocusImage = Properties.Resources.drect_white.ToBitmap();
                }
                windowMaximize.Tag = WindowsButton.maximized;
                CustomPanelWinControl.Location = new Point(ClientSize.Width - controlBoxSpace, 0);
            }
            else
            {
                if (Theme == MetroThemeStyle.Light)
                {
                    windowMaximize.Image = Properties.Resources.rect_black.ToBitmap();
                    windowMaximize.NoFocusImage = Properties.Resources.rect_black.ToBitmap();
                }
                else
                {
                    windowMaximize.Image = Properties.Resources.rect_white.ToBitmap();
                    windowMaximize.NoFocusImage = Properties.Resources.rect_white.ToBitmap();
                }
                windowMaximize.Tag = WindowsButton.minimized;
                CustomPanelWinControl.Location = new Point(ClientSize.Width - controlBoxSpace - 2, 2);
            }
            if (Theme == MetroThemeStyle.Light)
            {
                windowClose.Image = Properties.Resources.x_black.ToBitmap();
                windowClose.NoFocusImage = Properties.Resources.x_black.ToBitmap();
                windowTray.Image = Properties.Resources.line_black.ToBitmap();
                windowTray.NoFocusImage = Properties.Resources.line_black.ToBitmap();
            }
            else
            {
                windowClose.Image = Properties.Resources.x_white.ToBitmap();
                windowClose.NoFocusImage = Properties.Resources.x_white.ToBitmap();
                windowTray.Image = Properties.Resources.line_white.ToBitmap();
                windowTray.NoFocusImage = Properties.Resources.line_white.ToBitmap();
            }
            windowClose.BackColor = Color.Transparent;
            windowTray.BackColor = Color.Transparent;
            notifLabel.BackColor = ColorMethods.ToSystemColor(Style);
            notifLabel.ForeColor = MetroColors.White;
            notifLabel.Location = new Point(3, Height - 21);
        }

        #endregion
    }
}
