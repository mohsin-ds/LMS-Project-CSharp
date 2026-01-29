using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Student_My_Courses : Form
    {
        private string userEmail;
        private int userID;
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        private Color activeColor = Color.FromArgb(79, 70, 229);
        public class CourseItem
        {
            public string Name { get; set; }
            public int Value { get; set; }

            public CourseItem(string name, int value)
            {
                Name = name;
                Value = value;
            }
        }

        public Student_My_Courses(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;

            LoadUserData();
            SetupSidebarEvents();
            LoadMyCourses();

            if (studentSidebar1 != null)
            {
                studentSidebar1.SetActivePage("MyCourses");
            }
        }

        public Student_My_Courses()
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
        private void LoadMyCourses()
        {
            if (panelMyCourses == null)
            {
                return;
            }

            for (int i = panelMyCourses.Controls.Count - 1; i >= 0; i--)
            {
                if (panelMyCourses.Controls[i] is Panel)
                    panelMyCourses.Controls.RemoveAt(i);
            }

            if (comboBoxDrop != null)
            {
                comboBoxDrop.Items.Clear();
                comboBoxDrop.DisplayMember = "Name";
                comboBoxDrop.ValueMember = "Value";
            }

            panelMyCourses.AutoScroll = true;
            int y = 100;

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT c.CourseID, c.JoinCode, c.CourseName 
                                     FROM Courses c 
                                     INNER JOIN Enrollments e 
                                     ON c.CourseID = e.CourseID 
                                     WHERE e.StudentID = @SID";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SID", userID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int courseID = Convert.ToInt32(reader["CourseID"]);
                            string courseName = reader["CourseName"].ToString();
                            string courseCode = reader["JoinCode"].ToString();

                            CreateCourseCard(courseID, courseName, courseCode, y);

                            if (comboBoxDrop != null)
                            {
                                comboBoxDrop.Items.Add(new CourseItem(courseName, courseID));
                            }

                            y += 130;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void CreateCourseCard(int id, string name, string code, int y)
        {
            Panel card = new Panel();
            card.Size = new Size(800, 110);
            card.Location = new Point(40, y);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Cursor = Cursors.Hand;

            Panel strip = new Panel();
            strip.Size = new Size(8, 110);
            strip.Dock = DockStyle.Left;
            strip.BackColor = activeColor;

            Label lblCode = new Label();
            lblCode.Text = name;
            lblCode.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblCode.ForeColor = activeColor;
            lblCode.AutoSize = true;
            lblCode.Location = new Point(25, 20);

            Label lblName = new Label();
            lblName.Text = "Code: " + code;
            lblName.Font = new Font("Segoe UI", 11);
            lblName.ForeColor = Color.FromArgb(64, 64, 64);
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 55);
           

            card.Controls.Add(lblCode);
            card.Controls.Add(lblName);
            card.Controls.Add(strip);

            EventHandler open = (s, e) =>
            {
                this.Hide();
                new Student_AssignmentQuizzes(userEmail, id).ShowDialog();
                this.Close();
            };

            card.Click += open;
            lblCode.Click += open;
            lblName.Click += open;
            strip.Click += open;

            panelMyCourses.Controls.Add(card);
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            if (comboBoxDrop.SelectedItem == null)
            {
                MessageBox.Show("Please select a course to drop.");
                return;
            }

            CourseItem selectedCourse = (CourseItem)comboBoxDrop.SelectedItem;
            DialogResult dr = MessageBox.Show($"Are you sure you want to drop '{selectedCourse.Name}'? All your submissions and results for this course will be deleted.", "Confirm Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (MySqlTransaction trans = con.BeginTransaction())
                    {
                        try
                        {
                            string delSubmissions = @"DELETE FROM Submissions 
                                                      WHERE StudentID = @SID 
                                                      AND AssignmentID IN (SELECT AssignmentID FROM Assignments WHERE CourseID = @CID)";

                            using (MySqlCommand cmd1 = new MySqlCommand(delSubmissions, con, trans))
                            {
                                cmd1.Parameters.AddWithValue("@SID", userID);
                                cmd1.Parameters.AddWithValue("@CID", selectedCourse.Value);
                                cmd1.ExecuteNonQuery();
                            }

                            string delQuizResults = @"DELETE FROM QuizResults 
                                                      WHERE StudentID = @SID 
                                                      AND QuizID IN (SELECT QuizID FROM Quizzes WHERE CourseID = @CID)";

                            using (MySqlCommand cmd2 = new MySqlCommand(delQuizResults, con, trans))
                            {
                                cmd2.Parameters.AddWithValue("@SID", userID);
                                cmd2.Parameters.AddWithValue("@CID", selectedCourse.Value);
                                cmd2.ExecuteNonQuery();
                            }

                            string delEnrollment = @"DELETE FROM Enrollments 
                                                     WHERE StudentID = @SID AND CourseID = @CID";

                            using (MySqlCommand cmd3 = new MySqlCommand(delEnrollment, con, trans))
                            {
                                cmd3.Parameters.AddWithValue("@SID", userID);
                                cmd3.Parameters.AddWithValue("@CID", selectedCourse.Value);
                                cmd3.ExecuteNonQuery();
                            }

                            string logText = $"Dropped Course: {selectedCourse.Name}";

                            string logQuery = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@U, @A)";
                            using (MySqlCommand cmdLog = new MySqlCommand(logQuery, con, trans))
                            {
                                cmdLog.Parameters.AddWithValue("@U", userID);
                                cmdLog.Parameters.AddWithValue("@A", logText);
                                cmdLog.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Course dropped and academic data cleared successfully.");
                            LoadMyCourses();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Drop failed: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error dropping course: " + ex.Message);
            }
        }
        private void SetupSidebarEvents()
        {
            if (studentSidebar1 != null)
            {
                studentSidebar1.DashboardClicked += (s, e) => NavigateTo(new StudentDashboard(userEmail));
                studentSidebar1.MyGradesClicked += (s, e) => NavigateTo(new Student_My_Grades(userEmail));
                studentSidebar1.LogoutClicked += (s, e) => HandleLogout();
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
