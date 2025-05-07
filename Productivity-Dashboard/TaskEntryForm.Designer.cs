namespace Productivity_Dashboard
{
    partial class TaskEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTaskName = new TextBox();
            dtpDueDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblTaskName = new Label();
            lblDueDate = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(272, 111);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(249, 27);
            txtTaskName.TabIndex = 0;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(271, 158);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(272, 198);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(249, 28);
            cmbStatus.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(272, 247);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(372, 247);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(190, 111);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(83, 20);
            lblTaskName.TabIndex = 5;
            lblTaskName.Text = "Task Name:";
            lblTaskName.Click += label1_Click;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(190, 158);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(75, 20);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "Due Date:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(213, 206);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            lblStatus.Click += label3_Click;
            // 
            // TaskEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblDueDate);
            Controls.Add(lblTaskName);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDueDate);
            Controls.Add(txtTaskName);
            Name = "TaskEntryForm";
            Text = "TaskEntryForm";
            Load += TaskEntryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaskName;
        private DateTimePicker dtpDueDate;
        private ComboBox cmbStatus;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblTaskName;
        private Label lblDueDate;
        private Label lblStatus;
    }
}