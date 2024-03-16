using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    // True or False question - extends base question class, but doesn't need any new properies
    internal class TrueOrFalseQuestion : BaseQuestion
    {
        public TrueOrFalseQuestion() { }
        public TrueOrFalseQuestion( string id, string question, string correctAnswer, int points, int difficulty) : base(id,question, correctAnswer, points, difficulty)
        {
        }
    }
}
