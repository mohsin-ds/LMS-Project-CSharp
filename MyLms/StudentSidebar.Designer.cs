namespace MyLms
{
    partial class StudentSidebar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSidebar));
            btnMyGrades = new RoundedButton();
            btnMyCourses = new RoundedButton();
            labelLine2 = new Label();
            labelLine1 = new Label();
            panelLogout = new Panel();
            pictureBoxPerson = new PictureBox();
            labelUser = new Label();
            lblName = new Label();
            linkLabelLogout = new LinkLabel();
            btnDashboard = new RoundedButton();
            panelTop = new Panel();
            pictureBoxLogo = new PictureBox();
            lblLMS = new Label();
            panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerson).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnMyGrades
            // 
            btnMyGrades.BackColor = Color.Transparent;
            btnMyGrades.FlatAppearance.BorderSize = 0;
            btnMyGrades.FlatStyle = FlatStyle.Flat;
            btnMyGrades.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMyGrades.ForeColor = Color.FromArgb(156, 163, 175);
            btnMyGrades.Location = new Point(34, 259);
            btnMyGrades.Name = "btnMyGrades";
            btnMyGrades.Size = new Size(225, 56);
            btnMyGrades.TabIndex = 6;
            btnMyGrades.Text = "My Grades";
            btnMyGrades.UseVisualStyleBackColor = false;
            btnMyGrades.Click += btnMyGrades_Click;
            // 
            // btnMyCourses
            // 
            btnMyCourses.BackColor = Color.Transparent;
            btnMyCourses.FlatAppearance.BorderSize = 0;
            btnMyCourses.FlatStyle = FlatStyle.Flat;
            btnMyCourses.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMyCourses.ForeColor = Color.FromArgb(156, 163, 175);
            btnMyCourses.Location = new Point(34, 197);
            btnMyCourses.Name = "btnMyCourses";
            btnMyCourses.Size = new Size(225, 56);
            btnMyCourses.TabIndex = 5;
            btnMyCourses.Text = "My Courses";
            btnMyCourses.UseVisualStyleBackColor = false;
            btnMyCourses.Click += btnMyCourses_Click;
            // 
            // labelLine2
            // 
            labelLine2.AutoSize = true;
            labelLine2.Font = new Font("Segoe UI", 10.2F);
            labelLine2.ForeColor = SystemColors.ButtonFace;
            labelLine2.Location = new Point(-4, 557);
            labelLine2.Name = "labelLine2";
            labelLine2.Size = new Size(304, 23);
            labelLine2.TabIndex = 4;
            labelLine2.Text = "__________________________________________";
            // 
            // labelLine1
            // 
            labelLine1.AutoSize = true;
            labelLine1.Font = new Font("Segoe UI", 10.2F);
            labelLine1.ForeColor = SystemColors.ButtonFace;
            labelLine1.Location = new Point(-2, 94);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(304, 23);
            labelLine1.TabIndex = 2;
            labelLine1.Text = "__________________________________________";
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(pictureBoxPerson);
            panelLogout.Controls.Add(labelUser);
            panelLogout.Controls.Add(lblName);
            panelLogout.Controls.Add(linkLabelLogout);
            panelLogout.Dock = DockStyle.Bottom;
            panelLogout.Location = new Point(0, 583);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new Size(300, 169);
            panelLogout.TabIndex = 10;
            // 
            // pictureBoxPerson
            // 
            pictureBoxPerson.BackColor = Color.FromArgb(79, 70, 229);
            pictureBoxPerson.Image = (Image)resources.GetObject("pictureBoxPerson.Image");
            pictureBoxPerson.Location = new Point(12, 17);
            pictureBoxPerson.Name = "pictureBoxPerson";
            pictureBoxPerson.Size = new Size(47, 48);
            pictureBoxPerson.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPerson.TabIndex = 1;
            pictureBoxPerson.TabStop = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 10.2F);
            labelUser.ForeColor = Color.FromArgb(156, 163, 175);
            labelUser.Location = new Point(65, 42);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(69, 23);
            labelUser.TabIndex = 1;
            labelUser.Text = "Student";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(65, 17);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Student Name";
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogout.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabelLogout.LinkColor = Color.Red;
            linkLabelLogout.Location = new Point(91, 109);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(78, 28);
            linkLabelLogout.TabIndex = 1;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.FromArgb(156, 163, 175);
            btnDashboard.Location = new Point(34, 135);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(225, 56);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBoxLogo);
            panelTop.Controls.Add(lblLMS);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(300, 100);
            panelTop.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(79, 70, 229);
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(34, 24);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(58, 57);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // lblLMS
            // 
            lblLMS.AutoSize = true;
            lblLMS.BackColor = Color.FromArgb(31, 41, 55);
            lblLMS.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLMS.ForeColor = Color.White;
            lblLMS.Location = new Point(105, 34);
            lblLMS.Name = "lblLMS";
            lblLMS.Size = new Size(179, 37);
            lblLMS.TabIndex = 2;
            lblLMS.Text = "LMS Student";
            // 
            // StudentSidebar
            // 
            BackColor = Color.FromArgb(31, 41, 55);
            Controls.Add(btnMyGrades);
            Controls.Add(btnMyCourses);
            Controls.Add(labelLine2);
            Controls.Add(labelLine1);
            Controls.Add(panelLogout);
            Controls.Add(btnDashboard);
            Controls.Add(panelTop);
            Name = "StudentSidebar";
            Size = new Size(300, 752);
            panelLogout.ResumeLayout(false);
            panelLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerson).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MyLms.RoundedButton btnMyGrades;
        private MyLms.RoundedButton btnMyCourses;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.PictureBox pictureBoxPerson;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private MyLms.RoundedButton btnDashboard;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblLMS;
    }
}