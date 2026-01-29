using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Student_JoinCourse : Form
    {
        private string userEmail;
        private int userID;
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";

        public Student_JoinCourse(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            LoadUserData();
            SetupSidebarEvents();
            if (studentSidebar1 != null)
            {
                studentSidebar1.SetActivePage("");
            }
        }

        public Student_JoinCourse()
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

        private bool IsValidCourseCode(string code)
        {
            return Regex.IsMatch(code, "^[A-Z0-9]{6}$");
        }

        private void txtCourseCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCourseCode.Focused)
            {
                int pos = txtCourseCode.SelectionStart;
                txtCourseCode.Text = txtCourseCode.Text.ToUpper();
                txtCourseCode.SelectionStart = pos;
            }
        }

        private void btnJoinCourse_Click(object sender, EventArgs e)
        {
            string code = txtCourseCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Please enter a Course Code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidCourseCode(code))
            {
                MessageBox.Show("Invalid Code format. Code must be exactly 6 alphanumeric characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string courseQuery = @"SELECT CourseID, CourseName
                                           FROM Courses
                                           WHERE JoinCode = @Code";

                    MySqlCommand cmdCourse = new MySqlCommand(courseQuery, con);
                    cmdCourse.Parameters.AddWithValue("@Code", code);

                    int courseID = 0;
                    string courseName = "";

                    using (MySqlDataReader reader = cmdCourse.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            courseID = Convert.ToInt32(reader["CourseID"]);
                            courseName = reader["CourseName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Join Code. No course found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string checkEnrollmentQuery = @"SELECT COUNT(*) AS CountEnrollment
                                                    FROM Enrollments 
                                                    WHERE StudentID = @S AND CourseID = @C";

                    MySqlCommand cmdCheck = new MySqlCommand(checkEnrollmentQuery, con);
                    cmdCheck.Parameters.AddWithValue("@S", userID);
                    cmdCheck.Parameters.AddWithValue("@C", courseID);

                    using (MySqlDataReader reader = cmdCheck.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader["CountEnrollment"]);
                            if (count > 0)
                            {
                                MessageBox.Show("You are already enrolled in this course.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                    string insertEnrollmentQuery = "INSERT INTO Enrollments (StudentID, CourseID) VALUES (@SID, @CID)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertEnrollmentQuery, con))
                    {
                        cmdInsert.Parameters.AddWithValue("@SID", userID);
                        cmdInsert.Parameters.AddWithValue("@CID", courseID);
                        cmdInsert.ExecuteNonQuery();
                    }

                    string logText = $"Joined course: {courseName}";

                    string logQuery = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@U, @A)";
                    using (MySqlCommand cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@U", userID);
                        cmdLog.Parameters.AddWithValue("@A", logText);
                        cmdLog.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully joined: " + courseName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NavigateTo(new StudentDashboard(userEmail));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error joining course: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void HandleLogout()
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new SignupLoginForm().ShowDialog();
                this.Close();
            }
        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            NavigateTo(new StudentDashboard(userEmail));
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
