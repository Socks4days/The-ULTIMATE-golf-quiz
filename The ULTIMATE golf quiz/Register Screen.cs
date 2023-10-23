using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public partial class frmReg : Form
    {
        public static User user;
        public frmReg()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtBoxUser.Clear();
            txtBoxPassword.Clear();
            txtBoxName.Clear();
            txtBoxAge.Clear();
            txtBoxGender.Clear();
            txtBoxNation.Clear();
            this.ActiveControl = txtBoxUser;
        }
        bool validPassword = false;
        public void PasswordValidation()
        {
            string password = txtBoxPassword.Text;

            if ((password.Length >= 8) && (password.Any(char.IsUpper)) && (password.Any(char.IsDigit)))
            {
                //txtBoxPassword.Text.Any(!char.IsLetterOrDigit);
                validPassword = true;
            }
            else 
            { 
                lblPassError.Visible = true; 
            }
       


            List<char> symbols = new List<char>() { '@', '<', '>', '*', '!', '£', '$', '%', '&', '^', '.', ',', ':', ';', '/', '?', '#'};

            
            foreach( char sym in symbols)
            {
                if(password.Contains(sym))
                {                    
                    Register();
                }
            }

        }


        public User Register()
        {
            string username = txtBoxUser.Text;
            string password = txtBoxPassword.Text;
            string name = txtBoxName.Text;
            string gender = txtBoxGender.Text;
            int age = 0;
            int.TryParse(txtBoxAge.Text, out age);
            string nationality = txtBoxNation.Text;
            user = new User(username, password, name, age, gender, nationality);
            frmUserInfo info = new frmUserInfo();

            if (validPassword = true)
            {
                mainMenu mainMenu = new mainMenu();
                this.Hide();
                mainMenu.Show();
            }

            return new User(username, password, name, age, gender, nationality);

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if((txtBoxUser.Text=="")||(txtBoxPassword.Text=="")||(txtBoxName.Text=="")||(txtBoxAge.Text=="")||(txtBoxGender.Text=="")|| (txtBoxNation.Text == ""))
            {
                Error();
            }
            else             
            {
                PasswordValidation();
            }
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Error()
        {
            MessageBox.Show("Please complete all indicated fields.");
            lblErrorU.Text = "*";
            lblErrorU.ForeColor = Color.Red;
            lblErrorU.Visible = true;
            lblErrorP.Text = "*";
            lblErrorP.ForeColor = Color.Red;
            lblErrorNam.Text = "*";
            lblErrorNam.ForeColor = Color.Red;
            lblErrorA.Text = "*";
            lblErrorA.ForeColor = Color.Red;
            lblErrorG.Text = "*";
            lblErrorG.ForeColor = Color.Red;
            lblErrorNat.Text = "*";
            lblErrorNat.ForeColor = Color.Red;            
        }     
    }
}
