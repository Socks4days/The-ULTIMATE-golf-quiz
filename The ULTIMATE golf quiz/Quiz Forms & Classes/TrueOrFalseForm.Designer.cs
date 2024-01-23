namespace The_ULTIMATE_golf_quiz
{
    partial class frmTrueOrFalseQuestions
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
            this.lblTypeItQuestion = new System.Windows.Forms.Label();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.lblEnterYourAnswer = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrongAnswer = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTypeItQuestion
            // 
            this.lblTypeItQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeItQuestion.Location = new System.Drawing.Point(28, 112);
            this.lblTypeItQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeItQuestion.Name = "lblTypeItQuestion";
            this.lblTypeItQuestion.Size = new System.Drawing.Size(1003, 137);
            this.lblTypeItQuestion.TabIndex = 0;
            this.lblTypeItQuestion.Text = "Question Text";
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAnswer.Location = new System.Drawing.Point(37, 288);
            this.txtBoxAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAnswer.Multiline = true;
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(355, 73);
            this.txtBoxAnswer.TabIndex = 1;
            // 
            // lblEnterYourAnswer
            // 
            this.lblEnterYourAnswer.AutoSize = true;
            this.lblEnterYourAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterYourAnswer.Location = new System.Drawing.Point(31, 249);
            this.lblEnterYourAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterYourAnswer.Name = "lblEnterYourAnswer";
            this.lblEnterYourAnswer.Size = new System.Drawing.Size(267, 29);
            this.lblEnterYourAnswer.TabIndex = 2;
            this.lblEnterYourAnswer.Text = "Enter your answer here:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(25, 14);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(215, 79);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(436, 284);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(267, 74);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(28, 463);
            this.lblCorrectAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(238, 37);
            this.lblCorrectAnswer.TabIndex = 8;
            this.lblCorrectAnswer.Text = "Correct Answer";
            this.lblCorrectAnswer.Visible = false;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(28, 388);
            this.lblCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(81, 37);
            this.lblCorrect.TabIndex = 9;
            this.lblCorrect.Text = "Yes!";
            this.lblCorrect.Visible = false;
            // 
            // lblWrongAnswer
            // 
            this.lblWrongAnswer.AutoSize = true;
            this.lblWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswer.Location = new System.Drawing.Point(28, 388);
            this.lblWrongAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWrongAnswer.Name = "lblWrongAnswer";
            this.lblWrongAnswer.Size = new System.Drawing.Size(356, 37);
            this.lblWrongAnswer.TabIndex = 10;
            this.lblWrongAnswer.Text = "No - the right answer is:";
            this.lblWrongAnswer.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(797, 457);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(255, 74);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(436, 388);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(267, 74);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Finish Round";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(377, 284);
            this.lblFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(278, 37);
            this.lblFinish.TabIndex = 13;
            this.lblFinish.Text = "View Your Results";
            this.lblFinish.Visible = false;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(702, 14);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(95, 26);
            this.lblDifficulty.TabIndex = 14;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblWrongAnswer);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblEnterYourAnswer);
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.lblTypeItQuestion);
            this.Controls.Add(this.btnFinish);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuestions";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeItQuestion;
        private System.Windows.Forms.TextBox txtBoxAnswer;
        private System.Windows.Forms.Label lblEnterYourAnswer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrongAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblDifficulty;
    }
}