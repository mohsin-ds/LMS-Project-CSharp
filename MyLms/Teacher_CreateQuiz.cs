using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Teacher_CreateQuiz : Form
    {
        private string userEmail;
        private int courseID;
        private int userID;
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        private List<QuestionItem> questions = new List<QuestionItem>();

        private Color activeColor = Color.FromArgb(79, 70, 229);

        private class QuestionItem
        {
            public string Statement { get; set; }
            public string OptA { get; set; }
            public string OptB { get; set; }
            public string OptC { get; set; }
            public string OptD { get; set; }
            public string Correct { get; set; }

            public QuestionItem(string statement, string optA, string optB, string optC, string optD, string correct)
            {
                Statement = statement;
                OptA = optA;
                OptB = optB;
                OptC = optC;
                OptD = optD;
                Correct = correct;
            }
        }

        public Teacher_CreateQuiz(string email, int cID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            courseID = cID;

            LoadUserData();
            SetupSidebarEvents();

            if (teacherSidebar1 != null)
            {
                teacherSidebar1.SetActivePage("MyCourses");
            }
        }

        public Teacher_CreateQuiz()
        {
            InitializeComponent();
        }

        private void LoadUserData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT UserID, FullName
                                     FROM Users
                                     WHERE Email = @E";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@E", userEmail);
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            userID = Convert.ToInt32(r["UserID"]);
                            if (teacherSidebar1 != null)
                            {
                                teacherSidebar1.TeacherName = r["FullName"].ToString();
                            }
                        }
                    }

                    string courseQuery = @"SELECT CourseName
                                           FROM Courses
                                           WHERE CourseID = @CID";

                    using (MySqlCommand cmdCourse = new MySqlCommand(courseQuery, con))
                    {
                        cmdCourse.Parameters.AddWithValue("@CID", courseID);

                        using (MySqlDataReader reader = cmdCourse.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string courseName = reader["CourseName"].ToString();
                                if (lblQuizTitle != null)
                                {
                                    lblQuizTitle.Text = "New Quiz: " + courseName;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestionStatement.Text) ||
                string.IsNullOrWhiteSpace(txtQuestionOptA.Text) ||
                string.IsNullOrWhiteSpace(txtQuestionOptB.Text) ||
                string.IsNullOrWhiteSpace(txtQuestionOptC.Text) ||
                string.IsNullOrWhiteSpace(txtQuestionOptD.Text))
            {
                MessageBox.Show("Please fill in the question and all four options.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxCorrectOption.SelectedItem == null)
            {
                MessageBox.Show("Please select which option (A, B, C, or D) is the correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            questions.Add(new QuestionItem(txtQuestionStatement.Text.Trim(), txtQuestionOptA.Text.Trim(), txtQuestionOptB.Text.Trim(), txtQuestionOptC.Text.Trim(), txtQuestionOptD.Text.Trim(), comboBoxCorrectOption.SelectedItem.ToString()));

            MessageBox.Show($"Question added! Total questions in quiz: {questions.Count}", "Question Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearQuestionFields();
        }

        private void ClearQuestionFields()
        {
            txtQuestionStatement.Clear();
            txtQuestionOptA.Clear();
            txtQuestionOptB.Clear();
            txtQuestionOptC.Clear();
            txtQuestionOptD.Clear();
            comboBoxCorrectOption.SelectedIndex = -1;
        }

        private void btnClearQuestion_Click(object sender, EventArgs e)
        {
            ClearQuestionFields();
        }

        private void btnPublishQuiz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuizTitle.Text))
            {
                MessageBox.Show("Please provide a title for the quiz.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (questions.Count == 0)
            {
                MessageBox.Show("A quiz must have at least one question to be published.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime due = QuizduedatePicker.Value.Date + QuizduetimePicker.Value.TimeOfDay;
            if (due < DateTime.Now)
            {
                MessageBox.Show("The deadline cannot be set in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericQuizDuration.Value <= 0)
            {
                MessageBox.Show("Duration must be greater than 0 minutes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericQuizAttempts.Value <= 0)
            {
                MessageBox.Show("Total attempts must be at least 1.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string qQuiz = "INSERT INTO Quizzes (CourseID, Title, DurationMinutes, DueDate, TotalAttempts) VALUES (@C, @T, @Dur, @Due, @Att);";
                    using (MySqlCommand cmd = new MySqlCommand(qQuiz, con))
                    {
                        cmd.Parameters.AddWithValue("@C", courseID);
                        cmd.Parameters.AddWithValue("@T", txtQuizTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@Dur", numericQuizDuration.Value);
                        cmd.Parameters.AddWithValue("@Due", due);
                        cmd.Parameters.AddWithValue("@Att", numericQuizAttempts.Value);
                        cmd.ExecuteNonQuery();
                    }

                    int newQuizID = 0;
                    string getIDQuery = "SELECT LAST_INSERT_ID() AS QuizID;";
                    using (MySqlCommand cmdID = new MySqlCommand(getIDQuery, con))
                    using (MySqlDataReader reader = cmdID.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            newQuizID = Convert.ToInt32(reader["QuizID"]);
                        }
                    }

                    string qQuestion = "INSERT INTO QuizQuestions (QuizID, Statement, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES (@QID, @S, @A, @B, @C, @D, @Cor);";
                    foreach (var q in questions)
                    {
                        using (MySqlCommand cmdQ = new MySqlCommand(qQuestion, con))
                        {
                            cmdQ.Parameters.AddWithValue("@QID", newQuizID);
                            cmdQ.Parameters.AddWithValue("@S", q.Statement);
                            cmdQ.Parameters.AddWithValue("@A", q.OptA);
                            cmdQ.Parameters.AddWithValue("@B", q.OptB);
                            cmdQ.Parameters.AddWithValue("@C", q.OptC);
                            cmdQ.Parameters.AddWithValue("@D", q.OptD);
                            cmdQ.Parameters.AddWithValue("@Cor", q.Correct);
                            cmdQ.ExecuteNonQuery();
                        }
                    }

                    string logQ = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@U, @AT);";
                    using (MySqlCommand cmdLog = new MySqlCommand(logQ, con))
                    {
                        cmdLog.Parameters.AddWithValue("@U", userID);
                        cmdLog.Parameters.AddWithValue("@AT", $"Published Quiz: {txtQuizTitle.Text.Trim()}");
                        cmdLog.ExecuteNonQuery();
                    }

                    MessageBox.Show("Quiz has been successfully published to the course!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NavigateBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupSidebarEvents()
        {
            if (teacherSidebar1 != null)
            {
                teacherSidebar1.DashboardClicked += (s, e) => NavigateTo(new TeacherDashboard(userEmail));
                teacherSidebar1.MyCoursesClicked += (s, e) => NavigateTo(new Teacher_My_Courses(userEmail));
                teacherSidebar1.GradesClicked += (s, e) => NavigateTo(new Teacher_Grades(userEmail));
                teacherSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }
        }

        private void HandleLogout()
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new SignupLoginForm().ShowDialog();
                this.Close();
            }
        }
        private void btnBackToAssignmentsQuizzesFromQuiz_Click(object sender, EventArgs e)
        {
            NavigateBack();
        }

        private void NavigateBack()
        {
            this.Hide();
            new Teacher_AssignmentsQuizzes(userEmail, courseID).ShowDialog();
            this.Close();
        }

        private void NavigateTo(Form nextForm)
        {
            if (nextForm != null)
            {
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
        }
    }
}