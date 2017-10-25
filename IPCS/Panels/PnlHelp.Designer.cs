namespace IPCS.Panels
{
    partial class PnlHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PnlHelp));
            this.pnlMetro = new MetroFramework.Controls.MetroPanel();
            this.lblLink = new MetroFramework.Controls.MetroLink();
            this.lblCopyright = new MetroFramework.Controls.MetroLabel();
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMetro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMetro
            // 
            this.pnlMetro.Controls.Add(this.lblLink);
            this.pnlMetro.Controls.Add(this.lblCopyright);
            this.pnlMetro.Controls.Add(this.lblVersion);
            this.pnlMetro.Controls.Add(this.metroLabel1);
            this.pnlMetro.Controls.Add(this.pictureBoxLogo);
            this.pnlMetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetro.HorizontalScrollbarBarColor = true;
            this.pnlMetro.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMetro.HorizontalScrollbarSize = 10;
            this.pnlMetro.Location = new System.Drawing.Point(0, 0);
            this.pnlMetro.Name = "pnlMetro";
            this.pnlMetro.Size = new System.Drawing.Size(696, 442);
            this.pnlMetro.TabIndex = 1;
            this.pnlMetro.VerticalScrollbarBarColor = true;
            this.pnlMetro.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMetro.VerticalScrollbarSize = 10;
            // 
            // lblLink
            // 
            this.lblLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLink.Location = new System.Drawing.Point(297, 291);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(113, 23);
            this.lblLink.TabIndex = 6;
            this.lblLink.Text = "Check for updates";
            this.lblLink.UseSelectable = true;
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyright.Location = new System.Drawing.Point(176, 269);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(350, 19);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Copyright © 2017 Someone";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersion.AutoSize = true;
            this.lblVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVersion.Location = new System.Drawing.Point(383, 250);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(41, 19);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "000x";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(283, 250);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Product version:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(176, 47);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(350, 200);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // PnlHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMetro);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PnlHelp";
            this.Size = new System.Drawing.Size(696, 442);
            this.pnlMetro.ResumeLayout(false);
            this.pnlMetro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMetro;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private MetroFramework.Controls.MetroLabel lblVersion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblCopyright;
        private MetroFramework.Controls.MetroLink lblLink;
    }
}
