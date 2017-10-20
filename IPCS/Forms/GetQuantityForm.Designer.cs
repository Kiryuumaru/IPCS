namespace IPCS.Forms
{
    partial class GetQuantityForm
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
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.btnSubtract = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtBoxQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblQuantity = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(35, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(331, 196);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Ok";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubtract.Location = new System.Drawing.Point(3, 3);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(25, 25);
            this.btnSubtract.TabIndex = 24;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseSelectable = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdd.Location = new System.Drawing.Point(79, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "+";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxQuantity
            // 
            // 
            // 
            // 
            this.txtBoxQuantity.CustomButton.Image = null;
            this.txtBoxQuantity.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txtBoxQuantity.CustomButton.Name = "";
            this.txtBoxQuantity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBoxQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxQuantity.CustomButton.TabIndex = 1;
            this.txtBoxQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxQuantity.CustomButton.UseSelectable = true;
            this.txtBoxQuantity.CustomButton.Visible = false;
            this.txtBoxQuantity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBoxQuantity.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtBoxQuantity.Lines = new string[] {
        "1"};
            this.txtBoxQuantity.Location = new System.Drawing.Point(34, 3);
            this.txtBoxQuantity.MaxLength = 32767;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.PasswordChar = '\0';
            this.txtBoxQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxQuantity.SelectedText = "";
            this.txtBoxQuantity.SelectionLength = 0;
            this.txtBoxQuantity.SelectionStart = 0;
            this.txtBoxQuantity.ShortcutsEnabled = true;
            this.txtBoxQuantity.Size = new System.Drawing.Size(39, 25);
            this.txtBoxQuantity.TabIndex = 26;
            this.txtBoxQuantity.Text = "1";
            this.txtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxQuantity.UseSelectable = true;
            this.txtBoxQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxQuantity.TextChanged += new System.EventHandler(this.txtBoxQuantity_TextChanged);
            this.txtBoxQuantity.Click += new System.EventHandler(this.txtBoxQuantity_Click);
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integerTextBox_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPrice.Location = new System.Drawing.Point(281, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 19);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStock.Location = new System.Drawing.Point(281, 48);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 19);
            this.lblStock.TabIndex = 22;
            this.lblStock.Text = "stock";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblId.Location = new System.Drawing.Point(281, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(41, 19);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "000x";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblName.Location = new System.Drawing.Point(281, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 19);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQuantity.Location = new System.Drawing.Point(83, 5);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 19);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Quantity :";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(131, 91);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(260, 30);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.lblQuantity);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroPanel2.Size = new System.Drawing.Size(153, 30);
            this.metroPanel2.TabIndex = 32;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.btnSubtract);
            this.metroPanel3.Controls.Add(this.btnAdd);
            this.metroPanel3.Controls.Add(this.txtBoxQuantity);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(153, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(107, 30);
            this.metroPanel3.TabIndex = 32;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroPanel1);
            this.metroPanel4.Controls.Add(this.productPicture);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.metroLabel7);
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.Controls.Add(this.lblPrice);
            this.metroPanel4.Controls.Add(this.metroLabel10);
            this.metroPanel4.Controls.Add(this.lblStock);
            this.metroPanel4.Controls.Add(this.lblId);
            this.metroPanel4.Controls.Add(this.lblName);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(35, 53);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(396, 126);
            this.metroPanel4.TabIndex = 33;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.Color.Transparent;
            this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPicture.Image = global::IPCS.Properties.Resources.logo;
            this.productPicture.Location = new System.Drawing.Point(0, 0);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(126, 126);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPicture.TabIndex = 37;
            this.productPicture.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(234, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Price :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(232, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(47, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Stock :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(251, 10);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(28, 19);
            this.metroLabel9.TabIndex = 26;
            this.metroLabel9.Text = "ID :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(195, 29);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(84, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Label name :";
            // 
            // GetQuantityForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(465, 272);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetQuantityForm";
            this.NotifDefaultText = "Ready";
            this.NotifText = "Ready";
            this.Resizable = false;
            this.Text = "Quantity";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.metroPanel4, 0);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroButton btnSubtract;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtBoxQuantity;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblQuantity;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.PictureBox productPicture;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}