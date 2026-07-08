using EasyDay_SignUp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyDay_SignUp
{
    public partial class TaskDetailForm : Form
    {
        private TaskItem _task;
        public TaskDetailForm(TaskItem task)
        {
            InitializeComponent();
            _task = task;
            LoadTaskDetails();
        }
        private void LoadTaskDetails()
        {
            lblTitle.Text = _task.Title;

            stepsPanel.Controls.Clear();

            int yPos = 10;
            foreach (var step in _task.Steps)
            {
                Panel row = BuildStepRow(step);
                row.Location = new Point(10, yPos);
                stepsPanel.Controls.Add(row);
                yPos += row.Height + 10;
            }
        }

        private Panel BuildStepRow(TaskStep step)
        {
            Panel row = new Panel { Size = new Size(700, 40) };

            Label numberCircle = new Label
            {
                Text = step.StepNumber.ToString(),
                Size = new Size(26, 26),
                Location = new Point(0, 5),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(31, 122, 61),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            Label text = new Label
            {
                Text = step.Instruction,
                Location = new Point(36, 8),
                AutoSize = true
            };

            row.Controls.Add(numberCircle);
            row.Controls.Add(text);
            return row;
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
