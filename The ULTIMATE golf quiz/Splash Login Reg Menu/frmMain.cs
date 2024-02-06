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
    public partial class frmMain : Form
    {
       // public string formChoice { get; set; } 
        public frmMain()
        {
            InitializeComponent();           
            hideSubMenus();
            setUpAfterLogin();
        }
       /* private void formSelector()
        {
            switch (formChoice)
            {
                case "Splash":
                    
                    openChildForm(new SplashScreen());
                    break;
                case "Login":
                    
                    openChildForm(new frmLogin());
                    break;
                case "Register":
                    
                    openChildForm(new frmReg());
                    break;
                case "Main":
                    
                    break;
                default:
                    
                    break;
            }
                
        }*/
        private void setUpAfterLogin()
        {
            hideSubMenus();
            setTitleLabels();
            setAvatar();
            showMenus();
            if (SplashScreen.player.isAdmin == 0)
            {
                btnAdmin.Visible = false;
            }
        }
        #region submenuToggles 
        private void hideSubMenus()
        {
            pnlSettingsSubMenu.Visible = false;
            pnlAdminSubMenu.Visible = false;
        }
        private void hideMenus()
        {
            pnlSideMenu.Visible = false;
            pnlTitleBar.Visible = false;
        }
        private void showMenus()
        {
            pnlSideMenu.Visible = true;
            pnlTitleBar.Visible = true;
        }



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
        private void setTitleLabels()
        {
            lblCurrentUser.Text = "Current User: " + SplashScreen.player.username + "   ";
            lblHighscore.Text = "Highscore: " + SplashScreen.player.highscore.ToString() + "   ";
            lblGamesPlayed.Text = "Rounds played: " + SplashScreen.player.roundsPlayed.ToString();
        }

        private void setAvatar()
        {
            string[] avatarPaths = { "Default1", "Default2", "Tiger Woods", "Rory McIllroy", "Female1", "Female2" };
            int avatarIndex = SplashScreen.player.avatar;
            pctBoxAvatar.Image = (Image)Properties.Resources.ResourceManager.GetObject(avatarPaths[avatarIndex]);
        }
        #endregion topMenuSetup


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!= null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFormContainer.Controls.Add(childForm);
            pnlFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void closeChildForm()
        {
            if (activeForm != null)
                activeForm.Close();
        }


        #region NavigationButtonClicks

        private void btnGoToQuiz_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            openChildForm(new frmQuizQuestions());
            resetButtonColours();
            btnGoToQuiz.BackColor = Color.FromArgb(0, 75, 0);
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            openChildForm(new frmLeaderboard());
            resetButtonColours();
            btnLeaderboard.BackColor = Color.FromArgb(0, 75, 0);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            closeChildForm();
            toggleSubMenu(pnlSettingsSubMenu);
            resetButtonColours();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserInfo());
            resetButtonColours();
            btnUserInfo.BackColor = Color.FromArgb(0,75,0);
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAvatarChange());
            resetButtonColours();
            btnChangeAvatar.BackColor = Color.FromArgb(0,75,0);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChangePass());
            resetButtonColours();
            btnChangePassword.BackColor = Color.FromArgb(0, 75, 0);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            closeChildForm();
            openChildForm(new frmUserInfo());
            List<Player> players = UserFileHandler.players;
            DialogResult result = MessageBox.Show("This action is permanent! \nDo you wish to continue?", "Delete Account", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (Player player in players)
                {
                    if (player.username == SplashScreen.player.username)
                    {
                        players.Remove(player);
                        UserFileHandler.SaveAllPlayers();
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            closeChildForm();
            toggleSubMenu(pnlAdminSubMenu);           
            resetButtonColours();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewUsers());
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            openChildForm(new frmResetOrDeleteUser("Reset"));
        }

        private void btnDeleteUserAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new frmResetOrDeleteUser("Delete"));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

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
        public void resetButtonColours()
        {
            btnGoToQuiz.BackColor = Color.FromArgb(33,33,33);
            btnLeaderboard.BackColor = Color.FromArgb(33, 33, 33);
            btnUserInfo.BackColor = Color.FromArgb(55, 55, 55);
            btnChangeAvatar.BackColor = Color.FromArgb(55, 55, 55);
            btnChangePassword.BackColor = Color.FromArgb(55, 55, 55);
            btnViewUsers.BackColor = Color.FromArgb(55, 55, 55);
            btnResetPassword.BackColor = Color.FromArgb(55, 55, 55);
            btnLogout.BackColor = Color.FromArgb(33, 33, 33);
        }

        #endregion ButtonColouring


    }
}
