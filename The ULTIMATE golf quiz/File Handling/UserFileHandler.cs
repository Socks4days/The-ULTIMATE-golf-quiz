using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public class UserFileHandler
    {
        const string userListFilePath = @"Users.csv";
        const string playerQuestionAnsweredFilePath = @"Player Files\QuestionsAnswered_PLAYER.csv";

        public static List<Player> players = new List<Player>();        
        public UserFileHandler()
        {

        }        
        //method that will read in all the players from the csv file
        public static void ReadInPlayers()
        {
            string line;
            // creates an array to store the current user's information in
            string[] playerInfo = new string[10];
            // creates the list of players and sets it equal to the list of players created in the splash screen
            // List<Player> players = SplashScreen.players;
            // using streamreader to read in all the players
            using (StreamReader sr = new StreamReader(userListFilePath))
            {                
                // Read details of each player until the end of the file
                while(!sr.EndOfStream)
                {
                   line = sr.ReadLine();
                  // puts all of the information into the already created array
                   playerInfo = line.Split(',').ToArray();
                   Player playerA = new Player();
                   playerA.username = playerInfo[0];
                   playerA.password = playerInfo[1];
                   playerA.name = playerInfo[2];
                   playerA.age = Convert.ToInt32(playerInfo[3]);
                   playerA.gender = playerInfo[4];
                   playerA.nationality = playerInfo[5];
                   playerA.highscore = Convert.ToInt32(playerInfo[6]);
                   playerA.isAdmin = Convert.ToInt32(playerInfo[7]);
                   playerA.avatar = Convert.ToInt32(playerInfo[8]);
                   playerA.roundsPlayed = Convert.ToInt32(playerInfo[9]);
                    // adds all the players that are in the csv into the original splash screen list of players
                   players.Add(playerA);
                }
                sr.Close();
            }

        }
       
        // method that will write out to the csv file to save all the users
        public static void SaveAllPlayers()
        {
            // again creates a list of all players and sets it equal to the list of players created in the splash screen
           // List<Player> players = SplashScreen.players;
           // using streamwriter to write to the csv file
            using (StreamWriter sw = new StreamWriter(userListFilePath))
            {        
                // Write details of each user into the file
                foreach (Player player in players)
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                    player.username,player.password,player.name,player.age,player.gender,player.nationality,player.highscore,player.isAdmin,player.avatar,player.roundsPlayed); 
                    
                }
                sw.Close();
            }
        }

        public static void SavePlayerQuestionAnswered(Player player, BaseQuestion question, bool correctAnswer)
        {
            // save whether a player has answered a questions to a file with the player's username
            // using streamwriter to append the line to the end of the csv file if it already exists
            string playerFilePathWithUsername = playerQuestionAnsweredFilePath.Replace("PLAYER", player.username);
            using (StreamWriter sw = new StreamWriter(playerFilePathWithUsername,true))
            {
                // Write details of question answered and right/wrong into the file
                sw.WriteLine("{0},{1}",
                question.Id, correctAnswer.ToString());
                sw.Close();
            }
        }
        public static void ClearPlayerQuestionAnswered(Player player)
        {
            string playerFilePathWithUsername = playerQuestionAnsweredFilePath.Replace("PLAYER", player.username);
            using (StreamWriter sw = new StreamWriter(playerFilePathWithUsername))
            {
                // Write details of question answered and right/wrong into the file
                sw.Write("");
                sw.Close();
            }
        }

        public static void DeletePlayerQuestionFile(Player player)
        {
            string playerFilePathWithUsername = playerQuestionAnsweredFilePath.Replace("PLAYER", player.username);
            System.IO.File.Delete(playerFilePathWithUsername);
        }

        public static void ReadPlayerQuestionAnswered(Player player)
        {
            string playerFilePathWithUsername = playerQuestionAnsweredFilePath.Replace("PLAYER", player.username);
            string line;
            string questionID;
            bool questionAnsweredCorrectly;
            string[] playersAnsweredQuestions = new string[2];

            // Clear and read in all questions 
            QuestionFileHandler.ReadInAllQuestions();

            try
            {
                using (StreamReader sr = new StreamReader(playerFilePathWithUsername))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        // puts all of the information into the already created array
                        playersAnsweredQuestions = line.Split(',').ToArray();

                        questionID = playersAnsweredQuestions[0];
                        questionAnsweredCorrectly = Convert.ToBoolean(playersAnsweredQuestions[1]);

                        // adds all the players that are in the csv into the original splash screen list of players
                        TypeItQuestion typeItQuestion = QuestionFileHandler.TypeItQuestions.Find(x => x.Id == questionID);
                        if (typeItQuestion != null)
                        {
                            QuestionFileHandler.TypeItQuestions.Remove(typeItQuestion);
                        }
                        TrueOrFalseQuestion trueOrFalseQuestion = QuestionFileHandler.TrueOrFalseQuestions.Find(x => x.Id == questionID);
                        if (trueOrFalseQuestion != null)
                        {
                            QuestionFileHandler.TrueOrFalseQuestions.Remove(trueOrFalseQuestion);
                        }
                        MultiChoiceQuestion multiChoiceQuestion = QuestionFileHandler.MultiChoiceQuestions.Find(x => x.Id == questionID);
                        if (multiChoiceQuestion != null)
                        {
                            QuestionFileHandler.MultiChoiceQuestions.Remove(multiChoiceQuestion);
                        }
                        PictureQuestion pictureQuestion = QuestionFileHandler.PictureQuestions.Find(x => x.Id == questionID);
                        if (pictureQuestion != null)
                        {
                            QuestionFileHandler.PictureQuestions.Remove(pictureQuestion);
                        }

                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException)
            {
                // File doesn't exist the first time the player logs in

            }

           
        }
        
    }
}