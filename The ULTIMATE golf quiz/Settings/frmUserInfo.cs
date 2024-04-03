using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace The_ULTIMATE_golf_quiz
{
    // Settings - User Info form 
    public partial class frmUserInfo : Form
    {
        // Initialise the form and set the submit button based on the mode
        public frmUserInfo(string mode)
        {
            InitializeComponent();
            btnSubmit.Text = mode;  
        }
        
        // Sets the user who's details are displayed equal to the user that is logged in
        Player player = frmSplashScreen.player;
        List<Player> players = UserFileHandler.players;
        bool unsavedChange = false;
        int timesDetailsChanged = 0;
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            PopulateUserInfo();
        }
        
        // Set user info labels with player's details
        private void PopulateUserInfo()
        {
            // When the form is loaded, the textboxes are populated with all the relevant information
            lblUserText.Text = player.username;
            lblNameText.Text = player.name;
            lblAgeText.Text = Convert.ToString(player.age);
            lblGenderText.Text = player.gender;
            lblNationText.Text = player.nationality;
        }

        // Back arrow clicked
        private void btnReturn_Click(object sender, EventArgs e)
        {
            // When the back arrow is clicked, close the form 
            this.Close();
        }

        // Submit button clicked on form (Edit / Delete / Reset)
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Depending on form selected - Edit, Delete or Reset user
            switch (btnSubmit.Text)
            {
                // Edit button clicked
                case "Edit":
                    pnlInfo.Visible = false;
                    pnlEdit.Visible = true;
                    txtBoxUsername.Text = frmSplashScreen.player.username;
                    txtBoxName.Text = frmSplashScreen.player.name;
                    txtBoxAge.Text = Convert.ToString(frmSplashScreen.player.age);
                    txtBoxGender.Text = frmSplashScreen.player.gender;
                    txtBoxNationality.Text = frmSplashScreen.player.nationality;
                    timesDetailsChanged = 0;
                    unsavedChange = false;
                    btnSave.Enabled = false;
                    break;

                // Delete button clicked
                case "Delete":
                    
                    DialogResult deleteResult = MessageBox.Show("This action is permanent! \nDo you wish to continue?", "Delete Account", MessageBoxButtons.YesNo);

                    if (deleteResult == DialogResult.Yes)
                    {
                        // Delete the account from the player list and then update the players file
                        foreach (Player player in players)
                        {
                            if (player.username == frmSplashScreen.player.username)
                            {
                                players.Remove(player);
                                UserFileHandler.SaveAllPlayers();
                                UserFileHandler.DeletePlayerQuestionFile(player);
                                MessageBox.Show("Account Deleted\nReturning to login screen now");
                                // When the account is deleted, the program returns to the login screen
                                frmMain.ActiveForm.Hide();
                                new frmLogin().Show();
                                break;
                            }
                        }
                    }
                    else if (deleteResult == DialogResult.No)
                    {
                        return;
                    }
                    break;

                // Reset button clicked
                case "Reset":
                    DialogResult resetResult = MessageBox.Show("This action is permanent! Your highscore and questions asked will be reset! \nDo you wish to continue?", "Reset Account", MessageBoxButtons.YesNo);

                    if (resetResult == DialogResult.Yes)
                    {
                        // Reset the player's details and then update the players file
                        foreach (Player player in players)
                        {
                            if (player.username == frmSplashScreen.player.username)
                            {
                                player.highscore = 0;
                                UserFileHandler.ClearPlayerQuestionAnswered(player);
                                UserFileHandler.SaveAllPlayers();
                                QuestionFileHandler.ReadInAllQuestions();
                                frmSplashScreen.mainMenu.SetTitleLabels();
                                MessageBox.Show("Account reset");
                                break;
                            }
                        }
                    }
                    else if (resetResult == DialogResult.No)
                    {
                        return;
                    }
                    break;
            }
        }

        // Save button clicked on Edit user info form
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check all fields filled in
            int age;
            if ((txtBoxUsername.Text == "") || (txtBoxName.Text == "")
                    || (txtBoxAge.Text == "") || (txtBoxGender.Text == "") || (txtBoxNationality.Text == ""))
            {
                ShowError("Please complete all indicated fields");
                return;
            }
            // Check text boxes don't have any commas
            else if ((txtBoxUsername.Text.Contains(',')) || (txtBoxName.Text.Contains(','))
                    || (txtBoxAge.Text.Contains(',')) || (txtBoxGender.Text.Contains(',')) || (txtBoxNationality.Text.Contains(',')))
            {
                ShowError("All fields cannot contain any commas\nPlease remove any commas and try again...");
                return;
            }
            // Check age entered as a number
            else if (!int.TryParse(txtBoxAge.Text, out age) || (Convert.ToInt32(txtBoxAge.Text) < 0))
            {
                ShowError("Please enter a valid age in years");
                this.ActiveControl = txtBoxAge;
                return;
            }
            // If the player has changed their username, check the new name isn't the same as someone else's
            else if (txtBoxUsername.Text != frmSplashScreen.player.username)
            {
                foreach (Player player in players)
                {
                    if (player.username == txtBoxUsername.Text)
                    {
                        // if someone already has already got the same username, then an error message is thrown saying they have to change it
                        ShowError("Sorry, that username is already taken.\nPlease try a different one...");
                        //sets mouse to go to the username textbox
                        this.ActiveControl = txtBoxUsername;
                        return;
                    }
                }
            }

            // All checks passed
            // Update the player's details and save to the CSV file
            frmSplashScreen.player.username = txtBoxUsername.Text;
            frmSplashScreen.player.name = txtBoxName.Text;
            frmSplashScreen.player.age = Convert.ToInt32(txtBoxAge.Text);
            frmSplashScreen.player.gender = txtBoxGender.Text;
            frmSplashScreen.player.nationality = txtBoxNationality.Text;
            UserFileHandler.SaveAllPlayers();

            // Update the user info and main menu title and go back to user info
            unsavedChange = false;
            ClearError();
            MessageBox.Show("All changes saved!");
            PopulateUserInfo();
            frmSplashScreen.mainMenu.SetTitleLabels();
            pnlEdit.Visible = false;
            pnlInfo.Visible = true;
        }        

        // Back arrow clicked on Edit screen
        private void btnEditReturn_Click(object sender, EventArgs e)
        {
            if(unsavedChange == true)
            {
                // There are unsaved changes - check if user is happy to discard them
                DialogResult discardResult = MessageBox.Show("Are you sure you want to leave? You have unsaved changes.", "Discard Changes?", MessageBoxButtons.YesNo);
                if (discardResult == DialogResult.Yes)
                {
                    pnlEdit.Visible = false;
                    pnlInfo.Visible = true;
                }
            }
            else
            {
                // No unsaved changes, go back to the View screen
                pnlEdit.Visible = false;
                pnlInfo.Visible = true;
            }
        }

        // If the text is changed in any of the text boxes, set unsaved changes flag
        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ChangeMade();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            ChangeMade();
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            ChangeMade();
        }

        private void txtBoxGender_TextChanged(object sender, EventArgs e)
        {
            ChangeMade();
        }

        private void txtBoxNationality_TextChanged(object sender, EventArgs e)
        {
            ChangeMade();
        }
        
        private void ChangeMade()
        {
            unsavedChange = true;
            btnSave.Enabled = true;
        }
        
        // Mark any blank fields and show error message
        public void ShowError(string errorMessage)
        {
            // shows an error indicating which boxes need to be filled in to be valid
            if (txtBoxUsername.Text == "") lblErrorU.Visible = true;
            if (txtBoxName.Text == "") lblErrorNam.Visible = true;
            if (txtBoxAge.Text == "") lblErrorA.Visible = true;
            if (txtBoxGender.Text == "") lblErrorG.Visible = true;
            if (txtBoxNationality.Text == "") lblErrorNat.Visible = true;
            lblError.Text = errorMessage;
            lblError.Visible = true;
        }
        
        // Clear and hide error message
        private void ClearError()
        {
            // hide error message
            lblErrorU.Visible = false;
            lblErrorNam.Visible = false;
            lblErrorA.Visible = false;
            lblErrorG.Visible = false;
            lblErrorNat.Visible = false;
            lblError.Text = "";
            lblError.Visible = false;
        }
    }
}
