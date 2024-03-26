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
using System.IO;

namespace The_ULTIMATE_golf_quiz
{
    // Open the quiz form
    public partial class frmQuizQuestions : Form
    {
        #region Properties
        // score and points for this round
        public int TotalScoreForCurrentRound { get; set; }
        public int NumberOfQuestionsAnsweredCorrectly { get; set; }
        private int NumberOfQuestionsAskedThisRound { get; set; }
        private int TotalPointsAvailable { get; set; }

        // choose the right club properties
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
        // Properties for question lists loaded in from CSV files
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
        // Submit the answer or go to the next question when the users hits Enter
        bool enterKeyPressed = false;
        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (enterKeyPressed == false)
                    {
                        // If the user is entering the answer, submit it when they hit enter
                        if (txtBoxAnswer.Enabled == true)
                        {
                            btnSubmit_Click(sender, e);
                            enterKeyPressed = true;
                        }
                        // If the Next button is shown, go to the next question when they hit enter
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
        // Disable the answer buttons when the user has answered the question
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
        // Enable the answer buttons when the user goes to the next question
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

        #region Music
        System.Media.SoundPlayer backgroundMusicPlayer = new System.Media.SoundPlayer();
        System.Media.SoundPlayer countdownPlayer = new System.Media.SoundPlayer();

        // Play background music
        private void startMusicPlayer()
        {
            backgroundMusicPlayer.PlayLooping();
        }
        // Stop background music
        private void stopMusicPlayer()
        {
            backgroundMusicPlayer.Stop();
        }
        // Start countdown music for question timer
        private void startCountdown()
        {
            countdownPlayer.Play();
        }
        // Stop countdown music
        private void stopCountdown()
        {
            countdownPlayer.Stop();
        }
        #endregion Music

        // Set up when the quiz form is first created
        public frmQuizQuestions()
        {
            // start the music while selecting the round
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

       
        #region Initialisation
        private void frmQuizQuestions_Load(object sender, EventArgs e)
        {
            // set up for the start of each round)
            frmQuizQuestionsInitialisation();
        }
        
        // Set up at the start of every round
        private void frmQuizQuestionsInitialisation()
        {
            // Hide all the question panels
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

            // Check the player hasn't answered all the questions for any of the rounds
            if (QuestionFileHandler.TypeItQuestions.Count > 0)
                questionTypes.Add("Type It");
            if (QuestionFileHandler.TrueOrFalseQuestions.Count > 0)
                questionTypes.Add("True or False");
            if (QuestionFileHandler.MultiChoiceQuestions.Count > 0)
                questionTypes.Add("Multiple Choice");
            if (QuestionFileHandler.PictureQuestions.Count > 0)
                questionTypes.Add("Picture");
            questionTypes.Add("Choose Club");

            // Show the panel to select the type of round
            pnlTypeOfRound.Dock = DockStyle.Fill;
            pnlTypeOfRound.Visible = true;
        }
        #endregion Initialisation

        #region RoundTypeButtonClicks
        // Start a type it round
        private void btnTypeItRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Type It";
            setup();
        }

        // Start a true or false round
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

        // Start a multiple choice round
        private void btnMultipleChoiceRound_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Multiple Choice";
            setup();
        }

        // Start choose the right club round (originally named drag and drop)
        private void btnChooseTheRightClub_Click(object sender, EventArgs e)
        {
            QuestionFileHandler.RoundType = "Choose Club";
            setup();
        }

        // Pick a round randomly for the user
        private void btnSurpriseMeRound_Click(object sender, EventArgs e)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            QuestionFileHandler.RoundType = questionTypes[random.Next(0, questionTypes.Count)];
            setup();
        }
        #endregion RoundTypeButtonClicks

        #region SetupForRound
        // Start a new round
        private void setup()
        {
            // Hide the select round type panel
            pnlTypeOfRound.Dock = DockStyle.None;
            pnlTypeOfRound.Visible = false;

            // Show the question and answer panels and dock them to top/bottom
            pnlQuestion.Visible = true;
            pnlAnswer.Visible = true;
            pnlQuestion.Dock = DockStyle.Top;
            pnlAnswer.Dock = DockStyle.Bottom;
            btnNext.Visible = false;
            
            // Now get the first question
            GetQuestion();
        }
        #endregion SetupForRound

        #region GetQuestion 

        private bool pictureQuestionAnswered = false;
        private int flagPositionX = 0;
        private int ballPositionX = 0;

        // Get the next question
        public void GetQuestion()
        {
            // Hide question panels and question answer
            pnlMultipleChoiceOptions.Visible = false;
            pnlTrueOrFalseOptions.Visible = false;
            pnlTypeIt.Visible = false;
            pctBoxPicture.Visible = false;
            lblAnswer.Visible = false;
            lblQuestion.ForeColor = Color.White;
            
            // Seed random number generator with a unique guid to ensure question order is correctly randomised
            Random random = new Random(Guid.NewGuid().GetHashCode());

            // If the amount of questions asked this round is less than 5 then it will ask another question
            if (NumberOfQuestionsAskedThisRound < 5)
            {
                // Start the countdown at 30 seconds
                countdown = 30 * 10;
                progressBarCountdown.Maximum = countdown;
                tmrCountdown.Start();
                startCountdown();
                
                // Show the panels relevant to the selected round type
                switch (QuestionFileHandler.RoundType)
                {
                    case "Type It":
                        // if the amount of type it questions in the list is more than 0, ie its not empty, then it will ask another question
                        if (typeItQuestionList.Count > 0)
                        {
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of type it questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.TypeItQuestions.Count);
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
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.TrueOrFalseQuestions.Count);

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

                    case "Multiple Choice":
                        if (multipleChoiceQuestionList.Count > 0)
                        {
                            // sets a variable equal to a number between 0 and the total amount of questions in the list of multi choice questions
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.MultiChoiceQuestions.Count);
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
                            int randomisedQuestionNumber = random.Next(0, QuestionFileHandler.PictureQuestions.Count);
                            PictureQuestion currentPictureQuestion = QuestionFileHandler.PictureQuestions[randomisedQuestionNumber];
                            // sets the current question equal to the base question with the randomised index
                            currentPictureQuestion1 = currentPictureQuestion;
                            // if the current questions' id equals a question in the lists' id, then the question will be displayed

                            // Question preparation
                            lblQuestion.Text = currentPictureQuestion.Question;

                            if (currentPictureQuestion.PictureId.Contains("FILEPATH"))
                            {
                                try
                                {
                                    // Load the selected image into the picturebox 
                                    pctBoxPicture.Image = Image.FromFile(currentPictureQuestion.PictureId.Replace("FILEPATH",""));
                                }
                                catch (FileNotFoundException fnf)
                                {
                                    MessageBox.Show("ShowError: Could not find your file from " + currentPictureQuestion.PictureId.Replace("FILEPATH", "") + "\nError: " + fnf.Message);
                                }
                            }
                            else
                            {
                                pctBoxPicture.Image = (Image)Properties.Resources.ResourceManager.GetObject(currentPictureQuestion.PictureId);
                            }

                            this.ActiveControl = btnOption1;
                            lblDifficulty.Text = "Difficulty: " + BaseQuestion.DifficultyLevels[currentPictureQuestion.Difficulty];
                           // TotalPointsAvailable += currentPictureQuestion.Points;
                            NumberOfQuestionsAskedThisRound++;

                            // Show MultipleChoce and Picture panels
                            //pnlMultipleChoiceOptions.Visible = true;
                            pctBoxPicture.Visible = true;
                            pnlPicture.Visible = true;
                            pnlPicture.Dock = DockStyle.Fill;
                            lblAnswer.Text = "Click a point on the map to select the location of the answer";
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

                        // Display the panels
                        pnlChooseTheRightClub.Visible = true;
                        pnlGrass.Visible = true;
                        pnlChooseTheRightClub.Dock = DockStyle.Fill;

                        // Set the starting point for the ball
                        sx = 0;
                        sy = 0;
                        
                        // Set the target distance to the flag
                        distanceToHoleYds = random.Next(10, 330);

                        // Default scale to convert yards to pixels is 2 for window of width 740 (default)
                        // Increase the scale if the window is larger
                        ydsToPixelsScale = Math.Max (2, 2 * pnlChooseTheRightClub.Width / 740);

                        // Move the grass panel so it always appears at the bottom of the window and is the full width
                        // when the window size is changed
                        pnlGrass.Width = pnlChooseTheRightClub.Width;
                        pnlGrass.Location = new Point(pnlGrass.Location.X, pnlChooseTheRightClub.Height - pnlGrass.Height);

                        // Reset the Y position of the flag and ball to the bottom of the 'choose the right club' panel
                        flagStartY = pnlChooseTheRightClub.Height - pnlGrass.Height - pctBoxFlag.Height + 10;
                        ballStartY = pnlChooseTheRightClub.Height - pnlGrass.Height - pctBoxGolfBall.Height;
                        ballX = ballStartX;
                        ballY = ballStartY;

                        // Move the X position of the flag to the random distance selected scaling to fit the window
                        flagPositionX = ballStartX + distanceToHoleYds * ydsToPixelsScale;
                        pctBoxFlag.Location = new Point(flagPositionX - (pctBoxFlag.Width / 2), flagStartY);

                        // Set up the question details
                        lblQuestion.Text = ("Choose the club you think will get you closest to the hole. Click Go to start the power meter then Stop to take your shot!");
                        lblDifficulty.Text = "Difficulty: Medium";
                        lblDistanceToHole.Text = "Distance to hole: " + distanceToHoleYds + " yards";
                        pctBoxGolfBall.Location = new Point(ballStartX - (pctBoxGolfBall.Width / 2), ballStartY);

                        NumberOfQuestionsAskedThisRound++;

                        // Calculate the wind speed and direction and show the right flag image
                        Random windSpeedRnd = new Random();
                        windSpeed = windSpeedRnd.Next(-25,25);
                        if (windSpeed >= 15) // strong wind to right
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagRight");
                        else if ( windSpeed <= -15) // strong wind to left
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagLeft");
                        else if (windSpeed < -5) // gentle wind to left
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagLeftWeak");
                        else if ( windSpeed > 5) // gentle wind to right
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagRightWeak");
                        else // no wind
                            pctBoxFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("FlagNone");
                        pctBoxFlag.BackColor = Color.Transparent;
                        lblWindSpeed.Text = "Wind Speed: " + Math.Abs(windSpeed);

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

                // show the question number
                lblQuestionNumber.Text = QuestionFileHandler.RoundType + " " + NumberOfQuestionsAskedThisRound.ToString() + "/5";
            }
            else
            {
                
                // if the user has been asked their 5 questions, then they will be shown the finish panel
                RoundFinishedScreen();
            }                                          
        }
        #endregion GetQuestion

        #region QuizAnswerButtonClicks
        //-------------------------------------------------------------------------------------------------------
        // Type It - Submit button clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Stop the timer
            tmrCountdown.Stop(); 
            stopCountdown();
            
            // Disable the answer buttons, show the answer details and next button
            this.ActiveControl = btnNext;
            lblAnswer.Visible = true;
            QuestionFileHandler.TypeItQuestions.Remove(currentTypeItQuestion1);
            AnswerButtonsDisable();
            pnlAnswer.Visible = true;
            btnNext.Visible = true;
            txtBoxAnswer.Enabled = false;
            
            // Check the answer (ignoring case)
            if (txtBoxAnswer.Text.ToLower() == currentTypeItQuestion1.CorrectAnswer.ToLower())
            {
                // Correct - increase the score and number of correct answers
                // Save the id of the question so it doesn't get asked again and mark it as correct
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound += currentTypeItQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentTypeItQuestion1, true);
            }
            else
            {
                // Incorrect - tell the player the correct answer
                // Save the id of the question so it doesn't get asked again and mark it as incorrect
                lblAnswer.Text = "Incorrect, the answer is " + currentTypeItQuestion1.CorrectAnswer;
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentTypeItQuestion1, false);
            }
        }

        //---------------------------------------------------------------------------------------------------------
        // True or False - True button clicked
        private void btnTrue_Click(object sender, EventArgs e)
        {
            // Stop the timer
            tmrCountdown.Stop();
            stopCountdown();

            // Disable the answer buttons, show the answer details and next button
            pnlAnswer.Visible = true;
            AnswerButtonsDisable(); 
            lblAnswer.Visible = true;
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            
            // Check the answer
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "1")
            {
                // Correct - increase the score and number of correct answers
                // Save the id of the question so it doesn't get asked again and mark it as correct
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound += currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentTrueOrFalseQuestion1, true);
            }
            else
            {
                // Incorrect - tell the player the correct answer
                // Save the id of the question so it doesn't get asked again and mark it as incorrect
                lblAnswer.Text = "Incorrect, it's false";
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentTrueOrFalseQuestion1, false);
            }
        }

        // True or False - False button clicked
        private void btnFalse_Click(object sender, EventArgs e)
        {
            // Stop the timer
            tmrCountdown.Stop();
            stopCountdown();
            
            // Disable the answer buttons, show the answer details and next button
            pnlAnswer.Visible = true;
            lblAnswer.Visible = true;
            AnswerButtonsDisable();
            QuestionFileHandler.TrueOrFalseQuestions.Remove(currentTrueOrFalseQuestion1);
            btnNext.Visible = true;
            this.ActiveControl = btnNext;
            
            // Check the answer
            if (currentTrueOrFalseQuestion1.CorrectAnswer == "0")
            {
                // Correct - increase the score and number of correct answers
                // Save the id of the question so it doesn't get asked again and mark it as correct
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound += currentTrueOrFalseQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentTrueOrFalseQuestion1, true);

            }
            else
            {
                // Incorrect - tell the player the correct answer
                // Save the id of the question so it doesn't get asked again and mark it as incorrect
                lblAnswer.Text = "Incorrect, it's true";
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentTrueOrFalseQuestion1, false);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------
        // Multiple Choice - option 1 clicked
        private void btnOption1_Click(object sender, EventArgs e)
        {
            checkMultipleChoiceAnswer(btnOption1.Text);
        }

        // Multiple Choice - option 2 clicked
        private void btnOption2_Click(object sender, EventArgs e)
        {
            checkMultipleChoiceAnswer(btnOption2.Text);
        }

        // Multiple Choice - option 3 clicked
        private void btnOption3_Click(object sender, EventArgs e)
        {
            checkMultipleChoiceAnswer(btnOption3.Text);
        }    

        // Multiple Choice - option 4 clicked
        private void btnOption4_Click(object sender, EventArgs e)
        {
            checkMultipleChoiceAnswer(btnOption4.Text);
        }
        
        // Multiple Choice - shared method to check if answer is correct
        private void checkMultipleChoiceAnswer(string answerSelected)
        {
            // Stop the timer
            tmrCountdown.Stop();
            stopCountdown();
            
            // Disable the answer buttons, show the answer details and next button
            pnlAnswer.Visible = true;
            AnswerButtonsDisable();
            lblAnswer.Visible = true;
            btnNext.Visible = true;
            this.ActiveControl = btnNext;

            // Check the answer
            QuestionFileHandler.MultiChoiceQuestions.Remove(currentMultipleChoiceQuestion1);
            if (currentMultipleChoiceQuestion1.CorrectAnswer == answerSelected)
            {
                // Correct - increase the score and number of correct answers
                // Save the id of the question so it doesn't get asked again and mark it as correct
                lblAnswer.Text = "Correct";
                TotalScoreForCurrentRound += currentMultipleChoiceQuestion1.Points;
                NumberOfQuestionsAnsweredCorrectly++;
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentMultipleChoiceQuestion1, true);
            }
            else
            {
                // Incorrect - tell the player the correct answer
                // Save the id of the question so it doesn't get asked again and mark it as incorrect
                lblAnswer.Text = "Incorrect, the answer is " + currentMultipleChoiceQuestion1.CorrectAnswer;
                UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentMultipleChoiceQuestion1, false);
            }
        }
        
        //-------------------------------------------------------------------------------------------------------------------
        // Picture Round - map clicked
        private void pctBoxMap_Click(object sender, EventArgs e)
        {
            // Check if the user has already clicked on the map
            if (!pictureQuestionAnswered)
            {
                // Stop the timer
                tmrCountdown.Stop();
                stopCountdown();
                
                QuestionFileHandler.PictureQuestions.Remove(currentPictureQuestion1);

                
                int mapX = pctBoxMap.Location.X;
                int mapY = pctBoxMap.Location.Y;

                // Work out where the user clicked on the map and move the location marker to that position
                MouseEventArgs mouseEvent = (MouseEventArgs)e;
                pctBoxLocation.Location = new Point(mapX + mouseEvent.X - (pctBoxLocation.Width / 2), mapY + mouseEvent.Y - pctBoxLocation.Height);

                // Convert the location clicked to a number between 0-1000 so the location is the same for all map sizes 
                int x = (1000 * mouseEvent.X) / pctBoxMap.Width;
                int y = (1000 * mouseEvent.Y) / pctBoxMap.Height;

                // Check if the player is close to the right answer (+/- 50)
                if (Math.Abs(currentPictureQuestion1.CorrectLocationX - x) <= 50
                    && Math.Abs(currentPictureQuestion1.CorrectLocationY - y) <= 50)
                {
                    // Correct - add points and save question as correct
                    lblAnswer.Text = String.Format("Correct! {0} ({1}, {2} )\nYou selected ({3}, {4})",
                        currentPictureQuestion1.CorrectAnswer, currentPictureQuestion1.CorrectLocationX, currentPictureQuestion1.CorrectLocationY, x, y);
                    NumberOfQuestionsAnsweredCorrectly++;
                    TotalScoreForCurrentRound += currentPictureQuestion1.Points;
                    UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentPictureQuestion1, true);

                }
                else
                {
                    // Incorrect - save question as incorrect
                    lblAnswer.Text = String.Format("No, {0} ({1}, {2} )\nYou selected ({3}, {4})",
                        currentPictureQuestion1.CorrectAnswer, currentPictureQuestion1.CorrectLocationX, currentPictureQuestion1.CorrectLocationY, x, y);
                    UserFileHandler.SavePlayerQuestionAnswered(frmSplashScreen.player, currentPictureQuestion1, false);

                }
                
                // Remember that user has already clicked on the map so they can't answer more than once
                // Show the answer
                pictureQuestionAnswered = true;
                AnswerButtonsDisable();
                pctBoxLocation.Visible = true;
                pnlAnswer.Visible = true;
                lblAnswer.Visible = true;
                btnNext.Visible = true;
                TotalPointsAvailable += currentPictureQuestion1.Points;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------
        // Choose the Right Club - Go/Stop button clicked
        private int ballX = 0;
        private int ballY = 0;
        private double sx = 0;
        private double sy = 0;
        
        // Lookup with loft and max distance of each club
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

        private void btnChooseAClubGo_Click(object sender, EventArgs e)
        {
            // Check the player has selected a club
            string selectedClub = comboBoxChooseAClub.Text;
            if (selectedClub == "")
            {
                MessageBox.Show("You need to select a club first!");
                return;
            }

            // Stop the countdown timer
            tmrCountdown.Stop();
            stopCountdown();
            
            // If this is the first time the go button is clicked, start the power timer
            if (goButtonClickCount == 0)
            {
                // Reset/show the power progress bar and start the power meter
                progressBarPower.Value = progressBarPower.Minimum;
                progressBarPower.Visible = true;
                lblPower.Visible = true;
                tmrPower.Enabled = true;
                tmrPower.Start();
                goButtonClickCount = 1;
                btnChooseAClubGo.Text = "Stop!";
                return;
            }
            
            // Otherwise (second time go button clicked)
            // Stop the power meter, stop the countdown music, play the sound to hit the ball
            goButtonClickCount = 2;
            tmrPower.Stop();
            tmrPower.Enabled = false;
            stopMusicPlayer();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Golf Ball.wav";
            player.Load();
            player.Play();
                     
            // Get the power value selected by the player
            double powerSelected = progressBarPower.Value;

            // Animate ball moving to hole

            // s = (u * t) + 0.5 * (a * t * t)
            // assume no air fiction and no wind
            // sx = (u * cos(loft) * t) + 0.5 * (0 * t * t)
            // sy = (u * sin(loft) * t) + 0.5 * (g * t * t)

            // set value of gravity in yards per second (all distances in yards)
            const double metresToYards = 1.094;
            const double gravity = 9.81 * metresToYards;

            // get the position of the flag on panel
            int flagX = pctBoxFlag.Location.X;
            int flagY = pctBoxFlag.Location.Y;

            // start at (0,0)
            sx = 0;
            sy = 0;

            // Get loft and swing speed for selected club
            // Then calculate the distance that the ball will go
            // Look up loft based on club selected and convert to radians
            double loftInDegrees = clubLoftAndMaxDistanceYds[selectedClub].Item1;
            double loftInRadians = loftInDegrees * Math.PI / 180;
            // Look up the max distance for the selected club for a perfect shot with no wind
            double maxDistanceYds = clubLoftAndMaxDistanceYds[selectedClub].Item2;
            
            // Now calculate the actual distance and starting speed based on the power and wind
            double actualDistanceYds = 0;
            double swingSpeed = 0;
            double ux = 0;
            double uy = 0;
            
            // For putter, ignore wind speed and gravity
            if (selectedClub == "Putter")
            {
                // Actual distance is max distance times percentage power
                actualDistanceYds = maxDistanceYds * (powerSelected / 100);
                // base the speed of the putt on the distance (10 seconds for a 50 yard putt)
                ux = maxDistanceYds / 10;
            }
            // Otherwise adjust distance based on wind speed and direction - 1% for every 1 mph
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

            // Work out how long the shot will take based on distance divided by horizontal speed
            double timeBallInMotion = actualDistanceYds / ux;

            // Initialise starting time and interval for loop
            double timeInSecs = 0;
            double intervalInSecs = 0.1;

            // Set start position for ball
            ballX = ballStartX;
            ballY = ballStartY;

            // Animate the ball in intervals of 0.1 seconds
            while (timeInSecs < timeBallInMotion)
            {
                // Increment time
                timeInSecs += intervalInSecs;

                // Calculate horizontal (sx) and vertical (sy) position in metres
                // s = (u * t) + 0.5 * (a * t * t)
                sx = (ux * timeInSecs);

                // For putter, ignore height
                if (selectedClub == "Putter")
                {
                    sy = 0;
                }
                // For other clubs, use the formula
                else
                {
                    sy = (uy * timeInSecs) - (0.5 * gravity * timeInSecs * timeInSecs);
                }

                // Move the ball to the right position on the canvas
                // Scale the distance based on the size of the window
                // and add to the starting position of the ball
                ballX = ballStartX + (int)sx * ydsToPixelsScale;
                ballY = ballStartY - (int)sy * ydsToPixelsScale;

                pctBoxGolfBall.Location = new Point(ballX - (pctBoxGolfBall.Width / 2), ballY);

                // Wait interval seconds
                Thread.Sleep((int)(intervalInSecs * 100));
            }
           
            // When the ball lands get the final distance in yards
            // and calculate the distance to the hole
            int distanceTravelledinYards = (ballX - ballStartX) / ydsToPixelsScale;
            int distanceFromHoleYds = Math.Abs(distanceToHoleYds - distanceTravelledinYards);
            
            // Calculate the number of points based on how close the ball is to the hole
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
            
            // Stop the user from trying again and show the results
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
        // Button clicked to select the next question
        private void btnNext_Click(object sender, EventArgs e)
        {
            // When next is clicked, reset the question and answer details
            lblAnswer.Visible = false;
            btnNext.Visible = false;
            txtBoxAnswer.Text = "";
            enterKeyPressed = false;

            // Allow the user to answer again
            AnswerButtonsEnabled();

            // Check if there are any questions left for the selected round type
            // If so get the next question or else go to the finish screen
            // Type It
            if (QuestionFileHandler.RoundType == "Type It" && QuestionFileHandler.TypeItQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "Type It" && QuestionFileHandler.TypeItQuestions.Count == 0)
            {
                questionTypes.Remove("Type It");
                RoundFinishedScreen();
            }
            // True or False
            else if (QuestionFileHandler.RoundType == "True or False" && QuestionFileHandler.TrueOrFalseQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "True or False" && QuestionFileHandler.TrueOrFalseQuestions.Count == 0)
            {
                questionTypes.Remove("True or False");
                RoundFinishedScreen();
            }
            // Multiple choice
            else if (QuestionFileHandler.RoundType == "Multiple Choice" && QuestionFileHandler.MultiChoiceQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "Multiple Choice" && QuestionFileHandler.MultiChoiceQuestions.Count == 0)
            {
                questionTypes.Remove("Multiple Choice");
                RoundFinishedScreen();
            }
            // Picture Round
            else if (QuestionFileHandler.RoundType == "Picture" && QuestionFileHandler.PictureQuestions.Count > 0)
            {
                GetQuestion();
            }
            else if (QuestionFileHandler.RoundType == "Picture" && QuestionFileHandler.PictureQuestions.Count == 0)
            {
                questionTypes.Remove("Picture");
                RoundFinishedScreen();
            }
            // No need to check for Choose the Right Club as it generates the questions randomly
            else if (QuestionFileHandler.RoundType == "Choose Club")
                GetQuestion();
        }
        #endregion NextQuestionButtonClicked

        #region EndOfRound
        // When all 5 questions in the round are completed
        // or there are no more questions for the selected round type
        // show a summary of the round and the points scored
        private void RoundFinishedScreen()
        {
            // Stop the countdown
            // Hide the question and answer details, next button, etc
            // Show the finish panel
            stopCountdown();
            pnlAnswer.Visible = false;
            btnNext.Visible = false;
            pnlQuestion.Visible = false;
            pnlTypeIt.Visible = false;
            pnlTrueOrFalseOptions.Visible = false;
            pnlMultipleChoiceOptions.Visible = false;
            pnlChooseTheRightClub.Visible = false;
            pnlPicture.Visible = false;
            pnlFinish.Visible = true;
            pnlFinish.Dock = DockStyle.Fill;
            
            // Show the player how many questions they got right and their points
            lblQuestionsAnsweredCorrectly.Text = "You got " + NumberOfQuestionsAnsweredCorrectly + "/" + NumberOfQuestionsAskedThisRound + " questions correct!";
            lblTotalScore.Text = "You got " + TotalScoreForCurrentRound + "/" + TotalPointsAvailable + " points!";
            
            // Add the score for the round to the player's total score for this session
            frmSplashScreen.player.totalScoreForCurrentSession += TotalScoreForCurrentRound;
            frmSplashScreen.player.roundsPlayed++;

            // If the score is better than the player's high score, save their new highscore
            if (frmSplashScreen.player.totalScoreForCurrentSession > frmSplashScreen.player.highscore)
            {
                frmSplashScreen.player.highscore = frmSplashScreen.player.totalScoreForCurrentSession;
            }

            // Save player details and update title bar
            UserFileHandler.SaveAllPlayers();
            frmSplashScreen.mainMenu.setTitleLabels();
        }
        #endregion EndOfRound

        #region FinishMenuButtonClicks
        // Next found button clicked on finish panel
        // Start the quiz again with the select round type
        private void btnNextRound_Click(object sender, EventArgs e)
        {
            NumberOfQuestionsAskedThisRound = 0;
            frmQuizQuestionsInitialisation();
        }

        //-----------------------------------------------------------------
        // Finish session button clicked on finish panel
        // Exit the quiz and go back to the main menu
        private void btnFinishSession_Click(object sender, EventArgs e)
        {
            UserFileHandler.SaveAllPlayers();
            this.Close();
        }
        #endregion FinishMenuButtonClicks

        #region Exiting
        // Back arrow button clicked to stop in the middle of the question round
        // Warn the player they will lose their progress
        // and check they want to continue
        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Leaving will result in losing all your rounds' progress.\nDo you wish to leave? ", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Stop the countdown and exit the quiz
                stopCountdown();
                this.Close(); 
            }
        }

        // Back arrow button on select round type screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            stopCountdown();
            this.Close();
        }
        #endregion Exiting

        //-----------------------------------------------------------------
        // Timer events
        //-----------------------------------------------------------------
        // All question types - timer event for question countdown
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

        //-----------------------------------------------------------------
        // Choose the Right Club - timer event for power selector
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
                tmrPower.Stop();
                tmrPower.Enabled = false;                
                ticks = 0;
            }
        }

        //-----------------------------------------------------------------
        // Picture Round - enlarge/shrink picture when it is clicked
        private void pctBoxPicture_Click(object sender, EventArgs e)
        {
            // Toggle image zoom
            zoomPictureBox(!imageZoomed);
        }

        bool imageZoomed = false;
        int originalImageWidth = 140;
        int originalImageHeight = 140;

        // Method to resize picture box based on the size of the window
        private void zoomPictureBox(bool zoomImage)
        {
            if (zoomImage)
            {
                // Image zoomed in - move and resize
                // Scale image to 80% of the panel width/height (whichever is smaller), but no smaller than 140x140
                int newImageWidth = Math.Max(140, (int)(Math.Min(pnlPicture.Width, pnlPicture.Height) * 0.8));
                int newImageHeight = newImageWidth;

                pctBoxPicture.Size = new Size(newImageWidth, newImageHeight);
                pctBoxPicture.Location = new Point((pnlPicture.Width / 2) - (pctBoxPicture.Width / 2), (pnlPicture.Height / 2) - (pctBoxPicture.Height / 2));
                imageZoomed = true;
            }
            else
            {
                // Image not zoomed in - just change position to keep it in the top right
                pctBoxPicture.Size = new Size((originalImageWidth), (originalImageHeight));
                pctBoxPicture.Location = new Point(pnlPicture.Width - originalImageWidth - 20, 20);
                imageZoomed = false;
            }
        }

        //-----------------------------------------------------------------
        // Window resized event
        //-----------------------------------------------------------------
        // - Picture Round - resize/reposition picture to fit window
        // - Choose the Right Club - redraw grass, ball and flag to fit window
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

        //-----------------------------------------------------------------
        // Choose the Right Club - redraw grass, ball and flag when the
        // window is resized to fill the available space
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
    }
}
