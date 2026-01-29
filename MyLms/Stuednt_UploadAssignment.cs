using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Stuednt_UploadAssignment : Form
    {
        private string userEmail;
        private int courseID;
        private int assignmentID;
        private int userID;
        private string sourceFilePath = "";
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";

        public Stuednt_UploadAssignment(string email, int cID, int aID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            courseID = cID;
            assignmentID = aID;

            LoadUserData();
            SetupSidebarEvents();

            if (studentSidebar1 != null)
            {
                studentSidebar1.SetActivePage("MyCourses");
            }
        }

        public Stuednt_UploadAssignment() { InitializeComponent(); }

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

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@E", userEmail);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select your assignment file";
                ofd.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Word Documents (*.docx)|*.docx";

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

        private void btnViewFile_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherFilePath = "";
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT FilePath
                                     FROM Assignments 
                                     WHERE AssignmentID = @AID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AID", assignmentID);
                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                teacherFilePath = r["FilePath"].ToString();
                            }
                        }
                    }
                }

                if (!string.IsNullOrEmpty(teacherFilePath) && File.Exists(teacherFilePath))
                {
                    Process.Start(new ProcessStartInfo(teacherFilePath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("The teacher has not uploaded a reference file or the file is missing.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmitAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceFilePath) || !File.Exists(sourceFilePath))
            {
                MessageBox.Show("Please select a valid file before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string submissionsFolder = Path.Combine(Application.StartupPath, "Submissions");
            if (!Directory.Exists(submissionsFolder))
            {
                Directory.CreateDirectory(submissionsFolder);
            }

            string ext = Path.GetExtension(sourceFilePath);
            string newFileName = $"Assign_{assignmentID}_Student_{userID}{ext}";
            string destPath = Path.Combine(submissionsFolder, newFileName);

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string checkQuery = @"SELECT FilePath
                                          FROM Submissions
                                          WHERE AssignmentID = @AID AND StudentID = @SID";

                    object existingPath = null;
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@AID", assignmentID);
                        checkCmd.Parameters.AddWithValue("@SID", userID);
                        using (MySqlDataReader r = checkCmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                existingPath = r["FilePath"];
                            }
                        }
                    }

                    if (existingPath != null)
                    {
                        var confirm = MessageBox.Show("Overwriting previous submission?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.No)
                        {
                            return;
                        }

                        File.Copy(sourceFilePath, destPath, true);

                        string updateQuery = @"UPDATE Submissions
                                               SET FilePath = @path, SubmissionDate = NOW(), Status = 'Resubmitted', Attempts = Attempts + 1 
                                               WHERE AssignmentID = @AID AND StudentID = @SID";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@path", destPath);
                            updateCmd.Parameters.AddWithValue("@AID", assignmentID);
                            updateCmd.Parameters.AddWithValue("@SID", userID);
                            updateCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Resubmitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        File.Copy(sourceFilePath, destPath, true);

                        string insertQuery = "INSERT INTO Submissions (AssignmentID, StudentID, FilePath, Status, SubmissionDate, Attempts) VALUES (@AID, @SID, @path, 'Submitted', NOW(), 1)";
                       
                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@AID", assignmentID);
                            insertCmd.Parameters.AddWithValue("@SID", userID);
                            insertCmd.Parameters.AddWithValue("@path", destPath);
                            insertCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string logText = $"Submitted Assignment (ID: {assignmentID})";

                    string logQuery = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@U, @Txt)";
                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, con))
                    {
                        logCmd.Parameters.AddWithValue("@U", userID);
                        logCmd.Parameters.AddWithValue("@Txt", logText);
                        logCmd.ExecuteNonQuery();
                    }
                }

                NavigateBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submission failed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateBack()
        {
            this.Hide();
            new Student_AssignmentQuizzes(userEmail, courseID).ShowDialog();
            this.Close();
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
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnBackToAssignmentsQuizzesFromAssignment_Click(object sender, EventArgs e)
        {
            NavigateBack();
        }
    }
}
