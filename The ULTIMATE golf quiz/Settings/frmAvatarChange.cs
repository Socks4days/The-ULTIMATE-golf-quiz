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
    public partial class frmAvatarChange : Form
    {
        List<Player> players = UserFileHandler.players;
        int currentAvatarIndex = frmSplashScreen.player.avatar;
        public static List<string> avatars = new List<string>();
        private string[] avatarPaths = { "Default1", "Default2", "Tiger Woods", "Rory McIllroy", "Female1", "Female2" };
        
        bool saveButtonClicked = false;
        public frmAvatarChange()
        {
            InitializeComponent();
            UpdateAvatarImage();
        }

        public void UpdateAvatarImage()
        {
            if (currentAvatarIndex >= 0 && currentAvatarIndex < avatarPaths.Length)
            {
                pctBoxAvatar.Image = (Image)Properties.Resources.ResourceManager.GetObject(avatarPaths[currentAvatarIndex]);
            }
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!saveButtonClicked && frmSplashScreen.player.avatar!=currentAvatarIndex)
            {
                saveButtonClicked= true;
                DialogResult result = MessageBox.Show("You have unsaved changes! \n Do you want to save them?", "Confirmation", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    saveButtonClicked = false;
                }
            }
            else
            {
                this.Close();
            }
           
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            currentAvatarIndex = (currentAvatarIndex + 1) % avatarPaths.Length;
            saveButtonClicked = false;
            UpdateAvatarImage();
        }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveButtonClicked = true;
            int avatarNumber = 0;
           /* if (avatarNumber < avatarPaths.Length)
            {
                string imageName = avatarPaths[avatarNumber];
                // Assign a number to the image 
                int imageNumber = avatarNumber + 1;
                avatarNumber++;
            }
            foreach (string avatar in avatarPaths)
            {
                avatarNumber = avatarNumber + 1;
            }*/
            
            switch (currentAvatarIndex)
            {
                case 0:
                    {
                        avatarNumber = 0;
                    }
                    break;
                case 1:
                    {
                        avatarNumber = 1;
                    }
                    break;
                case 2:
                    {
                        avatarNumber = 2;
                    }
                    break;
                case 3:
                    {
                        avatarNumber = 3;
                    }
                    break;
                case 4:
                    {
                        avatarNumber = 4;
                    }
                    break;
                case 5:
                    {
                        avatarNumber = 5;
                    }
                    break;
            }
            foreach (Player player in players)
            {
                if ((player.username == frmSplashScreen.player.username) && (player.avatar == avatarNumber))
                {
                    MessageBox.Show("No changes were made");
                }
                else if (player.username == frmSplashScreen.player.username)
                {
                    MessageBox.Show("Preferences saved!");
                    player.avatar = avatarNumber;
                }
            }
            UserFileHandler.SaveAllPlayers();            
        }

        private void btnAddOwn_Click(object sender, EventArgs e)
        {
            saveButtonClicked = false;
            OpenFileDialog uploadAvatar = new OpenFileDialog();

            // Set the filter to allow only image files
            uploadAvatar.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (uploadAvatar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the picturebox 
                   pctBoxAvatar.Image = new System.Drawing.Bitmap(uploadAvatar.FileName);
                    foreach (string avatar in avatarPaths)
                    {
                        if (Convert.ToString(pctBoxAvatar.Image) != avatar)
                        {
                            List<string> avatars = avatarPaths.ToList();
                            avatars.Add(Convert.ToString(pctBoxAvatar.Image));
                            avatarPaths = avatars.ToArray();
                        }
                        else
                        {
                            MessageBox.Show("That image already exists");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read your file. Error: " + ex.Message);
                }
            }
        }

        
    }
}