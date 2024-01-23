using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public partial class frmQuizQuestions : Form
    {
        public int TotalScoreForCurrentRound { get; set; }
        public int NumberOfQuestionsAnsweredCorrectly { get; set; }
        private int NumberOfQuestionsAskedThisRound { get; set; }
        private int TotalPointsAvailable { get; set; }

        public frmQuizQuestions()
        {
            InitializeComponent();
            txtBoxAnswer.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
            NumberOfQuestionsAskedThisRound = 0;
            
        }
        private void frmQuizQuestions_Load(object sender, EventArgs e)
        {
            pnlAnswer.Visible = false;
            pnlQuestion.Visible = false;
            pnlTypeIt.Visible = false;
            pnlTrueOrFalseOptions.Visible = false;
            pnlMultipleChoiceOptions.Visible = false;
            pnlFinish.Visible = false;
            pnlTypeOfRound.Dock = DockStyle.Fill;
        }
        private void btnTypeItRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Type It";
            setup();
        }

        private void btnTrueOrFalseRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "True or False";
            setup();
        }

        private void btnPictureRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Picture";
            setup();
        }

        private void btnMultipleChoiceRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Multiple Choice";
            setup();
        }

        private void btnDragAndDrop_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Drag n Drop";
            setup();
        }

        private void btnSurpriseMeRound_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            QuestionFileHandler.RoundType = questionTypes[random.Next(0, questionTypes.Count)];
            setup();
        }
        private void setup()
        {
            pnlQuestion.Visible = true;
            pnlAnswer.Visible = true;
            pnlTypeOfRound.Dock = DockStyle.None;
            pnlTypeOfRound.Visible = false;
            pnlQuestion.Dock = DockStyle.Top;
            pnlAnswer.Dock = DockStyle.Bottom;

            switch (QuestionFileHandler.RoundType)
            {
                case "Type It":

                    pnlTypeIt.Visible = true;
                    pnlTrueOrFalseOptions.Visible = false;
                    pnlMultipleChoiceOptions.Visible = false;
                    pnlTypeIt.Dock = DockStyle.Fill;
                    break;

                case "True or False":

                    pnlTrueOrFalseOptions.Visible = true;
                    pnlMultipleChoiceOptions.Visible = false;
                    pnlTypeIt.Visible = false;
                    pnlTrueOrFalseOptions.Dock = DockStyle.Fill;
                    break;

                case "Multiple Choice":

                    pnlMultipleChoiceOptions.Visible = true;
                    pnlTrueOrFalseOptions.Visible = false;
                    pnlTypeIt.Visible = false;
                    pnlMultipleChoiceOptions.Dock = DockStyle.Fill;
                    break;

                case "Picture":

                    pnlMultipleChoiceOptions.Visible = true;
                    pnlTrueOrFalseOptions.Visible = false;
                    pnlTypeIt.Visible = false;

                    break;
            }
            // Then gets the initial question
            GetQuestion();
        }
        // Prepares initial display for whatever round type is selected
       
       // list of all the questions which are read in from each question types csv
        List<TypeItQuestion> typeItQuestionList = QuestionFileHandler.TypeItQuestions;
        List<TrueOrFalseQuestion> trueOrFalseQuestionList = QuestionFileHandler.TrueOrFalseQuestions;
        List<MultiChoiceQuestion> multipleChoiceQuestionList = QuestionFileHandler.MultiChoiceQuestions;
        List<PictureQuestion> pictureQuestionList = QuestionFileHandler.PictureQuestions;
        List<string> questionTypes = new List<string>();

        // Separate questions for each type to be used outside of the GetQuestion method
        private TypeItQuestion currentTypeItQuestion1;
        private TrueOrFalseQuestion currentTrueOrFalseQuestion1;
        private MultiChoiceQuestion currentMultipleChoiceQuestion1;
        private PictureQuestion currentPictureQuestion1;
        bool enterKeyPressed = false;

        // Question method
        public void GetQuestion()
        {
            
            // If the amount of questions asked this round is less than 10 then it will ask another question
            if (NumberOfQuestionsAskedThisRound < 10)
            {               
                switch (QuestionFileHandler.RoundType)
                {
                    case "Type It":
                        // if the amount of type it questions in the list is more than 0, ie its not empty, then it will ask another question
                        if (typeItQuestionList.Count > 0)
                        {
                            Random random = new Random();
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of type it questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.TypeItQuestions.Count-1);
                            // the current question is equal to the question in the list with the index of the random number generated
                            TypeItQuestion currentTypeItQuestion = QuestionFileHandler.TypeItQuestions[randomisedQuestionNumber];
                            // sets the current question equal to the base question with the randomised index
                            currentTypeItQuestion1 = currentTypeItQuestion;

                            // Preparation for the question to be displayed
                            lblQuestion.Text = currentTypeItQuestion.Question;
                            txtBoxAnswer.Enabled = true;
                            this.ActiveControl = txtBoxAnswer;
                            lblCorrectAnswer.Text = currentTypeItQuestion.CorrectAnswer;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentTypeItQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentTypeItQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;
                        }
                        else
                        {
                            MessageBox.Show("You have completed all available questions for type it, Congratulations!");
                            this.Hide();
                            new frmMainMenu("selectRoundType").Show();
                        }
                        break;



                    case "True or False":
                        // Same things for true or false questions
                        if (trueOrFalseQuestionList.Count > 0)
                        {
                            Random random = new Random();
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of t or f questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.TrueOrFalseQuestions.Count-1);

                            TrueOrFalseQuestion currentTrueOrFalseQuestion = QuestionFileHandler.TrueOrFalseQuestions[randomisedQuestionNumber];
                            currentTrueOrFalseQuestion1 = currentTrueOrFalseQuestion;

                            // Question preparation
                            lblQuestion.Text = currentTrueOrFalseQuestion.Question;
                            lblCorrectAnswer.Text = currentTrueOrFalseQuestion.CorrectAnswer;
                            this.ActiveControl = btnTrue;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentTrueOrFalseQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentTrueOrFalseQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;
                        }
                        else
                        {
                            MessageBox.Show("You have completed all available questions for true or false, Congratulations!");
                            this.Hide();
                            new frmMainMenu("selectRoundType").Show();
                        }
                        break;



                    case "Multiple Choice":
                        if (multipleChoiceQuestionList.Count > 0)
                        {
                            Random random = new Random();
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of multi choice questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.MultiChoiceQuestions.Count - 1);
                            MultiChoiceQuestion currentMultipleChoiceQuestion = QuestionFileHandler.MultiChoiceQuestions[randomisedQuestionNumber];
                            // sets the current question equal to the base question with the randomised index
                            currentMultipleChoiceQuestion1 = currentMultipleChoiceQuestion;
                            // if the current questions' id equals a question in the lists' id, then the question will be displayed
                            
                            // Question preparation
                            lblQuestion.Text = currentMultipleChoiceQuestion.Question;
                            lblCorrectAnswer.Text = currentMultipleChoiceQuestion.CorrectAnswer;
                            btnOption1.Text = currentMultipleChoiceQuestion.Option1;
                            btnOption2.Text = currentMultipleChoiceQuestion.Option2;
                            btnOption3.Text = currentMultipleChoiceQuestion.Option3;
                            btnOption4.Text = currentMultipleChoiceQuestion.Option4;
                            this.ActiveControl = btnOption1;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentMultipleChoiceQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentMultipleChoiceQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;
                        }
                        else
                        {
                            MessageBox.Show("You have completed all available questions for multiple choice, Congratulations!");
                            this.Hide();
                            new frmMainMenu("selectRoundType").Show();
                        }
                        break;

                    


                    case "Picture":
                        if (pictureQuestionList.Count > 0)
                        {
                            Random random = new Random();
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of multi choice questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.MultiChoiceQuestions.Count - 1);
                            PictureQuestion currentPictureQuestion = QuestionFileHandler.PictureQuestions[randomisedQuestionNumber];
                            // sets the current question equal to the base question with the randomised index
                            currentPictureQuestion1 = currentPictureQuestion;
                            // if the current questions' id equals a question in the lists' id, then the question will be displayed

                            // Question preparation
                            lblQuestion.Text = currentPictureQuestion.Question;
                            lblCorrectAnswer.Text = currentPictureQuestion.CorrectAnswer;
                            btnOption1.Text = currentPictureQuestion.Option1;
                            btnOption2.Text = currentPictureQuestion.Option2;
                            btnOption3.Text = currentPictureQuestion.Option3;
                            btnOption4.Text = currentPictureQuestion.Option4;
                            //pctBoxPictureRound.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentPictureQuestion.PictureId);
                            this.ActiveControl = btnOption1;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentPictureQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentPictureQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;
                        }
                        else
                        {
                            MessageBox.Show("You have completed all available questions for the picture round, Congratulations!");
                            this.Hide();
                            new frmMainMenu("selectRoundType").Show();
                        }
                        break;

                    default:
                        break;
                }

                lblQuestionNumber.Text = QuestionFileHandler.RoundType + " " + NumberOfQuestionsAskedThisRound.ToString() + "/10";
            }
            else
            {
                // if the user has been asked their 10 questions, then they will be shown the finish panel
                RoundFinishedScreen();
            }                                          
        }

        //-------------------------------------------------------------------------------------------------------
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.ActiveControl = btnNext;
            QuestionFileHandler.TypeItQuestions.Remove(currentTypeItQuestion1);
            AnswerButtonsDisable();
            pnlAnswer.Visible = true;
            btnNext.Visible = true;
            txtBoxAnswer.Enabled = false;
            if (txtBoxAnswer.Text.ToLower() == currentTypeItQuestion1.CorrectAnswer.ToLower())
            {
                lblCorrect.Visible = true;
                lblWrongAnswer.Visible = false;
                lblCorrectAnswer.Visible = false;
                TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentTypeItQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTypeItQuestion1, true);
            }
            else
            {
                lblWrongAnswer.Visible = true;
                lblCorrectAnswer.Visible = true;
                lblCorrect.Visible = false;
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTypeItQuestion1, false);
            }
        }

        //---------------------------------------------------------------------------------------------------------
        private void btnTrue_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "1")
            {
                lblCorrect.Visible = true;
                lblWrongAnswer.Visible = false;
                lblCorrectAnswer.Visible = false;
                TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
            }
            else
            {
                lblWrongAnswer.Visible = true;
                lblCorrectAnswer.Visible = true;
                lblCorrect.Visible = false;
                lblCorrectAnswer.Text = "False";
            }
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "0")
            {
                lblCorrect.Visible = true;
                lblWrongAnswer.Visible = false;
                lblCorrectAnswer.Visible = false;
                TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
            }
            else
            {
                lblWrongAnswer.Visible = true;
                lblCorrectAnswer.Visible = true;
                lblCorrect.Visible = false;
                lblCorrectAnswer.Text = "True";
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnOption1_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            btnNext.Visible = true;
            this.ActiveControl = btnNext;

            if(QuestionFileHandler.RoundType=="Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption1.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentMultipleChoiceQuestion1.CorrectAnswer;
                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption1.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentPictureQuestion1.CorrectAnswer;
                }
            }
            
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            btnNext.Visible = true;
            this.ActiveControl = btnNext;


            if (QuestionFileHandler.RoundType == "Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption2.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentMultipleChoiceQuestion1.CorrectAnswer;
                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption2.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentPictureQuestion1.CorrectAnswer;
                }
            }
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            btnNext.Visible = true;
            this.ActiveControl = btnNext;


            if (QuestionFileHandler.RoundType == "Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption3.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentMultipleChoiceQuestion1.CorrectAnswer;
                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption3.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentPictureQuestion1.CorrectAnswer;
                }
            }
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            btnNext.Visible = true;
            this.ActiveControl = btnNext;


            if (QuestionFileHandler.RoundType == "Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption4.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentMultipleChoiceQuestion1.CorrectAnswer;
                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption4.Text)
                {
                    lblCorrect.Visible = true;
                    lblWrongAnswer.Visible = false;
                    lblCorrectAnswer.Visible = false;
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                    lblWrongAnswer.Visible = true;
                    lblCorrectAnswer.Visible = true;
                    lblCorrect.Visible = false;
                    lblCorrectAnswer.Text = currentPictureQuestion1.CorrectAnswer;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------


        private void btnNext_Click(object sender, EventArgs e)
        {
            // When it is clicked, the question will reset back to default
            lblCorrect.Visible = false;
            lblCorrectAnswer.Visible = false;
            lblWrongAnswer.Visible = false;
            btnNext.Visible = false;
            txtBoxAnswer.Text = "";
            enterKeyPressed = false;

            // Allows the user to answer again
            AnswerButtonsEnabled();

            // alternative way to do this, put the round type questions in a generic list for the round and reference that list instead of each individual list
            if (QuestionFileHandler.RoundType == "Type It" && QuestionFileHandler.TypeItQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "Type It" && QuestionFileHandler.TypeItQuestions.Count == 0)
            {
                questionTypes.Remove("Type It");
                RoundFinishedScreen();
            }
            else if (QuestionFileHandler.RoundType == "True or False" && QuestionFileHandler.TrueOrFalseQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "True or False" && QuestionFileHandler.TrueOrFalseQuestions.Count == 0)
            {
                questionTypes.Remove("True or False");
                RoundFinishedScreen();
            }
            else if (QuestionFileHandler.RoundType == "Multiple Choice" && QuestionFileHandler.MultiChoiceQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "Multiple Choice" && QuestionFileHandler.MultiChoiceQuestions.Count == 0)
            {
                questionTypes.Remove("Multiple Choice");
                RoundFinishedScreen();
            }
            else if (QuestionFileHandler.RoundType == "Picture" && QuestionFileHandler.PictureQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "Picture" && QuestionFileHandler.PictureQuestions.Count == 0)
            {
                questionTypes.Remove("Picture");
                RoundFinishedScreen();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------


        // Method called when the user has either finished their 10 questions or exhausted all the available questions of a certain type
        private void RoundFinishedScreen()
        {
            pnlFinish.Visible = true;
            lblQuestionsAnsweredCorrectly.Text = "You got " + NumberOfQuestionsAnsweredCorrectly + "/" + NumberOfQuestionsAskedThisRound + " questions correct!";
            lblTotalScore.Text = "You got " + TotalScoreForCurrentRound + "/" + TotalPointsAvailable + " points!";
            pnlAnswer.Visible = false;
            btnNext.Visible = false;
            pnlQuestion.Visible = false;
            pnlTypeIt.Visible = false;
            pnlTrueOrFalseOptions.Visible = false;
            pnlMultipleChoiceOptions.Visible = false;
            SplashScreen.player.totalScoreForCurrentSession += TotalScoreForCurrentRound;
            if (SplashScreen.player.totalScoreForCurrentSession > SplashScreen.player.highscore)
            {
                SplashScreen.player.highscore = SplashScreen.player.totalScoreForCurrentSession;
                UserFileHandler.SaveAllPlayers();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------


        

        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                     if (enterKeyPressed == false)
                     {
                        if (txtBoxAnswer.Enabled == true)
                        {
                            btnSubmit_Click(sender, e);
                            enterKeyPressed = true;
                        }
                        else if (btnNext.Visible = true && pnlAnswer.Visible == true)
                        {
                            btnNext_Click(sender, e);
                            enterKeyPressed = true;
                        }                     
                     }
                break;

                default:

                    break;
            }         
        }

        //-------------------------------------------------------
       
        private void AnswerButtonsDisable()
        {
            btnOption1.Enabled= false;
            btnOption2.Enabled= false;
            btnOption3.Enabled= false;
            btnOption4.Enabled= false;
            txtBoxAnswer.Enabled= false;
            btnSubmit.Enabled= false;
            btnTrue.Enabled= false;
            btnFalse.Enabled= false;
        }
        private void AnswerButtonsEnabled()
        {
            btnOption1.Enabled = true;
            btnOption2.Enabled = true;
            btnOption3.Enabled = true;
            btnOption4.Enabled = true;
            txtBoxAnswer.Enabled = true;
            btnSubmit.Enabled = true;
            btnTrue.Enabled = true;
            btnFalse.Enabled = true;
        }

        //-------------------------------------------------------

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            NumberOfQuestionsAskedThisRound = 0;
            this.Hide();
            new frmMainMenu("selectRoundType").Show();
           
        }

        //-----------------------------------------------------------------

        private void btnFinishSession_Click(object sender, EventArgs e)
        {
            SplashScreen.player.roundsPlayed++;
            UserFileHandler.SaveAllPlayers();
            this.Close();
        }

        //---------------------------------------------------------------------------------------------------------------------

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Leaving will result in losing all your rounds' progress.\nDo you wish to leave? ", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /* private void btnTypeItRound_Click(object sender, EventArgs e)
       {
           QuestionFileHandler.RoundType = "Type It";
           this.Hide();
           new frmQuizQuestions().Show();
       }

       private void btnTrueOrFalseRound_Click(object sender, EventArgs e)
       {
           QuestionFileHandler.RoundType = "True or False";
           this.Hide();
           new frmQuizQuestions().Show();
       }

       private void btnMultipleChoiceRound_Click(object sender, EventArgs e)
       {
           QuestionFileHandler.RoundType = "Multiple Choice";
           this.Hide();
           new frmQuizQuestions().Show();
       }

       private void btnPictureRound_Click(object sender, EventArgs e)
       {
           MessageBox.Show("Unavailable");
       }

       private void btnDragAndDrop_Click(object sender, EventArgs e)
       {
           MessageBox.Show("Unavailable");
       }

       private void btnSurpriseMeRound_Click(object sender, EventArgs e)
       {
           if (questionTypes.Count>0)
           {
               Random random = new Random();
               QuestionFileHandler.RoundType = questionTypes[random.Next(0, questionTypes.Count)];
               this.Hide();
               new frmQuizQuestions().Show();
           }
           else
           {
               MessageBox.Show("You have completed all available round types, Congratulations!");
           }
       }*/

        //-------------------------------------------------------------------------------------------
    }
}