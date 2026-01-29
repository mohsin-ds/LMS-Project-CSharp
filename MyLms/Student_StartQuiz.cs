using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class Student_StartQuiz : Form
    {
        private string userEmail;
        private int courseID;
        private int quizID;
        private int userID;
        private int timeLeftSeconds;


        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private Dictionary<int, string> userAnswers = new Dictionary<int, string>();
        private string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";

        public class Question
        {
            public int QuestionId { get; set; }
            public string Text { get; set; }
            public string OptA { get; set; }
            public string OptB { get; set; }
            public string OptC { get; set; }
            public string OptD { get; set; }
            public string Correct { get; set; }

            public Question(int questionId, string text, string optA, string optB, string optC, string optD, string correct)
            {
                QuestionId = questionId;
                Text = text;
                OptA = optA;
                OptB = optB;
                OptC = optC;
                OptD = optD;
                Correct = correct;
            }
        }

        public Student_StartQuiz(string email, int cID, int qID, string quizTitle, int durationMinutes)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userEmail = email;
            courseID = cID;
            quizID = qID;
            timeLeftSeconds = durationMinutes * 60;

            if (lblQuizName != null)
            {
                lblQuizName.Text = quizTitle;
            }

            LoadUserData();
            LoadQuestions();
            SetupTimer();

            if (questions.Count > 0)
            {
                ShowQuestion(0);
            }
            else
            {
                MessageBox.Show("No questions found.");
                CloseQuiz();
            }
        }

        public Student_StartQuiz() { InitializeComponent(); }

        private void LoadUserData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT UserID 
                                     FROM Users
                                     WHERE Email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                userID = Convert.ToInt32(r["UserID"]);
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

        private void LoadQuestions()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT * 
                                     FROM QuizQuestions
                                     WHERE QuizID = @QID";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@QID", quizID);
                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                questions.Add(new Question (Convert.ToInt32(r["QuestionID"]), r["Statement"].ToString(), r["OptionA"].ToString(), r["OptionB"].ToString(), r["OptionC"].ToString(), r["OptionD"].ToString(),r["CorrectOption"].ToString().Trim()));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message);
            }
        }

        private void SetupTimer()
        {
            quizTimer.Tick -= quizTimer_Tick;
            quizTimer.Tick += quizTimer_Tick;
            quizTimer.Start();
            UpdateTimerDisplay();
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeftSeconds > 0)
            {
                timeLeftSeconds--;
                UpdateTimerDisplay();
            }
            else
            {
                quizTimer.Stop();
                SaveCurrentAnswer();
                MessageBox.Show("Time up!");
                SubmitQuiz();
            }
        }

        private void UpdateTimerDisplay()
        {
            if (lblTimer != null)
            {
                int mins = timeLeftSeconds / 60;
                int secs = timeLeftSeconds % 60;
                lblTimer.Text = $"{mins:D2}:{secs:D2}";
                if (timeLeftSeconds < 60)
                {
                    lblTimer.ForeColor = Color.Red;
                }
            }
        }

        private void ShowQuestion(int index)
        {
            if (index < 0 || index >= questions.Count) 
            { 
                return; 
            }

            currentQuestionIndex = index;
            Question q = questions[index];
            if (lblQuestionStatement != null)
            {
                lblQuestionStatement.Text = $"{index + 1}. {q.Text}";
            }
            rdOptionA.Text = q.OptA; rdOptionA.Checked = false;
            rdOptionB.Text = q.OptB; rdOptionB.Checked = false;
            rdOptionC.Text = q.OptC; rdOptionC.Checked = false;
            rdOptionD.Text = q.OptD; rdOptionD.Checked = false;

            if (userAnswers.ContainsKey(q.QuestionId))
            {
                string ans = userAnswers[q.QuestionId];
                if (ans == "A") rdOptionA.Checked = true;
                else if (ans == "B") rdOptionB.Checked = true;
                else if (ans == "C") rdOptionC.Checked = true;
                else if (ans == "D") rdOptionD.Checked = true;
            }

            btnPrevious.Enabled = currentQuestionIndex > 0;
            btnNext.Text = (currentQuestionIndex == questions.Count - 1) ? "Submit" : "Next";
            btnNext.BackColor = (currentQuestionIndex == questions.Count - 1) ? Color.Green : Color.FromArgb(31, 41, 55);
        }

        private void SaveCurrentAnswer()
        {
            if (questions.Count == 0) return;
            int qId = questions[currentQuestionIndex].QuestionId;
            string selected = null;
            if (rdOptionA.Checked) selected = "A";
            else if (rdOptionB.Checked) selected = "B";
            else if (rdOptionC.Checked) selected = "C";
            else if (rdOptionD.Checked) selected = "D";

            if (selected != null) userAnswers[qId] = selected;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            if (currentQuestionIndex == questions.Count - 1)
            {
                if (MessageBox.Show("Are you sure you want to submit the quiz?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SubmitQuiz();
                }
            }
            else
            {
                ShowQuestion(currentQuestionIndex + 1);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            ShowQuestion(currentQuestionIndex - 1);
        }

        private void SubmitQuiz()
        {
            if (quizTimer != null) quizTimer.Stop();
            int score = 0;
            foreach (var q in questions)
            {
                string correct = q.Correct.Replace("Option ", "").Trim();
                if (userAnswers.ContainsKey(q.QuestionId) && userAnswers[q.QuestionId].Trim().Equals(correct, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string checkQuery = @"SELECT Attempts
                                          FROM QuizResults
                                          WHERE QuizID = @QID AND StudentID = @SID";

                    int attempts = 0;
                    bool exists = false;

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@QID", quizID);
                        checkCmd.Parameters.AddWithValue("@SID", userID);
                        using (MySqlDataReader r = checkCmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                exists = true;
                                attempts = Convert.ToInt32(r["Attempts"]);
                            }
                        }
                    }

                    if (exists)
                    {
                        string updateQuery = @"UPDATE QuizResults
                                               SET Score = @Score, AttemptDate = NOW(), Attempts = Attempts + 1 
                                               WHERE QuizID = @QID AND StudentID = @SID";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@Score", score);
                            updateCmd.Parameters.AddWithValue("@QID", quizID);
                            updateCmd.Parameters.AddWithValue("@SID", userID);
                            updateCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Quiz Resubmitted!\nYour Score: {score}/{questions.Count}\nAttempt number: {attempts + 1}", "Quiz Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO QuizResults (QuizID, StudentID, Score, AttemptDate, Attempts) VALUES (@QID, @SID, @Score, NOW(), 1)";
                        
                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@QID", quizID);
                            insertCmd.Parameters.AddWithValue("@SID", userID);
                            insertCmd.Parameters.AddWithValue("@Score", score);
                            insertCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Quiz Submitted Successfully!\nYour Score: {score}/{questions.Count}", "Quiz Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string activityDescription = $"Completed Quiz: {lblQuizName.Text} (Score: {score}/{questions.Count})";

                    string logQuery = "INSERT INTO ActivityLog (UserID, ActivityText) VALUES (@UID, @Txt)";
                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, con))
                    {
                        logCmd.Parameters.AddWithValue("@UID", userID);
                        logCmd.Parameters.AddWithValue("@Txt", activityDescription);
                        logCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting quiz: " + ex.Message);
            }
            CloseQuiz();
        }

        private void CloseQuiz()
        {
            this.Hide();
            new Student_AssignmentQuizzes(userEmail, courseID).ShowDialog();
            this.Close();
        }

        private void btnBackToAssignmentsQuizzesFromQuiz_Click(object sender, EventArgs e)
        {
            CloseQuiz();
        }
    }
}
