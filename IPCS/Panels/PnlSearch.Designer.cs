namespace IPCS.Panels
{
    partial class PnlSearch
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
            this.comboBoxSearch = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.ItemHeight = 23;
            this.comboBoxSearch.Location = new System.Drawing.Point(-1, -3);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(154, 29);
            this.comboBoxSearch.TabIndex = 2;
            this.comboBoxSearch.UseSelectable = true;
            this.comboBoxSearch.TextChanged += new System.EventHandler(this.comboBoxSearch_TextChanged);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.CustomButton.Visible = false;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(127, 23);
            this.txtBoxSearch.TabIndex = 3;
            this.txtBoxSearch.UseSelectable = true;
            this.txtBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSearch.Click += new System.EventHandler(this.txtBoxSearch_Click);
            this.txtBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearch_KeyPress);
            this.txtBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyUp);
            // 
            // PnlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PnlSearch";
            this.Size = new System.Drawing.Size(152, 23);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox comboBoxSearch;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
    }
}
