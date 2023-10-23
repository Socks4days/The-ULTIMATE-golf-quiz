using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
            
        }
        
        string userName = "Bananaa";
        string password = "Butterr";
        
        

        public void verification()
        {
            

            string inputUsername = usernametxtbox.Text;
            string inputPassword = passwordtxtbox.Text;

            if ((inputUsername == userName) && (inputPassword == password))
            {                               
                mainMenu mainMenu = new mainMenu();
                this.Hide();
                mainMenu.Show();
                MessageBox.Show("Welcome Back " + userName);
            } 
            else 
            {
                MessageBox.Show("Error, please try again...");
                Cancelation();                
            }            
        }
        public void Cancelation()
        {
            usernametxtbox.Clear();
            passwordtxtbox.Clear();
            this.ActiveControl=usernametxtbox;

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            verification();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Cancelation();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            frmReg registerfrm = new frmReg();
            this.Hide();
            registerfrm.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
