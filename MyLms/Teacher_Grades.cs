using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Teacher_Grades : Form
    {
        private string userEmail;
        private int teacherID;
        string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        Color activeColor = Color.FromArgb(79, 70, 229);

        public Teacher_Grades(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            LoadTeacherData();
            LoadCourses();
            SetupSidebarEvents();
            if (teacherSidebar1 != null)
            {
                teacherSidebar1.SetActivePage("Grades");
            }
        }

        public Teacher_Grades() 
        { 
            InitializeComponent(); 
        }

        public class ComboItem
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public ComboItem() { }
            public ComboItem(string name, int value) 
            { 
                Name = name; 
                Value = value; 
            }
        }

        private void LoadTeacherData()
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
                            teacherID = Convert.ToInt32(r["UserID"]);
                            if (teacherSidebar1 != null)
                            {
                                teacherSidebar1.TeacherName = r["FullName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load teacher profile: " + ex.Message, "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCourses()
        {
            if (comboCourses == null)
            {
                return;
            }
            comboCourses.Items.Clear();
            comboCourses.DisplayMember = "Name";
            comboCourses.ValueMember = "Value";
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT CourseID, CourseName 
                                     FROM Courses 
                                     WHERE TeacherID = @TID";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TID", teacherID);
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            comboCourses.Items.Add(new ComboItem(r["CourseName"].ToString(), Convert.ToInt32(r["CourseID"])));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubmissions()
        {
            if (comboCourses.SelectedItem == null)
            {
                return;
            }
            int selectedCourseID = ((ComboItem)comboCourses.SelectedItem).Value;
            dataGridViewGrades.Rows.Clear();
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT s.SubmissionID AS ID, u.FullName AS StudentName, a.Title AS Activity, 
                                            s.SubmissionDate AS Date, s.Score, s.Status, 'Assignment' AS Type, a.TotalMarks AS MaxScore
                                     FROM Submissions s
                                     INNER JOIN Assignments a ON s.AssignmentID = a.AssignmentID
                                     INNER JOIN Users u ON s.StudentID = u.UserID
                                     WHERE a.CourseID = @CID
                                     UNION ALL
                                     SELECT r.ResultID AS ID, u.FullName AS StudentName, q.Title AS Activity, 
                                            r.AttemptDate AS Date, r.Score, 'Graded' AS Status, 'Quiz' AS Type, 
                                            (SELECT COUNT(*) FROM QuizQuestions WHERE QuizID = q.QuizID) AS MaxScore
                                     FROM QuizResults r
                                     INNER JOIN Quizzes q ON r.QuizID = q.QuizID
                                     INNER JOIN Users u ON r.StudentID = u.UserID
                                     WHERE q.CourseID = @CID
                                     ORDER BY Date DESC";
                    
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CID", selectedCourseID);
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string score = Convert.ToString(r["Score"]);
                            string type = r["Type"].ToString();
                            string max = r["MaxScore"].ToString();
                            int index = dataGridViewGrades.Rows.Add(r["ID"], r["StudentName"], r["Activity"], Convert.ToDateTime(r["Date"]).ToString("MMM dd, HH:mm"), r["Status"], score, max, "View File", type);
                           
                            if (type == "Quiz")
                            {
                                dataGridViewGrades.Rows[index].Cells["colScore"].ReadOnly = true;
                                dataGridViewGrades.Rows[index].Cells["colScore"].Style.BackColor = Color.FromArgb(243, 244, 246);
                                dataGridViewGrades.Rows[index].Cells["colScore"].Style.ForeColor = activeColor;
                                dataGridViewGrades.Rows[index].Cells["colFile"].Value = "N/A";
                            }
                            dataGridViewGrades.Rows[index].Cells["colTotalScore"].ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grade data: " + ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveGrades_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    int count = 0;
                    foreach (DataGridViewRow row in dataGridViewGrades.Rows)
                    {
                        if (row.IsNewRow || row.Cells["colType"].Value.ToString() == "Quiz")
                        {
                            continue;
                        }

                        int id = Convert.ToInt32(row.Cells["colID"].Value);
                        string scoreStr = row.Cells["colScore"].Value?.ToString();
                        int max = Convert.ToInt32(row.Cells["colTotalScore"].Value);
                        if (int.TryParse(scoreStr, out int val))
                        {
                            if (val >= 0 && val <= max)
                            {
                                string updateQuery = @"UPDATE Submissions
                                                       SET Score=@S, Status='Graded'
                                                       WHERE SubmissionID=@I";

                                MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                                cmd.Parameters.AddWithValue("@S", val);
                                cmd.Parameters.AddWithValue("@I", id);
                                cmd.ExecuteNonQuery();
                                count++;
                            }
                            else
                            {
                                MessageBox.Show($"Score for {row.Cells["colStudent"].Value} must be between 0 and {max}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    MessageBox.Show($"{count} Assignment grades updated successfully!", "Grades Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubmissions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save grades: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupSidebarEvents()
        {
            if (teacherSidebar1 != null)
            {
                teacherSidebar1.DashboardClicked += (s, e) => NavigateTo(new TeacherDashboard(userEmail));
                teacherSidebar1.MyCoursesClicked += (s, e) => NavigateTo(new Teacher_My_Courses(userEmail));
                teacherSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }

            if (comboCourses != null)
                comboCourses.SelectedIndexChanged += (s, e) => LoadSubmissions();

            if (dataGridViewGrades != null)
            {
                dataGridViewGrades.CellContentClick += (s, e) =>
                {
                    if (e.RowIndex >= 0 && dataGridViewGrades.Columns[e.ColumnIndex].Name == "colFile")
                    {
                        if (dataGridViewGrades.Rows[e.RowIndex].Cells["colType"].Value.ToString() == "Assignment")
                        {
                            OpenFile(Convert.ToInt32(dataGridViewGrades.Rows[e.RowIndex].Cells["colID"].Value));
                        }
                    }
                };
            }
        }

        private void OpenFile(int submissionID)
        {
            try
            {
                string filePath = "";
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string fileQuery = @"SELECT FilePath
                                         FROM Submissions
                                         WHERE SubmissionID = @SID";

                    MySqlCommand cmd = new MySqlCommand(fileQuery, con);
                    cmd.Parameters.AddWithValue("@SID", submissionID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        filePath = result.ToString();
                }
                if (System.IO.File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = filePath, UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("The student's submission file was not found on the server.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
