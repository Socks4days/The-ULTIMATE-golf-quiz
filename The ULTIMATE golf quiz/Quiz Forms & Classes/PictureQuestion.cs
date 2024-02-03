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
        public int CorrectLocationX { get; set; }
        public int CorrectLocationY { get; set; }

        public PictureQuestion(string id, string question, string correctAnswer, int points, int difficulty, string pictureId, int correctLocationX, int correctLocationY) : base(id, question, correctAnswer, points, difficulty)
        {
            PictureId = pictureId;
            CorrectLocationX = correctLocationX;
            CorrectLocationY = correctLocationY;
        }
    }
}
