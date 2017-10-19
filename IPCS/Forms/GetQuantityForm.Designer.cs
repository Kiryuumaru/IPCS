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
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(35, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Location = new System.Drawing.Point(263, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Ok";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubtract.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSubtract.Location = new System.Drawing.Point(213, 163);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(35, 35);
            this.btnSubtract.TabIndex = 24;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseSelectable = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.Location = new System.Drawing.Point(328, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
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
            this.txtBoxQuantity.CustomButton.Location = new System.Drawing.Point(34, 1);
            this.txtBoxQuantity.CustomButton.Name = "";
            this.txtBoxQuantity.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtBoxQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxQuantity.CustomButton.TabIndex = 1;
            this.txtBoxQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxQuantity.CustomButton.UseSelectable = true;
            this.txtBoxQuantity.CustomButton.Visible = false;
            this.txtBoxQuantity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxQuantity.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtBoxQuantity.Lines = new string[] {
        "1"};
            this.txtBoxQuantity.Location = new System.Drawing.Point(254, 163);
            this.txtBoxQuantity.MaxLength = 32767;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.PasswordChar = '\0';
            this.txtBoxQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxQuantity.SelectedText = "";
            this.txtBoxQuantity.SelectionLength = 0;
            this.txtBoxQuantity.SelectionStart = 0;
            this.txtBoxQuantity.ShortcutsEnabled = true;
            this.txtBoxQuantity.Size = new System.Drawing.Size(68, 35);
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
            // GetQuantityForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetQuantityForm";
            this.NotifDefaultText = "Ready";
            this.NotifText = "Ready";
            this.Resizable = false;
            this.Text = "GetQuantity";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSubtract, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.txtBoxQuantity, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroButton btnSubtract;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtBoxQuantity;
    }
}