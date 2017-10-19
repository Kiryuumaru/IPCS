namespace IPCS.Panels
{
    partial class PnlMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PnlMain));
            this.pnlMetro = new MetroFramework.Controls.MetroPanel();
            this.pnlMainHolder = new MetroFramework.Controls.MetroPanel();
            this.pnlCenter = new MetroFramework.Controls.MetroPanel();
            this.pnlControl = new MetroFramework.Controls.MetroPanel();
            this.separator = new System.Windows.Forms.PictureBox();
            this.pnlTab = new MetroFramework.Controls.MetroPanel();
            this.pnlTabHolder = new MetroFramework.Controls.MetroPanel();
            this.tabHome = new IPCS.Panels.PnlTab();
            this.tabHelp = new IPCS.Panels.PnlTab();
            this.tabStartCashiering = new IPCS.Panels.PnlTab();
            this.tabManageInventory = new IPCS.Panels.PnlTab();
            this.tabSettings = new IPCS.Panels.PnlTab();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.tabShow = new IPCS.Panels.PnlTab();
            this.tabHide = new IPCS.Panels.PnlTab();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.pnlMetro.SuspendLayout();
            this.pnlMainHolder.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            this.pnlTab.SuspendLayout();
            this.pnlTabHolder.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMetro
            // 
            this.pnlMetro.Controls.Add(this.pnlMainHolder);
            this.pnlMetro.Controls.Add(this.pnlControl);
            this.pnlMetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetro.HorizontalScrollbarBarColor = true;
            this.pnlMetro.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMetro.HorizontalScrollbarSize = 10;
            this.pnlMetro.Location = new System.Drawing.Point(0, 0);
            this.pnlMetro.Name = "pnlMetro";
            this.pnlMetro.Size = new System.Drawing.Size(896, 450);
            this.pnlMetro.TabIndex = 0;
            this.pnlMetro.VerticalScrollbarBarColor = true;
            this.pnlMetro.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMetro.VerticalScrollbarSize = 10;
            // 
            // pnlMainHolder
            // 
            this.pnlMainHolder.Controls.Add(this.pnlCenter);
            this.pnlMainHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainHolder.HorizontalScrollbarBarColor = true;
            this.pnlMainHolder.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMainHolder.HorizontalScrollbarSize = 10;
            this.pnlMainHolder.Location = new System.Drawing.Point(212, 0);
            this.pnlMainHolder.Name = "pnlMainHolder";
            this.pnlMainHolder.Size = new System.Drawing.Size(684, 450);
            this.pnlMainHolder.TabIndex = 6;
            this.pnlMainHolder.VerticalScrollbarBarColor = true;
            this.pnlMainHolder.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMainHolder.VerticalScrollbarSize = 10;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.HorizontalScrollbarBarColor = true;
            this.pnlCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCenter.HorizontalScrollbarSize = 10;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCenter.Size = new System.Drawing.Size(684, 450);
            this.pnlCenter.TabIndex = 4;
            this.pnlCenter.VerticalScrollbarBarColor = true;
            this.pnlCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCenter.VerticalScrollbarSize = 10;
            // 
            // pnlControl
            // 
            this.pnlControl.AutoSize = true;
            this.pnlControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlControl.Controls.Add(this.separator);
            this.pnlControl.Controls.Add(this.pnlTab);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControl.HorizontalScrollbarBarColor = true;
            this.pnlControl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControl.HorizontalScrollbarSize = 10;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(212, 450);
            this.pnlControl.TabIndex = 3;
            this.pnlControl.VerticalScrollbarBarColor = true;
            this.pnlControl.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControl.VerticalScrollbarSize = 10;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.Dock = System.Windows.Forms.DockStyle.Right;
            this.separator.Image = ((System.Drawing.Image)(resources.GetObject("separator.Image")));
            this.separator.Location = new System.Drawing.Point(210, 0);
            this.separator.Margin = new System.Windows.Forms.Padding(0);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(2, 450);
            this.separator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.separator.TabIndex = 2;
            this.separator.TabStop = false;
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.pnlTabHolder);
            this.pnlTab.Controls.Add(this.pnlProfile);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTab.HorizontalScrollbarBarColor = true;
            this.pnlTab.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTab.HorizontalScrollbarSize = 10;
            this.pnlTab.Location = new System.Drawing.Point(0, 0);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(210, 450);
            this.pnlTab.TabIndex = 2;
            this.pnlTab.VerticalScrollbarBarColor = true;
            this.pnlTab.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTab.VerticalScrollbarSize = 10;
            // 
            // pnlTabHolder
            // 
            this.pnlTabHolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlTabHolder.Controls.Add(this.tabHome);
            this.pnlTabHolder.Controls.Add(this.tabHelp);
            this.pnlTabHolder.Controls.Add(this.tabStartCashiering);
            this.pnlTabHolder.Controls.Add(this.tabManageInventory);
            this.pnlTabHolder.Controls.Add(this.tabSettings);
            this.pnlTabHolder.HorizontalScrollbarBarColor = true;
            this.pnlTabHolder.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTabHolder.HorizontalScrollbarSize = 10;
            this.pnlTabHolder.Location = new System.Drawing.Point(8, 122);
            this.pnlTabHolder.Name = "pnlTabHolder";
            this.pnlTabHolder.Size = new System.Drawing.Size(178, 218);
            this.pnlTabHolder.TabIndex = 2;
            this.pnlTabHolder.VerticalScrollbarBarColor = true;
            this.pnlTabHolder.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTabHolder.VerticalScrollbarSize = 10;
            // 
            // tabHome
            // 
            this.tabHome.DarkThemeImage = global::IPCS.Properties.Resources.ic_home_white_48dp_2x;
            this.tabHome.Image = global::IPCS.Properties.Resources.ic_home_gray_48dp_2x;
            this.tabHome.LightThemeImage = global::IPCS.Properties.Resources.ic_home_black_48dp_2x;
            this.tabHome.Location = new System.Drawing.Point(0, 3);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(175, 35);
            this.tabHome.TabIndex = 2;
            this.tabHome.TabText = "Profile";
            this.tabHome.Tag = "Home";
            this.tabHome.Toggled = false;
            this.tabHome.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabHelp
            // 
            this.tabHelp.DarkThemeImage = global::IPCS.Properties.Resources.ic_help_white_48dp_2x;
            this.tabHelp.Image = global::IPCS.Properties.Resources.ic_help_gray_48dp_2x;
            this.tabHelp.LightThemeImage = global::IPCS.Properties.Resources.ic_help_black_48dp_2x;
            this.tabHelp.Location = new System.Drawing.Point(1, 167);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(174, 35);
            this.tabHelp.TabIndex = 17;
            this.tabHelp.TabText = "About Us";
            this.tabHelp.Tag = "Help";
            this.tabHelp.Toggled = false;
            this.tabHelp.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabStartCashiering
            // 
            this.tabStartCashiering.DarkThemeImage = global::IPCS.Properties.Resources.ic_monetization_on_white_48dp_2x;
            this.tabStartCashiering.Image = global::IPCS.Properties.Resources.ic_monetization_on_gray_48dp_2x;
            this.tabStartCashiering.LightThemeImage = global::IPCS.Properties.Resources.ic_monetization_on_black_48dp_2x;
            this.tabStartCashiering.Location = new System.Drawing.Point(0, 44);
            this.tabStartCashiering.Name = "tabStartCashiering";
            this.tabStartCashiering.Size = new System.Drawing.Size(175, 35);
            this.tabStartCashiering.TabIndex = 14;
            this.tabStartCashiering.TabText = "Start Cashiering";
            this.tabStartCashiering.Tag = "StartCashiering";
            this.tabStartCashiering.Toggled = false;
            this.tabStartCashiering.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabManageInventory
            // 
            this.tabManageInventory.DarkThemeImage = global::IPCS.Properties.Resources.ic_assessment_white_48dp_2x;
            this.tabManageInventory.Image = global::IPCS.Properties.Resources.ic_assessment_gray_48dp_2x;
            this.tabManageInventory.LightThemeImage = global::IPCS.Properties.Resources.ic_assessment_black_48dp_2x;
            this.tabManageInventory.Location = new System.Drawing.Point(0, 85);
            this.tabManageInventory.Name = "tabManageInventory";
            this.tabManageInventory.Size = new System.Drawing.Size(175, 35);
            this.tabManageInventory.TabIndex = 15;
            this.tabManageInventory.TabText = "Manage Inventory";
            this.tabManageInventory.Tag = "ManageInventory";
            this.tabManageInventory.Toggled = false;
            this.tabManageInventory.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.DarkThemeImage = global::IPCS.Properties.Resources.ic_build_white_48dp_2x;
            this.tabSettings.Image = global::IPCS.Properties.Resources.ic_build_gray_48dp_2x;
            this.tabSettings.LightThemeImage = global::IPCS.Properties.Resources.ic_build_black_48dp_2x;
            this.tabSettings.Location = new System.Drawing.Point(1, 126);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(174, 35);
            this.tabSettings.TabIndex = 16;
            this.tabSettings.TabText = "Settings";
            this.tabSettings.Tag = "Settings";
            this.tabSettings.Toggled = false;
            this.tabSettings.Click += new System.EventHandler(this.Tab_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlProfile.Controls.Add(this.tabShow);
            this.pnlProfile.Controls.Add(this.tabHide);
            this.pnlProfile.Controls.Add(this.lblUsername);
            this.pnlProfile.Controls.Add(this.profilePicture);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(210, 116);
            this.pnlProfile.TabIndex = 4;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
            // 
            // tabShow
            // 
            this.tabShow.DarkThemeImage = global::IPCS.Properties.Resources.ic_chevron_right_white_48pt_2x;
            this.tabShow.Image = global::IPCS.Properties.Resources.ic_chevron_right_gray_48pt_2x;
            this.tabShow.LightThemeImage = global::IPCS.Properties.Resources.ic_chevron_right_black_48pt_2x;
            this.tabShow.Location = new System.Drawing.Point(8, 0);
            this.tabShow.Name = "tabShow";
            this.tabShow.Size = new System.Drawing.Size(35, 35);
            this.tabShow.TabIndex = 6;
            this.tabShow.TabText = null;
            this.tabShow.Toggled = false;
            this.tabShow.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabHide
            // 
            this.tabHide.DarkThemeImage = global::IPCS.Properties.Resources.ic_chevron_left_white_48pt_2x;
            this.tabHide.Image = global::IPCS.Properties.Resources.ic_chevron_left_gray_48pt_2x;
            this.tabHide.LightThemeImage = global::IPCS.Properties.Resources.ic_chevron_left_black_48pt_2x;
            this.tabHide.Location = new System.Drawing.Point(169, 0);
            this.tabHide.Name = "tabHide";
            this.tabHide.Size = new System.Drawing.Size(35, 35);
            this.tabHide.TabIndex = 2;
            this.tabHide.TabText = null;
            this.tabHide.Toggled = false;
            this.tabHide.Click += new System.EventHandler(this.Tab_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUsername.Location = new System.Drawing.Point(0, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(210, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Anatawa dare?";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicture.Image = global::IPCS.Properties.Resources.logo;
            this.profilePicture.Location = new System.Drawing.Point(76, 34);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(60, 60);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 5;
            this.profilePicture.TabStop = false;
            // 
            // PnlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMetro);
            this.Name = "PnlMain";
            this.Size = new System.Drawing.Size(896, 450);
            this.pnlMetro.ResumeLayout(false);
            this.pnlMetro.PerformLayout();
            this.pnlMainHolder.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            this.pnlTab.ResumeLayout(false);
            this.pnlTabHolder.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMetro;
        private MetroFramework.Controls.MetroPanel pnlCenter;
        private MetroFramework.Controls.MetroPanel pnlControl;
        private PnlTab tabHelp;
        private PnlTab tabSettings;
        private PnlTab tabManageInventory;
        private PnlTab tabStartCashiering;
        private PnlTab tabHome;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private System.Windows.Forms.PictureBox profilePicture;
        private MetroFramework.Controls.MetroPanel pnlMainHolder;
        private PnlTab tabHide;
        private PnlTab tabShow;
        private MetroFramework.Controls.MetroPanel pnlTab;
        private MetroFramework.Controls.MetroPanel pnlTabHolder;
        private System.Windows.Forms.PictureBox separator;
    }
}
