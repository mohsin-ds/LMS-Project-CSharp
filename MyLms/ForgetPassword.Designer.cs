namespace MyLms
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            panelForget = new Panel();
            linkBackToLogin = new LinkLabel();
            btnSendResetLink = new RoundedButton();
            txtEmailForget = new TextBox();
            lblResetPasswordtxt = new Label();
            lblResetPassword = new Label();
            pictureBoxLogo = new PictureBox();
            panelForget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelForget
            // 
            panelForget.BackColor = Color.White;
            panelForget.Controls.Add(linkBackToLogin);
            panelForget.Controls.Add(btnSendResetLink);
            panelForget.Controls.Add(txtEmailForget);
            panelForget.Controls.Add(lblResetPasswordtxt);
            panelForget.Controls.Add(lblResetPassword);
            panelForget.Controls.Add(pictureBoxLogo);
            panelForget.Location = new Point(337, 118);
            panelForget.Margin = new Padding(3, 2, 3, 2);
            panelForget.Name = "panelForget";
            panelForget.Size = new Size(463, 334);
            panelForget.TabIndex = 0;
            // 
            // linkBackToLogin
            // 
            linkBackToLogin.AutoSize = true;
            linkBackToLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            linkBackToLogin.LinkBehavior = LinkBehavior.HoverUnderline;
            linkBackToLogin.Location = new Point(173, 275);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(100, 19);
            linkBackToLogin.TabIndex = 126;
            linkBackToLogin.TabStop = true;
            linkBackToLogin.Text = "Back to Login";
            linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // btnSendResetLink
            // 
            btnSendResetLink.BackColor = Color.FromArgb(79, 70, 229);
            btnSendResetLink.FlatAppearance.BorderSize = 0;
            btnSendResetLink.FlatStyle = FlatStyle.Flat;
            btnSendResetLink.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSendResetLink.ForeColor = Color.White;
            btnSendResetLink.Location = new Point(134, 210);
            btnSendResetLink.Margin = new Padding(3, 2, 3, 2);
            btnSendResetLink.Name = "btnSendResetLink";
            btnSendResetLink.Size = new Size(197, 42);
            btnSendResetLink.TabIndex = 125;
            btnSendResetLink.Text = "Send Reset Link";
            btnSendResetLink.UseVisualStyleBackColor = false;
            btnSendResetLink.Click += btnSendResetLink_Click;
            // 
            // txtEmailForget
            // 
            txtEmailForget.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtEmailForget.ForeColor = Color.Gray;
            txtEmailForget.Location = new Point(31, 159);
            txtEmailForget.Margin = new Padding(3, 2, 3, 2);
            txtEmailForget.Name = "txtEmailForget";
            txtEmailForget.PlaceholderText = "  Email Address";
            txtEmailForget.Size = new Size(404, 27);
            txtEmailForget.TabIndex = 124;
            // 
            // lblResetPasswordtxt
            // 
            lblResetPasswordtxt.AutoSize = true;
            lblResetPasswordtxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResetPasswordtxt.ForeColor = Color.FromArgb(131, 129, 136);
            lblResetPasswordtxt.Location = new Point(93, 113);
            lblResetPasswordtxt.Name = "lblResetPasswordtxt";
            lblResetPasswordtxt.Size = new Size(265, 20);
            lblResetPasswordtxt.TabIndex = 123;
            lblResetPasswordtxt.Text = "Enter your email to receive instructions";
            lblResetPasswordtxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResetPassword
            // 
            lblResetPassword.AutoSize = true;
            lblResetPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResetPassword.ForeColor = Color.FromArgb(51, 51, 51);
            lblResetPassword.Location = new Point(150, 75);
            lblResetPassword.Name = "lblResetPassword";
            lblResetPassword.Size = new Size(149, 25);
            lblResetPassword.TabIndex = 1;
            lblResetPassword.Text = "Reset Password";
            lblResetPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(214, 32);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(35, 25);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 255);
            ClientSize = new Size(1122, 562);
            Controls.Add(panelForget);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ForgetPassword";
            Text = "ForgetPassword";
            panelForget.ResumeLayout(false);
            panelForget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForget;
        private PictureBox pictureBoxLogo;
        private Label lblResetPassword;
        private Label lblResetPasswordtxt;
        private TextBox txtEmailForget;
        private RoundedButton btnSendResetLink;
        private LinkLabel linkBackToLogin;
    }
}