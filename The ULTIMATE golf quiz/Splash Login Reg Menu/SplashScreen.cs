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

    public partial class SplashScreen : Form
    {
 
        public SplashScreen()
        {
            InitializeComponent();
            // Read in all the players from the csv file
            UserFileHandler.ReadInPlayers();
            
           
        }

        // Create Player object for the duration of the program
        public static Player player = new Player();
        // Creates a list of players of type player for all forms to access


        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Starts timer when the splash screen loads 
            tmrLoad.Start();           
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            // image of golf ball image running alongside the loading bar
            pictureBox1.Show();
            pnlSmall.Width += 6;
            pictureBox1.Location = new Point(pictureBox1.Location.X + 6, pictureBox1.Location.Y);
            if (pnlSmall.Width >= panel1.Width)
            {
                // stops timer when it gets to the required width and then shows the login screen
                tmrLoad.Stop();
                this.Hide();
                new frmLogin().Show();
            }
        }

        
    }
}
