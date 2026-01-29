using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Student_My_Grades : Form
    {
        private string userEmail;
        private int userID;
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        private Color activeColor = Color.FromArgb(79, 70, 229);
        private Color defaultColor = Color.FromArgb(31, 41, 55);
        private Color hoverColor = Color.FromArgb(55, 65, 81);

        public Student_My_Grades(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;

            LoadUserData();
            LoadEnrolledCourses();
            SetupSidebarEvents();

            if (studentSidebar1 != null)
            {
                studentSidebar1.SetActivePage("MyGrades");
            }
        }

        public Student_My_Grades()
        {
            InitializeComponent();
        }

        public class StudentComboItem
        {
            public string Name { get; set; }
            public int ID { get; set; }

            public StudentComboItem(string name, int id)
            {
                Name = name;
                ID = id;
            }
        }

        private void LoadUserData()
        {
            string query = @"SELECT UserID, FullName
                             FROM Users
                             WHERE Email = @Email";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            userID = Convert.ToInt32(r["UserID"]);
                            if (studentSidebar1 != null)
                            {
                                studentSidebar1.StudentName = r["FullName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile load error: " + ex.Message);
            }
        }

        private void LoadEnrolledCourses()
        {
            if (comboBoxCourseList == null)
            {
                return;
            }

            comboBoxCourseList.Items.Clear();
            comboBoxCourseList.DisplayMember = "Name";
            comboBoxCourseList.ValueMember = "ID";

            string query = @"SELECT c.CourseID, c.CourseName
                             FROM Enrollments e
                             JOIN Courses c 
                             ON e.CourseID = c.CourseID
                             WHERE e.StudentID = @StudentID";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", userID);

                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            comboBoxCourseList.Items.Add(new StudentComboItem(r["CourseName"].ToString(), Convert.ToInt32(r["CourseID"])));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void LoadMyGrades()
        {
            if (dataGridViewMyGrades == null || comboBoxCourseList.SelectedItem == null) 
            { 
                return; 
            }

            dataGridViewMyGrades.Rows.Clear();
            int courseID = ((StudentComboItem)comboBoxCourseList.SelectedItem).ID;

            string query = @"SELECT a.Title AS Activity,
                                    IFNULL(s.Score, -1) AS Score,
                                    IFNULL(s.Status, 'Pending') AS Status,
                                    'Assignment' AS Type,
                                    a.TotalMarks AS MaxScore
                              FROM Assignments a
                              LEFT JOIN Submissions s 
                              ON a.AssignmentID = s.AssignmentID AND s.StudentID = @SID
                              WHERE a.CourseID = @CID
                              UNION ALL
                              SELECT q.Title AS Activity,
                                    IFNULL(r.Score, -1) AS Score,
                                    IF(r.Score IS NULL, 'Pending', 'Graded') AS Status,
                                    'Quiz' AS Type,
                                    (SELECT COUNT(*) FROM QuizQuestions WHERE QuizID = q.QuizID) AS MaxScore
                              FROM Quizzes q
                              LEFT JOIN QuizResults r 
                              ON q.QuizID = r.QuizID AND r.StudentID = @SID
                              WHERE q.CourseID = @CID";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SID", userID);
                    cmd.Parameters.AddWithValue("@CID", courseID);

                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            int score = Convert.ToInt32(r["Score"]);
                            string maxScore = r["MaxScore"].ToString();
                            string scoreDisplay = score == -1 ? $"-- / {maxScore}" : $"{score} / {maxScore}";
                            string activity = $"{r["Activity"]} ({r["Type"]})";
                            string courseName = ((StudentComboItem)comboBoxCourseList.SelectedItem).Name;

                            dataGridViewMyGrades.Rows.Add(courseName, activity, scoreDisplay, r["Status"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message);
            }
        }

        private void SetupSidebarEvents()
        {
            if (studentSidebar1 != null)
            {
                studentSidebar1.DashboardClicked += (s, e) => NavigateTo(new StudentDashboard(userEmail));
                studentSidebar1.MyCoursesClicked += (s, e) => NavigateTo(new Student_My_Courses(userEmail));
                studentSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }

            if (comboBoxCourseList != null)
                comboBoxCourseList.SelectedIndexChanged += (s, e) => LoadMyGrades();
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
