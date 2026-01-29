namespace MyLms
{
    partial class Teacher_CreateQuiz
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
            panelCreateQuiz = new Panel();
            btnAddQuestion = new RoundedButton();
            btnClearQuestion = new RoundedButton();
            lblCorrectOption = new Label();
            comboBoxCorrectOption = new ComboBox();
            lblQuestionOptD = new Label();
            txtQuestionOptD = new TextBox();
            lblQuestionOptC = new Label();
            txtQuestionOptC = new TextBox();
            lblQuestionOptB = new Label();
            txtQuestionOptB = new TextBox();
            lblQuestionOptA = new Label();
            txtQuestionOptA = new TextBox();
            txtQuestionStatement = new RichTextBox();
            lblQuestionStatement = new Label();
            QuizduetimePicker = new DateTimePicker();
            lblQuizDueTime = new Label();
            numericQuizDuration = new NumericUpDown();
            lblQuizAttempts = new Label();
            numericQuizAttempts = new NumericUpDown();
            btnPublishQuiz = new RoundedButton();
            QuizduedatePicker = new DateTimePicker();
            lblQuizDuration = new Label();
            lblQuizDueDate = new Label();
            txtQuizTitle = new TextBox();
            lblQuizTitle = new Label();
            btnBackToAssignmentsQuizzesFromQuiz = new RoundedButton();
            lblCreateQuiz = new Label();
            teacherSidebar1 = new TeacherSidebar();
            panelCreateQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuizDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuizAttempts).BeginInit();
            SuspendLayout();
            // 
            // panelCreateQuiz
            // 
            panelCreateQuiz.Controls.Add(btnAddQuestion);
            panelCreateQuiz.Controls.Add(btnClearQuestion);
            panelCreateQuiz.Controls.Add(lblCorrectOption);
            panelCreateQuiz.Controls.Add(comboBoxCorrectOption);
            panelCreateQuiz.Controls.Add(lblQuestionOptD);
            panelCreateQuiz.Controls.Add(txtQuestionOptD);
            panelCreateQuiz.Controls.Add(lblQuestionOptC);
            panelCreateQuiz.Controls.Add(txtQuestionOptC);
            panelCreateQuiz.Controls.Add(lblQuestionOptB);
            panelCreateQuiz.Controls.Add(txtQuestionOptB);
            panelCreateQuiz.Controls.Add(lblQuestionOptA);
            panelCreateQuiz.Controls.Add(txtQuestionOptA);
            panelCreateQuiz.Controls.Add(txtQuestionStatement);
            panelCreateQuiz.Controls.Add(lblQuestionStatement);
            panelCreateQuiz.Controls.Add(QuizduetimePicker);
            panelCreateQuiz.Controls.Add(lblQuizDueTime);
            panelCreateQuiz.Controls.Add(numericQuizDuration);
            panelCreateQuiz.Controls.Add(lblQuizAttempts);
            panelCreateQuiz.Controls.Add(numericQuizAttempts);
            panelCreateQuiz.Controls.Add(btnPublishQuiz);
            panelCreateQuiz.Controls.Add(QuizduedatePicker);
            panelCreateQuiz.Controls.Add(lblQuizDuration);
            panelCreateQuiz.Controls.Add(lblQuizDueDate);
            panelCreateQuiz.Controls.Add(txtQuizTitle);
            panelCreateQuiz.Controls.Add(lblQuizTitle);
            panelCreateQuiz.Controls.Add(btnBackToAssignmentsQuizzesFromQuiz);
            panelCreateQuiz.Controls.Add(lblCreateQuiz);
            panelCreateQuiz.Location = new Point(301, 0);
            panelCreateQuiz.Name = "panelCreateQuiz";
            panelCreateQuiz.Size = new Size(980, 752);
            panelCreateQuiz.TabIndex = 25;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.MidnightBlue;
            btnAddQuestion.Cursor = Cursors.Hand;
            btnAddQuestion.FlatAppearance.BorderSize = 0;
            btnAddQuestion.FlatStyle = FlatStyle.Flat;
            btnAddQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Location = new Point(770, 605);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(156, 47);
            btnAddQuestion.TabIndex = 37;
            btnAddQuestion.Text = "+ Question";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnClearQuestion
            // 
            btnClearQuestion.BackColor = Color.FromArgb(229, 231, 235);
            btnClearQuestion.Cursor = Cursors.Hand;
            btnClearQuestion.FlatAppearance.BorderSize = 0;
            btnClearQuestion.FlatStyle = FlatStyle.Flat;
            btnClearQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearQuestion.ForeColor = Color.Black;
            btnClearQuestion.Location = new Point(665, 605);
            btnClearQuestion.Name = "btnClearQuestion";
            btnClearQuestion.Size = new Size(79, 47);
            btnClearQuestion.TabIndex = 36;
            btnClearQuestion.Text = "Clear";
            btnClearQuestion.UseVisualStyleBackColor = false;
            btnClearQuestion.Click += btnClearQuestion_Click;
            // 
            // lblCorrectOption
            // 
            lblCorrectOption.AutoSize = true;
            lblCorrectOption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCorrectOption.ForeColor = Color.FromArgb(68, 68, 68);
            lblCorrectOption.Location = new Point(49, 614);
            lblCorrectOption.Name = "lblCorrectOption";
            lblCorrectOption.Size = new Size(82, 28);
            lblCorrectOption.TabIndex = 35;
            lblCorrectOption.Text = "Correct:";
            // 
            // comboBoxCorrectOption
            // 
            comboBoxCorrectOption.BackColor = Color.White;
            comboBoxCorrectOption.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCorrectOption.Font = new Font("Segoe UI", 12F);
            comboBoxCorrectOption.FormattingEnabled = true;
            comboBoxCorrectOption.Items.AddRange(new object[] { "Option A", "Option B", "Option C", "Option D" });
            comboBoxCorrectOption.Location = new Point(137, 611);
            comboBoxCorrectOption.Name = "comboBoxCorrectOption";
            comboBoxCorrectOption.Size = new Size(311, 36);
            comboBoxCorrectOption.TabIndex = 34;
            // 
            // lblQuestionOptD
            // 
            lblQuestionOptD.AutoSize = true;
            lblQuestionOptD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuestionOptD.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuestionOptD.Location = new Point(49, 553);
            lblQuestionOptD.Name = "lblQuestionOptD";
            lblQuestionOptD.Size = new Size(31, 28);
            lblQuestionOptD.TabIndex = 33;
            lblQuestionOptD.Text = "D:";
            // 
            // txtQuestionOptD
            // 
            txtQuestionOptD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionOptD.Location = new Point(85, 550);
            txtQuestionOptD.Multiline = true;
            txtQuestionOptD.Name = "txtQuestionOptD";
            txtQuestionOptD.PlaceholderText = "e.g. Very Bad";
            txtQuestionOptD.Size = new Size(841, 34);
            txtQuestionOptD.TabIndex = 32;
            // 
            // lblQuestionOptC
            // 
            lblQuestionOptC.AutoSize = true;
            lblQuestionOptC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuestionOptC.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuestionOptC.Location = new Point(49, 509);
            lblQuestionOptC.Name = "lblQuestionOptC";
            lblQuestionOptC.Size = new Size(29, 28);
            lblQuestionOptC.TabIndex = 31;
            lblQuestionOptC.Text = "C:";
            // 
            // txtQuestionOptC
            // 
            txtQuestionOptC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionOptC.Location = new Point(85, 506);
            txtQuestionOptC.Multiline = true;
            txtQuestionOptC.Name = "txtQuestionOptC";
            txtQuestionOptC.PlaceholderText = "e.g. Bad";
            txtQuestionOptC.Size = new Size(841, 34);
            txtQuestionOptC.TabIndex = 30;
            // 
            // lblQuestionOptB
            // 
            lblQuestionOptB.AutoSize = true;
            lblQuestionOptB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuestionOptB.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuestionOptB.Location = new Point(49, 467);
            lblQuestionOptB.Name = "lblQuestionOptB";
            lblQuestionOptB.Size = new Size(29, 28);
            lblQuestionOptB.TabIndex = 29;
            lblQuestionOptB.Text = "B:";
            // 
            // txtQuestionOptB
            // 
            txtQuestionOptB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionOptB.Location = new Point(85, 464);
            txtQuestionOptB.Multiline = true;
            txtQuestionOptB.Name = "txtQuestionOptB";
            txtQuestionOptB.PlaceholderText = "e.g. Good";
            txtQuestionOptB.Size = new Size(841, 34);
            txtQuestionOptB.TabIndex = 28;
            // 
            // lblQuestionOptA
            // 
            lblQuestionOptA.AutoSize = true;
            lblQuestionOptA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuestionOptA.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuestionOptA.Location = new Point(49, 424);
            lblQuestionOptA.Name = "lblQuestionOptA";
            lblQuestionOptA.Size = new Size(30, 28);
            lblQuestionOptA.TabIndex = 27;
            lblQuestionOptA.Text = "A:";
            // 
            // txtQuestionOptA
            // 
            txtQuestionOptA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestionOptA.Location = new Point(85, 421);
            txtQuestionOptA.Multiline = true;
            txtQuestionOptA.Name = "txtQuestionOptA";
            txtQuestionOptA.PlaceholderText = "e.g. Very Good";
            txtQuestionOptA.Size = new Size(841, 34);
            txtQuestionOptA.TabIndex = 26;
            // 
            // txtQuestionStatement
            // 
            txtQuestionStatement.Font = new Font("Segoe UI", 12F);
            txtQuestionStatement.Location = new Point(71, 309);
            txtQuestionStatement.Name = "txtQuestionStatement";
            txtQuestionStatement.Size = new Size(855, 93);
            txtQuestionStatement.TabIndex = 25;
            txtQuestionStatement.Text = "";
            // 
            // lblQuestionStatement
            // 
            lblQuestionStatement.AutoSize = true;
            lblQuestionStatement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuestionStatement.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuestionStatement.Location = new Point(49, 267);
            lblQuestionStatement.Name = "lblQuestionStatement";
            lblQuestionStatement.Size = new Size(194, 28);
            lblQuestionStatement.TabIndex = 24;
            lblQuestionStatement.Text = "Question Statement";
            // 
            // QuizduetimePicker
            // 
            QuizduetimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuizduetimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuizduetimePicker.Format = DateTimePickerFormat.Time;
            QuizduetimePicker.Location = new Point(275, 220);
            QuizduetimePicker.Name = "QuizduetimePicker";
            QuizduetimePicker.Size = new Size(143, 34);
            QuizduetimePicker.TabIndex = 23;
            // 
            // lblQuizDueTime
            // 
            lblQuizDueTime.AutoSize = true;
            lblQuizDueTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuizDueTime.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuizDueTime.Location = new Point(250, 180);
            lblQuizDueTime.Name = "lblQuizDueTime";
            lblQuizDueTime.Size = new Size(100, 28);
            lblQuizDueTime.TabIndex = 22;
            lblQuizDueTime.Text = "Due Time";
            // 
            // numericQuizDuration
            // 
            numericQuizDuration.Font = new Font("Segoe UI", 12F);
            numericQuizDuration.Location = new Point(524, 220);
            numericQuizDuration.Name = "numericQuizDuration";
            numericQuizDuration.Size = new Size(143, 34);
            numericQuizDuration.TabIndex = 21;
            // 
            // lblQuizAttempts
            // 
            lblQuizAttempts.AutoSize = true;
            lblQuizAttempts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuizAttempts.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuizAttempts.Location = new Point(757, 180);
            lblQuizAttempts.Name = "lblQuizAttempts";
            lblQuizAttempts.Size = new Size(96, 28);
            lblQuizAttempts.TabIndex = 20;
            lblQuizAttempts.Text = "Attempts";
            // 
            // numericQuizAttempts
            // 
            numericQuizAttempts.Font = new Font("Segoe UI", 12F);
            numericQuizAttempts.Location = new Point(783, 220);
            numericQuizAttempts.Name = "numericQuizAttempts";
            numericQuizAttempts.Size = new Size(143, 34);
            numericQuizAttempts.TabIndex = 19;
            numericQuizAttempts.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPublishQuiz
            // 
            btnPublishQuiz.BackColor = Color.FromArgb(79, 70, 229);
            btnPublishQuiz.Cursor = Cursors.Hand;
            btnPublishQuiz.FlatAppearance.BorderSize = 0;
            btnPublishQuiz.FlatStyle = FlatStyle.Flat;
            btnPublishQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPublishQuiz.ForeColor = Color.White;
            btnPublishQuiz.Location = new Point(386, 679);
            btnPublishQuiz.Name = "btnPublishQuiz";
            btnPublishQuiz.Size = new Size(225, 47);
            btnPublishQuiz.TabIndex = 18;
            btnPublishQuiz.Text = "Publish Quiz";
            btnPublishQuiz.UseVisualStyleBackColor = false;
            btnPublishQuiz.Click += btnPublishQuiz_Click;
            // 
            // QuizduedatePicker
            // 
            QuizduedatePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuizduedatePicker.CustomFormat = "";
            QuizduedatePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuizduedatePicker.Format = DateTimePickerFormat.Short;
            QuizduedatePicker.Location = new Point(71, 220);
            QuizduedatePicker.Name = "QuizduedatePicker";
            QuizduedatePicker.Size = new Size(143, 34);
            QuizduedatePicker.TabIndex = 16;
            // 
            // lblQuizDuration
            // 
            lblQuizDuration.AutoSize = true;
            lblQuizDuration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuizDuration.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuizDuration.Location = new Point(496, 180);
            lblQuizDuration.Name = "lblQuizDuration";
            lblQuizDuration.Size = new Size(156, 28);
            lblQuizDuration.TabIndex = 15;
            lblQuizDuration.Text = "Duration (MIN) ";
            // 
            // lblQuizDueDate
            // 
            lblQuizDueDate.AutoSize = true;
            lblQuizDueDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuizDueDate.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuizDueDate.Location = new Point(49, 180);
            lblQuizDueDate.Name = "lblQuizDueDate";
            lblQuizDueDate.Size = new Size(97, 28);
            lblQuizDueDate.TabIndex = 14;
            lblQuizDueDate.Text = "Due Date";
            // 
            // txtQuizTitle
            // 
            txtQuizTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuizTitle.Location = new Point(71, 129);
            txtQuizTitle.Name = "txtQuizTitle";
            txtQuizTitle.PlaceholderText = "e.g. Quiz#01";
            txtQuizTitle.Size = new Size(855, 34);
            txtQuizTitle.TabIndex = 13;
            // 
            // lblQuizTitle
            // 
            lblQuizTitle.AutoSize = true;
            lblQuizTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblQuizTitle.ForeColor = Color.FromArgb(68, 68, 68);
            lblQuizTitle.Location = new Point(49, 82);
            lblQuizTitle.Name = "lblQuizTitle";
            lblQuizTitle.Size = new Size(98, 28);
            lblQuizTitle.TabIndex = 12;
            lblQuizTitle.Text = "Quiz Title";
            // 
            // btnBackToAssignmentsQuizzesFromQuiz
            // 
            btnBackToAssignmentsQuizzesFromQuiz.BackColor = Color.FromArgb(229, 231, 235);
            btnBackToAssignmentsQuizzesFromQuiz.FlatAppearance.BorderSize = 0;
            btnBackToAssignmentsQuizzesFromQuiz.FlatStyle = FlatStyle.Flat;
            btnBackToAssignmentsQuizzesFromQuiz.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToAssignmentsQuizzesFromQuiz.ForeColor = Color.Black;
            btnBackToAssignmentsQuizzesFromQuiz.Location = new Point(630, 24);
            btnBackToAssignmentsQuizzesFromQuiz.Name = "btnBackToAssignmentsQuizzesFromQuiz";
            btnBackToAssignmentsQuizzesFromQuiz.Size = new Size(296, 56);
            btnBackToAssignmentsQuizzesFromQuiz.TabIndex = 9;
            btnBackToAssignmentsQuizzesFromQuiz.Text = "Back to Assignments && Quizzes";
            btnBackToAssignmentsQuizzesFromQuiz.UseVisualStyleBackColor = false;
            btnBackToAssignmentsQuizzesFromQuiz.Click += btnBackToAssignmentsQuizzesFromQuiz_Click;
            // 
            // lblCreateQuiz
            // 
            lblCreateQuiz.AutoSize = true;
            lblCreateQuiz.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCreateQuiz.ForeColor = Color.FromArgb(17, 24, 39);
            lblCreateQuiz.Location = new Point(49, 33);
            lblCreateQuiz.Name = "lblCreateQuiz";
            lblCreateQuiz.Size = new Size(165, 37);
            lblCreateQuiz.TabIndex = 4;
            lblCreateQuiz.Text = "Create Quiz";
            // 
            // teacherSidebar1
            // 
            teacherSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            teacherSidebar1.Location = new Point(0, 0);
            teacherSidebar1.Name = "teacherSidebar1";
            teacherSidebar1.Size = new Size(300, 752);
            teacherSidebar1.TabIndex = 26;
            // 
            // Teacher_CreateQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(teacherSidebar1);
            Controls.Add(panelCreateQuiz);
            Name = "Teacher_CreateQuiz";
            Text = "Teacher_CreateQuiz";
            panelCreateQuiz.ResumeLayout(false);
            panelCreateQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuizDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuizAttempts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCreateQuiz;
        private RoundedButton btnAddQuestion;
        private RoundedButton btnClearQuestion;
        private Label lblCorrectOption;
        private ComboBox comboBoxCorrectOption;
        private Label lblQuestionOptD;
        private TextBox txtQuestionOptD;
        private Label lblQuestionOptC;
        private TextBox txtQuestionOptC;
        private Label lblQuestionOptB;
        private TextBox txtQuestionOptB;
        private Label lblQuestionOptA;
        private TextBox txtQuestionOptA;
        private RichTextBox txtQuestionStatement;
        private Label lblQuestionStatement;
        private DateTimePicker QuizduetimePicker;
        private Label lblQuizDueTime;
        private NumericUpDown numericQuizDuration;
        private Label lblQuizAttempts;
        private NumericUpDown numericQuizAttempts;
        private RoundedButton btnPublishQuiz;
        private DateTimePicker QuizduedatePicker;
        private Label lblQuizDuration;
        private Label lblQuizDueDate;
        private TextBox txtQuizTitle;
        private Label lblQuizTitle;
        private RoundedButton btnBackToAssignmentsQuizzesFromQuiz;
        private Label lblCreateQuiz;
        private TeacherSidebar teacherSidebar1;
    }
}