using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    internal class MultiChoiceQuestion : BaseQuestion
    {
        public MultiChoiceQuestion() { }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }


        public MultiChoiceQuestion( string id, string question, string correctAnswer, int points, int difficulty, string option1, string option2, string option3, string option4) :base(id, question, correctAnswer, points, difficulty)
        {
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
        }
    }
}
