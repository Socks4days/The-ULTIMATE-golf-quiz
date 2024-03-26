using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    // Base question class with properties shared by all question types
    public class BaseQuestion
    {
        public string Id { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }        
        public int Points { get; set; }
        public int Difficulty { get; set; }
        
        public static readonly Dictionary<int, string> DifficultyLevels = new Dictionary<int, string>()
        {
             {1, "Easy" },
             {2, "Medium" },
             {3, "Hard" },
             {4, "Almost Impossible" },
             {5, "Totally Impossible" }
        };

        public BaseQuestion() 
        {
        }

        public BaseQuestion (string id, string question, string correctAnswer, int points, int difficulty)
        {
            Id = id;
            Question = question;
            CorrectAnswer = correctAnswer;
            Points = points;
            Difficulty = difficulty;
        }
    }
}
