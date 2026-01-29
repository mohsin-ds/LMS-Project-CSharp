using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Teacher_AssignmentsQuizzes : Form
    {
        private string userEmail;
        private int currentCourseID;
        private int userID;

        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        private Color activeColor = Color.FromArgb(79, 70, 229);
        private Color deleteColor = Color.FromArgb(220, 38, 38);

        public Teacher_AssignmentsQuizzes(string email, int courseId)
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
            LoadAssignments();
            LoadQuizzes();

            if (teacherSidebar1 != null)
            {
                teacherSidebar1.SetActivePage("MyCourses");
            }
        }

        public Teacher_AssignmentsQuizzes()
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

                    string userQuery = @"SELECT UserID, FullName 
                                         FROM Users 
                                         WHERE Email = @E";

                    using (MySqlCommand cmd = new MySqlCommand(userQuery, con))
                    {
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
                    }

                    string courseQuery = @"SELECT CourseName 
                                           FROM Courses 
                                           WHERE CourseID = @CID";

                    using (MySqlCommand cmd = new MySqlCommand(courseQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@CID", currentCourseID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["CourseName"].ToString();

                                if (lblAssignmentsQuizzes != null)
                                {
                                    lblAssignmentsQuizzes.Text = name + " - Activities";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Error: " + ex.Message);
            }
        }

        private void LoadAssignments()
        {
            if (panelAssignments == null)
            {
                return;
            }

            panelAssignments.Controls.Clear();
            int y = 10;

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string q = @"SELECT AssignmentID, Title, DueDate, MaxAttempts
                                 FROM Assignments
                                 WHERE CourseID = @CID
                                 ORDER BY DueDate DESC";

                    using (MySqlCommand cmd = new MySqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@CID", currentCourseID);

                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                int id = Convert.ToInt32(r["AssignmentID"]);
                                string title = r["Title"].ToString();
                                DateTime due = Convert.ToDateTime(r["DueDate"]);
                                int attempts = r["MaxAttempts"] != DBNull.Value ? Convert.ToInt32(r["MaxAttempts"]) : 1;

                                string d1 = due.ToString("MMM dd, yyyy - hh:mm tt");
                                string d2 = attempts + " Attempt(s) allowed";

                                CreateCard(panelAssignments, id, title, d1, d2, y, true);
                                y += 100;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        private void LoadQuizzes()
        {
            if (panelQuizzes == null) return;

            panelQuizzes.Controls.Clear();
            int y = 10;

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string q = @"SELECT QuizID, Title, DurationMinutes, TotalAttempts
                                 FROM Quizzes
                                 WHERE CourseID = @CID";

                    using (MySqlCommand cmd = new MySqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@CID", currentCourseID);

                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                int id = Convert.ToInt32(r["QuizID"]);
                                string title = r["Title"].ToString();
                                int duration = Convert.ToInt32(r["DurationMinutes"]);
                                int attempts = r["TotalAttempts"] != DBNull.Value ? Convert.ToInt32(r["TotalAttempts"]) : 1;

                                string d1 = "Duration: " + duration + " Mins";
                                string d2 = attempts + " Attempt(s) allowed";

                                CreateCard(panelQuizzes, id, title, d1, d2, y, false);
                                y += 100;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quizzes: " + ex.Message);
            }
        }

        private void CreateCard(Panel parent, int id, string title, string d1, string d2, int y, bool isAssignment)
        {
            Panel p = new Panel();
            p.Size = new Size(parent.Width - 40, 90);
            p.Location = new Point(10, y);
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.FixedSingle;

            Panel strip = new Panel();
            strip.Size = new Size(5, 90);
            strip.Dock = DockStyle.Left;
            strip.BackColor = activeColor;

            Label l1 = new Label();
            l1.Text = title;
            l1.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            l1.Location = new Point(15, 10);
            l1.AutoSize = true;

            Label l2 = new Label();
            l2.Text = d1;
            l2.Location = new Point(15, 35);
            l2.AutoSize = true;
            l2.ForeColor = Color.Gray;

            Label l3 = new Label();
            l3.Text = d2;
            l3.Location = new Point(15, 55);
            l3.AutoSize = true;
            l3.ForeColor = Color.DarkBlue;

            RoundedButton del = new RoundedButton();
            del.Text = "Delete";
            del.BackColor = deleteColor;
            del.ForeColor = Color.White;
            del.Size = new Size(80, 35);
            del.Location = new Point(p.Width - 95, 25);

            del.Click += (s, e) =>
            {
                if (isAssignment) DeleteAssignment(id, title);
                else DeleteQuiz(id, title);
            };

            p.Controls.Add(l1);
            p.Controls.Add(l2);
            p.Controls.Add(l3);
            p.Controls.Add(del);
            p.Controls.Add(strip);
            parent.Controls.Add(p);
        }

        private void DeleteAssignment(int id, string title)
        {
            if (MessageBox.Show("Delete assignment '" + title + "'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();

                        string q = @"DELETE FROM Assignments 
                                     WHERE AssignmentID = @ID";

                        using (MySqlCommand cmd = new MySqlCommand(q, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                        }

                        LogActivity("Deleted Assignment: " + title);
                    }

                    LoadAssignments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
            }
        }

        private void DeleteQuiz(int id, string title)
        {
            if (MessageBox.Show("Delete quiz '" + title + "'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();

                        string q = @"DELETE FROM Quizzes 
                                     WHERE QuizID = @ID";

                        using (MySqlCommand cmd = new MySqlCommand(q, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                        }

                        LogActivity("Deleted Quiz: " + title);
                    }

                    LoadQuizzes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
            }
        }

        private void LogActivity(string text)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string q = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@UID, @Txt)";

                    using (MySqlCommand cmd = new MySqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@UID", userID);
                        cmd.Parameters.AddWithValue("@Txt", text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
            }
        }

        private void HandleLogout()
        {
            if (MessageBox.Show("Log out from the system?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new SignupLoginForm().ShowDialog();
                this.Close();
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


        private void btnBacktoCourses_Click(object sender, EventArgs e)
        {
            NavigateTo(new Teacher_My_Courses(userEmail));
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            NavigateTo(new Teacher_CreateAssignment(userEmail, currentCourseID));
        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            NavigateTo(new Teacher_CreateQuiz(userEmail, currentCourseID));
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
