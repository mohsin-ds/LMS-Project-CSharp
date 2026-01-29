using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Teacher_CreateCourse : Form
    {
        private string userEmail;
        private int userID;
        private string userName;
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";

        public Teacher_CreateCourse(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;

            LoadUserData();
            SetupSidebarEvents();

            if (teacherSidebar1 != null)
            {
                teacherSidebar1.SetActivePage("");
            }
        }

        public Teacher_CreateCourse()
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
                            userName = r["FullName"].ToString();

                            if (teacherSidebar1 != null)
                            {
                                teacherSidebar1.TeacherName = userName;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Teacher profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Connection Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter a Course Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseDescription.Text))
            {
                MessageBox.Show("Please enter a Description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseCode.Text) || !IsValidCourseCode(txtCourseCode.Text))
            {
                MessageBox.Show("Course Code must be exactly 6 characters using letters and numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "INSERT INTO Courses (CourseName, Description, JoinCode, TeacherID) VALUES (@N, @D, @C, @T)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@N", txtCourseName.Text.Trim());
                        cmd.Parameters.AddWithValue("@D", txtCourseDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@C", txtCourseCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@T", userID);
                        cmd.ExecuteNonQuery();
                    }

                    string logText = "Created Course: " + txtCourseName.Text.Trim();

                    string logQuery = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@U, @A)";

                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, con))
                    {
                        logCmd.Parameters.AddWithValue("@U", userID);
                        logCmd.Parameters.AddWithValue("@A", logText);
                        logCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Teacher_My_Courses(userEmail).ShowDialog();
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("This Course Code is already in use. Please choose a different unique code.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create course: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void SetupSidebarEvents()
        {
            if (teacherSidebar1 != null)
            {
                teacherSidebar1.DashboardClicked += (s, e) => NavigateTo(new TeacherDashboard(userEmail));
                teacherSidebar1.MyCoursesClicked += (s, e) => NavigateTo(new Teacher_My_Courses(userEmail));
                teacherSidebar1.GradesClicked += (s, e) => NavigateTo(new Teacher_Grades(userEmail));
                teacherSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }

            if (btnBacktoDashboard != null)
            {
                btnBacktoDashboard.Click += (s, e) => NavigateTo(new TeacherDashboard(userEmail));
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