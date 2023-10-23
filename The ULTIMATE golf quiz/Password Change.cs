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
    public partial class frmChangePass : Form 
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

       
        bool validPassword = false;
        public void PasswordValidation()
        {
            string password = txtBoxChangePass.Text;

            if ((password.Length >= 8) && (password.Any(char.IsUpper)) && (password.Any(char.IsDigit)))
            {
              validPassword = true;
            }
            else
            {
                lblError.Visible = true;
            }

            List<char> symbols = new List<char>() { '@', '<', '>', '*', '!', '£', '$', '%', '&', '^', '.', ',', ':', ';', '/', '?', '#' };
                      
            foreach (char sym in symbols)
            {
                if (password.Contains(sym))
                {                    
                    Verify();
                }
            }

        }
        public void Verify()
        {
            if (validPassword = true)
            {
                mainMenu mainMenu = new mainMenu();
                this.Hide();
                mainMenu.Show();
                MessageBox.Show("Password changed successfully!");
            }

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if ((txtBoxChangePass.Text == "") || (txtBoxChangePass.Text == "") || (txtBoxChangePass.Text == "") || (txtBoxChangePass.Text == "") || (txtBoxChangePass.Text == "") || (txtBoxChangePass.Text == ""))
            {
                Error();
            }
            else
            {
                PasswordValidation();
            }
        }
        private void Error()
        {
            MessageBox.Show("No password was entered: Please try again.");
            lblError0.Visible = true;
        }
    }
}
