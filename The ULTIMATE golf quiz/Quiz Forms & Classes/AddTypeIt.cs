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
    public partial class frmAddQuestions : Form
    {
        private int difficulty;
        public frmAddQuestions()
        {
            InitializeComponent();           
            selectQuestionType();

            // Read in all the questions again without deleting those answered by the player
            QuestionFileHandler.ReadInAllQuestions();
        }
        private void selectQuestionType()
        {
            pnlChooseQuestionType.Visible = true;
            pnlQuestion.Visible = false;
            pnlAnswerTypeIt.Visible = false;
            pnlAnswerTrueOrFalse.Visible = false;
            pnlAnswerMulti.Visible = false;
            pnlPicture.Visible = false;
            pnlDiffPointsAdd.Visible = false;
            pctBoxLocation.Visible = false;
            pnlAddPicture.Visible = false;
        }

        private string questionToAddType { get; set; }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (pnlChooseQuestionType.Visible)
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Your question will not be saved!\nDo you wish to leave?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)                
                    selectQuestionType(); 
            }
        }    
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
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (questionToAddType)
            {
                case "Type It":
                    TypeItQuestion typeItQuestionToAdd = new TypeItQuestion();
                    typeItQuestionToAdd.Question = txtBoxQuestion.Text;
                    typeItQuestionToAdd.CorrectAnswer = txtBoxTypeItAnswer.Text;
                    typeItQuestionToAdd.Id = "TI" + (QuestionFileHandler.TypeItQuestions.Count + 1).ToString("D2");
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

                case "True or False":
                    TrueOrFalseQuestion trueOrFalseQuestionToAdd = new TrueOrFalseQuestion();
                    trueOrFalseQuestionToAdd.Question = txtBoxQuestion.Text;
                    if (rButtonTrue.Checked)
                        trueOrFalseQuestionToAdd.CorrectAnswer = "1";
                    else if (rButonFalse.Checked)
                        trueOrFalseQuestionToAdd.CorrectAnswer = "0";
                    else
                        trueOrFalseQuestionToAdd.CorrectAnswer = "";
                    trueOrFalseQuestionToAdd.Id = "TF" + (QuestionFileHandler.TrueOrFalseQuestions.Count + 1).ToString("D2");
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
                case "Multiple Choice":
                    MultiChoiceQuestion multiChoiceQuestionToAdd = new MultiChoiceQuestion();
                    multiChoiceQuestionToAdd.Question = txtBoxQuestion.Text;
                    if (radioButtonOption1.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption1.Text;
                    else if (radioButtonOption2.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption2.Text;
                    else if (radioButtonOption3.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption3.Text;
                    else if (radioButtonOption4.Checked)
                        multiChoiceQuestionToAdd.CorrectAnswer = txtBoxMultiOption4.Text;
                    else
                        multiChoiceQuestionToAdd.CorrectAnswer = "";
                    multiChoiceQuestionToAdd.Id = "MC" + (QuestionFileHandler.MultiChoiceQuestions.Count + 1).ToString("D2");
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
                case "Picture":
                    PictureQuestion pictureQuestionToAdd = new PictureQuestion();
                    pictureQuestionToAdd.Question = txtBoxQuestion.Text;
                    pictureQuestionToAdd.CorrectAnswer = txtBoxTypeItAnswer.Text;
                    pictureQuestionToAdd.Id = "PC" + (QuestionFileHandler.PictureQuestions.Count + 1).ToString("D2");
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

        private void btnTypeIt_Click(object sender, EventArgs e)
        {
            questionToAddType = "Type It";
            setup();
        }

        private void btnTrueOrFalse_Click(object sender, EventArgs e)
        {
            questionToAddType = "True or False";
            setup();
        }

        private void btnMultipleChoice_Click(object sender, EventArgs e)
        {
            questionToAddType = "Multiple Choice";
            setup();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            questionToAddType = "Picture";
            setup();
        }
        private void setup()
        {
            pnlChooseQuestionType.Visible = false;
            pnlQuestion.Visible = true;
            pnlQuestion.SendToBack();
            pnlTitleMenu.SendToBack();
            
           
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
                    pnlPicture.Visible = true;
                    pnlAnswerTypeIt.Visible = true; 
                    pnlAddPicture.Visible = true;
                    pnlDiffPointsAdd.BringToFront();
                    break;
                default: break;
            }
            this.ActiveControl = txtBoxQuestion;
            pnlDiffPointsAdd.Visible = true;
        }
        private void questionSuccessfullyAdded()
        {
            MessageBox.Show("Question successfully added");
        }
        private void questionUnsuccessfullyAdded()
        {
            MessageBox.Show("You are missing parts of the question that are required\nPlease fill them in to add your question");
        }

        int x = 0;
        int y = 0;
        private void pctBoxMap_Click(object sender, EventArgs e)
        {
            pctBoxLocation.Visible = true;
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int mapX = pctBoxMap.Location.X;
            int mapY = pctBoxMap.Location.Y;

            pctBoxLocation.Location = new Point(mapX + mouseEvent.X - (pctBoxLocation.Width / 2), mapY + mouseEvent.Y - pctBoxLocation.Height);

            // Get location selected (convert map panel width to 0-1000 range)
            x = (1000 * mouseEvent.X) / pctBoxMap.Width;
            y = (1000 * mouseEvent.Y) / pctBoxMap.Height;

        }
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
                    MessageBox.Show("Error: Could not read your file. Error: " + ex.Message);
                }
            }
        }
    }
}