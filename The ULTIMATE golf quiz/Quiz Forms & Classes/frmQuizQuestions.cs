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

        List<string> questionTypes = new List<string>();

        public frmQuizQuestions()
        {
            InitializeComponent();
            txtBoxAnswer.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
            NumberOfQuestionsAskedThisRound = 0;
            
        }
        private void frmQuizQuestions_Load(object sender, EventArgs e)
        {
            frmQuizQuestionsInitialisation();
        }
        private void frmQuizQuestionsInitialisation()
        {
            pnlAnswer.Visible = false;
            pnlQuestion.Visible = false;
            pnlTypeIt.Visible = false;
            pnlTrueOrFalseOptions.Visible = false;
            pnlMultipleChoiceOptions.Visible = false;
            pnlFinish.Visible = false;

            if (QuestionFileHandler.TypeItQuestions.Count > 0)
                questionTypes.Add("Type It");
            if (QuestionFileHandler.TrueOrFalseQuestions.Count > 0)
                questionTypes.Add("True or False");
            if (QuestionFileHandler.MultiChoiceQuestions.Count > 0)
                questionTypes.Add("Multiple Choice");
            if (QuestionFileHandler.PictureQuestions.Count > 0)
                questionTypes.Add("Picture");

            pnlTypeOfRound.Dock = DockStyle.Fill;
            pnlTypeOfRound.Visible = true;
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
            btnNext.Visible = false;

 /*           switch (QuestionFileHandler.RoundType)
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
                    pctBoxPicture.Visible = true;
                    pnlMultipleChoiceOptions.Dock = DockStyle.Fill;
                    break;
            }*/
            // Then gets the initial question
            GetQuestion();
        }
        // Prepares initial display for whatever round type is selected
       
       // list of all the questions which are read in from each question types csv
        List<TypeItQuestion> typeItQuestionList = QuestionFileHandler.TypeItQuestions;
        List<TrueOrFalseQuestion> trueOrFalseQuestionList = QuestionFileHandler.TrueOrFalseQuestions;
        List<MultiChoiceQuestion> multipleChoiceQuestionList = QuestionFileHandler.MultiChoiceQuestions;
        List<PictureQuestion> pictureQuestionList = QuestionFileHandler.PictureQuestions;
        

        // Separate questions for each type to be used outside of the GetQuestion method
        private TypeItQuestion currentTypeItQuestion1;
        private TrueOrFalseQuestion currentTrueOrFalseQuestion1;
        private MultiChoiceQuestion currentMultipleChoiceQuestion1;
        private PictureQuestion currentPictureQuestion1;
        bool enterKeyPressed = false;

        // Question method
        public void GetQuestion()
        {
            // Hide question panels and question answer
            pnlMultipleChoiceOptions.Visible = false;
            pnlTrueOrFalseOptions.Visible = false;
            pnlTypeIt.Visible = false;
            pctBoxPicture.Visible = false;
            lblAnswer.Visible = false;

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
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentTypeItQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentTypeItQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;

                            // Show TypeIt panel
                            pnlTypeIt.Visible = true;
                            pnlTypeIt.Dock = DockStyle.Fill;

                        }
                        else
                        {
                            frmQuizQuestionsInitialisation();
                            MessageBox.Show("You have completed all available questions for type it, Congratulations!");
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
                            this.ActiveControl = btnTrue;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentTrueOrFalseQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentTrueOrFalseQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;

                            // Show TrueOrFalse panel
                            pnlTrueOrFalseOptions.Visible = true;
                            pnlTrueOrFalseOptions.Dock = DockStyle.Fill;
                        }
                        else
                        {
                            frmQuizQuestionsInitialisation();
                            MessageBox.Show("You have completed all available questions for true or false, Congratulations!");
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
                            btnOption1.Text = currentMultipleChoiceQuestion.Option1;
                            btnOption2.Text = currentMultipleChoiceQuestion.Option2;
                            btnOption3.Text = currentMultipleChoiceQuestion.Option3;
                            btnOption4.Text = currentMultipleChoiceQuestion.Option4;
                            this.ActiveControl = btnOption1;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentMultipleChoiceQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentMultipleChoiceQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;

                            // Show MultipleChoice panel
                            pnlMultipleChoiceOptions.Visible = true;
                            pnlMultipleChoiceOptions.Dock = DockStyle.Fill;

                        }
                        else
                        {
                            frmQuizQuestionsInitialisation();
                            MessageBox.Show("You have completed all available questions for multiple choice, Congratulations!");
                        }
                        break;

                    case "Picture":
                        if (pictureQuestionList.Count > 0)
                        {
                            Random random = new Random();
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of multi choice questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.PictureQuestions.Count - 1);
                            PictureQuestion currentPictureQuestion = QuestionFileHandler.PictureQuestions[randomisedQuestionNumber];
                            // sets the current question equal to the base question with the randomised index
                            currentPictureQuestion1 = currentPictureQuestion;
                            // if the current questions' id equals a question in the lists' id, then the question will be displayed

                            // Question preparation
                            lblQuestion.Text = currentPictureQuestion.Question;
                            btnOption1.Text = currentPictureQuestion.Option1;
                            btnOption2.Text = currentPictureQuestion.Option2;
                            btnOption3.Text = currentPictureQuestion.Option3;
                            btnOption4.Text = currentPictureQuestion.Option4;
                            pctBoxPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentPictureQuestion.PictureId);
                            this.ActiveControl = btnOption1;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentPictureQuestion.Difficulty];
                            TotalPointsAvailable = TotalPointsAvailable + currentPictureQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;

                            // Show MultipleChoce and Picture panels
                            pnlMultipleChoiceOptions.Visible = true;
                            pctBoxPicture.Visible = true;
                            pnlMultipleChoiceOptions.Dock = DockStyle.Fill;
                        }
                        else
                        {
                            frmQuizQuestionsInitialisation();
                            MessageBox.Show("You have completed all available questions for the picture round, Congratulations!");
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
            lblAnswer.Visible = true;
            QuestionFileHandler.TypeItQuestions.Remove(currentTypeItQuestion1);
            AnswerButtonsDisable();
            pnlAnswer.Visible = true;
            btnNext.Visible = true;
            txtBoxAnswer.Enabled = false;
            if (txtBoxAnswer.Text.ToLower() == currentTypeItQuestion1.CorrectAnswer.ToLower())
            {
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentTypeItQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTypeItQuestion1, true);
            }
            else
            {
                lblAnswer.Text = "Incorrect, the answer is " + currentTypeItQuestion1.CorrectAnswer;
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTypeItQuestion1, false);
            }
        }

        //---------------------------------------------------------------------------------------------------------
        private void btnTrue_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable(); 
            lblAnswer.Visible = true;
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "1")
            {
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
            }
            else
            {
                lblAnswer.Text = "Incorrect, it's false";
            }
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            lblAnswer.Visible = true;
            AnswerButtonsDisable();
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "0")
            {
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
            }
            else
            {
               lblAnswer.Text = "Incorrect, it's true";
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnOption1_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            lblAnswer.Visible = true;
            btnNext.Visible = true;
            this.ActiveControl = btnNext;

            if(QuestionFileHandler.RoundType=="Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption1.Text)
                {
                   lblAnswer.Text = "Correct";
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                }
                else
                {
                   lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;

                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption1.Text)
                {
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                }
                else
                {
                    lblAnswer.Text = "Incorrect, the answer is " + currentPictureQuestion1.CorrectAnswer;
                }
            }
            
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            lblAnswer.Visible = true;
            btnNext.Visible = true;
            this.ActiveControl = btnNext;

            if (QuestionFileHandler.RoundType == "Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption2.Text)
                {
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                }
                else
                {
                   lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;

                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption2.Text)
                {
                    
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                }
                else
                {
                   
                    lblAnswer.Text = "Incorrect, the answer is " + currentPictureQuestion1.CorrectAnswer;
                }
            }
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            lblAnswer.Visible = true;

            if (QuestionFileHandler.RoundType == "Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption3.Text)
                {
                   
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                }
                else
                {
                    
                    lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;

                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption3.Text)
                {
                    
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                }
                else
                {
                    
                    lblAnswer.Text = "Incorrect, the answer is " + currentPictureQuestion1.CorrectAnswer;
                }
            }
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            lblAnswer.Visible = true;

            if (QuestionFileHandler.RoundType == "Multiple Choice")
            {
                QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
                if (currentMultipleChoiceQuestion1.CorrectAnswer == btnOption4.Text)
                {
                   
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                }
                else
                {
                    
                    lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;
                }
            }
            else if (QuestionFileHandler.RoundType == "Picture")
            {
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                if (currentPictureQuestion1.CorrectAnswer == btnOption4.Text)
                {
                   
                    TotalScoreForCurrentRound = TotalScoreForCurrentRound + currentPictureQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                }
                else
                {
                    
                    lblAnswer.Text = "Incorrect, the answer is " + currentPictureQuestion1.CorrectAnswer;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------


        private void btnNext_Click(object sender, EventArgs e)
        {
            // When it is clicked, the question will reset back to default
            //lblCorrect.Visible = false;
            //lblCorrectAnswer.Visible = false;
            lblAnswer.Visible = false;
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
            pnlFinish.Dock = DockStyle.Fill;
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
            frmQuizQuestionsInitialisation();
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
    }
}