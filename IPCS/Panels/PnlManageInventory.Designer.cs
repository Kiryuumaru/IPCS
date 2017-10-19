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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMetro = new MetroFramework.Controls.MetroPanel();
            this.metroGridInventory = new MetroFramework.Controls.MetroGrid();
            this.metroPanelInventoryHeader = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxInventorySearchI = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelSearch2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelInventoryBottom = new MetroFramework.Controls.MetroPanel();
            this.pnlPrivilege = new MetroFramework.Controls.MetroPanel();
            this.pnlAdminPrivilege = new MetroFramework.Controls.MetroPanel();
            this.btnHidePrivilege = new MetroFramework.Controls.MetroButton();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.btnEditProduct = new MetroFramework.Controls.MetroButton();
            this.btnDeleteProduct = new MetroFramework.Controls.MetroButton();
            this.pnlUnlockPrivilege = new MetroFramework.Controls.MetroPanel();
            this.btnUnlock = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.InventoryColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMetro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridInventory)).BeginInit();
            this.metroPanelInventoryHeader.SuspendLayout();
            this.metroPanelInventoryBottom.SuspendLayout();
            this.pnlPrivilege.SuspendLayout();
            this.pnlAdminPrivilege.SuspendLayout();
            this.pnlUnlockPrivilege.SuspendLayout();
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
            // metroGridInventory
            // 
            this.metroGridInventory.AllowUserToAddRows = false;
            this.metroGridInventory.AllowUserToDeleteRows = false;
            this.metroGridInventory.AllowUserToResizeRows = false;
            this.metroGridInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.metroGridInventory.ColumnHeadersHeight = 30;
            this.metroGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridInventory.DefaultCellStyle = dataGridViewCellStyle20;
            this.metroGridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridInventory.EnableHeadersVisualStyles = false;
            this.metroGridInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridInventory.Location = new System.Drawing.Point(0, 30);
            this.metroGridInventory.MultiSelect = false;
            this.metroGridInventory.Name = "metroGridInventory";
            this.metroGridInventory.ReadOnly = true;
            this.metroGridInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGridInventory.RowHeadersVisible = false;
            this.metroGridInventory.RowHeadersWidth = 40;
            this.metroGridInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridInventory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.metroGridInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridInventory.Size = new System.Drawing.Size(896, 387);
            this.metroGridInventory.TabIndex = 12;
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
            this.metroPanelInventoryHeader.Size = new System.Drawing.Size(896, 30);
            this.metroPanelInventoryHeader.TabIndex = 13;
            this.metroPanelInventoryHeader.VerticalScrollbarBarColor = true;
            this.metroPanelInventoryHeader.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelInventoryHeader.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxInventorySearchI
            // 
            this.metroTextBoxInventorySearchI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.metroTextBoxInventorySearchI.CustomButton.Image = null;
            this.metroTextBoxInventorySearchI.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.metroTextBoxInventorySearchI.CustomButton.Name = "";
            this.metroTextBoxInventorySearchI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxInventorySearchI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxInventorySearchI.CustomButton.TabIndex = 1;
            this.metroTextBoxInventorySearchI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxInventorySearchI.CustomButton.UseSelectable = true;
            this.metroTextBoxInventorySearchI.CustomButton.Visible = false;
            this.metroTextBoxInventorySearchI.Lines = new string[0];
            this.metroTextBoxInventorySearchI.Location = new System.Drawing.Point(58, 5);
            this.metroTextBoxInventorySearchI.Margin = new System.Windows.Forms.Padding(0);
            this.metroTextBoxInventorySearchI.MaxLength = 32767;
            this.metroTextBoxInventorySearchI.Name = "metroTextBoxInventorySearchI";
            this.metroTextBoxInventorySearchI.PasswordChar = '\0';
            this.metroTextBoxInventorySearchI.PromptText = "Label name";
            this.metroTextBoxInventorySearchI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxInventorySearchI.SelectedText = "";
            this.metroTextBoxInventorySearchI.SelectionLength = 0;
            this.metroTextBoxInventorySearchI.SelectionStart = 0;
            this.metroTextBoxInventorySearchI.ShortcutsEnabled = true;
            this.metroTextBoxInventorySearchI.Size = new System.Drawing.Size(332, 23);
            this.metroTextBoxInventorySearchI.TabIndex = 4;
            this.metroTextBoxInventorySearchI.UseSelectable = true;
            this.metroTextBoxInventorySearchI.WaterMark = "Label name";
            this.metroTextBoxInventorySearchI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxInventorySearchI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelSearch2
            // 
            this.metroLabelSearch2.AutoSize = true;
            this.metroLabelSearch2.Location = new System.Drawing.Point(0, 5);
            this.metroLabelSearch2.Name = "metroLabelSearch2";
            this.metroLabelSearch2.Size = new System.Drawing.Size(55, 19);
            this.metroLabelSearch2.TabIndex = 2;
            this.metroLabelSearch2.Text = "Search :";
            // 
            // metroPanelInventoryBottom
            // 
            this.metroPanelInventoryBottom.Controls.Add(this.pnlPrivilege);
            this.metroPanelInventoryBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanelInventoryBottom.HorizontalScrollbarBarColor = true;
            this.metroPanelInventoryBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelInventoryBottom.HorizontalScrollbarSize = 10;
            this.metroPanelInventoryBottom.Location = new System.Drawing.Point(0, 417);
            this.metroPanelInventoryBottom.Name = "metroPanelInventoryBottom";
            this.metroPanelInventoryBottom.Size = new System.Drawing.Size(896, 25);
            this.metroPanelInventoryBottom.TabIndex = 14;
            this.metroPanelInventoryBottom.VerticalScrollbarBarColor = true;
            this.metroPanelInventoryBottom.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelInventoryBottom.VerticalScrollbarSize = 10;
            // 
            // pnlPrivilege
            // 
            this.pnlPrivilege.Controls.Add(this.pnlAdminPrivilege);
            this.pnlPrivilege.Controls.Add(this.pnlUnlockPrivilege);
            this.pnlPrivilege.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPrivilege.HorizontalScrollbarBarColor = true;
            this.pnlPrivilege.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPrivilege.HorizontalScrollbarSize = 10;
            this.pnlPrivilege.Location = new System.Drawing.Point(0, 0);
            this.pnlPrivilege.Name = "pnlPrivilege";
            this.pnlPrivilege.Size = new System.Drawing.Size(896, 25);
            this.pnlPrivilege.TabIndex = 13;
            this.pnlPrivilege.VerticalScrollbarBarColor = true;
            this.pnlPrivilege.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPrivilege.VerticalScrollbarSize = 10;
            // 
            // pnlAdminPrivilege
            // 
            this.pnlAdminPrivilege.Controls.Add(this.btnHidePrivilege);
            this.pnlAdminPrivilege.Controls.Add(this.btnAddProduct);
            this.pnlAdminPrivilege.Controls.Add(this.btnEditProduct);
            this.pnlAdminPrivilege.Controls.Add(this.btnDeleteProduct);
            this.pnlAdminPrivilege.HorizontalScrollbarBarColor = true;
            this.pnlAdminPrivilege.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminPrivilege.HorizontalScrollbarSize = 10;
            this.pnlAdminPrivilege.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminPrivilege.Name = "pnlAdminPrivilege";
            this.pnlAdminPrivilege.Size = new System.Drawing.Size(893, 25);
            this.pnlAdminPrivilege.TabIndex = 15;
            this.pnlAdminPrivilege.VerticalScrollbarBarColor = true;
            this.pnlAdminPrivilege.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminPrivilege.VerticalScrollbarSize = 10;
            // 
            // btnHidePrivilege
            // 
            this.btnHidePrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHidePrivilege.Location = new System.Drawing.Point(743, 0);
            this.btnHidePrivilege.Name = "btnHidePrivilege";
            this.btnHidePrivilege.Size = new System.Drawing.Size(150, 25);
            this.btnHidePrivilege.TabIndex = 13;
            this.btnHidePrivilege.Text = "Hide admin controls";
            this.btnHidePrivilege.UseSelectable = true;
            this.btnHidePrivilege.Click += new System.EventHandler(this.btnHidePrivelege_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.Location = new System.Drawing.Point(587, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 25);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProduct.Location = new System.Drawing.Point(431, 0);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(150, 25);
            this.btnEditProduct.TabIndex = 9;
            this.btnEditProduct.Text = "Edit selected product";
            this.btnEditProduct.UseSelectable = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(275, 0);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(150, 25);
            this.btnDeleteProduct.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDeleteProduct.TabIndex = 14;
            this.btnDeleteProduct.Text = "Delete selected product";
            this.btnDeleteProduct.UseCustomForeColor = true;
            this.btnDeleteProduct.UseSelectable = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // pnlUnlockPrivilege
            // 
            this.pnlUnlockPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnlockPrivilege.Controls.Add(this.btnUnlock);
            this.pnlUnlockPrivilege.Controls.Add(this.metroLabel1);
            this.pnlUnlockPrivilege.Controls.Add(this.txtBoxPassword);
            this.pnlUnlockPrivilege.HorizontalScrollbarBarColor = true;
            this.pnlUnlockPrivilege.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlUnlockPrivilege.HorizontalScrollbarSize = 10;
            this.pnlUnlockPrivilege.Location = new System.Drawing.Point(0, 0);
            this.pnlUnlockPrivilege.Name = "pnlUnlockPrivilege";
            this.pnlUnlockPrivilege.Size = new System.Drawing.Size(893, 25);
            this.pnlUnlockPrivilege.TabIndex = 11;
            this.pnlUnlockPrivilege.VerticalScrollbarBarColor = true;
            this.pnlUnlockPrivilege.VerticalScrollbarHighlightOnWheel = false;
            this.pnlUnlockPrivilege.VerticalScrollbarSize = 10;
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(743, 0);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(150, 25);
            this.btnUnlock.TabIndex = 12;
            this.btnUnlock.Text = "Show admin controls";
            this.btnUnlock.UseSelectable = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(416, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Unlock admin privilege ";
            // 
            // txtBoxPassword
            // 
            // 
            // 
            // 
            this.txtBoxPassword.CustomButton.Image = null;
            this.txtBoxPassword.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtBoxPassword.CustomButton.Name = "";
            this.txtBoxPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPassword.CustomButton.TabIndex = 1;
            this.txtBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPassword.CustomButton.UseSelectable = true;
            this.txtBoxPassword.CustomButton.Visible = false;
            this.txtBoxPassword.Lines = new string[0];
            this.txtBoxPassword.Location = new System.Drawing.Point(572, 0);
            this.txtBoxPassword.MaxLength = 32767;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '●';
            this.txtBoxPassword.PromptText = "Admin password";
            this.txtBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.SelectionLength = 0;
            this.txtBoxPassword.SelectionStart = 0;
            this.txtBoxPassword.ShortcutsEnabled = true;
            this.txtBoxPassword.Size = new System.Drawing.Size(165, 25);
            this.txtBoxPassword.TabIndex = 6;
            this.txtBoxPassword.UseSelectable = true;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.WaterMark = "Admin password";
            this.txtBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InventoryColumn1
            // 
            this.InventoryColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InventoryColumn1.HeaderText = "ID";
            this.InventoryColumn1.Name = "InventoryColumn1";
            this.InventoryColumn1.ReadOnly = true;
            this.InventoryColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn1.Width = 50;
            // 
            // InventoryColumn2
            // 
            this.InventoryColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InventoryColumn2.HeaderText = "Label Name";
            this.InventoryColumn2.Name = "InventoryColumn2";
            this.InventoryColumn2.ReadOnly = true;
            this.InventoryColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // InventoryColumn3
            // 
            this.InventoryColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryColumn3.HeaderText = "Price";
            this.InventoryColumn3.Name = "InventoryColumn3";
            this.InventoryColumn3.ReadOnly = true;
            this.InventoryColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn3.Width = 66;
            // 
            // InventoryColumn4
            // 
            this.InventoryColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryColumn4.HeaderText = "Cost";
            this.InventoryColumn4.Name = "InventoryColumn4";
            this.InventoryColumn4.ReadOnly = true;
            this.InventoryColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn4.Width = 65;
            // 
            // InventoryColumn5
            // 
            this.InventoryColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryColumn5.HeaderText = "Stock";
            this.InventoryColumn5.Name = "InventoryColumn5";
            this.InventoryColumn5.ReadOnly = true;
            this.InventoryColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn5.Width = 70;
            // 
            // InventoryColumn6
            // 
            this.InventoryColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryColumn6.HeaderText = "Current Sale";
            this.InventoryColumn6.Name = "InventoryColumn6";
            this.InventoryColumn6.ReadOnly = true;
            this.InventoryColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn6.Width = 97;
            // 
            // InventoryColumn7
            // 
            this.InventoryColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryColumn7.HeaderText = "Expected Sale";
            this.InventoryColumn7.Name = "InventoryColumn7";
            this.InventoryColumn7.ReadOnly = true;
            this.InventoryColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn7.Width = 104;
            // 
            // InventoryColumn8
            // 
            this.InventoryColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryColumn8.HeaderText = "Current Gain";
            this.InventoryColumn8.Name = "InventoryColumn8";
            this.InventoryColumn8.ReadOnly = true;
            this.InventoryColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // InventoryColumn9
            // 
            this.InventoryColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryColumn9.HeaderText = "Expected Gain";
            this.InventoryColumn9.Name = "InventoryColumn9";
            this.InventoryColumn9.ReadOnly = true;
            this.InventoryColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryColumn9.Width = 106;
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
            ((System.ComponentModel.ISupportInitialize)(this.metroGridInventory)).EndInit();
            this.metroPanelInventoryHeader.ResumeLayout(false);
            this.metroPanelInventoryHeader.PerformLayout();
            this.metroPanelInventoryBottom.ResumeLayout(false);
            this.pnlPrivilege.ResumeLayout(false);
            this.pnlAdminPrivilege.ResumeLayout(false);
            this.pnlUnlockPrivilege.ResumeLayout(false);
            this.pnlUnlockPrivilege.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMetro;
        private MetroFramework.Controls.MetroPanel metroPanelInventoryHeader;
        private MetroFramework.Controls.MetroTextBox metroTextBoxInventorySearchI;
        private MetroFramework.Controls.MetroLabel metroLabelSearch2;
        private MetroFramework.Controls.MetroPanel metroPanelInventoryBottom;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnEditProduct;
        private MetroFramework.Controls.MetroTextBox txtBoxPassword;
        private MetroFramework.Controls.MetroGrid metroGridInventory;
        private MetroFramework.Controls.MetroPanel pnlUnlockPrivilege;
        private MetroFramework.Controls.MetroPanel pnlPrivilege;
        private MetroFramework.Controls.MetroButton btnUnlock;
        private MetroFramework.Controls.MetroButton btnHidePrivilege;
        private MetroFramework.Controls.MetroButton btnDeleteProduct;
        private MetroFramework.Controls.MetroPanel pnlAdminPrivilege;
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
