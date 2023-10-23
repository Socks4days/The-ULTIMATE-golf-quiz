namespace The_ULTIMATE_golf_quiz
{
    partial class frmReg
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxGender = new System.Windows.Forms.TextBox();
            this.txtBoxNation = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblErrorU = new System.Windows.Forms.Label();
            this.lblErrorP = new System.Windows.Forms.Label();
            this.lblErrorNam = new System.Windows.Forms.Label();
            this.lblErrorA = new System.Windows.Forms.Label();
            this.lblErrorG = new System.Windows.Forms.Label();
            this.lblErrorNat = new System.Windows.Forms.Label();
            this.lblPassError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 468);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(183, 69);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(890, 468);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(181, 71);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(580, 163);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(100, 26);
            this.txtBoxUser.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(580, 221);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 26);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(580, 323);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 26);
            this.txtBoxName.TabIndex = 4;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(580, 369);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(100, 26);
            this.txtBoxAge.TabIndex = 5;
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.Location = new System.Drawing.Point(580, 416);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.Size = new System.Drawing.Size(100, 26);
            this.txtBoxGender.TabIndex = 6;
            // 
            // txtBoxNation
            // 
            this.txtBoxNation.Location = new System.Drawing.Point(580, 461);
            this.txtBoxNation.Name = "txtBoxNation";
            this.txtBoxNation.Size = new System.Drawing.Size(100, 26);
            this.txtBoxNation.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(381, 163);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(130, 29);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(381, 221);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(126, 29);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(437, 322);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(453, 368);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 25);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(428, 417);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.BackColor = System.Drawing.Color.Transparent;
            this.lblNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNation.ForeColor = System.Drawing.Color.Black;
            this.lblNation.Location = new System.Drawing.Point(399, 460);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(108, 25);
            this.lblNation.TabIndex = 13;
            this.lblNation.Text = "Nationality:";
            // 
            // lblErrorU
            // 
            this.lblErrorU.AutoSize = true;
            this.lblErrorU.Location = new System.Drawing.Point(561, 166);
            this.lblErrorU.Name = "lblErrorU";
            this.lblErrorU.Size = new System.Drawing.Size(0, 20);
            this.lblErrorU.TabIndex = 14;
            // 
            // lblErrorP
            // 
            this.lblErrorP.AutoSize = true;
            this.lblErrorP.Location = new System.Drawing.Point(561, 224);
            this.lblErrorP.Name = "lblErrorP";
            this.lblErrorP.Size = new System.Drawing.Size(0, 20);
            this.lblErrorP.TabIndex = 15;
            // 
            // lblErrorNam
            // 
            this.lblErrorNam.AutoSize = true;
            this.lblErrorNam.Location = new System.Drawing.Point(561, 327);
            this.lblErrorNam.Name = "lblErrorNam";
            this.lblErrorNam.Size = new System.Drawing.Size(0, 20);
            this.lblErrorNam.TabIndex = 16;
            // 
            // lblErrorA
            // 
            this.lblErrorA.AutoSize = true;
            this.lblErrorA.Location = new System.Drawing.Point(561, 372);
            this.lblErrorA.Name = "lblErrorA";
            this.lblErrorA.Size = new System.Drawing.Size(0, 20);
            this.lblErrorA.TabIndex = 17;
            // 
            // lblErrorG
            // 
            this.lblErrorG.AutoSize = true;
            this.lblErrorG.Location = new System.Drawing.Point(561, 419);
            this.lblErrorG.Name = "lblErrorG";
            this.lblErrorG.Size = new System.Drawing.Size(0, 20);
            this.lblErrorG.TabIndex = 18;
            // 
            // lblErrorNat
            // 
            this.lblErrorNat.AutoSize = true;
            this.lblErrorNat.Location = new System.Drawing.Point(561, 465);
            this.lblErrorNat.Name = "lblErrorNat";
            this.lblErrorNat.Size = new System.Drawing.Size(0, 20);
            this.lblErrorNat.TabIndex = 19;
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblPassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassError.ForeColor = System.Drawing.Color.Red;
            this.lblPassError.Location = new System.Drawing.Point(746, 220);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(219, 125);
            this.lblPassError.TabIndex = 20;
            this.lblPassError.Text = "Password must contain:\r\n- At least 8 characters\r\n- At least 1 number\r\n- At least " +
    "1 capital\r\n- At least 1 symbol\r\n";
            this.lblPassError.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(329, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 40);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "The Ultimate Golf Quiz!";
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 551);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassError);
            this.Controls.Add(this.lblErrorNat);
            this.Controls.Add(this.lblErrorG);
            this.Controls.Add(this.lblErrorA);
            this.Controls.Add(this.lblErrorNam);
            this.Controls.Add(this.lblErrorP);
            this.Controls.Add(this.lblErrorU);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtBoxNation);
            this.Controls.Add(this.txtBoxGender);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnReset);
            this.Name = "frmReg";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxGender;
        private System.Windows.Forms.TextBox txtBoxNation;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblErrorU;
        private System.Windows.Forms.Label lblErrorP;
        private System.Windows.Forms.Label lblErrorNam;
        private System.Windows.Forms.Label lblErrorA;
        private System.Windows.Forms.Label lblErrorG;
        private System.Windows.Forms.Label lblErrorNat;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.Label lblTitle;
    }
}