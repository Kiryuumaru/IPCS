namespace IPCS.Forms
{
    partial class GetCashForm
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtBoxQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(34, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(263, 156);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "Ok";
            this.btnOk.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(129, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 25);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Total : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblId.Location = new System.Drawing.Point(195, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 25);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "000x";
            // 
            // txtBoxQuantity
            // 
            // 
            // 
            // 
            this.txtBoxQuantity.CustomButton.Image = null;
            this.txtBoxQuantity.CustomButton.Location = new System.Drawing.Point(69, 1);
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
            this.txtBoxQuantity.Location = new System.Drawing.Point(195, 98);
            this.txtBoxQuantity.MaxLength = 32767;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.PasswordChar = '\0';
            this.txtBoxQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxQuantity.SelectedText = "";
            this.txtBoxQuantity.SelectionLength = 0;
            this.txtBoxQuantity.SelectionStart = 0;
            this.txtBoxQuantity.ShortcutsEnabled = true;
            this.txtBoxQuantity.Size = new System.Drawing.Size(93, 25);
            this.txtBoxQuantity.TabIndex = 29;
            this.txtBoxQuantity.Text = "1";
            this.txtBoxQuantity.UseSelectable = true;
            this.txtBoxQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxQuantity.TextChanged += new System.EventHandler(this.txtBoxQuantity_TextChanged);
            this.txtBoxQuantity.Click += new System.EventHandler(this.txtBoxQuantity_Click);
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxQuantity_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(126, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Cash : ";
            // 
            // GetCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetCashForm";
            this.NotifDefaultText = "Ready";
            this.NotifText = "Ready";
            this.Resizable = false;
            this.Text = "Cash";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.metroLabel5, 0);
            this.Controls.SetChildIndex(this.txtBoxQuantity, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtBoxQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}