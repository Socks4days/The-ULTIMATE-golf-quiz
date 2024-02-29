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
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtBoxConfirm = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError0 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboxPassword = new System.Windows.Forms.CheckBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.txtBoxOriginalPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cBoxNewPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(279, 396);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(219, 54);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Verify";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtBoxConfirm
            // 
            this.txtBoxConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirm.Location = new System.Drawing.Point(176, 315);
            this.txtBoxConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxConfirm.Name = "txtBoxConfirm";
            this.txtBoxConfirm.PasswordChar = '*';
            this.txtBoxConfirm.Size = new System.Drawing.Size(409, 46);
            this.txtBoxConfirm.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(591, 253);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(192, 100);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Password Must Contain:\r\n- 8 - 15 characters\r\n- At least 1 Capital letter\r\n- At le" +
    "ast 1 number\r\n- At least 1 symbol\r\n";
            this.lblError.Visible = false;
            // 
            // lblError0
            // 
            this.lblError0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError0.AutoSize = true;
            this.lblError0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError0.ForeColor = System.Drawing.Color.Red;
            this.lblError0.Location = new System.Drawing.Point(148, 224);
            this.lblError0.Name = "lblError0";
            this.lblError0.Size = new System.Drawing.Size(39, 52);
            this.lblError0.TabIndex = 5;
            this.lblError0.Text = "*";
            this.lblError0.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(129, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(505, 54);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Change your password";
            // 
            // cboxPassword
            // 
            this.cboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxPassword.AutoSize = true;
            this.cboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPassword.ForeColor = System.Drawing.Color.White;
            this.cboxPassword.Location = new System.Drawing.Point(419, 171);
            this.cboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPassword.Name = "cboxPassword";
            this.cboxPassword.Size = new System.Drawing.Size(175, 29);
            this.cboxPassword.TabIndex = 7;
            this.cboxPassword.Text = "Show Password";
            this.cboxPassword.UseVisualStyleBackColor = true;
            this.cboxPassword.CheckedChanged += new System.EventHandler(this.cboxPass_CheckedChanged);
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPassword.Location = new System.Drawing.Point(176, 230);
            this.txtBoxNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.PasswordChar = '*';
            this.txtBoxNewPassword.Size = new System.Drawing.Size(409, 46);
            this.txtBoxNewPassword.TabIndex = 8;
            // 
            // txtBoxOriginalPassword
            // 
            this.txtBoxOriginalPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOriginalPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxOriginalPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOriginalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOriginalPassword.Location = new System.Drawing.Point(175, 127);
            this.txtBoxOriginalPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOriginalPassword.Name = "txtBoxOriginalPassword";
            this.txtBoxOriginalPassword.PasswordChar = '*';
            this.txtBoxOriginalPassword.Size = new System.Drawing.Size(409, 46);
            this.txtBoxOriginalPassword.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(148, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // lblOldPass
            // 
            this.lblOldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.ForeColor = System.Drawing.Color.White;
            this.lblOldPass.Location = new System.Drawing.Point(172, 99);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(191, 25);
            this.lblOldPass.TabIndex = 11;
            this.lblOldPass.Text = "Enter Old Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(175, 283);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(177, 25);
            this.lblConfirmPassword.TabIndex = 12;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(173, 202);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(199, 25);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "Enter New Password:";
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
            // cBoxNewPassword
            // 
            this.cBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxNewPassword.AutoSize = true;
            this.cBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNewPassword.ForeColor = System.Drawing.Color.White;
            this.cBoxNewPassword.Location = new System.Drawing.Point(418, 274);
            this.cBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxNewPassword.Name = "cBoxNewPassword";
            this.cBoxNewPassword.Size = new System.Drawing.Size(175, 29);
            this.cBoxNewPassword.TabIndex = 15;
            this.cBoxNewPassword.Text = "Show Password";
            this.cBoxNewPassword.UseVisualStyleBackColor = true;
            this.cBoxNewPassword.CheckedChanged += new System.EventHandler(this.cBoxNewPassword_CheckedChanged);
            // 
            // frmChangePass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(760, 472);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.txtBoxOriginalPassword);
            this.Controls.Add(this.cboxPassword);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError0);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBoxConfirm);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxNewPassword);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtBoxConfirm;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblError0;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox cboxPassword;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.TextBox txtBoxOriginalPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox cBoxNewPassword;
    }
}