using System.Drawing;
using System.Windows.Forms;

namespace Productivity_Dashboard
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label Title;
        private Button btnAddTask;
        private Button btnViewTasks;
        private Button btnDeleteTask;
        private ListView taskListView;
        private Panel buttonPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Title = new Label();
            btnAddTask = new Button();
            btnViewTasks = new Button();
            btnDeleteTask = new Button();
            taskListView = new ListView();
            buttonPanel = new Panel();

            // Form properties
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 450);
            Text = "Productivity Dashboard";

            // Title Label
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(20, 20);
            Title.Name = "Title";
            Title.Text = "Productivity Dashboard";

            // Button Panel
            buttonPanel.Location = new Point(20, 70);
            buttonPanel.Size = new Size(150, 130);
            buttonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonPanel.Controls.Add(btnAddTask);
            buttonPanel.Controls.Add(btnViewTasks);
            buttonPanel.Controls.Add(btnDeleteTask);

            // Add Task Button
            btnAddTask.Location = new Point(0, 0);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(130, 30);
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;

            // View Tasks Button
            btnViewTasks.Location = new Point(0, 45);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(130, 30);
            btnViewTasks.Text = "View Tasks";
            btnViewTasks.UseVisualStyleBackColor = true;

            // Delete Task Button
            btnDeleteTask.Location = new Point(0, 90);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(130, 30);
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;

            // Task ListView
            taskListView.Location = new Point(190, 70);
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(680, 370);
            taskListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskListView.View = View.Details;
            taskListView.FullRowSelect = true;
            taskListView.GridLines = true;
            taskListView.Columns.Add("Task", 300, HorizontalAlignment.Left);
            taskListView.Columns.Add("Due Date", 150, HorizontalAlignment.Left);
            taskListView.Columns.Add("Status", 150, HorizontalAlignment.Left);

            // Add controls to Form
            Controls.Add(Title);
            Controls.Add(buttonPanel);
            Controls.Add(taskListView);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
