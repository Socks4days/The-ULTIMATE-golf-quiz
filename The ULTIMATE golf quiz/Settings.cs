using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public partial class frmSettings : Form
    {
        List<Player> players = SaveClass.players;
        
        public frmSettings()
        {
            InitializeComponent();
        }

        // when clicked the program will be sent to the password change form
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmChangePass().Show();
        }

        // when clicked, the program will be sent to the user information form
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUserInfo().Show();
        }

        // when clicked the program will be sent to the main menu form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainMenu().Show();
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAvatarChange().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This action is permanent! \nDo you wish to continue?", "Delete Account", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (Player player in players)
                {
                    if (player.username == SplashScreen.player.username)
                    {
                        players.Remove(player);
                        SaveClass.SaveAllPlayers();
                        MessageBox.Show("Account Deleted\nReturning to login screen now");
                        this.Hide();
                        new loginfrm().Show();
                        break;
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }            
        }
    }
}