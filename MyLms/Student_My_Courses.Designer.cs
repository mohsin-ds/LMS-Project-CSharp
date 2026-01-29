namespace MyLms
{
    partial class Student_My_Courses
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
            panelMyCourses = new Panel();
            comboBoxDrop = new ComboBox();
            btnDropCourse = new RoundedButton();
            lblMyCourses = new Label();
            studentSidebar1 = new StudentSidebar();
            panelMyCourses.SuspendLayout();
            SuspendLayout();
            // 
            // panelMyCourses
            // 
            panelMyCourses.BackColor = Color.FromArgb(243, 244, 246);
            panelMyCourses.Controls.Add(comboBoxDrop);
            panelMyCourses.Controls.Add(btnDropCourse);
            panelMyCourses.Controls.Add(lblMyCourses);
            panelMyCourses.ForeColor = Color.FromArgb(156, 163, 175);
            panelMyCourses.Location = new Point(301, 0);
            panelMyCourses.Name = "panelMyCourses";
            panelMyCourses.Size = new Size(980, 752);
            panelMyCourses.TabIndex = 20;
            // 
            // comboBoxDrop
            // 
            comboBoxDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxDrop.FormattingEnabled = true;
            comboBoxDrop.Location = new Point(696, 28);
            comboBoxDrop.Name = "comboBoxDrop";
            comboBoxDrop.Size = new Size(259, 36);
            comboBoxDrop.TabIndex = 10;
            // 
            // btnDropCourse
            // 
            btnDropCourse.BackColor = Color.Red;
            btnDropCourse.Cursor = Cursors.Hand;
            btnDropCourse.FlatAppearance.BorderSize = 0;
            btnDropCourse.FlatStyle = FlatStyle.Flat;
            btnDropCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDropCourse.ForeColor = Color.White;
            btnDropCourse.Location = new Point(538, 22);
            btnDropCourse.Name = "btnDropCourse";
            btnDropCourse.Size = new Size(152, 47);
            btnDropCourse.TabIndex = 9;
            btnDropCourse.Text = "Drop Course";
            btnDropCourse.UseVisualStyleBackColor = false;
            btnDropCourse.Click += btnDropCourse_Click;
            // 
            // lblMyCourses
            // 
            lblMyCourses.AutoSize = true;
            lblMyCourses.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMyCourses.ForeColor = Color.FromArgb(17, 24, 39);
            lblMyCourses.Location = new Point(45, 34);
            lblMyCourses.Name = "lblMyCourses";
            lblMyCourses.Size = new Size(165, 37);
            lblMyCourses.TabIndex = 3;
            lblMyCourses.Text = "My Courses";
            // 
            // studentSidebar1
            // 
            studentSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            studentSidebar1.Location = new Point(0, 0);
            studentSidebar1.Name = "studentSidebar1";
            studentSidebar1.Size = new Size(300, 752);
            studentSidebar1.TabIndex = 21;
            // 
            // Student_My_Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(studentSidebar1);
            Controls.Add(panelMyCourses);
            Name = "Student_My_Courses";
            Text = "Student_My_Courses";
            panelMyCourses.ResumeLayout(false);
            panelMyCourses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMyCourses;
        private Label lblMyCourses;
        private ComboBox comboBoxDrop;
        private RoundedButton btnDropCourse;
        private StudentSidebar studentSidebar1;
    }
}