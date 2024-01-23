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
        public frmMain()
        {
            // thing to do, find out how to get the back button on each form to call the method to reset button colours
            InitializeComponent();
            hideSubMenus();
            setTitleLabels();
            setAvatar();
            if (SplashScreen.player.isAdmin == 0)
            {
                btnAdmin.Visible = false;
            }
        }

        private void hideSubMenus()
        {
            pnlSettingsSubMenu.Visible = false;
            pnlAdminSubMenu.Visible = false;
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnlSettingsSubMenu);
            resetButtonColours();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnlAdminSubMenu);
            resetButtonColours();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!= null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            pnlFormContainer.Controls.Add(childForm);
            pnlFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnGoToQuiz_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuizQuestions());
            resetButtonColours();
            btnGoToQuiz.BackColor = Color.FromArgb(0, 75, 0);
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

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewUsers());
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLeaderboard());
            resetButtonColours();
            btnLeaderboard.BackColor = Color.FromArgb(0,75,0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {                        
            openChildForm(new frmResetUserPassword());
        }

        private void btnDeleteUserAccount_Click(object sender, EventArgs e)
        {
           
            openChildForm(new frmResetUserPassword());
        }
    }
}
