using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    // Settings - Change Password form
    public partial class frmChangePass : Form 
    {
        public frmChangePass()
        {
            InitializeComponent();
            txtBoxConfirmPassword.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
        }
        
        List<Player> players = UserFileHandler.players;

        // Change Password button clicked
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // When the user attempts to change their password
            // First check if the textboxes are empty and if so, show an error to alert the user
            if ((txtBoxOriginalPassword.Text == "") || (txtBoxNewPassword.Text == "") || (txtBoxConfirmPassword.Text == ""))
            {
                ShowError("Please complete all indicated fields");               
            }
            // Then they have entered their old password correctly
            else if (txtBoxOriginalPassword.Text != frmSplashScreen.player.password)
            {
                ShowError("Your original password does not match what you have entered. Please try again.");
                this.ActiveControl = txtBoxOriginalPassword;                
            }
            // Then check if the new password matches their confirmed password
            else if (txtBoxNewPassword.Text != txtBoxConfirmPassword.Text)
            {
                // New password and confirmation don't match
                ShowError("The confirmed password does not match the new password. Please try again.");
                this.ActiveControl = txtBoxConfirmPassword;
            }
            // Now check the new password id valid
            else 
            {
                PasswordValidation();
            }           
        }
        
        // Method that will check if the password is valid
        bool validPassword = false;
        public void PasswordValidation()
        {
            // Sets the password variable equal to what the user has input 
            string password = txtBoxConfirmPassword.Text;

            // Password check 1:
            // - Has more than 7 characters and less than 16
            // - Has a capital letter
            // - Has a number
            if ((password.Length >= 8 ) && (password.Length <= 15)
                && (password.Any(char.IsUpper))
                && (password.Any(char.IsDigit)))
            {            
                // Password check 2:
                // - Contains a special symbol in the following list
                List<char> symbols = new List<char>() { '@', '<', '>', '*', '!', '£', '$', '%', '&', '^', '.', ',', ':', ';', '/', '?', '#' };
         
                // Loop through each special symbol to see if the password contains one of them
                foreach (char sym in symbols)
                {
                    if (password.Contains(sym))
                    {                    
                        // if it does, then send the program to the next stage of Verification and stop
                        validPassword = true;
                        ChangePassword();
                        return;
                    }
                }
            }
            else
            // If any of the password checks fail, display an error to alert the user
            ShowError("Your new password must be between 8-15 characters, with at least\n1 number, 1 capital letter and 1 symbol");
        }

        // Method to set the new password
        public void ChangePassword()
        {                        
            // Set the the players password equal to what they input
            frmSplashScreen.player.password = txtBoxConfirmPassword.Text;           
            
            // Save the players password
            UserFileHandler.SaveAllPlayers();

            // Let the user know that their password was valid and it was set successfully
            ShowError("Password changed successfully!");           
        }

        // When the back arrow button is clicked, return to the main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // If the show password checkbox is ticked for the original password,
        // then show the user what they have input
        // otherwise show password as '*'
        private void cboxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPassword.Checked)
            {
                txtBoxOriginalPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxOriginalPassword.PasswordChar = '*';
            }
        }
        
        // If the show password checkbox is ticked for the new password,
        // then show the user what they have input
        // otherwise show password as '*'
        private void cBoxNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxNewPassword.Checked)
            {
                txtBoxNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxNewPassword.PasswordChar = '*';
            }
        }
        private void cBoxConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxConfirmPassword.Checked)
            {
                txtBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxConfirmPassword.PasswordChar = '*';
            }
        }

        // Key pressed event - check if Enter key hit
        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // When the enter key is hit it will attempt to run the Verification method
                    // to find out if a valid user is trying to log in
                    btnChangePass_Click(sender,e);
                    break;
                default:
                    break;
            }
        }
        private void ShowError(string message)
        {
            if (txtBoxOriginalPassword.Text == "") lblErrorOld.Visible = true;
            if (txtBoxNewPassword.Text == "") lblErrorNew.Visible = true;
            if (txtBoxConfirmPassword.Text == "") lblErrorConfirm.Visible = true;
            lblError.Text = message;
            lblError.Visible = true;
        }

        public void ClearError()
        {
            lblErrorOld.Visible = false;
            lblErrorNew.Visible = false;
            lblErrorConfirm.Visible = false;
            lblError.Visible = false;
        }

        private void txtBoxOriginalPassword_TextChanged(object sender, EventArgs e)
        {
            lblErrorOld.Visible = false;
        }

        private void txtBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            lblErrorNew.Visible = false;
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            lblErrorConfirm.Visible = false;
        }
    }
}
