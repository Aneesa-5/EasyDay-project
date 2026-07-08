using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EasyDay_SignUp.Models;

namespace EasyDay_SignUp
{
    public partial class NotificationSettingsForm : Form
    {
        public NotificationSettingsForm()
        {
            InitializeComponent();
            chkTaskReminders.Checked = NotificationPreferences.TaskReminders;
            chkMessages.Checked = NotificationPreferences.Messages;
            chkEmergencyAlerts.Checked = NotificationPreferences.EmergencyAlerts;
        }

        private void btnSaveNotifications_Click(object sender, EventArgs e)
        {
            NotificationPreferences.TaskReminders = chkTaskReminders.Checked;
            NotificationPreferences.Messages = chkMessages.Checked;
            NotificationPreferences.EmergencyAlerts = chkEmergencyAlerts.Checked;

            MessageBox.Show("Preferences saved.");
            this.Close();
        }
    }
}
