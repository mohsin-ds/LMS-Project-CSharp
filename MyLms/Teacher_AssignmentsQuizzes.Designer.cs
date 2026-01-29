using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    partial class Teacher_AssignmentsQuizzes
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
            panelAssignmentsQuizzes = new Panel();
            panelQuizzesInner = new Panel();
            btnAddQuiz = new RoundedButton();
            lblQuizzes = new Label();
            panelQuizzes = new Panel();
            panelAssignmentsInner = new Panel();
            btnAddAssignment = new RoundedButton();
            lblAssignments = new Label();
            panelAssignments = new Panel();
            btnBacktoCourses = new RoundedButton();
            lblAssignmentsQuizzes = new Label();
            teacherSidebar1 = new TeacherSidebar();
            panelAssignmentsQuizzes.SuspendLayout();
            panelQuizzesInner.SuspendLayout();
            panelAssignmentsInner.SuspendLayout();
            SuspendLayout();
            // 
            // panelAssignmentsQuizzes
            // 
            panelAssignmentsQuizzes.BackColor = Color.FromArgb(243, 244, 246);
            panelAssignmentsQuizzes.Controls.Add(panelQuizzesInner);
            panelAssignmentsQuizzes.Controls.Add(panelQuizzes);
            panelAssignmentsQuizzes.Controls.Add(panelAssignmentsInner);
            panelAssignmentsQuizzes.Controls.Add(panelAssignments);
            panelAssignmentsQuizzes.Controls.Add(btnBacktoCourses);
            panelAssignmentsQuizzes.Controls.Add(lblAssignmentsQuizzes);
            panelAssignmentsQuizzes.ForeColor = Color.FromArgb(156, 163, 175);
            panelAssignmentsQuizzes.Location = new Point(301, 0);
            panelAssignmentsQuizzes.Name = "panelAssignmentsQuizzes";
            panelAssignmentsQuizzes.Size = new Size(980, 752);
            panelAssignmentsQuizzes.TabIndex = 23;
            // 
            // panelQuizzesInner
            // 
            panelQuizzesInner.BackColor = Color.FromArgb(249, 250, 251);
            panelQuizzesInner.Controls.Add(btnAddQuiz);
            panelQuizzesInner.Controls.Add(lblQuizzes);
            panelQuizzesInner.Location = new Point(517, 106);
            panelQuizzesInner.Name = "panelQuizzesInner";
            panelQuizzesInner.Size = new Size(430, 107);
            panelQuizzesInner.TabIndex = 6;
            // 
            // btnAddQuiz
            // 
            btnAddQuiz.BackColor = Color.FromArgb(79, 70, 229);
            btnAddQuiz.Cursor = Cursors.Hand;
            btnAddQuiz.FlatAppearance.BorderSize = 0;
            btnAddQuiz.FlatStyle = FlatStyle.Flat;
            btnAddQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQuiz.ForeColor = Color.White;
            btnAddQuiz.Location = new Point(310, 30);
            btnAddQuiz.Name = "btnAddQuiz";
            btnAddQuiz.Size = new Size(94, 47);
            btnAddQuiz.TabIndex = 7;
            btnAddQuiz.Text = "+ Quiz";
            btnAddQuiz.UseVisualStyleBackColor = false;
            btnAddQuiz.Click += btnAddQuiz_Click;
            // 
            // lblQuizzes
            // 
            lblQuizzes.AutoSize = true;
            lblQuizzes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblQuizzes.ForeColor = Color.FromArgb(17, 24, 39);
            lblQuizzes.Location = new Point(31, 32);
            lblQuizzes.Name = "lblQuizzes";
            lblQuizzes.Size = new Size(114, 37);
            lblQuizzes.TabIndex = 4;
            lblQuizzes.Text = "Quizzes";
            // 
            // panelQuizzes
            // 
            panelQuizzes.BackColor = Color.White;
            panelQuizzes.Location = new Point(517, 215);
            panelQuizzes.Name = "panelQuizzes";
            panelQuizzes.Size = new Size(430, 500);
            panelQuizzes.TabIndex = 8;
            // 
            // panelAssignmentsInner
            // 
            panelAssignmentsInner.BackColor = Color.FromArgb(249, 250, 251);
            panelAssignmentsInner.Controls.Add(btnAddAssignment);
            panelAssignmentsInner.Controls.Add(lblAssignments);
            panelAssignmentsInner.Location = new Point(45, 106);
            panelAssignmentsInner.Name = "panelAssignmentsInner";
            panelAssignmentsInner.Size = new Size(430, 107);
            panelAssignmentsInner.TabIndex = 5;
            // 
            // btnAddAssignment
            // 
            btnAddAssignment.BackColor = Color.FromArgb(79, 70, 229);
            btnAddAssignment.Cursor = Cursors.Hand;
            btnAddAssignment.FlatAppearance.BorderSize = 0;
            btnAddAssignment.FlatStyle = FlatStyle.Flat;
            btnAddAssignment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAssignment.ForeColor = Color.White;
            btnAddAssignment.Location = new Point(246, 30);
            btnAddAssignment.Name = "btnAddAssignment";
            btnAddAssignment.Size = new Size(159, 47);
            btnAddAssignment.TabIndex = 6;
            btnAddAssignment.Text = "+ Assignment";
            btnAddAssignment.UseVisualStyleBackColor = false;
            btnAddAssignment.Click += btnAddAssignment_Click;
            // 
            // lblAssignments
            // 
            lblAssignments.AutoSize = true;
            lblAssignments.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAssignments.ForeColor = Color.FromArgb(17, 24, 39);
            lblAssignments.Location = new Point(31, 32);
            lblAssignments.Name = "lblAssignments";
            lblAssignments.Size = new Size(180, 37);
            lblAssignments.TabIndex = 4;
            lblAssignments.Text = "Assignments";
            // 
            // panelAssignments
            // 
            panelAssignments.BackColor = Color.White;
            panelAssignments.Location = new Point(45, 215);
            panelAssignments.Name = "panelAssignments";
            panelAssignments.Size = new Size(430, 500);
            panelAssignments.TabIndex = 7;
            // 
            // btnBacktoCourses
            // 
            btnBacktoCourses.BackColor = Color.FromArgb(229, 231, 235);
            btnBacktoCourses.FlatAppearance.BorderSize = 0;
            btnBacktoCourses.FlatStyle = FlatStyle.Flat;
            btnBacktoCourses.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBacktoCourses.ForeColor = Color.Black;
            btnBacktoCourses.Location = new Point(722, 32);
            btnBacktoCourses.Name = "btnBacktoCourses";
            btnBacktoCourses.Size = new Size(225, 56);
            btnBacktoCourses.TabIndex = 6;
            btnBacktoCourses.Text = "Back to Courses";
            btnBacktoCourses.UseVisualStyleBackColor = false;
            btnBacktoCourses.Click += btnBacktoCourses_Click;
            // 
            // lblAssignmentsQuizzes
            // 
            lblAssignmentsQuizzes.AutoSize = true;
            lblAssignmentsQuizzes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAssignmentsQuizzes.ForeColor = Color.FromArgb(17, 24, 39);
            lblAssignmentsQuizzes.Location = new Point(45, 34);
            lblAssignmentsQuizzes.Name = "lblAssignmentsQuizzes";
            lblAssignmentsQuizzes.Size = new Size(314, 37);
            lblAssignmentsQuizzes.TabIndex = 3;
            lblAssignmentsQuizzes.Text = "Assignments && Quizzes";
            // 
            // teacherSidebar1
            // 
            teacherSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            teacherSidebar1.Location = new Point(0, 0);
            teacherSidebar1.Name = "teacherSidebar1";
            teacherSidebar1.Size = new Size(300, 752);
            teacherSidebar1.TabIndex = 9;
            // 
            // Teacher_AssignmentsQuizzes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(teacherSidebar1);
            Controls.Add(panelAssignmentsQuizzes);
            Name = "Teacher_AssignmentsQuizzes";
            Text = "Teacher_AssignmentsQuizzes";
            panelAssignmentsQuizzes.ResumeLayout(false);
            panelAssignmentsQuizzes.PerformLayout();
            panelQuizzesInner.ResumeLayout(false);
            panelQuizzesInner.PerformLayout();
            panelAssignmentsInner.ResumeLayout(false);
            panelAssignmentsInner.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelAssignmentsQuizzes;
        private System.Windows.Forms.Panel panelQuizzesInner;
        private RoundedButton btnAddQuiz;
        private System.Windows.Forms.Label lblQuizzes;
        private System.Windows.Forms.Panel panelQuizzes;
        private System.Windows.Forms.Panel panelAssignmentsInner;
        private RoundedButton btnAddAssignment;
        private System.Windows.Forms.Label lblAssignments;
        private System.Windows.Forms.Panel panelAssignments;
        private RoundedButton btnBacktoCourses;
        private System.Windows.Forms.Label lblAssignmentsQuizzes;
        private TeacherSidebar teacherSidebar1;
    }
}