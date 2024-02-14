using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;


namespace The_ULTIMATE_golf_quiz
{
    public partial class frmQuizQuestions : Form
    {
        #region Properties
        public int TotalScoreForCurrentRound { get; set; }
        public int NumberOfQuestionsAnsweredCorrectly { get; set; }
        private int NumberOfQuestionsAskedThisRound { get; set; }
        private int TotalPointsAvailable { get; set; }

        // starting location of ball on panel
        private int ballStartX { get; set; }
        private int ballStartY { get; set; }
        private int flagStartX { get; set; }
        private int flagStartY { get; set; }
      
        private int distanceToHoleYds { get; set; }

        private int windSpeed { get; set; }
        private int windDirection { get; set; }        
        private int ydsToPixelsScale { get; set; }
        private int goButtonClickCount { get; set; }
       
        #endregion Properties

        #region Lists
        List<string> questionTypes = new List<string>();
        List<TypeItQuestion> typeItQuestionList = QuestionFileHandler.TypeItQuestions;
        List<TrueOrFalseQuestion> trueOrFalseQuestionList = QuestionFileHandler.TrueOrFalseQuestions;
        List<MultiChoiceQuestion> multipleChoiceQuestionList = QuestionFileHandler.MultiChoiceQuestions;
        List<PictureQuestion> pictureQuestionList = QuestionFileHandler.PictureQuestions;
        #endregion Lists

        #region BaseQuestionsReferredToThroughoutForm
        // Separate questions for each type to be used outside of the GetQuestion method
        private TypeItQuestion currentTypeItQuestion1;
        private TrueOrFalseQuestion currentTrueOrFalseQuestion1;
        private MultiChoiceQuestion currentMultipleChoiceQuestion1;
        private PictureQuestion currentPictureQuestion1;
        #endregion BaseQuestionsReferredToThroughoutForm

        #region EnterKeyLogic
        bool enterKeyPressed = false;
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
        #endregion EnterKeyLogic

        #region AnswerButtonsEnabling
        //-------------------------------------------------------

        private void AnswerButtonsDisable()
        {
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
            txtBoxAnswer.Enabled = false;
            btnSubmit.Enabled = false;
            btnTrue.Enabled = false;
            btnFalse.Enabled = false;
            btnChooseAClubGo.Enabled = false;
            comboBoxChooseAClub.Enabled = false;
            pctBoxMap.Enabled = false;
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
            btnChooseAClubGo.Enabled = true;
            comboBoxChooseAClub.Enabled = true;
            pctBoxMap.Enabled=true; 
        }
        #endregion AnswerButtonsEnabling

        public frmQuizQuestions()
        {
            backgroundMusicPlayer.SoundLocation = "Background Music.wav";
            backgroundMusicPlayer.Load();
            countdownPlayer.SoundLocation = "Countdown.wav";
            countdownPlayer.Load();
            InitializeComponent();
            startMusicPlayer();
            txtBoxAnswer.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
            NumberOfQuestionsAskedThisRound = 0;

            // remember start position of ball and flag (only the first time the form is created)
            ballStartX = pctBoxGolfBall.Location.X;
            ballStartY = pctBoxGolfBall.Location.Y;
            flagStartX = pctBoxFlag.Location.X;
            flagStartY = pctBoxFlag.Location.Y;
        }

        #region Music
        System.Media.SoundPlayer backgroundMusicPlayer = new System.Media.SoundPlayer();
        System.Media.SoundPlayer countdownPlayer = new System.Media.SoundPlayer();
       
        
       
        private void startMusicPlayer()
        {           
            backgroundMusicPlayer.PlayLooping();
        }
        private void stopMusicPlayer()
        {
            backgroundMusicPlayer.Stop();
        }
        private void startCountdown()
        {            
            countdownPlayer.Play();
        }
        private void stopCountdown()
        {
            countdownPlayer.Stop();
        }
        #endregion Music

        #region Initialisation
        private void frmQuizQuestions_Load(object sender, EventArgs e)
        {
            // initialise the form (when first loaded and at the start of each round)
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
            pnlChooseTheRightClub.Visible = false;
            pnlPicture.Visible = false;
            pnlTypeOfRound.Visible = false;
            pnlGrass.Visible = false;

            if (QuestionFileHandler.TypeItQuestions.Count > 0)
                questionTypes.Add("Type It");
            if (QuestionFileHandler.TrueOrFalseQuestions.Count > 0)
                questionTypes.Add("True or False");
            if (QuestionFileHandler.MultiChoiceQuestions.Count > 0)
                questionTypes.Add("Multiple Choice");
            if (QuestionFileHandler.PictureQuestions.Count > 0)
                questionTypes.Add("Picture");
            questionTypes.Add("Choose Club");

            pnlTypeOfRound.Dock = DockStyle.Fill;
            pnlTypeOfRound.Visible = true;

         
        }
        #endregion Initialisation

        #region RoundTypeButtonClicks
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
            QuestionFileHandler.RoundType = "Choose Club";
            setup();
        }

        private void btnSurpriseMeRound_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            QuestionFileHandler.RoundType = questionTypes[random.Next(0, questionTypes.Count)];
            setup();
        }
        #endregion RoundTypeButtonClicks

        #region SetupForRound
        private void setup()
        {
            pnlQuestion.Visible = true;
            pnlAnswer.Visible = true;
            pnlTypeOfRound.Dock = DockStyle.None;
            pnlTypeOfRound.Visible = false;
            pnlQuestion.Dock = DockStyle.Top;
            pnlAnswer.Dock = DockStyle.Bottom;
            btnNext.Visible = false;
           //pnlAnswer.BackColor = Color.FromArgb(55, 55, 55);
            
            // Then gets the initial question
            GetQuestion();
        }
        #endregion SetupForRound

        #region GetQuestion 

        private bool pictureQuestionAnswered = false;
        private int flagPositionX = 0;
        private int ballPositionX = 0;

        // Question method
        public void GetQuestion()
        {
            // Hide question panels and question answer
            pnlMultipleChoiceOptions.Visible = false;
            pnlTrueOrFalseOptions.Visible = false;
            pnlTypeIt.Visible = false;
            pctBoxPicture.Visible = false;
            lblAnswer.Visible = false;
            lblQuestion.ForeColor = Color.White;
            Random random = new Random();

            


            // If the amount of questions asked this round is less than 10 then it will ask another question
            if (NumberOfQuestionsAskedThisRound < 5)
            {
                // Start the countdown to 30 seconds
                countdown = 30 * 10;
                progressBarCountdown.Maximum = countdown;
                timerCountdown.Start();
                startCountdown();
                switch (QuestionFileHandler.RoundType)
                {
                    case "Type It":
                        // if the amount of type it questions in the list is more than 0, ie its not empty, then it will ask another question
                        if (typeItQuestionList.Count > 0)
                        {
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
                            TotalPointsAvailable += currentTypeItQuestion.Points;
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
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of t or f questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.TrueOrFalseQuestions.Count-1);

                            TrueOrFalseQuestion currentTrueOrFalseQuestion = QuestionFileHandler.TrueOrFalseQuestions[randomisedQuestionNumber];
                            currentTrueOrFalseQuestion1 = currentTrueOrFalseQuestion;

                            // Question preparation
                            lblQuestion.Text = currentTrueOrFalseQuestion.Question;
                            this.ActiveControl = btnTrue;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentTrueOrFalseQuestion.Difficulty];
                            TotalPointsAvailable += currentTrueOrFalseQuestion.Points;
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
                        //boys kissing
                    case "Multiple Choice":
                        if (multipleChoiceQuestionList.Count > 0)
                        {
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
                            TotalPointsAvailable += currentMultipleChoiceQuestion.Points;
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
                            
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of multi choice questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.PictureQuestions.Count - 1);
                            PictureQuestion currentPictureQuestion = QuestionFileHandler.PictureQuestions[randomisedQuestionNumber];
                            // sets the current question equal to the base question with the randomised index
                            currentPictureQuestion1 = currentPictureQuestion;
                            // if the current questions' id equals a question in the lists' id, then the question will be displayed

                            // Question preparation
                            lblQuestion.Text = currentPictureQuestion.Question;
                           // btnOption1.Text = currentPictureQuestion.Option1;
                           // btnOption2.Text = currentPictureQuestion.Option2;
                           // btnOption3.Text = currentPictureQuestion.Option3;
                           // btnOption4.Text = currentPictureQuestion.Option4;
                            pctBoxPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentPictureQuestion.PictureId);
                            this.ActiveControl = btnOption1;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentPictureQuestion.Difficulty];
                           // TotalPointsAvailable += currentPictureQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;

                            // Show MultipleChoce and Picture panels
                            //pnlMultipleChoiceOptions.Visible = true;
                            pctBoxPicture.Visible = true;
                            pnlPicture.Visible = true;
                            pnlPicture.Dock = DockStyle.Fill;
                            lblAnswer.Text = "Click a point on the map to select a location";
                            lblAnswer.Visible = true;
                            pictureQuestionAnswered = false;
                            pctBoxLocation.Visible = false;

                            // reset the imageZoomed flag and resize the picture to the new panel size
                            zoomPictureBox(false);
                        }
                        else
                        {
                            frmQuizQuestionsInitialisation();
                            MessageBox.Show("You have completed all available questions for the picture round, Congratulations!");
                        }
                        break;

                    case "Choose Club":

                        pnlChooseTheRightClub.Visible = true;
                        pnlGrass.Visible = true;
                        pnlChooseTheRightClub.Dock = DockStyle.Fill;

                        sx = 0;
                        sy = 0;
                        distanceToHoleYds = random.Next(10, 330);

                        // Default scale to convert yards to pixels is 2 for window of with 740 (default)
                        // Increase the scale if the window is larger
                        ydsToPixelsScale = Math.Max (2, 2 * pnlChooseTheRightClub.Width / 740); // ((pnlChooseTheRightClub.Width / (flagStartX - ballStartX)));

                        // Move the grass panel so it always appears at the bottom of the window and is the full width when the window size is changed
                        pnlGrass.Width = pnlChooseTheRightClub.Width;
                        pnlGrass.Location = new Point(pnlGrass.Location.X, pnlChooseTheRightClub.Height - pnlGrass.Height);


                        // Reset the Y positiion of the flag and ball to the bottom of the 'choose the right club' panel
                        flagStartY = pnlChooseTheRightClub.Height - pnlGrass.Height - pctBoxFlag.Height + 10;
                        ballStartY = pnlChooseTheRightClub.Height - pnlGrass.Height - pctBoxGolfBall.Height;
                        ballX = ballStartX;
                        ballY = ballStartY;

                        flagPositionX = ballStartX + distanceToHoleYds * ydsToPixelsScale;
                        pctBoxFlag.Location = new Point(flagPositionX - (pctBoxFlag.Width / 2), flagStartY);

                        lblQuestion.Text = ("Choose the club you think will get you closest to the hole");
                        lblDifficulty.Text = "Difficulty: Medium";
                        lblDistanceToHole.Text = "Distance to hole: " + distanceToHoleYds + " yards";
                        pctBoxGolfBall.Location = new Point(ballStartX - (pctBoxGolfBall.Width / 2), ballStartY);

                        NumberOfQuestionsAskedThisRound++;

                        Random windSpeedRnd = new Random();
                        windSpeed = windSpeedRnd.Next(-25,25);
                        if (windSpeed >= 15)
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagRight");
                        else if ( windSpeed <= -15)
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagLeft");
                        else if (windSpeed < -5)
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagLeftWeak");
                        else if ( windSpeed > 5)
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagRightWeak");
                        else
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagNone");
                        pctBoxFlag.BackColor = Color.Transparent;
                        lblWindSpeed.Text = "Wind Speed: " + Math.Abs(windSpeed);
                        // pnlAnswer.BackColor = Color.DarkGreen;

                        // reset go button and hide power progress bar
                        btnChooseAClubGo.Text = "Go!";
                        goButtonClickCount = 0;
                        progressBarPower.Visible = false;
                        lblPower.Visible = false;
                        pctBoxMap.Enabled = true;
                        break;

                    default:
                        break;
                }

                lblQuestionNumber.Text = QuestionFileHandler.RoundType + " " + NumberOfQuestionsAskedThisRound.ToString() + "/5";
            }
            else
            {
                
                // if the user has been asked their 10 questions, then they will be shown the finish panel
                RoundFinishedScreen();
            }                                          
        }
        #endregion GetQuestion

        #region QuizAnswerButtonClicks
        //-------------------------------------------------------------------------------------------------------
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop(); 
            stopCountdown();
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
                TotalScoreForCurrentRound += currentTypeItQuestion1.Points;
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
            timerCountdown.Stop();
            stopCountdown();
            pnlAnswer.Visible = true;
            AnswerButtonsDisable(); 
            lblAnswer.Visible = true;
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "1")
            {
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound += currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTrueOrFalseQuestion1, true);

            }
            else
            {
                lblAnswer.Text = "Incorrect, it's false";
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTrueOrFalseQuestion1, false);

            }
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            stopCountdown();
            pnlAnswer.Visible = true;
            lblAnswer.Visible = true;
            AnswerButtonsDisable();
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "0")
            {
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound += currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTrueOrFalseQuestion1, true);

            }
            else
            {
               lblAnswer.Text = "Incorrect, it's true";
                UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentTrueOrFalseQuestion1, false);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnOption1_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            stopCountdown();
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
                    TotalScoreForCurrentRound += currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, true);

                }
                else
                {
                   lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, false);

                }
            }
           
            
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            stopCountdown();
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
                    TotalScoreForCurrentRound += currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, true);

                }
                else
                {
                   lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, false);

                }
            }
           
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            stopCountdown();
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

                    TotalScoreForCurrentRound += currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, true);

                }
                else
                {

                    lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, false);

                }
            }
        }    

        private void btnOption4_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            stopCountdown();
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

                    TotalScoreForCurrentRound += currentMultipleChoiceQuestion1.Points;
                    NumberOfQuestionsAnsweredCorrectly++;
                    lblAnswer.Text = "Correct";
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, true);

                }
                else
                {

                    lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentMultipleChoiceQuestion1, false);

                }
            }
           
        }

        private void pctBoxMap_Click(object sender, EventArgs e)
        {
            if (!pictureQuestionAnswered)
            {
                timerCountdown.Stop();
                stopCountdown();
                MouseEventArgs mouseEvent = (MouseEventArgs)e;
                // MessageBox.Show(string.Format("X: {0} Y: {1}", x, y));
                int mapX = pctBoxMap.Location.X;
                int mapY = pctBoxMap.Location.Y;

                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);
                pctBoxLocation.Location = new Point(mapX + mouseEvent.X - (pctBoxLocation.Width / 2), mapY + mouseEvent.Y - pctBoxLocation.Height);

                // Get location selected (convert map panel width to 0-1000 range)
                int x = (1000 * mouseEvent.X) / pctBoxMap.Width;
                int y = (1000 * mouseEvent.Y) / pctBoxMap.Height;

                // Check if the player is close to the right answer
                if (Math.Abs(currentPictureQuestion1.CorrectLocationX - x) <= 50
                    && Math.Abs(currentPictureQuestion1.CorrectLocationY - y) <= 50)
                {
                    lblAnswer.Text = String.Format("Correct! {0} ({1}, {2} )\nYou selected ({3}, {4})",
                        currentPictureQuestion1.CorrectAnswer, currentPictureQuestion1.CorrectLocationX, currentPictureQuestion1.CorrectLocationY, x, y);
                    NumberOfQuestionsAnsweredCorrectly++;
                    TotalScoreForCurrentRound += currentPictureQuestion1.Points;
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentPictureQuestion1, true);

                }
                else
                {
                    lblAnswer.Text = String.Format("No, {0} ({1}, {2} )\nYou selected ({3}, {4})",
                        currentPictureQuestion1.CorrectAnswer, currentPictureQuestion1.CorrectLocationX, currentPictureQuestion1.CorrectLocationY, x, y);
                    UserFileHandler.SavePlayerQuestionAnswered(SplashScreen.player, currentPictureQuestion1, false);

                }
                pictureQuestionAnswered = true;

                AnswerButtonsDisable();
                pctBoxLocation.Visible = true;
                pnlAnswer.Visible = true;
                lblAnswer.Visible = true;
                btnNext.Visible = true;
                TotalPointsAvailable += currentPictureQuestion1.Points;
            }
        }


        private int ballX = 0;
        private int ballY = 0;
        private double sx = 0;
        private double sy = 0;

        private void btnChooseAClubGo_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            stopCountdown();
            // If this is the first time the go button is clicked, start the power timer
            if (goButtonClickCount == 0)
            {
                // Reset/show the power progress bar and start the power meter
                progressBarPower.Value = progressBarPower.Minimum;
                progressBarPower.Visible = true;
                lblPower.Visible = true;
                timerPower.Enabled = true;
                timerPower.Start();
                goButtonClickCount = 1;
                btnChooseAClubGo.Text = "Stop!";
                return;
            }
            stopMusicPlayer();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Golf Ball.wav";
            player.Load();
            player.Play();
            
            // Otherwise (second time go button click), stop the timer and animate the ball
            // Stop the power meter
            goButtonClickCount = 2;
            timerPower.Stop();
            timerPower.Enabled = false;

            

           
            // Get the power value selected by the player
            double powerSelected = progressBarPower.Value;

            // Animate ball moving to hole

            // s = (u*t) + (a*t*t)
            // assume no air fiction and no wind
            // sx = (u * cos(loft) * t) + ((0) * t * t)
            // assume gravity is -10
            // sy = (u * sin(loft) * t) + ((-10) * t * t)

            const double metresToYards = 1.094;

            // set value of gravity in yards per second (all distances in yards)
            const double gravity = 9.81 * metresToYards;

            // postition of flag on panel
            int flagX = pctBoxFlag.Location.X;
            int flagY = pctBoxFlag.Location.Y;

            sx = 0;
            sy = 0;

            // Get loft and swing speed for selected club
            string selectedClub = comboBoxChooseAClub.Text;
            if (selectedClub == "")
            {
                MessageBox.Show("You need to select a club first!");
                return;
            }

            // Move ball back to start
            

            double loftInDegrees = clubLoftAndMaxDistanceYds[selectedClub].Item1;
            double loftInRadians = loftInDegrees * Math.PI / 180;
            double maxDistanceYds = clubLoftAndMaxDistanceYds[selectedClub].Item2;

            double actualDistanceYds = 0;
            double swingSpeed = 0;
            double ux = 0;
            double uy = 0;

            // for putter, ignore wind speed and gravity
            if (selectedClub == "Putter")
            {
                actualDistanceYds = maxDistanceYds * (powerSelected / 100);
                ux = maxDistanceYds / 10; // 10 seconds for a 50 yard putt
            }
            // otherwise adjust distance based on wind speed and direction - 1% for every 1 mph
            else
            {
                // negative wind blowing to left (hitting into wind)
                // positive wind speed blowing to the right (hitting with the wind)
                // reduce or increase distance by 1% for every 1 mph
                    actualDistanceYds = maxDistanceYds * (100 + windSpeed) / 100;
                
                // Apply power selected to distance
                actualDistanceYds = actualDistanceYds * (powerSelected / 100);

                // Formula for horizontal distance the ball will go using loft and initial speed
                // horizontal distance = ( initial horizontal speed^2 * sin(2 * loft) ) / g
                // initial horizontal speed = square root of ( (horizontal distance * g) / sin (2 * loft) )
                swingSpeed = Math.Sqrt((actualDistanceYds * gravity) / Math.Sin(2 * loftInRadians));

                // Calculate starting horizontal (ux) and vertical (uy) speed based on loft (converted from degrees to radians)
                ux = swingSpeed * Math.Cos(loftInRadians);
                uy = swingSpeed * Math.Sin(loftInRadians);

            }

            double timeBallInMotion = actualDistanceYds / ux;

            // initialise starting time and interval for loop
            double timeInSecs = 0;
            double intervalInSecs = 0.1;

            // set start position for ball
            ballX = ballStartX;
            ballY = ballStartY;


            while (timeInSecs < timeBallInMotion)
            {
                // increment time
                timeInSecs += intervalInSecs;

                // calculate horizontal (sx) and vertical (sy) position in metres
                // s = (u*t) + (a*t*t)
                sx = (ux * timeInSecs);

                // for putter, ignore height
                if (selectedClub == "Putter")
                {
                    sy = 0;
                }
                else
                {
                    sy = (uy * timeInSecs) - (0.5 * gravity * timeInSecs * timeInSecs);
                }

                // move ball to position on canvas
                ballX = ballStartX + (int)sx * ydsToPixelsScale;
                ballY = ballStartY - (int)sy * ydsToPixelsScale;

                pctBoxGolfBall.Location = new Point(ballX - (pctBoxGolfBall.Width / 2), ballY);

                // wait interval seconds
                Thread.Sleep((int)(intervalInSecs * 100));
            }
           
            int distanceTravelledinYards = (ballX - ballStartX) / ydsToPixelsScale;
            int distanceFromHoleYds = Math.Abs(distanceToHoleYds - distanceTravelledinYards);
            int points = 0;
            if (distanceFromHoleYds <= 10)
            {
                NumberOfQuestionsAnsweredCorrectly++;
                points = 5;
            }
            else if (distanceFromHoleYds <= 20)
                points = 3;
            else if (distanceFromHoleYds < 30)
                points = 1;
            AnswerButtonsDisable();
            pnlAnswer.Visible = true;
            lblAnswer.Visible = true;
            btnNext.Visible = true;
            lblAnswer.Text = "Your ball went " + distanceTravelledinYards + " yards so you were " + distanceFromHoleYds + " yards from the hole"
                + "\nYou score " + points + " points";
            TotalScoreForCurrentRound += points;
            TotalPointsAvailable += 5;
            pctBoxMap.Enabled = false;
        }


        //-------------------------------------------------------------------------------------------------------------------
        #endregion QuizAnswerButtonClicks

        #region NextQuestionButtonClicked
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
            else if (QuestionFileHandler.RoundType == "Choose Club")
                GetQuestion();
        }

        #endregion NextQuestionButtonClicked

        #region EndOfRound
        private void RoundFinishedScreen()
        {
            stopCountdown();
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
            pnlChooseTheRightClub.Visible = false;
            pnlPicture.Visible = false;
            SplashScreen.player.totalScoreForCurrentSession += TotalScoreForCurrentRound;
            if (SplashScreen.player.totalScoreForCurrentSession > SplashScreen.player.highscore)
            {
                SplashScreen.player.highscore = SplashScreen.player.totalScoreForCurrentSession;
                UserFileHandler.SaveAllPlayers();
            }
        }
        #endregion EndOfRound

        #region FinishMenuButtonClicks
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
        #endregion FinishMenuButtonClicks

        #region Exiting
        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Leaving will result in losing all your rounds' progress.\nDo you wish to leave? ", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                stopCountdown();
                this.Close(); 
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            stopCountdown();
            this.Close();
        }



        #endregion Exiting



        private readonly Dictionary<string, (int,int)> clubLoftAndMaxDistanceYds = new Dictionary<string, (int,int)>
        { 
            { "Putter", (0,50) },
            { "Lob wedge", (60,106) },
            { "Sand wedge", (56, 115) },
            { "Gap wedge", (52, 129) },
            { "Pitching wedge", (48, 148) },
            { "9 iron", (42, 163) },
            { "8 iron", (38, 175) },
            { "7 iron", (34, 192) },
            { "6 iron", (29, 207) },
            { "5 iron", (25, 219) },
            { "4 iron", (22, 240) },
            { "5 wood", (18, 273) },
            { "3 wood", (14, 293) },
            { "Driver", (10, 326) }
        };


       

        private int ticks = 0;
        private void timerPower_Tick(object sender, EventArgs e)
        {
            // Stop when reach 100 or go button has been clicked a second time
            if (ticks < 100 && goButtonClickCount != 2)
            {
                ticks++;
                progressBarPower.Value = ticks;
            }
            else
            {
                timerPower.Stop();
                timerPower.Enabled = false;                
                ticks = 0;
            }
        }

        bool imageZoomed = false;
        int originalImageWidth = 140;
        int originalImageHeight = 140;

        private void zoomPictureBox(bool zoomImage)
        {
            if (zoomImage)
            {
                // Scale image to 80% of the panel width/height (whichever is smaller), but no smaller than 140x140
                int newImageWidth = Math.Max(140, (int)(Math.Min(pnlPicture.Width, pnlPicture.Height) * 0.8));
                int newImageHeight = newImageWidth;

                pctBoxPicture.Size = new Size(newImageWidth, newImageHeight);
                pctBoxPicture.Location = new Point((pnlPicture.Width / 2) - (pctBoxPicture.Width / 2), (pnlPicture.Height / 2) - (pctBoxPicture.Height / 2));
                imageZoomed = true;
            }
            else
            {
                pctBoxPicture.Size = new Size((originalImageWidth), (originalImageHeight));
                pctBoxPicture.Location = new Point(pnlPicture.Width - originalImageWidth - 20, 20);
                imageZoomed = false;
            }
        }

        private void calculateBallAndFlagPositionRelativeToWindow ()
        {
            // Default scale to convert yards to pixels is 2 for window of with 740 (default)
            // Increase the scale if the window is larger
            ydsToPixelsScale = Math.Max(2, 2 * pnlChooseTheRightClub.Width / 740); // ((pnlChooseTheRightClub.Width / (flagStartX - ballStartX)));

            // Move the grass panel so it always appears at the bottom of the window and is the full width when the window size is changed
            pnlGrass.Width = pnlChooseTheRightClub.Width;
            pnlGrass.Location = new Point(pnlGrass.Location.X, pnlChooseTheRightClub.Height - pnlGrass.Height);


            // Reset the Y positiion of the flag and ball to the bottom of the 'choose the right club' panel
            flagStartY = pnlChooseTheRightClub.Height - pnlGrass.Height - pctBoxFlag.Height + 10;
            flagPositionX = ballStartX + distanceToHoleYds * ydsToPixelsScale;

            // Recalculate position of ball using new scale
            ballStartY = pnlChooseTheRightClub.Height - pnlGrass.Height - pctBoxGolfBall.Height;
            ballX = ballStartX + (int)sx * ydsToPixelsScale;
            ballY = ballStartY - (int)sy * ydsToPixelsScale;

            // Move the flag
            pctBoxFlag.Location = new Point(flagPositionX - (pctBoxFlag.Width / 2), flagStartY);

            // Move the ball
            pctBoxGolfBall.Location = new Point(ballX - (pctBoxFlag.Width / 2), ballY);

        }

        private void pctBoxPicture_Click(object sender, EventArgs e)
        {
            // Toggle image zoom
            zoomPictureBox(!imageZoomed);
        }

        private void frmQuizQuestions_Resize(object sender, EventArgs e)
        {
            if (QuestionFileHandler.RoundType == "Picture")
            {
                // resize the picture to the new panel size
                zoomPictureBox(imageZoomed);
            }
            else if (QuestionFileHandler.RoundType == "Choose Club")
            {
                // move the ball, flag and grass to the right places based on the new window size
                calculateBallAndFlagPositionRelativeToWindow();
            }
        }

        int countdown = 0;
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {                
                countdown--;
                progressBarCountdown.Value = countdown;
            }
            else
            {
                
                lblQuestion.Text = "TIME'S UP!!";
                lblQuestion.ForeColor = Color.Red;
                AnswerButtonsDisable();
                btnNext.Visible = true;
                lblAnswer.Visible = true;
                // If the question hasn't been answered treat it as incorrect
                // Show out of time message and stop player from answering
                // TO DO
            }
        }
    }
}
/**/