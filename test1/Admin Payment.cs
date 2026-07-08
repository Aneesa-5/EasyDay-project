using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace EasyDay
{
    public partial class frmAdminPayment : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataTable dt;

        public frmAdminPayment()
        {
            InitializeComponent();
        }

        private void frmAdminPayment_Load(object sender, EventArgs e)
        {
            LoadPayment();
        }

        private void LoadPayment()
        {
            con.Open();

            string sql = @"SELECT tbl_users.Username, tbl_payment.Cardholder_Name, tbl_payment.Plan FROM tbl_users INNER JOIN tbl_payment ON tbl_users.User_ID = tbl_payment.User_ID";

            da = new OleDbDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            dgvPayment.DataSource = dt;

            dgvPayment.Columns["Username"].HeaderText = "Username";
            dgvPayment.Columns["Cardholder_Name"].HeaderText = "Cardholder Name";
            dgvPayment.Columns["Plan"].HeaderText = "Subscription Plan";

            cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_payment", con);

            lblTotalUnlimited.Text = "Total Unlimited Users : " + cmd.ExecuteScalar().ToString();
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = @"SELECT tbl_users.Username, tbl_payment.Cardholder_Name, tbl_payment.Plan FROM tbl_users INNER JOIN tbl_payment ON tbl_users.User_ID = tbl_payment.User_ID WHERE tbl_users.Username LIKE ?";

            da = new OleDbDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@Username", "%" + txtUsername.Text + "%");
            dt = new DataTable();
            da.Fill(dt);
            dgvPayment.DataSource = dt;

            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            LoadPayment();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment record");
                return;
            }
            string username = dgvPayment.SelectedRows[0].Cells["Username"].Value.ToString();
            con.Open();

            string sql = @"DELETE FROM tbl_payment WHERE User_ID IN (SELECT User_ID FROM tbl_users WHERE Username = ?)";
            cmd = new OleDbCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Payment record deleted successfully.");
            LoadPayment();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            new frmAdminDashboard().Show();
            this.Hide();
        }
    }
}
