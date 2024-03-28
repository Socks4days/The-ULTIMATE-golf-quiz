using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_ULTIMATE_golf_quiz
{
    // Admin - Add Questions
    public partial class frmAddQuestions : Form
    {
        private int difficulty;
        public frmAddQuestions()
        {
            InitializeComponent();

            // Display panel to select the type of question to add
            selectQuestionType();

            // Read in all the questions again without deleting those answered by the player
            QuestionFileHandler.ReadInAllQuestions();
        }
        
        // Show the select question type panel and hide other panels
        private void selectQuestionType()
        {
            pnlChooseQuestionType.Visible = true;
            pnlQuestion.Visible = false;
            pnlAnswerTypeIt.Visible = false;
            pnlAnswerTrueOrFalse.Visible = false;
            pnlAnswerMulti.Visible = false;
            pnlWhereInTheWorld.Visible = false;
            pnlDiffPointsAdd.Visible = false;
            pctBoxLocation.Visible = false;
            pnlAddWhereInTheWorld.Visible = false;
        }

        // If back arrow clicked, warn user if they are adding a question and return to main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            // If showing the choose question type panel, just exit
            if (pnlChooseQuestionType.Visible)
            {
                this.Close();
            }
            // Otherwise warn they user their new question won't be saved
            else
            {
                DialogResult result = MessageBox.Show("Your question will not be saved!\nDo you wish to leave?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)                
                    selectQuestionType(); 
            }
        }    
        
        // Method to map difficulty radio buttons to difficulty level
        private void Difficulty()
        {
            difficulty = 0;
            if (rBtnEasy.Checked)
            {
                difficulty = 1;
            }
            else if (rBtnMedium.Checked)
            {
                difficulty = 2;
            }
            else if (rBtnHard.Checked)
            {
                difficulty = 3;
            }
            else if (rBtnAImpossible.Checked)
            {
                difficulty = 4;
            }
            else if (rBtnTImpossible.Checked)
            {
                difficulty = 5;
            }
        }
        
        // Clear question details
        private void resetQuestion()
        {
            // Reset input form
            rBtnEasy.Checked = false;
            rBtnMedium.Checked = false;
            rBtnHard.Checked = false;
            rBtnAImpossible.Checked = false;
            rBtnTImpossible.Checked = false;
            txtBoxQuestion.Text = "";
            txtBoxTypeItAnswer.Text = "";
            nUDPoints.Value = 1;
            this.ActiveControl = txtBoxQuestion;
            pctBoxLocation.Visible = false;
            txtBoxMultiOption1.Text = "";
            txtBoxMultiOption2.Text = "";
            txtBoxMultiOption3.Text = "";
            txtBoxMultiOption4.Text = "";
            rBtnOption1.Checked = false;
            rBtnOption2.Checked = false;
            rBtnOption3.Checked = false;
            rBtnOption4.Checked = false;
            rBtnTrue.Checked = false;
            rBtnFalse.Checked = false;
            pctBoxImageUploaded.Image = null;
        }
        
        //----------------------------------------------------------------------------
        // Add question button clicked
        private string questionToAddType { get; set; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check all details entered for the selected question type
            // then save to the correct question file
            switch (questionToAddType)
            {
                //--------------------------------------------------------------------
                // Add Type It question
                case "Type It":
                    // Get the next question number and check it hasn't already been used
                    bool uniqueIdFound = false;
                    int nextQuestionNumberTypeIt = QuestionFileHandler.TypeItQuestions.Count + 1;
                    string questionId = "";
                    while (!uniqueIdFound)
                    {
                        // Add question prefix to number and pad with zeros
                        questionId = "TI" + nextQuestionNumberTypeIt.ToString("D2");
                        
                        // If it's already used, add one and check again
                        if (QuestionFileHandler.TypeItQuestions.FirstOrDefault(item => item.Id == questionId) != null)
                        {
                            // A question with that id already exists, so try the next one
                            nextQuestionNumberTypeIt++;
                        }
                        else
                        {
                            // The id hasn't been used, stop looking
                            uniqueIdFound = true;
                        }
                    }
                    
                    // Set the question details and the save it to the CSV file
                    TypeItQuestion typeItQuestionToAdd = new TypeItQuestion();
                    typeItQuestionToAdd.Id = questionId;
                    typeItQuestionToAdd.Question = txtBoxQuestion.Text;
                    typeItQuestionToAdd.CorrectAnswer = txtBoxTypeItAnswer.Text;
                    typeItQuestionToAdd.Points = Convert.ToInt32(nUDPoints.Value);
                    Difficulty();
                    typeItQuestionToAdd.Difficulty = difficulty;
                    if (typeItQuestionToAdd.Question != "" && typeItQuestionToAdd.CorrectAnswer != "" && typeItQuestionToAdd.Difficulty != 0)
                    {
                        QuestionFileHandler.TypeItQuestions.Add(typeItQuestionToAdd);
                        QuestionFileHandler.SaveAllTypeItQuestions();
                        resetQuestion();
                        questionSuccessfullyAdded();
                    }
                    else
                    {
                        questionUnsuccessfullyAdded();
                    }
                    break;

                //--------------------------------------------------------------------
                // Add True or False question
                case "True or False":
                    // Get the next question number and check it hasn't already been used
                    bool uniqueIdFoundTF = false;
                    int nextQuestionNumberTf = QuestionFileHandler.TrueOrFalseQuestions.Count + 1;
                    string questionIdTF = "";
                    while (!uniqueIdFoundTF)
                    {
                        // Add question prefix to number and pad with zeros
                        questionIdTF = "TF" + (QuestionFileHandler.TrueOrFalseQuestions.Count + 1).ToString("D2");

                        // If it's already used, add one and check again
                        if (QuestionFileHandler.TrueOrFalseQuestions.FirstOrDefault(item => item.Id == questionIdTF) != null)
                        {
                            // A question with that id already exists, so try the next one
                            nextQuestionNumberTf++;
                        }
                        else
                        {
                            // The id hasn't been used, stop looking
                            uniqueIdFoundTF = true;
                        }
                    }
                    
                    // Set the question details and the save it to the CSV file
                    TrueOrFalseQuestion trueOrFalseQuestionToAdd = new TrueOrFalseQuestion();
                    trueOrFalseQuestionToAdd.Id = questionIdTF;
                    trueOrFalseQuestionToAdd.Question = txtBoxQuestion.Text;
                    if (rBtnTrue.Checked)
                        trueOrFalseQuestionToAdd.CorrectAnswer = "1";
                    else if (rBtnFalse.Checked)
                        trueOrFalseQuestionToAdd.CorrectAnswer = "0";
                    else
                        trueOrFalseQuestionToAdd.CorrectAnswer = "";
                    trueOrFalseQuestionToAdd.Points = Convert.ToInt32(nUDPoints.Value);
                    Difficulty();
                    trueOrFalseQuestionToAdd.Difficulty = difficulty;
                    if (trueOrFalseQuestionToAdd.Question != "" && trueOrFalseQuestionToAdd.CorrectAnswer != "" && trueOrFalseQuestionToAdd.Difficulty != 0)
                    {
                        QuestionFileHandler.TrueOrFalseQuestions.Add(trueOrFalseQuestionToAdd);
                        QuestionFileHandler.SaveAllTrueOrFalseQuestions();
                        resetQuestion();
                        questionSuccessfullyAdded();
                    }
                    else
                    {
                        questionUnsuccessfullyAdded();
                    }
                    break;

                //--------------------------------------------------------------------
                // Add Multiple Choice question
                case "Multiple Choice":
                    // Get the next question number and check it hasn't already been used
                    bool uniqueIdFoundMc = false;
                    int nextQuestionNumberMc = QuestionFileHandler.MultiChoiceQuestions.Count + 1;
                    string questionIdMc = "";
                    while (!uniqueIdFoundMc)
                    {
                        // Add question prefix to number and pad with zeros
                        questionIdMc = "MC" + (nextQuestionNumberMc).ToString("D2");

                        // If it's already used, add one and check again
                        if (QuestionFileHandler.MultiChoiceQuestions.FirstOrDefault(item => item.Id == questionIdMc) != null)
                        {
                            // A question with that id already exists, so try the next one
                            nextQuestionNumberMc++;
                        }
                        else
                        {
                            // The id hasn't been used, stop looking
                            uniqueIdFoundMc = true;
                        }
                    }

                    // Set the question details and the save it to the CSV file
                    MultiChoiceQuestion multiChoiceQuestionToAdd = new MultiChoiceQuestion();
                    multiChoiceQuestionToAdd.Id = questionIdMc;
                    multiChoiceQuestionToAdd.Question = txtBoxQuestion.Text;
                    if (rBtnOption1.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption1.Text;
                    else if (rBtnOption2.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption2.Text;
                    else if (rBtnOption3.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption3.Text;
                    else if (rBtnOption4.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption4.Text;
                    else
                        multiChoiceQuestionToAdd.CorrectAnswer = "";
                    multiChoiceQuestionToAdd.Points = Convert.ToInt32(nUDPoints.Value);
                    Difficulty();
                    multiChoiceQuestionToAdd.Difficulty = difficulty;
                    multiChoiceQuestionToAdd.Option1 = txtBoxMultiOption1.Text;
                    multiChoiceQuestionToAdd.Option2 = txtBoxMultiOption2.Text;
                    multiChoiceQuestionToAdd.Option3 = txtBoxMultiOption3.Text;
                    multiChoiceQuestionToAdd.Option4 = txtBoxMultiOption4.Text;
                    if (multiChoiceQuestionToAdd.Question != "" && multiChoiceQuestionToAdd.CorrectAnswer != "" && multiChoiceQuestionToAdd.Difficulty != 0 &&
                        multiChoiceQuestionToAdd.Option1 != "" && multiChoiceQuestionToAdd.Option2 != "" && multiChoiceQuestionToAdd.Option3 != "" && multiChoiceQuestionToAdd.Option4 != "" )
                    {
                        QuestionFileHandler.MultiChoiceQuestions.Add(multiChoiceQuestionToAdd);
                        QuestionFileHandler.SaveAllMultiChoiceQuestions();
                        resetQuestion();
                        questionSuccessfullyAdded();
                    }
                    else
                    {
                        questionUnsuccessfullyAdded();
                    }

                    break;
                    
                //--------------------------------------------------------------------
                // Add Picture Round question
                case "Picture":
                    // Get the next question number and check it hasn't already been used
                    bool uniqueIdFoundPc = false;
                    int nextQuestionNumberPc = QuestionFileHandler.PictureQuestions.Count + 1;
                    string questionIdPc = "";
                    while (!uniqueIdFoundPc)
                    {
                        // Add question prefix to number and pad with zeros
                        questionIdPc = "PC" + (nextQuestionNumberPc).ToString("D2");

                        // If it's already used, add one and check again
                        if (QuestionFileHandler.MultiChoiceQuestions.FirstOrDefault(item => item.Id == questionIdPc) != null)
                        {
                            // A question with that id already exists, so try the next one
                            nextQuestionNumberPc++;
                        }
                        else
                        {
                            // The id hasn't been used, stop looking
                            uniqueIdFoundPc = true;
                        }
                    }

                    // Set the question details and the save it to the CSV file
                    WhereInTheWorld pictureQuestionToAdd = new WhereInTheWorld();
                    pictureQuestionToAdd.Id = questionIdPc;
                    pictureQuestionToAdd.Question = txtBoxQuestion.Text;
                    pictureQuestionToAdd.CorrectAnswer = txtBoxTypeItAnswer.Text;
                    pictureQuestionToAdd.Points = Convert.ToInt32(nUDPoints.Value);
                    Difficulty();
                    pictureQuestionToAdd.Difficulty = difficulty;
                    pictureQuestionToAdd.CorrectLocationX = x;
                    pictureQuestionToAdd.CorrectLocationY = y;
                    pictureQuestionToAdd.PictureId = "FILEPATH" + selectedImageFilePath;
                    if (pictureQuestionToAdd.Question != "" && pictureQuestionToAdd.CorrectAnswer != "" && pictureQuestionToAdd.Difficulty != 0 && pictureQuestionToAdd.CorrectLocationX !=0)
                    {
                        QuestionFileHandler.PictureQuestions.Add(pictureQuestionToAdd);
                        QuestionFileHandler.SaveAllPictureQuestions();
                        resetQuestion();
                        questionSuccessfullyAdded();
                    }
                    else
                    {
                        questionUnsuccessfullyAdded();
                    }
                    break;
            }           
        }

        //--------------------------------------------------------------------------------
        // Select question type buttons
        //--------------------------------------------------------------------------------
        // Select question type - Type It button clicked
        private void btnTypeIt_Click(object sender, EventArgs e)
        {
            questionToAddType = "Type It";
            setup();
        }

        // Select question type - True or False button clicked
        private void btnTrueOrFalse_Click(object sender, EventArgs e)
        {
            questionToAddType = "True or False";
            setup();
        }

        // Select question type - Multiple Choice button clicked
        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            questionToAddType = "Multiple Choice";
            setup();
        }

        // Select question type - Picture Round button clicked
        private void btnPicture_Click(object sender, EventArgs e)
        {
            questionToAddType = "Picture";
            setup();
        }
        
        // Show the right panels for the selected question type
        private void setup()
        {
            // Hide the choose question type panel, show the shared panels
            pnlChooseQuestionType.Visible = false;
            pnlQuestion.Visible = true;
            pnlQuestion.SendToBack();
            pnlTitleMenu.SendToBack();
            
            // Show the specific panels needed for each question type
            switch(questionToAddType)
            {
                case "Type It":
                    pnlAnswerTypeIt.Visible = true;
                    pnlDiffPointsAdd.BringToFront();
                    break;
                case "True or False":
                    pnlAnswerTrueOrFalse.Visible = true;
                    pnlDiffPointsAdd.BringToFront();
                    break;
                case "Multiple Choice":
                    pnlAnswerMulti.Visible = true;
                    pnlDiffPointsAdd.BringToFront();
                    break;
                case "Picture":
                    pnlWhereInTheWorld.Visible = true;
                    pnlAnswerTypeIt.Visible = true; 
                    pnlAddWhereInTheWorld.Visible = true;
                    pnlDiffPointsAdd.BringToFront();
                    break;
                default: break;
            }
            this.ActiveControl = txtBoxQuestion;
            pnlDiffPointsAdd.Visible = true;
        }
        
        // Message boxes
        private void questionSuccessfullyAdded()
        {
            MessageBox.Show("Question successfully added");
        }
        private void questionUnsuccessfullyAdded()
        {
            MessageBox.Show("You are missing parts of the question that are required\nPlease fill them in to add your question");
        }

        //-----------------------------------------------------------------------
        // Picture round - save location when user clicks on the map
        int x = 0;
        int y = 0;
        private void pctBoxMap_Click(object sender, EventArgs e)
        {
            // Show location marker and move to where the user clicked
            pctBoxLocation.Visible = true;
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int mapX = pctBoxMap.Location.X;
            int mapY = pctBoxMap.Location.Y;
            pctBoxLocation.Location = new Point(mapX + mouseEvent.X - (pctBoxLocation.Width / 2), mapY + mouseEvent.Y - pctBoxLocation.Height);

            // Get location selected and convert it to between 0-1000 to handle different screen sizes
            x = (1000 * mouseEvent.X) / pctBoxMap.Width;
            y = (1000 * mouseEvent.Y) / pctBoxMap.Height;
        }

        //-----------------------------------------------------------------------
        // Picture round - allow user to select an image file for the question picture
        string selectedImageFilePath = "";
        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadImage = new OpenFileDialog();

            // Set the filter to allow only image files
            uploadImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (uploadImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the picturebox 
                    pctBoxImageUploaded.Image = Image.FromFile(uploadImage.FileName);        
                    selectedImageFilePath = uploadImage.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ShowError: Could not read your file. ShowError: " + ex.Message);
                }
            }
        }
    }
}