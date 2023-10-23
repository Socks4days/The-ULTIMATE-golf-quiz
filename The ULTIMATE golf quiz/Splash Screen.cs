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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timeLeft = 10;
            tmrload.Start();
        }

        public int timeLeft { get; set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pnlSmall.Width += 3;
            pictureBox1.Location = new Point(pictureBox1.Location.X +3, pictureBox1.Location.Y);
            if(pnlSmall.Width >= 800)
            {
                tmrload.Stop();
                this.Hide();
                new loginfrm().Show();
            }
        }
    }
}
