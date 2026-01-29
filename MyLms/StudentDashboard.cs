using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class StudentDashboard : Form
    {
        private string userEmail;
        private int userID;
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        private Color activeColor = Color.FromArgb(79, 70, 229);

        public StudentDashboard(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            LoadUserData();
            SetupSidebarEvents();
            LoadDashboardStats();
            if (studentSidebar1 != null)
            {
                studentSidebar1.SetActivePage("Dashboard");
            }
        }

        public StudentDashboard()
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
                            string fullName = reader["FullName"].ToString();

                            if (studentSidebar1 != null)
                            {
                                studentSidebar1.StudentName = fullName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string enrolledQuery = @"SELECT COUNT(*) AS TotalCourses
                                             FROM Enrollments
                                             WHERE StudentID = @ID";
                    
                    MySqlCommand cmdEnrolled = new MySqlCommand(enrolledQuery, con);
                    cmdEnrolled.Parameters.AddWithValue("@ID", userID);

                    using (MySqlDataReader reader = cmdEnrolled.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string totalCourses = reader["TotalCourses"].ToString();
                            if (lblNoEnrolledCourses != null)
                            {
                                lblNoEnrolledCourses.Text = totalCourses;
                            }
                        }
                    }

                    string pendingQuery = @"SELECT COUNT(a.AssignmentID) AS PendingTasks
                                            FROM Assignments a
                                            JOIN Enrollments e 
                                            ON a.CourseID = e.CourseID
                                            LEFT JOIN Submissions s 
                                            ON a.AssignmentID = s.AssignmentID AND s.StudentID = @ID
                                            WHERE e.StudentID = @ID AND s.SubmissionID IS NULL";

                    MySqlCommand cmdPending = new MySqlCommand(pendingQuery, con);
                    cmdPending.Parameters.AddWithValue("@ID", userID);

                    using (MySqlDataReader reader = cmdPending.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string totalPending = reader["PendingTasks"].ToString();
                            if (lblNoPendingTasks != null)
                            {
                                lblNoPendingTasks.Text = totalPending;
                            }
                        }
                    }

                    LoadRecentActivity(con);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stats Loading Error: " + ex.Message);
            }
        }

        private void LoadRecentActivity(MySqlConnection con)
        {
            if (panelRecentActivity == null)
            {
                return;
            }

            panelRecentActivity.Controls.Clear();
            string activityQuery = @"SELECT ActivityText, ActivityTime
                                     FROM ActivityLog
                                     WHERE UserID = @ID
                                     ORDER BY ActivityTime DESC LIMIT 5";

            MySqlCommand cmd = new MySqlCommand(activityQuery, con);
            cmd.Parameters.AddWithValue("@ID", userID);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                int y = 10;
                while (reader.Read())
                {
                    Panel p = new Panel
                    {
                        Size = new Size(panelRecentActivity.Width - 40, 60),
                        Location = new Point(20, y),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    Panel strip = new Panel
                    {
                        Size = new Size(5, 60),
                        Dock = DockStyle.Left,
                        BackColor = activeColor
                    };

                    Label t = new Label
                    {
                        Text = reader["ActivityText"].ToString(),
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Location = new Point(15, 10),
                        AutoSize = true
                    };

                    Label time = new Label
                    {
                        Text = Convert.ToDateTime(reader["ActivityTime"]).ToString("MMM dd, hh:mm tt"),
                        ForeColor = Color.Gray,
                        Location = new Point(15, 35),
                        AutoSize = true
                    };

                    p.Controls.Add(t);
                    p.Controls.Add(time);
                    p.Controls.Add(strip);
                    panelRecentActivity.Controls.Add(p);
                    y += 70;
                }
            }
        }

        private void SetupSidebarEvents()
        {
            if (studentSidebar1 != null)
            {
                studentSidebar1.MyCoursesClicked += (s, e) => NavigateTo(new Student_My_Courses(userEmail));
                studentSidebar1.MyGradesClicked += (s, e) => NavigateTo(new Student_My_Grades(userEmail));
                studentSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }

            if (btnJoinNewCourse != null)
            {
                btnJoinNewCourse.Click += (s, e) => NavigateTo(new Student_JoinCourse(userEmail));
            }
        }

        private void HandleLogout()
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new SignupLoginForm().ShowDialog();
                this.Close();
            }
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
