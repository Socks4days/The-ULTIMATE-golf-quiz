namespace The_ULTIMATE_golf_quiz
{
    partial class Logout_Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSmall = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tmrloadLogout = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSmall
            // 
            this.pnlSmall.BackColor = System.Drawing.Color.Lime;
            this.pnlSmall.Location = new System.Drawing.Point(0, 486);
            this.pnlSmall.Name = "pnlSmall";
            this.pnlSmall.Size = new System.Drawing.Size(17, 53);
            this.pnlSmall.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 487);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::The_ULTIMATE_golf_quiz.Properties.Resources.golf_ball_running_back;
            this.pictureBox1.Location = new System.Drawing.Point(1092, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1189, 139);
            this.panel3.TabIndex = 0;
            // 
            // tmrloadLogout
            // 
            this.tmrloadLogout.Interval = 10;
            this.tmrloadLogout.Tick += new System.EventHandler(this.tmrloadLogout_Tick);
            // 
            // Logout_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.pnlSmall);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Logout_Splash";
            this.Text = "Logout_Splash";
            this.Load += new System.EventHandler(this.Logout_Splash_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSmall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer tmrloadLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}