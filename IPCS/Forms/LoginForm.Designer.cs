namespace IPCS.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txUsername = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.Location = new System.Drawing.Point(314, 186);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(97, 33);
            this.btnLogIn.TabIndex = 11;
            this.btnLogIn.Text = "&Login";
            this.btnLogIn.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IPCS.Properties.Resources._67ba8ec362b2ca9c9dff7b759a790ad45c6287c5f8017684e8ed10bba71d1b2f;
            this.pictureBox1.Location = new System.Drawing.Point(132, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(253, 2);
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
            this.txtPassword.Location = new System.Drawing.Point(132, 152);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(279, 28);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txUsername
            // 
            this.txUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txUsername.CustomButton.Image = null;
            this.txUsername.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.txUsername.CustomButton.Name = "";
            this.txUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txUsername.CustomButton.TabIndex = 1;
            this.txUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txUsername.CustomButton.UseSelectable = true;
            this.txUsername.CustomButton.Visible = false;
            this.txUsername.DisplayIcon = true;
            this.txUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txUsername.Icon")));
            this.txUsername.Lines = new string[0];
            this.txUsername.Location = new System.Drawing.Point(132, 118);
            this.txUsername.MaxLength = 32767;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.PromptText = "Username";
            this.txUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUsername.SelectedText = "";
            this.txUsername.SelectionLength = 0;
            this.txUsername.SelectionStart = 0;
            this.txUsername.ShortcutsEnabled = true;
            this.txUsername.Size = new System.Drawing.Size(279, 28);
            this.txUsername.TabIndex = 9;
            this.txUsername.UseSelectable = true;
            this.txUsername.WaterMark = "Username";
            this.txUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(545, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.NotificationBox = false;
            this.Resizable = false;
            this.Text = "Sign in";
            this.Controls.SetChildIndex(this.txUsername, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnLogIn, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}