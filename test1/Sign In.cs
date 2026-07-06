using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using test1;

namespace EasyDay
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            con.Open();
            string signIn = "SELECT * FROM tbl_users WHERE Username = ? and [Password] = ?";
            cmd = new OleDbCommand(signIn, con);
            cmd.Parameters.AddWithValue("?", txtUsername.Text);
            cmd.Parameters.AddWithValue("?", txtPassword.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string role = dr["Role"].ToString();

                con.Close();

                if (role == "Supervisor")
                {
                    // page supervisor
                }
                else if (role == "Worker")
                {
                    // page worker
                }
                else if (role == "Admin")
                {
                    // page admin
                }
                this.Hide();
            }
            else
            {
                con.Close();

                MessageBox.Show("Invalid Username or Password, Please Try again", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            new frmSignUp().Show();
            this.Hide();
        }
    }
}
