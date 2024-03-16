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
    // Admin - Reset or Delete form
    // Uses parameter to show form as Reset or Delete
    public partial class frmResetOrDeleteUser : Form
    {
        public frmResetOrDeleteUser(string mode)
        {
            InitializeComponent();

            // Add all players into the list view
            List<Player> playerList = UserFileHandler.players;
            foreach (Player player in playerList)
            {
                string playerName = player.username;
                listViewPlayers.Items.Add(playerName);
            }
            
            if (mode == "Delete")
            {
                // Display delete options
                DeleteAccount();
            }
            else if (mode == "Reset")
            {
                // Display reset options
                Reset();
            }
        }
        
        // Display delete options        
        public void DeleteAccount()
        {
            lblAdvice.Text = "To delete one or more users, select the users from the list and then hit 'Delete'\r\n";
            btnReset.Visible = false;
        }
        
        // Display reset options
        public void Reset()
        {
            lblAdvice.Text = "To reset one or more users passwords, select the users from the list and then hit 'Reset'\r\nTheir password will be reset to Password1!\r\n";
            btnDelete.Visible = false;
        }

        // When back arrow clicked, close form and go back to the main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Reset button clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (GetSelectedPlayers() == 0)
            {
                MessageBox.Show("First select one or more players to reset password");
            }
            else
            {
                foreach (string playerToResetPassword in playersToEdit)
                {
                    foreach (Player player in UserFileHandler.players)
                    {
                        if (playerToResetPassword.ToString() == player.username)
                        {
                            player.password = "Password1!";
                            MessageBox.Show(player.username + "'s password has been reset!");
                        }
                    }
                }
                // Save players with reset passwords to CSV file
                UserFileHandler.SaveAllPlayers();
            }
        }

        // Delete button clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GetSelectedPlayers() == 0)
            {
                MessageBox.Show("First select one or more players to delete");
            }
            else
            {
                List<Player> players = UserFileHandler.players;
                DialogResult result = MessageBox.Show("This action is permanent! \nDo you wish to continue?", "Delete Account", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove selected players from player list
                    foreach (string playerToDelete in playersToEdit)
                    {
                        try 
                        {
                            foreach (Player player in players)
                            {
                                if (playerToDelete.ToString() == player.username)
                                {
                                    players.Remove(player);
                                    MessageBox.Show(player.username + " has been deleted");
                                }
                            }
                        }
                        catch(Exception) { }
                    }
                    // Save remaining list of players to CSV file
                    UserFileHandler.SaveAllPlayers();
                }
            }
        }

        // Method to get list of selected players
        List<string> playersToEdit = new List<string>();
        private int GetSelectedPlayers()
        {
            int numberOfPlayersSelected = 0;
            foreach(ListViewItem listViewItem in listViewPlayers.Items)
            {
                if (listViewItem != null)
                {
                    if (listViewItem.Checked)
                    {
                        playersToEdit.Add(listViewItem.Text);
                        numberOfPlayersSelected++;
                    }
                }
            }
            return numberOfPlayersSelected;
        }
    }
}
