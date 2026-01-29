using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyLms
{
    public partial class SignupLoginForm : Form
    {
        Color activeBackColor = ColorTranslator.FromHtml("#DDE0FF");
        Color activeForeColor = ColorTranslator.FromHtml("#4F69EC");
        Color defaultBackColor = Color.White;
        Color defaultForeColor = Color.Gray;

        private Button currentButton;

        string conString = "server=localhost;uid=root;pwd="YOUR_PASSWORD_HERE";database=LMS;";

        public SignupLoginForm()
        {
            InitializeComponent();
            panelSignup.Visible = false;
        }

        private void ResetButton(Button btn)
        {
            btn.BackColor = defaultBackColor;
            btn.ForeColor = defaultForeColor;
        }

        private void SetActiveButton(Button clickedButton)
        {
            ResetButton(btnLogin);
            ResetButton(btnSignUp);

            if (clickedButton != null)
            {
                clickedButton.BackColor = activeBackColor;
                clickedButton.ForeColor = activeForeColor;
                currentButton = clickedButton;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSignUp);
            panelSignup.Visible = true;
            panelLogin.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnLogin);
            panelLogin.Visible = true;
            panelSignup.Visible = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameSignup.Text.Trim();
                string email = txtEmailSignup.Text.Trim();
                string pass = txtPassSignup.Text.Trim();
                string cpass = txtConfirmPassSignup.Text.Trim();
                string role = comboBoxRoleSignup.Text.Trim();

                txtNameSignup.BackColor = Color.White;
                txtNameSignup.ForeColor = Color.Gray;
                txtEmailSignup.BackColor = Color.White;
                txtEmailSignup.ForeColor = Color.Gray;
                txtPassSignup.BackColor = Color.White;
                txtPassSignup.ForeColor = Color.Gray;
                txtConfirmPassSignup.BackColor = Color.White;
                txtConfirmPassSignup.ForeColor = Color.Gray;

                bool hasError = false;

                if (string.IsNullOrEmpty(name))
                {
                    txtNameSignup.BackColor = Color.LightCoral;
                    txtNameSignup.ForeColor = Color.White;
                    hasError = true;
                }

                if (string.IsNullOrEmpty(email))
                {
                    txtEmailSignup.BackColor = Color.LightCoral;
                    txtEmailSignup.ForeColor = Color.White;
                    hasError = true;
                }

                if (string.IsNullOrEmpty(pass))
                {
                    txtPassSignup.BackColor = Color.LightCoral;
                    txtPassSignup.ForeColor = Color.White;
                    hasError = true;
                }

                if (string.IsNullOrEmpty(cpass))
                {
                    txtConfirmPassSignup.BackColor = Color.LightCoral;
                    txtConfirmPassSignup.ForeColor = Color.White;
                    hasError = true;
                }

                if (hasError)
                {
                    throw new Exception("Please fill all highlighted fields.");
                }

                if (string.IsNullOrEmpty(role))
                {
                    throw new Exception("Please select your role.");
                }

                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    txtEmailSignup.BackColor = Color.LightCoral;
                    txtEmailSignup.ForeColor = Color.White;
                    throw new Exception("Please enter a valid email address.");
                }

                if (pass != cpass)
                {
                    throw new Exception("Password and Confirm Password do not match!");
                }

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "INSERT INTO Users (FullName, Email, Password, Role) VALUES (@Name, @Email, @Pass, @Role)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Pass", pass);
                    cmd.Parameters.AddWithValue("@Role", role);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNameSignup.Clear();
                    txtEmailSignup.Clear();
                    txtPassSignup.Clear();
                    txtConfirmPassSignup.Clear();
                    SetActiveButton(btnLogin);
                    panelSignup.Visible = false;
                    panelLogin.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmailLogin.Text.Trim();
                string pass = txtPassLogin.Text.Trim();

                txtEmailLogin.BackColor = Color.White;
                txtEmailLogin.ForeColor = Color.Gray;

                txtPassLogin.BackColor = Color.White;
                txtPassLogin.ForeColor = Color.Gray;

                bool hasError = false;

                if (string.IsNullOrEmpty(email))
                {
                    txtEmailLogin.BackColor = Color.LightCoral;
                    txtEmailLogin.ForeColor = Color.White;
                    hasError = true;
                }

                if (string.IsNullOrEmpty(pass))
                {
                    txtPassLogin.BackColor = Color.LightCoral;
                    txtPassLogin.ForeColor = Color.White;
                    hasError = true;
                }

                if (hasError)
                {
                    throw new Exception("Please enter both email and password.");
                }

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT Password, Role, FullName 
                                     FROM Users
                                     WHERE Email = @Email";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string dbPass = reader["Password"].ToString();
                        string role = reader["Role"].ToString();
                        string name = reader["FullName"].ToString();

                        if (dbPass != pass)
                        {
                            throw new Exception("Incorrect password.");
                        }

                        MessageBox.Show("Welcome back, " + name + "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        if (role == "Student")
                        {
                            StudentDashboard s = new StudentDashboard(email);
                            s.Show();
                        }
                        else if (role == "Teacher")
                        {
                            TeacherDashboard t = new TeacherDashboard(email);
                            t.Show();
                        }
                        else
                        {
                            MessageBox.Show("Role is missing in database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        throw new Exception("Email not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}