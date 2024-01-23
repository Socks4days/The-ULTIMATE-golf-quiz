using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public partial class frmSettings : Form
    {
        static User userDetails = new User();
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmChangePass().Show();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUserInfo().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainMenu().Show();
        }
    }
}
