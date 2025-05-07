using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Productivity_Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            // Hook up button events
            btnAddTask.Click += BtnAddTask_Click;
            btnViewTasks.Click += BtnViewTasks_Click;
            btnDeleteTask.Click += BtnDeleteTask_Click;
            taskListView.DoubleClick += TaskListView_DoubleClick;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            using var form = new TaskEntryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var task = new TaskItem
                {
                    Name = form.TaskName,
                    DueDate = form.DueDate,
                    Status = form.Status
                };

                bool success = DBHelper.InsertTask(task);
                MessageBox.Show(success ? "Task saved to database!" : "Failed to save task.",
                    success ? "Success" : "Error",
                    MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
        }

        private void BtnViewTasks_Click(object sender, EventArgs e)
        {
            taskListView.Items.Clear();

            List<TaskItem> tasksFromDb = DBHelper.GetAllTasks();
            foreach (var task in tasksFromDb)
            {
                var item = new ListViewItem(task.Name);
                item.SubItems.Add(task.DueDate.ToShortDateString());
                item.SubItems.Add(task.Status);
                item.Tag = task.Id;
                taskListView.Items.Add(item);
            }

            if (tasksFromDb.Count == 0)
            {
                MessageBox.Show("No tasks found in the database.", "View Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TaskListView_DoubleClick(object sender, EventArgs e)
        {
            if (taskListView.SelectedItems.Count == 0) return;

            var selectedItem = taskListView.SelectedItems[0];
            if (selectedItem.Tag is not int taskId) return;

            var taskToEdit = DBHelper.GetAllTasks().Find(t => t.Id == taskId);
            if (taskToEdit == null) return;

            using var form = new TaskEntryForm(taskToEdit);
            if (form.ShowDialog() == DialogResult.OK)
            {
                taskToEdit.Name = form.TaskName;
                taskToEdit.DueDate = form.DueDate;
                taskToEdit.Status = form.Status;

                bool updated = DBHelper.UpdateTask(taskToEdit);
                MessageBox.Show(updated ? "Task updated!" : "Update failed.",
                    updated ? "Success" : "Error",
                    MessageBoxButtons.OK,
                    updated ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                BtnViewTasks_Click(null, null); // Refresh
            }
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            if (taskListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = taskListView.SelectedItems[0];
            if (selectedItem.Tag is not int taskId)
            {
                MessageBox.Show("Task ID missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool success = DBHelper.DeleteTask(taskId);
                MessageBox.Show(success ? "Task deleted." : "Failed to delete task.",
                    success ? "Deleted" : "Error",
                    MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                BtnViewTasks_Click(null, null);
            }
        }
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }

        public TaskItem()
        {
            Name = string.Empty;
            Status = "Pending";
        }
    }
}
