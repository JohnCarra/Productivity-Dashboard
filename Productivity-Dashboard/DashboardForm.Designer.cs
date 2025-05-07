namespace Productivity_Dashboard
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Title = new Label();
            btnAddTask = new Button();
            btnViewTasks = new Button();
            taskListView = new ListView();

            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(250, 30);
            Title.Name = "Title";
            Title.Size = new Size(260, 32);
            Title.TabIndex = 0;
            Title.Text = "Productivity Dashboard";

            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(50, 100);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(100, 30);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;

            // 
            // btnViewTasks
            // 
            btnViewTasks.Location = new Point(50, 140);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(100, 30);
            btnViewTasks.TabIndex = 2;
            btnViewTasks.Text = "View Tasks";
            btnViewTasks.UseVisualStyleBackColor = true;

            // 
            // taskListView
            // 
            taskListView.FullRowSelect = true;
            taskListView.GridLines = true;
            taskListView.Location = new Point(200, 100);
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(560, 300);
            taskListView.TabIndex = 3;
            taskListView.UseCompatibleStateImageBehavior = false;
            taskListView.View = View.Details;

            // Add columns
            taskListView.Columns.Add("Task", 200, HorizontalAlignment.Left);
            taskListView.Columns.Add("Due Date", 120, HorizontalAlignment.Left);
            taskListView.Columns.Add("Status", 120, HorizontalAlignment.Left);

            // Add sample row
            ListViewItem sampleItem = new ListViewItem("Example Task");
            sampleItem.SubItems.Add("2025-05-10");
            sampleItem.SubItems.Add("Pending");
            taskListView.Items.Add(sampleItem);

            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(taskListView);
            Controls.Add(btnViewTasks);
            Controls.Add(btnAddTask);
            Controls.Add(Title);
            Name = "DashboardForm";
            Text = "Productivity Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button btnAddTask;
        private Button btnViewTasks;
        private ListView taskListView;
    }
}
