using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Modern flat ui rj code advance en
namespace The_ULTIMATE_golf_quiz
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeMainMenu();
            
        }
        List<string> questionTypes = new List<string>();
        public frmMainMenu(string startScreenName) 
        {
            InitializeMainMenu();
            switch (startScreenName)
            {
                case "selectRoundType":
                    pnlMainMenu.Visible = false;
                    pnlTypeOfRound.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public void InitializeMainMenu()
        {
            InitializeComponent();
            pnlTypeOfRound.Visible = false;
            pnlMainMenu.Visible = true;
            string[] avatarPaths = { "Default1", "Default2", "Tiger Woods", "Rory McIllroy", "Female1", "Female2" };
            int avatarIndex = SplashScreen.player.avatar;
            pctBoxAvatar.Image = (Image)Properties.Resources.ResourceManager.GetObject(avatarPaths[avatarIndex]);
            lblRounds.Text = "Rounds Completed: " + SplashScreen.player.roundsPlayed;
              
        }

        //----------------------------------------------------------------------------
        public void btnQuiz_Click(object sender, EventArgs e)
        {
            questionTypes.Add("Type It");
            questionTypes.Add("True or False");
            questionTypes.Add("Multiple Choice");
            pnlMainMenu.Visible = false;
          pnlTypeOfRound.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // when clicked the user will be sent back to the login screen
            this.Hide();
            new frmLogin().Show();
        }

       
        //------------------------------------------------------------------------------
        private void mainMenu_Load(object sender, EventArgs e)
        {
            // when the main menu loads, these labels may be shown displaying some basic information
            lblCurrentUser.Text = "Current User: " + SplashScreen.player.name;
            lblHighScore.Text = "Highscore: " + Convert.ToString(SplashScreen.player.highscore);
            // lblRounds.Text = "Rounds played: " + timesPlayed;
        }
        private void mainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // when the window is closed, the program will also close 
            System.Windows.Forms.Application.Exit();
        }

        private void btnQuiz_MouseHover(object sender, EventArgs e)
        {
            lblArrow1.Visible=true;
            lblArrow2.Visible=true;
            lblArrow3.Visible=true;
        }

        private void btnQuiz_MouseLeave(object sender, EventArgs e)
        {
            lblArrow1.Visible=false; 
            lblArrow2.Visible=false;
            lblArrow3.Visible=false;
        }
        //-----------------------------------------------------------------------
        private void btnTypeItRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType= "Type It";            
            this.Hide();
            new frmQuizQuestions().Show();
            
        }

        private void btnTrueOrFalseRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "True or False";
            this.Hide();
            new frmQuizQuestions().Show();
        }

        private void btnMultipleChoiceRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Multiple Choice";
            this.Hide();
            new frmQuizQuestions().Show();
        }
        private void btnPictureRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Picture";
            this.Hide();
            new frmQuizQuestions().Show();
        }

        public void btnSurpriseMeRound_Click(object sender, EventArgs e)
        {            
            Random random = new Random();
            QuestionFileHandler.RoundType = questionTypes[random.Next(0,questionTypes.Count)];
            this.Hide();
            new frmQuizQuestions().Show();

        }
        //-------------------------------------------------------------------------------
        private void btnFinish_Click(object sender, EventArgs e)
        {
            pnlFinish.Visible = false;
            this.Hide();
            new frmLeaderboard().Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = true;
            pnlTypeOfRound.Visible = false;
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLeaderboard().Show();
        }

        
    }   
    
}
