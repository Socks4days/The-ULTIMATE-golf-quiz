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
    public partial class Logout_Splash : Form
    {
        public Logout_Splash()
        {
            InitializeComponent();
        }

        private void Logout_Splash_Load(object sender, EventArgs e)
        {
            timeLeft = 10;
            tmrloadLogout.Start();
            pnlSmall.Width = 800;
        }
        public int timeLeft { get; set; }

        private void tmrloadLogout_Tick(object sender, EventArgs e)
        {
            pictureBox1.Show();
             pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
            pnlSmall.Width -= 1;
            if (pnlSmall.Width <= 0)
            {
                tmrloadLogout.Stop();                
                Application.Exit();
            }
        }
    }
}
