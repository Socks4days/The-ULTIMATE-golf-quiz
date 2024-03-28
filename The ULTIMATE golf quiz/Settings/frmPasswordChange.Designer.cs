namespace The_ULTIMATE_golf_quiz
{
    partial class frmChangePass
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.cboxPassword = new System.Windows.Forms.CheckBox();
            this.lblErrorNew = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorConfirm = new System.Windows.Forms.Label();
            this.lblErrorOld = new System.Windows.Forms.Label();
            this.cBoxNewPassword = new System.Windows.Forms.CheckBox();
            this.txtBoxOriginalPassword = new System.Windows.Forms.TextBox();
            this.cBoxConfirmPassword = new System.Windows.Forms.CheckBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(213, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Change your password";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(12, 11);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 50);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(185, 239);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(197, 26);
            this.lblConfirmPassword.TabIndex = 12;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(183, 158);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(222, 26);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "Enter New Password:";
            // 
            // cboxPassword
            // 
            this.cboxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxPassword.AutoSize = true;
            this.cboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPassword.ForeColor = System.Drawing.Color.White;
            this.cboxPassword.Location = new System.Drawing.Point(414, 132);
            this.cboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPassword.Name = "cboxPassword";
            this.cboxPassword.Size = new System.Drawing.Size(188, 30);
            this.cboxPassword.TabIndex = 7;
            this.cboxPassword.Text = "Show Password";
            this.cboxPassword.UseVisualStyleBackColor = true;
            this.cboxPassword.CheckedChanged += new System.EventHandler(this.cboxPass_CheckedChanged);
            // 
            // lblErrorNew
            // 
            this.lblErrorNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorNew.AutoSize = true;
            this.lblErrorNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblErrorNew.Location = new System.Drawing.Point(158, 180);
            this.lblErrorNew.Name = "lblErrorNew";
            this.lblErrorNew.Size = new System.Drawing.Size(31, 39);
            this.lblErrorNew.TabIndex = 5;
            this.lblErrorNew.Text = "*";
            this.lblErrorNew.Visible = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(180, 343);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(415, 77);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "Error Message\r\n";
            this.lblError.Visible = false;
            // 
            // lblErrorConfirm
            // 
            this.lblErrorConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorConfirm.AutoSize = true;
            this.lblErrorConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblErrorConfirm.Location = new System.Drawing.Point(158, 272);
            this.lblErrorConfirm.Name = "lblErrorConfirm";
            this.lblErrorConfirm.Size = new System.Drawing.Size(31, 39);
            this.lblErrorConfirm.TabIndex = 10;
            this.lblErrorConfirm.Text = "*";
            this.lblErrorConfirm.Visible = false;
            // 
            // lblErrorOld
            // 
            this.lblErrorOld.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorOld.AutoSize = true;
            this.lblErrorOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblErrorOld.Location = new System.Drawing.Point(158, 89);
            this.lblErrorOld.Name = "lblErrorOld";
            this.lblErrorOld.Size = new System.Drawing.Size(31, 39);
            this.lblErrorOld.TabIndex = 22;
            this.lblErrorOld.Text = "*";
            this.lblErrorOld.Visible = false;
            // 
            // cBoxNewPassword
            // 
            this.cBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxNewPassword.AutoSize = true;
            this.cBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNewPassword.ForeColor = System.Drawing.Color.White;
            this.cBoxNewPassword.Location = new System.Drawing.Point(414, 226);
            this.cBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxNewPassword.Name = "cBoxNewPassword";
            this.cBoxNewPassword.Size = new System.Drawing.Size(188, 30);
            this.cBoxNewPassword.TabIndex = 15;
            this.cBoxNewPassword.Text = "Show Password";
            this.cBoxNewPassword.UseVisualStyleBackColor = true;
            this.cBoxNewPassword.CheckedChanged += new System.EventHandler(this.cBoxNewPassword_CheckedChanged);
            // 
            // txtBoxOriginalPassword
            // 
            this.txtBoxOriginalPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxOriginalPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxOriginalPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOriginalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOriginalPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxOriginalPassword.Location = new System.Drawing.Point(185, 92);
            this.txtBoxOriginalPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOriginalPassword.MaxLength = 15;
            this.txtBoxOriginalPassword.Name = "txtBoxOriginalPassword";
            this.txtBoxOriginalPassword.PasswordChar = '*';
            this.txtBoxOriginalPassword.Size = new System.Drawing.Size(409, 37);
            this.txtBoxOriginalPassword.TabIndex = 9;
            this.txtBoxOriginalPassword.TextChanged += new System.EventHandler(this.txtBoxOriginalPassword_TextChanged);
            // 
            // cBoxConfirmPassword
            // 
            this.cBoxConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxConfirmPassword.AutoSize = true;
            this.cBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.cBoxConfirmPassword.Location = new System.Drawing.Point(414, 309);
            this.cBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxConfirmPassword.Name = "cBoxConfirmPassword";
            this.cBoxConfirmPassword.Size = new System.Drawing.Size(188, 30);
            this.cBoxConfirmPassword.TabIndex = 23;
            this.cBoxConfirmPassword.Text = "Show Password";
            this.cBoxConfirmPassword.UseVisualStyleBackColor = true;
            this.cBoxConfirmPassword.CheckedChanged += new System.EventHandler(this.cBoxConfirmPassword_CheckedChanged);
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxNewPassword.Location = new System.Drawing.Point(186, 186);
            this.txtBoxNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNewPassword.MaxLength = 15;
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.PasswordChar = '*';
            this.txtBoxNewPassword.Size = new System.Drawing.Size(409, 37);
            this.txtBoxNewPassword.TabIndex = 8;
            this.txtBoxNewPassword.TextChanged += new System.EventHandler(this.txtBoxNewPassword_TextChanged);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(268, 428);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(250, 50);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Change";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lblOldPass
            // 
            this.lblOldPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.ForeColor = System.Drawing.Color.White;
            this.lblOldPass.Location = new System.Drawing.Point(182, 64);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(212, 26);
            this.lblOldPass.TabIndex = 11;
            this.lblOldPass.Text = "Enter Old Password:";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(186, 271);
            this.txtBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxConfirmPassword.MaxLength = 15;
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.PasswordChar = '*';
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(409, 37);
            this.txtBoxConfirmPassword.TabIndex = 3;
            this.txtBoxConfirmPassword.TextChanged += new System.EventHandler(this.txtBoxConfirmPassword_TextChanged);
            // 
            // frmChangePass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(760, 489);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.cBoxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtBoxOriginalPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.cBoxNewPassword);
            this.Controls.Add(this.cboxPassword);
            this.Controls.Add(this.lblErrorOld);
            this.Controls.Add(this.lblErrorNew);
            this.Controls.Add(this.lblErrorConfirm);
            this.Controls.Add(this.lblError);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.CheckBox cBoxConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxOriginalPassword;
        private System.Windows.Forms.CheckBox cBoxNewPassword;
        private System.Windows.Forms.Label lblErrorOld;
        private System.Windows.Forms.Label lblErrorConfirm;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorNew;
        private System.Windows.Forms.CheckBox cboxPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
    }
}