using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    internal class QuestionFileHandler
    {
        public static List<TypeItQuestion> TypeItQuestions = new List<TypeItQuestion>();
        public static List<TrueOrFalseQuestion> TrueOrFalseQuestions = new List<TrueOrFalseQuestion>();
        public static List<MultiChoiceQuestion> MultiChoiceQuestions = new List<MultiChoiceQuestion>();
        public static List<PictureQuestion> PictureQuestions = new List<PictureQuestion>();
        //public static List<BaseQuestion> TypeItQuestions = new List<BaseQuestion>();
        public static string RoundType { get; set; }


        public static void ReadInTypeItQuestions()
        {
            string[] typeItQuestionData = new string[5];
            string line;
            try 
            { 
            string filePath = "TypeItQuestions.csv";
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    typeItQuestionData = line.Split(',').ToArray();
                    TypeItQuestion typeItQuestion = new TypeItQuestion();
                    typeItQuestion.Id = typeItQuestionData[0];
                    typeItQuestion.Question = typeItQuestionData[1];
                    typeItQuestion.CorrectAnswer = typeItQuestionData[2];
                    typeItQuestion.Points = Convert.ToInt32(typeItQuestionData[3]);
                    typeItQuestion.Difficulty = Convert.ToInt32(typeItQuestionData[4]);
                    // adds the question from the csv into the list of questions
                    TypeItQuestions.Add(typeItQuestion);
                }
                sr.Close();
            }
            }
            catch(FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.ToString(), "File Not Found", MessageBoxButtons.OK);
            }
        }
        public static void  SaveAllTypeItQuestions()
        {
            string filePath = "TypeItQuestions.csv";
            // again creates a list of all players and sets it equal to the list of players created in the splash screen
            // List<Player> players = SplashScreen.players;
            // using streamwriter to write to the csv file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Write details of each user into the file
                foreach (TypeItQuestion typeItQuestion in TypeItQuestions)
                {
                    sw.WriteLine("{0},{1},{2},{3},{4}",
                    typeItQuestion.Id, typeItQuestion.Question, typeItQuestion.CorrectAnswer, typeItQuestion.Points, typeItQuestion.Difficulty);
                }
                sw.Close();
            }
        }

        public static void ReadInTrueOrFalseQuestions()
        {
            string[] trueOrFalseQuestionData = new string[5];
            string line;
            try
            {
                string filePath = "TrueOrFalseQuestions.csv";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        trueOrFalseQuestionData = line.Split(',').ToArray();
                        TrueOrFalseQuestion trueOrFalseQuestion = new TrueOrFalseQuestion();
                        trueOrFalseQuestion.Id = trueOrFalseQuestionData[0];
                        trueOrFalseQuestion.Question = trueOrFalseQuestionData[1];
                        trueOrFalseQuestion.CorrectAnswer = trueOrFalseQuestionData[2];
                        trueOrFalseQuestion.Points = Convert.ToInt32(trueOrFalseQuestionData[3]);
                        trueOrFalseQuestion.Difficulty = Convert.ToInt32(trueOrFalseQuestionData[4]);
                        // adds the question from the csv into the list of questions
                        TrueOrFalseQuestions.Add(trueOrFalseQuestion);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.ToString(), "File Not Found", MessageBoxButtons.OK);
            }
        }
        public static void SaveAllTrueOrFalseQuestions()
        {
            string filePath = "TrueOrFalseQuestions.csv";
            // again creates a list of all players and sets it equal to the list of players created in the splash screen
            // List<Player> players = SplashScreen.players;
            // using streamwriter to write to the csv file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Write details of each user into the file
                foreach (TrueOrFalseQuestion trueOrFalseQuestion in TrueOrFalseQuestions)
                {
                    sw.WriteLine("{0},{1},{2},{3},{4}",
                    trueOrFalseQuestion.Id, trueOrFalseQuestion.Question, trueOrFalseQuestion.CorrectAnswer, trueOrFalseQuestion.Points, trueOrFalseQuestion.Difficulty);
                }
                sw.Close();
            }
        }
        public static void ReadInMultiChoiceQuestions()
        {
            string[] multiChoiceQuestionData = new string[9];
            string line;
            try
            {
                string filePath = "MultiChoiceQuestions.csv";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        multiChoiceQuestionData = line.Split(',').ToArray();
                        MultiChoiceQuestion multiChoiceQuestion = new MultiChoiceQuestion();
                        multiChoiceQuestion.Id = multiChoiceQuestionData[0];
                        multiChoiceQuestion.Question = multiChoiceQuestionData[1];
                        multiChoiceQuestion.CorrectAnswer = multiChoiceQuestionData[2];
                        multiChoiceQuestion.Points = Convert.ToInt32(multiChoiceQuestionData[3]);
                        multiChoiceQuestion.Difficulty = Convert.ToInt32(multiChoiceQuestionData[4]);
                        multiChoiceQuestion.Option1 = multiChoiceQuestionData[5];
                        multiChoiceQuestion.Option2 = multiChoiceQuestionData[6];
                        multiChoiceQuestion.Option3 = multiChoiceQuestionData[7];
                        multiChoiceQuestion.Option4 = multiChoiceQuestionData[8];
                        // adds the question from the csv into the list of questions
                        MultiChoiceQuestions.Add(multiChoiceQuestion);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.ToString(), "File Not Found", MessageBoxButtons.OK);
            }
        }
        public static void SaveAllMultiChoiceQuestions()
        {
            string filePath = "MultiChoiceQuestions.csv";
            // again creates a list of all players and sets it equal to the list of players created in the splash screen
            // List<Player> players = SplashScreen.players;
            // using streamwriter to write to the csv file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Write details of each user into the file
                foreach (MultiChoiceQuestion multiChoiceQuestion in MultiChoiceQuestions)
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                    multiChoiceQuestion.Id, multiChoiceQuestion.Question, multiChoiceQuestion.CorrectAnswer, multiChoiceQuestion.Points, 
                    multiChoiceQuestion.Difficulty, multiChoiceQuestion.Option1, multiChoiceQuestion.Option2, multiChoiceQuestion.Option3, multiChoiceQuestion.Option4);
                }
                sw.Close();
            }
        }

        public static void ReadInPictureQuestions()
        {
            string[] pictureQuestionData = new string[10];
            string line;
            try
            {
                string filePath = "PictureQuestions.csv";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        pictureQuestionData = line.Split(',').ToArray();
                        PictureQuestion pictureQuestion = new PictureQuestion();
                        pictureQuestion.Id = pictureQuestionData[0];
                        pictureQuestion.Question = pictureQuestionData[1];
                        pictureQuestion.CorrectAnswer = pictureQuestionData[2];
                        pictureQuestion.Points = Convert.ToInt32(pictureQuestionData[3]);
                        pictureQuestion.Difficulty = Convert.ToInt32(pictureQuestionData[4]);
                        pictureQuestion.Option1 = pictureQuestionData[5];
                        pictureQuestion.Option2 = pictureQuestionData[6];
                        pictureQuestion.Option3 = pictureQuestionData[7];
                        pictureQuestion.Option4 = pictureQuestionData[8];
                        pictureQuestion.PictureId = pictureQuestionData[9];
                        // adds the question from the csv into the list of questions
                        PictureQuestions.Add(pictureQuestion);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.ToString(), "File Not Found", MessageBoxButtons.OK);
            }
        }
        public static void SaveAllPictureQuestions()
        {
            string filePath = "PictureQuestions.csv";
            // again creates a list of all players and sets it equal to the list of players created in the splash screen
            // List<Player> players = SplashScreen.players;
            // using streamwriter to write to the csv file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Write details of each user into the file
                foreach (PictureQuestion pictureQuestion in PictureQuestions)
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                    pictureQuestion.Id, pictureQuestion.Question, pictureQuestion.CorrectAnswer, pictureQuestion.Points,
                    pictureQuestion.Difficulty, pictureQuestion.Option1, pictureQuestion.Option2, pictureQuestion.Option3, 
                    pictureQuestion.Option4,pictureQuestion.PictureId);
                }
                sw.Close();
            }
        }
    }
}
