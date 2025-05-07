using System.Drawing;
using System.Windows.Forms;

namespace Productivity_Dashboard
{
    partial class TaskEntryForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTaskName;
        private TextBox txtTaskName;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSubmit;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTaskName = new Label();
            txtTaskName = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();

            // Form properties
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 280);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add or Edit Task";

            // Task Name Label
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(30, 30);
            lblTaskName.Text = "Task Name:";

            // Task Name TextBox
            txtTaskName.Location = new Point(130, 27);
            txtTaskName.Size = new Size(270, 27);
            txtTaskName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Due Date Label
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(30, 75);
            lblDueDate.Text = "Due Date:";

            // Due Date Picker
            dtpDueDate.Location = new Point(130, 72);
            dtpDueDate.Size = new Size(270, 27);
            dtpDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Status Label
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 120);
            lblStatus.Text = "Status:";

            // Status ComboBox
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(130, 117);
            cmbStatus.Size = new Size(270, 28);
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Submit Button
            btnSubmit.Location = new Point(130, 180);
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;

            // Cancel Button
            btnCancel.Location = new Point(240, 180);
            btnCancel.Size = new Size(100, 30);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            // Add controls
            Controls.Add(lblTaskName);
            Controls.Add(txtTaskName);
            Controls.Add(lblDueDate);
            Controls.Add(dtpDueDate);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);

            Load += TaskEntryForm_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
