using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    internal class TypeItQuestion : BaseQuestion
    {
        public TypeItQuestion() { }
        public TypeItQuestion(string id, string question, string correctAnswer, int points, int difficulty) :base(id, question, correctAnswer, points, difficulty) 
        {

        }
    }
}
