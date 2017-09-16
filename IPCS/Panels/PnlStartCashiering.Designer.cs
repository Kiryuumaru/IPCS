namespace IPCS.Panels
{
    partial class PnlStartCashiering
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pnlMetro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMetro
            // 
            this.pnlMetro.Controls.Add(this.metroLabel4);
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(0, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(148, 25);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Start Cashiering";
            // 
            // PnlStartCashiering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMetro);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PnlStartCashiering";
            this.Size = new System.Drawing.Size(696, 442);
            this.pnlMetro.ResumeLayout(false);
            this.pnlMetro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMetro;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
