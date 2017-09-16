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
            this.pnlMetro = new MetroFramework.Controls.MetroPanel();
            this.pnlCenter = new MetroFramework.Controls.MetroPanel();
            this.pnlTab = new MetroFramework.Controls.MetroPanel();
            this.tabHelp = new IPCS.Panels.PnlTab();
            this.tabSettings = new IPCS.Panels.PnlTab();
            this.tabManageInventory = new IPCS.Panels.PnlTab();
            this.tabStartCashiering = new IPCS.Panels.PnlTab();
            this.tabHome = new IPCS.Panels.PnlTab();
            this.pnlProfile = new MetroFramework.Controls.MetroPanel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.pnlMetro.SuspendLayout();
            this.pnlTab.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMetro
            // 
            this.pnlMetro.Controls.Add(this.pnlCenter);
            this.pnlMetro.Controls.Add(this.pnlTab);
            this.pnlMetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetro.HorizontalScrollbarBarColor = true;
            this.pnlMetro.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMetro.HorizontalScrollbarSize = 10;
            this.pnlMetro.Location = new System.Drawing.Point(0, 0);
            this.pnlMetro.Name = "pnlMetro";
            this.pnlMetro.Size = new System.Drawing.Size(896, 442);
            this.pnlMetro.TabIndex = 0;
            this.pnlMetro.VerticalScrollbarBarColor = true;
            this.pnlMetro.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMetro.VerticalScrollbarSize = 10;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.HorizontalScrollbarBarColor = true;
            this.pnlCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCenter.HorizontalScrollbarSize = 10;
            this.pnlCenter.Location = new System.Drawing.Point(200, 0);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(696, 442);
            this.pnlCenter.TabIndex = 4;
            this.pnlCenter.VerticalScrollbarBarColor = true;
            this.pnlCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCenter.VerticalScrollbarSize = 10;
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.tabHelp);
            this.pnlTab.Controls.Add(this.tabSettings);
            this.pnlTab.Controls.Add(this.tabManageInventory);
            this.pnlTab.Controls.Add(this.tabStartCashiering);
            this.pnlTab.Controls.Add(this.tabHome);
            this.pnlTab.Controls.Add(this.pnlProfile);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTab.HorizontalScrollbarBarColor = true;
            this.pnlTab.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTab.HorizontalScrollbarSize = 10;
            this.pnlTab.Location = new System.Drawing.Point(0, 0);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(200, 442);
            this.pnlTab.TabIndex = 3;
            this.pnlTab.VerticalScrollbarBarColor = true;
            this.pnlTab.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTab.VerticalScrollbarSize = 10;
            // 
            // tabHelp
            // 
            this.tabHelp.DarkThemeImage = global::IPCS.Properties.Resources.ic_help_white_48dp_2x;
            this.tabHelp.Image = global::IPCS.Properties.Resources.ic_help_gray_48dp_2x;
            this.tabHelp.LightThemeImage = global::IPCS.Properties.Resources.ic_help_black_48dp_2x;
            this.tabHelp.Location = new System.Drawing.Point(20, 260);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(174, 35);
            this.tabHelp.TabIndex = 17;
            this.tabHelp.TabText = "Help";
            this.tabHelp.Tag = "Help";
            this.tabHelp.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.DarkThemeImage = global::IPCS.Properties.Resources.ic_build_white_48dp_2x;
            this.tabSettings.Image = global::IPCS.Properties.Resources.ic_build_gray_48dp_2x;
            this.tabSettings.LightThemeImage = global::IPCS.Properties.Resources.ic_build_black_48dp_2x;
            this.tabSettings.Location = new System.Drawing.Point(20, 219);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(174, 35);
            this.tabSettings.TabIndex = 16;
            this.tabSettings.TabText = "Settings";
            this.tabSettings.Tag = "Settings";
            this.tabSettings.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabManageInventory
            // 
            this.tabManageInventory.DarkThemeImage = global::IPCS.Properties.Resources.ic_assessment_white_48dp_2x;
            this.tabManageInventory.Image = global::IPCS.Properties.Resources.ic_assessment_gray_48dp_2x;
            this.tabManageInventory.LightThemeImage = global::IPCS.Properties.Resources.ic_assessment_black_48dp_2x;
            this.tabManageInventory.Location = new System.Drawing.Point(20, 178);
            this.tabManageInventory.Name = "tabManageInventory";
            this.tabManageInventory.Size = new System.Drawing.Size(175, 35);
            this.tabManageInventory.TabIndex = 15;
            this.tabManageInventory.TabText = "Manage Inventory";
            this.tabManageInventory.Tag = "ManageInventory";
            this.tabManageInventory.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabStartCashiering
            // 
            this.tabStartCashiering.DarkThemeImage = global::IPCS.Properties.Resources.ic_monetization_on_white_48dp_2x;
            this.tabStartCashiering.Image = global::IPCS.Properties.Resources.ic_monetization_on_gray_48dp_2x;
            this.tabStartCashiering.LightThemeImage = global::IPCS.Properties.Resources.ic_monetization_on_black_48dp_2x;
            this.tabStartCashiering.Location = new System.Drawing.Point(20, 137);
            this.tabStartCashiering.Name = "tabStartCashiering";
            this.tabStartCashiering.Size = new System.Drawing.Size(174, 35);
            this.tabStartCashiering.TabIndex = 14;
            this.tabStartCashiering.TabText = "Start Cashiering";
            this.tabStartCashiering.Tag = "StartCashiering";
            this.tabStartCashiering.Click += new System.EventHandler(this.Tab_Click);
            // 
            // tabHome
            // 
            this.tabHome.DarkThemeImage = global::IPCS.Properties.Resources.ic_home_white_48dp_2x;
            this.tabHome.Image = global::IPCS.Properties.Resources.ic_home_gray_48dp_2x;
            this.tabHome.LightThemeImage = global::IPCS.Properties.Resources.ic_home_black_48dp_2x;
            this.tabHome.Location = new System.Drawing.Point(20, 96);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(174, 35);
            this.tabHome.TabIndex = 2;
            this.tabHome.TabText = "Home";
            this.tabHome.Tag = "Home";
            this.tabHome.Click += new System.EventHandler(this.Tab_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlProfile.Controls.Add(this.lblUsername);
            this.pnlProfile.Controls.Add(this.profilePicture);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfile.HorizontalScrollbarBarColor = true;
            this.pnlProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfile.HorizontalScrollbarSize = 10;
            this.pnlProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(200, 73);
            this.pnlProfile.TabIndex = 4;
            this.pnlProfile.VerticalScrollbarBarColor = true;
            this.pnlProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfile.VerticalScrollbarSize = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsername.Location = new System.Drawing.Point(0, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Anatawa dare?";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicture.Image = global::IPCS.Properties.Resources.ic_help_black_48dp_2x;
            this.profilePicture.Location = new System.Drawing.Point(80, 16);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(35, 35);
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
            this.Size = new System.Drawing.Size(896, 442);
            this.pnlMetro.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMetro;
        private MetroFramework.Controls.MetroPanel pnlTab;
        private MetroFramework.Controls.MetroPanel pnlProfile;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private System.Windows.Forms.PictureBox profilePicture;
        private MetroFramework.Controls.MetroPanel pnlCenter;
        private PnlTab tabHome;
        private PnlTab tabStartCashiering;
        private PnlTab tabHelp;
        private PnlTab tabSettings;
        private PnlTab tabManageInventory;
    }
}
