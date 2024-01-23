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
    public partial class frmViewUsers : Form
    {
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
