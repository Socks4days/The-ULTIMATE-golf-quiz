using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    internal class PictureQuestion : BaseQuestion
    {
        public PictureQuestion() { }

        public string PictureId { get; set; }

        public PictureQuestion(string id, string question, string correctAnswer, int points, int difficulty, string pictureId) : base(id, question, correctAnswer, points, difficulty)
        {
            this.PictureId = pictureId;
        }
    }
}
