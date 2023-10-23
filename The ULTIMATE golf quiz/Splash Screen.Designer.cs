namespace The_ULTIMATE_golf_quiz
{
    partial class Splash_Screen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSmall = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrload = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-13, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 124);
            this.panel1.TabIndex = 0;
            // 
            // pnlSmall
            // 
            this.pnlSmall.BackColor = System.Drawing.Color.Lime;
            this.pnlSmall.Location = new System.Drawing.Point(-10, 487);
            this.pnlSmall.Name = "pnlSmall";
            this.pnlSmall.Size = new System.Drawing.Size(12, 51);
            this.pnlSmall.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(-10, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 492);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::The_ULTIMATE_golf_quiz.Properties.Resources.running_golf_ball;
            this.pictureBox1.Location = new System.Drawing.Point(-92, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tmrload
            // 
            this.tmrload.Interval = 1;
            this.tmrload.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.pnlSmall);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Splash_Screen";
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSmall;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer tmrload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}