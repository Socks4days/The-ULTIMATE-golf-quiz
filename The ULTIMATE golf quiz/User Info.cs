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
        public frmUserInfo(string username, string password, string name, string gender, string age, string nationality)
        {
            InitializeComponent();
        }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public string nationality { get; set; }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            lblUserText.Text = username;
            lblPasswordText.Text = password;
            lblNameText.Text = name;
            lblAgeText.Text = age;
            lblGenderText.Text = gender;
            lblNationText.Text = nationality;
        }    
    

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().Show();
        }
    }
}
