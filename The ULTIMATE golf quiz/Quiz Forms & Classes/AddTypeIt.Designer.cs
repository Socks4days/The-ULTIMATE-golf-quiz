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
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.nUDPoints = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitleMenu = new System.Windows.Forms.Panel();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.groupBoxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTitleMenu.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(19, 15);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(206, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 54);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Add A Question";
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuestion.Location = new System.Drawing.Point(-12, 124);
            this.txtBoxQuestion.MaxLength = 200;
            this.txtBoxQuestion.Multiline = true;
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.Size = new System.Drawing.Size(423, 124);
            this.txtBoxQuestion.TabIndex = 7;
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAnswer.Location = new System.Drawing.Point(-32, 314);
            this.txtBoxAnswer.MaxLength = 35;
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(423, 37);
            this.txtBoxAnswer.TabIndex = 8;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(-18, 89);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(319, 32);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "Type your question here";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(-18, 262);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(301, 32);
            this.lblAnswer.TabIndex = 10;
            this.lblAnswer.Text = "Type your answer here";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(12, 296);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(47, 198);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(204, 31);
            this.lblPoints.TabIndex = 15;
            this.lblPoints.Text = "Points available";
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.ForeColor = System.Drawing.Color.White;
            this.rBtnEasy.Location = new System.Drawing.Point(16, 31);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(77, 29);
            this.rBtnEasy.TabIndex = 21;
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
            this.rBtnMedium.Size = new System.Drawing.Size(103, 29);
            this.rBtnMedium.TabIndex = 22;
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
            this.rBtnHard.Size = new System.Drawing.Size(75, 29);
            this.rBtnHard.TabIndex = 23;
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
            this.rBtnAImpossible.Size = new System.Drawing.Size(191, 29);
            this.rBtnAImpossible.TabIndex = 24;
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
            this.rBtnTImpossible.Size = new System.Drawing.Size(250, 29);
            this.rBtnTImpossible.TabIndex = 25;
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
            this.groupBoxDifficulty.Location = new System.Drawing.Point(12, 19);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(276, 179);
            this.groupBoxDifficulty.TabIndex = 26;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Select Difficulty";
            // 
            // nUDPoints
            // 
            this.nUDPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDPoints.Location = new System.Drawing.Point(53, 241);
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
            this.nUDPoints.Size = new System.Drawing.Size(198, 37);
            this.nUDPoints.TabIndex = 27;
            this.nUDPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxQuestion);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.txtBoxAnswer);
            this.panel1.Location = new System.Drawing.Point(63, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 120);
            this.panel1.TabIndex = 28;
            // 
            // pnlTitleMenu
            // 
            this.pnlTitleMenu.Controls.Add(this.lblTitle);
            this.pnlTitleMenu.Controls.Add(this.btnReturn);
            this.pnlTitleMenu.Location = new System.Drawing.Point(0, 2);
            this.pnlTitleMenu.Name = "pnlTitleMenu";
            this.pnlTitleMenu.Size = new System.Drawing.Size(738, 100);
            this.pnlTitleMenu.TabIndex = 29;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.btnAdd);
            this.pnlSideMenu.Controls.Add(this.nUDPoints);
            this.pnlSideMenu.Controls.Add(this.groupBoxDifficulty);
            this.pnlSideMenu.Controls.Add(this.lblPoints);
            this.pnlSideMenu.Location = new System.Drawing.Point(370, 139);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(288, 364);
            this.pnlSideMenu.TabIndex = 30;
            // 
            // AddTypeIt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(762, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleMenu);
            this.Controls.Add(this.pnlSideMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddTypeIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Type It";
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPoints)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTitleMenu.ResumeLayout(false);
            this.pnlTitleMenu.PerformLayout();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.NumericUpDown nUDPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTitleMenu;
        private System.Windows.Forms.Panel pnlSideMenu;
    }
}