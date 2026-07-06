using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EasyDay_SignUp.Models;

namespace EasyDay_SignUp
{
    public partial class MyTasksForm : Form

    {
        private List<TaskItem> _allTasks;
        private TaskState _activeFilter = TaskState.ToDo;

        
        public MyTasksForm()
        {
            InitializeComponent();
            _allTasks = TaskRepository.GetSampleTasks();
            RenderTaskCards();

        }
        private void btnToDo_Click(object sender, EventArgs e)
        {
            _activeFilter = TaskState.ToDo;
            RenderTaskCards();
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            _activeFilter = TaskState.InProgress;
            RenderTaskCards();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            _activeFilter = TaskState.Completed;
            RenderTaskCards();
        }

        private void RenderTaskCards()
        {
            taskListPanel.Controls.Clear();

            var filtered = _allTasks.Where(t => t.Status == _activeFilter).ToList();

            int yPos = 10;
            foreach (var task in filtered)
            {
                Panel card = BuildTaskCard(task);
                card.Location = new Point(10, yPos);
                taskListPanel.Controls.Add(card);
                yPos += card.Height + 10;
            }
        }

        private Panel BuildTaskCard(TaskItem task)
        {
            Panel card = new Panel
            {
                Size = new Size(700, 90),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            Label title = new Label { Text = task.Title, Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(15, 10), AutoSize = true };
            Label subtitle = new Label { Text = task.Subtitle, ForeColor = Color.DimGray, Location = new Point(15, 32), AutoSize = true };
            Label due = new Label { Text = task.DueTime, ForeColor = Color.DimGray, Location = new Point(15, 56), AutoSize = true };

            Color tagColor = task.Priority == TaskPriority.High ? Color.IndianRed :
                              task.Priority == TaskPriority.Medium ? Color.Orange : Color.Gray;

            Label priorityTag = new Label
            {
                Text = task.Priority.ToString(),
                BackColor = tagColor,
                ForeColor = Color.White,
                AutoSize = true,
                Padding = new Padding(6, 2, 6, 2),
                Location = new Point(620, 56)
            };

            card.Controls.Add(title);
            card.Controls.Add(subtitle);
            card.Controls.Add(due);
            card.Controls.Add(priorityTag);

            card.Click += (s, e) => OpenTaskDetail(task);
            foreach (Control c in card.Controls)
                c.Click += (s, e) => OpenTaskDetail(task);

            return card;
        }

        private void OpenTaskDetail(TaskItem task)
        {
            using var detail = new TaskDetailForm(task);
            if (detail.ShowDialog(this) == DialogResult.OK)
            {
                task.Status = TaskState.Completed;
                RenderTaskCards();
            }
        }
    }
}
