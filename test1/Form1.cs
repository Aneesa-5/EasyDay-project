using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.AccessControl;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                bool hasNumber = txtPassword.Text.Any(char.IsDigit);
                bool hasSymbol = txtPassword.Text.Any(ch => !char.IsLetterOrDigit(ch));

                if (txtPassword.Text.Length < 8 || !hasNumber || !hasSymbol)
                {
                    MessageBox.Show("Password must be at least 8 characters and above including at least one number and one symbol", "Invalid Password",MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPassword.Focus();
                    return;
                }

                string role = "";
                if (radSupervisor.Checked)
                {
                    role = "Supervisor";
                }
                else if (radWorker.Checked)
                {
                    role = "Worker";
                }
                else
                {
                    MessageBox.Show("Please select a role!");
                    return;
                }

                con.Open();

                string checkUser = "SELECT COUNT(*) FROM tbl_users WHERE Username = ?";
                cmd = new OleDbCommand(checkUser, con);
                cmd.Parameters.AddWithValue("?", txtUsername.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    con.Close();

                    MessageBox.Show("Username already exists. Please choose another username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtUsername.Focus();
                    return;
                }

                string register = "INSERT INTO tbl_users (Username, [Password], Role) VALUES (?, ?, ?)";
                cmd = new OleDbCommand(register, con);
                cmd.Parameters.AddWithValue("?", txtUsername.Text);
                cmd.Parameters.AddWithValue("?", txtPassword.Text);
                cmd.Parameters.AddWithValue("?", role);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                radSupervisor.Checked = false;
                radWorker.Checked = false;

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Passwords do not match!","Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            // ke page sign in
        }
    }
}
