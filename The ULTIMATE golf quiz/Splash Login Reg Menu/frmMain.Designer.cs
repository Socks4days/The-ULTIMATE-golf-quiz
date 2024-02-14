namespace The_ULTIMATE_golf_quiz
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlAdminSubMenu = new System.Windows.Forms.Panel();
            this.btnDeleteUserAccount = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlSettingsSubMenu = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnGoToQuiz = new System.Windows.Forms.Button();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.pctBoxAvatar = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.pnlFormContainer = new System.Windows.Forms.Panel();
            this.lblUltimateGolfQuiz = new System.Windows.Forms.Label();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAddQuestions = new System.Windows.Forms.Button();
            this.pnlSideMenu.SuspendLayout();
            this.pnlAdminSubMenu.SuspendLayout();
            this.pnlSettingsSubMenu.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAvatar)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlSideMenu.Controls.Add(this.btnLogout);
            this.pnlSideMenu.Controls.Add(this.pnlAdminSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnAdmin);
            this.pnlSideMenu.Controls.Add(this.pnlSettingsSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnSettings);
            this.pnlSideMenu.Controls.Add(this.btnLeaderboard);
            this.pnlSideMenu.Controls.Add(this.btnGoToQuiz);
            this.pnlSideMenu.Controls.Add(this.pnlAvatar);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 555);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 758);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(233, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlAdminSubMenu
            // 
            this.pnlAdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlAdminSubMenu.Controls.Add(this.btnAddQuestions);
            this.pnlAdminSubMenu.Controls.Add(this.btnDeleteUserAccount);
            this.pnlAdminSubMenu.Controls.Add(this.btnResetPassword);
            this.pnlAdminSubMenu.Controls.Add(this.btnViewUsers);
            this.pnlAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminSubMenu.Location = new System.Drawing.Point(0, 553);
            this.pnlAdminSubMenu.Name = "pnlAdminSubMenu";
            this.pnlAdminSubMenu.Size = new System.Drawing.Size(233, 205);
            this.pnlAdminSubMenu.TabIndex = 6;
            // 
            // btnDeleteUserAccount
            // 
            this.btnDeleteUserAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteUserAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteUserAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnDeleteUserAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnDeleteUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUserAccount.Location = new System.Drawing.Point(0, 100);
            this.btnDeleteUserAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUserAccount.Name = "btnDeleteUserAccount";
            this.btnDeleteUserAccount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDeleteUserAccount.Size = new System.Drawing.Size(233, 50);
            this.btnDeleteUserAccount.TabIndex = 6;
            this.btnDeleteUserAccount.Text = "Delete user account";
            this.btnDeleteUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUserAccount.UseVisualStyleBackColor = true;
            this.btnDeleteUserAccount.Click += new System.EventHandler(this.btnDeleteUserAccount_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(0, 50);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnResetPassword.Size = new System.Drawing.Size(233, 50);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "Reset password";
            this.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewUsers.FlatAppearance.BorderSize = 0;
            this.btnViewUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnViewUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.ForeColor = System.Drawing.Color.White;
            this.btnViewUsers.Location = new System.Drawing.Point(0, 0);
            this.btnViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnViewUsers.Size = new System.Drawing.Size(233, 50);
            this.btnViewUsers.TabIndex = 4;
            this.btnViewUsers.Text = "View users";
            this.btnViewUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 503);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(233, 50);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlSettingsSubMenu
            // 
            this.pnlSettingsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlSettingsSubMenu.Controls.Add(this.btnReset);
            this.pnlSettingsSubMenu.Controls.Add(this.btnDeleteAccount);
            this.pnlSettingsSubMenu.Controls.Add(this.btnChangePassword);
            this.pnlSettingsSubMenu.Controls.Add(this.btnChangeAvatar);
            this.pnlSettingsSubMenu.Controls.Add(this.btnUserInfo);
            this.pnlSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettingsSubMenu.Location = new System.Drawing.Point(0, 250);
            this.pnlSettingsSubMenu.Name = "pnlSettingsSubMenu";
            this.pnlSettingsSubMenu.Size = new System.Drawing.Size(233, 253);
            this.pnlSettingsSubMenu.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(0, 200);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReset.Size = new System.Drawing.Size(233, 50);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Account";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(0, 150);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDeleteAccount.Size = new System.Drawing.Size(233, 50);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete account";
            this.btnDeleteAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 100);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(233, 50);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeAvatar.FlatAppearance.BorderSize = 0;
            this.btnChangeAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnChangeAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnChangeAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAvatar.ForeColor = System.Drawing.Color.White;
            this.btnChangeAvatar.Location = new System.Drawing.Point(0, 50);
            this.btnChangeAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnChangeAvatar.Size = new System.Drawing.Size(233, 50);
            this.btnChangeAvatar.TabIndex = 5;
            this.btnChangeAvatar.Text = "Change avatar";
            this.btnChangeAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUserInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnUserInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 0);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUserInfo.Size = new System.Drawing.Size(233, 50);
            this.btnUserInfo.TabIndex = 4;
            this.btnUserInfo.Text = "User info";
            this.btnUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 200);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(233, 50);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeaderboard.FlatAppearance.BorderSize = 0;
            this.btnLeaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderboard.Location = new System.Drawing.Point(0, 150);
            this.btnLeaderboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLeaderboard.Size = new System.Drawing.Size(233, 50);
            this.btnLeaderboard.TabIndex = 2;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnGoToQuiz
            // 
            this.btnGoToQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoToQuiz.FlatAppearance.BorderSize = 0;
            this.btnGoToQuiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnGoToQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnGoToQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToQuiz.ForeColor = System.Drawing.Color.White;
            this.btnGoToQuiz.Location = new System.Drawing.Point(0, 100);
            this.btnGoToQuiz.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToQuiz.Name = "btnGoToQuiz";
            this.btnGoToQuiz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGoToQuiz.Size = new System.Drawing.Size(233, 50);
            this.btnGoToQuiz.TabIndex = 1;
            this.btnGoToQuiz.Text = "To the Quiz!";
            this.btnGoToQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToQuiz.UseVisualStyleBackColor = true;
            this.btnGoToQuiz.Click += new System.EventHandler(this.btnGoToQuiz_Click);
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Controls.Add(this.pctBoxAvatar);
            this.pnlAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvatar.Location = new System.Drawing.Point(0, 0);
            this.pnlAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(233, 100);
            this.pnlAvatar.TabIndex = 0;
            // 
            // pctBoxAvatar
            // 
            this.pctBoxAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxAvatar.Location = new System.Drawing.Point(59, 0);
            this.pctBoxAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pctBoxAvatar.Name = "pctBoxAvatar";
            this.pctBoxAvatar.Size = new System.Drawing.Size(113, 96);
            this.pctBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxAvatar.TabIndex = 0;
            this.pctBoxAvatar.TabStop = false;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlTitleBar.Controls.Add(this.btnQuit);
            this.pnlTitleBar.Controls.Add(this.lblGamesPlayed);
            this.pnlTitleBar.Controls.Add(this.lblHighscore);
            this.pnlTitleBar.Controls.Add(this.lblCurrentUser);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(250, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(740, 50);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(490, 0);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(250, 50);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGamesPlayed.ForeColor = System.Drawing.Color.White;
            this.lblGamesPlayed.Location = new System.Drawing.Point(203, 0);
            this.lblGamesPlayed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblGamesPlayed.Size = new System.Drawing.Size(116, 35);
            this.lblGamesPlayed.TabIndex = 2;
            this.lblGamesPlayed.Text = "Games Played:";
            this.lblGamesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHighscore.ForeColor = System.Drawing.Color.White;
            this.lblHighscore.Location = new System.Drawing.Point(118, 0);
            this.lblHighscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblHighscore.Size = new System.Drawing.Size(85, 35);
            this.lblHighscore.TabIndex = 1;
            this.lblHighscore.Text = "Highscore:";
            this.lblHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCurrentUser.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.lblCurrentUser.Size = new System.Drawing.Size(118, 35);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Current User: ";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFormContainer
            // 
            this.pnlFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlFormContainer.Controls.Add(this.lblUltimateGolfQuiz);
            this.pnlFormContainer.Controls.Add(this.pctBoxLogo);
            this.pnlFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContainer.Location = new System.Drawing.Point(250, 50);
            this.pnlFormContainer.Name = "pnlFormContainer";
            this.pnlFormContainer.Size = new System.Drawing.Size(740, 505);
            this.pnlFormContainer.TabIndex = 2;
            // 
            // lblUltimateGolfQuiz
            // 
            this.lblUltimateGolfQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUltimateGolfQuiz.AutoSize = true;
            this.lblUltimateGolfQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimateGolfQuiz.ForeColor = System.Drawing.Color.White;
            this.lblUltimateGolfQuiz.Location = new System.Drawing.Point(193, 113);
            this.lblUltimateGolfQuiz.Name = "lblUltimateGolfQuiz";
            this.lblUltimateGolfQuiz.Size = new System.Drawing.Size(404, 37);
            this.lblUltimateGolfQuiz.TabIndex = 1;
            this.lblUltimateGolfQuiz.Text = "The ULTIMATE Golf Quiz";
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBoxLogo.Image = global::The_ULTIMATE_golf_quiz.Properties.Resources.Golf_logo3;
            this.pctBoxLogo.Location = new System.Drawing.Point(239, 119);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(288, 239);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 0;
            this.pctBoxLogo.TabStop = false;
            // 
            // btnAddQuestions
            // 
            this.btnAddQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddQuestions.FlatAppearance.BorderSize = 0;
            this.btnAddQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnAddQuestions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.btnAddQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestions.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestions.Location = new System.Drawing.Point(0, 150);
            this.btnAddQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAddQuestions.Size = new System.Drawing.Size(233, 50);
            this.btnAddQuestions.TabIndex = 7;
            this.btnAddQuestions.Text = "Add Questions";
            this.btnAddQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddQuestions.UseVisualStyleBackColor = true;
            this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(990, 555);
            this.Controls.Add(this.pnlFormContainer);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1006, 589);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The ULTIMATE Golf Quiz";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlAdminSubMenu.ResumeLayout(false);
            this.pnlSettingsSubMenu.ResumeLayout(false);
            this.pnlAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAvatar)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlFormContainer.ResumeLayout(false);
            this.pnlFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Button btnGoToQuiz;
        private System.Windows.Forms.Panel pnlSettingsSubMenu;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Panel pnlAdminSubMenu;
        private System.Windows.Forms.Button btnDeleteUserAccount;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlFormContainer;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Label lblUltimateGolfQuiz;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.PictureBox pctBoxAvatar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddQuestions;
    }
}