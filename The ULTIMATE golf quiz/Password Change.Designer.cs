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
            this.lblChangePass = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtBoxChangePass = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(342, 285);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(159, 62);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Verify";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lblChangePass
            // 
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePass.Location = new System.Drawing.Point(297, 136);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(257, 25);
            this.lblChangePass.TabIndex = 1;
            this.lblChangePass.Text = "Enter New Password Below:";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 68);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // txtBoxChangePass
            // 
            this.txtBoxChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxChangePass.Location = new System.Drawing.Point(342, 193);
            this.txtBoxChangePass.Multiline = true;
            this.txtBoxChangePass.Name = "txtBoxChangePass";
            this.txtBoxChangePass.Size = new System.Drawing.Size(159, 53);
            this.txtBoxChangePass.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(527, 193);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(182, 100);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Password Must Contain:\r\n- More than 8 characters\r\n- At least 1 Capital letter\r\n- " +
    "At least 1 number\r\n- At least 1 symbol\r\n";
            this.lblError.Visible = false;
            // 
            // lblError0
            // 
            this.lblError0.AutoSize = true;
            this.lblError0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError0.ForeColor = System.Drawing.Color.Red;
            this.lblError0.Location = new System.Drawing.Point(311, 193);
            this.lblError0.Name = "lblError0";
            this.lblError0.Size = new System.Drawing.Size(25, 32);
            this.lblError0.TabIndex = 5;
            this.lblError0.Text = "*";
            this.lblError0.Visible = false;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(831, 483);
            this.Controls.Add(this.lblError0);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBoxChangePass);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblChangePass);
            this.Controls.Add(this.btnChangePass);
            this.Name = "frmChangePass";
            this.Text = "Password_Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtBoxChangePass;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblError0;
    }
}