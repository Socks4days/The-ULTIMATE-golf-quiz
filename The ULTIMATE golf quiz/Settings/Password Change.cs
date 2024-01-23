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
    public partial class frmChangePass : Form 
    {
       
        public frmChangePass()
        {
            InitializeComponent();
            //txtBoxOriginalPass.
        }
        List<Player> players = UserFileHandler.players;

        private void btnChangePass_Click(object sender, EventArgs e)
        {
           
            // when the user attempts to change their password the program first checks if the textbox is empty and if so, throws an error, alerting the user
            if (txtBoxConfirm2.Text == "")
            {
                Error();
            }
            else if (txtBoxOriginalPass.Text != SplashScreen.player.password)
            {
                MessageBox.Show("Password does not match original password\nPlease try again...");
                this.ActiveControl = txtBoxOriginalPass;
                return;
            }
            else
            {
                // if it isn't then it will continue to check if it is a valid password
                PasswordValidation();
            }
        }
        bool validPassword = false;
        // method that will check if the password is valid
        public void PasswordValidation()
        {
            // sets the variable equal to what the user has input 
            string password = txtBoxConfirm2.Text;

            // Password check: has more than 7 characters, has a capital letter and has a number
            if ((password.Length >= 8 ) && (password.Length <= 15) && (password.Any(char.IsUpper)) && (password.Any(char.IsDigit)))
            {
                // if it passes then the bool is set to true
              validPassword = true;
            }
            else
            {
                // if it does not pass then an error is thrown and the user is alerted
                lblError.Visible = true;
            }

            // list of valid symbols that the password must contain
            List<char> symbols = new List<char>() { '@', '<', '>', '*', '!', '£', '$', '%', '&', '^', '.', ',', ':', ';', '/', '?', '#' };
                      
            foreach (char sym in symbols)
            {
                // loop to see if the password contains a valid symbol
                if (password.Contains(sym))
                {                    
                   // if it does, then send the program to the next stage of verification
                    Verify();
                }
            }
        }
        // method to set the new password
        public void Verify()
        {            
            if (validPassword == true)
            {
                if (txtBoxConfirm1.Text == txtBoxConfirm2.Text)
                {

                }                
                // set the the players password equal to what they input
                SplashScreen.player.password = txtBoxConfirm2.Text;

                // loop through each player to find the right player to set new password
                foreach (Player player in players)
                {
                    // when the right player is found then set the password equal to what they input
                    if (player.username == SplashScreen.player.username)
                    {
                        player.password = txtBoxConfirm2.Text;
                    }
                }
                UserFileHandler.SaveAllPlayers();
                // when done, send them back to the main menu
                frmMainMenu mainMenu = new frmMainMenu();
                this.Hide();
                mainMenu.Show();
                // let the user know that their password was valid and it was set successfully
                MessageBox.Show("Password changed successfully!");
            }         
        }

        // method that sends an error if the user does not enter anything
        private void Error()
        {
            MessageBox.Show("No password was entered: Please try again.");
            lblError0.Visible = true;
        }

        // when the button is clicked, the program will return to the settings form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // if the check box is ticked, then the user will be able to see what they have input, otherwise they will only see '*'
        private void cboxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPass.Checked)
            {
                txtBoxOriginalPass.PasswordChar = '\0';
            }
            else
            {
                txtBoxOriginalPass.PasswordChar = '*';
            }
        }
        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // when the enter key is hit it will attemp to run the verification method to find out if a valid user is trying to log in
                    btnChangePass_Click(sender,e);
                    break;
                default:

                    break;

            }
        }

        
    }
}
