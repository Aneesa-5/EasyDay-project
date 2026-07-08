using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EasyDay
{
    public partial class frmAdminDashboard : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();

        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            con.Open();

            // total workers
            cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_users WHERE Role = 'Worker'", con);
            lblTotalWorkers.Text = cmd.ExecuteScalar().ToString();

            // total supervisors
            cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_users WHERE Role = 'Supervisor'", con);
            lblTotalSupervisors.Text = cmd.ExecuteScalar().ToString();

            // to do task
            cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_tasks WHERE Status = 'To Do'", con);
            lblToDoTask.Text = cmd.ExecuteScalar().ToString();

            // pending task
            cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_tasks WHERE Status = 'Pending'", con);
            lblPendingTask.Text = cmd.ExecuteScalar().ToString();

            // completed task
            cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_tasks WHERE Status = 'Completed'", con);
            lblCompletedTask.Text = cmd.ExecuteScalar().ToString();

            // premium users
            cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_payment", con);
            lblUnlimitedUsers.Text = cmd.ExecuteScalar().ToString();

            con.Close();
        }

        private void lblPayment_Click(object sender, EventArgs e)
        {
            new frmAdminPayment().Show();
            this.Hide();
        }
    }
}
