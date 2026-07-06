namespace EasyDay_SignUp
{
    partial class NotificationSettingsForm
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
            label1 = new Label();
            chkTaskReminders = new CheckBox();
            chkMessages = new CheckBox();
            chkEmergencyAlerts = new CheckBox();
            btnSaveNotifications = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(239, 31);
            label1.TabIndex = 0;
            label1.Text = "Notification Settings";
            // 
            // chkTaskReminders
            // 
            chkTaskReminders.AutoSize = true;
            chkTaskReminders.Location = new Point(20, 70);
            chkTaskReminders.Name = "chkTaskReminders";
            chkTaskReminders.Size = new Size(132, 24);
            chkTaskReminders.TabIndex = 1;
            chkTaskReminders.Text = "Task Reminders";
            chkTaskReminders.UseVisualStyleBackColor = true;
            // 
            // chkMessages
            // 
            chkMessages.AutoSize = true;
            chkMessages.Location = new Point(20, 110);
            chkMessages.Name = "chkMessages";
            chkMessages.Size = new Size(204, 24);
            chkMessages.TabIndex = 2;
            chkMessages.Text = "Messages from Supervisor";
            chkMessages.UseVisualStyleBackColor = true;
            // 
            // chkEmergencyAlerts
            // 
            chkEmergencyAlerts.AutoSize = true;
            chkEmergencyAlerts.Location = new Point(20, 150);
            chkEmergencyAlerts.Name = "chkEmergencyAlerts";
            chkEmergencyAlerts.Size = new Size(146, 24);
            chkEmergencyAlerts.TabIndex = 3;
            chkEmergencyAlerts.Text = "Emergency Alerts";
            chkEmergencyAlerts.UseVisualStyleBackColor = true;
            // 
            // btnSaveNotifications
            // 
            btnSaveNotifications.BackColor = Color.Blue;
            btnSaveNotifications.FlatStyle = FlatStyle.Flat;
            btnSaveNotifications.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSaveNotifications.ForeColor = Color.Snow;
            btnSaveNotifications.Location = new Point(20, 220);
            btnSaveNotifications.Name = "btnSaveNotifications";
            btnSaveNotifications.Size = new Size(100, 35);
            btnSaveNotifications.TabIndex = 4;
            btnSaveNotifications.Text = "Save";
            btnSaveNotifications.UseVisualStyleBackColor = false;
            btnSaveNotifications.Click += btnSaveNotifications_Click;
            // 
            // NotificationSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 303);
            Controls.Add(btnSaveNotifications);
            Controls.Add(chkEmergencyAlerts);
            Controls.Add(chkMessages);
            Controls.Add(chkTaskReminders);
            Controls.Add(label1);
            Name = "NotificationSettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Notification Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chkTaskReminders;
        private CheckBox chkMessages;
        private CheckBox chkEmergencyAlerts;
        private Button btnSaveNotifications;
    }
}