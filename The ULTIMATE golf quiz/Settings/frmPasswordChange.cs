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
            txtBoxConfirm.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
        }
        
        List<Player> players = UserFileHandler.players;

        // Change Password button clicked
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // When the user attempts to change their password
            // First check if the textbox is empty and if so, show an error to alert the user
            if (txtBoxConfirm.Text == "")
            {
                MessageBox.Show("No password was entered: Please try again.");
                lblError0.Visible = true;
            }
            // Then they have entered their old password correctly
            else if (txtBoxOriginalPassword.Text != frmSplashScreen.player.password)
            {
                MessageBox.Show("Password does not match original password\nPlease try again...");
                this.ActiveControl = txtBoxOriginalPassword;
                return;
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
            string password = txtBoxConfirm.Text;

            // Password check 1:
            // - Has more than 7 characters and less than 16
            // - Has a capital letter
            // - Has a number
            if ((password.Length >= 8 ) && (password.Length <= 15)
                && (password.Any(char.IsUpper))
                && (password.Any(char.IsDigit)))
            {
                // Password check 2:
                // - New password and confirmation must match
                if (txtBoxNewPassword.Text != txtBoxConfirm.Text)
                {
                    // New password and confirmation don't match
                    MessageBox.Show("The new password and confirmation password don't match: Please try again.");
                }
                else
                {
                    // Password check 3:
                    // - Contains a special symbol in the following list
                    List<char> symbols = new List<char>() { '@', '<', '>', '*', '!', '£', '$', '%', '&', '^', '.', ',', ':', ';', '/', '?', '#' };
         
                    // Loop through each special symbol to see if the password contains one of them
                    foreach (char sym in symbols)
                    {
                        if (password.Contains(sym))
                        {                    
                            // if it does, then send the program to the next stage of verification and stop
                            validPassword = true;
                            ChangePassword();
                            return;
                        }
                    }
                }
            }
            
            // If any of the password checks fail, display an error to alert the user
            lblError.Visible = true;
        }

        // Method to set the new password
        public void ChangePassword()
        {                        
            // Set the the players password equal to what they input
            frmSplashScreen.player.password = txtBoxConfirm.Text;

            // Loop through each player to find the right player to set new password
            foreach (Player player in players)
            {
                // When the right player is found then set the password equal to what they input
                if (player.username == frmSplashScreen.player.username)
                {
                    player.password = txtBoxConfirm.Text;
                }
            }
            
            // Save the players password
            UserFileHandler.SaveAllPlayers();

            // Let the user know that their password was valid and it was set successfully
            MessageBox.Show("Password changed successfully!");
            
            // When done, send them back to the main menu
            this.Close();
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
        
        // Key pressed event - check if Enter key hit
        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // When the enter key is hit it will attempt to run the verification method
                    // to find out if a valid user is trying to log in
                    btnChangePass_Click(sender,e);
                    break;
                default:
                    break;
            }
        }
    }
}
