using System;
using System.Collections.Generic;

namespace EasyDay_SignUp.Models
{
    public enum TaskPriority { Low, Medium, High }
    public enum TaskState { ToDo, InProgress, Completed }

    public class TaskItem
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string DueTime { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; }
        public TaskState Status { get; set; }
        public List<TaskStep> Steps { get; set; } = new();

        public TaskItem(string title, string subtitle, string dueTime, TaskPriority priority, TaskState status)
        {
            Title = title;
            Subtitle = subtitle;
            DueTime = dueTime;
            Priority = priority;
            Status = status;
        }
    }
}