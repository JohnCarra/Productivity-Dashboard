using System;
using System.Windows.Forms;

namespace Productivity_Dashboard
{
    public partial class TaskEntryForm : Form
    {
        // Public properties to expose user input
        public string TaskName => txtTaskName.Text;
        public DateTime DueDate => dtpDueDate.Value;
        public string Status => cmbStatus.SelectedItem?.ToString() ?? "Pending";

        private readonly TaskItem? existingTask;

        // Constructor for "Add" mode
        public TaskEntryForm()
        {
            InitializeComponent();
        }

        // Constructor for "Edit" mode
        public TaskEntryForm(TaskItem taskToEdit)
        {
            InitializeComponent();
            existingTask = taskToEdit;
        }

        private void TaskEntryForm_Load(object sender, EventArgs e)
        {
            // Populate status dropdown
            cmbStatus.Items.AddRange(new[] { "Pending", "In Progress", "Completed" });
            cmbStatus.SelectedIndex = 0;

            if (existingTask != null)
            {
                // Editing an existing task
                txtTaskName.Text = existingTask.Name;
                dtpDueDate.Value = existingTask.DueDate;
                cmbStatus.SelectedItem = existingTask.Status;
                Text = "Edit Task";
            }
            else
            {
                // Adding a new task
                Text = "Add Task";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text) || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a task name and select a status.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // These can be safely removed or left empty
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
