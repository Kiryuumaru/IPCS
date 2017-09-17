namespace IPCS.Panels
{
    partial class PnlTab
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
            this.pictureBoxTab = new System.Windows.Forms.PictureBox();
            this.pnlMetroTab = new MetroFramework.Controls.MetroPanel();
            this.lblTab = new MetroFramework.Controls.MetroLabel();
            this.pnlPictureBoxHolder = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTab)).BeginInit();
            this.pnlMetroTab.SuspendLayout();
            this.pnlPictureBoxHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTab
            // 
            this.pictureBoxTab.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTab.Location = new System.Drawing.Point(2, 3);
            this.pictureBoxTab.Name = "pictureBoxTab";
            this.pictureBoxTab.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTab.TabIndex = 9;
            this.pictureBoxTab.TabStop = false;
            this.pictureBoxTab.Tag = "";
            this.pictureBoxTab.MouseEnter += new System.EventHandler(this.Tab_Enter);
            this.pictureBoxTab.MouseLeave += new System.EventHandler(this.Tab_Leave);
            // 
            // pnlMetroTab
            // 
            this.pnlMetroTab.Controls.Add(this.lblTab);
            this.pnlMetroTab.Controls.Add(this.pnlPictureBoxHolder);
            this.pnlMetroTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetroTab.HorizontalScrollbarBarColor = true;
            this.pnlMetroTab.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMetroTab.HorizontalScrollbarSize = 10;
            this.pnlMetroTab.Location = new System.Drawing.Point(0, 0);
            this.pnlMetroTab.Name = "pnlMetroTab";
            this.pnlMetroTab.Size = new System.Drawing.Size(165, 35);
            this.pnlMetroTab.TabIndex = 11;
            this.pnlMetroTab.VerticalScrollbarBarColor = true;
            this.pnlMetroTab.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMetroTab.VerticalScrollbarSize = 10;
            // 
            // lblTab
            // 
            this.lblTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTab.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTab.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTab.Location = new System.Drawing.Point(40, 0);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(125, 35);
            this.lblTab.TabIndex = 10;
            this.lblTab.Text = "Tab name";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTab.UseCustomForeColor = true;
            this.lblTab.MouseEnter += new System.EventHandler(this.Tab_Enter);
            this.lblTab.MouseLeave += new System.EventHandler(this.Tab_Leave);
            // 
            // pnlPictureBoxHolder
            // 
            this.pnlPictureBoxHolder.Controls.Add(this.pictureBoxTab);
            this.pnlPictureBoxHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPictureBoxHolder.HorizontalScrollbarBarColor = true;
            this.pnlPictureBoxHolder.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPictureBoxHolder.HorizontalScrollbarSize = 10;
            this.pnlPictureBoxHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlPictureBoxHolder.Name = "pnlPictureBoxHolder";
            this.pnlPictureBoxHolder.Size = new System.Drawing.Size(40, 35);
            this.pnlPictureBoxHolder.TabIndex = 11;
            this.pnlPictureBoxHolder.VerticalScrollbarBarColor = true;
            this.pnlPictureBoxHolder.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPictureBoxHolder.VerticalScrollbarSize = 10;
            // 
            // PnlTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMetroTab);
            this.Name = "PnlTab";
            this.Size = new System.Drawing.Size(165, 35);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTab)).EndInit();
            this.pnlMetroTab.ResumeLayout(false);
            this.pnlPictureBoxHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTab;
        private MetroFramework.Controls.MetroPanel pnlMetroTab;
        private MetroFramework.Controls.MetroLabel lblTab;
        private MetroFramework.Controls.MetroPanel pnlPictureBoxHolder;
    }
}
