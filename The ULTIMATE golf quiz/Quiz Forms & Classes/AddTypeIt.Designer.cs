namespace The_ULTIMATE_golf_quiz
{
    partial class AddTypeIt
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.rBtnAImpossible = new System.Windows.Forms.RadioButton();
            this.rBtnTImpossible = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUDPoints = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(31, 18);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 95);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(374, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 44);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Add A Question";
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuestion.Location = new System.Drawing.Point(31, 175);
            this.txtBoxQuestion.MaxLength = 200;
            this.txtBoxQuestion.Multiline = true;
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.Size = new System.Drawing.Size(567, 164);
            this.txtBoxQuestion.TabIndex = 7;
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAnswer.Location = new System.Drawing.Point(31, 396);
            this.txtBoxAnswer.MaxLength = 35;
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(568, 31);
            this.txtBoxAnswer.TabIndex = 8;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(25, 146);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(244, 26);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "Type your question here";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(25, 367);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(232, 26);
            this.lblAnswer.TabIndex = 10;
            this.lblAnswer.Text = "Type your answer here";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(685, 442);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 69);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(612, 367);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(164, 25);
            this.lblPoints.TabIndex = 15;
            this.lblPoints.Text = "Points available";
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Location = new System.Drawing.Point(16, 31);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(78, 29);
            this.rBtnEasy.TabIndex = 21;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.Location = new System.Drawing.Point(16, 60);
            this.rBtnMedium.Name = "rBtnMedium";
            this.rBtnMedium.Size = new System.Drawing.Size(106, 29);
            this.rBtnMedium.TabIndex = 22;
            this.rBtnMedium.TabStop = true;
            this.rBtnMedium.Text = "Medium";
            this.rBtnMedium.UseVisualStyleBackColor = true;
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Location = new System.Drawing.Point(16, 89);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(76, 29);
            this.rBtnHard.TabIndex = 23;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            // 
            // rBtnAImpossible
            // 
            this.rBtnAImpossible.AutoSize = true;
            this.rBtnAImpossible.Location = new System.Drawing.Point(16, 118);
            this.rBtnAImpossible.Name = "rBtnAImpossible";
            this.rBtnAImpossible.Size = new System.Drawing.Size(203, 29);
            this.rBtnAImpossible.TabIndex = 24;
            this.rBtnAImpossible.TabStop = true;
            this.rBtnAImpossible.Text = "Almost Impossible";
            this.rBtnAImpossible.UseVisualStyleBackColor = true;
            // 
            // rBtnTImpossible
            // 
            this.rBtnTImpossible.AutoSize = true;
            this.rBtnTImpossible.Location = new System.Drawing.Point(16, 147);
            this.rBtnTImpossible.Name = "rBtnTImpossible";
            this.rBtnTImpossible.Size = new System.Drawing.Size(257, 29);
            this.rBtnTImpossible.TabIndex = 25;
            this.rBtnTImpossible.TabStop = true;
            this.rBtnTImpossible.Text = "TOTALLY IMPOSSIBLE";
            this.rBtnTImpossible.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnTImpossible);
            this.groupBox1.Controls.Add(this.rBtnEasy);
            this.groupBox1.Controls.Add(this.rBtnAImpossible);
            this.groupBox1.Controls.Add(this.rBtnMedium);
            this.groupBox1.Controls.Add(this.rBtnHard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(617, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 193);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Difficulty";
            // 
            // nUDPoints
            // 
            this.nUDPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDPoints.Location = new System.Drawing.Point(617, 396);
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
            this.nUDPoints.Size = new System.Drawing.Size(122, 31);
            this.nUDPoints.TabIndex = 27;
            this.nUDPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddTypeIt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1016, 566);
            this.Controls.Add(this.nUDPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.txtBoxQuestion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddTypeIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Type It";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.TextBox txtBoxAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnAImpossible;
        private System.Windows.Forms.RadioButton rBtnTImpossible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nUDPoints;
    }
}