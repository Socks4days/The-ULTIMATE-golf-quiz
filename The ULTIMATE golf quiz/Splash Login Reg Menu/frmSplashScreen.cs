using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace The_ULTIMATE_golf_quiz
{

    // The splash screen is displayed when the application starts
    public partial class frmSplashScreen : Form
    {
 
        public frmSplashScreen()
        {
            InitializeComponent();
            // Read in all the players from the csv file
            UserFileHandler.ReadInPlayers();
        }

        // Create Player object and main menu for the duration of the program
        public static Player player = new Player();
        public static frmMain mainMenu;

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
