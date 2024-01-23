namespace The_ULTIMATE_golf_quiz
{
    partial class frmMainMenu
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
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pctBoxAvatar = new System.Windows.Forms.PictureBox();
            this.lblArrow1 = new System.Windows.Forms.Label();
            this.lblArrow3 = new System.Windows.Forms.Label();
            this.lblArrow2 = new System.Windows.Forms.Label();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.pnlTypeOfRound = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSurpriseMeRound = new System.Windows.Forms.Button();
            this.btnMultipleChoiceRound = new System.Windows.Forms.Button();
            this.btnDragAndDrop = new System.Windows.Forms.Button();
            this.btnPictureRound = new System.Windows.Forms.Button();
            this.btnTrueOrFalseRound = new System.Windows.Forms.Button();
            this.btnTypeItRound = new System.Windows.Forms.Button();
            this.lblTypeOfRound = new System.Windows.Forms.Label();
            this.pnlFinish = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAvatar)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            this.pnlTypeOfRound.SuspendLayout();
            this.pnlFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.Location = new System.Drawing.Point(529, 32);
            this.btnQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(300, 82);
            this.btnQuiz.TabIndex = 0;
            this.btnQuiz.Text = "To The Quiz!";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            this.btnQuiz.MouseLeave += new System.EventHandler(this.btnQuiz_MouseLeave);
            this.btnQuiz.MouseHover += new System.EventHandler(this.btnQuiz_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Snow;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1087, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(249, 82);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(221, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(860, 91);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "The Ultimate Golf Quiz!";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(400, 117);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(542, 72);
            this.lblCurrentUser.TabIndex = 4;
            this.lblCurrentUser.Text = "Current User:";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(840, 228);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(230, 46);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "High Score:";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.Location = new System.Drawing.Point(217, 228);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(384, 46);
            this.lblRounds.TabIndex = 6;
            this.lblRounds.Text = "Rounds Completed: ";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlMain.Controls.Add(this.pctBoxAvatar);
            this.pnlMain.Controls.Add(this.btnLogout);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblCurrentUser);
            this.pnlMain.Location = new System.Drawing.Point(1, 1);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1344, 334);
            this.pnlMain.TabIndex = 7;
            // 
            // pctBoxAvatar
            // 
            this.pctBoxAvatar.Location = new System.Drawing.Point(15, 22);
            this.pctBoxAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pctBoxAvatar.Name = "pctBoxAvatar";
            this.pctBoxAvatar.Size = new System.Drawing.Size(183, 156);
            this.pctBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxAvatar.TabIndex = 11;
            this.pctBoxAvatar.TabStop = false;
            // 
            // lblArrow1
            // 
            this.lblArrow1.AutoSize = true;
            this.lblArrow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow1.Location = new System.Drawing.Point(580, 117);
            this.lblArrow1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrow1.Name = "lblArrow1";
            this.lblArrow1.Size = new System.Drawing.Size(60, 69);
            this.lblArrow1.TabIndex = 8;
            this.lblArrow1.Text = "↑";
            this.lblArrow1.Visible = false;
            // 
            // lblArrow3
            // 
            this.lblArrow3.AutoSize = true;
            this.lblArrow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow3.Location = new System.Drawing.Point(724, 117);
            this.lblArrow3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrow3.Name = "lblArrow3";
            this.lblArrow3.Size = new System.Drawing.Size(60, 69);
            this.lblArrow3.TabIndex = 9;
            this.lblArrow3.Text = "↑";
            this.lblArrow3.Visible = false;
            // 
            // lblArrow2
            // 
            this.lblArrow2.AutoSize = true;
            this.lblArrow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow2.Location = new System.Drawing.Point(652, 117);
            this.lblArrow2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrow2.Name = "lblArrow2";
            this.lblArrow2.Size = new System.Drawing.Size(60, 69);
            this.lblArrow2.TabIndex = 10;
            this.lblArrow2.Text = "↑";
            this.lblArrow2.Visible = false;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.btnLeaderboard);
            this.pnlMainMenu.Controls.Add(this.lblArrow2);
            this.pnlMainMenu.Controls.Add(this.lblArrow3);
            this.pnlMainMenu.Controls.Add(this.btnQuiz);
            this.pnlMainMenu.Controls.Add(this.lblArrow1);
            this.pnlMainMenu.Controls.Add(this.lblRounds);
            this.pnlMainMenu.Controls.Add(this.lblHighScore);
            this.pnlMainMenu.Location = new System.Drawing.Point(12, 341);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1337, 333);
            this.pnlMainMenu.TabIndex = 12;
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.Location = new System.Drawing.Point(242, 32);
            this.btnLeaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(256, 82);
            this.btnLeaderboard.TabIndex = 11;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // pnlTypeOfRound
            // 
            this.pnlTypeOfRound.Controls.Add(this.btnReturn);
            this.pnlTypeOfRound.Controls.Add(this.btnSurpriseMeRound);
            this.pnlTypeOfRound.Controls.Add(this.btnMultipleChoiceRound);
            this.pnlTypeOfRound.Controls.Add(this.btnDragAndDrop);
            this.pnlTypeOfRound.Controls.Add(this.btnPictureRound);
            this.pnlTypeOfRound.Controls.Add(this.btnTrueOrFalseRound);
            this.pnlTypeOfRound.Controls.Add(this.btnTypeItRound);
            this.pnlTypeOfRound.Controls.Add(this.lblTypeOfRound);
            this.pnlTypeOfRound.Location = new System.Drawing.Point(32, 341);
            this.pnlTypeOfRound.Name = "pnlTypeOfRound";
            this.pnlTypeOfRound.Size = new System.Drawing.Size(1285, 301);
            this.pnlTypeOfRound.TabIndex = 13;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(55, 22);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(69, 64);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSurpriseMeRound
            // 
            this.btnSurpriseMeRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSurpriseMeRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurpriseMeRound.Location = new System.Drawing.Point(940, 205);
            this.btnSurpriseMeRound.Name = "btnSurpriseMeRound";
            this.btnSurpriseMeRound.Size = new System.Drawing.Size(290, 63);
            this.btnSurpriseMeRound.TabIndex = 5;
            this.btnSurpriseMeRound.Text = "Surprise Me!";
            this.btnSurpriseMeRound.UseVisualStyleBackColor = false;
            this.btnSurpriseMeRound.Click += new System.EventHandler(this.btnSurpriseMeRound_Click);
            // 
            // btnMultipleChoiceRound
            // 
            this.btnMultipleChoiceRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMultipleChoiceRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleChoiceRound.Location = new System.Drawing.Point(940, 112);
            this.btnMultipleChoiceRound.Name = "btnMultipleChoiceRound";
            this.btnMultipleChoiceRound.Size = new System.Drawing.Size(290, 63);
            this.btnMultipleChoiceRound.TabIndex = 2;
            this.btnMultipleChoiceRound.Text = "Multiple Choice";
            this.btnMultipleChoiceRound.UseVisualStyleBackColor = false;
            this.btnMultipleChoiceRound.Click += new System.EventHandler(this.btnMultipleChoiceRound_Click);
            // 
            // btnDragAndDrop
            // 
            this.btnDragAndDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDragAndDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDragAndDrop.Location = new System.Drawing.Point(509, 205);
            this.btnDragAndDrop.Name = "btnDragAndDrop";
            this.btnDragAndDrop.Size = new System.Drawing.Size(290, 63);
            this.btnDragAndDrop.TabIndex = 4;
            this.btnDragAndDrop.Text = "Drag \'n\' Drop";
            this.btnDragAndDrop.UseVisualStyleBackColor = false;
            // 
            // btnPictureRound
            // 
            this.btnPictureRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPictureRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureRound.Location = new System.Drawing.Point(55, 205);
            this.btnPictureRound.Name = "btnPictureRound";
            this.btnPictureRound.Size = new System.Drawing.Size(290, 63);
            this.btnPictureRound.TabIndex = 3;
            this.btnPictureRound.Text = "Picture Round";
            this.btnPictureRound.UseVisualStyleBackColor = false;
            this.btnPictureRound.Click += new System.EventHandler(this.btnPictureRound_Click);
            // 
            // btnTrueOrFalseRound
            // 
            this.btnTrueOrFalseRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrueOrFalseRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrueOrFalseRound.Location = new System.Drawing.Point(509, 112);
            this.btnTrueOrFalseRound.Name = "btnTrueOrFalseRound";
            this.btnTrueOrFalseRound.Size = new System.Drawing.Size(290, 63);
            this.btnTrueOrFalseRound.TabIndex = 1;
            this.btnTrueOrFalseRound.Text = "True or False";
            this.btnTrueOrFalseRound.UseVisualStyleBackColor = false;
            this.btnTrueOrFalseRound.Click += new System.EventHandler(this.btnTrueOrFalseRound_Click);
            // 
            // btnTypeItRound
            // 
            this.btnTypeItRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTypeItRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeItRound.Location = new System.Drawing.Point(55, 112);
            this.btnTypeItRound.Name = "btnTypeItRound";
            this.btnTypeItRound.Size = new System.Drawing.Size(290, 63);
            this.btnTypeItRound.TabIndex = 0;
            this.btnTypeItRound.Text = "Type It";
            this.btnTypeItRound.UseVisualStyleBackColor = false;
            this.btnTypeItRound.Click += new System.EventHandler(this.btnTypeItRound_Click);
            // 
            // lblTypeOfRound
            // 
            this.lblTypeOfRound.AutoSize = true;
            this.lblTypeOfRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfRound.Location = new System.Drawing.Point(340, 32);
            this.lblTypeOfRound.Name = "lblTypeOfRound";
            this.lblTypeOfRound.Size = new System.Drawing.Size(743, 46);
            this.lblTypeOfRound.TabIndex = 0;
            this.lblTypeOfRound.Text = "What type of round would you like to do?";
            // 
            // pnlFinish
            // 
            this.pnlFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlFinish.Controls.Add(this.btnFinish);
            this.pnlFinish.Location = new System.Drawing.Point(1, 1);
            this.pnlFinish.Name = "pnlFinish";
            this.pnlFinish.Size = new System.Drawing.Size(1348, 334);
            this.pnlFinish.TabIndex = 14;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(529, 101);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(299, 88);
            this.btnFinish.TabIndex = 15;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1347, 671);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFinish);
            this.Controls.Add(this.pnlTypeOfRound);
            this.Controls.Add(this.pnlMainMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenu_FormClosed);
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAvatar)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.pnlTypeOfRound.ResumeLayout(false);
            this.pnlTypeOfRound.PerformLayout();
            this.pnlFinish.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblArrow1;
        private System.Windows.Forms.Label lblArrow3;
        private System.Windows.Forms.Label lblArrow2;
        private System.Windows.Forms.PictureBox pctBoxAvatar;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlTypeOfRound;
        private System.Windows.Forms.Label lblTypeOfRound;
        private System.Windows.Forms.Button btnMultipleChoiceRound;
        private System.Windows.Forms.Button btnDragAndDrop;
        private System.Windows.Forms.Button btnPictureRound;
        private System.Windows.Forms.Button btnTrueOrFalseRound;
        private System.Windows.Forms.Button btnTypeItRound;
        private System.Windows.Forms.Button btnSurpriseMeRound;
        private System.Windows.Forms.Panel pnlFinish;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}