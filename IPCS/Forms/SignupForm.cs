using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;

namespace IPCS.Forms
{
    public partial class SignupForm : CustomForm
    {
        public SignupForm()
        {
            InitializeComponent();
            NotifText = "Server Ready";
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length <= 0 || txtPassword.Text.Length <= 0 || txtConfirmPassword.Text.Length <= 0|| txtRecoveryKey.Text.Length <=0)
            {
                NotifText = "Please fill up all field";
                return;
            }
            if (txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                NotifText = "Creating Account...";
                if (!Program.Signup(txtUsername.Text, txtPassword.Text, txtRecoveryKey.Text, profilePicture.Image))
                {
                    NotifText = "Account alreadu exist";
                    return;
                }
                NotifText = "Username " + txtUsername.Text + " is ready";
                MetroMessageBox.Show(this, "You successfully created your account!", "Create Account", MessageBoxButtons.OK, 150);
                Dispose();
            }
            else
            {
                NotifText = "Password Mismatch";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BrowsePic_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                profilePicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
