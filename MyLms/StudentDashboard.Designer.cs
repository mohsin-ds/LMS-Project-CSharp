using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    partial class StudentDashboard
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
            panelRecentActivity = new Panel();
            lblRecentActivity = new Label();
            lblDashboard = new Label();
            btnJoinNewCourse = new RoundedButton();
            panelPendingTasks1 = new Panel();
            panelPendingTasks2 = new Panel();
            lblNoPendingTasks = new Label();
            lblTotalStudents = new Label();
            panelEnrolledCourses1 = new Panel();
            panelEnrolledCourses2 = new Panel();
            lblNoEnrolledCourses = new Label();
            lblEnrolledCourses = new Label();
            studentSidebar1 = new StudentSidebar();
            panelDashboard.SuspendLayout();
            panelPendingTasks1.SuspendLayout();
            panelEnrolledCourses1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(243, 244, 246);
            panelDashboard.Controls.Add(panelRecentActivity);
            panelDashboard.Controls.Add(lblRecentActivity);
            panelDashboard.Controls.Add(lblDashboard);
            panelDashboard.Controls.Add(btnJoinNewCourse);
            panelDashboard.Controls.Add(panelPendingTasks1);
            panelDashboard.Controls.Add(panelEnrolledCourses1);
            panelDashboard.ForeColor = Color.FromArgb(156, 163, 175);
            panelDashboard.Location = new Point(301, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(980, 752);
            panelDashboard.TabIndex = 2;
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
            // btnJoinNewCourse
            // 
            btnJoinNewCourse.BackColor = Color.FromArgb(79, 70, 229);
            btnJoinNewCourse.Cursor = Cursors.Hand;
            btnJoinNewCourse.FlatAppearance.BorderSize = 0;
            btnJoinNewCourse.FlatStyle = FlatStyle.Flat;
            btnJoinNewCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJoinNewCourse.ForeColor = Color.White;
            btnJoinNewCourse.Location = new Point(722, 32);
            btnJoinNewCourse.Name = "btnJoinNewCourse";
            btnJoinNewCourse.Size = new Size(210, 47);
            btnJoinNewCourse.TabIndex = 4;
            btnJoinNewCourse.Text = "Join New Course";
            btnJoinNewCourse.UseVisualStyleBackColor = false;
            // 
            // panelPendingTasks1
            // 
            panelPendingTasks1.BackColor = Color.White;
            panelPendingTasks1.Controls.Add(panelPendingTasks2);
            panelPendingTasks1.Controls.Add(lblNoPendingTasks);
            panelPendingTasks1.Controls.Add(lblTotalStudents);
            panelPendingTasks1.Location = new Point(514, 135);
            panelPendingTasks1.Name = "panelPendingTasks1";
            panelPendingTasks1.Size = new Size(418, 110);
            panelPendingTasks1.TabIndex = 11;
            // 
            // panelPendingTasks2
            // 
            panelPendingTasks2.BackColor = Color.FromArgb(230, 175, 0);
            panelPendingTasks2.Location = new Point(0, 0);
            panelPendingTasks2.Name = "panelPendingTasks2";
            panelPendingTasks2.Size = new Size(10, 110);
            panelPendingTasks2.TabIndex = 13;
            // 
            // lblNoPendingTasks
            // 
            lblNoPendingTasks.AutoSize = true;
            lblNoPendingTasks.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoPendingTasks.ForeColor = Color.Black;
            lblNoPendingTasks.Location = new Point(192, 13);
            lblNoPendingTasks.Name = "lblNoPendingTasks";
            lblNoPendingTasks.Size = new Size(43, 50);
            lblNoPendingTasks.TabIndex = 2;
            lblNoPendingTasks.Text = "0";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI", 10F);
            lblTotalStudents.ForeColor = Color.FromArgb(107, 114, 144);
            lblTotalStudents.Location = new Point(148, 71);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(115, 23);
            lblTotalStudents.TabIndex = 0;
            lblTotalStudents.Text = "Pending Tasks";
            // 
            // panelEnrolledCourses1
            // 
            panelEnrolledCourses1.BackColor = Color.White;
            panelEnrolledCourses1.Controls.Add(panelEnrolledCourses2);
            panelEnrolledCourses1.Controls.Add(lblNoEnrolledCourses);
            panelEnrolledCourses1.Controls.Add(lblEnrolledCourses);
            panelEnrolledCourses1.Location = new Point(45, 135);
            panelEnrolledCourses1.Name = "panelEnrolledCourses1";
            panelEnrolledCourses1.Size = new Size(418, 110);
            panelEnrolledCourses1.TabIndex = 9;
            // 
            // panelEnrolledCourses2
            // 
            panelEnrolledCourses2.BackColor = Color.FromArgb(30, 100, 255);
            panelEnrolledCourses2.Location = new Point(0, 0);
            panelEnrolledCourses2.Name = "panelEnrolledCourses2";
            panelEnrolledCourses2.Size = new Size(10, 110);
            panelEnrolledCourses2.TabIndex = 12;
            // 
            // lblNoEnrolledCourses
            // 
            lblNoEnrolledCourses.AutoSize = true;
            lblNoEnrolledCourses.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoEnrolledCourses.ForeColor = Color.Black;
            lblNoEnrolledCourses.Location = new Point(192, 13);
            lblNoEnrolledCourses.Name = "lblNoEnrolledCourses";
            lblNoEnrolledCourses.Size = new Size(43, 50);
            lblNoEnrolledCourses.TabIndex = 1;
            lblNoEnrolledCourses.Text = "0";
            // 
            // lblEnrolledCourses
            // 
            lblEnrolledCourses.AutoSize = true;
            lblEnrolledCourses.Font = new Font("Segoe UI", 10F);
            lblEnrolledCourses.ForeColor = Color.FromArgb(107, 114, 144);
            lblEnrolledCourses.Location = new Point(148, 71);
            lblEnrolledCourses.Name = "lblEnrolledCourses";
            lblEnrolledCourses.Size = new Size(137, 23);
            lblEnrolledCourses.TabIndex = 0;
            lblEnrolledCourses.Text = "Enrolled Courses";
            // 
            // studentSidebar1
            // 
            studentSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            studentSidebar1.Location = new Point(0, 0);
            studentSidebar1.Name = "studentSidebar1";
            studentSidebar1.Size = new Size(300, 752);
            studentSidebar1.TabIndex = 3;
            // 
            // StudentDashboard
            // 
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(1282, 753);
            Controls.Add(studentSidebar1);
            Controls.Add(panelDashboard);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            panelPendingTasks1.ResumeLayout(false);
            panelPendingTasks1.PerformLayout();
            panelEnrolledCourses1.ResumeLayout(false);
            panelEnrolledCourses1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelRecentActivity;
        private System.Windows.Forms.Label lblRecentActivity;
        private System.Windows.Forms.Label lblDashboard;
        private MyLms.RoundedButton btnJoinNewCourse;
        private System.Windows.Forms.Panel panelPendingTasks1;
        private System.Windows.Forms.Panel panelPendingTasks2;
        private System.Windows.Forms.Label lblNoPendingTasks;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Panel panelEnrolledCourses1;
        private System.Windows.Forms.Panel panelEnrolledCourses2;
        private System.Windows.Forms.Label lblNoEnrolledCourses;
        private System.Windows.Forms.Label lblEnrolledCourses;
        private StudentSidebar studentSidebar1;
    }
}