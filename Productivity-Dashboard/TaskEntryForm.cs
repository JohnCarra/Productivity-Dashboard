using System;
using System.Windows.Forms;

namespace Productivity_Dashboard
{
    public partial class TaskEntryForm : Form
    {
        // Public properties to expose user input to the dashboard
        public string TaskName => txtTaskName.Text;
        public DateTime DueDate => dtpDueDate.Value;
        public string Status => cmbStatus.SelectedItem?.ToString() ?? "Pending";

        public TaskEntryForm()
        {
            InitializeComponent();
        }

        private void TaskEntryForm_Load(object sender, EventArgs e)
        {
            // Populate status options
            cmbStatus.Items.AddRange(new[] { "Pending", "In Progress", "Completed" });
            cmbStatus.SelectedIndex = 0;
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

        // You can safely remove these if unused:
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
