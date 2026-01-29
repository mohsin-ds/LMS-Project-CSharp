using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Teacher_CreateAssignment : Form
    {
        private string userEmail;
        private int courseID;
        private int userID;
        private string sourceFilePath = "";
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";

        public Teacher_CreateAssignment(string email, int cID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            courseID = cID;

            LoadUserData();
            SetupSidebarEvents();

            if (teacherSidebar1 != null)
            {
                teacherSidebar1.SetActivePage("MyCourses");
            }
        }

        public Teacher_CreateAssignment() 
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
                    string q = @"SELECT UserID, FullName
                                FROM Users
                                WHERE Email = @E";
                    
                    using (MySqlCommand cmd = new MySqlCommand(q, con))
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files|*.pdf|Word Documents|*.docx|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sourceFilePath = ofd.FileName;
                    if (lblFileName != null)
                    {
                        lblFileName.Text = Path.GetFileName(sourceFilePath);
                    }
                }
            }
        }

        private void btnPublishAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssignmentTitle.Text))
            {
                MessageBox.Show("Please enter a title for the assignment.");
                return;
            }

            DateTime due = AssignmentduedatePicker.Value.Date + AssignmentduetimePicker.Value.TimeOfDay;
            if (due < DateTime.Now)
            {
                MessageBox.Show("The due date and time cannot be in the past.");
                return;
            }

            int attempts = (int)numericAssignmentAttempts.Value;
            int totalMarks = (int)numericTotalMarks.Value;
            string savedFilePath = "";

            if (!string.IsNullOrEmpty(sourceFilePath))
            {
                try
                {
                    string uploadFolder = Path.Combine(Application.StartupPath, "Uploads", "Assignments");
                    if (!Directory.Exists(uploadFolder))
                    {
                        Directory.CreateDirectory(uploadFolder);
                    }

                    string ext = Path.GetExtension(sourceFilePath);
                    string uniqueName = $"Assign_{courseID}_{Guid.NewGuid()}{ext}";
                    savedFilePath = Path.Combine(uploadFolder, uniqueName);
                    File.Copy(sourceFilePath, savedFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File system error: " + ex.Message);
                    return;
                }
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string q = "INSERT INTO Assignments (CourseID, Title, DueDate, FilePath, MaxAttempts, TotalMarks) VALUES (@C, @T, @D, @F, @M, @TM)";

                    using (MySqlCommand cmd = new MySqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@C", courseID);
                        cmd.Parameters.AddWithValue("@T", txtAssignmentTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@D", due);
                        cmd.Parameters.AddWithValue("@F", savedFilePath);
                        cmd.Parameters.AddWithValue("@M", attempts);
                        cmd.Parameters.AddWithValue("@TM", totalMarks);
                        cmd.ExecuteNonQuery();
                    }

                    string logText = "Created Assignment: " + txtAssignmentTitle.Text.Trim();

                    string query = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@U, @A)";

                    using (MySqlCommand logCmd = new MySqlCommand(query, con))
                    {
                        logCmd.Parameters.AddWithValue("@U", userID);
                        logCmd.Parameters.AddWithValue("@A", logText);
                        logCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Assignment has been published successfully!");
                    NavigateBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
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

        private void HandleLogout()
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new SignupLoginForm().ShowDialog();
                this.Close();
            }
        }

        private void btnBackToAssignmentsQuizzesFromAssignment_Click(object sender, EventArgs e)
        {
            NavigateBack();
        }

        private void NavigateBack()
        {
            this.Hide();
            new Teacher_AssignmentsQuizzes(userEmail, courseID).ShowDialog();
            this.Close();
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
