using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_ULTIMATE_golf_quiz
{
    public partial class AddTypeIt : Form
    {
        public AddTypeIt()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Your question will not be saved!\nDo you wish to leave?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new frmMainMenu().Show();
            }
            else if (result == DialogResult.No)
            {
                
            }
        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TypeItQuestion questionToAdd = new TypeItQuestion();
            questionToAdd.Question= txtBoxQuestion.Text;
            questionToAdd.CorrectAnswer = txtBoxAnswer.Text;
            questionToAdd.Id = "TI"+ QuestionFileHandler.TypeItQuestions.Count+1;
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

            if (questionToAdd.Question != "" && questionToAdd.CorrectAnswer != "" && questionToAdd.Difficulty!=0)
            {
                QuestionFileHandler.TypeItQuestions.Add(questionToAdd);
                QuestionFileHandler.SaveAllTypeItQuestions();
            }
            else
            {
                MessageBox.Show("You are missing parts of the question that are required\nPlease fill them in to add your question");
            }
            
        }
       

        

        
    }
}