using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    // Picture Round question - extends base question class,
    // adding a property to hold the picture details
    // and properties to hold the x/y map coordinates of the correct location
    internal class WhereInTheWorld : BaseQuestion
    {
        public WhereInTheWorld() { }

        public string PictureId { get; set; }
        public int CorrectLocationX { get; set; }
        public int CorrectLocationY { get; set; }

        public WhereInTheWorld(string id, string question, string correctAnswer, int points, int difficulty, string pictureId, int correctLocationX, int correctLocationY) : base(id, question, correctAnswer, points, difficulty)
        {
            PictureId = pictureId;
            CorrectLocationX = correctLocationX;
            CorrectLocationY = correctLocationY;
        }
    }
}
