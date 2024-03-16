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
    // Admin - View Users
    public partial class frmViewUsers : Form
    {
        // Display form and add all players into the list view
        public frmViewUsers()
        {
            InitializeComponent();

            List<Player> playerList = UserFileHandler.players;
            foreach (Player player in playerList)
            {
                string playerName = player.username;
                listViewPlayers.Items.Add(playerName);
            }
        }

        // Close the form when the back arrow is clicked
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
