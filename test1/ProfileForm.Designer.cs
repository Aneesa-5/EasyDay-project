namespace EasyDay_SignUp
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            picProfile = new PictureBox();
            lblName = new Label();
            lblRole = new Label();
            languageRow = new Panel();
            lblLanguageArrow = new Label();
            lblLanguageValue = new Label();
            lblLanguageTitle = new Label();
            notificationsRow = new Panel();
            label1 = new Label();
            lblNotificationsTitle = new Label();
            changePasswordRow = new Panel();
            label4 = new Label();
            lblChangePasswordTitle = new Label();
            aboutRow = new Panel();
            label7 = new Label();
            lblAboutTitle = new Label();
            logoutRow = new Panel();
            label10 = new Label();
            label11 = new Label();
            lblLogoutTitle = new Label();
            navPanel = new Panel();
            lblNavProfile = new Label();
            lblNavMessages = new Label();
            lblNavTasks = new Label();
            lblNavHome = new Label();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            languageRow.SuspendLayout();
            notificationsRow.SuspendLayout();
            changePasswordRow.SuspendLayout();
            aboutRow.SuspendLayout();
            logoutRow.SuspendLayout();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // picProfile
            // 
            picProfile.BorderStyle = BorderStyle.FixedSingle;
            picProfile.Image = (Image)resources.GetObject("picProfile.Image");
            picProfile.Location = new Point(30, 20);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(80, 80);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblName.Location = new Point(130, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 38);
            lblName.TabIndex = 1;
            lblName.Text = "Rahman";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = SystemColors.ControlDarkDark;
            lblRole.Location = new Point(136, 68);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(119, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "Packaging Line 2";
            // 
            // languageRow
            // 
            languageRow.Controls.Add(lblLanguageArrow);
            languageRow.Controls.Add(lblLanguageValue);
            languageRow.Controls.Add(lblLanguageTitle);
            languageRow.Cursor = Cursors.Hand;
            languageRow.Location = new Point(30, 128);
            languageRow.Name = "languageRow";
            languageRow.Size = new Size(740, 45);
            languageRow.TabIndex = 3;
            // 
            // lblLanguageArrow
            // 
            lblLanguageArrow.AutoSize = true;
            lblLanguageArrow.Location = new Point(700, 12);
            lblLanguageArrow.Name = "lblLanguageArrow";
            lblLanguageArrow.Size = new Size(19, 20);
            lblLanguageArrow.TabIndex = 2;
            lblLanguageArrow.Text = ">";
            // 
            // lblLanguageValue
            // 
            lblLanguageValue.AutoSize = true;
            lblLanguageValue.Location = new Point(550, 12);
            lblLanguageValue.Name = "lblLanguageValue";
            lblLanguageValue.Size = new Size(55, 20);
            lblLanguageValue.TabIndex = 1;
            lblLanguageValue.Text = "Bangla";
            // 
            // lblLanguageTitle
            // 
            lblLanguageTitle.AutoSize = true;
            lblLanguageTitle.Location = new Point(10, 12);
            lblLanguageTitle.Name = "lblLanguageTitle";
            lblLanguageTitle.Size = new Size(74, 20);
            lblLanguageTitle.TabIndex = 0;
            lblLanguageTitle.Text = "Language";
            // 
            // notificationsRow
            // 
            notificationsRow.Controls.Add(label1);
            notificationsRow.Controls.Add(lblNotificationsTitle);
            notificationsRow.Cursor = Cursors.Hand;
            notificationsRow.Location = new Point(30, 183);
            notificationsRow.Name = "notificationsRow";
            notificationsRow.Size = new Size(740, 45);
            notificationsRow.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(700, 12);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = ">";
            // 
            // lblNotificationsTitle
            // 
            lblNotificationsTitle.AutoSize = true;
            lblNotificationsTitle.Location = new Point(10, 12);
            lblNotificationsTitle.Name = "lblNotificationsTitle";
            lblNotificationsTitle.Size = new Size(145, 20);
            lblNotificationsTitle.TabIndex = 0;
            lblNotificationsTitle.Text = "Notification Settings";
            // 
            // changePasswordRow
            // 
            changePasswordRow.Controls.Add(label4);
            changePasswordRow.Controls.Add(lblChangePasswordTitle);
            changePasswordRow.Cursor = Cursors.Hand;
            changePasswordRow.Location = new Point(30, 238);
            changePasswordRow.Name = "changePasswordRow";
            changePasswordRow.Size = new Size(740, 45);
            changePasswordRow.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(700, 12);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 2;
            label4.Text = ">";
            // 
            // lblChangePasswordTitle
            // 
            lblChangePasswordTitle.AutoSize = true;
            lblChangePasswordTitle.Location = new Point(10, 12);
            lblChangePasswordTitle.Name = "lblChangePasswordTitle";
            lblChangePasswordTitle.Size = new Size(124, 20);
            lblChangePasswordTitle.TabIndex = 0;
            lblChangePasswordTitle.Text = "Change Password";
            // 
            // aboutRow
            // 
            aboutRow.Controls.Add(label7);
            aboutRow.Controls.Add(lblAboutTitle);
            aboutRow.Cursor = Cursors.Hand;
            aboutRow.Location = new Point(30, 293);
            aboutRow.Name = "aboutRow";
            aboutRow.Size = new Size(740, 45);
            aboutRow.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(700, 12);
            label7.Name = "label7";
            label7.Size = new Size(19, 20);
            label7.TabIndex = 2;
            label7.Text = ">";
            // 
            // lblAboutTitle
            // 
            lblAboutTitle.AutoSize = true;
            lblAboutTitle.Location = new Point(10, 12);
            lblAboutTitle.Name = "lblAboutTitle";
            lblAboutTitle.Size = new Size(109, 20);
            lblAboutTitle.TabIndex = 0;
            lblAboutTitle.Text = "About EasyDay";
            // 
            // logoutRow
            // 
            logoutRow.Controls.Add(label10);
            logoutRow.Controls.Add(label11);
            logoutRow.Controls.Add(lblLogoutTitle);
            logoutRow.Cursor = Cursors.Hand;
            logoutRow.Location = new Point(31, 351);
            logoutRow.Name = "logoutRow";
            logoutRow.Size = new Size(740, 45);
            logoutRow.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(700, 12);
            label10.Name = "label10";
            label10.Size = new Size(19, 20);
            label10.TabIndex = 2;
            label10.Text = ">";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 360);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 1;
            label11.Text = "Bangla";
            // 
            // lblLogoutTitle
            // 
            lblLogoutTitle.AutoSize = true;
            lblLogoutTitle.ForeColor = Color.OrangeRed;
            lblLogoutTitle.Location = new Point(10, 12);
            lblLogoutTitle.Name = "lblLogoutTitle";
            lblLogoutTitle.Size = new Size(62, 20);
            lblLogoutTitle.TabIndex = 0;
            lblLogoutTitle.Text = "Log Out";
            // 
            // navPanel
            // 
            navPanel.Controls.Add(lblNavProfile);
            navPanel.Controls.Add(lblNavMessages);
            navPanel.Controls.Add(lblNavTasks);
            navPanel.Controls.Add(lblNavHome);
            navPanel.Location = new Point(21, 402);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(750, 45);
            navPanel.TabIndex = 7;
            // 
            // lblNavProfile
            // 
            lblNavProfile.AutoSize = true;
            lblNavProfile.BackColor = Color.Blue;
            lblNavProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavProfile.ForeColor = Color.Snow;
            lblNavProfile.Location = new Point(660, 15);
            lblNavProfile.Name = "lblNavProfile";
            lblNavProfile.Size = new Size(55, 20);
            lblNavProfile.TabIndex = 3;
            lblNavProfile.Text = "Profile";
            // 
            // lblNavMessages
            // 
            lblNavMessages.AutoSize = true;
            lblNavMessages.BackColor = Color.Blue;
            lblNavMessages.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavMessages.ForeColor = Color.Snow;
            lblNavMessages.Location = new Point(460, 15);
            lblNavMessages.Name = "lblNavMessages";
            lblNavMessages.Size = new Size(77, 20);
            lblNavMessages.TabIndex = 2;
            lblNavMessages.Text = "Messages";
            // 
            // lblNavTasks
            // 
            lblNavTasks.AutoSize = true;
            lblNavTasks.BackColor = Color.Blue;
            lblNavTasks.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavTasks.ForeColor = Color.Snow;
            lblNavTasks.Location = new Point(260, 15);
            lblNavTasks.Name = "lblNavTasks";
            lblNavTasks.Size = new Size(47, 20);
            lblNavTasks.TabIndex = 1;
            lblNavTasks.Text = "Tasks";
            // 
            // lblNavHome
            // 
            lblNavHome.AutoSize = true;
            lblNavHome.BackColor = Color.Blue;
            lblNavHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavHome.ForeColor = Color.Snow;
            lblNavHome.Location = new Point(60, 15);
            lblNavHome.Name = "lblNavHome";
            lblNavHome.Size = new Size(51, 20);
            lblNavHome.TabIndex = 0;
            lblNavHome.Text = "Home";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(782, 453);
            Controls.Add(navPanel);
            Controls.Add(changePasswordRow);
            Controls.Add(aboutRow);
            Controls.Add(logoutRow);
            Controls.Add(notificationsRow);
            Controls.Add(languageRow);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Controls.Add(picProfile);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            languageRow.ResumeLayout(false);
            languageRow.PerformLayout();
            notificationsRow.ResumeLayout(false);
            notificationsRow.PerformLayout();
            changePasswordRow.ResumeLayout(false);
            changePasswordRow.PerformLayout();
            aboutRow.ResumeLayout(false);
            aboutRow.PerformLayout();
            logoutRow.ResumeLayout(false);
            logoutRow.PerformLayout();
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProfile;
        private Label lblName;
        private Label lblRole;
        private Panel languageRow;
        private Label lblLanguageArrow;
        private Label lblLanguageValue;
        private Label lblLanguageTitle;
        private Panel notificationsRow;
        private Label label1;
        private Label lblNotificationsTitle;
        private Panel changePasswordRow;
        private Label label4;
        private Label lblChangePasswordTitle;
        private Panel aboutRow;
        private Label label7;
        private Label lblAboutTitle;
        private Panel logoutRow;
        private Label label10;
        private Label label11;
        private Label lblLogoutTitle;
        private Panel navPanel;
        private Label lblNavProfile;
        private Label lblNavMessages;
        private Label lblNavTasks;
        private Label lblNavHome;
    }
}