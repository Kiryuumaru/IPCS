using System.ComponentModel;

namespace IPCS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanelHeader = new MetroFramework.Controls.MetroPanel();
            this.linkUserAccount = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroPanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroPanelHeader
            // 
            this.metroPanelHeader.Controls.Add(this.linkUserAccount);
            this.metroPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelHeader.HorizontalScrollbarBarColor = true;
            this.metroPanelHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelHeader.HorizontalScrollbarSize = 10;
            this.metroPanelHeader.Location = new System.Drawing.Point(5, 35);
            this.metroPanelHeader.Name = "metroPanelHeader";
            this.metroPanelHeader.Size = new System.Drawing.Size(901, 30);
            this.metroPanelHeader.TabIndex = 4;
            this.metroPanelHeader.VerticalScrollbarBarColor = true;
            this.metroPanelHeader.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelHeader.VerticalScrollbarSize = 10;
            // 
            // linkUserAccount
            // 
            this.linkUserAccount.AutoSize = true;
            this.linkUserAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkUserAccount.FontSize = MetroFramework.MetroLabelSize.Small;
            this.linkUserAccount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.linkUserAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkUserAccount.Location = new System.Drawing.Point(813, 0);
            this.linkUserAccount.MinimumSize = new System.Drawing.Size(0, 30);
            this.linkUserAccount.Name = "linkUserAccount";
            this.linkUserAccount.Size = new System.Drawing.Size(88, 15);
            this.linkUserAccount.TabIndex = 4;
            this.linkUserAccount.Text = "Anatawa dare?";
            this.linkUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkUserAccount.UseCustomForeColor = true;
            this.linkUserAccount.Click += new System.EventHandler(this.UserAccount_Click);
            this.linkUserAccount.MouseEnter += new System.EventHandler(this.UserAccount_MouseEnter);
            this.linkUserAccount.MouseLeave += new System.EventHandler(this.UserAccount_MouseLeave);
            // 
            // metroToolTip
            // 
            this.metroToolTip.AutomaticDelay = 0;
            this.metroToolTip.AutoPopDelay = 10000;
            this.metroToolTip.InitialDelay = 0;
            this.metroToolTip.ReshowDelay = 0;
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = this.metroStyleManager;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(911, 481);
            this.Controls.Add(this.metroPanelHeader);
            this.Name = "MainForm";
            this.StyleManager = this.metroStyleManager;
            this.Text = "IPCS";
            this.Controls.SetChildIndex(this.metroPanelHeader, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroPanelHeader.ResumeLayout(false);
            this.metroPanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel metroPanelHeader;
        private MetroFramework.Controls.MetroLabel linkUserAccount;
        private MetroFramework.Components.MetroToolTip metroToolTip;
    }
}

