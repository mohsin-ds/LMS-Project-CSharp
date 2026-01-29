namespace MyLms
{
    partial class Teacher_My_Courses
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
            teacherSidebar1 = new TeacherSidebar();
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
            panelMyCourses.Size = new Size(981, 752);
            panelMyCourses.TabIndex = 26;
            // 
            // comboBoxDrop
            // 
            comboBoxDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxDrop.FormattingEnabled = true;
            comboBoxDrop.Location = new Point(664, 37);
            comboBoxDrop.Name = "comboBoxDrop";
            comboBoxDrop.Size = new Size(259, 36);
            comboBoxDrop.TabIndex = 8;
            // 
            // btnDropCourse
            // 
            btnDropCourse.BackColor = Color.Red;
            btnDropCourse.Cursor = Cursors.Hand;
            btnDropCourse.FlatAppearance.BorderSize = 0;
            btnDropCourse.FlatStyle = FlatStyle.Flat;
            btnDropCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDropCourse.ForeColor = Color.White;
            btnDropCourse.Location = new Point(506, 31);
            btnDropCourse.Name = "btnDropCourse";
            btnDropCourse.Size = new Size(152, 47);
            btnDropCourse.TabIndex = 6;
            btnDropCourse.Text = "Drop Course";
            btnDropCourse.UseVisualStyleBackColor = false;
            btnDropCourse.Click += btnDropCourse_Click;
            // 
            // lblMyCourses
            // 
            lblMyCourses.AutoSize = true;
            lblMyCourses.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMyCourses.ForeColor = Color.FromArgb(17, 24, 39);
            lblMyCourses.Location = new Point(45, 35);
            lblMyCourses.Name = "lblMyCourses";
            lblMyCourses.Size = new Size(165, 37);
            lblMyCourses.TabIndex = 3;
            lblMyCourses.Text = "My Courses";
            // 
            // teacherSidebar1
            // 
            teacherSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            teacherSidebar1.Location = new Point(0, 0);
            teacherSidebar1.Name = "teacherSidebar1";
            teacherSidebar1.Size = new Size(300, 752);
            teacherSidebar1.TabIndex = 27;
            // 
            // Teacher_My_Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 749);
            Controls.Add(teacherSidebar1);
            Controls.Add(panelMyCourses);
            Name = "Teacher_My_Courses";
            Text = "Teacher_My_Courses";
            panelMyCourses.ResumeLayout(false);
            panelMyCourses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMyCourses;
        private Label lblMyCourses;
        private ComboBox comboBoxDrop;
        private RoundedButton btnDropCourse;
        private TeacherSidebar teacherSidebar1;
    }
}