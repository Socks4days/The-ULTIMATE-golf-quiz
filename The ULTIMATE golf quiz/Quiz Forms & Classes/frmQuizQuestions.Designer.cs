namespace The_ULTIMATE_golf_quiz
{
    partial class frmQuizQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuizQuestions));
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinishSession = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pnlFinish = new System.Windows.Forms.Panel();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblQuestionsAnsweredCorrectly = new System.Windows.Forms.Label();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTypeIt = new System.Windows.Forms.Panel();
            this.lblEnterYourAnswer = new System.Windows.Forms.Label();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.progressBarCountdown = new System.Windows.Forms.ProgressBar();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pctBoxPicture = new System.Windows.Forms.PictureBox();
            this.pnlMultipleChoiceOptions = new System.Windows.Forms.Panel();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.pnlTrueOrFalseOptions = new System.Windows.Forms.Panel();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.pnlTypeOfRound = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSurpriseMeRound = new System.Windows.Forms.Button();
            this.btnMultipleChoiceRound = new System.Windows.Forms.Button();
            this.btnChooseTheRightClub = new System.Windows.Forms.Button();
            this.btnPictureRound = new System.Windows.Forms.Button();
            this.btnTrueOrFalseRound = new System.Windows.Forms.Button();
            this.btnTypeItRound = new System.Windows.Forms.Button();
            this.lblTypeOfRound = new System.Windows.Forms.Label();
            this.pnlChooseTheRightClub = new System.Windows.Forms.Panel();
            this.lblPower = new System.Windows.Forms.Label();
            this.progressBarPower = new System.Windows.Forms.ProgressBar();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblDistanceToHole = new System.Windows.Forms.Label();
            this.btnChooseAClubGo = new System.Windows.Forms.Button();
            this.lblChooseAClub = new System.Windows.Forms.Label();
            this.comboBoxChooseAClub = new System.Windows.Forms.ComboBox();
            this.pnlGrass = new System.Windows.Forms.Panel();
            this.pctBoxGolfBall = new System.Windows.Forms.PictureBox();
            this.pctBoxFlag = new System.Windows.Forms.PictureBox();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pctBoxLocation = new System.Windows.Forms.PictureBox();
            this.pctBoxMap = new System.Windows.Forms.PictureBox();
            this.timerPower = new System.Windows.Forms.Timer(this.components);
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.pnlFinish.SuspendLayout();
            this.pnlAnswer.SuspendLayout();
            this.pnlTypeIt.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPicture)).BeginInit();
            this.pnlMultipleChoiceOptions.SuspendLayout();
            this.pnlTrueOrFalseOptions.SuspendLayout();
            this.pnlTypeOfRound.SuspendLayout();
            this.pnlChooseTheRightClub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGolfBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).BeginInit();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(30, 13);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(216, 25);
            this.lblAnswer.TabIndex = 10;
            this.lblAnswer.Text = "No - the right answer is:";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(479, 11);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(250, 50);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinishSession
            // 
            this.btnFinishSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinishSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnFinishSession.FlatAppearance.BorderSize = 0;
            this.btnFinishSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnFinishSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnFinishSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishSession.ForeColor = System.Drawing.Color.White;
            this.btnFinishSession.Location = new System.Drawing.Point(402, 169);
            this.btnFinishSession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinishSession.Name = "btnFinishSession";
            this.btnFinishSession.Size = new System.Drawing.Size(250, 50);
            this.btnFinishSession.TabIndex = 12;
            this.btnFinishSession.Text = "Finish";
            this.btnFinishSession.UseVisualStyleBackColor = false;
            this.btnFinishSession.Click += new System.EventHandler(this.btnFinishSession_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(132, 23);
            this.lblFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(574, 25);
            this.lblFinish.TabIndex = 13;
            this.lblFinish.Text = "You have completed all questions in this round - congratulations!!";
            // 
            // pnlFinish
            // 
            this.pnlFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlFinish.Controls.Add(this.lblTotalScore);
            this.pnlFinish.Controls.Add(this.lblQuestionsAnsweredCorrectly);
            this.pnlFinish.Controls.Add(this.btnNextRound);
            this.pnlFinish.Controls.Add(this.btnFinishSession);
            this.pnlFinish.Controls.Add(this.lblFinish);
            this.pnlFinish.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFinish.Location = new System.Drawing.Point(0, 610);
            this.pnlFinish.Name = "pnlFinish";
            this.pnlFinish.Size = new System.Drawing.Size(741, 241);
            this.pnlFinish.TabIndex = 17;
            this.pnlFinish.Visible = false;
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.White;
            this.lblTotalScore.Location = new System.Drawing.Point(295, 120);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(113, 25);
            this.lblTotalScore.TabIndex = 16;
            this.lblTotalScore.Text = "Total Score";
            // 
            // lblQuestionsAnsweredCorrectly
            // 
            this.lblQuestionsAnsweredCorrectly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestionsAnsweredCorrectly.AutoSize = true;
            this.lblQuestionsAnsweredCorrectly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionsAnsweredCorrectly.ForeColor = System.Drawing.Color.White;
            this.lblQuestionsAnsweredCorrectly.Location = new System.Drawing.Point(267, 79);
            this.lblQuestionsAnsweredCorrectly.Name = "lblQuestionsAnsweredCorrectly";
            this.lblQuestionsAnsweredCorrectly.Size = new System.Drawing.Size(170, 25);
            this.lblQuestionsAnsweredCorrectly.TabIndex = 15;
            this.lblQuestionsAnsweredCorrectly.Text = "Questions Correct";
            // 
            // btnNextRound
            // 
            this.btnNextRound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnNextRound.FlatAppearance.BorderSize = 0;
            this.btnNextRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnNextRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnNextRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRound.ForeColor = System.Drawing.Color.White;
            this.btnNextRound.Location = new System.Drawing.Point(105, 169);
            this.btnNextRound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(250, 50);
            this.btnNextRound.TabIndex = 14;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = false;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlAnswer.Controls.Add(this.btnNext);
            this.pnlAnswer.Controls.Add(this.textBox1);
            this.pnlAnswer.Controls.Add(this.button1);
            this.pnlAnswer.Controls.Add(this.lblAnswer);
            this.pnlAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswer.Location = new System.Drawing.Point(0, 542);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(741, 68);
            this.pnlAnswer.TabIndex = 11;
            this.pnlAnswer.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(46, -434);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(561, 75);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, -366);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlTypeIt
            // 
            this.pnlTypeIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTypeIt.Controls.Add(this.lblEnterYourAnswer);
            this.pnlTypeIt.Controls.Add(this.txtBoxAnswer);
            this.pnlTypeIt.Controls.Add(this.btnSubmit);
            this.pnlTypeIt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTypeIt.Location = new System.Drawing.Point(0, 93);
            this.pnlTypeIt.Name = "pnlTypeIt";
            this.pnlTypeIt.Size = new System.Drawing.Size(741, 221);
            this.pnlTypeIt.TabIndex = 20;
            this.pnlTypeIt.Visible = false;
            // 
            // lblEnterYourAnswer
            // 
            this.lblEnterYourAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnterYourAnswer.AutoSize = true;
            this.lblEnterYourAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterYourAnswer.ForeColor = System.Drawing.Color.White;
            this.lblEnterYourAnswer.Location = new System.Drawing.Point(103, 41);
            this.lblEnterYourAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterYourAnswer.Name = "lblEnterYourAnswer";
            this.lblEnterYourAnswer.Size = new System.Drawing.Size(219, 25);
            this.lblEnterYourAnswer.TabIndex = 2;
            this.lblEnterYourAnswer.Text = "Enter your answer here:";
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAnswer.Location = new System.Drawing.Point(105, 79);
            this.txtBoxAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(547, 30);
            this.txtBoxAnswer.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(402, 121);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(250, 50);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.AutoSize = true;
            this.pnlQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlQuestion.Controls.Add(this.progressBarCountdown);
            this.pnlQuestion.Controls.Add(this.lblQuestionNumber);
            this.pnlQuestion.Controls.Add(this.btnReturn);
            this.pnlQuestion.Controls.Add(this.lblDifficulty);
            this.pnlQuestion.Controls.Add(this.lblQuestion);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(741, 93);
            this.pnlQuestion.TabIndex = 21;
            this.pnlQuestion.Visible = false;
            // 
            // progressBarCountdown
            // 
            this.progressBarCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCountdown.Location = new System.Drawing.Point(564, 36);
            this.progressBarCountdown.Name = "progressBarCountdown";
            this.progressBarCountdown.Size = new System.Drawing.Size(165, 23);
            this.progressBarCountdown.Step = 1;
            this.progressBarCountdown.TabIndex = 16;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.White;
            this.lblQuestionNumber.Location = new System.Drawing.Point(128, 9);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(126, 25);
            this.lblQuestionNumber.TabIndex = 15;
            this.lblQuestionNumber.Text = "Question No.";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblDifficulty.Location = new System.Drawing.Point(475, 9);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(84, 25);
            this.lblDifficulty.TabIndex = 14;
            this.lblDifficulty.Text = "Difficulty";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(128, 34);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(431, 59);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question Text";
            // 
            // pctBoxPicture
            // 
            this.pctBoxPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxPicture.Location = new System.Drawing.Point(576, 20);
            this.pctBoxPicture.Name = "pctBoxPicture";
            this.pctBoxPicture.Size = new System.Drawing.Size(140, 140);
            this.pctBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxPicture.TabIndex = 16;
            this.pctBoxPicture.TabStop = false;
            this.pctBoxPicture.Click += new System.EventHandler(this.pctBoxPicture_Click);
            // 
            // pnlMultipleChoiceOptions
            // 
            this.pnlMultipleChoiceOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlMultipleChoiceOptions.Controls.Add(this.btnOption2);
            this.pnlMultipleChoiceOptions.Controls.Add(this.textBox2);
            this.pnlMultipleChoiceOptions.Controls.Add(this.btnOption4);
            this.pnlMultipleChoiceOptions.Controls.Add(this.button2);
            this.pnlMultipleChoiceOptions.Controls.Add(this.btnOption3);
            this.pnlMultipleChoiceOptions.Controls.Add(this.btnOption1);
            this.pnlMultipleChoiceOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMultipleChoiceOptions.Location = new System.Drawing.Point(0, 314);
            this.pnlMultipleChoiceOptions.Name = "pnlMultipleChoiceOptions";
            this.pnlMultipleChoiceOptions.Size = new System.Drawing.Size(741, 139);
            this.pnlMultipleChoiceOptions.TabIndex = 22;
            this.pnlMultipleChoiceOptions.Visible = false;
            // 
            // btnOption2
            // 
            this.btnOption2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnOption2.FlatAppearance.BorderSize = 0;
            this.btnOption2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnOption2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.ForeColor = System.Drawing.Color.White;
            this.btnOption2.Location = new System.Drawing.Point(402, 16);
            this.btnOption2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(250, 50);
            this.btnOption2.TabIndex = 33;
            this.btnOption2.Text = "Option2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(32, -155);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(561, 75);
            this.textBox2.TabIndex = 1;
            // 
            // btnOption4
            // 
            this.btnOption4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOption4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnOption4.FlatAppearance.BorderSize = 0;
            this.btnOption4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnOption4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.ForeColor = System.Drawing.Color.White;
            this.btnOption4.Location = new System.Drawing.Point(402, 77);
            this.btnOption4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(250, 50);
            this.btnOption4.TabIndex = 32;
            this.btnOption4.Text = "Option4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(284, -87);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 75);
            this.button2.TabIndex = 7;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnOption3.FlatAppearance.BorderSize = 0;
            this.btnOption3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnOption3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.ForeColor = System.Drawing.Color.White;
            this.btnOption3.Location = new System.Drawing.Point(105, 77);
            this.btnOption3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(250, 50);
            this.btnOption3.TabIndex = 31;
            this.btnOption3.Text = "Option3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption1
            // 
            this.btnOption1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnOption1.FlatAppearance.BorderSize = 0;
            this.btnOption1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnOption1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.ForeColor = System.Drawing.Color.White;
            this.btnOption1.Location = new System.Drawing.Point(105, 16);
            this.btnOption1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(250, 50);
            this.btnOption1.TabIndex = 30;
            this.btnOption1.Text = "Option1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // pnlTrueOrFalseOptions
            // 
            this.pnlTrueOrFalseOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTrueOrFalseOptions.Controls.Add(this.btnFalse);
            this.pnlTrueOrFalseOptions.Controls.Add(this.btnTrue);
            this.pnlTrueOrFalseOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTrueOrFalseOptions.Location = new System.Drawing.Point(0, 453);
            this.pnlTrueOrFalseOptions.Name = "pnlTrueOrFalseOptions";
            this.pnlTrueOrFalseOptions.Size = new System.Drawing.Size(741, 89);
            this.pnlTrueOrFalseOptions.TabIndex = 23;
            this.pnlTrueOrFalseOptions.Visible = false;
            // 
            // btnFalse
            // 
            this.btnFalse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnFalse.FlatAppearance.BorderSize = 0;
            this.btnFalse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnFalse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalse.ForeColor = System.Drawing.Color.White;
            this.btnFalse.Location = new System.Drawing.Point(402, 22);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(250, 50);
            this.btnFalse.TabIndex = 27;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTrue.FlatAppearance.BorderSize = 0;
            this.btnTrue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnTrue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.ForeColor = System.Drawing.Color.White;
            this.btnTrue.Location = new System.Drawing.Point(105, 22);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(250, 50);
            this.btnTrue.TabIndex = 26;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // pnlTypeOfRound
            // 
            this.pnlTypeOfRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlTypeOfRound.Controls.Add(this.btnBack);
            this.pnlTypeOfRound.Controls.Add(this.btnSurpriseMeRound);
            this.pnlTypeOfRound.Controls.Add(this.btnMultipleChoiceRound);
            this.pnlTypeOfRound.Controls.Add(this.btnChooseTheRightClub);
            this.pnlTypeOfRound.Controls.Add(this.btnPictureRound);
            this.pnlTypeOfRound.Controls.Add(this.btnTrueOrFalseRound);
            this.pnlTypeOfRound.Controls.Add(this.btnTypeItRound);
            this.pnlTypeOfRound.Controls.Add(this.lblTypeOfRound);
            this.pnlTypeOfRound.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTypeOfRound.Location = new System.Drawing.Point(0, 851);
            this.pnlTypeOfRound.Name = "pnlTypeOfRound";
            this.pnlTypeOfRound.Size = new System.Drawing.Size(741, 301);
            this.pnlTypeOfRound.TabIndex = 24;
            this.pnlTypeOfRound.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(18, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 50);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSurpriseMeRound
            // 
            this.btnSurpriseMeRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSurpriseMeRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnSurpriseMeRound.FlatAppearance.BorderSize = 0;
            this.btnSurpriseMeRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnSurpriseMeRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnSurpriseMeRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurpriseMeRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurpriseMeRound.ForeColor = System.Drawing.Color.White;
            this.btnSurpriseMeRound.Location = new System.Drawing.Point(402, 239);
            this.btnSurpriseMeRound.Name = "btnSurpriseMeRound";
            this.btnSurpriseMeRound.Size = new System.Drawing.Size(250, 50);
            this.btnSurpriseMeRound.TabIndex = 5;
            this.btnSurpriseMeRound.Text = "Surprise Me!";
            this.btnSurpriseMeRound.UseVisualStyleBackColor = false;
            this.btnSurpriseMeRound.Click += new System.EventHandler(this.btnSurpriseMeRound_Click);
            // 
            // btnMultipleChoiceRound
            // 
            this.btnMultipleChoiceRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMultipleChoiceRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnMultipleChoiceRound.FlatAppearance.BorderSize = 0;
            this.btnMultipleChoiceRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnMultipleChoiceRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnMultipleChoiceRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleChoiceRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleChoiceRound.ForeColor = System.Drawing.Color.White;
            this.btnMultipleChoiceRound.Location = new System.Drawing.Point(402, 167);
            this.btnMultipleChoiceRound.Name = "btnMultipleChoiceRound";
            this.btnMultipleChoiceRound.Size = new System.Drawing.Size(250, 50);
            this.btnMultipleChoiceRound.TabIndex = 2;
            this.btnMultipleChoiceRound.Text = "Multiple Choice";
            this.btnMultipleChoiceRound.UseVisualStyleBackColor = false;
            this.btnMultipleChoiceRound.Click += new System.EventHandler(this.btnMultipleChoiceRound_Click);
            // 
            // btnChooseTheRightClub
            // 
            this.btnChooseTheRightClub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChooseTheRightClub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChooseTheRightClub.FlatAppearance.BorderSize = 0;
            this.btnChooseTheRightClub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnChooseTheRightClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseTheRightClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseTheRightClub.ForeColor = System.Drawing.Color.White;
            this.btnChooseTheRightClub.Location = new System.Drawing.Point(105, 239);
            this.btnChooseTheRightClub.Name = "btnChooseTheRightClub";
            this.btnChooseTheRightClub.Size = new System.Drawing.Size(250, 50);
            this.btnChooseTheRightClub.TabIndex = 4;
            this.btnChooseTheRightClub.Text = "Choose the right club";
            this.btnChooseTheRightClub.UseVisualStyleBackColor = false;
            this.btnChooseTheRightClub.Click += new System.EventHandler(this.btnDragAndDrop_Click);
            // 
            // btnPictureRound
            // 
            this.btnPictureRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPictureRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnPictureRound.FlatAppearance.BorderSize = 0;
            this.btnPictureRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnPictureRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnPictureRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPictureRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureRound.ForeColor = System.Drawing.Color.White;
            this.btnPictureRound.Location = new System.Drawing.Point(105, 167);
            this.btnPictureRound.Name = "btnPictureRound";
            this.btnPictureRound.Size = new System.Drawing.Size(250, 50);
            this.btnPictureRound.TabIndex = 3;
            this.btnPictureRound.Text = "Picture Round";
            this.btnPictureRound.UseVisualStyleBackColor = false;
            this.btnPictureRound.Click += new System.EventHandler(this.btnPictureRound_Click);
            // 
            // btnTrueOrFalseRound
            // 
            this.btnTrueOrFalseRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrueOrFalseRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTrueOrFalseRound.FlatAppearance.BorderSize = 0;
            this.btnTrueOrFalseRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTrueOrFalseRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnTrueOrFalseRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrueOrFalseRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrueOrFalseRound.ForeColor = System.Drawing.Color.White;
            this.btnTrueOrFalseRound.Location = new System.Drawing.Point(402, 97);
            this.btnTrueOrFalseRound.Name = "btnTrueOrFalseRound";
            this.btnTrueOrFalseRound.Size = new System.Drawing.Size(250, 50);
            this.btnTrueOrFalseRound.TabIndex = 1;
            this.btnTrueOrFalseRound.Text = "True or False";
            this.btnTrueOrFalseRound.UseVisualStyleBackColor = false;
            this.btnTrueOrFalseRound.Click += new System.EventHandler(this.btnTrueOrFalseRound_Click);
            // 
            // btnTypeItRound
            // 
            this.btnTypeItRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTypeItRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTypeItRound.FlatAppearance.BorderSize = 0;
            this.btnTypeItRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTypeItRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnTypeItRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeItRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeItRound.ForeColor = System.Drawing.Color.White;
            this.btnTypeItRound.Location = new System.Drawing.Point(105, 97);
            this.btnTypeItRound.Name = "btnTypeItRound";
            this.btnTypeItRound.Size = new System.Drawing.Size(250, 50);
            this.btnTypeItRound.TabIndex = 0;
            this.btnTypeItRound.Text = "Type It";
            this.btnTypeItRound.UseVisualStyleBackColor = false;
            this.btnTypeItRound.Click += new System.EventHandler(this.btnTypeItRound_Click);
            // 
            // lblTypeOfRound
            // 
            this.lblTypeOfRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTypeOfRound.AutoSize = true;
            this.lblTypeOfRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfRound.ForeColor = System.Drawing.Color.White;
            this.lblTypeOfRound.Location = new System.Drawing.Point(198, 31);
            this.lblTypeOfRound.Name = "lblTypeOfRound";
            this.lblTypeOfRound.Size = new System.Drawing.Size(363, 25);
            this.lblTypeOfRound.TabIndex = 0;
            this.lblTypeOfRound.Text = "What type of round would you like to do?";
            // 
            // pnlChooseTheRightClub
            // 
            this.pnlChooseTheRightClub.Controls.Add(this.lblPower);
            this.pnlChooseTheRightClub.Controls.Add(this.progressBarPower);
            this.pnlChooseTheRightClub.Controls.Add(this.lblWindSpeed);
            this.pnlChooseTheRightClub.Controls.Add(this.lblDistanceToHole);
            this.pnlChooseTheRightClub.Controls.Add(this.btnChooseAClubGo);
            this.pnlChooseTheRightClub.Controls.Add(this.lblChooseAClub);
            this.pnlChooseTheRightClub.Controls.Add(this.comboBoxChooseAClub);
            this.pnlChooseTheRightClub.Controls.Add(this.pnlGrass);
            this.pnlChooseTheRightClub.Controls.Add(this.pctBoxGolfBall);
            this.pnlChooseTheRightClub.Controls.Add(this.pctBoxFlag);
            this.pnlChooseTheRightClub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChooseTheRightClub.Location = new System.Drawing.Point(0, 1152);
            this.pnlChooseTheRightClub.Name = "pnlChooseTheRightClub";
            this.pnlChooseTheRightClub.Size = new System.Drawing.Size(741, 333);
            this.pnlChooseTheRightClub.TabIndex = 25;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.ForeColor = System.Drawing.Color.White;
            this.lblPower.Location = new System.Drawing.Point(8, 43);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(45, 16);
            this.lblPower.TabIndex = 11;
            this.lblPower.Text = "Power";
            // 
            // progressBarPower
            // 
            this.progressBarPower.Location = new System.Drawing.Point(121, 39);
            this.progressBarPower.Name = "progressBarPower";
            this.progressBarPower.Size = new System.Drawing.Size(121, 23);
            this.progressBarPower.Step = 1;
            this.progressBarPower.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPower.TabIndex = 10;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.ForeColor = System.Drawing.Color.White;
            this.lblWindSpeed.Location = new System.Drawing.Point(340, 37);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(82, 16);
            this.lblWindSpeed.TabIndex = 9;
            this.lblWindSpeed.Text = "Wind Speed";
            // 
            // lblDistanceToHole
            // 
            this.lblDistanceToHole.AutoSize = true;
            this.lblDistanceToHole.ForeColor = System.Drawing.Color.White;
            this.lblDistanceToHole.Location = new System.Drawing.Point(340, 10);
            this.lblDistanceToHole.Name = "lblDistanceToHole";
            this.lblDistanceToHole.Size = new System.Drawing.Size(103, 16);
            this.lblDistanceToHole.TabIndex = 7;
            this.lblDistanceToHole.Text = "Distance to hole";
            // 
            // btnChooseAClubGo
            // 
            this.btnChooseAClubGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChooseAClubGo.FlatAppearance.BorderSize = 0;
            this.btnChooseAClubGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChooseAClubGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnChooseAClubGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseAClubGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseAClubGo.ForeColor = System.Drawing.Color.White;
            this.btnChooseAClubGo.Location = new System.Drawing.Point(257, 6);
            this.btnChooseAClubGo.Name = "btnChooseAClubGo";
            this.btnChooseAClubGo.Size = new System.Drawing.Size(61, 28);
            this.btnChooseAClubGo.TabIndex = 6;
            this.btnChooseAClubGo.Text = "Go!";
            this.btnChooseAClubGo.UseVisualStyleBackColor = false;
            this.btnChooseAClubGo.Click += new System.EventHandler(this.btnChooseAClubGo_Click);
            // 
            // lblChooseAClub
            // 
            this.lblChooseAClub.AutoSize = true;
            this.lblChooseAClub.ForeColor = System.Drawing.Color.White;
            this.lblChooseAClub.Location = new System.Drawing.Point(8, 9);
            this.lblChooseAClub.Name = "lblChooseAClub";
            this.lblChooseAClub.Size = new System.Drawing.Size(93, 16);
            this.lblChooseAClub.TabIndex = 4;
            this.lblChooseAClub.Text = "Choose a club";
            // 
            // comboBoxChooseAClub
            // 
            this.comboBoxChooseAClub.FormattingEnabled = true;
            this.comboBoxChooseAClub.Items.AddRange(new object[] {
            "Putter",
            "Lob wedge",
            "Sand wedge",
            "Gap wedge",
            "Pitching wedge",
            "9 iron",
            "8 iron",
            "7 iron",
            "6 iron",
            "5 iron",
            "4 iron",
            "5 wood",
            "3 wood",
            "Driver"});
            this.comboBoxChooseAClub.Location = new System.Drawing.Point(121, 6);
            this.comboBoxChooseAClub.Name = "comboBoxChooseAClub";
            this.comboBoxChooseAClub.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChooseAClub.TabIndex = 3;
            // 
            // pnlGrass
            // 
            this.pnlGrass.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlGrass.Location = new System.Drawing.Point(0, 303);
            this.pnlGrass.Name = "pnlGrass";
            this.pnlGrass.Size = new System.Drawing.Size(740, 30);
            this.pnlGrass.TabIndex = 8;
            this.pnlGrass.Visible = false;
            // 
            // pctBoxGolfBall
            // 
            this.pctBoxGolfBall.Image = global::The_ULTIMATE_golf_quiz.Properties.Resources.running_golf_ball;
            this.pctBoxGolfBall.Location = new System.Drawing.Point(72, 266);
            this.pctBoxGolfBall.Name = "pctBoxGolfBall";
            this.pctBoxGolfBall.Size = new System.Drawing.Size(38, 38);
            this.pctBoxGolfBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxGolfBall.TabIndex = 0;
            this.pctBoxGolfBall.TabStop = false;
            // 
            // pctBoxFlag
            // 
            this.pctBoxFlag.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxFlag.Image = global::The_ULTIMATE_golf_quiz.Properties.Resources.FlagLeft;
            this.pctBoxFlag.Location = new System.Drawing.Point(624, 242);
            this.pctBoxFlag.Name = "pctBoxFlag";
            this.pctBoxFlag.Size = new System.Drawing.Size(70, 70);
            this.pctBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxFlag.TabIndex = 1;
            this.pctBoxFlag.TabStop = false;
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.pctBoxPicture);
            this.pnlPicture.Controls.Add(this.pctBoxLocation);
            this.pnlPicture.Controls.Add(this.pctBoxMap);
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicture.Location = new System.Drawing.Point(0, 1485);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(741, 500);
            this.pnlPicture.TabIndex = 26;
            // 
            // pctBoxLocation
            // 
            this.pctBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pctBoxLocation.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxLocation.Image = global::The_ULTIMATE_golf_quiz.Properties.Resources.Location;
            this.pctBoxLocation.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctBoxLocation.InitialImage")));
            this.pctBoxLocation.Location = new System.Drawing.Point(3, 414);
            this.pctBoxLocation.Name = "pctBoxLocation";
            this.pctBoxLocation.Size = new System.Drawing.Size(21, 31);
            this.pctBoxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLocation.TabIndex = 1;
            this.pctBoxLocation.TabStop = false;
            // 
            // pctBoxMap
            // 
            this.pctBoxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBoxMap.Image = global::The_ULTIMATE_golf_quiz.Properties.Resources.Screenshot_2024_01_26_085609;
            this.pctBoxMap.Location = new System.Drawing.Point(0, 0);
            this.pctBoxMap.Name = "pctBoxMap";
            this.pctBoxMap.Size = new System.Drawing.Size(741, 500);
            this.pctBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxMap.TabIndex = 0;
            this.pctBoxMap.TabStop = false;
            this.pctBoxMap.Click += new System.EventHandler(this.pctBoxMap_Click);
            // 
            // timerPower
            // 
            this.timerPower.Interval = 5;
            this.timerPower.Tick += new System.EventHandler(this.timerPower_Tick);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // frmQuizQuestions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(762, 466);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.pnlChooseTheRightClub);
            this.Controls.Add(this.pnlTypeOfRound);
            this.Controls.Add(this.pnlFinish);
            this.Controls.Add(this.pnlAnswer);
            this.Controls.Add(this.pnlTrueOrFalseOptions);
            this.Controls.Add(this.pnlMultipleChoiceOptions);
            this.Controls.Add(this.pnlTypeIt);
            this.Controls.Add(this.pnlQuestion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuizQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quiz";
            this.Load += new System.EventHandler(this.frmQuizQuestions_Load);
            this.Resize += new System.EventHandler(this.frmQuizQuestions_Resize);
            this.pnlFinish.ResumeLayout(false);
            this.pnlFinish.PerformLayout();
            this.pnlAnswer.ResumeLayout(false);
            this.pnlAnswer.PerformLayout();
            this.pnlTypeIt.ResumeLayout(false);
            this.pnlTypeIt.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPicture)).EndInit();
            this.pnlMultipleChoiceOptions.ResumeLayout(false);
            this.pnlMultipleChoiceOptions.PerformLayout();
            this.pnlTrueOrFalseOptions.ResumeLayout(false);
            this.pnlTypeOfRound.ResumeLayout(false);
            this.pnlTypeOfRound.PerformLayout();
            this.pnlChooseTheRightClub.ResumeLayout(false);
            this.pnlChooseTheRightClub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGolfBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFlag)).EndInit();
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinishSession;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Panel pnlFinish;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblQuestionsAnsweredCorrectly;
        private System.Windows.Forms.Panel pnlTypeIt;
        private System.Windows.Forms.Label lblEnterYourAnswer;
        private System.Windows.Forms.TextBox txtBoxAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlMultipleChoiceOptions;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Panel pnlTrueOrFalseOptions;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlTypeOfRound;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSurpriseMeRound;
        private System.Windows.Forms.Button btnMultipleChoiceRound;
        private System.Windows.Forms.Button btnChooseTheRightClub;
        private System.Windows.Forms.Button btnPictureRound;
        private System.Windows.Forms.Button btnTrueOrFalseRound;
        private System.Windows.Forms.Button btnTypeItRound;
        private System.Windows.Forms.Label lblTypeOfRound;
        private System.Windows.Forms.PictureBox pctBoxPicture;
        private System.Windows.Forms.Panel pnlChooseTheRightClub;
        private System.Windows.Forms.PictureBox pctBoxFlag;
        private System.Windows.Forms.PictureBox pctBoxGolfBall;
        private System.Windows.Forms.Label lblChooseAClub;
        private System.Windows.Forms.ComboBox comboBoxChooseAClub;
        private System.Windows.Forms.Button btnChooseAClubGo;
        private System.Windows.Forms.Label lblDistanceToHole;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox pctBoxMap;
        private System.Windows.Forms.PictureBox pctBoxLocation;
        private System.Windows.Forms.Panel pnlGrass;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.ProgressBar progressBarPower;
        private System.Windows.Forms.Timer timerPower;
        private System.Windows.Forms.ProgressBar progressBarCountdown;
        private System.Windows.Forms.Timer timerCountdown;
    }
}