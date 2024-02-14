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
        public frmAddQuestions()
        {
            InitializeComponent();
            //pnlTitleMenu.Dock = DockStyle.Top;
            //pnlChooseQuestionType.Dock = DockStyle.Fill;
            pnlChooseQuestionType.Visible = true;
            pnlQuestion.Visible = false;
            pnlAnswerTypeIt.Visible = false;
            pnlAnswerTrueOrFalse.Visible = false;
            pnlAnswerMulti.Visible = false;
            pnlPicture.Visible = false;
            pnlDiffPointsAdd.Visible = false;

            // Read in all the questions again without deleting those answered by the player
            QuestionFileHandler.ReadInAllQuestions();
        }

        private string questionToAddType { get; set; }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Your question will not be saved!\nDo you wish to leave?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                
            }
        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (questionToAddType)
            {
                case "Type It":
                    TypeItQuestion questionToAdd = new TypeItQuestion();
                    questionToAdd.Question = txtBoxQuestion.Text;
                    questionToAdd.CorrectAnswer = txtBoxTypeItAnswer.Text;
                    questionToAdd.Id = "TI" + (QuestionFileHandler.TypeItQuestions.Count + 1).ToString("D2");
                    questionToAdd.Points = Convert.ToInt32(nUDPoints.Value);
                    questionToAdd.Difficulty = 0;
                    if (rBtnEasy.Checked)
                    {
                        questionToAdd.Difficulty = 1;
                    }
                    else if (rBtnMedium.Checked)
                    {
                        questionToAdd.Difficulty = 2;
                    }
                    else if (rBtnHard.Checked)
                    {
                        questionToAdd.Difficulty = 3;
                    }
                    else if (rBtnAImpossible.Checked)
                    {
                        questionToAdd.Difficulty = 4;
                    }
                    else if (rBtnTImpossible.Checked)
                    {
                        questionToAdd.Difficulty = 5;
                    }

                    if (questionToAdd.Question != "" && questionToAdd.CorrectAnswer != "" && questionToAdd.Difficulty != 0)
                    {
                        QuestionFileHandler.TypeItQuestions.Add(questionToAdd);
                        QuestionFileHandler.SaveAllTypeItQuestions();

                        // Reset input form
                        txtBoxQuestion.Text = "";
                        txtBoxTypeItAnswer.Text = "";
                        nUDPoints.Value = 1;
                        rBtnEasy.Checked = false;
                        rBtnMedium.Checked = false;
                        rBtnHard.Checked = false;
                        rBtnAImpossible.Checked = false;
                        rBtnTImpossible.Checked = false;
                        this.ActiveControl = txtBoxQuestion;
                    }
                    else
                    {
                        MessageBox.Show("You are missing parts of the question that are required\nPlease fill them in to add your question");
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
            //pnlQuestion.Dock = DockStyle.Top;
            //pnlDiffPointsAdd.Dock = DockStyle.Bottom;
           
            switch(questionToAddType)
            {
                case "Type It":
                    pnlAnswerTypeIt.Visible = true;
                    //pnlAnswerTypeIt.Dock = DockStyle.Top;
                    break;
                case "True or False":
                    pnlAnswerTrueOrFalse.Visible = true;
                    //pnlAnswerTrueOrFalse.Dock = DockStyle.Fill;
                    break;
                case "Multiple Choice":
                    pnlAnswerMulti.Visible = true;
                    //pnlAnswerMulti.Dock = DockStyle.Fill;
                    break;
                case "Picture":
                    pnlPicture.Visible = true;
                    //pnlPicture.Dock = DockStyle.Fill;
                    break;
                default: break;
            }

            this.ActiveControl = txtBoxQuestion;

            pnlDiffPointsAdd.Visible = true;

        }
    }
}