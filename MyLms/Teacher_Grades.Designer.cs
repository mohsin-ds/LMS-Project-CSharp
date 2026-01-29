namespace MyLms
{
    partial class Teacher_Grades
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelContent = new Panel();
            btnSaveGrades = new Button();
            dataGridViewGrades = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colStudent = new DataGridViewTextBoxColumn();
            colAssign = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colScore = new DataGridViewTextBoxColumn();
            colTotalScore = new DataGridViewTextBoxColumn();
            colFile = new DataGridViewButtonColumn();
            colType = new DataGridViewTextBoxColumn();
            comboCourses = new ComboBox();
            lblSelectCourse = new Label();
            lblHeader = new Label();
            teacherSidebar1 = new TeacherSidebar();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(btnSaveGrades);
            panelContent.Controls.Add(dataGridViewGrades);
            panelContent.Controls.Add(comboCourses);
            panelContent.Controls.Add(lblSelectCourse);
            panelContent.Controls.Add(lblHeader);
            panelContent.Dock = DockStyle.Right;
            panelContent.Location = new Point(300, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(982, 753);
            panelContent.TabIndex = 3;
            // 
            // btnSaveGrades
            // 
            btnSaveGrades.BackColor = Color.FromArgb(16, 185, 129);
            btnSaveGrades.FlatAppearance.BorderSize = 0;
            btnSaveGrades.FlatStyle = FlatStyle.Flat;
            btnSaveGrades.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveGrades.ForeColor = Color.White;
            btnSaveGrades.Location = new Point(820, 680);
            btnSaveGrades.Name = "btnSaveGrades";
            btnSaveGrades.Size = new Size(120, 40);
            btnSaveGrades.TabIndex = 4;
            btnSaveGrades.Text = "Save Grades";
            btnSaveGrades.UseVisualStyleBackColor = false;
            btnSaveGrades.Click += btnSaveGrades_Click;
            // 
            // dataGridViewGrades
            // 
            dataGridViewGrades.AllowUserToAddRows = false;
            dataGridViewGrades.BackgroundColor = Color.White;
            dataGridViewGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrades.Columns.AddRange(new DataGridViewColumn[] { colID, colStudent, colAssign, colDate, colStatus, colScore, colTotalScore, colFile, colType });
            dataGridViewGrades.Location = new Point(40, 140);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.RowHeadersVisible = false;
            dataGridViewGrades.RowHeadersWidth = 51;
            dataGridViewGrades.RowTemplate.Height = 35;
            dataGridViewGrades.Size = new Size(900, 520);
            dataGridViewGrades.TabIndex = 3;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Visible = false;
            colID.Width = 125;
            // 
            // colStudent
            // 
            colStudent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStudent.HeaderText = "Student Name";
            colStudent.MinimumWidth = 6;
            colStudent.Name = "colStudent";
            colStudent.ReadOnly = true;
            // 
            // colAssign
            // 
            colAssign.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAssign.HeaderText = "Activity";
            colAssign.MinimumWidth = 6;
            colAssign.Name = "colAssign";
            colAssign.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Submitted On";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // colScore
            // 
            colScore.HeaderText = "Score";
            colScore.MinimumWidth = 6;
            colScore.Name = "colScore";
            colScore.Width = 80;
            // 
            // colTotalScore
            // 
            colTotalScore.HeaderText = "Total Score";
            colTotalScore.MinimumWidth = 6;
            colTotalScore.Name = "colTotalScore";
            colTotalScore.Width = 125;
            // 
            // colFile
            // 
            colFile.HeaderText = "File";
            colFile.MinimumWidth = 6;
            colFile.Name = "colFile";
            colFile.Text = "View";
            colFile.UseColumnTextForButtonValue = true;
            colFile.Width = 125;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.Visible = false;
            colType.Width = 125;
            // 
            // comboCourses
            // 
            comboCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCourses.Font = new Font("Segoe UI", 10F);
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(640, 37);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(300, 31);
            comboCourses.TabIndex = 2;
            // 
            // lblSelectCourse
            // 
            lblSelectCourse.AutoSize = true;
            lblSelectCourse.Font = new Font("Segoe UI", 12F);
            lblSelectCourse.Location = new Point(489, 38);
            lblSelectCourse.Name = "lblSelectCourse";
            lblSelectCourse.Size = new Size(133, 28);
            lblSelectCourse.TabIndex = 1;
            lblSelectCourse.Text = "Select Course:";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.Location = new Point(40, 30);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(207, 46);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Grade Book";
            // 
            // teacherSidebar1
            // 
            teacherSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            teacherSidebar1.Location = new Point(0, 0);
            teacherSidebar1.Name = "teacherSidebar1";
            teacherSidebar1.Size = new Size(300, 752);
            teacherSidebar1.TabIndex = 4;
            // 
            // Teacher_Grades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(teacherSidebar1);
            Controls.Add(panelContent);
            Name = "Teacher_Grades";
            Text = "Teacher Grades";
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox comboCourses;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.Button btnSaveGrades;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colStudent;
        private DataGridViewTextBoxColumn colAssign;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colScore;
        private DataGridViewTextBoxColumn colTotalScore;
        private DataGridViewButtonColumn colFile;
        private DataGridViewTextBoxColumn colType;
        private TeacherSidebar teacherSidebar1;
    }
}