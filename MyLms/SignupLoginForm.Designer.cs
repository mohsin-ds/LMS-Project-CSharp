namespace MyLms
{
    partial class SignupLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupLoginForm));
            panelOuter = new Panel();
            lblWelcometxt = new Label();
            panelLogin = new Panel();
            linkLabelForgot = new LinkLabel();
            btnSignIn = new Button();
            txtPassLogin = new TextBox();
            lblPassLogin = new Label();
            txtEmailLogin = new TextBox();
            lblEmailLogin = new Label();
            panelSignup = new Panel();
            btnCreateAccount = new Button();
            comboBoxRoleSignup = new ComboBox();
            lblRoleSignup = new Label();
            txtConfirmPassSignup = new TextBox();
            lblConfirmPassSignup = new Label();
            txtPassSignup = new TextBox();
            lblPassSignup = new Label();
            txtEmailSignup = new TextBox();
            lblEmailSignup = new Label();
            txtNameSignup = new TextBox();
            lblNameSignup = new Label();
            panelSignupLogin = new Panel();
            btnSignUp = new RoundedButton();
            btnLogin = new RoundedButton();
            pictureBoxLogo = new PictureBox();
            lblWelcome = new Label();
            panelOuter.SuspendLayout();
            panelLogin.SuspendLayout();
            panelSignup.SuspendLayout();
            panelSignupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelOuter
            // 
            panelOuter.BackColor = Color.White;
            panelOuter.BorderStyle = BorderStyle.FixedSingle;
            panelOuter.Controls.Add(lblWelcometxt);
            panelOuter.Controls.Add(panelLogin);
            panelOuter.Controls.Add(panelSignup);
            panelOuter.Controls.Add(panelSignupLogin);
            panelOuter.Controls.Add(pictureBoxLogo);
            panelOuter.Controls.Add(lblWelcome);
            panelOuter.Location = new Point(377, 12);
            panelOuter.Name = "panelOuter";
            panelOuter.Size = new Size(529, 780);
            panelOuter.TabIndex = 0;
            // 
            // lblWelcometxt
            // 
            lblWelcometxt.AutoSize = true;
            lblWelcometxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcometxt.ForeColor = Color.FromArgb(131, 129, 136);
            lblWelcometxt.Location = new Point(147, 114);
            lblWelcometxt.Name = "lblWelcometxt";
            lblWelcometxt.Size = new Size(226, 25);
            lblWelcometxt.TabIndex = 122;
            lblWelcometxt.Text = "Access your learning portal";
            lblWelcometxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(linkLabelForgot);
            panelLogin.Controls.Add(btnSignIn);
            panelLogin.Controls.Add(txtPassLogin);
            panelLogin.Controls.Add(lblPassLogin);
            panelLogin.Controls.Add(txtEmailLogin);
            panelLogin.Controls.Add(lblEmailLogin);
            panelLogin.Location = new Point(19, 237);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(494, 320);
            panelLogin.TabIndex = 121;
            // 
            // linkLabelForgot
            // 
            linkLabelForgot.ActiveLinkColor = Color.FromArgb(48, 63, 159);
            linkLabelForgot.AutoSize = true;
            linkLabelForgot.Font = new Font("Segoe UI", 10F);
            linkLabelForgot.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabelForgot.LinkColor = Color.FromArgb(63, 81, 181);
            linkLabelForgot.Location = new Point(331, 205);
            linkLabelForgot.Name = "linkLabelForgot";
            linkLabelForgot.Size = new Size(143, 23);
            linkLabelForgot.TabIndex = 10;
            linkLabelForgot.TabStop = true;
            linkLabelForgot.Text = "Forgot Password?";
            linkLabelForgot.LinkClicked += linkLabelForgot_LinkClicked;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(79, 70, 229);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(155, 244);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(176, 38);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassLogin
            // 
            txtPassLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtPassLogin.ForeColor = Color.Gray;
            txtPassLogin.Location = new Point(13, 147);
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(461, 32);
            txtPassLogin.TabIndex = 3;
            // 
            // lblPassLogin
            // 
            lblPassLogin.AutoSize = true;
            lblPassLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassLogin.ForeColor = Color.FromArgb(51, 51, 51);
            lblPassLogin.Location = new Point(13, 108);
            lblPassLogin.Name = "lblPassLogin";
            lblPassLogin.Size = new Size(97, 28);
            lblPassLogin.TabIndex = 4;
            lblPassLogin.Text = "Password";
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtEmailLogin.ForeColor = Color.Gray;
            txtEmailLogin.Location = new Point(13, 59);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(461, 32);
            txtEmailLogin.TabIndex = 2;
            // 
            // lblEmailLogin
            // 
            lblEmailLogin.AutoSize = true;
            lblEmailLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmailLogin.ForeColor = Color.FromArgb(51, 51, 51);
            lblEmailLogin.Location = new Point(13, 14);
            lblEmailLogin.Name = "lblEmailLogin";
            lblEmailLogin.Size = new Size(60, 28);
            lblEmailLogin.TabIndex = 2;
            lblEmailLogin.Text = "Email";
            // 
            // panelSignup
            // 
            panelSignup.Controls.Add(btnCreateAccount);
            panelSignup.Controls.Add(comboBoxRoleSignup);
            panelSignup.Controls.Add(lblRoleSignup);
            panelSignup.Controls.Add(txtConfirmPassSignup);
            panelSignup.Controls.Add(lblConfirmPassSignup);
            panelSignup.Controls.Add(txtPassSignup);
            panelSignup.Controls.Add(lblPassSignup);
            panelSignup.Controls.Add(txtEmailSignup);
            panelSignup.Controls.Add(lblEmailSignup);
            panelSignup.Controls.Add(txtNameSignup);
            panelSignup.Controls.Add(lblNameSignup);
            panelSignup.Location = new Point(19, 237);
            panelSignup.Name = "panelSignup";
            panelSignup.Size = new Size(494, 508);
            panelSignup.TabIndex = 3;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(79, 70, 229);
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(155, 438);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(176, 38);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // comboBoxRoleSignup
            // 
            comboBoxRoleSignup.BackColor = Color.White;
            comboBoxRoleSignup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoleSignup.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            comboBoxRoleSignup.ForeColor = Color.FromArgb(51, 51, 51);
            comboBoxRoleSignup.FormattingEnabled = true;
            comboBoxRoleSignup.Items.AddRange(new object[] { "Student", "Teacher" });
            comboBoxRoleSignup.Location = new Point(13, 370);
            comboBoxRoleSignup.Name = "comboBoxRoleSignup";
            comboBoxRoleSignup.Size = new Size(461, 33);
            comboBoxRoleSignup.TabIndex = 7;
            // 
            // lblRoleSignup
            // 
            lblRoleSignup.AutoSize = true;
            lblRoleSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRoleSignup.ForeColor = Color.FromArgb(51, 51, 51);
            lblRoleSignup.Location = new Point(13, 330);
            lblRoleSignup.Name = "lblRoleSignup";
            lblRoleSignup.Size = new Size(51, 28);
            lblRoleSignup.TabIndex = 8;
            lblRoleSignup.Text = "Role";
            // 
            // txtConfirmPassSignup
            // 
            txtConfirmPassSignup.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtConfirmPassSignup.ForeColor = Color.Gray;
            txtConfirmPassSignup.Location = new Point(13, 288);
            txtConfirmPassSignup.Name = "txtConfirmPassSignup";
            txtConfirmPassSignup.Size = new Size(461, 32);
            txtConfirmPassSignup.TabIndex = 6;
            // 
            // lblConfirmPassSignup
            // 
            lblConfirmPassSignup.AutoSize = true;
            lblConfirmPassSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblConfirmPassSignup.ForeColor = Color.FromArgb(51, 51, 51);
            lblConfirmPassSignup.Location = new Point(13, 246);
            lblConfirmPassSignup.Name = "lblConfirmPassSignup";
            lblConfirmPassSignup.Size = new Size(176, 28);
            lblConfirmPassSignup.TabIndex = 6;
            lblConfirmPassSignup.Text = "Confirm Password";
            // 
            // txtPassSignup
            // 
            txtPassSignup.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtPassSignup.ForeColor = Color.Gray;
            txtPassSignup.Location = new Point(13, 205);
            txtPassSignup.Name = "txtPassSignup";
            txtPassSignup.Size = new Size(461, 32);
            txtPassSignup.TabIndex = 5;
            // 
            // lblPassSignup
            // 
            lblPassSignup.AutoSize = true;
            lblPassSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassSignup.ForeColor = Color.FromArgb(51, 51, 51);
            lblPassSignup.Location = new Point(13, 165);
            lblPassSignup.Name = "lblPassSignup";
            lblPassSignup.Size = new Size(97, 28);
            lblPassSignup.TabIndex = 4;
            lblPassSignup.Text = "Password";
            // 
            // txtEmailSignup
            // 
            txtEmailSignup.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtEmailSignup.ForeColor = Color.Gray;
            txtEmailSignup.Location = new Point(13, 124);
            txtEmailSignup.Name = "txtEmailSignup";
            txtEmailSignup.Size = new Size(461, 32);
            txtEmailSignup.TabIndex = 4;
            // 
            // lblEmailSignup
            // 
            lblEmailSignup.AutoSize = true;
            lblEmailSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmailSignup.ForeColor = Color.FromArgb(51, 51, 51);
            lblEmailSignup.Location = new Point(13, 86);
            lblEmailSignup.Name = "lblEmailSignup";
            lblEmailSignup.Size = new Size(60, 28);
            lblEmailSignup.TabIndex = 2;
            lblEmailSignup.Text = "Email";
            // 
            // txtNameSignup
            // 
            txtNameSignup.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtNameSignup.ForeColor = Color.Gray;
            txtNameSignup.Location = new Point(13, 48);
            txtNameSignup.Name = "txtNameSignup";
            txtNameSignup.Size = new Size(461, 32);
            txtNameSignup.TabIndex = 3;
            // 
            // lblNameSignup
            // 
            lblNameSignup.AutoSize = true;
            lblNameSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNameSignup.ForeColor = Color.FromArgb(51, 51, 51);
            lblNameSignup.Location = new Point(13, 9);
            lblNameSignup.Name = "lblNameSignup";
            lblNameSignup.Size = new Size(66, 28);
            lblNameSignup.TabIndex = 0;
            lblNameSignup.Text = "Name";
            // 
            // panelSignupLogin
            // 
            panelSignupLogin.BackColor = Color.FromArgb(247, 247, 247);
            panelSignupLogin.Controls.Add(btnSignUp);
            panelSignupLogin.Controls.Add(btnLogin);
            panelSignupLogin.ForeColor = SystemColors.ControlText;
            panelSignupLogin.Location = new Point(19, 165);
            panelSignupLogin.Name = "panelSignupLogin";
            panelSignupLogin.Size = new Size(494, 57);
            panelSignupLogin.TabIndex = 2;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.Gray;
            btnSignUp.Location = new Point(269, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(205, 45);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(221, 224, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(79, 105, 236);
            btnLogin.Location = new Point(10, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(205, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(237, 20);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(58, 57);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(51, 51, 51);
            lblWelcome.Location = new Point(174, 82);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(179, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignupLoginForm
            // 
            BackColor = Color.FromArgb(231, 234, 255);
            ClientSize = new Size(1282, 803);
            Controls.Add(panelOuter);
            Name = "SignupLoginForm";
            Padding = new Padding(30);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupLoginForm";
            panelOuter.ResumeLayout(false);
            panelOuter.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelSignup.ResumeLayout(false);
            panelSignup.PerformLayout();
            panelSignupLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOuter;
        private Label lblWelcome;
        private PictureBox pictureBoxLogo;
        private Panel panelSignupLogin;
        private Panel panelSignup;
        private TextBox txtEmailSignup;
        private Label lblEmailSignup;
        private TextBox txtNameSignup;
        private Label lblNameSignup;
        private Label lblPassSignup;
        private TextBox txtConfirmPassSignup;
        private Label lblConfirmPassSignup;
        private TextBox txtPassSignup;
        private Label lblRoleSignup;
        private ComboBox comboBoxRoleSignup;
        private Button btnCreateAccount;
        private RoundedButton btnLogin;
        private RoundedButton btnSignUp;
        private Panel panelLogin;
        private LinkLabel linkLabelForgot;
        private Button btnSignIn;
        private TextBox txtPassLogin;
        private Label lblPassLogin;
        private TextBox txtEmailLogin;
        private Label lblEmailLogin;
        private Label lblWelcometxt;
    }
}