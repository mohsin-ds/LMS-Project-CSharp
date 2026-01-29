using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Teacher_My_Courses : Form
    {
        private string userEmail;
        private int userID;

        string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";
        Color activeColor = Color.FromArgb(79, 70, 229);

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

        public Teacher_My_Courses(string email)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            userEmail = email;

            LoadUserData();
            SetupSidebarEvents();
            LoadMyCourses();

            if (teacherSidebar1 != null)
            {
                teacherSidebar1.SetActivePage("MyCourses");
            }
        }

        public Teacher_My_Courses()
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
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
                {
                    panelMyCourses.Controls.RemoveAt(i);
                }
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

                    string query = @"SELECT CourseID, CourseName, JoinCode
                                     FROM Courses
                                     WHERE TeacherID = @ID";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", userID);

                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            int courseId = Convert.ToInt32(r["CourseID"]);
                            string courseName = r["CourseName"].ToString();
                            string joinCode = r["JoinCode"].ToString();

                            CreateCourseCard(courseId, courseName, joinCode, y);

                            if (comboBoxDrop != null)
                            {
                                CourseItem item = new CourseItem(courseName,courseId);
                                comboBoxDrop.Items.Add(item);
                            }

                            y = y + 130;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            CourseItem selectedCourse = comboBoxDrop.SelectedItem as CourseItem;

            if (selectedCourse == null)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the course '" + selectedCourse.Name + "'?","Confirm Deletion",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();

                        string deleteQuery = @"DELETE
                                               FROM Courses
                                               WHERE CourseID = @ID";

                        MySqlCommand cmd = new MySqlCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@ID", selectedCourse.Value);
                        cmd.ExecuteNonQuery();

                        string logQuery = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@U, @A)";

                        MySqlCommand logCmd = new MySqlCommand(logQuery, con);
                        logCmd.Parameters.AddWithValue("@U", userID);
                        logCmd.Parameters.AddWithValue("@A", "Deleted Course: " + selectedCourse.Name);
                        logCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Course deleted successfully.");
                    LoadMyCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course: " + ex.Message);
                }
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
            lblName.Text = "Code: " + code; ;
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
                new Teacher_AssignmentsQuizzes(userEmail, id).ShowDialog();
                this.Close();
            };

            card.Click += open;
            lblCode.Click += open;
            lblName.Click += open;
            strip.Click += open;

            panelMyCourses.Controls.Add(card);
        }

        private void SetupSidebarEvents()
        {
            if (teacherSidebar1 != null)
            {
                teacherSidebar1.DashboardClicked += (s, e) => NavigateTo(new TeacherDashboard(userEmail));
                teacherSidebar1.GradesClicked += (s, e) => NavigateTo(new Teacher_Grades(userEmail));
                teacherSidebar1.LogoutClicked += (s, e) => HandleLogout();
            }
        }

        private void HandleLogout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
