namespace The_ULTIMATE_golf_quiz
{
    partial class frmResetOrDeleteUser
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
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.columnHeaderUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.listViewPlayers.CheckBoxes = true;
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUsers});
            this.listViewPlayers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listViewPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPlayers.ForeColor = System.Drawing.Color.White;
            this.listViewPlayers.GridLines = true;
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(247, 24);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(271, 376);
            this.listViewPlayers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPlayers.TabIndex = 10;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUsers
            // 
            this.columnHeaderUsers.Text = "Players";
            this.columnHeaderUsers.Width = 250;
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
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "←";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAdvice
            // 
            this.lblAdvice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvice.ForeColor = System.Drawing.Color.White;
            this.lblAdvice.Location = new System.Drawing.Point(22, 83);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(185, 317);
            this.lblAdvice.TabIndex = 13;
            this.lblAdvice.Text = "Instructions";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(257, 420);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(250, 50);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(257, 420);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(250, 50);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmResetOrDeleteUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(764, 481);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmResetOrDeleteUser";
            this.Text = "Player reset or delete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.ColumnHeader columnHeaderUsers;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
    }
}