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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label3 = new Label();
            chkShowPassword = new CheckBox();
            lblSignIn = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            radWorker = new Guna.UI2.WinForms.Guna2RadioButton();
            radSupervisor = new Guna.UI2.WinForms.Guna2RadioButton();
            btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 409);
            label3.Name = "label3";
            label3.Size = new Size(206, 23);
            label3.TabIndex = 5;
            label3.Text = "Already have an account?";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(176, 224);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(148, 27);
            chkShowPassword.TabIndex = 13;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.BackColor = Color.Transparent;
            lblSignIn.Cursor = Cursors.Hand;
            lblSignIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.Blue;
            lblSignIn.Location = new Point(256, 409);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(63, 23);
            lblSignIn.TabIndex = 16;
            lblSignIn.Text = "Sign In";
            lblSignIn.Click += lblSignIn_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 6;
            guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(radWorker);
            guna2Panel1.Controls.Add(radSupervisor);
            guna2Panel1.Controls.Add(btnSignUp);
            guna2Panel1.Controls.Add(lblSignIn);
            guna2Panel1.Controls.Add(txtConfirmPassword);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(txtPassword);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(txtUsername);
            guna2Panel1.Controls.Add(chkShowPassword);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2Panel1.Location = new Point(403, 24);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(375, 454);
            guna2Panel1.TabIndex = 18;
            // 
            // radWorker
            // 
            radWorker.AutoSize = true;
            radWorker.BackColor = Color.Transparent;
            radWorker.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            radWorker.CheckedState.BorderThickness = 0;
            radWorker.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            radWorker.CheckedState.InnerColor = Color.White;
            radWorker.CheckedState.InnerOffset = -4;
            radWorker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radWorker.Location = new Point(214, 272);
            radWorker.Name = "radWorker";
            radWorker.Size = new Size(85, 27);
            radWorker.TabIndex = 18;
            radWorker.Text = "Worker";
            radWorker.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radWorker.UncheckedState.BorderThickness = 2;
            radWorker.UncheckedState.FillColor = Color.Transparent;
            radWorker.UncheckedState.InnerColor = Color.Transparent;
            radWorker.UseVisualStyleBackColor = false;
            // 
            // radSupervisor
            // 
            radSupervisor.AutoSize = true;
            radSupervisor.BackColor = Color.Transparent;
            radSupervisor.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            radSupervisor.CheckedState.BorderThickness = 0;
            radSupervisor.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            radSupervisor.CheckedState.InnerColor = Color.White;
            radSupervisor.CheckedState.InnerOffset = -4;
            radSupervisor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radSupervisor.Location = new Point(74, 272);
            radSupervisor.Name = "radSupervisor";
            radSupervisor.Size = new Size(110, 27);
            radSupervisor.TabIndex = 17;
            radSupervisor.Text = "Supervisor";
            radSupervisor.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radSupervisor.UncheckedState.BorderThickness = 2;
            radSupervisor.UncheckedState.FillColor = Color.Transparent;
            radSupervisor.UncheckedState.InnerColor = Color.Transparent;
            radSupervisor.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.BorderColor = Color.LightGray;
            btnSignUp.BorderRadius = 10;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.CustomizableEdges = customizableEdges1;
            btnSignUp.DisabledState.BorderColor = Color.DarkGray;
            btnSignUp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignUp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignUp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignUp.FillColor = Color.Blue;
            btnSignUp.Font = new Font("Segoe UI", 9F);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(74, 319);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSignUp.Size = new Size(225, 56);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderColor = Color.Gray;
            txtConfirmPassword.BorderRadius = 10;
            txtConfirmPassword.CustomizableEdges = customizableEdges3;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPassword.IconRightSize = new Size(35, 20);
            txtConfirmPassword.Location = new Point(54, 184);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtConfirmPassword.Size = new Size(270, 38);
            txtConfirmPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.Gray;
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconRightSize = new Size(35, 20);
            txtPassword.Location = new Point(54, 138);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(270, 38);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BorderColor = Color.Gray;
            txtUsername.BorderRadius = 10;
            txtUsername.CustomizableEdges = customizableEdges7;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(54, 91);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtUsername.Size = new Size(270, 38);
            txtUsername.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private CheckBox chkShowPassword;
        private Label lblSignIn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2RadioButton radSupervisor;
        private Guna.UI2.WinForms.Guna2RadioButton radWorker;
    }
}
