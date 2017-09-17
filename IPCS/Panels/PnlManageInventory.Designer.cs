namespace IPCS.Panels
{
    partial class PnlManageInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMetro = new MetroFramework.Controls.MetroPanel();
            this.metroLabelSearch2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelInventoryHeader = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxInventorySearchI = new MetroFramework.Controls.MetroTextBox();
            this.InventoryColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButtonAddProduct = new MetroFramework.Controls.MetroButton();
            this.metroButtonNextInventory = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonEditProduct = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPasswordI = new MetroFramework.Controls.MetroTextBox();
            this.metroPanelInventoryBottom = new MetroFramework.Controls.MetroPanel();
            this.InventoryColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroGridInventory = new MetroFramework.Controls.MetroGrid();
            this.pnlMetro.SuspendLayout();
            this.metroPanelInventoryHeader.SuspendLayout();
            this.metroPanelInventoryBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMetro
            // 
            this.pnlMetro.Controls.Add(this.metroGridInventory);
            this.pnlMetro.Controls.Add(this.metroPanelInventoryHeader);
            this.pnlMetro.Controls.Add(this.metroPanelInventoryBottom);
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
            // metroLabelSearch2
            // 
            this.metroLabelSearch2.AutoSize = true;
            this.metroLabelSearch2.Location = new System.Drawing.Point(0, 10);
            this.metroLabelSearch2.Name = "metroLabelSearch2";
            this.metroLabelSearch2.Size = new System.Drawing.Size(55, 19);
            this.metroLabelSearch2.TabIndex = 2;
            this.metroLabelSearch2.Text = "Search :";
            // 
            // metroPanelInventoryHeader
            // 
            this.metroPanelInventoryHeader.Controls.Add(this.metroTextBoxInventorySearchI);
            this.metroPanelInventoryHeader.Controls.Add(this.metroLabelSearch2);
            this.metroPanelInventoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelInventoryHeader.HorizontalScrollbarBarColor = true;
            this.metroPanelInventoryHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelInventoryHeader.HorizontalScrollbarSize = 10;
            this.metroPanelInventoryHeader.Location = new System.Drawing.Point(0, 0);
            this.metroPanelInventoryHeader.Name = "metroPanelInventoryHeader";
            this.metroPanelInventoryHeader.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.metroPanelInventoryHeader.Size = new System.Drawing.Size(896, 37);
            this.metroPanelInventoryHeader.TabIndex = 13;
            this.metroPanelInventoryHeader.VerticalScrollbarBarColor = true;
            this.metroPanelInventoryHeader.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelInventoryHeader.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxInventorySearchI
            // 
            this.metroTextBoxInventorySearchI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBoxInventorySearchI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.metroTextBoxInventorySearchI.CustomButton.Image = null;
            this.metroTextBoxInventorySearchI.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.metroTextBoxInventorySearchI.CustomButton.Name = "";
            this.metroTextBoxInventorySearchI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxInventorySearchI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxInventorySearchI.CustomButton.TabIndex = 1;
            this.metroTextBoxInventorySearchI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxInventorySearchI.CustomButton.UseSelectable = true;
            this.metroTextBoxInventorySearchI.CustomButton.Visible = false;
            this.metroTextBoxInventorySearchI.Lines = new string[0];
            this.metroTextBoxInventorySearchI.Location = new System.Drawing.Point(58, 10);
            this.metroTextBoxInventorySearchI.Margin = new System.Windows.Forms.Padding(0);
            this.metroTextBoxInventorySearchI.MaxLength = 32767;
            this.metroTextBoxInventorySearchI.Name = "metroTextBoxInventorySearchI";
            this.metroTextBoxInventorySearchI.PasswordChar = '\0';
            this.metroTextBoxInventorySearchI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxInventorySearchI.SelectedText = "";
            this.metroTextBoxInventorySearchI.SelectionLength = 0;
            this.metroTextBoxInventorySearchI.SelectionStart = 0;
            this.metroTextBoxInventorySearchI.ShortcutsEnabled = true;
            this.metroTextBoxInventorySearchI.Size = new System.Drawing.Size(327, 23);
            this.metroTextBoxInventorySearchI.TabIndex = 4;
            this.metroTextBoxInventorySearchI.UseSelectable = true;
            this.metroTextBoxInventorySearchI.WaterMark = "Label name";
            this.metroTextBoxInventorySearchI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxInventorySearchI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InventoryColumn9
            // 
            this.InventoryColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn9.HeaderText = "Expected Gain";
            this.InventoryColumn9.Name = "InventoryColumn9";
            this.InventoryColumn9.ReadOnly = true;
            this.InventoryColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn9.Width = 94;
            // 
            // InventoryColumn8
            // 
            this.InventoryColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn8.HeaderText = "Current Gain";
            this.InventoryColumn8.Name = "InventoryColumn8";
            this.InventoryColumn8.ReadOnly = true;
            this.InventoryColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn8.Width = 85;
            // 
            // InventoryColumn7
            // 
            this.InventoryColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn7.HeaderText = "Expected Sale";
            this.InventoryColumn7.Name = "InventoryColumn7";
            this.InventoryColumn7.ReadOnly = true;
            this.InventoryColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn7.Width = 94;
            // 
            // InventoryColumn6
            // 
            this.InventoryColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn6.HeaderText = "Current Sale";
            this.InventoryColumn6.Name = "InventoryColumn6";
            this.InventoryColumn6.ReadOnly = true;
            this.InventoryColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn6.Width = 85;
            // 
            // InventoryColumn5
            // 
            this.InventoryColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn5.HeaderText = "Stock";
            this.InventoryColumn5.Name = "InventoryColumn5";
            this.InventoryColumn5.ReadOnly = true;
            this.InventoryColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn5.Width = 57;
            // 
            // InventoryColumn4
            // 
            this.InventoryColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn4.HeaderText = "Cost";
            this.InventoryColumn4.Name = "InventoryColumn4";
            this.InventoryColumn4.ReadOnly = true;
            this.InventoryColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn4.Width = 53;
            // 
            // InventoryColumn3
            // 
            this.InventoryColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn3.HeaderText = "Price";
            this.InventoryColumn3.Name = "InventoryColumn3";
            this.InventoryColumn3.ReadOnly = true;
            this.InventoryColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn3.Width = 54;
            // 
            // InventoryColumn1
            // 
            this.InventoryColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn1.HeaderText = "ID";
            this.InventoryColumn1.Name = "InventoryColumn1";
            this.InventoryColumn1.ReadOnly = true;
            this.InventoryColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn1.Width = 53;
            // 
            // metroButtonAddProduct
            // 
            this.metroButtonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonAddProduct.Location = new System.Drawing.Point(778, 3);
            this.metroButtonAddProduct.Name = "metroButtonAddProduct";
            this.metroButtonAddProduct.Size = new System.Drawing.Size(115, 41);
            this.metroButtonAddProduct.TabIndex = 12;
            this.metroButtonAddProduct.Text = "Add product";
            this.metroButtonAddProduct.UseSelectable = true;
            // 
            // metroButtonNextInventory
            // 
            this.metroButtonNextInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonNextInventory.Location = new System.Drawing.Point(536, 3);
            this.metroButtonNextInventory.Name = "metroButtonNextInventory";
            this.metroButtonNextInventory.Size = new System.Drawing.Size(115, 41);
            this.metroButtonNextInventory.TabIndex = 11;
            this.metroButtonNextInventory.Text = "Next Inventory";
            this.metroButtonNextInventory.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(298, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Enter admin password to unlock admin privilege :";
            // 
            // metroButtonEditProduct
            // 
            this.metroButtonEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonEditProduct.Location = new System.Drawing.Point(657, 3);
            this.metroButtonEditProduct.Name = "metroButtonEditProduct";
            this.metroButtonEditProduct.Size = new System.Drawing.Size(115, 41);
            this.metroButtonEditProduct.TabIndex = 9;
            this.metroButtonEditProduct.Text = "Manage product";
            this.metroButtonEditProduct.UseSelectable = true;
            // 
            // metroTextBoxPasswordI
            // 
            // 
            // 
            // 
            this.metroTextBoxPasswordI.CustomButton.Image = null;
            this.metroTextBoxPasswordI.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBoxPasswordI.CustomButton.Name = "";
            this.metroTextBoxPasswordI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPasswordI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPasswordI.CustomButton.TabIndex = 1;
            this.metroTextBoxPasswordI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPasswordI.CustomButton.UseSelectable = true;
            this.metroTextBoxPasswordI.CustomButton.Visible = false;
            this.metroTextBoxPasswordI.Lines = new string[0];
            this.metroTextBoxPasswordI.Location = new System.Drawing.Point(301, 12);
            this.metroTextBoxPasswordI.MaxLength = 32767;
            this.metroTextBoxPasswordI.Name = "metroTextBoxPasswordI";
            this.metroTextBoxPasswordI.PasswordChar = '●';
            this.metroTextBoxPasswordI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPasswordI.SelectedText = "";
            this.metroTextBoxPasswordI.SelectionLength = 0;
            this.metroTextBoxPasswordI.SelectionStart = 0;
            this.metroTextBoxPasswordI.ShortcutsEnabled = true;
            this.metroTextBoxPasswordI.Size = new System.Drawing.Size(165, 23);
            this.metroTextBoxPasswordI.TabIndex = 6;
            this.metroTextBoxPasswordI.UseSelectable = true;
            this.metroTextBoxPasswordI.UseSystemPasswordChar = true;
            this.metroTextBoxPasswordI.WaterMark = "Admin password";
            this.metroTextBoxPasswordI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPasswordI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanelInventoryBottom
            // 
            this.metroPanelInventoryBottom.Controls.Add(this.metroButtonAddProduct);
            this.metroPanelInventoryBottom.Controls.Add(this.metroButtonNextInventory);
            this.metroPanelInventoryBottom.Controls.Add(this.metroLabel1);
            this.metroPanelInventoryBottom.Controls.Add(this.metroButtonEditProduct);
            this.metroPanelInventoryBottom.Controls.Add(this.metroTextBoxPasswordI);
            this.metroPanelInventoryBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanelInventoryBottom.HorizontalScrollbarBarColor = true;
            this.metroPanelInventoryBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelInventoryBottom.HorizontalScrollbarSize = 10;
            this.metroPanelInventoryBottom.Location = new System.Drawing.Point(0, 396);
            this.metroPanelInventoryBottom.Name = "metroPanelInventoryBottom";
            this.metroPanelInventoryBottom.Size = new System.Drawing.Size(896, 46);
            this.metroPanelInventoryBottom.TabIndex = 14;
            this.metroPanelInventoryBottom.VerticalScrollbarBarColor = true;
            this.metroPanelInventoryBottom.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelInventoryBottom.VerticalScrollbarSize = 10;
            // 
            // InventoryColumn2
            // 
            this.InventoryColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InventoryColumn2.HeaderText = "Label Name";
            this.InventoryColumn2.Name = "InventoryColumn2";
            this.InventoryColumn2.ReadOnly = true;
            this.InventoryColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // metroGridInventory
            // 
            this.metroGridInventory.AllowUserToAddRows = false;
            this.metroGridInventory.AllowUserToDeleteRows = false;
            this.metroGridInventory.AllowUserToResizeRows = false;
            this.metroGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryColumn1,
            this.InventoryColumn2,
            this.InventoryColumn3,
            this.InventoryColumn4,
            this.InventoryColumn5,
            this.InventoryColumn6,
            this.InventoryColumn7,
            this.InventoryColumn8,
            this.InventoryColumn9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridInventory.EnableHeadersVisualStyles = false;
            this.metroGridInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridInventory.Location = new System.Drawing.Point(0, 37);
            this.metroGridInventory.MultiSelect = false;
            this.metroGridInventory.Name = "metroGridInventory";
            this.metroGridInventory.ReadOnly = true;
            this.metroGridInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridInventory.RowHeadersVisible = false;
            this.metroGridInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridInventory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroGridInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridInventory.Size = new System.Drawing.Size(896, 359);
            this.metroGridInventory.TabIndex = 12;
            // 
            // PnlManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMetro);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PnlManageInventory";
            this.Size = new System.Drawing.Size(896, 442);
            this.pnlMetro.ResumeLayout(false);
            this.metroPanelInventoryHeader.ResumeLayout(false);
            this.metroPanelInventoryHeader.PerformLayout();
            this.metroPanelInventoryBottom.ResumeLayout(false);
            this.metroPanelInventoryBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMetro;
        private MetroFramework.Controls.MetroPanel metroPanelInventoryHeader;
        private MetroFramework.Controls.MetroTextBox metroTextBoxInventorySearchI;
        private MetroFramework.Controls.MetroLabel metroLabelSearch2;
        private MetroFramework.Controls.MetroPanel metroPanelInventoryBottom;
        private MetroFramework.Controls.MetroButton metroButtonAddProduct;
        private MetroFramework.Controls.MetroButton metroButtonNextInventory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonEditProduct;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPasswordI;
        private MetroFramework.Controls.MetroGrid metroGridInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryColumn9;
    }
}
