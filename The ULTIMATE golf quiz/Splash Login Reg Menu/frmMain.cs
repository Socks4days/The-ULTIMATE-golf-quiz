using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_ULTIMATE_golf_quiz.File_Handling;

namespace The_ULTIMATE_golf_quiz
{
    // Main application form with menu and container panel for child forms
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();           
            SetUpAfterLogin();
            SoundFileHandler.PlaySoundLooping(SoundFileHandler.backgroundMusic);
        }

        // Initialise the menu and show the user's avatar
        private void SetUpAfterLogin()
        {
            hideSubMenus();
            SetTitleLabels();
            SetAvatar();
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
        public void SetTitleLabels()
        {
            lblCurrentUser.Text = "User: " + frmSplashScreen.player.username + "   ";
            lblHighscore.Text = "Highscore: " + frmSplashScreen.player.highscore.ToString() + "   ";
            lblGamesPlayed.Text = "Rounds played: " + frmSplashScreen.player.roundsPlayed.ToString();
        }

        // Show the user's avatar
        public void SetAvatar()
        {
            string[] avatarPaths = { "Default1", "Default2", "Tiger Woods", "Rory McIllroy", "Female1", "Female2" };
            int avatarIndex = frmSplashScreen.player.avatar;
            pctBoxAvatar.Image = (Image)Properties.Resources.ResourceManager.GetObject(avatarPaths[avatarIndex]);
        }
        #endregion topMenuSetup

        // Method to open a child form in the main menu container
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
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
            childForm.BringToFront();
            childForm.Show();
        }

        // Close the child form if one is open
        private void CloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();

                // If the background music isn't already playing it will start playing
                SoundFileHandler.PlaySoundLooping(SoundFileHandler.backgroundMusic);
            }
        }

        #region NavigationButtonClicks
        
        // Load the quiz form
        private void btnGoToQuiz_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            // Reload questions for the current player, removing any already answered
            UserFileHandler.ReadPlayerQuestionAnswered(frmSplashScreen.player);

            // Open the quiz form
            OpenChildForm(new frmQuizQuestions());
            ResetButtonColours();
            btnGoToQuiz.BackColor = Color.FromArgb(0,75,0);
        }

        // Load the leaderboard form
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            OpenChildForm(new frmLeaderboard());
            ResetButtonColours();
            btnLeaderboard.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the settings menu
        private void btnSettings_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            toggleSubMenu(pnlSettingsSubMenu);
            ResetButtonColours();
        }

        // Open the user info form
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUserInfo("Edit"));
            ResetButtonColours();
            btnUserInfo.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the change avatar form
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAvatarChange());
            ResetButtonColours();
            btnChangeAvatar.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the change password form
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChangePass());
            ResetButtonColours();
            btnChangePassword.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the user info form and show the delete account message
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            ResetButtonColours();
            btnDeleteAccount.BackColor = Color.FromArgb(0,75,0);
            OpenChildForm(new frmUserInfo("Delete"));            
        }
        
        // Open the user info form and display the reset account message
        private void btnReset_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            ResetButtonColours();
            btnReset.BackColor = Color.FromArgb(0,75,0);
            OpenChildForm(new frmUserInfo("Reset"));
            
        }

        // Open the admin menu
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            toggleSubMenu(pnlAdminSubMenu);           
            ResetButtonColours();
        }

        // Open the view users form
        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewUsers());
            ResetButtonColours();
            btnViewUsers.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the reset version of the reset or delete form
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmResetOrDeleteUser("Reset"));
            ResetButtonColours();
            btnResetPassword.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the delete version of the reset or delete form
        private void btnDeleteUserAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmResetOrDeleteUser("Delete"));
            ResetButtonColours();
            btnDeleteUserAccount.BackColor = Color.FromArgb(0,75,0);
        }

        // Open the add questions form
        private void btnAddQuestions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddQuestions());
            ResetButtonColours();
            btnAddQuestions.BackColor = Color.FromArgb(0,75,0);
        }

        // Close the main menu and go back to the login form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            SoundFileHandler.StopSound();
            this.Close();
            new frmLogin().Show();
        }

        // Quit the application
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SoundFileHandler.StopSound();
                System.Windows.Forms.Application.Exit();
            }
        }
        #endregion NavigationButtonsClicked

        #region ButtonColouring
        // Set all the menu buttons back to the unselected colour
        public void ResetButtonColours()
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

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoundFileHandler.StopSound();
            System.Windows.Forms.Application.Exit();
        }
    }
}
