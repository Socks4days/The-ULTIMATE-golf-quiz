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
    public partial class AddQuestions : Form
    {
        public AddQuestions()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMainMenu().Show();
        }

        private void btnTyped_Click(object sender, EventArgs e)
        {

        }



        /* Basic Idea:
         * User will select question type they would like to add
         * Depending on type, it will generate the first two numbers of the question id
         * The user will then see different layouts depending on question type about how to proceed
         
         * If multiple choice, then they can insert the question and also up to a max of 4 available options
         * they will then tick which answer will be correct
         
         * If true or false, then they will insert the question and select which one will be correct
         
         * If picture round then insert question and inport pictures, selecting which one will be right
         
         * etc
         * 
         * Back arrow will be there, if clicked then warning box pops up saying all they have done will not be saved
         * 
         * When they click the submit button, it will find the last question that matches that type, get the number from it and generate
         * the number that is one more and the id will be complete
         * Then all the pieces of the array will be complete and it will be written out to the csv file and saved
         * 
         * could also do a check to see if the question has already been input using foreach loop
         */
    }
}
