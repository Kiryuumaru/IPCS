namespace IPCS.Forms
{
    partial class ReceiptForm
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
            this.txtBoxReceipt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBoxReceipt
            // 
            this.txtBoxReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxReceipt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxReceipt.Location = new System.Drawing.Point(2, 35);
            this.txtBoxReceipt.MaxLength = 0;
            this.txtBoxReceipt.Name = "txtBoxReceipt";
            this.txtBoxReceipt.ReadOnly = true;
            this.txtBoxReceipt.Size = new System.Drawing.Size(396, 463);
            this.txtBoxReceipt.TabIndex = 3;
            this.txtBoxReceipt.Text = "";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.txtBoxReceipt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptForm";
            this.NotificationBox = false;
            this.Resizable = false;
            this.Text = "Receipt";
            this.Controls.SetChildIndex(this.txtBoxReceipt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxReceipt;
    }
}