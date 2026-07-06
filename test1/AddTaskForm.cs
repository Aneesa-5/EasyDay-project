using EasyDay_SignUp.Models;

namespace EasyDay_SignUp
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbAssignTo.Items.AddRange(new object[] { "Rahman", "Aisha", "Karim" }); // fake names for now
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }
            if (cmbPriority.SelectedItem == null)
            {
                MessageBox.Show("Please select a priority.");
                return;
            }

            TaskPriority priority = (TaskPriority)Enum.Parse(typeof(TaskPriority), cmbPriority.SelectedItem.ToString());

            TaskItem newTask = new TaskItem(
                txtTitle.Text,
                txtSubtitle.Text,
                dtpDueTime.Value.ToString("h:mm tt"),
                priority,
                TaskState.ToDo
            );

            TaskRepository.AddTask(newTask);

            MessageBox.Show("Task added successfully!");
            this.Close();
        }

        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            TaskPriority priority = cmbPriority.SelectedItem.ToString() switch
            {
                "High" => TaskPriority.High,
                "Medium" => TaskPriority.Medium,
                _ => TaskPriority.Low
            };

            TaskItem newTask = new TaskItem(
                txtTitle.Text,
                txtSubtitle.Text,
                dtpDueTime.Value.ToString("h:mm tt"),
                priority,
                TaskState.ToDo
            );

            TaskRepository.AddTask(newTask);

            MessageBox.Show("Task added successfully!");
            txtTitle.Clear();
            txtSubtitle.Clear();
            
        }
    }
}