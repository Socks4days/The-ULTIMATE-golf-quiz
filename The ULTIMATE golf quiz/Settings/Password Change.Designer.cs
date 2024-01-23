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
            this.txtBoxConfirm2 = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError0 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboxPass = new System.Windows.Forms.CheckBox();
            this.txtBoxConfirm1 = new System.Windows.Forms.TextBox();
            this.txtBoxOriginalPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
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
            // txtBoxConfirm2
            // 
            this.txtBoxConfirm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConfirm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxConfirm2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConfirm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirm2.Location = new System.Drawing.Point(176, 340);
            this.txtBoxConfirm2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxConfirm2.Name = "txtBoxConfirm2";
            this.txtBoxConfirm2.PasswordChar = '*';
            this.txtBoxConfirm2.Size = new System.Drawing.Size(409, 37);
            this.txtBoxConfirm2.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(591, 253);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(149, 80);
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
            this.lblError0.Location = new System.Drawing.Point(149, 244);
            this.lblError0.Name = "lblError0";
            this.lblError0.Size = new System.Drawing.Size(31, 39);
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
            this.lblTitle.Location = new System.Drawing.Point(180, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 42);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Change your password";
            // 
            // cboxPass
            // 
            this.cboxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxPass.AutoSize = true;
            this.cboxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPass.ForeColor = System.Drawing.Color.White;
            this.cboxPass.Location = new System.Drawing.Point(443, 188);
            this.cboxPass.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPass.Name = "cboxPass";
            this.cboxPass.Size = new System.Drawing.Size(141, 24);
            this.cboxPass.TabIndex = 7;
            this.cboxPass.Text = "Show Password";
            this.cboxPass.UseVisualStyleBackColor = true;
            this.cboxPass.CheckedChanged += new System.EventHandler(this.cboxPass_CheckedChanged);
            // 
            // txtBoxConfirm1
            // 
            this.txtBoxConfirm1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConfirm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxConfirm1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConfirm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirm1.Location = new System.Drawing.Point(176, 247);
            this.txtBoxConfirm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxConfirm1.Name = "txtBoxConfirm1";
            this.txtBoxConfirm1.PasswordChar = '*';
            this.txtBoxConfirm1.Size = new System.Drawing.Size(409, 37);
            this.txtBoxConfirm1.TabIndex = 8;
            // 
            // txtBoxOriginalPass
            // 
            this.txtBoxOriginalPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOriginalPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.txtBoxOriginalPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOriginalPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOriginalPass.Location = new System.Drawing.Point(175, 145);
            this.txtBoxOriginalPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOriginalPass.Name = "txtBoxOriginalPass";
            this.txtBoxOriginalPass.PasswordChar = '*';
            this.txtBoxOriginalPass.Size = new System.Drawing.Size(409, 37);
            this.txtBoxOriginalPass.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(149, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 39);
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
            this.lblOldPass.Location = new System.Drawing.Point(172, 114);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(153, 20);
            this.lblOldPass.TabIndex = 11;
            this.lblOldPass.Text = "Enter Old Password:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(173, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter New Password:";
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
            // frmChangePass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(760, 472);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxConfirm1);
            this.Controls.Add(this.txtBoxOriginalPass);
            this.Controls.Add(this.cboxPass);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError0);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBoxConfirm2);
            this.Controls.Add(this.btnChangePass);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtBoxConfirm2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblError0;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox cboxPass;
        private System.Windows.Forms.TextBox txtBoxConfirm1;
        private System.Windows.Forms.TextBox txtBoxOriginalPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
    }
}