namespace MyLms
{
    partial class Teacher_CreateCourse
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
            CreateCoursePanel = new Panel();
            txtCourseCode = new TextBox();
            btnBacktoDashboard = new RoundedButton();
            btnCreateCourse = new RoundedButton();
            lblCourseCode = new Label();
            txtCourseDescription = new RichTextBox();
            lblDescription = new Label();
            txtCourseName = new TextBox();
            lblCourseName = new Label();
            lblCreateCourseHeader = new Label();
            teacherSidebar1 = new TeacherSidebar();
            CreateCoursePanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateCoursePanel
            // 
            CreateCoursePanel.BackColor = Color.FromArgb(243, 244, 246);
            CreateCoursePanel.Controls.Add(txtCourseCode);
            CreateCoursePanel.Controls.Add(btnBacktoDashboard);
            CreateCoursePanel.Controls.Add(btnCreateCourse);
            CreateCoursePanel.Controls.Add(lblCourseCode);
            CreateCoursePanel.Controls.Add(txtCourseDescription);
            CreateCoursePanel.Controls.Add(lblDescription);
            CreateCoursePanel.Controls.Add(txtCourseName);
            CreateCoursePanel.Controls.Add(lblCourseName);
            CreateCoursePanel.Controls.Add(lblCreateCourseHeader);
            CreateCoursePanel.Location = new Point(301, 0);
            CreateCoursePanel.Margin = new Padding(3, 4, 3, 4);
            CreateCoursePanel.Name = "CreateCoursePanel";
            CreateCoursePanel.Size = new Size(980, 752);
            CreateCoursePanel.TabIndex = 8;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseCode.Location = new Point(196, 401);
            txtCourseCode.Margin = new Padding(3, 4, 3, 4);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.PlaceholderText = "e.g, VP1102";
            txtCourseCode.Size = new Size(150, 34);
            txtCourseCode.TabIndex = 9;
            txtCourseCode.TextChanged += txtCourseCode_TextChanged;
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
            btnBacktoDashboard.TabIndex = 8;
            btnBacktoDashboard.Text = "Back to Dashboard";
            btnBacktoDashboard.UseVisualStyleBackColor = false;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.BackColor = Color.FromArgb(79, 70, 229);
            btnCreateCourse.FlatAppearance.BorderSize = 0;
            btnCreateCourse.FlatStyle = FlatStyle.Flat;
            btnCreateCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateCourse.ForeColor = Color.White;
            btnCreateCourse.Location = new Point(270, 465);
            btnCreateCourse.Margin = new Padding(3, 4, 3, 4);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(187, 56);
            btnCreateCourse.TabIndex = 7;
            btnCreateCourse.Text = "Create Course";
            btnCreateCourse.UseVisualStyleBackColor = false;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCourseCode.ForeColor = Color.FromArgb(68, 68, 68);
            lblCourseCode.Location = new Point(51, 404);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(133, 28);
            lblCourseCode.TabIndex = 5;
            lblCourseCode.Text = "Course Code:";
            // 
            // txtCourseDescription
            // 
            txtCourseDescription.Location = new Point(51, 249);
            txtCourseDescription.Margin = new Padding(3, 4, 3, 4);
            txtCourseDescription.Name = "txtCourseDescription";
            txtCourseDescription.Size = new Size(675, 132);
            txtCourseDescription.TabIndex = 4;
            txtCourseDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(68, 68, 68);
            lblDescription.Location = new Point(45, 200);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(115, 28);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseName.Location = new Point(51, 153);
            txtCourseName.Margin = new Padding(3, 4, 3, 4);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.PlaceholderText = "e.g. Visual Programming";
            txtCourseName.Size = new Size(675, 34);
            txtCourseName.TabIndex = 2;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCourseName.ForeColor = Color.FromArgb(68, 68, 68);
            lblCourseName.Location = new Point(45, 106);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(135, 28);
            lblCourseName.TabIndex = 1;
            lblCourseName.Text = "Course Name";
            // 
            // lblCreateCourseHeader
            // 
            lblCreateCourseHeader.AutoSize = true;
            lblCreateCourseHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateCourseHeader.Location = new Point(45, 34);
            lblCreateCourseHeader.Name = "lblCreateCourseHeader";
            lblCreateCourseHeader.Size = new Size(261, 37);
            lblCreateCourseHeader.TabIndex = 0;
            lblCreateCourseHeader.Text = "Create New Course";
            // 
            // teacherSidebar1
            // 
            teacherSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            teacherSidebar1.Location = new Point(0, 0);
            teacherSidebar1.Name = "teacherSidebar1";
            teacherSidebar1.Size = new Size(300, 752);
            teacherSidebar1.TabIndex = 9;
            // 
            // Teacher_CreateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(teacherSidebar1);
            Controls.Add(CreateCoursePanel);
            Name = "Teacher_CreateCourse";
            Text = "Teacher_CreateCourse";
            CreateCoursePanel.ResumeLayout(false);
            CreateCoursePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel CreateCoursePanel;
        private RoundedButton btnBacktoDashboard;
        private RoundedButton btnCreateCourse;
        private Label lblCourseCode;
        private RichTextBox txtCourseDescription;
        private Label lblDescription;
        private TextBox txtCourseName;
        private Label lblCourseName;
        private Label lblCreateCourseHeader;
        private TextBox txtCourseCode;
        private TeacherSidebar teacherSidebar1;
    }
}