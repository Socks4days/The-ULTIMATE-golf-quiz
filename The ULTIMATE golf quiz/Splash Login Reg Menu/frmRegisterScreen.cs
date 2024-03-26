using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_ULTIMATE_golf_quiz
{
    // Register a new user
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        List<Player> players = UserFileHandler.players;
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            int age;

            // Hide any previously shown error message
            ClearError();

            // when register button is clicked, check to see if any of the textboxes have been left empty
            // if so, throw an error message addressing this
            if ((txtBoxUser.Text == "") || (txtBoxPassword.Text == "") || (txtBoxName.Text == "")
                    || (txtBoxAge.Text == "") || (txtBoxGender.Text == "") || (txtBoxNation.Text == ""))
            {
                ShowError("Please complete all indicated fields");
            }
            if ((txtBoxUser.Text.Contains(',')) || (txtBoxPassword.Text.Contains(',')) || (txtBoxName.Text.Contains(','))
                    || (txtBoxAge.Text.Contains(',')) || (txtBoxGender.Text.Contains(',')) || (txtBoxNation.Text.Contains(',')))
            {
                ShowError("All fields, including passwords, cannot contain any commas\nPlease remove any commas and try again...");
                return;
             }
            else if (!int.TryParse(txtBoxAge.Text, out age) || (Convert.ToInt32(txtBoxAge.Text)<0))
            {
                ShowError("Please enter a valid age in years");
                this.ActiveControl = txtBoxAge;
                return;
            }
            else
            {
                // if all are filled in, then begin the verification process
                PasswordValidation();
            }
        }       

        bool validPassword = false;        
        public void PasswordValidation()
        {
            // setting variable equal to what the user inputs for password
            string password = txtBoxPassword.Text;

            // checks to see if the input password passes all the checks: More than 8 chatacters, contain a capital, contain a number
            if ((password.Length >= 8)&&(password.Length <= 15) 
                && (password.Any(char.IsUpper)) && (password.Any(char.IsDigit)))
            {
                // if it passes, bool is set equal to true and program can continue
                validPassword = true;
            }
            else 
            {
                // if it fails, a list of the password requirements are shown
                ShowError("Enter a password between 8-15 characters, with at least\n1 number, 1 capital letter and 1 symbol");
            }

            // Creates a list of valid password symbols and populates it
            List<char> symbols = new List<char>() 
                { '@', '<', '>', '*', '!', '£', '$', '%', '&', '^', '.',':', ';', '/', '?', '#'};
            
            // checks to see if the input password contains one of these symbols 
            foreach( char sym in symbols)
            {
                if((password.Contains(sym)))
                {                    
                    // if it does, then the program runs the register method which will register the user as a valid user
                    Register();
                }                
                else
                {
                    ShowError("Enter a password between 8-15 characters, with at least\n1 number, 1 capital letter and 1 symbol");
                }
            }
        }
        
        // method that registers the user as a valid user
        public Player Register()
        {
            // sets all the input information equal to their corresponding variable
            string username = txtBoxUser.Text;
            string password = txtBoxPassword.Text;
            string name = txtBoxName.Text;
            string gender = txtBoxGender.Text;
            int age = Convert.ToInt32(txtBoxAge.Text);            
            string nationality = txtBoxNation.Text;
            int highscore = 0;
            int isAdmin = 0;
            
            // checks to see if the admin checkbox is ticked and if so, the admin box will contain a 1 and if not, a 0
            if ((cboxAdmin.Checked)&&(txtBoxPassword.Text=="Admin123!"))
            {
                isAdmin = 1;
            }
            else if ((cboxAdmin.Checked)&&(txtBoxPassword.Text!="Admin123!"))
            {
                ShowError("Invalid admin password.\n Please try again...");
            }
            else { isAdmin = 0; }
            int avatar = 0;
            if (gender.ToLower() == "female")
            {
               avatar = 1;
            }
                       
            int roundsPlayed = 0;
            
            // Check if the username is already taken
            bool validUsername = true;
            foreach(Player player in players)
            {
                if (player.username == username)
                {
                    // if someone already has already got the same username, then an error message is thrown saying they have to change it
                    validUsername = false;
                    ShowError("Sorry, that username is already taken.\nPlease try a different one...");
                    //sets mouse to go to the username textbox
                    this.ActiveControl=txtBoxUser;
                }
            }
            // if both the username and password are valid, the program can continue to register the user
            if (validPassword == true && validUsername == true)
            {
                // Set new user as the logged in user
                frmSplashScreen.player = new Player(username, password, name, age, gender, nationality, highscore, isAdmin, avatar, roundsPlayed);

                // Add new user to the list of valid users
                players.Add(frmSplashScreen.player);

                // Save the list of users back to the CSV file
                UserFileHandler.SaveAllPlayers();
                QuestionFileHandler.ReadInAllQuestions();

                // Go to the main menu
                this.Hide();
                // Open the main menu and save a reference to it
                frmSplashScreen.mainMenu = new frmMain();
                frmSplashScreen.mainMenu.Show();
            }
            // returns the new player values
            return new Player(username, password, name, age, gender, nationality, highscore, isAdmin, avatar, roundsPlayed);
        }
               
        private void btnReset_Click(object sender, EventArgs e)
        {
            // when button is clicked, run the reset method
            Reset();
        }
        public void Reset()
        {
            // When pressed, all textboxes will be cleared
            // and any previously shown error message hidden
            ClearError();
            txtBoxUser.Clear();
            txtBoxPassword.Clear();
            txtBoxName.Clear();
            txtBoxAge.Clear();
            txtBoxGender.Clear();
            txtBoxNation.Clear();
            // Mouse is returned to the first textbox
            this.ActiveControl = txtBoxUser;
        }

        private void ShowError(string errorMessage)
        {
            // shows an error indicating which boxes need to be filled in to be valid
            if (txtBoxUser.Text == "") lblErrorU.Visible = true;
            if (txtBoxPassword.Text == "") lblErrorP.Visible = true;
            if (txtBoxName.Text == "") lblErrorNam.Visible = true;
            if (txtBoxAge.Text == "") lblErrorA.Visible = true;
            if (txtBoxGender.Text == "") lblErrorG.Visible = true;
            if (txtBoxNation.Text == "") lblErrorNat.Visible = true;
            lblError.Text = errorMessage;
            lblError.Visible = true;
        }

        private void ClearError()
        {
            // hide error message
            lblErrorU.Visible = false;
            lblErrorP.Visible = false;
            lblErrorNam.Visible = false;
            lblErrorA.Visible = false;
            lblErrorG.Visible = false;
            lblErrorNat.Visible = false;
            lblError.Text = "";
            lblError.Visible = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            // when back arrow clicked, the program will be directed back to the login screen
            this.Hide();
            new frmLogin().Show();
        }

        private void frmReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if the window is closed, the program will also close
            System.Windows.Forms.Application.Exit();
        }

    }
}
