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
            user = frmReg.user;
        }

        public User user;        

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            lblUserText.Text = user.username;
            lblPasswordText.Text = user.password;
            lblNameText.Text = user.name;
            lblAgeText.Text = Convert.ToString(user.age);
            lblGenderText.Text = user.gender;
            lblNationText.Text = user.nationality;
        }    
    

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().Show();
        }
    }
}
