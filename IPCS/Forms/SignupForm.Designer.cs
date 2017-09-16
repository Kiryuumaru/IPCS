namespace IPCS.Forms
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.btnSignup = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.btnBrowsePic = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtRecoveryKey = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignup.Location = new System.Drawing.Point(370, 228);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(100, 35);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Create Account";
            this.btnSignup.UseSelectable = true;
            this.btnSignup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(217, 95);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(253, 28);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(217, 61);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(253, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtConfirmPassword.CustomButton.Image = null;
            this.txtConfirmPassword.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.txtConfirmPassword.CustomButton.Name = "";
            this.txtConfirmPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPassword.CustomButton.TabIndex = 1;
            this.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPassword.CustomButton.UseSelectable = true;
            this.txtConfirmPassword.CustomButton.Visible = false;
            this.txtConfirmPassword.DisplayIcon = true;
            this.txtConfirmPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtConfirmPassword.Icon")));
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(217, 129);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(253, 28);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.UseSelectable = true;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.WaterMark = "Confirm Password";
            this.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(34, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePicture.Image = global::IPCS.Properties.Resources.logo;
            this.profilePicture.Location = new System.Drawing.Point(64, 61);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(100, 100);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 19;
            this.profilePicture.TabStop = false;
            // 
            // btnBrowsePic
            // 
            this.btnBrowsePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowsePic.Location = new System.Drawing.Point(64, 169);
            this.btnBrowsePic.Name = "btnBrowsePic";
            this.btnBrowsePic.Size = new System.Drawing.Size(100, 22);
            this.btnBrowsePic.TabIndex = 20;
            this.btnBrowsePic.Text = "Browse";
            this.btnBrowsePic.UseSelectable = true;
            this.btnBrowsePic.Click += new System.EventHandler(this.BrowsePic_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image (*.png, *.jpg, *.tif)|*.png;*.jpg;*.tif";
            // 
            // txtRecoveryKey
            // 
            this.txtRecoveryKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtRecoveryKey.CustomButton.Image = null;
            this.txtRecoveryKey.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.txtRecoveryKey.CustomButton.Name = "";
            this.txtRecoveryKey.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRecoveryKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRecoveryKey.CustomButton.TabIndex = 1;
            this.txtRecoveryKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecoveryKey.CustomButton.UseSelectable = true;
            this.txtRecoveryKey.CustomButton.Visible = false;
            this.txtRecoveryKey.DisplayIcon = true;
            this.txtRecoveryKey.Icon = ((System.Drawing.Image)(resources.GetObject("txtRecoveryKey.Icon")));
            this.txtRecoveryKey.Lines = new string[0];
            this.txtRecoveryKey.Location = new System.Drawing.Point(217, 163);
            this.txtRecoveryKey.MaxLength = 32767;
            this.txtRecoveryKey.Name = "txtRecoveryKey";
            this.txtRecoveryKey.PasswordChar = '\0';
            this.txtRecoveryKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecoveryKey.SelectedText = "";
            this.txtRecoveryKey.SelectionLength = 0;
            this.txtRecoveryKey.SelectionStart = 0;
            this.txtRecoveryKey.ShortcutsEnabled = true;
            this.txtRecoveryKey.Size = new System.Drawing.Size(253, 28);
            this.txtRecoveryKey.TabIndex = 21;
            this.txtRecoveryKey.UseSelectable = true;
            this.txtRecoveryKey.WaterMark = "Recovery key (for recovering lost pass)";
            this.txtRecoveryKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRecoveryKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.txtRecoveryKey);
            this.Controls.Add(this.btnBrowsePic);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.Name = "SignupForm";
            this.Resizable = false;
            this.Text = "Signup";
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnSignup, 0);
            this.Controls.SetChildIndex(this.txtConfirmPassword, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.profilePicture, 0);
            this.Controls.SetChildIndex(this.btnBrowsePic, 0);
            this.Controls.SetChildIndex(this.txtRecoveryKey, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSignup;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.PictureBox profilePicture;
        private MetroFramework.Controls.MetroButton btnBrowsePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroTextBox txtRecoveryKey;
    }
}