namespace EasyDay_SignUp
{
    partial class MyTasksForm
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
            btnToDo = new Button();
            btnProgress = new Button();
            btnCompleted = new Button();
            taskListPanel = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            navPanel = new Panel();
            lblNavProfile = new Label();
            lblNavMessages = new Label();
            lblNavTasks = new Label();
            lblNavHome = new Label();
            taskListPanel.SuspendLayout();
            panel2.SuspendLayout();
            navPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(145, 41);
            label1.TabIndex = 0;
            label1.Text = "My Tasks";
            // 
            // btnToDo
            // 
            btnToDo.BackColor = Color.Goldenrod;
            btnToDo.FlatStyle = FlatStyle.Flat;
            btnToDo.ForeColor = Color.Snow;
            btnToDo.Location = new Point(30, 70);
            btnToDo.Name = "btnToDo";
            btnToDo.Size = new Size(100, 35);
            btnToDo.TabIndex = 1;
            btnToDo.Text = "To Do";
            btnToDo.UseVisualStyleBackColor = false;
            // 
            // btnProgress
            // 
            btnProgress.FlatStyle = FlatStyle.Flat;
            btnProgress.Location = new Point(140, 70);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(120, 35);
            btnProgress.TabIndex = 2;
            btnProgress.Text = "In Progress";
            btnProgress.UseVisualStyleBackColor = true;
            // 
            // btnCompleted
            // 
            btnCompleted.FlatStyle = FlatStyle.Flat;
            btnCompleted.Location = new Point(270, 70);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(110, 35);
            btnCompleted.TabIndex = 3;
            btnCompleted.Text = "Completed";
            btnCompleted.UseVisualStyleBackColor = true;
            // 
            // taskListPanel
            // 
            taskListPanel.AutoScroll = true;
            taskListPanel.Controls.Add(panel2);
            taskListPanel.Location = new Point(30, 120);
            taskListPanel.Name = "taskListPanel";
            taskListPanel.Size = new Size(740, 270);
            taskListPanel.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 90);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OrangeRed;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(620, 56);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 3;
            label5.Text = "High";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(15, 56);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 2;
            label4.Text = "Due 10:00 AM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(15, 33);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 1;
            label3.Text = "Pack 20 boxes of biscuits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 0;
            label2.Text = "Packaging Line 2";
            // 
            // navPanel
            // 
            navPanel.Controls.Add(lblNavProfile);
            navPanel.Controls.Add(lblNavMessages);
            navPanel.Controls.Add(lblNavTasks);
            navPanel.Controls.Add(lblNavHome);
            navPanel.Location = new Point(30, 396);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(750, 45);
            navPanel.TabIndex = 6;
            // 
            // lblNavProfile
            // 
            lblNavProfile.AutoSize = true;
            lblNavProfile.BackColor = Color.Blue;
            lblNavProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavProfile.ForeColor = Color.Snow;
            lblNavProfile.Location = new Point(660, 15);
            lblNavProfile.Name = "lblNavProfile";
            lblNavProfile.Size = new Size(55, 20);
            lblNavProfile.TabIndex = 3;
            lblNavProfile.Text = "Profile";
            // 
            // lblNavMessages
            // 
            lblNavMessages.AutoSize = true;
            lblNavMessages.BackColor = Color.Blue;
            lblNavMessages.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavMessages.ForeColor = Color.Snow;
            lblNavMessages.Location = new Point(460, 15);
            lblNavMessages.Name = "lblNavMessages";
            lblNavMessages.Size = new Size(77, 20);
            lblNavMessages.TabIndex = 2;
            lblNavMessages.Text = "Messages";
            // 
            // lblNavTasks
            // 
            lblNavTasks.AutoSize = true;
            lblNavTasks.BackColor = Color.Blue;
            lblNavTasks.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavTasks.ForeColor = Color.Snow;
            lblNavTasks.Location = new Point(260, 15);
            lblNavTasks.Name = "lblNavTasks";
            lblNavTasks.Size = new Size(47, 20);
            lblNavTasks.TabIndex = 1;
            lblNavTasks.Text = "Tasks";
            // 
            // lblNavHome
            // 
            lblNavHome.AutoSize = true;
            lblNavHome.BackColor = Color.Blue;
            lblNavHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNavHome.ForeColor = Color.Snow;
            lblNavHome.Location = new Point(60, 15);
            lblNavHome.Name = "lblNavHome";
            lblNavHome.Size = new Size(51, 20);
            lblNavHome.TabIndex = 0;
            lblNavHome.Text = "Home";
            // 
            // MyTasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(782, 453);
            Controls.Add(navPanel);
            Controls.Add(taskListPanel);
            Controls.Add(btnCompleted);
            Controls.Add(btnProgress);
            Controls.Add(btnToDo);
            Controls.Add(label1);
            Name = "MyTasksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Tasks";
            taskListPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnToDo;
        private Button btnProgress;
        private Button btnCompleted;
        private Panel taskListPanel;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel navPanel;
        private Label lblNavProfile;
        private Label lblNavMessages;
        private Label lblNavTasks;
        private Label lblNavHome;
    }
}