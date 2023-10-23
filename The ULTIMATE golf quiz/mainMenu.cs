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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry mate, no questions yet");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginfrm().Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().Show();
        }
    }
}
