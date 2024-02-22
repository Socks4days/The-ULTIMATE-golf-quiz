namespace The_ULTIMATE_golf_quiz
{
    partial class frmRegisterUser
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
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblFadeUser = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboxAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(310, 401);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(188, 41);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(526, 401);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(188, 41);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.ForeColor = System.Drawing.Color.White;
            this.txtBoxUser.Location = new System.Drawing.Point(136, 145);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(238, 28);
            this.txtBoxUser.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxPassword.Location = new System.Drawing.Point(136, 204);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(238, 28);
            this.txtBoxPassword.TabIndex = 1;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.ForeColor = System.Drawing.Color.White;
            this.txtBoxName.Location = new System.Drawing.Point(136, 265);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(238, 28);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.txtBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.ForeColor = System.Drawing.Color.White;
            this.txtBoxAge.Location = new System.Drawing.Point(486, 140);
            this.txtBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(219, 28);
            this.txtBoxAge.TabIndex = 3;
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.txtBoxGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGender.ForeColor = System.Drawing.Color.White;
            this.txtBoxGender.Location = new System.Drawing.Point(486, 205);
            this.txtBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.Size = new System.Drawing.Size(219, 28);
            this.txtBoxGender.TabIndex = 4;
            // 
            // txtBoxNation
            // 
            this.txtBoxNation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.txtBoxNation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNation.ForeColor = System.Drawing.Color.White;
            this.txtBoxNation.Location = new System.Drawing.Point(486, 265);
            this.txtBoxNation.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNation.Name = "txtBoxNation";
            this.txtBoxNation.Size = new System.Drawing.Size(219, 28);
            this.txtBoxNation.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(49, 143);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 20);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(49, 201);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 20);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(51, 271);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(400, 140);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(400, 205);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.BackColor = System.Drawing.Color.Transparent;
            this.lblNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNation.ForeColor = System.Drawing.Color.White;
            this.lblNation.Location = new System.Drawing.Point(400, 269);
            this.lblNation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(86, 20);
            this.lblNation.TabIndex = 13;
            this.lblNation.Text = "Nationality:";
            // 
            // lblErrorU
            // 
            this.lblErrorU.AutoSize = true;
            this.lblErrorU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorU.ForeColor = System.Drawing.Color.Red;
            this.lblErrorU.Location = new System.Drawing.Point(34, 143);
            this.lblErrorU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorU.Name = "lblErrorU";
            this.lblErrorU.Size = new System.Drawing.Size(23, 29);
            this.lblErrorU.TabIndex = 14;
            this.lblErrorU.Text = "*";
            this.lblErrorU.Visible = false;
            // 
            // lblErrorP
            // 
            this.lblErrorP.AutoSize = true;
            this.lblErrorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorP.ForeColor = System.Drawing.Color.Red;
            this.lblErrorP.Location = new System.Drawing.Point(29, 200);
            this.lblErrorP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorP.Name = "lblErrorP";
            this.lblErrorP.Size = new System.Drawing.Size(23, 29);
            this.lblErrorP.TabIndex = 15;
            this.lblErrorP.Text = "*";
            this.lblErrorP.Visible = false;
            // 
            // lblErrorNam
            // 
            this.lblErrorNam.AutoSize = true;
            this.lblErrorNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNam.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNam.Location = new System.Drawing.Point(384, 269);
            this.lblErrorNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorNam.Name = "lblErrorNam";
            this.lblErrorNam.Size = new System.Drawing.Size(23, 29);
            this.lblErrorNam.TabIndex = 16;
            this.lblErrorNam.Text = "*";
            this.lblErrorNam.Visible = false;
            // 
            // lblErrorA
            // 
            this.lblErrorA.AutoSize = true;
            this.lblErrorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorA.ForeColor = System.Drawing.Color.Red;
            this.lblErrorA.Location = new System.Drawing.Point(384, 136);
            this.lblErrorA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorA.Name = "lblErrorA";
            this.lblErrorA.Size = new System.Drawing.Size(23, 29);
            this.lblErrorA.TabIndex = 17;
            this.lblErrorA.Text = "*";
            this.lblErrorA.Visible = false;
            // 
            // lblErrorG
            // 
            this.lblErrorG.AutoSize = true;
            this.lblErrorG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorG.ForeColor = System.Drawing.Color.Red;
            this.lblErrorG.Location = new System.Drawing.Point(384, 208);
            this.lblErrorG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorG.Name = "lblErrorG";
            this.lblErrorG.Size = new System.Drawing.Size(23, 29);
            this.lblErrorG.TabIndex = 18;
            this.lblErrorG.Text = "*";
            this.lblErrorG.Visible = false;
            // 
            // lblErrorNat
            // 
            this.lblErrorNat.AutoSize = true;
            this.lblErrorNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNat.Location = new System.Drawing.Point(34, 271);
            this.lblErrorNat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorNat.Name = "lblErrorNat";
            this.lblErrorNat.Size = new System.Drawing.Size(23, 29);
            this.lblErrorNat.TabIndex = 19;
            this.lblErrorNat.Text = "*";
            this.lblErrorNat.Visible = false;
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblPassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassError.ForeColor = System.Drawing.Color.Red;
            this.lblPassError.Location = new System.Drawing.Point(62, 332);
            this.lblPassError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(177, 100);
            this.lblPassError.TabIndex = 20;
            this.lblPassError.Text = "Password must contain:\r\n- 8 - 12 characters\r\n- At least 1 number\r\n- At least 1 ca" +
    "pital\r\n- At least 1 symbol\r\n";
            this.lblPassError.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(257, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 58);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "The Ultimate Golf Quiz!\r\n             Register ";
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxLogo.Location = new System.Drawing.Point(555, 8);
            this.pctBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(158, 98);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 22;
            this.pctBoxLogo.TabStop = false;
            // 
            // lblFadeUser
            // 
            this.lblFadeUser.AutoSize = true;
            this.lblFadeUser.BackColor = System.Drawing.Color.Transparent;
            this.lblFadeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFadeUser.Location = new System.Drawing.Point(50, 112);
            this.lblFadeUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFadeUser.Name = "lblFadeUser";
            this.lblFadeUser.Size = new System.Drawing.Size(350, 18);
            this.lblFadeUser.TabIndex = 23;
            this.lblFadeUser.Text = "Enter desired username, password and other details";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(16, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 41);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "←\r\n";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboxAdmin
            // 
            this.cboxAdmin.AutoSize = true;
            this.cboxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAdmin.Location = new System.Drawing.Point(555, 309);
            this.cboxAdmin.Name = "cboxAdmin";
            this.cboxAdmin.Size = new System.Drawing.Size(156, 24);
            this.cboxAdmin.TabIndex = 24;
            this.cboxAdmin.Text = "Register as admin";
            this.cboxAdmin.UseVisualStyleBackColor = true;
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 466);
            this.Controls.Add(this.cboxAdmin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFadeUser);
            this.Controls.Add(this.pctBoxLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassError);
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
            this.Controls.Add(this.lblErrorNat);
            this.Controls.Add(this.lblErrorA);
            this.Controls.Add(this.lblErrorG);
            this.Controls.Add(this.lblErrorNam);
            this.Controls.Add(this.lblErrorU);
            this.Controls.Add(this.lblErrorP);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReg_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Label lblFadeUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cboxAdmin;
    }
}