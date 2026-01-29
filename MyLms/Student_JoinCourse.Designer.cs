namespace MyLms
{
    partial class Student_JoinCourse
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
            panelJoinCourse = new Panel();
            btnJoinCourse = new RoundedButton();
            txtCourseCode = new TextBox();
            lblCourseCode = new Label();
            btnBacktoDashboard = new RoundedButton();
            lblJoinCourse = new Label();
            studentSidebar1 = new StudentSidebar();
            panelJoinCourse.SuspendLayout();
            SuspendLayout();
            // 
            // panelJoinCourse
            // 
            panelJoinCourse.BackColor = Color.FromArgb(243, 244, 246);
            panelJoinCourse.Controls.Add(btnJoinCourse);
            panelJoinCourse.Controls.Add(txtCourseCode);
            panelJoinCourse.Controls.Add(lblCourseCode);
            panelJoinCourse.Controls.Add(btnBacktoDashboard);
            panelJoinCourse.Controls.Add(lblJoinCourse);
            panelJoinCourse.Location = new Point(301, 0);
            panelJoinCourse.Name = "panelJoinCourse";
            panelJoinCourse.Size = new Size(980, 752);
            panelJoinCourse.TabIndex = 19;
            // 
            // btnJoinCourse
            // 
            btnJoinCourse.BackColor = Color.FromArgb(79, 70, 229);
            btnJoinCourse.Cursor = Cursors.Hand;
            btnJoinCourse.FlatAppearance.BorderSize = 0;
            btnJoinCourse.FlatStyle = FlatStyle.Flat;
            btnJoinCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJoinCourse.ForeColor = Color.White;
            btnJoinCourse.Location = new Point(51, 211);
            btnJoinCourse.Name = "btnJoinCourse";
            btnJoinCourse.Size = new Size(144, 47);
            btnJoinCourse.TabIndex = 8;
            btnJoinCourse.Text = "Join Course";
            btnJoinCourse.UseVisualStyleBackColor = false;
            btnJoinCourse.Click += btnJoinCourse_Click;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseCode.Location = new Point(51, 153);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.PlaceholderText = "e.g., 123456";
            txtCourseCode.Size = new Size(404, 34);
            txtCourseCode.TabIndex = 7;
            txtCourseCode.TextChanged += txtCourseCode_TextChanged;
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseCode.ForeColor = Color.FromArgb(68, 68, 68);
            lblCourseCode.Location = new Point(45, 106);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(247, 28);
            lblCourseCode.TabIndex = 6;
            lblCourseCode.Text = "Enter 6-digit Course Code";
            // 
            // btnBacktoDashboard
            // 
            btnBacktoDashboard.BackColor = Color.FromArgb(229, 231, 235);
            btnBacktoDashboard.FlatAppearance.BorderSize = 0;
            btnBacktoDashboard.FlatStyle = FlatStyle.Flat;
            btnBacktoDashboard.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBacktoDashboard.ForeColor = Color.Black;
            btnBacktoDashboard.Location = new Point(722, 32);
            btnBacktoDashboard.Name = "btnBacktoDashboard";
            btnBacktoDashboard.Size = new Size(225, 56);
            btnBacktoDashboard.TabIndex = 5;
            btnBacktoDashboard.Text = "Back to Dashboard";
            btnBacktoDashboard.UseVisualStyleBackColor = false;
            btnBacktoDashboard.Click += btnBacktoDashboard_Click;
            // 
            // lblJoinCourse
            // 
            lblJoinCourse.AutoSize = true;
            lblJoinCourse.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblJoinCourse.ForeColor = Color.FromArgb(17, 24, 39);
            lblJoinCourse.Location = new Point(45, 34);
            lblJoinCourse.Name = "lblJoinCourse";
            lblJoinCourse.Size = new Size(187, 37);
            lblJoinCourse.TabIndex = 4;
            lblJoinCourse.Text = "Join a Course";
            // 
            // studentSidebar1
            // 
            studentSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            studentSidebar1.Location = new Point(0, 0);
            studentSidebar1.Name = "studentSidebar1";
            studentSidebar1.Size = new Size(300, 752);
            studentSidebar1.TabIndex = 22;
            // 
            // Student_JoinCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(studentSidebar1);
            Controls.Add(panelJoinCourse);
            Name = "Student_JoinCourse";
            Text = "Student_JoinCourse";
            panelJoinCourse.ResumeLayout(false);
            panelJoinCourse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelJoinCourse;
        private RoundedButton btnJoinCourse;
        private TextBox txtCourseCode;
        private Label lblCourseCode;
        private RoundedButton btnBacktoDashboard;
        private Label lblJoinCourse;
        private StudentSidebar studentSidebar1;
    }
}