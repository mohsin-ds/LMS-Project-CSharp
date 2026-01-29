namespace MyLms
{
    partial class Student_My_Grades
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

        private void InitializeComponent()
        {
            panelMyGrades = new Panel();
            comboBoxCourseList = new ComboBox();
            lblCourseGrade = new Label();
            dataGridViewMyGrades = new DataGridView();
            colCourse = new DataGridViewTextBoxColumn();
            colAssignment = new DataGridViewTextBoxColumn();
            colScore = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblMyGrades = new Label();
            studentSidebar1 = new StudentSidebar();
            panelMyGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyGrades).BeginInit();
            SuspendLayout();
            // 
            // panelMyGrades
            // 
            panelMyGrades.BackColor = Color.WhiteSmoke;
            panelMyGrades.Controls.Add(comboBoxCourseList);
            panelMyGrades.Controls.Add(lblCourseGrade);
            panelMyGrades.Controls.Add(dataGridViewMyGrades);
            panelMyGrades.Controls.Add(lblMyGrades);
            panelMyGrades.Location = new Point(301, 0);
            panelMyGrades.Name = "panelMyGrades";
            panelMyGrades.Size = new Size(982, 753);
            panelMyGrades.TabIndex = 3;
            // 
            // comboBoxCourseList
            // 
            comboBoxCourseList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourseList.Font = new Font("Segoe UI", 10F);
            comboBoxCourseList.FormattingEnabled = true;
            comboBoxCourseList.Location = new Point(640, 34);
            comboBoxCourseList.Name = "comboBoxCourseList";
            comboBoxCourseList.Size = new Size(300, 31);
            comboBoxCourseList.TabIndex = 2;
            // 
            // lblCourseGrade
            // 
            lblCourseGrade.AutoSize = true;
            lblCourseGrade.Font = new Font("Segoe UI", 12F);
            lblCourseGrade.Location = new Point(488, 35);
            lblCourseGrade.Name = "lblCourseGrade";
            lblCourseGrade.Size = new Size(133, 28);
            lblCourseGrade.TabIndex = 1;
            lblCourseGrade.Text = "Select Course:";
            // 
            // dataGridViewMyGrades
            // 
            dataGridViewMyGrades.AllowUserToAddRows = false;
            dataGridViewMyGrades.BackgroundColor = Color.White;
            dataGridViewMyGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMyGrades.Columns.AddRange(new DataGridViewColumn[] { colCourse, colAssignment, colScore, colStatus });
            dataGridViewMyGrades.Location = new Point(40, 140);
            dataGridViewMyGrades.Name = "dataGridViewMyGrades";
            dataGridViewMyGrades.RowHeadersVisible = false;
            dataGridViewMyGrades.RowHeadersWidth = 51;
            dataGridViewMyGrades.RowTemplate.Height = 35;
            dataGridViewMyGrades.Size = new Size(900, 520);
            dataGridViewMyGrades.TabIndex = 3;
            // 
            // colCourse
            // 
            colCourse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCourse.HeaderText = "Course";
            colCourse.MinimumWidth = 6;
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            // 
            // colAssignment
            // 
            colAssignment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAssignment.HeaderText = "Activity";
            colAssignment.MinimumWidth = 6;
            colAssignment.Name = "colAssignment";
            colAssignment.ReadOnly = true;
            // 
            // colScore
            // 
            colScore.HeaderText = "Score (Obtained/Total)";
            colScore.MinimumWidth = 6;
            colScore.Name = "colScore";
            colScore.ReadOnly = true;
            colScore.Width = 200;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 120;
            // 
            // lblMyGrades
            // 
            lblMyGrades.AutoSize = true;
            lblMyGrades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMyGrades.Location = new Point(40, 30);
            lblMyGrades.Name = "lblMyGrades";
            lblMyGrades.Size = new Size(190, 46);
            lblMyGrades.TabIndex = 0;
            lblMyGrades.Text = "My Grades";
            // 
            // studentSidebar1
            // 
            studentSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            studentSidebar1.Location = new Point(0, 0);
            studentSidebar1.Name = "studentSidebar1";
            studentSidebar1.Size = new Size(300, 752);
            studentSidebar1.TabIndex = 4;
            // 
            // Student_My_Grades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(studentSidebar1);
            Controls.Add(panelMyGrades);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Student_My_Grades";
            Text = "Student Grades";
            panelMyGrades.ResumeLayout(false);
            panelMyGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyGrades).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMyGrades;
        private System.Windows.Forms.Label lblMyGrades;
        private System.Windows.Forms.DataGridView dataGridViewMyGrades;
        private System.Windows.Forms.ComboBox comboBoxCourseList;
        private System.Windows.Forms.Label lblCourseGrade;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colAssignment;
        private DataGridViewTextBoxColumn colScore;
        private DataGridViewTextBoxColumn colStatus;
        private StudentSidebar studentSidebar1;
    }
}