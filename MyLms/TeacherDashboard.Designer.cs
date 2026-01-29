namespace MyLms
{
    partial class TeacherDashboard
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
            panelDashboard = new Panel();
            btnCreateNewCourse = new MyLms.RoundedButton();
            panelRecentActivity = new Panel();
            lblRecentActivity = new Label();
            lblDashboard = new Label();
            panelTotalStudents1 = new Panel();
            panelTotalStudents2 = new Panel();
            lblNoTotalStudents = new Label();
            lblTotalStudents = new Label();
            panelActiveCourses1 = new Panel();
            lblNoActiveCourses = new Label();
            panelActiveCourses2 = new Panel();
            lblActiveCourses = new Label();
            teacherSidebar1 = new MyLms.TeacherSidebar();
            panelDashboard.SuspendLayout();
            panelTotalStudents1.SuspendLayout();
            panelActiveCourses1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(243, 244, 246);
            panelDashboard.Controls.Add(btnCreateNewCourse);
            panelDashboard.Controls.Add(panelRecentActivity);
            panelDashboard.Controls.Add(lblRecentActivity);
            panelDashboard.Controls.Add(lblDashboard);
            panelDashboard.Controls.Add(panelTotalStudents1);
            panelDashboard.Controls.Add(panelActiveCourses1);
            panelDashboard.ForeColor = Color.FromArgb(156, 163, 175);
            panelDashboard.Location = new Point(301, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(980, 752);
            panelDashboard.TabIndex = 5;
            // 
            // btnCreateNewCourse
            // 
            btnCreateNewCourse.BackColor = Color.FromArgb(79, 70, 229);
            btnCreateNewCourse.Cursor = Cursors.Hand;
            btnCreateNewCourse.FlatAppearance.BorderSize = 0;
            btnCreateNewCourse.FlatStyle = FlatStyle.Flat;
            btnCreateNewCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateNewCourse.ForeColor = Color.White;
            btnCreateNewCourse.Location = new Point(722, 24);
            btnCreateNewCourse.Name = "btnCreateNewCourse";
            btnCreateNewCourse.Size = new Size(210, 47);
            btnCreateNewCourse.TabIndex = 5;
            btnCreateNewCourse.Text = "Create New Course";
            btnCreateNewCourse.UseVisualStyleBackColor = false;
            // 
            // panelRecentActivity
            // 
            panelRecentActivity.AutoScroll = true;
            panelRecentActivity.BackColor = Color.White;
            panelRecentActivity.Location = new Point(45, 322);
            panelRecentActivity.Name = "panelRecentActivity";
            panelRecentActivity.Size = new Size(887, 411);
            panelRecentActivity.TabIndex = 13;
            // 
            // lblRecentActivity
            // 
            lblRecentActivity.AutoSize = true;
            lblRecentActivity.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRecentActivity.ForeColor = Color.FromArgb(17, 24, 39);
            lblRecentActivity.Location = new Point(45, 276);
            lblRecentActivity.Name = "lblRecentActivity";
            lblRecentActivity.Size = new Size(211, 37);
            lblRecentActivity.TabIndex = 12;
            lblRecentActivity.Text = "Recent Activity";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.FromArgb(17, 24, 39);
            lblDashboard.Location = new Point(45, 34);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(205, 37);
            lblDashboard.TabIndex = 3;
            lblDashboard.Text = "My Dashboard";
            // 
            // panelTotalStudents1
            // 
            panelTotalStudents1.BackColor = Color.White;
            panelTotalStudents1.Controls.Add(panelTotalStudents2);
            panelTotalStudents1.Controls.Add(lblNoTotalStudents);
            panelTotalStudents1.Controls.Add(lblTotalStudents);
            panelTotalStudents1.Location = new Point(514, 135);
            panelTotalStudents1.Name = "panelTotalStudents1";
            panelTotalStudents1.Size = new Size(418, 110);
            panelTotalStudents1.TabIndex = 11;
            // 
            // panelTotalStudents2
            // 
            panelTotalStudents2.BackColor = Color.FromArgb(230, 175, 0);
            panelTotalStudents2.Location = new Point(0, 0);
            panelTotalStudents2.Name = "panelTotalStudents2";
            panelTotalStudents2.Size = new Size(10, 110);
            panelTotalStudents2.TabIndex = 13;
            // 
            // lblNoTotalStudents
            // 
            lblNoTotalStudents.AutoSize = true;
            lblNoTotalStudents.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoTotalStudents.ForeColor = Color.Black;
            lblNoTotalStudents.Location = new Point(192, 13);
            lblNoTotalStudents.Name = "lblNoTotalStudents";
            lblNoTotalStudents.Size = new Size(43, 50);
            lblNoTotalStudents.TabIndex = 2;
            lblNoTotalStudents.Text = "0";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI", 10F);
            lblTotalStudents.ForeColor = Color.FromArgb(107, 114, 144);
            lblTotalStudents.Location = new Point(148, 71);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(117, 23);
            lblTotalStudents.TabIndex = 0;
            lblTotalStudents.Text = "Total Students";
            // 
            // panelActiveCourses1
            // 
            panelActiveCourses1.BackColor = Color.White;
            panelActiveCourses1.Controls.Add(lblNoActiveCourses);
            panelActiveCourses1.Controls.Add(panelActiveCourses2);
            panelActiveCourses1.Controls.Add(lblActiveCourses);
            panelActiveCourses1.Location = new Point(45, 135);
            panelActiveCourses1.Name = "panelActiveCourses1";
            panelActiveCourses1.Size = new Size(418, 110);
            panelActiveCourses1.TabIndex = 9;
            // 
            // lblNoActiveCourses
            // 
            lblNoActiveCourses.AutoSize = true;
            lblNoActiveCourses.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoActiveCourses.ForeColor = Color.Black;
            lblNoActiveCourses.Location = new Point(188, 13);
            lblNoActiveCourses.Name = "lblNoActiveCourses";
            lblNoActiveCourses.Size = new Size(43, 50);
            lblNoActiveCourses.TabIndex = 13;
            lblNoActiveCourses.Text = "0";
            // 
            // panelActiveCourses2
            // 
            panelActiveCourses2.BackColor = Color.FromArgb(30, 100, 255);
            panelActiveCourses2.Location = new Point(0, 0);
            panelActiveCourses2.Name = "panelActiveCourses2";
            panelActiveCourses2.Size = new Size(10, 110);
            panelActiveCourses2.TabIndex = 12;
            // 
            // lblActiveCourses
            // 
            lblActiveCourses.AutoSize = true;
            lblActiveCourses.Font = new Font("Segoe UI", 10F);
            lblActiveCourses.ForeColor = Color.FromArgb(107, 114, 144);
            lblActiveCourses.Location = new Point(148, 71);
            lblActiveCourses.Name = "lblActiveCourses";
            lblActiveCourses.Size = new Size(121, 23);
            lblActiveCourses.TabIndex = 0;
            lblActiveCourses.Text = "Active Courses";
            // 
            // teacherSidebar1
            // 
            teacherSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            teacherSidebar1.Location = new Point(0, 0);
            teacherSidebar1.Name = "teacherSidebar1";
            teacherSidebar1.Size = new Size(300, 752);
            teacherSidebar1.TabIndex = 6;
            teacherSidebar1.TeacherName = "Teacher Name";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(teacherSidebar1);
            Controls.Add(panelDashboard);
            Name = "TeacherDashboard";
            Text = "TeacherDashboard";
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            panelTotalStudents1.ResumeLayout(false);
            panelTotalStudents1.PerformLayout();
            panelActiveCourses1.ResumeLayout(false);
            panelActiveCourses1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelRecentActivity;
        private System.Windows.Forms.Label lblRecentActivity;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panelTotalStudents1;
        private System.Windows.Forms.Panel panelTotalStudents2;
        private System.Windows.Forms.Label lblNoTotalStudents;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Panel panelActiveCourses1;
        private System.Windows.Forms.Label lblNoActiveCourses;
        private System.Windows.Forms.Panel panelActiveCourses2;
        private System.Windows.Forms.Label lblActiveCourses;
        private MyLms.RoundedButton btnCreateNewCourse;
        private MyLms.TeacherSidebar teacherSidebar1;
    }
}