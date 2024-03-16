using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace The_ULTIMATE_golf_quiz
{
    // Player class that extends the base User class with extra player details
    public class Player : User
    {
       // properties of the player class, creating the players highscore and whether they are an admin or not
        public int highscore { get; set; }
        public int isAdmin { get; set; }
        public int avatar { get; set; }
        public int roundsPlayed { get; set; }
        public int totalScoreForCurrentSession { get; set; }

        // default constructor
        public Player()
        {
        }

        // creates a player object, inheriting all the properties/behaviours of the user class and adds in the highscore and is/isn't admin
        public Player(string username, string password, string name, int age, string gender, string nationality, int highscore, int isAdmin, int avatar, int roundsPlayed) : base(username, password, name, age, gender, nationality)
        {
            this.highscore = highscore;
            this.isAdmin = isAdmin;
            this.avatar = avatar;
            this.roundsPlayed = roundsPlayed;
            this.totalScoreForCurrentSession = 0;
        }
    }
}