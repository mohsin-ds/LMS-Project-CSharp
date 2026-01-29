using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Student_AssignmentQuizzes : Form
    {
        private string userEmail;
        private int currentCourseID;
        private int userID;
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        private Color activeColor = Color.FromArgb(79, 70, 229);

        public Student_AssignmentQuizzes(string email, int courseId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            currentCourseID = courseId;

            if (panelAssignments != null)
            {
                panelAssignments.AutoScroll = true;
            }

            if (panelQuizzes != null)
            {
                panelQuizzes.AutoScroll = true;
            }

            LoadUserData();
            SetupSidebarEvents();
            LoadContent();

            if (studentSidebar1 != null)
            {
                studentSidebar1.SetActivePage("MyCourses");
            }
        }

        public Student_AssignmentQuizzes()
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

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = Convert.ToInt32(reader["UserID"]);
                            if (studentSidebar1 != null)
                            {
                                studentSidebar1.StudentName = reader["FullName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user: " + ex.Message);
            }
        }

        private void LoadContent()
        {
            if (panelAssignments == null || panelQuizzes == null)
            {
                return;
            }

            for (int i = panelAssignments.Controls.Count - 1; i >= 0; i--)
            {
                if (panelAssignments.Controls[i] is Panel)
                {
                    panelAssignments.Controls.RemoveAt(i);
                }
            }

            for (int i = panelQuizzes.Controls.Count - 1; i >= 0; i--)
            {
                if (panelQuizzes.Controls[i] is Panel)
                {
                    panelQuizzes.Controls.RemoveAt(i);
                }
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string queryCourseName = @"SELECT CourseName
                                               FROM Courses 
                                               WHERE CourseID = @CID";

                    MySqlCommand cmdCourse = new MySqlCommand(queryCourseName, con);
                    cmdCourse.Parameters.AddWithValue("@CID", currentCourseID);

                    string courseName = "";
                    using (MySqlDataReader r = cmdCourse.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            courseName = r["CourseName"].ToString();
                        }
                    }

                    if (lblAssignmentsQuizzes != null)
                    {
                        lblAssignmentsQuizzes.Text = courseName + " - Activities";
                    }

                    string queryAssignments = @"SELECT a.AssignmentID, a.Title, a.DueDate, a.MaxAttempts,
                                                      s.Status, s.Attempts
                                               FROM Assignments a
                                               LEFT JOIN Submissions s 
                                               ON a.AssignmentID = s.AssignmentID AND s.StudentID = @SID
                                               WHERE a.CourseID = @CID
                                               ORDER BY a.DueDate DESC";

                    MySqlCommand cmdAssignments = new MySqlCommand(queryAssignments, con);
                    cmdAssignments.Parameters.AddWithValue("@CID", currentCourseID);
                    cmdAssignments.Parameters.AddWithValue("@SID", userID);

                    int yAss = 10;
                    using (MySqlDataReader r = cmdAssignments.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string status = r["Status"] == DBNull.Value ? "Pending" : r["Status"].ToString();
                            int maxAttempts = Convert.ToInt32(r["MaxAttempts"]);
                            int attemptsUsed = r["Attempts"] == DBNull.Value ? 0 : Convert.ToInt32(r["Attempts"]);
                            CreateActivityCard(panelAssignments, Convert.ToInt32(r["AssignmentID"]), r["Title"].ToString(), Convert.ToDateTime(r["DueDate"]), status, maxAttempts, attemptsUsed, yAss, true);
                            yAss += 100;
                        }
                    }

                    string queryQuizzes = @"SELECT q.QuizID, q.Title, q.DurationMinutes, q.TotalAttempts, q.DueDate,
                                                 (SELECT COUNT(*) FROM QuizQuestions WHERE QuizID = q.QuizID) AS TotalQuestions,
                                                 (SELECT Attempts FROM QuizResults WHERE QuizID = q.QuizID AND StudentID = @SID) AS AttemptsUsed,
                                                 (SELECT Score FROM QuizResults WHERE QuizID = q.QuizID AND StudentID = @SID LIMIT 1) AS Score
                                          FROM Quizzes q
                                          WHERE q.CourseID = @CID
                                          ORDER BY q.DueDate DESC";

                    MySqlCommand cmdQuizzes = new MySqlCommand(queryQuizzes, con);
                    cmdQuizzes.Parameters.AddWithValue("@CID", currentCourseID);
                    cmdQuizzes.Parameters.AddWithValue("@SID", userID);

                    int yQuiz = 10;
                    using (MySqlDataReader r = cmdQuizzes.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string score = r["Score"] == DBNull.Value ? null : r["Score"].ToString();
                            int totalAttempts = Convert.ToInt32(r["TotalAttempts"]);
                            int attemptsUsed = r["AttemptsUsed"] == DBNull.Value ? 0 : Convert.ToInt32(r["AttemptsUsed"]);
                            int totalQuestions = Convert.ToInt32(r["TotalQuestions"]);
                            DateTime dueDate = Convert.ToDateTime(r["DueDate"]);
                            int duration = Convert.ToInt32(r["DurationMinutes"]);

                            CreateActivityCard(panelQuizzes, Convert.ToInt32(r["QuizID"]), r["Title"].ToString(), dueDate, score, totalAttempts, attemptsUsed, yQuiz, false, totalQuestions, duration);
                            yQuiz += 100;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading content: " + ex.Message);
            }
        }

        private void CreateActivityCard(Panel panel, int id, string title, DateTime due, object statusOrScore, int maxAttempts, int attemptsUsed, int y, bool isAssignment, int totalQuestions = 0, int duration = 0)
        {
            Panel card = new Panel
            {
                Size = new Size(panel.Width - 25, 90),
                Location = new Point(10, y),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Panel strip = new Panel
            {
                Size = new Size(5, 90),
                Dock = DockStyle.Left,
                BackColor = isAssignment ? activeColor : Color.FromArgb(16, 185, 129)
            };

            Label lblTitle = new Label { 
                Text = title, Font = new Font("Segoe UI", 11, FontStyle.Bold), AutoSize = true, Location = new Point(15, 10) 
            };

            Label lblDue = new Label { 
                Text = due.ToString("MMM dd, hh:mm tt"), Font = new Font("Segoe UI", 9), ForeColor = DateTime.Now > due ? Color.Red : Color.Gray, AutoSize = true, Location = new Point(15, 35) 
            };

            Label lblAttempts = new Label {
                Text = isAssignment ? $"Attempts: {attemptsUsed}/{maxAttempts}" : $"Attempts: {attemptsUsed}/{maxAttempts} | Duration: {duration} mins", Font = new Font("Segoe UI", 8), ForeColor = Color.DimGray, AutoSize = true, Location = new Point(15, 55) 
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDue);
            card.Controls.Add(lblAttempts);
            card.Controls.Add(strip);

            int buttonX = card.Width - 110;

            if (isAssignment)
            {
                if (DateTime.Now > due)
                {
                    Label lblClosed = new Label { Text = "Deadline Passed", ForeColor = Color.Red, Font = new Font("Segoe UI", 8, FontStyle.Bold), Location = new Point(buttonX - 20, 35), AutoSize = true };
                    card.Controls.Add(lblClosed);
                }
                else
                {
                    if (statusOrScore.ToString() == "Pending")
                    {
                        RoundedButton btn = CreateDynamicButton("Submit", activeColor, buttonX, 25);
                        btn.Click += (s, e) => NavigateToUpload(id);
                        card.Controls.Add(btn);
                    }
                    else
                    {
                        Label lblSubmitted = new Label { Text = "Submitted", ForeColor = Color.Green, Font = new Font("Segoe UI", 9, FontStyle.Bold), Location = new Point(buttonX + 10, 15), AutoSize = true };
                        card.Controls.Add(lblSubmitted);
                        if (attemptsUsed < maxAttempts)
                        {
                            RoundedButton btn = CreateDynamicButton("Resubmit", Color.Orange, buttonX, 40);
                            btn.Click += (s, e) => NavigateToUpload(id);
                            card.Controls.Add(btn);
                        }
                    }
                }
            }
            else
            {
                if (statusOrScore != null)
                {
                    Label lblScore = new Label { Text = $"Score: {statusOrScore}/{totalQuestions}", ForeColor = activeColor, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(buttonX - 25, 10), AutoSize = true };
                    card.Controls.Add(lblScore);
                }

                if (DateTime.Now > due)
                {
                    Label lblClosed = new Label { Text = "Quiz Closed", ForeColor = Color.Red, Font = new Font("Segoe UI", 9, FontStyle.Bold), Location = new Point(buttonX - 10, 35), AutoSize = true };
                    card.Controls.Add(lblClosed);
                }
                else
                {
                    if (attemptsUsed == 0)
                    {
                        RoundedButton btn = CreateDynamicButton("Start", activeColor, buttonX, 35);
                        btn.Click += (s, e) => NavigateToQuiz(id, title, duration);
                        card.Controls.Add(btn);
                    }
                    else if (attemptsUsed < maxAttempts)
                    {
                        RoundedButton btn = CreateDynamicButton("Retake", Color.Orange, buttonX, 35);
                        btn.Click += (s, e) => NavigateToQuiz(id, title, duration);
                        card.Controls.Add(btn);
                    }
                }
            }

            panel.Controls.Add(card);
        }

        private RoundedButton CreateDynamicButton(string text, Color bg, int x, int y)
        {
            return new RoundedButton
            {
                Text = text,
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(90, 35),
                Location = new Point(x, y),
                Cursor = Cursors.Hand,
                FlatAppearance = { BorderSize = 0 }
            };
        }

        private void NavigateToUpload(int assignmentID)
        {
            this.Hide();
            new Stuednt_UploadAssignment(userEmail, currentCourseID, assignmentID).ShowDialog();
            this.Close();
        }

        private void NavigateToQuiz(int quizID, string title, int duration)
        {
            this.Hide();
            new Student_StartQuiz(userEmail, currentCourseID, quizID, title, duration).ShowDialog();
            this.Close();
        }

        private void SetupSidebarEvents()
        {
            if (studentSidebar1 != null)
            {
                studentSidebar1.DashboardClicked += (s, e) => NavigateTo(new StudentDashboard(userEmail));
                studentSidebar1.MyCoursesClicked += (s, e) => NavigateTo(new Student_My_Courses(userEmail));
                studentSidebar1.MyGradesClicked += (s, e) => NavigateTo(new Student_My_Grades(userEmail));
                studentSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }
        }

        private void btnBacktoCourses_Click(object sender, EventArgs e)
        {
            NavigateTo(new Student_My_Courses(userEmail));
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

        private void NavigateTo(Form f)
        {
            if (f != null)
            {
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
