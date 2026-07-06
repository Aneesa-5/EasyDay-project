using System.Collections.Generic;

namespace EasyDay_SignUp.Models
{
    public static class TaskRepository
    {
        private static List<TaskItem> _tasks = new()
        {
            new TaskItem("Packaging Line 2", "Pack 20 boxes of biscuits.", "Due 10:00 AM", TaskPriority.High, TaskState.ToDo)
            {
                Steps = new List<TaskStep>
                {
                    new(1, "Wear gloves before starting."),
                    new(2, "Wear hairnet."),
                    new(3, "Put the biscuits into the box."),
                    new(4, "Seal the box properly."),
                    new(5, "Place the box on the pallet.")
                }
            },
            new TaskItem("Check Machine A", "Check and report any abnormal noise.", "Due 11:30 AM", TaskPriority.Medium, TaskState.ToDo)
            {
                Steps = new List<TaskStep>
                {
                    new(1, "Stand clear of moving parts."),
                    new(2, "Listen for grinding or rattling sounds."),
                    new(3, "Report any issue to your supervisor.")
                }
            },
            new TaskItem("Clean Work Area", "Keep your area clean before break time.", "Due 02:00 PM", TaskPriority.Low, TaskState.ToDo)
            {
                Steps = new List<TaskStep>
                {
                    new(1, "Sweep the floor around your station."),
                    new(2, "Wipe down surfaces and tools."),
                    new(3, "Dispose of waste in the correct bin.")
                }
            }
        };

        public static List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public static void AddTask(TaskItem task)
        {
            _tasks.Add(task);
        }
    }
}