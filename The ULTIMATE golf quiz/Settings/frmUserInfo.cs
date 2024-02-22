using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace The_ULTIMATE_golf_quiz
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();                       
        }
        // sets the user who's details are displayed equal to the user that is logged in
        Player player = frmSplashScreen.player;

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            // when the form is loaded, the textboxes are populated with all the relevant information
            lblUserText.Text = player.username;            
            lblPasswordText.Text = player.password;          
            lblNameText.Text = player.name;
            lblAgeText.Text = Convert.ToString(player.age);
            lblGenderText.Text = player.gender;
            lblNationText.Text = player.nationality;
        }        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // when clicked, the user will be directed back 
            this.Close();
        }

       
    }
}