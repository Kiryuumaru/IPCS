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
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.txtBoxCash = new MetroFramework.Controls.MetroTextBox();
            this.lblCash = new MetroFramework.Controls.MetroLabel();
            this.lblTotalCurr = new MetroFramework.Controls.MetroLabel();
            this.lblCashCurr = new MetroFramework.Controls.MetroLabel();
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
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotal.Location = new System.Drawing.Point(207, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 25);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "000x";
            // 
            // txtBoxCash
            // 
            // 
            // 
            // 
            this.txtBoxCash.CustomButton.Image = null;
            this.txtBoxCash.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.txtBoxCash.CustomButton.Name = "";
            this.txtBoxCash.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBoxCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxCash.CustomButton.TabIndex = 1;
            this.txtBoxCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxCash.CustomButton.UseSelectable = true;
            this.txtBoxCash.CustomButton.Visible = false;
            this.txtBoxCash.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxCash.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtBoxCash.Lines = new string[] {
        "1"};
            this.txtBoxCash.Location = new System.Drawing.Point(207, 95);
            this.txtBoxCash.MaxLength = 32767;
            this.txtBoxCash.Name = "txtBoxCash";
            this.txtBoxCash.PasswordChar = '\0';
            this.txtBoxCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxCash.SelectedText = "";
            this.txtBoxCash.SelectionLength = 0;
            this.txtBoxCash.SelectionStart = 0;
            this.txtBoxCash.ShortcutsEnabled = true;
            this.txtBoxCash.Size = new System.Drawing.Size(93, 30);
            this.txtBoxCash.TabIndex = 29;
            this.txtBoxCash.Text = "1";
            this.txtBoxCash.UseSelectable = true;
            this.txtBoxCash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxCash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxCash.TextChanged += new System.EventHandler(this.txtBoxCash_TextChanged);
            this.txtBoxCash.Click += new System.EventHandler(this.txtBoxCash_Click);
            this.txtBoxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCash_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCash.Location = new System.Drawing.Point(126, 98);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(63, 25);
            this.lblCash.TabIndex = 30;
            this.lblCash.Text = "Cash : ";
            // 
            // lblTotalCurr
            // 
            this.lblTotalCurr.AutoSize = true;
            this.lblTotalCurr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalCurr.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalCurr.Location = new System.Drawing.Point(179, 61);
            this.lblTotalCurr.Name = "lblTotalCurr";
            this.lblTotalCurr.Size = new System.Drawing.Size(22, 25);
            this.lblTotalCurr.TabIndex = 31;
            this.lblTotalCurr.Text = "$";
            // 
            // lblCashCurr
            // 
            this.lblCashCurr.AutoSize = true;
            this.lblCashCurr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCashCurr.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCashCurr.Location = new System.Drawing.Point(179, 98);
            this.lblCashCurr.Name = "lblCashCurr";
            this.lblCashCurr.Size = new System.Drawing.Size(22, 25);
            this.lblCashCurr.TabIndex = 32;
            this.lblCashCurr.Text = "$";
            // 
            // GetCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.lblCashCurr);
            this.Controls.Add(this.lblTotalCurr);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtBoxCash);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblTotal);
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
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.metroLabel5, 0);
            this.Controls.SetChildIndex(this.txtBoxCash, 0);
            this.Controls.SetChildIndex(this.lblCash, 0);
            this.Controls.SetChildIndex(this.lblTotalCurr, 0);
            this.Controls.SetChildIndex(this.lblCashCurr, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroTextBox txtBoxCash;
        private MetroFramework.Controls.MetroLabel lblCash;
        private MetroFramework.Controls.MetroLabel lblTotalCurr;
        private MetroFramework.Controls.MetroLabel lblCashCurr;
    }
}