using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public partial class frmTrueOrFalseQuestions : Form
    {
        public int NumberOfQuestionsAskedThisRound { get; set; }

        public frmTrueOrFalseQuestions()
        {
            InitializeComponent();
            NumberOfQuestionsAskedThisRound = 0;
            txtBoxAnswer.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
           
        }
        bool enterKeyPressed = false;
        public void GetQuestion()
        {
            List<TrueOrFalseQuestion> questionList = QuestionFileHandler.TrueOrFalseQuestions;
            foreach(TrueOrFalseQuestion question in questionList)
            {
                // creates a new random
                Random random = new Random();
                // sets a variable equal to a number between 1 and the total amount of questions in the list basequestions
                int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.TrueOrFalseQuestions.Count);
                // creates a new base question called current question
                TrueOrFalseQuestion currentQuestion = new TrueOrFalseQuestion();
                // sets the current question equal to the base question with the randomised index
                currentQuestion = QuestionFileHandler.TrueOrFalseQuestions[randomisedQuestionNumber];
                currentQuestion1 = currentQuestion;
                // if the current questions' id equals a question in the lists' id, then the question will be displayed
                if (currentQuestion.Id==question.Id)
                {
                    lblTrueOrFalseQuestion.Text = currentQuestion.Question;
                    lblCorrectAnswer.Text = currentQuestion.CorrectAnswer;
                    lblDifficulty.Text = "Difficulty: "+TrueOrFalseQuestion.DifficultyLevels[currentQuestion.Difficulty];
                    break;
                }
                // if it doesn't then it will loop round until it does                
            }           
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            GetQuestion();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Leaving will result in losing all your rounds' progress.\nDo you wish to leave? ", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new mainMenu().Show();
            }
            else if (result == DialogResult.No)
            {
                
            }
           
        }
        private TrueOrFalseQuestion currentQuestion1;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentQuestion1);
            btnNext.Visible = true;
            if (txtBoxAnswer.Text == currentQuestion1.CorrectAnswer)
            {
                lblCorrect.Visible = true;
                lblWrongAnswer.Visible = false;
                lblCorrectAnswer.Visible= false;
            }
            else
            {
                lblWrongAnswer.Visible = true;
                lblCorrectAnswer.Visible = true;
                lblCorrect.Visible = false;
            }
            if (QuestionFileHandler.TrueOrFalseQuestions.Count==0)
            {
                lblTrueOrFalseQuestion.Text = "You have completed all questions in this round - congratulations!!";
                btnNext.Visible = false;
                txtBoxAnswer.Visible = false;
                btnSubmit.Visible = false;
                lblDifficulty.Visible = false;
                lblCorrect.Visible = false;
                btnFinish.Visible = true;
                lblFinish.Visible = true;
                lblEnterYourAnswer.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblCorrect.Visible = false;
            lblCorrectAnswer.Visible = false;
            lblWrongAnswer.Visible = false;
            btnNext.Visible = false;
            txtBoxAnswer.Text = "";
            NumberOfQuestionsAskedThisRound++;
            enterKeyPressed = false;
            if (QuestionFileHandler.TrueOrFalseQuestions.Count>0)
            {
                GetQuestion();
            }           
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            SplashScreen.player.roundsPlayed++;
            UserFileHandler.SaveAllPlayers();
            this.Hide();
            new mainMenu().Show();
        }
        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // when the enter key is hit it will attemp to run the verification method to find out if a valid user is trying to log in
                 if (enterKeyPressed == false)
                 {
                    enterKeyPressed = true;
                    btnSubmit_Click(sender, e);                        
                 }
                break;

                default:

                    break;

            }
            
           
        }
    }
}
