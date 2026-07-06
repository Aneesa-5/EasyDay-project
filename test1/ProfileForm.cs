using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test1;

namespace EasyDay_SignUp
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            MakeCircular(picProfile);
            SetupRowClickHandlers();
        }
        private void MakeCircular(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(path);
        }
        private void SetupRowClickHandlers()
        {
            WireRowClick(languageRow, () =>
                MessageBox.Show("Language settings coming soon"));

            WireRowClick(notificationsRow, () =>
            {
                using var form = new NotificationSettingsForm();
                form.ShowDialog(this);
            });

            WireRowClick(changePasswordRow, () =>
                MessageBox.Show("Change Password coming soon"));

            WireRowClick(aboutRow, () =>
            {
                using var form = new AboutForm();
                form.ShowDialog(this);
            });

            WireRowClick(logoutRow, () =>
            {
                var result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            });
        }

        private void WireRowClick(Panel row, Action onClick)
        {
            row.Cursor = Cursors.Hand;
            row.Click += (s, e) => onClick();
            foreach (Control c in row.Controls)
            {
                c.Cursor = Cursors.Hand;
                c.Click += (s, e) => onClick();
            }
        }
    }
    
}
