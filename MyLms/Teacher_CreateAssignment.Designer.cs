namespace MyLms
{
    partial class Teacher_CreateAssignment
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
            panelCreateAssignment = new Panel();
            lblTotalMarks = new Label();
            numericTotalMarks = new NumericUpDown();
            lblAssignmentAttempts = new Label();
            numericAssignmentAttempts = new NumericUpDown();
            btnPublishAssignment = new RoundedButton();
            AssignmentduetimePicker = new DateTimePicker();
            AssignmentduedatePicker = new DateTimePicker();
            lblAssignmentDueTime = new Label();
            lblAssignmentDueDate = new Label();
            txtAssignmentTitle = new TextBox();
            lblAssignmentTitle = new Label();
            panelChooseFile = new Panel();
            lblFileName = new Label();
            btnChooseFile = new Button();
            lblUploadFile = new Label();
            btnBackToAssignmentsQuizzesFromAssignment = new RoundedButton();
            lblCreateAssignment = new Label();
            teacherSidebar1 = new TeacherSidebar();
            panelCreateAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalMarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAssignmentAttempts).BeginInit();
            panelChooseFile.SuspendLayout();
            SuspendLayout();
            // 
            // panelCreateAssignment
            // 
            panelCreateAssignment.Controls.Add(lblTotalMarks);
            panelCreateAssignment.Controls.Add(numericTotalMarks);
            panelCreateAssignment.Controls.Add(lblAssignmentAttempts);
            panelCreateAssignment.Controls.Add(numericAssignmentAttempts);
            panelCreateAssignment.Controls.Add(btnPublishAssignment);
            panelCreateAssignment.Controls.Add(AssignmentduetimePicker);
            panelCreateAssignment.Controls.Add(AssignmentduedatePicker);
            panelCreateAssignment.Controls.Add(lblAssignmentDueTime);
            panelCreateAssignment.Controls.Add(lblAssignmentDueDate);
            panelCreateAssignment.Controls.Add(txtAssignmentTitle);
            panelCreateAssignment.Controls.Add(lblAssignmentTitle);
            panelCreateAssignment.Controls.Add(panelChooseFile);
            panelCreateAssignment.Controls.Add(lblUploadFile);
            panelCreateAssignment.Controls.Add(btnBackToAssignmentsQuizzesFromAssignment);
            panelCreateAssignment.Controls.Add(lblCreateAssignment);
            panelCreateAssignment.Location = new Point(301, 0);
            panelCreateAssignment.Name = "panelCreateAssignment";
            panelCreateAssignment.Size = new Size(980, 752);
            panelCreateAssignment.TabIndex = 24;
            // 
            // lblTotalMarks
            // 
            lblTotalMarks.AutoSize = true;
            lblTotalMarks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalMarks.ForeColor = Color.FromArgb(68, 68, 68);
            lblTotalMarks.Location = new Point(45, 414);
            lblTotalMarks.Name = "lblTotalMarks";
            lblTotalMarks.Size = new Size(116, 28);
            lblTotalMarks.TabIndex = 22;
            lblTotalMarks.Text = "Total Marks";
            // 
            // numericTotalMarks
            // 
            numericTotalMarks.Font = new Font("Segoe UI", 12F);
            numericTotalMarks.Location = new Point(67, 463);
            numericTotalMarks.Name = "numericTotalMarks";
            numericTotalMarks.Size = new Size(855, 34);
            numericTotalMarks.TabIndex = 21;
            numericTotalMarks.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblAssignmentAttempts
            // 
            lblAssignmentAttempts.AutoSize = true;
            lblAssignmentAttempts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAssignmentAttempts.ForeColor = Color.FromArgb(68, 68, 68);
            lblAssignmentAttempts.Location = new Point(49, 308);
            lblAssignmentAttempts.Name = "lblAssignmentAttempts";
            lblAssignmentAttempts.Size = new Size(96, 28);
            lblAssignmentAttempts.TabIndex = 20;
            lblAssignmentAttempts.Text = "Attempts";
            // 
            // numericAssignmentAttempts
            // 
            numericAssignmentAttempts.Font = new Font("Segoe UI", 12F);
            numericAssignmentAttempts.Location = new Point(71, 357);
            numericAssignmentAttempts.Name = "numericAssignmentAttempts";
            numericAssignmentAttempts.Size = new Size(855, 34);
            numericAssignmentAttempts.TabIndex = 19;
            numericAssignmentAttempts.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPublishAssignment
            // 
            btnPublishAssignment.BackColor = Color.FromArgb(79, 70, 229);
            btnPublishAssignment.Cursor = Cursors.Hand;
            btnPublishAssignment.FlatAppearance.BorderSize = 0;
            btnPublishAssignment.FlatStyle = FlatStyle.Flat;
            btnPublishAssignment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPublishAssignment.ForeColor = Color.White;
            btnPublishAssignment.Location = new Point(356, 663);
            btnPublishAssignment.Name = "btnPublishAssignment";
            btnPublishAssignment.Size = new Size(225, 47);
            btnPublishAssignment.TabIndex = 18;
            btnPublishAssignment.Text = "Publish Assignment";
            btnPublishAssignment.UseVisualStyleBackColor = false;
            btnPublishAssignment.Click += btnPublishAssignment_Click;
            // 
            // AssignmentduetimePicker
            // 
            AssignmentduetimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignmentduetimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignmentduetimePicker.Format = DateTimePickerFormat.Time;
            AssignmentduetimePicker.Location = new Point(603, 244);
            AssignmentduetimePicker.Name = "AssignmentduetimePicker";
            AssignmentduetimePicker.Size = new Size(320, 34);
            AssignmentduetimePicker.TabIndex = 17;
            // 
            // AssignmentduedatePicker
            // 
            AssignmentduedatePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignmentduedatePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignmentduedatePicker.Format = DateTimePickerFormat.Short;
            AssignmentduedatePicker.Location = new Point(71, 244);
            AssignmentduedatePicker.Name = "AssignmentduedatePicker";
            AssignmentduedatePicker.Size = new Size(320, 34);
            AssignmentduedatePicker.TabIndex = 16;
            // 
            // lblAssignmentDueTime
            // 
            lblAssignmentDueTime.AutoSize = true;
            lblAssignmentDueTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAssignmentDueTime.ForeColor = Color.FromArgb(68, 68, 68);
            lblAssignmentDueTime.Location = new Point(569, 202);
            lblAssignmentDueTime.Name = "lblAssignmentDueTime";
            lblAssignmentDueTime.Size = new Size(100, 28);
            lblAssignmentDueTime.TabIndex = 15;
            lblAssignmentDueTime.Text = "Due Time";
            // 
            // lblAssignmentDueDate
            // 
            lblAssignmentDueDate.AutoSize = true;
            lblAssignmentDueDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAssignmentDueDate.ForeColor = Color.FromArgb(68, 68, 68);
            lblAssignmentDueDate.Location = new Point(49, 202);
            lblAssignmentDueDate.Name = "lblAssignmentDueDate";
            lblAssignmentDueDate.Size = new Size(97, 28);
            lblAssignmentDueDate.TabIndex = 14;
            lblAssignmentDueDate.Text = "Due Date";
            // 
            // txtAssignmentTitle
            // 
            txtAssignmentTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssignmentTitle.Location = new Point(71, 141);
            txtAssignmentTitle.Name = "txtAssignmentTitle";
            txtAssignmentTitle.PlaceholderText = "e.g. Assignment#01";
            txtAssignmentTitle.Size = new Size(855, 34);
            txtAssignmentTitle.TabIndex = 13;
            // 
            // lblAssignmentTitle
            // 
            lblAssignmentTitle.AutoSize = true;
            lblAssignmentTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAssignmentTitle.ForeColor = Color.FromArgb(68, 68, 68);
            lblAssignmentTitle.Location = new Point(49, 94);
            lblAssignmentTitle.Name = "lblAssignmentTitle";
            lblAssignmentTitle.Size = new Size(165, 28);
            lblAssignmentTitle.TabIndex = 12;
            lblAssignmentTitle.Text = "Assignment Title";
            // 
            // panelChooseFile
            // 
            panelChooseFile.BorderStyle = BorderStyle.FixedSingle;
            panelChooseFile.Controls.Add(lblFileName);
            panelChooseFile.Controls.Add(btnChooseFile);
            panelChooseFile.Location = new Point(71, 560);
            panelChooseFile.Name = "panelChooseFile";
            panelChooseFile.Size = new Size(855, 68);
            panelChooseFile.TabIndex = 11;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = Color.Black;
            lblFileName.Location = new Point(153, 22);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(119, 23);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "No file chosen";
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = SystemColors.ButtonFace;
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseFile.Location = new Point(21, 16);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(126, 34);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // lblUploadFile
            // 
            lblUploadFile.AutoSize = true;
            lblUploadFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUploadFile.ForeColor = Color.FromArgb(68, 68, 68);
            lblUploadFile.Location = new Point(49, 509);
            lblUploadFile.Name = "lblUploadFile";
            lblUploadFile.Size = new Size(114, 28);
            lblUploadFile.TabIndex = 10;
            lblUploadFile.Text = "Upload File";
            // 
            // btnBackToAssignmentsQuizzesFromAssignment
            // 
            btnBackToAssignmentsQuizzesFromAssignment.BackColor = Color.FromArgb(229, 231, 235);
            btnBackToAssignmentsQuizzesFromAssignment.FlatAppearance.BorderSize = 0;
            btnBackToAssignmentsQuizzesFromAssignment.FlatStyle = FlatStyle.Flat;
            btnBackToAssignmentsQuizzesFromAssignment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToAssignmentsQuizzesFromAssignment.ForeColor = Color.Black;
            btnBackToAssignmentsQuizzesFromAssignment.Location = new Point(630, 24);
            btnBackToAssignmentsQuizzesFromAssignment.Name = "btnBackToAssignmentsQuizzesFromAssignment";
            btnBackToAssignmentsQuizzesFromAssignment.Size = new Size(296, 56);
            btnBackToAssignmentsQuizzesFromAssignment.TabIndex = 9;
            btnBackToAssignmentsQuizzesFromAssignment.Text = "Back to Assignments && Quizzes";
            btnBackToAssignmentsQuizzesFromAssignment.UseVisualStyleBackColor = false;
            btnBackToAssignmentsQuizzesFromAssignment.Click += btnBackToAssignmentsQuizzesFromAssignment_Click;
            // 
            // lblCreateAssignment
            // 
            lblCreateAssignment.AutoSize = true;
            lblCreateAssignment.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCreateAssignment.ForeColor = Color.FromArgb(17, 24, 39);
            lblCreateAssignment.Location = new Point(49, 33);
            lblCreateAssignment.Name = "lblCreateAssignment";
            lblCreateAssignment.Size = new Size(259, 37);
            lblCreateAssignment.TabIndex = 4;
            lblCreateAssignment.Text = "Create Assignment";
            // 
            // teacherSidebar1
            // 
            teacherSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            teacherSidebar1.Location = new Point(0, 0);
            teacherSidebar1.Name = "teacherSidebar1";
            teacherSidebar1.Size = new Size(300, 752);
            teacherSidebar1.TabIndex = 25;
            // 
            // Teacher_CreateAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(teacherSidebar1);
            Controls.Add(panelCreateAssignment);
            Name = "Teacher_CreateAssignment";
            Text = "Teacher_CreateAssignment";
            panelCreateAssignment.ResumeLayout(false);
            panelCreateAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalMarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAssignmentAttempts).EndInit();
            panelChooseFile.ResumeLayout(false);
            panelChooseFile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCreateAssignment;
        private Label lblAssignmentAttempts;
        private NumericUpDown numericAssignmentAttempts;
        private RoundedButton btnPublishAssignment;
        private DateTimePicker AssignmentduetimePicker;
        private DateTimePicker AssignmentduedatePicker;
        private Label lblAssignmentDueTime;
        private Label lblAssignmentDueDate;
        private TextBox txtAssignmentTitle;
        private Label lblAssignmentTitle;
        private Panel panelChooseFile;
        private Label lblFileName;
        private Button btnChooseFile;
        private Label lblUploadFile;
        private RoundedButton btnBackToAssignmentsQuizzesFromAssignment;
        private Label lblCreateAssignment;
        private Label lblTotalMarks;
        private NumericUpDown numericTotalMarks;
        private TeacherSidebar teacherSidebar1;
    }
}