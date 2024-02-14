namespace The_ULTIMATE_golf_quiz
{
    partial class frmAddQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQuestions));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.rBtnAImpossible = new System.Windows.Forms.RadioButton();
            this.rBtnTImpossible = new System.Windows.Forms.RadioButton();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.nUDPoints = new System.Windows.Forms.NumericUpDown();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.pnlTitleMenu = new System.Windows.Forms.Panel();
            this.pnlDiffPointsAdd = new System.Windows.Forms.Panel();
            this.pnlAnswerTypeIt = new System.Windows.Forms.Panel();
            this.lblAnswerTypeIt = new System.Windows.Forms.Label();
            this.txtBoxTypeItAnswer = new System.Windows.Forms.TextBox();
            this.pnlAnswerMulti = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAnswerMultiOption2 = new System.Windows.Forms.Label();
            this.lblAnswerMultiOption3 = new System.Windows.Forms.Label();
            this.lblAnswerMultiOption4 = new System.Windows.Forms.Label();
            this.lblAnswerMultiOption1 = new System.Windows.Forms.Label();
            this.pnlAnswerTrueOrFalse = new System.Windows.Forms.Panel();
            this.rButonFalse = new System.Windows.Forms.RadioButton();
            this.rButtonTrue = new System.Windows.Forms.RadioButton();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pctBoxLocation = new System.Windows.Forms.PictureBox();
            this.pctBoxMap = new System.Windows.Forms.PictureBox();
            this.pnlChooseQuestionType = new System.Windows.Forms.Panel();
            this.lblChooseQuestionType = new System.Windows.Forms.Label();
            this.btnTrueOrFalse = new System.Windows.Forms.Button();
            this.btnMultipleChoice = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnTypeIt = new System.Windows.Forms.Button();
            this.groupBoxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).BeginInit();
            this.pnlQuestion.SuspendLayout();
            this.pnlTitleMenu.SuspendLayout();
            this.pnlDiffPointsAdd.SuspendLayout();
            this.pnlAnswerTypeIt.SuspendLayout();
            this.pnlAnswerMulti.SuspendLayout();
            this.pnlAnswerTrueOrFalse.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMap)).BeginInit();
            this.pnlChooseQuestionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(17, 11);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(229, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 44);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Add A Question";
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuestion.Location = new System.Drawing.Point(17, 35);
            this.txtBoxQuestion.MaxLength = 200;
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.Size = new System.Drawing.Size(701, 26);
            this.txtBoxQuestion.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(13, 12);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(178, 20);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Type your question here";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(414, 124);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(458, 33);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(164, 25);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Points available";
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.ForeColor = System.Drawing.Color.White;
            this.rBtnEasy.Location = new System.Drawing.Point(16, 31);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(62, 24);
            this.rBtnEasy.TabIndex = 0;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.ForeColor = System.Drawing.Color.White;
            this.rBtnMedium.Location = new System.Drawing.Point(16, 60);
            this.rBtnMedium.Name = "rBtnMedium";
            this.rBtnMedium.Size = new System.Drawing.Size(83, 24);
            this.rBtnMedium.TabIndex = 1;
            this.rBtnMedium.TabStop = true;
            this.rBtnMedium.Text = "Medium";
            this.rBtnMedium.UseVisualStyleBackColor = true;
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.ForeColor = System.Drawing.Color.White;
            this.rBtnHard.Location = new System.Drawing.Point(16, 89);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(62, 24);
            this.rBtnHard.TabIndex = 2;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            // 
            // rBtnAImpossible
            // 
            this.rBtnAImpossible.AutoSize = true;
            this.rBtnAImpossible.ForeColor = System.Drawing.Color.White;
            this.rBtnAImpossible.Location = new System.Drawing.Point(16, 118);
            this.rBtnAImpossible.Name = "rBtnAImpossible";
            this.rBtnAImpossible.Size = new System.Drawing.Size(156, 24);
            this.rBtnAImpossible.TabIndex = 3;
            this.rBtnAImpossible.TabStop = true;
            this.rBtnAImpossible.Text = "Almost Impossible";
            this.rBtnAImpossible.UseVisualStyleBackColor = true;
            // 
            // rBtnTImpossible
            // 
            this.rBtnTImpossible.AutoSize = true;
            this.rBtnTImpossible.ForeColor = System.Drawing.Color.White;
            this.rBtnTImpossible.Location = new System.Drawing.Point(16, 147);
            this.rBtnTImpossible.Name = "rBtnTImpossible";
            this.rBtnTImpossible.Size = new System.Drawing.Size(199, 24);
            this.rBtnTImpossible.TabIndex = 4;
            this.rBtnTImpossible.TabStop = true;
            this.rBtnTImpossible.Text = "TOTALLY IMPOSSIBLE";
            this.rBtnTImpossible.UseVisualStyleBackColor = true;
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.rBtnTImpossible);
            this.groupBoxDifficulty.Controls.Add(this.rBtnEasy);
            this.groupBoxDifficulty.Controls.Add(this.rBtnAImpossible);
            this.groupBoxDifficulty.Controls.Add(this.rBtnMedium);
            this.groupBoxDifficulty.Controls.Add(this.rBtnHard);
            this.groupBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDifficulty.ForeColor = System.Drawing.Color.White;
            this.groupBoxDifficulty.Location = new System.Drawing.Point(43, 19);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(283, 179);
            this.groupBoxDifficulty.TabIndex = 0;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Select Difficulty";
            // 
            // nUDPoints
            // 
            this.nUDPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDPoints.Location = new System.Drawing.Point(440, 72);
            this.nUDPoints.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPoints.Name = "nUDPoints";
            this.nUDPoints.Size = new System.Drawing.Size(198, 31);
            this.nUDPoints.TabIndex = 2;
            this.nUDPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.txtBoxQuestion);
            this.pnlQuestion.Controls.Add(this.lblQuestion);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 76);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(745, 80);
            this.pnlQuestion.TabIndex = 1;
            // 
            // pnlTitleMenu
            // 
            this.pnlTitleMenu.Controls.Add(this.lblTitle);
            this.pnlTitleMenu.Controls.Add(this.btnReturn);
            this.pnlTitleMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleMenu.Name = "pnlTitleMenu";
            this.pnlTitleMenu.Size = new System.Drawing.Size(745, 76);
            this.pnlTitleMenu.TabIndex = 0;
            // 
            // pnlDiffPointsAdd
            // 
            this.pnlDiffPointsAdd.Controls.Add(this.btnAdd);
            this.pnlDiffPointsAdd.Controls.Add(this.nUDPoints);
            this.pnlDiffPointsAdd.Controls.Add(this.groupBoxDifficulty);
            this.pnlDiffPointsAdd.Controls.Add(this.lblPoints);
            this.pnlDiffPointsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiffPointsAdd.Location = new System.Drawing.Point(0, 1178);
            this.pnlDiffPointsAdd.Name = "pnlDiffPointsAdd";
            this.pnlDiffPointsAdd.Size = new System.Drawing.Size(745, 211);
            this.pnlDiffPointsAdd.TabIndex = 7;
            // 
            // pnlAnswerTypeIt
            // 
            this.pnlAnswerTypeIt.Controls.Add(this.lblAnswerTypeIt);
            this.pnlAnswerTypeIt.Controls.Add(this.txtBoxTypeItAnswer);
            this.pnlAnswerTypeIt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerTypeIt.Location = new System.Drawing.Point(0, 156);
            this.pnlAnswerTypeIt.Name = "pnlAnswerTypeIt";
            this.pnlAnswerTypeIt.Size = new System.Drawing.Size(745, 70);
            this.pnlAnswerTypeIt.TabIndex = 2;
            // 
            // lblAnswerTypeIt
            // 
            this.lblAnswerTypeIt.AutoSize = true;
            this.lblAnswerTypeIt.Location = new System.Drawing.Point(13, 6);
            this.lblAnswerTypeIt.Name = "lblAnswerTypeIt";
            this.lblAnswerTypeIt.Size = new System.Drawing.Size(161, 20);
            this.lblAnswerTypeIt.TabIndex = 1;
            this.lblAnswerTypeIt.Text = "Type the answer here";
            // 
            // txtBoxTypeItAnswer
            // 
            this.txtBoxTypeItAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTypeItAnswer.Location = new System.Drawing.Point(17, 29);
            this.txtBoxTypeItAnswer.Name = "txtBoxTypeItAnswer";
            this.txtBoxTypeItAnswer.Size = new System.Drawing.Size(701, 26);
            this.txtBoxTypeItAnswer.TabIndex = 1;
            // 
            // pnlAnswerMulti
            // 
            this.pnlAnswerMulti.Controls.Add(this.textBox5);
            this.pnlAnswerMulti.Controls.Add(this.textBox4);
            this.pnlAnswerMulti.Controls.Add(this.textBox3);
            this.pnlAnswerMulti.Controls.Add(this.textBox2);
            this.pnlAnswerMulti.Controls.Add(this.lblAnswerMultiOption2);
            this.pnlAnswerMulti.Controls.Add(this.lblAnswerMultiOption3);
            this.pnlAnswerMulti.Controls.Add(this.lblAnswerMultiOption4);
            this.pnlAnswerMulti.Controls.Add(this.lblAnswerMultiOption1);
            this.pnlAnswerMulti.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerMulti.Location = new System.Drawing.Point(0, 226);
            this.pnlAnswerMulti.Name = "pnlAnswerMulti";
            this.pnlAnswerMulti.Size = new System.Drawing.Size(745, 150);
            this.pnlAnswerMulti.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(42, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 26);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(399, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 26);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(399, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 26);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(42, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 26);
            this.textBox2.TabIndex = 1;
            // 
            // lblAnswerMultiOption2
            // 
            this.lblAnswerMultiOption2.AutoSize = true;
            this.lblAnswerMultiOption2.Location = new System.Drawing.Point(467, 10);
            this.lblAnswerMultiOption2.Name = "lblAnswerMultiOption2";
            this.lblAnswerMultiOption2.Size = new System.Drawing.Size(161, 20);
            this.lblAnswerMultiOption2.TabIndex = 2;
            this.lblAnswerMultiOption2.Text = "Type the answer here";
            // 
            // lblAnswerMultiOption3
            // 
            this.lblAnswerMultiOption3.AutoSize = true;
            this.lblAnswerMultiOption3.Location = new System.Drawing.Point(108, 75);
            this.lblAnswerMultiOption3.Name = "lblAnswerMultiOption3";
            this.lblAnswerMultiOption3.Size = new System.Drawing.Size(161, 20);
            this.lblAnswerMultiOption3.TabIndex = 4;
            this.lblAnswerMultiOption3.Text = "Type the answer here";
            // 
            // lblAnswerMultiOption4
            // 
            this.lblAnswerMultiOption4.AutoSize = true;
            this.lblAnswerMultiOption4.Location = new System.Drawing.Point(467, 75);
            this.lblAnswerMultiOption4.Name = "lblAnswerMultiOption4";
            this.lblAnswerMultiOption4.Size = new System.Drawing.Size(161, 20);
            this.lblAnswerMultiOption4.TabIndex = 6;
            this.lblAnswerMultiOption4.Text = "Type the answer here";
            // 
            // lblAnswerMultiOption1
            // 
            this.lblAnswerMultiOption1.AutoSize = true;
            this.lblAnswerMultiOption1.Location = new System.Drawing.Point(108, 10);
            this.lblAnswerMultiOption1.Name = "lblAnswerMultiOption1";
            this.lblAnswerMultiOption1.Size = new System.Drawing.Size(161, 20);
            this.lblAnswerMultiOption1.TabIndex = 0;
            this.lblAnswerMultiOption1.Text = "Type the answer here";
            // 
            // pnlAnswerTrueOrFalse
            // 
            this.pnlAnswerTrueOrFalse.Controls.Add(this.rButonFalse);
            this.pnlAnswerTrueOrFalse.Controls.Add(this.rButtonTrue);
            this.pnlAnswerTrueOrFalse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerTrueOrFalse.Location = new System.Drawing.Point(0, 376);
            this.pnlAnswerTrueOrFalse.Name = "pnlAnswerTrueOrFalse";
            this.pnlAnswerTrueOrFalse.Size = new System.Drawing.Size(745, 50);
            this.pnlAnswerTrueOrFalse.TabIndex = 4;
            // 
            // rButonFalse
            // 
            this.rButonFalse.AutoSize = true;
            this.rButonFalse.Location = new System.Drawing.Point(399, 13);
            this.rButonFalse.Name = "rButonFalse";
            this.rButonFalse.Size = new System.Drawing.Size(66, 24);
            this.rButonFalse.TabIndex = 1;
            this.rButonFalse.TabStop = true;
            this.rButonFalse.Text = "False";
            this.rButonFalse.UseVisualStyleBackColor = true;
            // 
            // rButtonTrue
            // 
            this.rButtonTrue.AutoSize = true;
            this.rButtonTrue.Location = new System.Drawing.Point(277, 13);
            this.rButtonTrue.Name = "rButtonTrue";
            this.rButtonTrue.Size = new System.Drawing.Size(59, 24);
            this.rButtonTrue.TabIndex = 0;
            this.rButtonTrue.TabStop = true;
            this.rButtonTrue.Text = "True";
            this.rButtonTrue.UseVisualStyleBackColor = true;
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.pctBoxLocation);
            this.pnlPicture.Controls.Add(this.pctBoxMap);
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicture.Location = new System.Drawing.Point(0, 426);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(745, 500);
            this.pnlPicture.TabIndex = 5;
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
            this.pctBoxMap.Size = new System.Drawing.Size(745, 500);
            this.pctBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxMap.TabIndex = 0;
            this.pctBoxMap.TabStop = false;
            // 
            // pnlChooseQuestionType
            // 
            this.pnlChooseQuestionType.Controls.Add(this.lblChooseQuestionType);
            this.pnlChooseQuestionType.Controls.Add(this.btnTrueOrFalse);
            this.pnlChooseQuestionType.Controls.Add(this.btnMultipleChoice);
            this.pnlChooseQuestionType.Controls.Add(this.btnPicture);
            this.pnlChooseQuestionType.Controls.Add(this.btnTypeIt);
            this.pnlChooseQuestionType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChooseQuestionType.Location = new System.Drawing.Point(0, 926);
            this.pnlChooseQuestionType.Name = "pnlChooseQuestionType";
            this.pnlChooseQuestionType.Size = new System.Drawing.Size(745, 252);
            this.pnlChooseQuestionType.TabIndex = 6;
            // 
            // lblChooseQuestionType
            // 
            this.lblChooseQuestionType.AutoSize = true;
            this.lblChooseQuestionType.Location = new System.Drawing.Point(217, 24);
            this.lblChooseQuestionType.Name = "lblChooseQuestionType";
            this.lblChooseQuestionType.Size = new System.Drawing.Size(323, 20);
            this.lblChooseQuestionType.TabIndex = 0;
            this.lblChooseQuestionType.Text = "What type of question would you like to add?";
            // 
            // btnTrueOrFalse
            // 
            this.btnTrueOrFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTrueOrFalse.FlatAppearance.BorderSize = 0;
            this.btnTrueOrFalse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTrueOrFalse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnTrueOrFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrueOrFalse.Location = new System.Drawing.Point(399, 70);
            this.btnTrueOrFalse.Name = "btnTrueOrFalse";
            this.btnTrueOrFalse.Size = new System.Drawing.Size(250, 50);
            this.btnTrueOrFalse.TabIndex = 2;
            this.btnTrueOrFalse.Text = "True or False";
            this.btnTrueOrFalse.UseVisualStyleBackColor = false;
            this.btnTrueOrFalse.Click += new System.EventHandler(this.btnTrueOrFalse_Click);
            // 
            // btnMultipleChoice
            // 
            this.btnMultipleChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnMultipleChoice.FlatAppearance.BorderSize = 0;
            this.btnMultipleChoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnMultipleChoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnMultipleChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleChoice.Location = new System.Drawing.Point(85, 168);
            this.btnMultipleChoice.Name = "btnMultipleChoice";
            this.btnMultipleChoice.Size = new System.Drawing.Size(250, 50);
            this.btnMultipleChoice.TabIndex = 3;
            this.btnMultipleChoice.Text = "Multiple Choice";
            this.btnMultipleChoice.UseVisualStyleBackColor = false;
            this.btnMultipleChoice.Click += new System.EventHandler(this.btnMultipleChoice_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(399, 168);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(250, 50);
            this.btnPicture.TabIndex = 4;
            this.btnPicture.Text = "Picture Round";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnTypeIt
            // 
            this.btnTypeIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTypeIt.FlatAppearance.BorderSize = 0;
            this.btnTypeIt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnTypeIt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnTypeIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeIt.Location = new System.Drawing.Point(85, 70);
            this.btnTypeIt.Name = "btnTypeIt";
            this.btnTypeIt.Size = new System.Drawing.Size(250, 50);
            this.btnTypeIt.TabIndex = 1;
            this.btnTypeIt.Text = "Type It";
            this.btnTypeIt.UseVisualStyleBackColor = false;
            this.btnTypeIt.Click += new System.EventHandler(this.btnTypeIt_Click);
            // 
            // frmAddQuestions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(762, 473);
            this.Controls.Add(this.pnlDiffPointsAdd);
            this.Controls.Add(this.pnlChooseQuestionType);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.pnlAnswerTrueOrFalse);
            this.Controls.Add(this.pnlAnswerMulti);
            this.Controls.Add(this.pnlAnswerTypeIt);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlTitleMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmAddQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Questions";
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).EndInit();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.pnlTitleMenu.ResumeLayout(false);
            this.pnlTitleMenu.PerformLayout();
            this.pnlDiffPointsAdd.ResumeLayout(false);
            this.pnlDiffPointsAdd.PerformLayout();
            this.pnlAnswerTypeIt.ResumeLayout(false);
            this.pnlAnswerTypeIt.PerformLayout();
            this.pnlAnswerMulti.ResumeLayout(false);
            this.pnlAnswerMulti.PerformLayout();
            this.pnlAnswerTrueOrFalse.ResumeLayout(false);
            this.pnlAnswerTrueOrFalse.PerformLayout();
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMap)).EndInit();
            this.pnlChooseQuestionType.ResumeLayout(false);
            this.pnlChooseQuestionType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnAImpossible;
        private System.Windows.Forms.RadioButton rBtnTImpossible;
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.NumericUpDown nUDPoints;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Panel pnlTitleMenu;
        private System.Windows.Forms.Panel pnlDiffPointsAdd;
        private System.Windows.Forms.Panel pnlAnswerTypeIt;
        private System.Windows.Forms.Label lblAnswerTypeIt;
        private System.Windows.Forms.TextBox txtBoxTypeItAnswer;
        private System.Windows.Forms.Panel pnlAnswerMulti;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAnswerMultiOption2;
        private System.Windows.Forms.Label lblAnswerMultiOption3;
        private System.Windows.Forms.Label lblAnswerMultiOption4;
        private System.Windows.Forms.Label lblAnswerMultiOption1;
        private System.Windows.Forms.Panel pnlAnswerTrueOrFalse;
        private System.Windows.Forms.RadioButton rButonFalse;
        private System.Windows.Forms.RadioButton rButtonTrue;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox pctBoxLocation;
        private System.Windows.Forms.PictureBox pctBoxMap;
        private System.Windows.Forms.Panel pnlChooseQuestionType;
        private System.Windows.Forms.Button btnTypeIt;
        private System.Windows.Forms.Label lblChooseQuestionType;
        private System.Windows.Forms.Button btnTrueOrFalse;
        private System.Windows.Forms.Button btnMultipleChoice;
        private System.Windows.Forms.Button btnPicture;
    }
}