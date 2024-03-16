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
    // Main application form with menu and container panel for child forms
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();           
            setUpAfterLogin();
        }
       
        // Initialise the menu and show the user's avatar
        private void setUpAfterLogin()
        {
            hideSubMenus();
            setTitleLabels();
            setAvatar();
            showMenus();
            if (frmSplashScreen.player.isAdmin == 0)
            {
                btnAdmin.Visible = false;
            }
        }
        
        #region submenuToggles 
        // Hide the settings and admin submenus when a menu option is clicked
        private void hideSubMenus()
        {
            pnlSettingsSubMenu.Visible = false;
            pnlAdminSubMenu.Visible = false;
        }
        
        // Hide the main menu and title bar
        private void hideMenus()
        {
            pnlSideMenu.Visible = false;
            pnlTitleBar.Visible = false;
        }
        
        // Show the main menu and title bar
        private void showMenus()
        {
            pnlSideMenu.Visible = true;
            pnlTitleBar.Visible = true;
        }

        // Show or hide the sub menu when it is clicked
        private void toggleSubMenu(Panel selectedSubMenu)
        {
            if (selectedSubMenu.Visible == true)
            {
                hideSubMenus();
            }
            else
            {
                hideSubMenus(); 
                selectedSubMenu.Visible = true;
            }
        }
        #endregion

        #region topMenuSetup
        // Set the logged in user's details in the title panel
        private void setTitleLabels()
        {
            lblCurrentUser.Text = "Current User: " + frmSplashScreen.player.username + "   ";
            lblHighscore.Text = "Highscore: " + frmSplashScreen.player.highscore.ToString() + "   ";
            lblGamesPlayed.Text = "Rounds played: " + frmSplashScreen.player.roundsPlayed.ToString();
        }

        // Show the user's avatar
        public void setAvatar()
        {
            string[] avatarPaths = { "Default1", "Default2", "Tiger Woods", "Rory McIllroy", "Female1", "Female2" };
            int avatarIndex = frmSplashScreen.player.avatar;
            pctBoxAvatar.Image = (Image)Properties.Resources.ResourceManager.GetObject(avatarPaths[avatarIndex]);
        }
        #endregion topMenuSetup

        // Method to open a child form in the main menu container
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            // If an existing child form is already open, close it
            if (activeForm!= null)
                activeForm.Close();
            
            // Add the new child form in the main menu container 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFormContainer.Controls.Add(childForm);
            pnlFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Close the child form if one is open
        private void closeChildForm()
        {
            if (activeForm != null)
                activeForm.Close();
        }

        #region NavigationButtonClicks
        
        // Load the quiz form
        private void btnGoToQuiz_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            // Reload questions for the current player, removing any already answered
            UserFileHandler.ReadPlayerQuestionAnswered(frmSplashScreen.player);

            // Open the quiz form
            openChildForm(new frmQuizQuestions());
            resetButtonColours();
            btnGoToQuiz.BackColor = Color.FromArgb(0,75,0);
        }

        // Load the leaderboard form
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            openChildForm(new frmLeaderboard());
            resetButtonColours();
            btnLeaderboard.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the settings menu
        private void btnSettings_Click(object sender, EventArgs e)
        {
            closeChildForm();
            toggleSubMenu(pnlSettingsSubMenu);
            resetButtonColours();
        }

        // Open the user info form
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserInfo());
            resetButtonColours();
            btnUserInfo.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the change avatar form
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAvatarChange());
            resetButtonColours();
            btnChangeAvatar.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the change password form
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChangePass());
            resetButtonColours();
            btnChangePassword.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the user info form and show the delete account message
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            closeChildForm();
            resetButtonColours();
            btnDeleteAccount.BackColor = Color.FromArgb(0,75,0);
            openChildForm(new frmUserInfo());
            List<Player> players = UserFileHandler.players;
            DialogResult result = MessageBox.Show("This action is permanent! \nDo you wish to continue?", "Delete Account", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
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
                        this.Hide();
                        new frmLogin().Show();
                        break;
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
        
        // Open the user info form and display the reset account message
        private void btnReset_Click(object sender, EventArgs e)
        {
            closeChildForm();
            resetButtonColours();
            btnReset.BackColor = Color.FromArgb(0,75,0);
            openChildForm(new frmUserInfo());
            List<Player> players = UserFileHandler.players;
            DialogResult result = MessageBox.Show("This action is permanent! Your highscore and questions asked will be reset! \nDo you wish to continue?", "Reset Account", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
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
                        MessageBox.Show("Account reset");                       
                        break;
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        // Open the admin menu
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            closeChildForm();
            toggleSubMenu(pnlAdminSubMenu);           
            resetButtonColours();
        }

        // Open the view users form
        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewUsers());
            resetButtonColours();
            btnViewUsers.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the reset version of the reset or delete form
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            openChildForm(new frmResetOrDeleteUser("Reset"));
            resetButtonColours();
            btnResetPassword.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the delete version of the reset or delete form
        private void btnDeleteUserAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new frmResetOrDeleteUser("Delete"));
            resetButtonColours();
            btnDeleteUserAccount.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the add questions form
        private void btnAddQuestions_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAddQuestions());
            resetButtonColours();
            btnAddQuestions.BackColor = Color.FromArgb(0,75,0);
        }

        // Close the main menu and go back to the login form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        // Quit the application
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
        #endregion NavigationButtonsClicked

        #region ButtonColouring
        // Set all the menu buttons back to the unselected colour
        public void resetButtonColours()
        {
            btnGoToQuiz.BackColor = Color.FromArgb(33,33,33);
            btnLeaderboard.BackColor = Color.FromArgb(33, 33, 33);
            btnUserInfo.BackColor = Color.FromArgb(55, 55, 55);
            btnChangeAvatar.BackColor = Color.FromArgb(55, 55, 55);
            btnChangePassword.BackColor = Color.FromArgb(55, 55, 55);
            btnReset.BackColor = Color.FromArgb(55,55, 55);
            btnDeleteAccount.BackColor = Color.FromArgb(55, 55, 55);
            btnViewUsers.BackColor = Color.FromArgb(55, 55, 55);
            btnResetPassword.BackColor = Color.FromArgb(55, 55, 55);
            btnDeleteUserAccount.BackColor = Color.FromArgb(55,55, 55);
            btnAddQuestions.BackColor = Color.FromArgb(55, 55, 55);
            btnLogout.BackColor = Color.FromArgb(33, 33, 33);
        }
        #endregion ButtonColouring
    }
}
