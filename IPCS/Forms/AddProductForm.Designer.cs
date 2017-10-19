namespace IPCS.Forms
{
    partial class AddProductForm
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
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtBoxName = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxCost = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxQuantity = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(363, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add product";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(35, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxName
            // 
            // 
            // 
            // 
            this.txtBoxName.CustomButton.Image = null;
            this.txtBoxName.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtBoxName.CustomButton.Name = "";
            this.txtBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxName.CustomButton.TabIndex = 1;
            this.txtBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxName.CustomButton.UseSelectable = true;
            this.txtBoxName.CustomButton.Visible = false;
            this.txtBoxName.Lines = new string[0];
            this.txtBoxName.Location = new System.Drawing.Point(192, 75);
            this.txtBoxName.MaxLength = 32767;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PasswordChar = '\0';
            this.txtBoxName.PromptText = "Product name";
            this.txtBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxName.SelectedText = "";
            this.txtBoxName.SelectionLength = 0;
            this.txtBoxName.SelectionStart = 0;
            this.txtBoxName.ShortcutsEnabled = true;
            this.txtBoxName.Size = new System.Drawing.Size(165, 23);
            this.txtBoxName.TabIndex = 20;
            this.txtBoxName.UseSelectable = true;
            this.txtBoxName.WaterMark = "Product name";
            this.txtBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxPrice
            // 
            // 
            // 
            // 
            this.txtBoxPrice.CustomButton.Image = null;
            this.txtBoxPrice.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtBoxPrice.CustomButton.Name = "";
            this.txtBoxPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPrice.CustomButton.TabIndex = 1;
            this.txtBoxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPrice.CustomButton.UseSelectable = true;
            this.txtBoxPrice.CustomButton.Visible = false;
            this.txtBoxPrice.Lines = new string[0];
            this.txtBoxPrice.Location = new System.Drawing.Point(192, 104);
            this.txtBoxPrice.MaxLength = 32767;
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.PasswordChar = '\0';
            this.txtBoxPrice.PromptText = "Price";
            this.txtBoxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPrice.SelectedText = "";
            this.txtBoxPrice.SelectionLength = 0;
            this.txtBoxPrice.SelectionStart = 0;
            this.txtBoxPrice.ShortcutsEnabled = true;
            this.txtBoxPrice.Size = new System.Drawing.Size(165, 23);
            this.txtBoxPrice.TabIndex = 21;
            this.txtBoxPrice.UseSelectable = true;
            this.txtBoxPrice.WaterMark = "Price";
            this.txtBoxPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.doubleTextBox_KeyPress);
            // 
            // txtBoxCost
            // 
            // 
            // 
            // 
            this.txtBoxCost.CustomButton.Image = null;
            this.txtBoxCost.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtBoxCost.CustomButton.Name = "";
            this.txtBoxCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxCost.CustomButton.TabIndex = 1;
            this.txtBoxCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxCost.CustomButton.UseSelectable = true;
            this.txtBoxCost.CustomButton.Visible = false;
            this.txtBoxCost.Lines = new string[0];
            this.txtBoxCost.Location = new System.Drawing.Point(192, 133);
            this.txtBoxCost.MaxLength = 32767;
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.PasswordChar = '\0';
            this.txtBoxCost.PromptText = "Cost";
            this.txtBoxCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxCost.SelectedText = "";
            this.txtBoxCost.SelectionLength = 0;
            this.txtBoxCost.SelectionStart = 0;
            this.txtBoxCost.ShortcutsEnabled = true;
            this.txtBoxCost.Size = new System.Drawing.Size(165, 23);
            this.txtBoxCost.TabIndex = 22;
            this.txtBoxCost.UseSelectable = true;
            this.txtBoxCost.WaterMark = "Cost";
            this.txtBoxCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.doubleTextBox_KeyPress);
            // 
            // txtBoxQuantity
            // 
            // 
            // 
            // 
            this.txtBoxQuantity.CustomButton.Image = null;
            this.txtBoxQuantity.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtBoxQuantity.CustomButton.Name = "";
            this.txtBoxQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxQuantity.CustomButton.TabIndex = 1;
            this.txtBoxQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxQuantity.CustomButton.UseSelectable = true;
            this.txtBoxQuantity.CustomButton.Visible = false;
            this.txtBoxQuantity.Lines = new string[0];
            this.txtBoxQuantity.Location = new System.Drawing.Point(192, 162);
            this.txtBoxQuantity.MaxLength = 32767;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.PasswordChar = '\0';
            this.txtBoxQuantity.PromptText = "Initial quantity";
            this.txtBoxQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxQuantity.SelectedText = "";
            this.txtBoxQuantity.SelectionLength = 0;
            this.txtBoxQuantity.SelectionStart = 0;
            this.txtBoxQuantity.ShortcutsEnabled = true;
            this.txtBoxQuantity.Size = new System.Drawing.Size(165, 23);
            this.txtBoxQuantity.TabIndex = 23;
            this.txtBoxQuantity.UseSelectable = true;
            this.txtBoxQuantity.WaterMark = "Initial quantity";
            this.txtBoxQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integerTextBox_KeyPress);
            // 
            // AddProductForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.NotifDefaultText = "Server Ready";
            this.NotifText = "Server Ready";
            this.Resizable = false;
            this.Text = "Add Product";
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtBoxName, 0);
            this.Controls.SetChildIndex(this.txtBoxPrice, 0);
            this.Controls.SetChildIndex(this.txtBoxCost, 0);
            this.Controls.SetChildIndex(this.txtBoxQuantity, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtBoxName;
        private MetroFramework.Controls.MetroTextBox txtBoxPrice;
        private MetroFramework.Controls.MetroTextBox txtBoxCost;
        private MetroFramework.Controls.MetroTextBox txtBoxQuantity;
    }
}