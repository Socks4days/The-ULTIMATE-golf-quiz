using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace The_ULTIMATE_golf_quiz
{
    // Settings - Change Avatar
    public partial class frmAvatarChange : Form
    {
        // Variables for list of players, user's current avatar and list of available avatars
        List<Player> players = UserFileHandler.players;
        int currentAvatarIndex = frmSplashScreen.player.avatar;
        public static List<string> avatars = new List<string>();
        private string[] avatarPaths = { "Default1", "Default2", "Tiger Woods", "Rory McIllroy", "Female1", "Female2" };

        // Initialise form and display current avatar
        bool saveButtonClicked = false;
        public frmAvatarChange()
        {
            InitializeComponent();
            UpdateAvatarImage();
        }

        // Method to show the selected avatar from the list
        public void UpdateAvatarImage()
        {
            if (currentAvatarIndex >= 0 && currentAvatarIndex < avatarPaths.Length)
            {
                pctBoxAvatar.Image = (Image)Properties.Resources.ResourceManager.GetObject(avatarPaths[currentAvatarIndex]);
            }
        }

        // When back arrow button clicked before saving,
        // warn user then exit if they choose to continue
        private void btnReturn_Click(object sender, EventArgs e)
        {
            // If the selected avatar is different to the saved one, warn the user
            if (!saveButtonClicked && frmSplashScreen.player.avatar != currentAvatarIndex)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes! \n Do you want to save them?", "Confirmation", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Save change
                    btnSave_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    // Discard changes
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    // Cancel
                    saveButtonClicked = false;
                }
            }
            else
            {
                // If they haven't changed the avator
                // or they saved it, just exit
                this.Close();
            }
        }

        // Right button clicked - go to next avatar
        private void btnRight_Click(object sender, EventArgs e)
        {
            currentAvatarIndex = (currentAvatarIndex + 1) % avatarPaths.Length;
            saveButtonClicked = false;
            UpdateAvatarImage();
        }

        // Left button clicked - go to previous avatar
        private void btnLeft_Click(object sender, EventArgs e)
        {
            saveButtonClicked = false;
            if (currentAvatarIndex < 1)
            {
                currentAvatarIndex = avatarPaths.Length - 1;
            }
            else
            {
                currentAvatarIndex = (currentAvatarIndex - 1) % avatarPaths.Length;
            }           
            UpdateAvatarImage();
        }

        // Save button clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Remember save button has been clicked
            saveButtonClicked = true;

            // Get player's current avatar and save it if it has changed
            foreach (Player player in players)
            {
                if ((player.username == frmSplashScreen.player.username) && (player.avatar == currentAvatarIndex))
                {
                    MessageBox.Show("No changes were made");
                }
                else if (player.username == frmSplashScreen.player.username)
                {
                    // Save the player's new avatar
                    player.avatar = currentAvatarIndex;
                    UserFileHandler.SaveAllPlayers();
                    frmSplashScreen.mainMenu.setAvatar();
                    MessageBox.Show("Preferences saved!");                    
                }
            }
        }
    }
}