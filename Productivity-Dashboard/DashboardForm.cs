using System;
using System.Windows.Forms;

namespace Productivity_Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            // Hook up events
            btnAddTask.Click += BtnAddTask_Click;
            btnViewTasks.Click += BtnViewTasks_Click;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            using var form = new TaskEntryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // You’ll add task handling logic here later
                MessageBox.Show("Task added!");
            }
        }

        private void BtnViewTasks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Tasks clicked.");
        }
    }
}
