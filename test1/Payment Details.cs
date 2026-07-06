using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EasyDay
{
    public partial class frmPaymentDetails : Form
    {
        private int loggedInUserId;

        public frmPaymentDetails(int userId)
        {
            InitializeComponent();
            this.loggedInUserId = userId;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            // open yg translation page
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            // Cardholder name
            if (txtCardName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the cardholder name.");
                txtCardName.Clear();
                txtCardName.Focus();
                return;
            }

            // Card number
            if (txtCardNumber.Text.Length < 13 || txtCardNumber.Text.Length > 19)
            {
                MessageBox.Show("Card number must be between 13 and 19 digits.");
                txtCardNumber.Clear();
                txtCardNumber.Focus();
                return;
            }

            // Expiry Date
            if (!Regex.IsMatch(txtExpirationDate.Text, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                MessageBox.Show("Expiration Date must be in MM/YY format.");
                txtExpirationDate.Clear();
                txtExpirationDate.Focus();
                return;
            }

            // CVV
            if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show("CVV must be 3 digits.");
                txtCVV.Clear();
                txtCVV.Focus();
                return;
            }

            // database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb";
            string query = "INSERT INTO tbl_payment (User_ID, Cardholder_Name, Card_Number, Expiry_Date, CVV)" + "VALUES (?, ?, ?, ?, ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@User_ID", this.loggedInUserId);

                    cmd.Parameters.AddWithValue("@Carholder_Name", txtCardName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Card_Number", txtCardName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Expiry_Date", txtExpirationDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@CVV", txtCVV.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

                MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCardName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExpirationDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void txtExpirationDate_TextChanged(object sender, EventArgs e)
        {
            if (txtExpirationDate.Text.Length == 2 && !txtExpirationDate.Text.Contains("/"))
            {
                txtExpirationDate.Text += "/";
                txtExpirationDate.SelectionStart = txtExpirationDate.Text.Length;
            }
        }
    }
}
