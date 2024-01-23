using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    internal class PictureQuestion : MultiChoiceQuestion
    {
        public PictureQuestion() { }

        public string PictureId { get; set; }

        public PictureQuestion(string id, string question, string correctAnswer, int points, int difficulty, string option1, string option2, string option3, string option4, string pictureId) : base(id, question, correctAnswer, points, difficulty,  option1,  option2,  option3,  option4)
        {
            this.PictureId = pictureId;
        }
    }
}
