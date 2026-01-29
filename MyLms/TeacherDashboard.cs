using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class TeacherDashboard : Form
    {
        private string userEmail;
        private int userID;
        private string userName;

        string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        Color activeColor = Color.FromArgb(79, 70, 229);

        public TeacherDashboard(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            userEmail = email;

            LoadUserData();
            SetupSidebarEvents();
            LoadDashboardStats();

            if (teacherSidebar1 != null)
            {
                teacherSidebar1.SetActivePage("Dashboard");
            }
        }

        public TeacherDashboard()
        {
            InitializeComponent();
        }

        public void LoadUserData()
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
                            userName = r["FullName"].ToString();

                            if (teacherSidebar1 != null)
                            {
                                teacherSidebar1.TeacherName = userName;
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

        private void LoadDashboardStats()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string courseQuery = @"SELECT COUNT(*) AS totalCourses
                                           FROM Courses 
                                           WHERE TeacherID = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(courseQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", userID);

                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                lblNoActiveCourses.Text = r["totalCourses"].ToString();
                            }
                            else
                            {
                                lblNoActiveCourses.Text = "0";
                            }
                        }
                    }

                    string studentQuery = @"SELECT COUNT(DISTINCT StudentID) AS totalStudents
                                            FROM Enrollments e
                                            JOIN Courses c ON e.CourseID = c.CourseID
                                            WHERE c.TeacherID = @ID";


                    using (MySqlCommand cmd = new MySqlCommand(studentQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", userID);

                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                lblNoTotalStudents.Text = r["totalStudents"].ToString();
                            }
                            else
                            {
                                lblNoTotalStudents.Text = "0";
                            }
                        }
                    }

                    LoadRecentActivity(con);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard Stats Error: " + ex.Message);
            }
        }

        private void LoadRecentActivity(MySqlConnection con)
        {
            if (panelRecentActivity == null)
            {
                return;
            }

            panelRecentActivity.Controls.Clear();

            string query = @"SELECT ActivityText, ActivityTime
                             FROM ActivityLog
                             WHERE UserID = @ID
                             ORDER BY ActivityTime DESC
                             LIMIT 5";


            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", userID);

            using (MySqlDataReader r = cmd.ExecuteReader())
            {
                int y = 10;

                while (r.Read())
                {
                    Panel p = new Panel();
                    p.Size = new Size(panelRecentActivity.Width - 40, 60);
                    p.Location = new Point(20, y);
                    p.BackColor = Color.White;
                    p.BorderStyle = BorderStyle.FixedSingle;

                    Panel strip = new Panel();
                    strip.Size = new Size(5, 60);
                    strip.Dock = DockStyle.Left;
                    strip.BackColor = activeColor;

                    Label text = new Label();
                    text.Text = r["ActivityText"].ToString();
                    text.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    text.Location = new Point(15, 10);
                    text.AutoSize = true;

                    Label time = new Label();
                    time.Text = Convert.ToDateTime(r["ActivityTime"]).ToString("MMM dd, hh:mm tt");
                    time.ForeColor = Color.Gray;
                    time.Location = new Point(15, 35);
                    time.AutoSize = true;

                    p.Controls.Add(text);
                    p.Controls.Add(time);
                    p.Controls.Add(strip);
                    panelRecentActivity.Controls.Add(p);

                    y = y + 70;
                }
            }
        }

        private void SetupSidebarEvents()
        {
            if (teacherSidebar1 != null)
            {
                teacherSidebar1.MyCoursesClicked += (s, e) => NavigateTo(new Teacher_My_Courses(userEmail));
                teacherSidebar1.GradesClicked += (s, e) => NavigateTo(new Teacher_Grades(userEmail));
                teacherSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }

            if (btnCreateNewCourse != null)
            {
                btnCreateNewCourse.Click += (s, e) => NavigateTo(new Teacher_CreateCourse(userEmail));
            }
        }

        private void HandleLogout()
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
