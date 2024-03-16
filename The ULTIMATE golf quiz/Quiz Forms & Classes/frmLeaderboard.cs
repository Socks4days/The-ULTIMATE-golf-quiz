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
    // Show the leaderboard form
    public partial class frmLeaderboard : Form
    {
        public frmLeaderboard()
        {
            InitializeComponent();
            
            // Sort player list by descending highscore
            List<Player> sortedPlayerList = UserFileHandler.players.OrderByDescending(p=>p.highscore).ToList();
            
            // Add each player in the sorted list to the leader board
            foreach (Player player in sortedPlayerList)
            {
                // Create an array with the player's username and highscore
                string[] row = { player.username, player.highscore.ToString() };
                
                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);
                
                // Add the list item to the leader board list view
                listViewLeaderboard.Items.Add(item);
            }
        }

        // Close the form when the back arrow button is clicked
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
