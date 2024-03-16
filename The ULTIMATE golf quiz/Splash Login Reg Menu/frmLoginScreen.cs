using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace The_ULTIMATE_golf_quiz
{
	// Allows the user to log in or go to the Registration screen if they are a new user
    public partial class frmLogin : Form
    {
        private List<Player> players = UserFileHandler.players;
        
        public frmLogin()
        {
            InitializeComponent();
            // Code to be able to hit enter to do same thing as submit when in the password textbox
            passwordtxtbox.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
        }

        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    // when the enter key is hit it will attemp to run the verification method to find out if a valid user is trying to log in
                    verification();
                    break;
                default:
                    break;
            }
        }       

        public void verification()
        {            
           // setting variables that user has input to be processed
            string inputUsername = usernametxtbox.Text;
            string inputPassword = passwordtxtbox.Text;

            // Check for user in list of players
            frmSplashScreen.player = new Player();
            bool foundUser = false;
            foreach (Player player in players)
            {
                if ((inputUsername == player.username) && (inputPassword == player.password))
                {
                    // Found user
                    frmSplashScreen.player = player;
                    foundUser = true;
                }
            }

            if (foundUser)
            {
                this.Hide();
                // Open the main menu and save a reference to it
                frmSplashScreen.mainMenu = new frmMain();
                frmSplashScreen.mainMenu.Show();
            } 
            else 
            {
                MessageBox.Show("Error, please try again...");
                passwordtxtbox.Text = "";
            }            
        }       

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            // when submit button is pressed, program will find out if the credentials are valid or not
            verification();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            // Opens the register screen when pressed
            this.Hide();
            // new frmMain().formChoice = "Register";
            new frmRegisterUser().Show();
        }
                
        private void loginfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // exits the program if window is closed
            System.Windows.Forms.Application.Exit();
        }

        private void cboxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPassword.Checked)
            {
                // when the check box is ticked, the user will be able to see what they have input
                passwordtxtbox.PasswordChar = '\0';
            }
            else
            {
                // when the check box is unticked, the user will only be able to see * so the password is hidden
                passwordtxtbox.PasswordChar = '*';
            }
        }
    }
}