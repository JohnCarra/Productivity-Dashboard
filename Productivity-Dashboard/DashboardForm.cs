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
                if (success)
                {
                    MessageBox.Show("Task saved to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to save task to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                taskListView.Items.Add(item);
            }

            if (tasksFromDb.Count == 0)
            {
                MessageBox.Show("No tasks found in the database.", "View Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class TaskItem
    {
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
