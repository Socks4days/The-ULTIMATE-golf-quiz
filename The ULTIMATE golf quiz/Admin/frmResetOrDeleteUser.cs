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
    public partial class frmResetOrDeleteUser : Form
    {
        public frmResetOrDeleteUser(string mode)
        {
            InitializeComponent();

            List<Player> playerList = UserFileHandler.players;
            foreach (Player player in playerList)
            {
                string playerName = player.username;
                listViewPlayers.Items.Add(playerName);
            }
            if (mode == "Delete")
            {
                DeleteAccount();
            }
            else if (mode == "Reset")
            {
                Reset();
            }
        }
        List<string> playersToEdit = new List<string>();
        public void DeleteAccount()
        {
            lblAdvice.Text = "To delete one or more users, select the users from the list and then hit 'Delete'\r\n";
            btnReset.Visible = false;
        }
        public void Reset()
        {
            lblAdvice.Text = "To reset one or more users passwords, select the users from the list and then hit 'Reset'\r\nTheir password will be reset to Password1!\r\n";
            btnDelete.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem listViewItem in listViewPlayers.Items)
            {
                if (listViewItem != null)
                {
                    if (listViewItem.Checked)
                    {
                        playersToEdit.Add(listViewItem.Text);
                    }
                }
                else MessageBox.Show("There are no available players to reset password");
            }
            foreach (string playerToResetPassword in playersToEdit)
            {
                foreach (Player player in UserFileHandler.players)
                {
                    
                    if (playerToResetPassword.ToString() == player.username)
                    {
                        player.password = "Password1!";
                        MessageBox.Show("Password Reset!");
                    }
                }
            }
            UserFileHandler.SaveAllPlayers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem listViewItem in listViewPlayers.Items)
            {
                if (listViewItem != null)
                {
                    if (listViewItem.Checked)
                    {
                        playersToEdit.Add(listViewItem.Text);
                    }
                }
            }
            List<Player> players = UserFileHandler.players;
            DialogResult result = MessageBox.Show("This action is permanent! \nDo you wish to continue?", "Delete Account", MessageBoxButtons.YesNo);
            foreach (string playerToDelete in playersToEdit)
            {
                try {
                    if (result == DialogResult.Yes)
                    {
                        foreach (Player player in players)
                        {
                            if (playerToDelete.ToString() == player.username)
                            {
                                players.Remove(player);
                                UserFileHandler.SaveAllPlayers();
                                MessageBox.Show(player.username + " has been deleted\nPlease refresh page...");
                            }
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }

                }
                catch(Exception) { }
                    
            }
        }


    }
}
