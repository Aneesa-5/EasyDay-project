namespace test1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblAccount = new Label();
            label7 = new Label();
            label8 = new Label();
            txtUsername = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            txtConfirmPassword = new RoundedTextBox();
            btnSignUp = new RoundedButton();
            btnClear = new RoundedButton();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 65);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccount.Location = new Point(289, 404);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(198, 23);
            lblAccount.TabIndex = 5;
            lblAccount.Text = "Already have an account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(262, 216);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 6;
            label7.Text = "Confirm Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(262, 140);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 7;
            label8.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(262, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 38);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(262, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 38);
            txtPassword.TabIndex = 9;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(262, 242);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 38);
            txtConfirmPassword.TabIndex = 10;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(262, 330);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(110, 52);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(403, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 52);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(364, 286);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(148, 27);
            chkShowPassword.TabIndex = 13;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowPassword);
            Controls.Add(btnClear);
            Controls.Add(btnSignUp);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblAccount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblAccount;
        private Label label7;
        private Label label8;
        private RoundedTextBox txtUsername;
        private RoundedTextBox txtPassword;
        private RoundedTextBox txtConfirmPassword;
        private RoundedButton btnSignUp;
        private RoundedButton btnClear;
        private CheckBox chkShowPassword;
    }
}
