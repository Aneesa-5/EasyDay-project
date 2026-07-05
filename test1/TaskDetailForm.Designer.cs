namespace EasyDay_SignUp
{
    partial class TaskDetailForm
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
            backLabel = new Label();
            lblTitle = new Label();
            label3 = new Label();
            stepsPanel = new Panel();
            completeButton = new Button();
            SuspendLayout();
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.Cursor = Cursors.Hand;
            backLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backLabel.Location = new Point(20, 20);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(34, 31);
            backLabel.TabIndex = 0;
            backLabel.Text = "←";
            backLabel.Click += backLabel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(20, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Packaging Line 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Instructions";
            // 
            // stepsPanel
            // 
            stepsPanel.AutoScroll = true;
            stepsPanel.Location = new Point(20, 130);
            stepsPanel.Name = "stepsPanel";
            stepsPanel.Size = new Size(740, 260);
            stepsPanel.TabIndex = 3;
            // 
            // completeButton
            // 
            completeButton.BackColor = Color.Blue;
            completeButton.FlatStyle = FlatStyle.Flat;
            completeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            completeButton.ForeColor = Color.Snow;
            completeButton.Location = new Point(20, 396);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(740, 45);
            completeButton.TabIndex = 4;
            completeButton.Text = "Mark as Completed";
            completeButton.UseVisualStyleBackColor = false;
            completeButton.Click += completeButton_Click;
            // 
            // TaskDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(completeButton);
            Controls.Add(stepsPanel);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(backLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Task Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backLabel;
        private Label lblTitle;
        private Label label3;
        private Panel stepsPanel;
        private Button completeButton;
    }
}