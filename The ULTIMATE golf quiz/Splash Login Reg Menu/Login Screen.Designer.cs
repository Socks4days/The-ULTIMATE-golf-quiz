namespace The_ULTIMATE_golf_quiz
{
    partial class frmLogin
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.cboxPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.submitbtn.FlatAppearance.BorderSize = 0;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(382, 325);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(245, 74);
            this.submitbtn.TabIndex = 2;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.White;
            this.usernamelbl.Location = new System.Drawing.Point(191, 101);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(87, 20);
            this.usernamelbl.TabIndex = 6;
            this.usernamelbl.Text = "Username:";
            // 
            // passwordlbl
            // 
            this.passwordlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.White;
            this.passwordlbl.Location = new System.Drawing.Point(191, 193);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(82, 20);
            this.passwordlbl.TabIndex = 7;
            this.passwordlbl.Text = "Password:";
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.passwordtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxtbox.ForeColor = System.Drawing.Color.White;
            this.passwordtxtbox.Location = new System.Drawing.Point(195, 216);
            this.passwordtxtbox.Multiline = true;
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.PasswordChar = '*';
            this.passwordtxtbox.Size = new System.Drawing.Size(355, 48);
            this.passwordtxtbox.TabIndex = 1;
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernametxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.usernametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxtbox.ForeColor = System.Drawing.Color.White;
            this.usernametxtbox.Location = new System.Drawing.Point(195, 133);
            this.usernametxtbox.Multiline = true;
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(355, 46);
            this.usernametxtbox.TabIndex = 0;
            this.usernametxtbox.WordWrap = false;
            // 
            // registerbtn
            // 
            this.registerbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.registerbtn.FlatAppearance.BorderSize = 0;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.White;
            this.registerbtn.Location = new System.Drawing.Point(131, 325);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(245, 74);
            this.registerbtn.TabIndex = 4;
            this.registerbtn.Text = "Register\r\n";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // cboxPassword
            // 
            this.cboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxPassword.AutoSize = true;
            this.cboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPassword.ForeColor = System.Drawing.Color.White;
            this.cboxPassword.Location = new System.Drawing.Point(409, 270);
            this.cboxPassword.Name = "cboxPassword";
            this.cboxPassword.Size = new System.Drawing.Size(141, 24);
            this.cboxPassword.TabIndex = 10;
            this.cboxPassword.Text = "Show Password";
            this.cboxPassword.UseVisualStyleBackColor = true;
            this.cboxPassword.CheckedChanged += new System.EventHandler(this.cboxPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(760, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxPassword);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.submitbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginfrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.CheckBox cboxPassword;
        private System.Windows.Forms.Label label1;
    }
}

