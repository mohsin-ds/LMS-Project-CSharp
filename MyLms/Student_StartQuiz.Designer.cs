namespace MyLms
{
    partial class Student_StartQuiz
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
            components = new System.ComponentModel.Container();
            panelStartQuiz = new Panel();
            lblQuestionStatement = new Label();
            btnPrevious = new RoundedButton();
            btnNext = new RoundedButton();
            rdOptionD = new RadioButton();
            rdOptionC = new RadioButton();
            rdOptionB = new RadioButton();
            rdOptionA = new RadioButton();
            lblQuestion = new Label();
            panelStartQuizHeader = new Panel();
            lblTimer = new Label();
            btnBackToAssignmentsQuizzesFromQuiz = new RoundedButton();
            lblQuizName = new Label();
            quizTimer = new System.Windows.Forms.Timer(components);
            studentSidebar1 = new StudentSidebar();
            panelStartQuiz.SuspendLayout();
            panelStartQuizHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelStartQuiz
            // 
            panelStartQuiz.BackColor = Color.White;
            panelStartQuiz.Controls.Add(lblQuestionStatement);
            panelStartQuiz.Controls.Add(btnPrevious);
            panelStartQuiz.Controls.Add(btnNext);
            panelStartQuiz.Controls.Add(rdOptionD);
            panelStartQuiz.Controls.Add(rdOptionC);
            panelStartQuiz.Controls.Add(rdOptionB);
            panelStartQuiz.Controls.Add(rdOptionA);
            panelStartQuiz.Controls.Add(lblQuestion);
            panelStartQuiz.Controls.Add(panelStartQuizHeader);
            panelStartQuiz.ForeColor = Color.FromArgb(156, 163, 175);
            panelStartQuiz.Location = new Point(301, 0);
            panelStartQuiz.Name = "panelStartQuiz";
            panelStartQuiz.Size = new Size(980, 752);
            panelStartQuiz.TabIndex = 19;
            // 
            // lblQuestionStatement
            // 
            lblQuestionStatement.AutoSize = true;
            lblQuestionStatement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuestionStatement.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuestionStatement.Location = new Point(101, 164);
            lblQuestionStatement.Name = "lblQuestionStatement";
            lblQuestionStatement.Size = new Size(246, 28);
            lblQuestionStatement.TabIndex = 42;
            lblQuestionStatement.Text = "Question will appear here";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(229, 231, 235);
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.Black;
            btnPrevious.Location = new Point(619, 557);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(166, 47);
            btnPrevious.TabIndex = 41;
            btnPrevious.Text = "<- Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.MidnightBlue;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(814, 557);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(109, 47);
            btnNext.TabIndex = 40;
            btnNext.Text = "Next ->";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // rdOptionD
            // 
            rdOptionD.AutoSize = true;
            rdOptionD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdOptionD.ForeColor = Color.FromArgb(68, 68, 68);
            rdOptionD.Location = new Point(45, 472);
            rdOptionD.Name = "rdOptionD";
            rdOptionD.Size = new Size(116, 32);
            rdOptionD.TabIndex = 39;
            rdOptionD.TabStop = true;
            rdOptionD.Text = "Option D";
            rdOptionD.UseVisualStyleBackColor = true;
            // 
            // rdOptionC
            // 
            rdOptionC.AutoSize = true;
            rdOptionC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdOptionC.ForeColor = Color.FromArgb(68, 68, 68);
            rdOptionC.Location = new Point(45, 415);
            rdOptionC.Name = "rdOptionC";
            rdOptionC.Size = new Size(114, 32);
            rdOptionC.TabIndex = 38;
            rdOptionC.TabStop = true;
            rdOptionC.Text = "Option C";
            rdOptionC.UseVisualStyleBackColor = true;
            // 
            // rdOptionB
            // 
            rdOptionB.AutoSize = true;
            rdOptionB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdOptionB.ForeColor = Color.FromArgb(68, 68, 68);
            rdOptionB.Location = new Point(44, 353);
            rdOptionB.Name = "rdOptionB";
            rdOptionB.Size = new Size(114, 32);
            rdOptionB.TabIndex = 37;
            rdOptionB.TabStop = true;
            rdOptionB.Text = "Option B";
            rdOptionB.UseVisualStyleBackColor = true;
            // 
            // rdOptionA
            // 
            rdOptionA.AutoSize = true;
            rdOptionA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdOptionA.ForeColor = Color.FromArgb(68, 68, 68);
            rdOptionA.Location = new Point(46, 291);
            rdOptionA.Name = "rdOptionA";
            rdOptionA.Size = new Size(115, 32);
            rdOptionA.TabIndex = 36;
            rdOptionA.TabStop = true;
            rdOptionA.Text = "Option A";
            rdOptionA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuestion.Location = new Point(46, 127);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(194, 28);
            lblQuestion.TabIndex = 34;
            lblQuestion.Text = "Question Statement";
            // 
            // panelStartQuizHeader
            // 
            panelStartQuizHeader.BackColor = Color.FromArgb(249, 250, 251);
            panelStartQuizHeader.Controls.Add(lblTimer);
            panelStartQuizHeader.Controls.Add(btnBackToAssignmentsQuizzesFromQuiz);
            panelStartQuizHeader.Controls.Add(lblQuizName);
            panelStartQuizHeader.Location = new Point(0, 0);
            panelStartQuizHeader.Name = "panelStartQuizHeader";
            panelStartQuizHeader.Size = new Size(980, 97);
            panelStartQuizHeader.TabIndex = 5;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.Red;
            lblTimer.Location = new Point(383, 28);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(89, 38);
            lblTimer.TabIndex = 10;
            lblTimer.Text = "10:00";
            // 
            // btnBackToAssignmentsQuizzesFromQuiz
            // 
            btnBackToAssignmentsQuizzesFromQuiz.BackColor = Color.FromArgb(229, 231, 235);
            btnBackToAssignmentsQuizzesFromQuiz.FlatAppearance.BorderSize = 0;
            btnBackToAssignmentsQuizzesFromQuiz.FlatStyle = FlatStyle.Flat;
            btnBackToAssignmentsQuizzesFromQuiz.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToAssignmentsQuizzesFromQuiz.ForeColor = Color.Black;
            btnBackToAssignmentsQuizzesFromQuiz.Location = new Point(627, 22);
            btnBackToAssignmentsQuizzesFromQuiz.Name = "btnBackToAssignmentsQuizzesFromQuiz";
            btnBackToAssignmentsQuizzesFromQuiz.Size = new Size(296, 56);
            btnBackToAssignmentsQuizzesFromQuiz.TabIndex = 9;
            btnBackToAssignmentsQuizzesFromQuiz.Text = "Back to Assignments && Quizzes";
            btnBackToAssignmentsQuizzesFromQuiz.UseVisualStyleBackColor = false;
            btnBackToAssignmentsQuizzesFromQuiz.Click += btnBackToAssignmentsQuizzesFromQuiz_Click;
            // 
            // lblQuizName
            // 
            lblQuizName.AutoSize = true;
            lblQuizName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblQuizName.ForeColor = Color.FromArgb(17, 24, 39);
            lblQuizName.Location = new Point(45, 29);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(157, 37);
            lblQuizName.TabIndex = 3;
            lblQuizName.Text = "Quiz Name";
            // 
            // quizTimer
            // 
            quizTimer.Enabled = true;
            quizTimer.Interval = 1000;
            // 
            // studentSidebar1
            // 
            studentSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            studentSidebar1.Location = new Point(0, 0);
            studentSidebar1.Name = "studentSidebar1";
            studentSidebar1.Size = new Size(300, 752);
            studentSidebar1.TabIndex = 20;
            // 
            // Student_StartQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(studentSidebar1);
            Controls.Add(panelStartQuiz);
            Name = "Student_StartQuiz";
            Text = "StartQuiz";
            panelStartQuiz.ResumeLayout(false);
            panelStartQuiz.PerformLayout();
            panelStartQuizHeader.ResumeLayout(false);
            panelStartQuizHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelStartQuiz;
        private System.Windows.Forms.Timer quizTimer;
        private Panel panelStartQuizHeader;
        private Label lblTimer;
        private RoundedButton btnBackToAssignmentsQuizzesFromQuiz;
        private Label lblQuizName;
        private Label lblQuestion;
        private RadioButton rdOptionA;
        private RadioButton rdOptionD;
        private RadioButton rdOptionC;
        private RadioButton rdOptionB;
        private RoundedButton btnNext;
        private RoundedButton btnPrevious;
        private Label lblQuestionStatement;
        private StudentSidebar studentSidebar1;
    }
}