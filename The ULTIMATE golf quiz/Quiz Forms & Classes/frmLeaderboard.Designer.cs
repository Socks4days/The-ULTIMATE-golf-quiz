namespace The_ULTIMATE_golf_quiz
{
    partial class frmLeaderboard
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
            this.lblLeaderboard = new System.Windows.Forms.Label();
            this.listViewLeaderboard = new System.Windows.Forms.ListView();
            this.columnHeaderPlayer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHighscore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLeaderboard
            // 
            this.lblLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeaderboard.AutoSize = true;
            this.lblLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderboard.ForeColor = System.Drawing.Color.White;
            this.lblLeaderboard.Location = new System.Drawing.Point(255, 15);
            this.lblLeaderboard.Name = "lblLeaderboard";
            this.lblLeaderboard.Size = new System.Drawing.Size(277, 46);
            this.lblLeaderboard.TabIndex = 0;
            this.lblLeaderboard.Text = "Top Standings";
            // 
            // listViewLeaderboard
            // 
            this.listViewLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.listViewLeaderboard.BackgroundImageTiled = true;
            this.listViewLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPlayer,
            this.columnHeaderHighscore});
            this.listViewLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLeaderboard.ForeColor = System.Drawing.Color.White;
            this.listViewLeaderboard.GridLines = true;
            this.listViewLeaderboard.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewLeaderboard.HideSelection = false;
            this.listViewLeaderboard.LabelWrap = false;
            this.listViewLeaderboard.Location = new System.Drawing.Point(156, 76);
            this.listViewLeaderboard.Name = "listViewLeaderboard";
            this.listViewLeaderboard.Size = new System.Drawing.Size(424, 373);
            this.listViewLeaderboard.TabIndex = 6;
            this.listViewLeaderboard.UseCompatibleStateImageBehavior = false;
            this.listViewLeaderboard.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPlayer
            // 
            this.columnHeaderPlayer.Text = "Player";
            this.columnHeaderPlayer.Width = 200;
            // 
            // columnHeaderHighscore
            // 
            this.columnHeaderHighscore.Text = "Highscore";
            this.columnHeaderHighscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderHighscore.Width = 200;
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
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmLeaderboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(760, 472);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.listViewLeaderboard);
            this.Controls.Add(this.lblLeaderboard);
            this.Name = "frmLeaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeaderboard;
        private System.Windows.Forms.ListView listViewLeaderboard;
        private System.Windows.Forms.ColumnHeader columnHeaderPlayer;
        private System.Windows.Forms.ColumnHeader columnHeaderHighscore;
        private System.Windows.Forms.Button btnReturn;
    }
}