using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MyLms
{
    public partial class ForgetPassword : Form
    {
        string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";

        public ForgetPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSendResetLink_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmailForget.Text.Trim();

                txtEmailForget.BackColor = Color.White;
                txtEmailForget.ForeColor = Color.Gray;

                if (string.IsNullOrEmpty(email))
                {
                    txtEmailForget.BackColor = Color.LightCoral;
                    txtEmailForget.ForeColor = Color.White;
                    throw new Exception("Please! Enter your registered email address.");
                }

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT FullName, Password
                                     FROM Users
                                     WHERE Email = @Email";
                    
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string currentPassword = reader["Password"].ToString();
                            string name = reader["FullName"].ToString();

                            SendEmail(email, currentPassword, name);

                            MessageBox.Show($"Your password has been sent to {email}.\nPlease check your inbox.", "Password Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            txtEmailForget.BackColor = Color.LightCoral;
                            txtEmailForget.ForeColor = Color.White;
                            throw new Exception("This email is not registered in our system.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SendEmail(string toEmail, string password, string name)
        {
            try
            {
                string fromEmail = "YOUR_EMAIL_HERE";
                string appPassword = ""YOUR_APP_PASSWORD_HERE"";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromEmail);
                message.Subject = "LMS Password Recovery";
                message.To.Add(new MailAddress(toEmail));
                message.Body = $"Hello {name},\n\nWe received a request to recover your password.\n\nYour Current Password is: {password}\n\nPlease keep it safe.";
                message.IsBodyHtml = false;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromEmail, appPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to send email. Check internet connection.\nDetails: " + ex.Message);
            }
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}