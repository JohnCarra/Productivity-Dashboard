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

        // Internal task reference (used for editing)
        private TaskItem? _taskToEdit;

        // Constructor for adding a new task
        public TaskEntryForm()
        {
            InitializeComponent();
        }

        // Constructor for editing an existing task
        public TaskEntryForm(TaskItem taskToEdit) : this()
        {
            _taskToEdit = taskToEdit;
        }

        private void TaskEntryForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new[] { "Pending", "In Progress", "Completed" });
            cmbStatus.SelectedIndex = 0;

            if (_taskToEdit != null)
            {
                txtTaskName.Text = _taskToEdit.Name;
                dtpDueDate.Value = _taskToEdit.DueDate;

                int index = cmbStatus.Items.IndexOf(_taskToEdit.Status);
                cmbStatus.SelectedIndex = index >= 0 ? index : 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text) || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a task name and select a status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Unused label click handlers (optional to remove)
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
