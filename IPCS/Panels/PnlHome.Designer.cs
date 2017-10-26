namespace IPCS.Panels
{
    partial class PnlHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PnlHome));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblTotalSale = new MetroFramework.Controls.MetroLabel();
            this.lblTotalGain = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWarnings = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblWarnings);
            this.metroPanel1.Controls.Add(this.lblTotalGain);
            this.metroPanel1.Controls.Add(this.lblTotalSale);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(696, 442);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalSale.AutoSize = true;
            this.lblTotalSale.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalSale.Location = new System.Drawing.Point(432, 275);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(89, 25);
            this.lblTotalSale.TabIndex = 3;
            this.lblTotalSale.Text = "Total sale: ";
            // 
            // lblTotalGain
            // 
            this.lblTotalGain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalGain.AutoSize = true;
            this.lblTotalGain.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalGain.Location = new System.Drawing.Point(428, 300);
            this.lblTotalGain.Name = "lblTotalGain";
            this.lblTotalGain.Size = new System.Drawing.Size(93, 25);
            this.lblTotalGain.TabIndex = 4;
            this.lblTotalGain.Text = "Total gain: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(82, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 258);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblWarnings
            // 
            this.lblWarnings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWarnings.AutoSize = true;
            this.lblWarnings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWarnings.Location = new System.Drawing.Point(82, 330);
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(121, 25);
            this.lblWarnings.TabIndex = 5;
            this.lblWarnings.Text = "wanrings desu";
            // 
            // PnlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PnlHome";
            this.Size = new System.Drawing.Size(696, 442);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblTotalGain;
        private MetroFramework.Controls.MetroLabel lblTotalSale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblWarnings;
    }
}
